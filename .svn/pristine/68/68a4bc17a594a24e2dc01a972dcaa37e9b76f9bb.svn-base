using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using System.Reflection;
using System.Text.RegularExpressions;
using FengNiao.GameToolsCommon;
using System.Net;
using GameToolsCommon;

namespace GameToolsClient
{
    public partial class GiftCodeDetails : BaseForm
    {
        public GiftCodeDetails()
        {
            InitializeComponent();
            this.TopMostBox = false;
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TitleAlign = TitleAlignment.Left;
            this.Image = Properties.Resources.TK_2icon;
            this.Text = "礼包码生成";
            this.dtStartDate.Value = DateTime.Now;
            this.dtExpiretimeDate.Value = DateTime.Now.AddYears(1);
        }

        private void tbGiftPackage_DoubleClick(object sender, EventArgs e)
        {
            GiftPackageManager frmGiftPackageManager = new GiftPackageManager();
            frmGiftPackageManager.IsPackageSelector = true;
            if (frmGiftPackageManager.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbGiftPackage.Text = "";
                FengNiao.GMTools.Database.Model.tbl_gift_package giftPackageData = frmGiftPackageManager.SelectedPackage;
                if (giftPackageData != null)
                {
                    tbGiftPackage.AppendText("ID:" + giftPackageData.fld_id.ToString() + "\r\n");
                    tbGiftPackage.AppendText((giftPackageData.fld_lock_device == 1 ? "每个设备不可重复领取" : "每个设备可重复领取") + "\r\n");
                    if (giftPackageData.fld_title != null)
                    {
                        tbGiftPackage.AppendText("标题:" + giftPackageData.fld_title.ToString() + "\r\n");
                    }
                    if (giftPackageData.fld_content != null)
                    {
                        tbGiftPackage.AppendText("内容:" + giftPackageData.fld_content.ToString() + "\r\n");
                    }

                    for (int i = 0; i < 20; i++)
                    {
                        PropertyInfo itemIDPropertyInfo = giftPackageData.GetType().GetProperty(string.Format("fld_itemid{0}", (i + 1)));
                        if (itemIDPropertyInfo != null)
                        {
                            PropertyInfo itemCountPropertyInfo = giftPackageData.GetType().GetProperty(string.Format("fld_itemcount{0}", (i + 1)));
                            object itemIDObj = itemIDPropertyInfo.GetValue(giftPackageData, null);
                            object itemCountObj = itemCountPropertyInfo.GetValue(giftPackageData, null);
                            if (itemIDObj != null)
                            {
                                string strItem = string.Empty;
                                FengNiao.GMTools.Database.Model.tbl_item item = GlobalObject.GetGiftPackageItem((int)itemIDObj);
                                if (item != null)
                                {
                                    strItem = string.Format("道具{0}_{1}_{2}*{3}", (i + 1), item.item_id, item.name, itemCountObj);
                                }
                                else
                                {
                                    strItem = string.Format("道具{0}_{1}_{2}*{3}", (i + 1), itemIDObj, "未知物品", itemCountObj);
                                }
                                if (!string.IsNullOrEmpty(strItem))
                                {
                                    tbGiftPackage.AppendText(strItem + "\r\n");
                                }
                            }
                        }
                    }

                    if (giftPackageData.fld_desc != null)
                    {
                        tbGiftPackage.AppendText("描述:" + giftPackageData.fld_desc.ToString() + "\r\n");
                    }
                    tbGiftPackage.AppendText(giftPackageData.fld_deleted == 0 ? "礼包已启用" : "礼包未启用");
                }
                tbGiftPackage.Tag = giftPackageData;
            }
        }

        private void tbChannel_DoubleClick(object sender, EventArgs e)
        {
            PackageManager frmPackageManager = new PackageManager();
            frmPackageManager.IsSelector = true;
            if (frmPackageManager.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbChannel.Text = frmPackageManager.SelectedPackage.fld_declare;
                tbChannel.Tag = frmPackageManager.SelectedPackage;
            }
        }

        private void tbChannel_ButtonCustomClick(object sender, EventArgs e)
        {
            tbChannel.Tag = null;
            tbChannel.Text = "";
        }

        private void btnGenGiftCode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbGiftCodeCount.Text))
            {
                CustomMessageBox.Error(this, "礼包码数量无效");
                return;
            }
            if (Regex.IsMatch(tbGiftCodeCount.Text, "[^0-9]"))
            {
                CustomMessageBox.Error(this, "礼包码数量无效");
                return;
            }
            FengNiao.GMTools.Database.Model.tbl_gift_package giftPackageData = tbGiftPackage.Tag as FengNiao.GMTools.Database.Model.tbl_gift_package;
            if (giftPackageData == null)
            {
                CustomMessageBox.Error(this, "没有选择礼包");
                return;
            }


            DateTime starttime = DateTime.Parse(dtStartDate.Value.ToString("yyyy-MM-dd") + " " + dtStartTime.Value.ToString("HH:mm:ss"));
            DateTime expiretime = DateTime.Parse(dtExpiretimeDate.Value.ToString("yyyy-MM-dd") + " " + dtExpiretimeTime.Value.ToString("HH:mm:ss"));
            if (DateTime.Compare(starttime, expiretime) > -1)
            {
                CustomMessageBox.Error(this, "过期时间必须大于生效时间");
                return;
            }
            FengNiao.GMTools.Database.Model.tbl_package channelData = tbChannel.Tag as FengNiao.GMTools.Database.Model.tbl_package;

            int multiuse = cbMultiUse.Checked ? 1 : 0;

            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.GiftCode, HttpMethodType.Add);
            strArgs = string.Format("{0}&GiftCodeCount={1}&GiftPackageID={2}&StartTime={3}&ExpiretimeTime={4}&MultiUse={5}", strArgs, tbGiftCodeCount.Text, giftPackageData.fld_id, starttime.ToString("yyyy-MM-dd HH:mm:ss"), expiretime.ToString("yyyy-MM-dd HH:mm:ss"), multiuse);
            if (channelData != null)
            {
                strArgs = string.Format("{0}&Channel={1}", strArgs, channelData.fld_package_number);
            }

            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GenGiftCodeCallback);
        }

        private void GenGiftCodeCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        List<string> giftCodes = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<string>(requestResultModel.Content);
                        CustomMessageBox.Info(this, "生成完毕,即将为你打开礼包码预览");
                        GiftCodeView frmGiftCodeView = new GiftCodeView();
                        frmGiftCodeView.GiftCodes = giftCodes;
                        frmGiftCodeView.ShowDialog();

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
