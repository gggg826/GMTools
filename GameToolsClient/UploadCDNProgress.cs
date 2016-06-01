using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using System.IO;

namespace GameToolsClient
{
    public partial class UploadCDNProgress : BaseForm
    {
        public UploadCDNProgress()
        {
            InitializeComponent();
            this.Text = "上传进度";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMostBox = false;
            this.IsShowCaptionImage = false;
            this.IsShowCaptionText = false;
            this.IsTitleSplitLine = false;
            this.Image = Properties.Resources.TK_2icon;
            this.CloseBox = false;
        }

        private List<string> FileList { set; get; }
        public int UploadCompleteCounter = 0;
        public int MaxUploader = 0;
        public string CDNDirectoryName = "CDNData";
        public void AddFile(string strFile)
        {
            if (FileList == null)
            {
                FileList = new List<string>();
            }
            FileList.Add(strFile);
        }

        public void StartUpload()
        {
            UploadCompleteCounter = 0;
            MaxUploader = FileList.Count;
            for (int i = 0; i < FileList.Count; i++)
            {
                string fileName = FileList[i];
                FtpHelper ftpHelper = new FtpHelper(tbServer.Text, tbUserName.Text, tbPwd.Text);
                string name = GetFileName(fileName);
                ftpHelper.Upload(fileName, CDNDirectoryName, name, UpLoadingProgressCallback, UploadCompleteCallback, UploadErrorCallback);
            }
        }


        private void UpLoadingProgressCallback(long length, long currentPos, string fileName)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                this.UpdateProgress(fileName, length, currentPos);
            }));
        }

        private void UploadCompleteCallback(string fileName)
        {
            this.Invoke(new MethodInvoker(delegate()
               {
                   UploadCompleteCounter++;
                   if (MaxUploader == UploadCompleteCounter)
                   {
                       CustomMessageBox.Info(this, "上传完毕");
                       this.UpdateComplete();
                   }
               }));
        }

        private void UploadErrorCallback(string fileName, string errorContent)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                int index = GetProgressGridIndex(fileName);
                if (index == -1)
                {
                    gvDataList.Rows.Add(Guid.NewGuid().ToString(), fileName, errorContent, GameToolsClient.Properties.Resources.edit, GameToolsClient.Properties.Resources.edit);
                }
                else
                {
                    gvDataList.Rows[index].Cells[2].Value = errorContent;
                }
            }));
        }


        public string GetFileName(string imageFullPath)
        {
            FileInfo fi = new FileInfo(imageFullPath);
            return fi.Name;
        }

        public void UpdateProgress(string fileName, long length, long curPos)
        {
            int index = GetProgressGridIndex(fileName);
            if (index == -1)
            {
                gvDataList.Rows.Add(Guid.NewGuid().ToString(), fileName, ((float)curPos / (float)length) * 100f);
            }
            else
            {
                gvDataList.Rows[index].Cells[2].Value = ((float)curPos / (float)length) * 100f;
            }
        }

        public int GetProgressGridIndex(string fileName)
        {
            for (int i = 0; i < gvDataList.RowCount; i++)
            {
                if (gvDataList.Rows[i].Cells[1].Value.ToString().Equals(fileName))
                {
                    return i;
                }
            }
            return -1;
        }

        public void UpdateComplete()
        {
            this.CloseBox = true;
        }

        private void UploadCDNProgress_Load(object sender, EventArgs e)
        {
            panelUser.Visible = true;
        }

        private void btnStartUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbServer.Text))
            {
                CustomMessageBox.Error(this, "CDN服务器地址不能为空");
                return;
            }
            if (string.IsNullOrEmpty(tbUserName.Text))
            {
                CustomMessageBox.Error(this, "用户名不能");
                return;
            }

            if (string.IsNullOrEmpty(tbPwd.Text))
            {
                CustomMessageBox.Error(this, "密码不能");
                return;
            }
            panelUser.Visible = false;
            StartUpload();
        }

        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
                {
                    string fileName = gvDataList.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string name = GetFileName(fileName);
                    string url = string.Empty;
                    if (e.ColumnIndex == 3)
                    {
                        url = "http://qtcdn.yingxiong.com/" + CDNDirectoryName + "/" + name;
                    }
                    else if (e.ColumnIndex == 4)
                    {
                        url = "ftp://" + tbServer.Text + "/" + CDNDirectoryName + "/" + name;
                    }
                    UrlDetails frmUrlDetails = new UrlDetails();
                    frmUrlDetails.Url = url;
                    frmUrlDetails.Left = this.Left;
                    frmUrlDetails.Top = this.Top;
                    frmUrlDetails.ShowDialog();
                }
            }
        }
    }
}
