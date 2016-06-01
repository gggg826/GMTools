namespace GameToolsClient
{
    partial class MainNoticeDetails
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
            this.lbTitle = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tbContent = new System.Windows.Forms.RichTextBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnOpen = new DevComponents.DotNetBar.ButtonX();
            this.btnSaveTemplate = new DevComponents.DotNetBar.ButtonX();
            this.btnColor = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            // 
            // 
            // 
            this.lbTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTitle.Location = new System.Drawing.Point(12, 27);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(150, 23);
            this.lbTitle.TabIndex = 59;
            this.lbTitle.Text = "公告";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::GameToolsClient.Properties.Resources.dialog_cancel_4;
            this.btnCancel.Location = new System.Drawing.Point(333, 437);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 27);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::GameToolsClient.Properties.Resources.document_save_3;
            this.btnSave.Location = new System.Drawing.Point(227, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(16, 85);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(44, 23);
            this.labelX5.TabIndex = 89;
            this.labelX5.Text = "内容：";
            // 
            // tbContent
            // 
            this.tbContent.BackColor = System.Drawing.Color.Black;
            this.tbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbContent.ForeColor = System.Drawing.Color.White;
            this.tbContent.Location = new System.Drawing.Point(56, 89);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(566, 330);
            this.tbContent.TabIndex = 90;
            this.tbContent.Text = "";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(51, 200);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(44, 23);
            this.labelX7.TabIndex = 89;
            this.labelX7.Text = "内容1：";
            // 
            // btnOpen
            // 
            this.btnOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOpen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOpen.Image = global::GameToolsClient.Properties.Resources.folder_open;
            this.btnOpen.Location = new System.Drawing.Point(56, 60);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 23);
            this.btnOpen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOpen.TabIndex = 96;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveTemplate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveTemplate.Image = global::GameToolsClient.Properties.Resources.document_save_5;
            this.btnSaveTemplate.Location = new System.Drawing.Point(85, 60);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(23, 23);
            this.btnSaveTemplate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveTemplate.TabIndex = 95;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // btnColor
            // 
            this.btnColor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnColor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnColor.Image = global::GameToolsClient.Properties.Resources.color_wheel;
            this.btnColor.Location = new System.Drawing.Point(114, 60);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(23, 23);
            this.btnColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnColor.TabIndex = 94;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // MainNoticeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 488);
            this.CloseBox = true;
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTitle);
            this.Name = "MainNoticeDetails";
            this.Controls.SetChildIndex(this.lbTitle, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.tbContent, 0);
            this.Controls.SetChildIndex(this.btnColor, 0);
            this.Controls.SetChildIndex(this.btnSaveTemplate, 0);
            this.Controls.SetChildIndex(this.btnOpen, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbTitle;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.RichTextBox tbContent;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnOpen;
        private DevComponents.DotNetBar.ButtonX btnSaveTemplate;
        private DevComponents.DotNetBar.ButtonX btnColor;
    }
}