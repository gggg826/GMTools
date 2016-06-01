namespace GameToolsClient
{
    partial class ViewItem
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
            this.loadingControl1 = new GameToolsClient.LoadingControl();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnFilter = new DevComponents.DotNetBar.ButtonX();
            this.tbFilter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.gvDataList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
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
            this.panelParent.Controls.Add(this.btnCancel);
            this.panelParent.Controls.Add(this.btnFilter);
            this.panelParent.Controls.Add(this.tbFilter);
            this.panelParent.Controls.Add(this.btnOK);
            this.panelParent.Controls.Add(this.gvDataList);
            this.panelParent.Location = new System.Drawing.Point(6, 47);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(510, 528);
            this.panelParent.TabIndex = 49;
            // 
            // loadingControl1
            // 
            this.loadingControl1.BackColor = System.Drawing.Color.White;
            this.loadingControl1.Location = new System.Drawing.Point(4, 350);
            this.loadingControl1.Name = "loadingControl1";
            this.loadingControl1.Size = new System.Drawing.Size(504, 112);
            this.loadingControl1.TabIndex = 45;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::GameToolsClient.Properties.Resources.dialog_cancel_4;
            this.btnCancel.Location = new System.Drawing.Point(281, 489);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFilter.Image = global::GameToolsClient.Properties.Resources.view_filter;
            this.btnFilter.Location = new System.Drawing.Point(435, 8);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFilter.TabIndex = 51;
            this.btnFilter.Text = "筛选(&F)";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbFilter.Border.Class = "TextBoxBorder";
            this.tbFilter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFilter.ForeColor = System.Drawing.Color.Black;
            this.tbFilter.Location = new System.Drawing.Point(0, 9);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(429, 21);
            this.tbFilter.TabIndex = 50;
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Image = global::GameToolsClient.Properties.Resources.dialog_ok_apply_5;
            this.btnOK.Location = new System.Drawing.Point(145, 489);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            this.check,
            this.Column8,
            this.渠道名称,
            this.包名,
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
            this.gvDataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.gvDataList.Location = new System.Drawing.Point(0, 40);
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
            this.gvDataList.Size = new System.Drawing.Size(510, 426);
            this.gvDataList.TabIndex = 43;
            this.gvDataList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDataList_CellValueChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // check
            // 
            this.check.Checked = true;
            this.check.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.check.CheckValue = "N";
            this.check.FillWeight = 16F;
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Width = 16;
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
            // ViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 583);
            this.CloseBox = true;
            this.Controls.Add(this.panelParent);
            this.Name = "ViewItem";
            this.Load += new System.EventHandler(this.ViewItem_Load);
            this.Controls.SetChildIndex(this.panelParent, 0);
            this.panelParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelParent;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnFilter;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFilter;
        private LoadingControl loadingControl1;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvDataList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn 渠道名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 包名;
        private System.Windows.Forms.DataGridViewTextBoxColumn guid;
    }
}