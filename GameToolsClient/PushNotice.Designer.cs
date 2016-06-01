namespace GameToolsClient
{
    partial class PushNotice
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
            this.btnSend = new DevComponents.DotNetBar.ButtonX();
            this.lbTitle = new DevComponents.DotNetBar.LabelX();
            this.tbTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbContext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSend.Location = new System.Drawing.Point(105, 188);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 33);
            this.btnSend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSend.TabIndex = 53;
            this.btnSend.Text = "发送";
            this.btnSend.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTitle
            // 
            // 
            // 
            // 
            this.lbTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTitle.Location = new System.Drawing.Point(40, 57);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(57, 23);
            this.lbTitle.TabIndex = 43;
            this.lbTitle.Text = "标题：";
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbTitle.Border.Class = "TextBoxBorder";
            this.tbTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTitle.ForeColor = System.Drawing.Color.Black;
            this.tbTitle.Location = new System.Drawing.Point(103, 57);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(112, 48);
            this.tbTitle.TabIndex = 44;
            // 
            // tbContext
            // 
            this.tbContext.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbContext.Border.Class = "TextBoxBorder";
            this.tbContext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbContext.ForeColor = System.Drawing.Color.Black;
            this.tbContext.Location = new System.Drawing.Point(103, 111);
            this.tbContext.Multiline = true;
            this.tbContext.Name = "tbContext";
            this.tbContext.Size = new System.Drawing.Size(112, 59);
            this.tbContext.TabIndex = 44;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(40, 111);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 43;
            this.labelX1.Text = "标题：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX2.Location = new System.Drawing.Point(105, 19);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 23);
            this.labelX2.TabIndex = 43;
            this.labelX2.Text = "通知推送";
            // 
            // PushNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.CloseBox = true;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tbContext);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbTitle);
            this.IsShowCaptionImage = false;
            this.IsShowCaptionText = false;
            this.IsTitleSplitLine = false;
            this.Name = "PushNotice";
            this.Controls.SetChildIndex(this.tbTitle, 0);
            this.Controls.SetChildIndex(this.lbTitle, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.tbContext, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.btnSend, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSend;
        private DevComponents.DotNetBar.LabelX lbTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContext;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}
