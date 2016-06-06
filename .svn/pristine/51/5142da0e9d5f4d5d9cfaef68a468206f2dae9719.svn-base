using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameToolsCommon;
using GameToolsCommon;
using System.Net;

namespace GameToolsClient
{
    public partial class CheckOutChatHistory : FengNiao.GameTools.Util.BaseForm
    {
        public CheckOutChatHistory()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void InitList(List<FengNiao.GMTools.Database.Model.ChatMessage> dataList)
        {
            gvDataGridView.Rows.Clear();
            foreach (FengNiao.GMTools.Database.Model.ChatMessage item in dataList)
            {
                gvDataGridView.Rows.Add(item.PlayerName, item.Time, item.Message);
            }
        }


        private void GetChatCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                string strContent = Encoding.UTF8.GetString(e.Result);
                ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                if (requestResult.IsSuccess)
                {
                    MesResultModel mesRusultMod= FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<MesResultModel>(requestResult.Content);
                    InitList(GetChatList(mesRusultMod.result));
                }
                else
                {
                    CustomMessageBox.Error(this, string.Format("获取数据失败\r\n{0}", requestResult.Content));
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
        }

        private List<FengNiao.GMTools.Database.Model.ChatMessage> GetChatList(string str)
        {
            string[] strList = str.Split('\n');
            List<FengNiao.GMTools.Database.Model.ChatMessage> list = new List<FengNiao.GMTools.Database.Model.ChatMessage>();
            for (int i = 0; i < strList.Length-1; i++)
            {
                FengNiao.GMTools.Database.Model.ChatMessage message = new FengNiao.GMTools.Database.Model.ChatMessage(strList[i]);
                list.Add(message);
            }
            return list;
        }

        private void CheckOutChatHistory_Load(object sender, EventArgs e)
        {

        }

        private void tbServer_ButtonCustomClick(object sender, EventArgs e)
        {
            ServerManager frmServerManager = new ServerManager();
            frmServerManager.IsSelector = true;
            if (frmServerManager.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbServer.Text = frmServerManager.SelectedServer.fld_server_name;
                tbServer.Tag = frmServerManager.SelectedServer;

            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }

            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.CheckChat, HttpMethodType.Add);
            string strServerIP = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<string>(serverData.fld_server_ip.ToString());
            strArgs = string.Format("{0}&ServerIP={1}", strArgs, strServerIP);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetChatCallback);
        }
    }

    public class MesResultModel
    {
        private int _errorcode;
        private string _result;

        public int errorcode
        {
            get
            {
                return _errorcode;
            }

            set
            {
                _errorcode = value;
            }
        }

        public string result
        {
            get
            {
                return _result;
            }

            set
            {
                _result = value;
            }
        }
    }
}
