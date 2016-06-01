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
    public partial class FirstRechargeAddInfo : FengNiao.GameTools.Util.BaseForm
    {
        FengNiao.GMTools.Database.Model.tbl_first_recharge data = new FengNiao.GMTools.Database.Model.tbl_first_recharge();
        FirstRecharge mparent = null;
        public FirstRechargeAddInfo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void SetParent(FirstRecharge parent)
        {
            mparent = parent;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //List<OperationType> operationTypes = new List<OperationType>();
            //List<FengNiao.GMTools.Database.Model.tbl_first_recharge> dataList = new List<FengNiao.GMTools.Database.Model.tbl_first_recharge>();
            int ntemp = 0;
            Color errorColor = Color.Red;
            Color nomalColor = Color.White;
            if (string.IsNullOrEmpty(item_textBox.Text) == null)
            {
                //item_textBox.ForeColor = errorColor;
                CustomMessageBox.Error(this, "商品Id不能为空！");
                return;
            }
            data.itemid = item_textBox.Text.ToString();

            if (string.IsNullOrEmpty(index_textBox.Text) || !int.TryParse(index_textBox.Text, out ntemp))
            {
                //index_textBox.ForeColor = errorColor;
                CustomMessageBox.Error(this, "商品Id不能为空！");
                return;
            }
            data.index = ntemp;

            if (string.IsNullOrEmpty(name_textBox.Text))
            {
                //name_textBox.ForeColor = errorColor;
                CustomMessageBox.Error(this, "名字不能为空！");
                return;
            }
            data.name = name_textBox.Text;

            data.dec = dec_textBox.Text;

            if (string.IsNullOrEmpty(icon_textBox.Text) || !int.TryParse(icon_textBox.Text, out ntemp))
            {
                //icon_textBox.ForeColor = errorColor;
                CustomMessageBox.Error(this, "图标Id不能为空！");
                return;
            }
            data.icon = ntemp;

            if (string.IsNullOrEmpty(RMBprice_textBox.Text) || !int.TryParse(RMBprice_textBox.Text, out ntemp))
            {
                //RMBprice_textBox.ForeColor = errorColor;
                CustomMessageBox.Error(this, "RMB售价不能为空！");
                return;
            }
            data.RMBprice = ntemp;

            data.IsOnlyOnce = isOnlyOnce.Checked ?1:0;

            if (string.IsNullOrEmpty(diamonds_textBox.Text) || !int.TryParse(diamonds_textBox.Text, out ntemp))
            {
                //diamonds_textBox.ForeColor = errorColor;
                CustomMessageBox.Error(this, "给予钻石不能为空！");
                return;
            }
            data.diamonds = ntemp;

            if (string.IsNullOrEmpty(giveDiamond_textBox.Text) || !int.TryParse(giveDiamond_textBox.Text, out ntemp))
            {
                //giveDiamond_textBox.ForeColor = errorColor;
                CustomMessageBox.Error(this, "首充额外赠送钻石不能为空！");
                return;
            }
            data.giveDiamonds = ntemp;

            if (string.IsNullOrEmpty(normalGiveDiamonds_textBox.Text) || !int.TryParse(normalGiveDiamonds_textBox.Text, out ntemp))
            {
                //normalGiveDiamonds_textBox.ForeColor = errorColor;
                CustomMessageBox.Error(this, "非首充常态赠送钻石不能为空！");
                return;
            }
            data.normalGiveDiamonds = ntemp;

            if (string.IsNullOrEmpty(activeGiveDiamonds_textBox.Text) || !int.TryParse(activeGiveDiamonds_textBox.Text, out ntemp))
            {
                //activeGiveDiamonds_textBox.ForeColor = errorColor;
                CustomMessageBox.Error(this, "非首充常态赠送钻石不能为空！");
                return;
            }
            data.activeGiveDiamonds = ntemp;

            string strStartTime = dtStartDate.Value.ToString("yyyy-MM-dd") + " " + dtStartTime.Value.ToString("HH:mm:ss");
            string strStopTime = dtStopDate.Value.ToString("yyyy-MM-dd") + " " + dtStopTime.Value.ToString("HH:mm:ss");

            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Now;
            if (!DateTime.TryParse(strStartTime, out dt1))
            {
                CustomMessageBox.Error(this, "开始生效时间无效");
                return;
            }
            if (!DateTime.TryParse(strStopTime, out dt2))
            {
                CustomMessageBox.Error(this, "生效结束时间无效");
                return;
            }
            if (DateTime.Compare(dt1, dt2) > -1)
            {
                CustomMessageBox.Error(this, "生效结束时间必须大于开始生效时间");
                return;
            }
            data.activeStartTime = dt1;
            data.activeEndTime = dt2;

            data.isWeekCard = isWeekCard.Checked ? 1 : 0;
            data.isMonthCard = isMonthCard.Checked ? 1 : 0;

            data.channel = channel_textBox.Text;

            string status = sellStatc_textBox.Text.ToString().Substring(sellStatc_textBox.Text.ToString().LastIndexOf('-') + 1);
            if (string.IsNullOrEmpty(status) || !int.TryParse(status, out ntemp))
            {
                //sellStatc_textBox.ForeColor = errorColor;
                CustomMessageBox.Error(this, "销售状态不能为空！");
                return;
            }
            data.sellStatc = ntemp;
            if (!string.IsNullOrEmpty(FirstRechargeItem1_textBox.Text))
            {
                if (int.TryParse(FirstRechargeItem1_textBox.Text, out ntemp))
                { 
                    data.FirstRechargeItem1 = ntemp;
                }
            }

            if (!string.IsNullOrEmpty(Num1_textBox.Text))
            {
                if (int.TryParse(Num1_textBox.Text, out ntemp))
                {
                    data.Num1 = ntemp;
                }
            }
            if (!string.IsNullOrEmpty(FirstRechargeItem2_textBox.Text))
            {
                if (int.TryParse(FirstRechargeItem2_textBox.Text, out ntemp))
                {
                    data.FirstRechargeItem2 = ntemp;
                }
            }
            if (!string.IsNullOrEmpty(Num2_textBox.Text))
            {
                if (int.TryParse(Num2_textBox.Text, out ntemp))
                {
                    data.Num2 = ntemp;
                }
            }
            if (!string.IsNullOrEmpty(FirstRechargeItem3_textBox.Text))
            {
                if (int.TryParse(FirstRechargeItem3_textBox.Text, out ntemp))
                {
                    data.FirstRechargeItem3 = ntemp;
                }
            }
            if (!string.IsNullOrEmpty(Num3_textBox.Text))
            {
                if (int.TryParse(Num3_textBox.Text, out ntemp))
                {
                    data.Num3 = ntemp;
                }
            }
            if (!string.IsNullOrEmpty(FirstRechargeItem4_textBox.Text))
            {
                if (int.TryParse(FirstRechargeItem4_textBox.Text, out ntemp))
                {
                    data.FirstRechargeItem4 = ntemp;
                }
            }
            if (!string.IsNullOrEmpty(Num4_textBox.Text))
            {
                if (int.TryParse(Num4_textBox.Text, out ntemp))
                {
                    data.Num4 = ntemp;
                }
            }
            if (!string.IsNullOrEmpty(FirstRechargeItem5_textBox.Text))
            {
                if (int.TryParse(FirstRechargeItem5_textBox.Text, out ntemp))
                {
                    data.FirstRechargeItem5 = ntemp;
                }
            }
            if (!string.IsNullOrEmpty(Num5_textBox.Text))
            {
                if (int.TryParse(Num5_textBox.Text, out ntemp))
                {
                    data.Num5 = ntemp;
                }
            }
            if (!string.IsNullOrEmpty(FirstRechargeItem6_textBox.Text))
            {
                if (int.TryParse(FirstRechargeItem6_textBox.Text, out ntemp))
                {
                    data.FirstRechargeItem6 = ntemp;
                }
            }
            if (!string.IsNullOrEmpty(Num6_textBox.Text))
            {
                if (int.TryParse(Num6_textBox.Text, out ntemp))
                {
                    data.Num6 = ntemp;
                }
            }

            int.TryParse(channel_textBox.Text, out ntemp);

            if(mparent.isCanAdd(ntemp,data.itemid,data.index))
            {
                mparent.AddlocalRowInfo(data);
                Close();
            }
            else
                CustomMessageBox.Error(this, "同一渠道不能存在两个相同的item或index!");

        }
        public FengNiao.GMTools.Database.Model.tbl_first_recharge GetData()
        {
            return data;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            data= null;
            Close();
        }
        private void UpdateCallback(object sender, UploadDataCompletedEventArgs e)
        {
        }

        private void all_Check_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            //if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数
            //if (e.KeyChar > 0x20)
            //{
            //    try
            //    {
            //        double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
            //    }
            //    catch
            //    {
            //        e.KeyChar = (char)0;   //处理非法字符
            //    }
            //}
        }
    }
}
