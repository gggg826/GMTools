using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;

namespace GameToolsClient
{
    public partial class LauncherMain : BaseForm
    {
        public LauncherMain()
        {
            InitializeComponent();
            this.Text = "GM管理工具";
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.IsAcceptResize = true;
            //this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.TopMostBox = false;
            this.IsShowCaptionImage = false;
            this.IsShowCaptionText = false;
            this.IsTitleSplitLine = false;
        }

        private void mtiPackage_Click(object sender, EventArgs e)
        {
            this.Hide();
            PackageManager frmPackageManager = new PackageManager();
            frmPackageManager.ShowDialog();
            this.Show();
        }

        private void mtiServerGroup_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServerGroupManager frmServerGroupManager = new ServerGroupManager();
            frmServerGroupManager.ShowDialog();
            this.Show();
        }

        private void mtiSds_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServerManager frmServerManager = new ServerManager();
            frmServerManager.ShowDialog();
            this.Show();
        }

        private void mtiNotice_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoticeManager frmNoticeManager = new NoticeManager();
            frmNoticeManager.ShowDialog();
            this.Show();
        }

        private void mtiTestDevice_Click(object sender, EventArgs e)
        {
            this.Hide();
            TesterDeviceManager frmTesterDeviceManager = new TesterDeviceManager();
            frmTesterDeviceManager.ShowDialog();
            this.Show();
        }

        private void mtiDevice_Click(object sender, EventArgs e)
        {
            this.Hide();
            PackageUpgradeManager frmPackageUpgradeManager = new PackageUpgradeManager();
            frmPackageUpgradeManager.ShowDialog();
            this.Show();
        }

        private void mtiRunState_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResourceUpgradeManager frmResourceUpgradeManager = new ResourceUpgradeManager();
            frmResourceUpgradeManager.ManagerType = ResourceUpgradeManager.ResourceManagerType.ResourceManager;
            frmResourceUpgradeManager.ShowDialog();
            this.Show();
        }
    }
}
