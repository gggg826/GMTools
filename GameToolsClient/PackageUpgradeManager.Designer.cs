namespace GameToolsClient
{
    partial class PackageUpgradeManager
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
            this.panelParent = new System.Windows.Forms.Panel();
            this.loadingControl = new GameToolsClient.LoadingControl();
            this.gvDataList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.渠道名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.版本类型 = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.强制升级 = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.升级包下载地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.升级说明 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.删除 = new System.Windows.Forms.DataGridViewImageColumn();
            this.guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonX();
            this.panelParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelParent
            // 
            this.panelParent.Controls.Add(this.loadingControl);
            this.panelParent.Controls.Add(this.gvDataList);
            this.panelParent.Location = new System.Drawing.Point(8, 46);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(920, 607);
            this.panelParent.TabIndex = 48;
            // 
            // loadingControl
            // 
            this.loadingControl.BackColor = System.Drawing.Color.White;
            this.loadingControl.Location = new System.Drawing.Point(0, 544);
            this.loadingControl.Name = "loadingControl";
            this.loadingControl.Size = new System.Drawing.Size(917, 61);
            this.loadingControl.TabIndex = 44;
            // 
            // gvDataList
            // 
            this.gvDataList.AllowUserToAddRows = false;
            this.gvDataList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvDataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDataList.BackgroundColor = System.Drawing.Color.White;
            this.gvDataList.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.Column8,
            this.渠道名称,
            this.版本类型,
            this.强制升级,
            this.升级包下载地址,
            this.升级说明,
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
            this.gvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDataList.EnableHeadersVisualStyles = false;
            this.gvDataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gvDataList.Location = new System.Drawing.Point(0, 0);
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
            this.gvDataList.Size = new System.Drawing.Size(920, 607);
            this.gvDataList.TabIndex = 43;
            this.gvDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDataList_CellClick);
            this.gvDataList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDataList_CellEndEdit);
            this.gvDataList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvDataList_RowsAdded);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "包名";
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // 渠道名称
            // 
            this.渠道名称.HeaderText = "版本";
            this.渠道名称.Name = "渠道名称";
            this.渠道名称.Width = 150;
            // 
            // 版本类型
            // 
            this.版本类型.DropDownHeight = 106;
            this.版本类型.DropDownWidth = 121;
            this.版本类型.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.版本类型.HeaderText = "版本类型";
            this.版本类型.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.版本类型.IntegralHeight = false;
            this.版本类型.ItemHeight = 16;
            this.版本类型.Name = "版本类型";
            this.版本类型.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 强制升级
            // 
            this.强制升级.DropDownHeight = 106;
            this.强制升级.DropDownWidth = 121;
            this.强制升级.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.强制升级.HeaderText = "强制升级";
            this.强制升级.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.强制升级.IntegralHeight = false;
            this.强制升级.ItemHeight = 16;
            this.强制升级.Name = "强制升级";
            this.强制升级.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 升级包下载地址
            // 
            this.升级包下载地址.HeaderText = "升级包下载地址";
            this.升级包下载地址.Name = "升级包下载地址";
            this.升级包下载地址.Width = 250;
            // 
            // 升级说明
            // 
            this.升级说明.HeaderText = "升级说明";
            this.升级说明.Name = "升级说明";
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
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(9, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 28);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Location = new System.Drawing.Point(122, 8);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 28);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 50;
            this.btnNew.Text = "新增(&N)";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRefresh.Location = new System.Drawing.Point(234, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 28);
            this.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRefresh.TabIndex = 51;
            this.btnRefresh.Text = "刷新数据(&F)";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PackageUpgradeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 664);
            this.CloseBox = true;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelParent);
            this.Name = "PackageUpgradeManager";
            this.Load += new System.EventHandler(this.PackageUpgradeManager_Load);
            this.Controls.SetChildIndex(this.panelParent, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            this.panelParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelParent;
        private LoadingControl loadingControl;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvDataList;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private DevComponents.DotNetBar.ButtonX btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn 渠道名称;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn 版本类型;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn 强制升级;
        private System.Windows.Forms.DataGridViewTextBoxColumn 升级包下载地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 升级说明;
        private System.Windows.Forms.DataGridViewImageColumn 删除;
        private System.Windows.Forms.DataGridViewTextBoxColumn guid;
    }
}