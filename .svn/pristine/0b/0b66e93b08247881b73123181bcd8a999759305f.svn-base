using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using System.Text.RegularExpressions;

namespace GameToolsClient
{
    public partial class AddImageSelector : BaseForm
    {
        public AddImageSelector()
        {
            InitializeComponent();
            this.Text = "添加新图片";
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

        private GameToolsClient.GameLoadingImageManager.ImageManagerType managerType;
        public GameToolsClient.GameLoadingImageManager.ImageManagerType ManagerType
        {
            set
            {
                managerType = value;
                if (managerType == GameLoadingImageManager.ImageManagerType.LoadingImage)
                {
                    labelX3.Text = "显示概率(万分比)";
                    tbProbility.Visible = true;
                    cbQuick.Visible = false;
                    tbParam.Visible = false;

                }
                else if (managerType == GameLoadingImageManager.ImageManagerType.DepotWindowImage)
                {
                    labelX3.Text = "快捷方式";
                    tbProbility.Visible = false;
                    cbQuick.Visible = true;
                    tbParam.Visible = true;
                }
            }
            get { return managerType; }
        }

        public string SelectedImage
        {
            get
            {
                return tbImage.Text;
            }
        }

        public DirectoryInfoData SelectedDirectory
        {
            get
            {
                return cbDestinationDirectory.SelectedItem as DirectoryInfoData;
            }
        }

        public string PamramString
        {
            get
            {
                if (ManagerType == GameLoadingImageManager.ImageManagerType.LoadingImage)
                {
                    return tbProbility.Text;
                }
                else
                {
                    return string.Format("{0}|{1}", cbQuick.SelectedValue.ToString(), tbParam.Text);
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbImage.Text = "";
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片|*.jpg;*.png;*.gif";
            //ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbImage.Text = ofd.FileName;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbImage.Text))
            {
                CustomMessageBox.Error(this, "没有选择任何图片");
                return;
            }
            if (string.IsNullOrEmpty(cbDestinationDirectory.Text))
            {
                CustomMessageBox.Error(this, "没有选择存放目录");
                return;
            }
            if (ManagerType == GameLoadingImageManager.ImageManagerType.LoadingImage)
            {
                if (string.IsNullOrEmpty(tbProbility.Text))
                {
                    CustomMessageBox.Error(this, "概率无效,有效概率为万分比");
                    return;
                }

                Match match = Regex.Match(tbProbility.Text, "[^0-9]");
                if (match.Success)
                {
                    CustomMessageBox.Error(this, "概率无效,有效概率为万分比");
                    return;
                }

                int iProbility = int.Parse(tbProbility.Text);
                if (iProbility < 0 || iProbility > 10000)
                {
                    CustomMessageBox.Error(this, "概率无效,有效概率为万分比");
                    return;
                }
            }
            else if (ManagerType == GameLoadingImageManager.ImageManagerType.DepotWindowImage)
            {

            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void AddImageSelector_Load(object sender, EventArgs e)
        {
            cbDestinationDirectory.DataSource = GlobalObject.DirectoryDataList;
            cbDestinationDirectory.DisplayMember = "Title";
            cbDestinationDirectory.ValueMember = "DestinationDirectory";

            cbQuick.DataSource = new BindingSource(GlobalObject.QuickList, null);
            cbQuick.DisplayMember = "Value";
            cbQuick.ValueMember = "Key";

            tbParam.Text = string.Empty;

            if (ManagerType == GameLoadingImageManager.ImageManagerType.DepotWindowImage)
            {
                cbDestinationDirectory.SelectedIndex = 1;
            }
        }
    }
}
