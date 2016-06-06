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
    public partial class ChangePassword : BaseForm
    {
        public ChangePassword()
        {
            InitializeComponent();
            this.Text = "密码修改";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMostBox = false;
            this.TitleAlign = TitleAlignment.Left;
            this.Image = Properties.Resources.system_password_2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbOldPassword.Text))
            {
                CustomMessageBox.Error(this, "旧密码不得为空");
                return;
            }
            if (string.IsNullOrEmpty(tbNewPasswrod.Text))
            {
                CustomMessageBox.Error(this, "新密码不得为空");
                return;
            }
            if (string.IsNullOrEmpty(tbNewPassword1.Text))
            {
                CustomMessageBox.Error(this, "新密码确认不得为空");
                return;
            }
            if (tbOldPassword.Text.Length < GlobalObject.PasswrodLength)
            {
                CustomMessageBox.Error(this, string.Format("旧密码长度不得小于{0}位", GlobalObject.PasswrodLength));
                return;
            }
            if (tbNewPasswrod.Text.Length < GlobalObject.PasswrodLength)
            {
                CustomMessageBox.Error(this, string.Format("新密码长度不得小于{0}位", GlobalObject.PasswrodLength));
                return;
            }
            if (!tbNewPasswrod.Text.Equals(tbNewPassword1.Text))
            {
                CustomMessageBox.Error(this, "两次密码不一致");
                return;
            }

            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.User, HttpMethodType.ChangePassword);
            List<HttpInterfaceSqlParameter> requestParamters = new List<HttpInterfaceSqlParameter>();
            strArgs = string.Format("{0}&userID={1}&oldPassword={2}&newPassword={3}", strArgs, GlobalObject.CurrentLoginUserModel.UserID, tbOldPassword.Text, tbNewPasswrod.Text);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, ChangePasswordCallback);
            btnOk.Enabled = false;
        }


        private void ChangePasswordCallback(object sender, UploadDataCompletedEventArgs e)
        {

            if (e.Error == null)
            {
                string strContent = Encoding.UTF8.GetString(e.Result);
                ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                if (requestResult.IsSuccess)
                {
                    CustomMessageBox.Info(this, "修改密码成功，请重新进行登陆");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    CustomMessageBox.Error(this, string.Format("登陆失败\r\n{0}", requestResult.Content));
                }
            }
            else
            {

                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
            btnOk.Enabled = true;
        }
    }
}
