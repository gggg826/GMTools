namespace GameToolsClient
{
    partial class LoginRewardDetail
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbCount1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbKind = new System.Windows.Forms.ComboBox();
            this.tbServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.date = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.tbReward2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.tbCount2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.tbReward3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.tbCount3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.tbReward4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.tbCount4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tbReward1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(19, 107);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(77, 23);
            this.labelX1.TabIndex = 50;
            this.labelX1.Text = "奖励道具1：";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tbCount1
            // 
            this.tbCount1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbCount1.Border.Class = "TextBoxBorder";
            this.tbCount1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCount1.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbCount1.ForeColor = System.Drawing.Color.Black;
            this.tbCount1.Location = new System.Drawing.Point(237, 107);
            this.tbCount1.Name = "tbCount1";
            this.tbCount1.Size = new System.Drawing.Size(50, 21);
            this.tbCount1.TabIndex = 59;
            this.tbCount1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_Check_KeyPress);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(192, 107);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(42, 23);
            this.labelX2.TabIndex = 60;
            this.labelX2.Text = "数量：";
            // 
            // tbKind
            // 
            this.tbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbKind.FormattingEnabled = true;
            this.tbKind.Items.AddRange(new object[] {
            "0",
            "1"});
            this.tbKind.Location = new System.Drawing.Point(236, 82);
            this.tbKind.Name = "tbKind";
            this.tbKind.Size = new System.Drawing.Size(50, 20);
            this.tbKind.TabIndex = 87;
            // 
            // tbServer
            // 
            this.tbServer.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbServer.Border.Class = "TextBoxBorder";
            this.tbServer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbServer.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbServer.ForeColor = System.Drawing.Color.Black;
            this.tbServer.Location = new System.Drawing.Point(101, 53);
            this.tbServer.Name = "tbServer";
            this.tbServer.ReadOnly = true;
            this.tbServer.Size = new System.Drawing.Size(81, 21);
            this.tbServer.TabIndex = 59;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(26, 55);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(58, 23);
            this.labelX9.TabIndex = 60;
            this.labelX9.Text = "服务器：";
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.date.Border.Class = "TextBoxBorder";
            this.date.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.Location = new System.Drawing.Point(101, 81);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(59, 21);
            this.date.TabIndex = 59;
            this.date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_Check_KeyPress);
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(26, 81);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(69, 23);
            this.labelX10.TabIndex = 60;
            this.labelX10.Text = "时间(天):";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(170, 82);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(75, 23);
            this.labelX11.TabIndex = 88;
            this.labelX11.Text = "奖励类型：";
            // 
            // tbReward2
            // 
            this.tbReward2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbReward2.Border.Class = "TextBoxBorder";
            this.tbReward2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbReward2.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbReward2.ForeColor = System.Drawing.Color.Black;
            this.tbReward2.Location = new System.Drawing.Point(100, 134);
            this.tbReward2.Name = "tbReward2";
            this.tbReward2.Size = new System.Drawing.Size(59, 21);
            this.tbReward2.TabIndex = 59;
            this.tbReward2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_Check_KeyPress);
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(19, 134);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(77, 23);
            this.labelX12.TabIndex = 50;
            this.labelX12.Text = "奖励道具1：";
            this.labelX12.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tbCount2
            // 
            this.tbCount2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbCount2.Border.Class = "TextBoxBorder";
            this.tbCount2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCount2.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbCount2.ForeColor = System.Drawing.Color.Black;
            this.tbCount2.Location = new System.Drawing.Point(237, 134);
            this.tbCount2.Name = "tbCount2";
            this.tbCount2.Size = new System.Drawing.Size(50, 21);
            this.tbCount2.TabIndex = 59;
            this.tbCount2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_Check_KeyPress);
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(192, 134);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(42, 23);
            this.labelX13.TabIndex = 60;
            this.labelX13.Text = "数量：";
            // 
            // tbReward3
            // 
            this.tbReward3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbReward3.Border.Class = "TextBoxBorder";
            this.tbReward3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbReward3.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbReward3.ForeColor = System.Drawing.Color.Black;
            this.tbReward3.Location = new System.Drawing.Point(100, 161);
            this.tbReward3.Name = "tbReward3";
            this.tbReward3.Size = new System.Drawing.Size(59, 21);
            this.tbReward3.TabIndex = 59;
            this.tbReward3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_Check_KeyPress);
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(19, 161);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(77, 23);
            this.labelX14.TabIndex = 50;
            this.labelX14.Text = "奖励道具1：";
            this.labelX14.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tbCount3
            // 
            this.tbCount3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbCount3.Border.Class = "TextBoxBorder";
            this.tbCount3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCount3.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbCount3.ForeColor = System.Drawing.Color.Black;
            this.tbCount3.Location = new System.Drawing.Point(237, 161);
            this.tbCount3.Name = "tbCount3";
            this.tbCount3.Size = new System.Drawing.Size(50, 21);
            this.tbCount3.TabIndex = 59;
            this.tbCount3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_Check_KeyPress);
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(192, 161);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(42, 23);
            this.labelX15.TabIndex = 60;
            this.labelX15.Text = "数量：";
            // 
            // tbReward4
            // 
            this.tbReward4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbReward4.Border.Class = "TextBoxBorder";
            this.tbReward4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbReward4.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbReward4.ForeColor = System.Drawing.Color.Black;
            this.tbReward4.Location = new System.Drawing.Point(100, 188);
            this.tbReward4.Name = "tbReward4";
            this.tbReward4.Size = new System.Drawing.Size(59, 21);
            this.tbReward4.TabIndex = 59;
            this.tbReward4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_Check_KeyPress);
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(19, 188);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(77, 23);
            this.labelX16.TabIndex = 50;
            this.labelX16.Text = "奖励道具1：";
            this.labelX16.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tbCount4
            // 
            this.tbCount4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbCount4.Border.Class = "TextBoxBorder";
            this.tbCount4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCount4.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbCount4.ForeColor = System.Drawing.Color.Black;
            this.tbCount4.Location = new System.Drawing.Point(237, 188);
            this.tbCount4.Name = "tbCount4";
            this.tbCount4.Size = new System.Drawing.Size(50, 21);
            this.tbCount4.TabIndex = 59;
            this.tbCount4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_Check_KeyPress);
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(192, 188);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(42, 23);
            this.labelX17.TabIndex = 60;
            this.labelX17.Text = "数量：";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonX1.Image = global::GameToolsClient.Properties.Resources.dialog_cancel_4;
            this.buttonX1.Location = new System.Drawing.Point(183, 228);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(100, 27);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 72;
            this.buttonX1.Text = "取消(&C)";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::GameToolsClient.Properties.Resources.document_save_3;
            this.buttonX2.Location = new System.Drawing.Point(41, 228);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(100, 27);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 71;
            this.buttonX2.Text = "保存(&S)";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX3.Location = new System.Drawing.Point(57, 16);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(177, 23);
            this.labelX3.TabIndex = 58;
            this.labelX3.Text = "累计登录奖励配置";
            // 
            // tbReward1
            // 
            this.tbReward1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbReward1.Border.Class = "TextBoxBorder";
            this.tbReward1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbReward1.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbReward1.ForeColor = System.Drawing.Color.Black;
            this.tbReward1.Location = new System.Drawing.Point(100, 107);
            this.tbReward1.Name = "tbReward1";
            this.tbReward1.Size = new System.Drawing.Size(59, 21);
            this.tbReward1.TabIndex = 59;
            this.tbReward1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_Check_KeyPress);
            // 
            // LoginRewardDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(314, 280);
            this.CloseBox = true;
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.tbKind);
            this.Controls.Add(this.labelX17);
            this.Controls.Add(this.labelX15);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tbCount4);
            this.Controls.Add(this.tbCount3);
            this.Controls.Add(this.tbCount2);
            this.Controls.Add(this.tbCount1);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX16);
            this.Controls.Add(this.tbReward1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.tbReward4);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.tbReward3);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.tbReward2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX11);
            this.IsShowCaptionImage = false;
            this.IsShowCaptionText = false;
            this.IsTitleSplitLine = false;
            this.Name = "LoginRewardDetail";
            this.Controls.SetChildIndex(this.labelX11, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.tbReward2, 0);
            this.Controls.SetChildIndex(this.tbServer, 0);
            this.Controls.SetChildIndex(this.tbReward3, 0);
            this.Controls.SetChildIndex(this.labelX12, 0);
            this.Controls.SetChildIndex(this.tbReward4, 0);
            this.Controls.SetChildIndex(this.labelX9, 0);
            this.Controls.SetChildIndex(this.labelX14, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.date, 0);
            this.Controls.SetChildIndex(this.tbReward1, 0);
            this.Controls.SetChildIndex(this.labelX16, 0);
            this.Controls.SetChildIndex(this.labelX10, 0);
            this.Controls.SetChildIndex(this.tbCount1, 0);
            this.Controls.SetChildIndex(this.tbCount2, 0);
            this.Controls.SetChildIndex(this.tbCount3, 0);
            this.Controls.SetChildIndex(this.tbCount4, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.labelX13, 0);
            this.Controls.SetChildIndex(this.labelX15, 0);
            this.Controls.SetChildIndex(this.labelX17, 0);
            this.Controls.SetChildIndex(this.tbKind, 0);
            this.Controls.SetChildIndex(this.buttonX2, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbTitle;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCount1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ComboBox tbKind;
        private DevComponents.DotNetBar.Controls.TextBoxX tbServer;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX date;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX tbReward2;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCount2;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.TextBoxX tbReward3;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCount3;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.Controls.TextBoxX tbReward4;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCount4;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbReward1;
    }
}
