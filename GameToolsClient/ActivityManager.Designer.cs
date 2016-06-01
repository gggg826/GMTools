namespace GameToolsClient
{
    partial class ActivityManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelParent = new System.Windows.Forms.Panel();
            this.gvDataList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.活动ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.活动名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否开启活动 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开始时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selected = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnImportAll = new DevComponents.DotNetBar.ButtonX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.panelParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelParent
            // 
            this.panelParent.Controls.Add(this.gvDataList);
            this.panelParent.Controls.Add(this.panel2);
            this.panelParent.Controls.Add(this.panel1);
            this.panelParent.Location = new System.Drawing.Point(6, 43);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(1075, 564);
            this.panelParent.TabIndex = 53;
            // 
            // gvDataList
            // 
            this.gvDataList.AllowUserToAddRows = false;
            this.gvDataList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvDataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvDataList.BackgroundColor = System.Drawing.Color.White;
            this.gvDataList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.活动ID,
            this.活动名称,
            this.是否开启活动,
            this.开始时间,
            this.结束时间,
            this.edit,
            this.guid,
            this.selected});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDataList.DefaultCellStyle = dataGridViewCellStyle7;
            this.gvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDataList.EnableHeadersVisualStyles = false;
            this.gvDataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvDataList.Location = new System.Drawing.Point(0, 54);
            this.gvDataList.Name = "gvDataList";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvDataList.RowHeadersVisible = false;
            this.gvDataList.RowTemplate.Height = 23;
            this.gvDataList.Size = new System.Drawing.Size(1075, 510);
            this.gvDataList.TabIndex = 43;
            this.gvDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDataList_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // 活动ID
            // 
            this.活动ID.HeaderText = "活动ID";
            this.活动ID.Name = "活动ID";
            this.活动ID.ReadOnly = true;
            // 
            // 活动名称
            // 
            this.活动名称.HeaderText = "活动名称";
            this.活动名称.Name = "活动名称";
            this.活动名称.ReadOnly = true;
            this.活动名称.Width = 150;
            // 
            // 是否开启活动
            // 
            this.是否开启活动.HeaderText = "是否开启活动";
            this.是否开启活动.Name = "是否开启活动";
            this.是否开启活动.ReadOnly = true;
            this.是否开启活动.Width = 150;
            // 
            // 开始时间
            // 
            this.开始时间.HeaderText = "开始时间";
            this.开始时间.Name = "开始时间";
            this.开始时间.ReadOnly = true;
            this.开始时间.Width = 150;
            // 
            // 结束时间
            // 
            this.结束时间.HeaderText = "结束时间";
            this.结束时间.Name = "结束时间";
            this.结束时间.ReadOnly = true;
            this.结束时间.Width = 150;
            // 
            // edit
            // 
            this.edit.FillWeight = 40F;
            this.edit.HeaderText = "";
            this.edit.Image = global::GameToolsClient.Properties.Resources.edit;
            this.edit.Name = "edit";
            this.edit.Width = 20;
            // 
            // guid
            // 
            this.guid.HeaderText = "guid";
            this.guid.Name = "guid";
            this.guid.Visible = false;
            // 
            // selected
            // 
            this.selected.HeaderText = "";
            this.selected.Image = global::GameToolsClient.Properties.Resources.dialog_ok_apply_5;
            this.selected.Name = "selected";
            this.selected.Visible = false;
            this.selected.Width = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImportAll);
            this.panel2.Controls.Add(this.btnQuery);
            this.panel2.Controls.Add(this.tbServer);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 44);
            this.panel2.TabIndex = 45;
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
            this.tbServer.ButtonCustom.Visible = true;
            this.tbServer.ForeColor = System.Drawing.Color.Black;
            this.tbServer.Location = new System.Drawing.Point(70, 12);
            this.tbServer.Name = "tbServer";
            this.tbServer.ReadOnly = true;
            this.tbServer.Size = new System.Drawing.Size(220, 22);
            this.tbServer.TabIndex = 53;
            this.tbServer.ButtonCustomClick += new System.EventHandler(this.tbServer_ButtonCustomClick);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(17, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 23);
            this.labelX1.TabIndex = 54;
            this.labelX1.Text = "服务器：";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 10);
            this.panel1.TabIndex = 44;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX5.Location = new System.Drawing.Point(12, 30);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(150, 23);
            this.labelX5.TabIndex = 57;
            this.labelX5.Text = "活动管理";
            // 
            // btnImportAll
            // 
            this.btnImportAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportAll.Image = global::GameToolsClient.Properties.Resources.user_new;
            this.btnImportAll.Location = new System.Drawing.Point(521, 11);
            this.btnImportAll.Name = "btnImportAll";
            this.btnImportAll.Size = new System.Drawing.Size(119, 23);
            this.btnImportAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportAll.TabIndex = 56;
            this.btnImportAll.Text = "导入全部活动(&A)";
            this.btnImportAll.Click += new System.EventHandler(this.btnImportAll_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Image = global::GameToolsClient.Properties.Resources.edit;
            this.btnQuery.Location = new System.Drawing.Point(306, 11);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 55;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Image = global::GameToolsClient.Properties.Resources.user_new;
            this.btnNew.Location = new System.Drawing.Point(414, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 23);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 50;
            this.btnNew.Text = "新增活动(&N)";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ActivityManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 615);
            this.CloseBox = true;
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.panelParent);
            this.Name = "ActivityManager";
            this.Load += new System.EventHandler(this.ActivityManager_Load);
            this.Controls.SetChildIndex(this.panelParent, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.panelParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelParent;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvDataList;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbServer;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 活动ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 活动名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否开启活动;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束时间;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn guid;
        private System.Windows.Forms.DataGridViewImageColumn selected;
        private DevComponents.DotNetBar.ButtonX btnImportAll;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.ButtonX btnNew;
    }
}