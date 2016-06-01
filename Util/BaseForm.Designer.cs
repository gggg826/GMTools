using FengNiao.GameTools.Util;
namespace FengNiao.GameTools.Util
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.pbTitleCaption = new System.Windows.Forms.Label();
            this.pbTitleImage = new System.Windows.Forms.PictureBox();
            this.btnPin = new FengNiao.GameTools.Util.CustomButton();
            this.btnMin = new FengNiao.GameTools.Util.CustomButton();
            this.btnMax = new FengNiao.GameTools.Util.CustomButton();
            this.btnClose = new FengNiao.GameTools.Util.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTitleCaption
            // 
            this.pbTitleCaption.AutoSize = true;
            this.pbTitleCaption.Location = new System.Drawing.Point(109, 14);
            this.pbTitleCaption.Name = "pbTitleCaption";
            this.pbTitleCaption.Size = new System.Drawing.Size(53, 12);
            this.pbTitleCaption.TabIndex = 39;
            this.pbTitleCaption.Text = "动作选择";
            this.pbTitleCaption.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseDoubleClick);
            this.pbTitleCaption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbTitleCaption_MouseMove);
            // 
            // pbTitleImage
            // 
            this.pbTitleImage.Image = ((System.Drawing.Image)(resources.GetObject("pbTitleImage.Image")));
            this.pbTitleImage.Location = new System.Drawing.Point(79, 8);
            this.pbTitleImage.Name = "pbTitleImage";
            this.pbTitleImage.Size = new System.Drawing.Size(24, 24);
            this.pbTitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTitleImage.TabIndex = 38;
            this.pbTitleImage.TabStop = false;
            this.pbTitleImage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseDoubleClick);
            this.pbTitleImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbTitleImage_MouseMove);
            // 
            // btnPin
            // 
            this.btnPin.buttonBackGroudColor = System.Drawing.Color.Empty;
            this.btnPin.caption = null;
            this.btnPin.image = global::Util.Properties.Resource.pik;
            this.btnPin.imageSize = new System.Drawing.Size(0, 0);
            this.btnPin.Location = new System.Drawing.Point(189, 4);
            this.btnPin.mouseDownImage = null;
            this.btnPin.mouseEnterImage = null;
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(27, 28);
            this.btnPin.TabIndex = 42;
            this.btnPin.TextTips = null;
            // 
            // btnMin
            // 
            this.btnMin.buttonBackGroudColor = System.Drawing.Color.Empty;
            this.btnMin.caption = null;
            this.btnMin.image = global::Util.Properties.Resource.min;
            this.btnMin.imageSize = new System.Drawing.Size(0, 0);
            this.btnMin.Location = new System.Drawing.Point(212, 6);
            this.btnMin.mouseDownImage = null;
            this.btnMin.mouseEnterImage = null;
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(26, 23);
            this.btnMin.TabIndex = 41;
            this.btnMin.TextTips = null;
            this.btnMin.Visible = false;
            // 
            // btnMax
            // 
            this.btnMax.buttonBackGroudColor = System.Drawing.Color.Empty;
            this.btnMax.caption = null;
            this.btnMax.image = global::Util.Properties.Resource.max;
            this.btnMax.imageSize = new System.Drawing.Size(0, 0);
            this.btnMax.Location = new System.Drawing.Point(231, 6);
            this.btnMax.mouseDownImage = null;
            this.btnMax.mouseEnterImage = null;
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(26, 23);
            this.btnMax.TabIndex = 40;
            this.btnMax.TextTips = null;
            this.btnMax.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.buttonBackGroudColor = System.Drawing.Color.Empty;
            this.btnClose.caption = null;
            this.btnClose.image = global::Util.Properties.Resource.close;
            this.btnClose.imageSize = new System.Drawing.Size(0, 0);
            this.btnClose.Location = new System.Drawing.Point(253, 6);
            this.btnClose.mouseDownImage = null;
            this.btnClose.mouseEnterImage = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 37;
            this.btnClose.TextTips = null;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.pbTitleCaption);
            this.Controls.Add(this.pbTitleImage);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitleImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pbTitleCaption;
        private CustomButton btnClose;
        private CustomButton btnMax;
        private CustomButton btnMin;
        private CustomButton btnPin;
        private System.Windows.Forms.PictureBox pbTitleImage;
    }
}