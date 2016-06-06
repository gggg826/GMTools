using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using FengNiao.GameToolsCommon;
using GameToolsCommon;
using System.Net;

namespace GameToolsClient
{
    public partial class UserDetails : BaseForm
    {
        public UserDetails()
        {
            InitializeComponent();
            this.TopMostBox = false;
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TitleAlign = TitleAlignment.Left;
            this.Image = Properties.Resources.TK_2icon;
        }

        public UserDetails(FengNiao.GMTools.Database.Model.tbl_user userData)
            : this()
        {
            this.UserData = userData;
            tbUserName.ReadOnly = true;
            UserDetailsType = DetailsType.Edit;
            tbUserName.Text = userData.user_name;
            int authority = userData.authority == null ? 0 : userData.authority.Value;
            cbGiftPackage.Checked = GlobalObject.GetBitValue((uint)authority, 1);
            cbGiftCode.Checked = GlobalObject.GetBitValue((uint)authority, 2);
            cbServerConfig.Checked = GlobalObject.GetBitValue((uint)authority, 3);
            cbItemImport.Checked = GlobalObject.GetBitValue((uint)authority, 4);
            cbGameNotice.Checked = GlobalObject.GetBitValue((uint)authority, 5);
            cbUserManager.Checked = GlobalObject.GetBitValue((uint)authority, 6);
            cbRoleQuery.Checked = GlobalObject.GetBitValue((uint)authority, 7);
            cbMail.Checked = GlobalObject.GetBitValue((uint)authority, 8);
            cbNotice.Checked = GlobalObject.GetBitValue((uint)authority, 9);
            cbLockUser.Checked = GlobalObject.GetBitValue((uint)authority, 10);
            cbActivity.Checked = GlobalObject.GetBitValue((uint)authority, 11);
            cbImportActivity.Checked = GlobalObject.GetBitValue((uint)authority, 12);
            cbLoading.Checked = GlobalObject.GetBitValue((uint)authority, 13);
            cbDepotAd.Checked = GlobalObject.GetBitValue((uint)authority, 14);
            cbRecommend.Checked = GlobalObject.GetBitValue((uint)authority, 15);
            cbIsLogin.Checked = Convert.ToBoolean(userData.is_enabled == null ? 0 : userData.is_enabled);

        }

        private DetailsType userDetailsType;
        public DetailsType UserDetailsType
        {
            set
            {
                userDetailsType = value;
                switch (value)
                {
                    case DetailsType.New:
                        this.Text = "添加用户";
                        break;
                    case DetailsType.Edit:
                        this.Text = "编辑用户";
                        break;
                }
            }
        }

        private FengNiao.GMTools.Database.Model.tbl_user UserData;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (userDetailsType == DetailsType.New && string.IsNullOrEmpty(tbUserName.Text))
            {
                CustomMessageBox.Error(this, "用户名不能为空");
                return;
            }
            if (userDetailsType == DetailsType.New && string.IsNullOrEmpty(tbPassword.Text))
            {
                CustomMessageBox.Error(this, "密码不能为空");
                return;
            }
            if (userDetailsType == DetailsType.New && tbPassword.Text.Length < GlobalObject.PasswrodLength)
            {
                CustomMessageBox.Error(this, string.Format("密码不能小于{0}位", GlobalObject.PasswrodLength));
                return;
            }
            if (userDetailsType == DetailsType.New)
            {
                NewUser();
            }
            else if (userDetailsType == DetailsType.Edit)
            {
                SaveUser();
            }
        }

        private void NewUser()
        {
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.User, HttpMethodType.GetCount);
            List<HttpInterfaceSqlParameter> requestParamters = new List<HttpInterfaceSqlParameter>();
            requestParamters.Add(new HttpInterfaceSqlParameter("user_name", tbUserName.Text, SqlCompareType.Equal));
            string strParamter = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<HttpInterfaceSqlParameter>>(requestParamters);
            strArgs = string.Format("{0}&Parameter={1}", strArgs, strParamter);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetCountCallback);
        }



        private void GetCountCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                string strContent = Encoding.UTF8.GetString(e.Result);
                ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                if (requestResult.IsSuccess)
                {
                    int recordCount = 0;
                    if (int.TryParse(requestResult.Content, out recordCount))
                    {
                        if (recordCount > 0)
                        {
                            CustomMessageBox.Error(this, "已经存在该用户");
                        }
                        else
                        {
                            SaveUser();
                        }
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("保存数据失败\r\n{0}", requestResult.Content));
                    }
                }
                else
                {
                    CustomMessageBox.Error(this, string.Format("保存数据失败\r\n{0}", requestResult.Content));
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
        }

        private void SaveUser()
        {
            List<OperationType> operationTypes = new List<OperationType>();
            List<FengNiao.GMTools.Database.Model.tbl_user> dataList = new List<FengNiao.GMTools.Database.Model.tbl_user>();
            List<string> guidList = new List<string>();
            FengNiao.GMTools.Database.Model.tbl_user data = new FengNiao.GMTools.Database.Model.tbl_user();
            if (userDetailsType == DetailsType.Edit)
            {
                data.user_id = UserData.user_id;
                data.user_name = UserData.user_name;
                if (!string.IsNullOrEmpty(tbPassword.Text))
                {
                    if (tbPassword.Text.Length < 6)
                    {
                        CustomMessageBox.Error(this, "密码不能小于6位");
                        return;
                    }
                    data.password = FengNiao.GameToolsCommon.MD5.GetMD5String(tbPassword.Text);
                }
                else
                {
                    data.password = UserData.password;
                }
                operationTypes.Add(OperationType.Update);
            }
            else if (userDetailsType == DetailsType.New)
            {
                operationTypes.Add(OperationType.Add);
                data.user_name = tbUserName.Text;
                data.password = FengNiao.GameToolsCommon.MD5.GetMD5String(tbPassword.Text);
            }

            uint iAuthority = 0;
            GlobalObject.SetBitValue(ref iAuthority, cbGiftPackage.Checked, 1);
            GlobalObject.SetBitValue(ref iAuthority, cbGiftCode.Checked, 2);
            GlobalObject.SetBitValue(ref iAuthority, cbServerConfig.Checked, 3);
            GlobalObject.SetBitValue(ref iAuthority, cbItemImport.Checked, 4);
            GlobalObject.SetBitValue(ref iAuthority, cbGameNotice.Checked, 5);
            GlobalObject.SetBitValue(ref iAuthority, cbUserManager.Checked, 6);
            GlobalObject.SetBitValue(ref iAuthority, cbRoleQuery.Checked, 7);
            GlobalObject.SetBitValue(ref iAuthority, cbMail.Checked, 8);
            GlobalObject.SetBitValue(ref iAuthority, cbNotice.Checked, 9);
            GlobalObject.SetBitValue(ref iAuthority, cbLockUser.Checked, 10);
            GlobalObject.SetBitValue(ref iAuthority, cbActivity.Checked, 11);
            GlobalObject.SetBitValue(ref iAuthority, cbImportActivity.Checked, 12);
            GlobalObject.SetBitValue(ref iAuthority, cbLoading.Checked, 13);
            GlobalObject.SetBitValue(ref iAuthority, cbDepotAd.Checked, 14);
            GlobalObject.SetBitValue(ref iAuthority, cbRecommend.Checked, 15);

            data.authority = (int)iAuthority;
            data.is_enabled = Convert.ToInt32(cbIsLogin.Checked);
            dataList.Add(data);

            guidList.Add(Guid.NewGuid().ToString());
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.User, HttpMethodType.Update);
            string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_user>>(dataList);
            string strOperationTypes = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<OperationType>>(operationTypes);
            string strGuids = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(guidList);
            strArgs = string.Format("{0}&Model={1}&OperationType={2}&guid={3}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8), strOperationTypes, strGuids);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, UpdateCallback);
        }

        private void UpdateCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        List<OperateResultModel> resultModelList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<OperateResultModel>(requestResultModel.Content);
                        CustomMessageBox.Info(this, "保存完毕");
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("保存失败\r\n{0}", requestResultModel.Content));
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


    }
}
