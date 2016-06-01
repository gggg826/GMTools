namespace GameToolsClient
{
    partial class GiftPackageManager
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
            this.只领取一次 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.标题 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否启用 = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.删除 = new System.Windows.Forms.DataGridViewImageColumn();
            this.guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selected = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.panelParent.Location = new System.Drawing.Point(6, 49);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(1502, 637);
            this.panelParent.TabIndex = 48;
            // 
            // loadingControl
            // 
            this.loadingControl.BackColor = System.Drawing.Color.White;
            this.loadingControl.Location = new System.Drawing.Point(347, 485);
            this.loadingControl.Name = "loadingControl";
            this.loadingControl.Size = new System.Drawing.Size(861, 96);
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
            this.只领取一次,
            this.标题,
            this.内容,
            this.物品1,
            this.物品2,
            this.物品3,
            this.物品4,
            this.物品5,
            this.物品6,
            this.物品7,
            this.物品8,
            this.物品9,
            this.物品10,
            this.Column2,
            this.是否启用,
            this.edit,
            this.删除,
            this.guid,
            this.selected});
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
            this.gvDataList.Size = new System.Drawing.Size(1502, 637);
            this.gvDataList.TabIndex = 43;
            this.gvDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDataList_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // 只领取一次
            // 
            this.只领取一次.HeaderText = "只领取一次";
            this.只领取一次.Name = "只领取一次";
            this.只领取一次.ReadOnly = true;
            this.只领取一次.Width = 90;
            // 
            // 标题
            // 
            this.标题.HeaderText = "标题";
            this.标题.Name = "标题";
            this.标题.ReadOnly = true;
            // 
            // 内容
            // 
            this.内容.HeaderText = "内容";
            this.内容.Name = "内容";
            this.内容.ReadOnly = true;
            // 
            // 物品1
            // 
            this.物品1.HeaderText = "物品1";
            this.物品1.Name = "物品1";
            this.物品1.ReadOnly = true;
            this.物品1.Width = 80;
            // 
            // 物品2
            // 
            this.物品2.HeaderText = "物品2";
            this.物品2.Name = "物品2";
            this.物品2.ReadOnly = true;
            this.物品2.Width = 80;
            // 
            // 物品3
            // 
            this.物品3.HeaderText = "物品3";
            this.物品3.Name = "物品3";
            this.物品3.ReadOnly = true;
            this.物品3.Width = 80;
            // 
            // 物品4
            // 
            this.物品4.HeaderText = "物品4";
            this.物品4.Name = "物品4";
            this.物品4.ReadOnly = true;
            this.物品4.Width = 80;
            // 
            // 物品5
            // 
            this.物品5.HeaderText = "物品5";
            this.物品5.Name = "物品5";
            this.物品5.ReadOnly = true;
            this.物品5.Width = 80;
            // 
            // 物品6
            // 
            this.物品6.HeaderText = "物品6";
            this.物品6.Name = "物品6";
            this.物品6.ReadOnly = true;
            this.物品6.Width = 80;
            // 
            // 物品7
            // 
            this.物品7.HeaderText = "物品7";
            this.物品7.Name = "物品7";
            this.物品7.ReadOnly = true;
            this.物品7.Width = 80;
            // 
            // 物品8
            // 
            this.物品8.HeaderText = "物品8";
            this.物品8.Name = "物品8";
            this.物品8.ReadOnly = true;
            this.物品8.Width = 80;
            // 
            // 物品9
            // 
            this.物品9.HeaderText = "物品9";
            this.物品9.Name = "物品9";
            this.物品9.ReadOnly = true;
            this.物品9.Width = 80;
            // 
            // 物品10
            // 
            this.物品10.HeaderText = "物品10";
            this.物品10.Name = "物品10";
            this.物品10.ReadOnly = true;
            this.物品10.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "修改时间";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // 是否启用
            // 
            this.是否启用.DisplayMember = "Text";
            this.是否启用.DropDownHeight = 106;
            this.是否启用.DropDownWidth = 121;
            this.是否启用.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.是否启用.HeaderText = "是否启用";
            this.是否启用.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.是否启用.IntegralHeight = false;
            this.是否启用.ItemHeight = 16;
            this.是否启用.Name = "是否启用";
            this.是否启用.ReadOnly = true;
            this.是否启用.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.是否启用.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.是否启用.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.Image = global::GameToolsClient.Properties.Resources.edit;
            this.edit.Name = "edit";
            this.edit.Width = 20;
            // 
            // 删除
            // 
            this.删除.FillWeight = 40F;
            this.删除.HeaderText = "";
            this.删除.Image = global::GameToolsClient.Properties.Resources.delete;
            this.删除.Name = "删除";
            this.删除.Visible = false;
            this.删除.Width = 20;
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
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Image = global::GameToolsClient.Properties.Resources.user_new;
            this.btnNew.Location = new System.Drawing.Point(6, 7);
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
            this.btnRefresh.Image = global::GameToolsClient.Properties.Resources.view_refresh_3;
            this.btnRefresh.Location = new System.Drawing.Point(116, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 28);
            this.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRefresh.TabIndex = 51;
            this.btnRefresh.Text = "刷新数据(&F)";
            // 
            // GiftPackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 696);
            this.CloseBox = true;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panelParent);
            this.Name = "GiftPackageManager";
            this.Load += new System.EventHandler(this.GiftPackage_Load);
            this.Controls.SetChildIndex(this.panelParent, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            this.panelParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelParent;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvDataList;
        private LoadingControl loadingControl;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private DevComponents.DotNetBar.ButtonX btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 只领取一次;
        private System.Windows.Forms.DataGridViewTextBoxColumn 标题;
        private System.Windows.Forms.DataGridViewTextBoxColumn 内容;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品6;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品8;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品9;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn 是否启用;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn 删除;
        private System.Windows.Forms.DataGridViewTextBoxColumn guid;
        private System.Windows.Forms.DataGridViewImageColumn selected;
    }
}