namespace GameToolsClient
{
    partial class AddImageSelector
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbDestinationDirectory = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.tbImage = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tbProbility = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbQuick = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tbParam = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(66, 58);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 23);
            this.labelX1.TabIndex = 44;
            this.labelX1.Text = "图片列表";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(67, 101);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(64, 23);
            this.labelX2.TabIndex = 79;
            this.labelX2.Text = "存放目录";
            // 
            // cbDestinationDirectory
            // 
            this.cbDestinationDirectory.DisplayMember = "Text";
            this.cbDestinationDirectory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDestinationDirectory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinationDirectory.FormattingEnabled = true;
            this.cbDestinationDirectory.ItemHeight = 15;
            this.cbDestinationDirectory.Location = new System.Drawing.Point(126, 101);
            this.cbDestinationDirectory.Name = "cbDestinationDirectory";
            this.cbDestinationDirectory.Size = new System.Drawing.Size(294, 21);
            this.cbDestinationDirectory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbDestinationDirectory.TabIndex = 80;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX11.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX11.Location = new System.Drawing.Point(20, 27);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(150, 23);
            this.labelX11.TabIndex = 81;
            this.labelX11.Text = "添加新图片";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::GameToolsClient.Properties.Resources.document_save_5;
            this.btnSave.Location = new System.Drawing.Point(126, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 28);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 82;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::GameToolsClient.Properties.Resources.dialog_cancel_3;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnCancel.Location = new System.Drawing.Point(256, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 28);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 83;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbImage
            // 
            this.tbImage.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbImage.Border.Class = "TextBoxBorder";
            this.tbImage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbImage.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbImage.ButtonCustom.Visible = true;
            this.tbImage.ButtonCustom2.Image = global::GameToolsClient.Properties.Resources.edit_clear_2;
            this.tbImage.ButtonCustom2.Visible = true;
            this.tbImage.ForeColor = System.Drawing.Color.Black;
            this.tbImage.Location = new System.Drawing.Point(126, 59);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(294, 22);
            this.tbImage.TabIndex = 85;
            this.tbImage.ButtonCustomClick += new System.EventHandler(this.btnAddImage_Click);
            this.tbImage.ButtonCustom2Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(22, 139);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(104, 23);
            this.labelX3.TabIndex = 86;
            this.labelX3.Text = "显示概率(万分比)";
            // 
            // tbProbility
            // 
            this.tbProbility.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbProbility.Border.Class = "TextBoxBorder";
            this.tbProbility.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbProbility.ForeColor = System.Drawing.Color.Black;
            this.tbProbility.Location = new System.Drawing.Point(126, 139);
            this.tbProbility.Name = "tbProbility";
            this.tbProbility.Size = new System.Drawing.Size(294, 21);
            this.tbProbility.TabIndex = 87;
            // 
            // cbQuick
            // 
            this.cbQuick.DisplayMember = "Text";
            this.cbQuick.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbQuick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuick.FormattingEnabled = true;
            this.cbQuick.ItemHeight = 15;
            this.cbQuick.Location = new System.Drawing.Point(126, 139);
            this.cbQuick.Name = "cbQuick";
            this.cbQuick.Size = new System.Drawing.Size(294, 21);
            this.cbQuick.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbQuick.TabIndex = 88;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(80, 164);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(40, 23);
            this.labelX4.TabIndex = 89;
            this.labelX4.Text = "Param";
            // 
            // tbParam
            // 
            this.tbParam.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbParam.Border.Class = "TextBoxBorder";
            this.tbParam.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbParam.ForeColor = System.Drawing.Color.Black;
            this.tbParam.Location = new System.Drawing.Point(126, 166);
            this.tbParam.Name = "tbParam";
            this.tbParam.Size = new System.Drawing.Size(294, 21);
            this.tbParam.TabIndex = 90;
            // 
            // AddImageSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 256);
            this.CloseBox = true;
            this.Controls.Add(this.tbParam);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.cbQuick);
            this.Controls.Add(this.tbProbility);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.cbDestinationDirectory);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "AddImageSelector";
            this.Load += new System.EventHandler(this.AddImageSelector_Load);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.cbDestinationDirectory, 0);
            this.Controls.SetChildIndex(this.labelX11, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.tbImage, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.tbProbility, 0);
            this.Controls.SetChildIndex(this.cbQuick, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.tbParam, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbDestinationDirectory;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX tbImage;
        private DevComponents.DotNetBar.Controls.TextBoxX tbProbility;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbQuick;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX tbParam;
    }
}