using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using FengNiao.GameToolsCommon;
using System.Net;
using GameToolsCommon;

namespace GameToolsClient
{
    public partial class UserManager : BaseForm
    {
        public UserManager()
        {
            InitializeComponent();
            this.Text = "用户管理";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.TopMostBox = false;
            this.TitleAlign = TitleAlignment.Left;
            loadingControl.Dock = DockStyle.Fill;
            loadingControl.Visible = false;
            this.Image = Properties.Resources.TK_2icon;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RefreshLayout();
        }

        private void RefreshLayout()
        {
            if (this.IsHandleCreated && gvDataList.IsHandleCreated)
            {
                panelParent.Left = base.ClientBounds.X;
                panelParent.Top = base.ClientBounds.Y;
                panelParent.Width = base.ClientBounds.Width;
                panelParent.Height = base.ClientBounds.Height;
            }
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            RefreshLayout();
            InitList();
        }

        private void InitList()
        {
            loadingControl.Visible = true;
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.User, HttpMethodType.GetList);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
        }

        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_user> dataList)
        {
            gvDataList.Rows.Clear();
            foreach (FengNiao.GMTools.Database.Model.tbl_user data in dataList)
            {
                int rowIndex = gvDataList.Rows.Add(data.user_id, data.user_name);
                gvDataList.Rows[rowIndex].Cells[2].Value = "***";
                gvDataList.Rows[rowIndex].Cells[2].Tag = data.password;
                int authority = data.authority == null ? 0 : data.authority.Value;
                gvDataList.Rows[rowIndex].Cells[3].Value = GlobalObject.GetAuthorityText((uint)authority);
                gvDataList.Rows[rowIndex].Cells[3].Tag = authority;
                gvDataList.Rows[rowIndex].Cells[4].Value = data.is_enabled == 1 ? "允许" : "禁止";
                gvDataList.Rows[rowIndex].Tag = data;
                gvDataList.Rows[rowIndex].Cells[7].Value = Guid.NewGuid();
            }
        }


        private void GetListCallback(object sender, UploadDataCompletedEventArgs e)
        {
            loadingControl.Visible = false;
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        List<FengNiao.GMTools.Database.Model.tbl_user> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_user>(requestResult.Content);
                        GlobalObject.UserList = dataList;
                        InitList(GlobalObject.UserList);
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("获取数据失败\r\n{0}", requestResult.Content));
                    }
                }
                catch
                {
                    CustomMessageBox.Error(this, "服务器返回的数据无效");
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UserDetails frmUserDetails = new UserDetails();
            frmUserDetails.UserDetailsType = DetailsType.New;
            if (frmUserDetails.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitList();
            }
        }

        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > (gvDataList.RowCount - 1) || e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 5)
            {
                FengNiao.GMTools.Database.Model.tbl_user data = gvDataList.Rows[e.RowIndex].Tag as FengNiao.GMTools.Database.Model.tbl_user;
                if (data != null)
                {
                    UserDetails frmUserDetails = new UserDetails(data);
                    if (frmUserDetails.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        InitList();
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitList();
        }
    }
}
