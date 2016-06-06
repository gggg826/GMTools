using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using System.IO;
using FengNiao.GameToolsCommon;
using GameToolsCommon;
using System.Net;

namespace GameToolsClient
{
    public partial class Config : BaseForm
    {
        public Config()
        {
            InitializeComponent();
            this.Text = "管理工具设置";
            this.TopMostBox = false;
            //this.IsShowCaptionImage = false;
            //this.IsShowCaptionText = false;
            //this.IsTitleSplitLine = false;
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TitleAlign = TitleAlignment.Left;
            this.Image = Properties.Resources.TK_2icon;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(Runpath.AppPath + "system.config"))
                {
                    using (FileStream fs = File.Open(Runpath.AppPath + "system.config", FileMode.Create))
                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                        {
                            sw.Write("<?xml version=\"1.0\"?>\r\n" +
                                "<config>\r\n" +
                                  "<serverIP></serverIP>\r\n" +
                                  "</config>"
                                );
                        }
                    }
                }

                XmlConfig xmlConfig = new XmlConfig(Runpath.AppPath + "system.config");
                xmlConfig.SetXmlReader("config", "serverIP", tbServerAddress.Text);
                xmlConfig.XMLSave();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch
            {
                CustomMessageBox.Error(this, "写入配置文件出错");
            }
        }

        private void btnTesting_Click(object sender, EventArgs e)
        {
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Tester, HttpMethodType.Testing);
            try
            {
                CustomWebRequest.Request(tbServerAddress.Text, strArgs, Encoding.UTF8, TestingCallback);
                btnTesting.Enabled = false;
            }
            catch
            {
                CustomMessageBox.Error(this, "地址无效");
            }
        }

        private void TestingCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                string strContent = Encoding.UTF8.GetString(e.Result);
                ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                if (requestResult.IsSuccess)
                {
                    CustomMessageBox.Info(this, "接口测试成功");
                }
            }
            else
            {
                CustomMessageBox.Error(this, "测试失败，请确认服务器是否正确，并确认当前机器联网状态");
            }
            btnTesting.Enabled = true;
        }

        private void Config_Load(object sender, EventArgs e)
        {

        }
    }
}
