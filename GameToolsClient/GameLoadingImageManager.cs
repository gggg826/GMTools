using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using System.IO;
using System.Net;

namespace GameToolsClient
{
    public partial class GameLoadingImageManager : BaseForm
    {
        public enum ImageManagerType
        {
            LoadingImage,
            DepotWindowImage
        }
        public GameLoadingImageManager()
        {
            InitializeComponent();
            this.Text = "loading界面图片管理";
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
        }
        private ImageManagerType managerType;
        public ImageManagerType ManagerType
        {
            set
            {
                managerType = value;
                if (managerType == ImageManagerType.LoadingImage)
                {
                    lbTitle.Text = "loading界面图片管理";
                    dataGridViewTextBoxColumn3.HeaderText = "显示概率";
                }
                else if (managerType == ImageManagerType.DepotWindowImage)
                {
                    lbTitle.Text = "大厅弹窗图片管理";
                    dataGridViewTextBoxColumn3.HeaderText = "快捷方式";
                }
            }
            get { return managerType; }
        }

        private void tbPackageName_ButtonCustomClick(object sender, EventArgs e)
        {
            tbPackageName.Text = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            AddImageSelector frmAddImageSelector = new AddImageSelector();
            frmAddImageSelector.ManagerType = this.managerType;
            if (frmAddImageSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedImage = frmAddImageSelector.SelectedImage;
                DirectoryInfoData selectedDirectory = frmAddImageSelector.SelectedDirectory;
                string paramString = frmAddImageSelector.PamramString;
                if (!string.IsNullOrEmpty(selectedImage) && selectedDirectory != null && !IsContainsImage(selectedImage))
                {
                    int rowIndex = gvDataList.Rows.Add(Guid.NewGuid().ToString(),
                        selectedImage,
                        paramString,
                        selectedDirectory.Title,
                        GameToolsClient.Properties.Resources.delete);
                    gvDataList.Rows[rowIndex].Tag = selectedDirectory;
                }
            }
        }

        public bool IsContainsImage(string image)
        {
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                if (gvDataList.Rows[i].Cells[1].Value != null && gvDataList.Rows[i].Cells[1].Value.ToString().Equals(image))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string cndFullName = string.Empty;
        private string dataFullName = string.Empty;


        private string GetConfigFileName()
        {
            if (managerType == ImageManagerType.LoadingImage)
            {
                return "loadingconfig.txt";
            }
            else if (managerType == ImageManagerType.DepotWindowImage)
            {
                return "depotnoticeconfig.txt";
            }
            return "";
        }

        private void btnCreateCDN_Click(object sender, EventArgs e)
        {
            this.cndFullName = "";
            this.dataFullName = "";
            if (string.IsNullOrEmpty(tbPackageName.Text))
            {
                CustomMessageBox.Error(this, "打包文件名无效");
                return;
            }
            //if (gvDataList.RowCount < 1)
            //{
            //    CustomMessageBox.Error(this, "没有添加任何要打包的图片");
            //    return;
            //}
            List<string> imageNameList = GetImageList();
            byte[] manifestDatas = GenManifest();
            byte[] configDatas = GetImageConfig();
            Dictionary<string, byte[]> datas = new Dictionary<string, byte[]>();
            datas.Add("Manifest.txt", manifestDatas);
            datas.Add(GetConfigFileName(), configDatas);
            byte[] bytes = CDNHelper.EncodeCDNFiles(imageNameList, datas);
            string cdnPackageName = tbPackageName.Text;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string cndFullName = fbd.SelectedPath + "\\" + cdnPackageName + ".txt";
                string dataFullName = fbd.SelectedPath + "\\" + cdnPackageName + ".zip";
                using (FileStream fs = File.Open(dataFullName, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
                string md5Hash = GlobalObject.GetMd5Hash(dataFullName);
                using (FileStream fs = File.Open(cndFullName, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        string content = string.Empty;
                        content += "md5Hash=" + md5Hash + "\r\n";
                        content += "dataFileName=" + cdnPackageName + ".zip" + "\r\n";
                        sw.Write(content);
                    }
                }
                this.cndFullName = cndFullName;
                this.dataFullName = dataFullName;
                CustomMessageBox.Info(this, "生成成功");
            }
        }


        public byte[] GenManifest()
        {
            StringBuilder manifest = new StringBuilder();
            var loadingconfigDirectory = ManagerType == ImageManagerType.DepotWindowImage ? GlobalObject.DirectoryDataList[1].DestinationDirectory : GlobalObject.DirectoryDataList[0].DestinationDirectory;
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                string imageName = gvDataList.Rows[i].Cells[1].Value.ToString();
                imageName = GetImageName(imageName);
                DirectoryInfoData directoryData = gvDataList.Rows[i].Tag as DirectoryInfoData;
                if (directoryData != null)
                {
                    loadingconfigDirectory = directoryData.DestinationDirectory;
                    string strDirectory = directoryData.DestinationDirectory;
                    manifest.Append(imageName + "|" + strDirectory + (i == gvDataList.Rows.Count - 1 ? "" : "\r\n"));
                }
            }
            manifest.Insert(0, GetConfigFileName() + "|" + loadingconfigDirectory + "\r\n");
            byte[] bytes = Encoding.UTF8.GetBytes(manifest.ToString());
            return bytes;
        }

        public byte[] GetImageConfig()
        {
            string loadingConfig = string.Empty;
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                string imageName = gvDataList.Rows[i].Cells[1].Value.ToString();
                imageName = GetImageName(imageName);
                string probility = gvDataList.Rows[i].Cells[2].Value.ToString();
                loadingConfig += imageName + "|" + probility + (i == gvDataList.Rows.Count - 1 ? "" : "\r\n");
            }
            byte[] bytes = Encoding.UTF8.GetBytes(loadingConfig);
            return bytes;
        }

        public List<string> GetImageList()
        {
            List<string> imageList = new List<string>();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                string imageName = gvDataList.Rows[i].Cells[1].Value.ToString();
                imageList.Add(imageName);
            }
            return imageList;
        }

        public string GetImageName(string imageFullPath)
        {
            FileInfo fi = new FileInfo(imageFullPath);
            return fi.Name;
        }
        UploadCDNProgress frmUploadCDNProgress = null;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cndFullName))
            {
                CustomMessageBox.Error(this, "没有生成CDN数据");
                return;
            }
            if (string.IsNullOrEmpty(dataFullName))
            {
                CustomMessageBox.Error(this, "没有生成CDN数据");
                return;
            }
            frmUploadCDNProgress = new UploadCDNProgress();
            frmUploadCDNProgress.AddFile(cndFullName);
            frmUploadCDNProgress.AddFile(dataFullName);
            frmUploadCDNProgress.ShowDialog();

        }

        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 4)
                {
                    gvDataList.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
