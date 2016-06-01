namespace GameToolsClient
{
    partial class BroadcastChat
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
            this.btnSend = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbContent = new System.Windows.Forms.RichTextBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.gvDataList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.服务器ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.服务器名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.删除 = new System.Windows.Forms.DataGridViewImageColumn();
            this.guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.cbType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnColor = new DevComponents.DotNetBar.ButtonX();
            this.btnSaveTemplate = new DevComponents.DotNetBar.ButtonX();
            this.btnOpen = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSend.Location = new System.Drawing.Point(100, 486);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSend.TabIndex = 60;
            this.btnSend.Text = "发送(&S)";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(17, 104);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(90, 23);
            this.labelX1.TabIndex = 52;
            this.labelX1.Text = "服务器列表：";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(31, 65);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 63;
            this.labelX3.Text = "广播类型：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(31, 261);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 65;
            this.labelX2.Text = "广播内容：";
            // 
            // tbContent
            // 
            this.tbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbContent.Location = new System.Drawing.Point(95, 264);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(284, 203);
            this.tbContent.TabIndex = 66;
            this.tbContent.Text = "";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX5.Location = new System.Drawing.Point(29, 25);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(150, 23);
            this.labelX5.TabIndex = 67;
            this.labelX5.Text = "游戏广播";
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
            this.服务器ID,
            this.服务器名称,
            this.删除,
            this.guid});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDataList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvDataList.EnableHeadersVisualStyles = false;
            this.gvDataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvDataList.Location = new System.Drawing.Point(95, 104);
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
            this.gvDataList.Size = new System.Drawing.Size(284, 124);
            this.gvDataList.TabIndex = 68;
            this.gvDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDataList_CellClick);
            // 
            // 服务器ID
            // 
            this.服务器ID.HeaderText = "服务器ID";
            this.服务器ID.Name = "服务器ID";
            // 
            // 服务器名称
            // 
            this.服务器名称.HeaderText = "服务器名称";
            this.服务器名称.Name = "服务器名称";
            this.服务器名称.Width = 150;
            // 
            // 删除
            // 
            this.删除.FillWeight = 40F;
            this.删除.HeaderText = "";
            this.删除.Image = global::GameToolsClient.Properties.Resources.delete;
            this.删除.Name = "删除";
            this.删除.Width = 20;
            // 
            // guid
            // 
            this.guid.HeaderText = "guid";
            this.guid.Name = "guid";
            this.guid.Visible = false;
            // 
            // btnView
            // 
            this.btnView.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnView.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnView.Location = new System.Drawing.Point(304, 235);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnView.TabIndex = 69;
            this.btnView.Text = "浏览(&V)";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(247, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbType
            // 
            this.cbType.DisplayMember = "Text";
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 15;
            this.cbType.Location = new System.Drawing.Point(95, 65);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(284, 21);
            this.cbType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbType.TabIndex = 71;
            // 
            // btnColor
            // 
            this.btnColor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnColor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnColor.Image = global::GameToolsClient.Properties.Resources.color_wheel;
            this.btnColor.Location = new System.Drawing.Point(153, 234);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(23, 23);
            this.btnColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnColor.TabIndex = 72;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveTemplate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveTemplate.Image = global::GameToolsClient.Properties.Resources.document_save_5;
            this.btnSaveTemplate.Location = new System.Drawing.Point(124, 234);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(23, 23);
            this.btnSaveTemplate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveTemplate.TabIndex = 73;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOpen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOpen.Image = global::GameToolsClient.Properties.Resources.folder_open;
            this.btnOpen.Location = new System.Drawing.Point(95, 234);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 23);
            this.btnOpen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOpen.TabIndex = 74;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // BroadcastChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 529);
            this.CloseBox = true;
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.gvDataList);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.labelX1);
            this.Name = "BroadcastChat";
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.btnSend, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.tbContent, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.gvDataList, 0);
            this.Controls.SetChildIndex(this.btnView, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.cbType, 0);
            this.Controls.SetChildIndex(this.btnColor, 0);
            this.Controls.SetChildIndex(this.btnSaveTemplate, 0);
            this.Controls.SetChildIndex(this.btnOpen, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSend;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.RichTextBox tbContent;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvDataList;
        private System.Windows.Forms.DataGridViewTextBoxColumn 服务器ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 服务器名称;
        private System.Windows.Forms.DataGridViewImageColumn 删除;
        private System.Windows.Forms.DataGridViewTextBoxColumn guid;
        private DevComponents.DotNetBar.ButtonX btnView;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbType;
        private DevComponents.DotNetBar.ButtonX btnColor;
        private DevComponents.DotNetBar.ButtonX btnSaveTemplate;
        private DevComponents.DotNetBar.ButtonX btnOpen;
    }
}