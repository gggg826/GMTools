namespace GameToolsClient
{
    partial class GiftPackageDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new DevComponents.DotNetBar.LabelX();
            this.tbTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbContent = new DevComponents.DotNetBar.LabelX();
            this.tbContent = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lbDesc = new DevComponents.DotNetBar.LabelX();
            this.tbDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbEnabled = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lbEnabled = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.gvDataList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new DevComponents.DotNetBar.ButtonX();
            this.lbLock = new DevComponents.DotNetBar.LabelX();
            this.cbLock = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            // 
            // 
            // 
            this.lbTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTitle.Location = new System.Drawing.Point(29, 60);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(56, 23);
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
            this.tbTitle.Location = new System.Drawing.Point(92, 60);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(291, 21);
            this.tbTitle.TabIndex = 44;
            // 
            // lbContent
            // 
            // 
            // 
            // 
            this.lbContent.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbContent.Location = new System.Drawing.Point(29, 103);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(56, 23);
            this.lbContent.TabIndex = 45;
            this.lbContent.Text = "内容：";
            // 
            // tbContent
            // 
            this.tbContent.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbContent.Border.Class = "TextBoxBorder";
            this.tbContent.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbContent.ForeColor = System.Drawing.Color.Black;
            this.tbContent.Location = new System.Drawing.Point(91, 103);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(291, 63);
            this.tbContent.TabIndex = 46;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 190);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(73, 23);
            this.labelX3.TabIndex = 47;
            this.labelX3.Text = "物品列表：";
            // 
            // lbDesc
            // 
            // 
            // 
            // 
            this.lbDesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDesc.Location = new System.Drawing.Point(29, 352);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(56, 23);
            this.lbDesc.TabIndex = 49;
            this.lbDesc.Text = "描述：";
            // 
            // tbDesc
            // 
            this.tbDesc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbDesc.Border.Class = "TextBoxBorder";
            this.tbDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDesc.ForeColor = System.Drawing.Color.Black;
            this.tbDesc.Location = new System.Drawing.Point(91, 352);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(291, 63);
            this.tbDesc.TabIndex = 50;
            // 
            // cbEnabled
            // 
            // 
            // 
            // 
            this.cbEnabled.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbEnabled.Checked = true;
            this.cbEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnabled.CheckValue = "Y";
            this.cbEnabled.Location = new System.Drawing.Point(248, 433);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(18, 23);
            this.cbEnabled.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbEnabled.TabIndex = 51;
            // 
            // lbEnabled
            // 
            // 
            // 
            // 
            this.lbEnabled.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbEnabled.Location = new System.Drawing.Point(177, 434);
            this.lbEnabled.Name = "lbEnabled";
            this.lbEnabled.Size = new System.Drawing.Size(68, 23);
            this.lbEnabled.TabIndex = 52;
            this.lbEnabled.Text = "是否启用：";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::GameToolsClient.Properties.Resources.document_save_3;
            this.btnSave.Location = new System.Drawing.Point(92, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 33);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::GameToolsClient.Properties.Resources.dialog_cancel_4;
            this.btnCancel.Location = new System.Drawing.Point(236, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gvDataList
            // 
            this.gvDataList.AllowUserToAddRows = false;
            this.gvDataList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvDataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDataList.BackgroundColor = System.Drawing.Color.White;
            this.gvDataList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.index,
            this.物品,
            this.数量});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDataList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvDataList.EnableHeadersVisualStyles = false;
            this.gvDataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gvDataList.Location = new System.Drawing.Point(91, 190);
            this.gvDataList.Name = "gvDataList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvDataList.RowHeadersVisible = false;
            this.gvDataList.RowTemplate.Height = 23;
            this.gvDataList.Size = new System.Drawing.Size(291, 114);
            this.gvDataList.TabIndex = 48;
            this.gvDataList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDataList_CellEndEdit);
            this.gvDataList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvDataList_RowsAdded);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // index
            // 
            this.index.HeaderText = "序号";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 55;
            // 
            // 物品
            // 
            this.物品.HeaderText = "物品";
            this.物品.Name = "物品";
            this.物品.ReadOnly = true;
            this.物品.Width = 130;
            // 
            // 数量
            // 
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.Width = 55;
            // 
            // btnView
            // 
            this.btnView.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnView.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnView.Image = global::GameToolsClient.Properties.Resources.edit;
            this.btnView.Location = new System.Drawing.Point(305, 310);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(77, 30);
            this.btnView.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnView.TabIndex = 55;
            this.btnView.Text = "浏览(&V)";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lbLock
            // 
            // 
            // 
            // 
            this.lbLock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbLock.Location = new System.Drawing.Point(29, 434);
            this.lbLock.Name = "lbLock";
            this.lbLock.Size = new System.Drawing.Size(118, 23);
            this.lbLock.TabIndex = 57;
            this.lbLock.Text = "一个设备领取一次：";
            // 
            // cbLock
            // 
            // 
            // 
            // 
            this.cbLock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbLock.Checked = true;
            this.cbLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLock.CheckValue = "Y";
            this.cbLock.Location = new System.Drawing.Point(148, 434);
            this.cbLock.Name = "cbLock";
            this.cbLock.Size = new System.Drawing.Size(18, 23);
            this.cbLock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLock.TabIndex = 56;
            // 
            // GiftPackageDetails
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(420, 522);
            this.CloseBox = true;
            this.Controls.Add(this.lbLock);
            this.Controls.Add(this.cbLock);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbEnabled);
            this.Controls.Add(this.cbEnabled);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.gvDataList);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lbTitle);
            this.Name = "GiftPackageDetails";
            this.Load += new System.EventHandler(this.GiftPackageDetails_Load);
            this.Controls.SetChildIndex(this.lbTitle, 0);
            this.Controls.SetChildIndex(this.tbTitle, 0);
            this.Controls.SetChildIndex(this.lbContent, 0);
            this.Controls.SetChildIndex(this.tbContent, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.gvDataList, 0);
            this.Controls.SetChildIndex(this.lbDesc, 0);
            this.Controls.SetChildIndex(this.tbDesc, 0);
            this.Controls.SetChildIndex(this.cbEnabled, 0);
            this.Controls.SetChildIndex(this.lbEnabled, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnView, 0);
            this.Controls.SetChildIndex(this.cbLock, 0);
            this.Controls.SetChildIndex(this.lbLock, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContent;
        private DevComponents.DotNetBar.LabelX lbContent;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lbDesc;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDesc;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbEnabled;
        private DevComponents.DotNetBar.LabelX lbEnabled;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvDataList;
        private DevComponents.DotNetBar.ButtonX btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private DevComponents.DotNetBar.LabelX lbLock;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbLock;
    }
}