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
    public partial class Main : BaseForm
    {
        public Main()
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
            this.Image = Properties.Resources.TK_2icon;
        }

        bool isGotoLogin = false;


        void frmLauncherMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void mtiGiftPackage_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiftPackageManager frmGiftPackage = new GiftPackageManager();
            frmGiftPackage.ShowDialog();
            this.Show();
        }

        private void mtiItemManager_Click(object sender, EventArgs e)
        {
            ItemManager frmItemManager = new ItemManager();
            frmItemManager.ShowDialog();
        }

        private void mtiGiftCode_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiftCodeManager frmGiftCodeManager = new GiftCodeManager();
            frmGiftCodeManager.ShowDialog();
            this.Show();
        }

        private void mtiUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManager frmUserManager = new UserManager();
            frmUserManager.ShowDialog();
            this.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            lbLoginUser.Text = GlobalObject.CurrentLoginUserModel.UserName;
            uint authority = GlobalObject.CurrentLoginUserModel.Authority;
            mtiGiftPackage.Visible = GlobalObject.GetBitValue(authority, 1);
            mtiGiftCode.Visible = GlobalObject.GetBitValue(authority, 2);
            mtiServerMange.Visible = GlobalObject.GetBitValue(authority, 3);
            mtiItemManager.Visible = GlobalObject.GetBitValue(authority, 4);
            mtiNoticeBroadcast.Visible = GlobalObject.GetBitValue(authority, 5);
            mtiUser.Visible = GlobalObject.GetBitValue(authority, 6);
            mtiRoleQuery.Visible = GlobalObject.GetBitValue(authority, 7);
            mtiMail.Visible = GlobalObject.GetBitValue(authority, 8);
            mtiMainNotice.Visible = GlobalObject.GetBitValue(authority, 9);
            mtiNotice.Visible = GlobalObject.GetBitValue(authority, 9);
            mtiRollingNotice.Visible = GlobalObject.GetBitValue(authority, 9);
            mtiRoleLock.Visible = GlobalObject.GetBitValue(authority, 10);
            mtiActivityManager.Visible = GlobalObject.GetBitValue(authority, 11);
            mtiActivityImport.Visible = GlobalObject.GetBitValue(authority, 12);
            mtiLoadingManager.Visible = GlobalObject.GetBitValue(authority, 13);
            mtiDepotAdImage.Visible = GlobalObject.GetBitValue(authority, 14);
            mtiDepotAd.Visible = GlobalObject.GetBitValue(authority, 14);
            mtiActivityEdit.Visible = GlobalObject.GetBitValue(authority, 14);
            mtiFirstRechargeManager.Visible = GlobalObject.GetBitValue(authority, 13);
            mtiFirstRecharge.Visible = GlobalObject.GetBitValue(authority, 13);
            mtiRecommendManager.Visible = GlobalObject.GetBitValue(authority, 15);

        }

        private void GotoLogin()
        {
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.User, HttpMethodType.Quit);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, QuitCallback);
        }

        private void QuitCallback(object sender, UploadDataCompletedEventArgs e)
        {
            isGotoLogin = true;
            GlobalObject.CurrentLoginUserModel = null;
            this.Hide();
            GlobalObject.frmLogin.Show();
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Confirm(this, "是否要退出登陆？") == System.Windows.Forms.DialogResult.Yes)
            {
                GotoLogin();
            }
        }

        private void tiChangePasswrod_Click(object sender, EventArgs e)
        {
            ChangePassword frmChangePassword = new ChangePassword();
            if (frmChangePassword.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GotoLogin();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isGotoLogin)
            {
                GlobalObject.frmLogin.Close();
            }
        }

        private void mtiRoleQuery_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryRole frmQueryRole = new QueryRole();
            frmQueryRole.ShowDialog();
            this.Show();
        }

        private void mtiNoticeBroadcast_Click(object sender, EventArgs e)
        {
            this.Hide();
            BroadcastChat frmBroadcastChat = new BroadcastChat();
            frmBroadcastChat.ShowDialog();
            this.Show();
        }

        private void mtiServerMange_Click(object sender, EventArgs e)
        {
            this.Hide();
            LauncherMain frmLauncherMain = new LauncherMain();
            frmLauncherMain.ShowDialog();
            this.Show();
        }

        private void mtiMail_Click(object sender, EventArgs e)
        {
            this.Hide();
            MailManager frmMail = new MailManager();
            frmMail.ShowDialog();
            this.Show();
        }

        private void mtiRoleLock_Click(object sender, EventArgs e)
        {
            this.Hide();
            LockRoleManager frmLockRoleManager = new LockRoleManager();
            frmLockRoleManager.ShowDialog();
            this.Show();
        }

        private void btiActivityImport_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityImport frmActivityImport = new ActivityImport();
            frmActivityImport.ShowDialog();
            this.Show();
        }
        
        private void mtiActivityManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityManager frmActivityManager = new ActivityManager();
            frmActivityManager.ShowDialog();
            this.Show();
        }
        private void mtiFirstRecharge_Click(object sender, EventArgs e)
        { 
            this.Hide();
            FirstRecharge frmFirstRecharge = new FirstRecharge();
            frmFirstRecharge.ShowDialog();
            this.Show();
        }
        private void mtiFirstRechargeManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstRechargeManager frmFirstRechargeManager = new FirstRechargeManager();
            frmFirstRechargeManager.ShowDialog();
            this.Show();
        }
        private void mtiNotice_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoticeConfigManager frmNoticeConfigManager = new NoticeConfigManager();
            frmNoticeConfigManager.ShowDialog();
            this.Show();
        }

        private void mtiLoadingManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameLoadingImageManager frmGameLoadingImageMangager = new GameLoadingImageManager();
            frmGameLoadingImageMangager.ManagerType = GameLoadingImageManager.ImageManagerType.LoadingImage;
            frmGameLoadingImageMangager.ShowDialog();
            this.Show();
        }

        private void mtiWindowImageManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameLoadingImageManager frmGameLoadingImageMangager = new GameLoadingImageManager();
            frmGameLoadingImageMangager.ManagerType = GameLoadingImageManager.ImageManagerType.DepotWindowImage;
            frmGameLoadingImageMangager.ShowDialog();
            this.Show();
        }

        private void mtiRollingNotice_Click(object sender, EventArgs e)
        {
            this.Hide();
            RollingNoticeConfigManager frmNoticeConfigManager = new RollingNoticeConfigManager();
            frmNoticeConfigManager.ShowDialog();
            this.Show();
        }

        private void mtiMainNotice_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoticeManager frmNoticeManager = new NoticeManager();
            frmNoticeManager.ShowDialog();
            this.Show();
        }

        private void mtiDepotAd_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResourceUpgradeManager frmResourceUpgradeManager = new ResourceUpgradeManager();
            frmResourceUpgradeManager.ManagerType = ResourceUpgradeManager.ResourceManagerType.DepotAdManager;
            frmResourceUpgradeManager.ShowDialog();
            this.Show();
        }

        private void mtiRecommendManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecommendManager frmRecommendManager = new RecommendManager();
            frmRecommendManager.ShowDialog();
            this.Show();
        }

        private void mtiLoginRewards_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginRewardsManager frmLoginRewardsManager = new LoginRewardsManager();
            frmLoginRewardsManager.ShowDialog();
            this.Show();
        }

        private void mtiSuccessionReward_Click(object sender, EventArgs e)
        {
            this.Hide();
            SucessionRewardsManager frmLoginRewardsManager = new SucessionRewardsManager();
            frmLoginRewardsManager.ShowDialog();
            this.Show();
        }


        private void mtiCounts_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountManagers frmLoginRewardsManager = new CountManagers();
            frmLoginRewardsManager.ShowDialog();
            this.Show();
        }

        private void mtiPush_Click(object sender, EventArgs e)
        {
            this.Hide();
            PushNotice frmPushNotice = new PushNotice();
            frmPushNotice.ShowDialog();
            this.Show();
        }
    }
}
