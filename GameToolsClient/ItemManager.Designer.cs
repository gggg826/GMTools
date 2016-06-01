namespace GameToolsClient
{
    partial class ItemManager
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
            this.loadingControl1 = new GameToolsClient.LoadingControl();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnImport = new DevComponents.DotNetBar.ButtonX();
            this.gvDataList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.渠道名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.包名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelParent
            // 
            this.panelParent.Controls.Add(this.loadingControl1);
            this.panelParent.Controls.Add(this.btnSave);
            this.panelParent.Controls.Add(this.btnImport);
            this.panelParent.Controls.Add(this.gvDataList);
            this.panelParent.Location = new System.Drawing.Point(6, 43);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(510, 528);
            this.panelParent.TabIndex = 48;
            // 
            // loadingControl1
            // 
            this.loadingControl1.BackColor = System.Drawing.Color.White;
            this.loadingControl1.Location = new System.Drawing.Point(3, 354);
            this.loadingControl1.Name = "loadingControl1";
            this.loadingControl1.Size = new System.Drawing.Size(504, 112);
            this.loadingControl1.TabIndex = 45;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::GameToolsClient.Properties.Resources.document_save_3;
            this.btnSave.Location = new System.Drawing.Point(286, 491);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImport
            // 
            this.btnImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImport.Image = global::GameToolsClient.Properties.Resources.document_import;
            this.btnImport.Location = new System.Drawing.Point(136, 491);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImport.TabIndex = 49;
            this.btnImport.Text = "导入(&I)";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // gvDataList
            // 
            this.gvDataList.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gvDataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvDataList.BackgroundColor = System.Drawing.Color.White;
            this.gvDataList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.Column8,
            this.渠道名称,
            this.包名,
            this.guid});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDataList.DefaultCellStyle = dataGridViewCellStyle7;
            this.gvDataList.EnableHeadersVisualStyles = false;
            this.gvDataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gvDataList.Location = new System.Drawing.Point(0, 0);
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
            this.gvDataList.Size = new System.Drawing.Size(510, 466);
            this.gvDataList.TabIndex = 43;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "物品ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // 渠道名称
            // 
            this.渠道名称.HeaderText = "物品名称";
            this.渠道名称.Name = "渠道名称";
            this.渠道名称.ReadOnly = true;
            this.渠道名称.Width = 150;
            // 
            // 包名
            // 
            this.包名.HeaderText = "描述";
            this.包名.Name = "包名";
            this.包名.ReadOnly = true;
            this.包名.Width = 200;
            // 
            // guid
            // 
            this.guid.HeaderText = "guid";
            this.guid.Name = "guid";
            this.guid.ReadOnly = true;
            this.guid.Visible = false;
            // 
            // ItemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 583);
            this.CloseBox = true;
            this.Controls.Add(this.panelParent);
            this.Name = "ItemManager";
            this.Load += new System.EventHandler(this.ItemManager_Load);
            this.Controls.SetChildIndex(this.panelParent, 0);
            this.panelParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelParent;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvDataList;
        private DevComponents.DotNetBar.ButtonX btnImport;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private LoadingControl loadingControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn 渠道名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 包名;
        private System.Windows.Forms.DataGridViewTextBoxColumn guid;
    }
}