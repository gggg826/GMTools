namespace GameToolsClient
{
    partial class CountManagers
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new DevComponents.DotNetBar.LabelX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.btnCustomQuery = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.tbItemID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvDataList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lbSaving = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.applytoothers = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardName4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selected = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.lbTitle.Location = new System.Drawing.Point(545, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(196, 23);
            this.lbTitle.TabIndex = 57;
            this.lbTitle.Text = "活动计数管理";
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Image = global::GameToolsClient.Properties.Resources.user_new;
            this.btnNew.Location = new System.Drawing.Point(314, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 23);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 50;
            this.btnNew.Text = "新增活动(&N)";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCustomQuery
            // 
            this.btnCustomQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCustomQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCustomQuery.Image = global::GameToolsClient.Properties.Resources.edit;
            this.btnCustomQuery.Location = new System.Drawing.Point(1072, 10);
            this.btnCustomQuery.Name = "btnCustomQuery";
            this.btnCustomQuery.Size = new System.Drawing.Size(100, 23);
            this.btnCustomQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCustomQuery.TabIndex = 119;
            this.btnCustomQuery.Text = "查询";
            this.btnCustomQuery.Click += new System.EventHandler(this.btnCustomQuery_click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::GameToolsClient.Properties.Resources.document_save_3;
            this.btnSave.Location = new System.Drawing.Point(422, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 119;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(929, 10);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(58, 23);
            this.labelX9.TabIndex = 60;
            this.labelX9.Text = "输入ID：";
            // 
            // tbItemID
            // 
            this.tbItemID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbItemID.Border.Class = "TextBoxBorder";
            this.tbItemID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbItemID.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbItemID.ForeColor = System.Drawing.Color.Black;
            this.tbItemID.Location = new System.Drawing.Point(988, 11);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(81, 21);
            this.tbItemID.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvDataList);
            this.panel2.Controls.Add(this.lbSaving);
            this.panel2.Location = new System.Drawing.Point(30, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 354);
            this.panel2.TabIndex = 59;
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
            this.counts,
            this.dec,
            this.rewardName1,
            this.count1,
            this.rewardName2,
            this.Count2,
            this.rewardName3,
            this.Count3,
            this.rewardName4,
            this.Count4,
            this.edit,
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
            this.gvDataList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvDataList.EnableHeadersVisualStyles = false;
            this.gvDataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
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
            this.gvDataList.Size = new System.Drawing.Size(1220, 354);
            this.gvDataList.TabIndex = 43;
            this.gvDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDataList_CellClick);
            // 
            // lbSaving
            // 
            // 
            // 
            // 
            this.lbSaving.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbSaving.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSaving.Location = new System.Drawing.Point(327, 138);
            this.lbSaving.Name = "lbSaving";
            this.lbSaving.Size = new System.Drawing.Size(348, 107);
            this.lbSaving.TabIndex = 60;
            this.lbSaving.Text = "正在保存并通知服务器";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCustomQuery);
            this.panel3.Controls.Add(this.labelX9);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.tbItemID);
            this.panel3.Controls.Add(this.applytoothers);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.labelX1);
            this.panel3.Controls.Add(this.labelX2);
            this.panel3.Controls.Add(this.tbServer);
            this.panel3.Controls.Add(this.btnQuery);
            this.panel3.Location = new System.Drawing.Point(30, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 36);
            this.panel3.TabIndex = 61;
            // 
            // applytoothers
            // 
            this.applytoothers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.applytoothers.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.applytoothers.Image = global::GameToolsClient.Properties.Resources.user_new;
            this.applytoothers.Location = new System.Drawing.Point(529, 10);
            this.applytoothers.Name = "applytoothers";
            this.applytoothers.Size = new System.Drawing.Size(173, 23);
            this.applytoothers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.applytoothers.TabIndex = 119;
            this.applytoothers.Text = "应用到其他服务器(&B)";
            this.applytoothers.Click += new System.EventHandler(this.applytoothers_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 23);
            this.labelX1.TabIndex = 54;
            this.labelX1.Text = "服务器：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelX2.Location = new System.Drawing.Point(711, 11);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(183, 23);
            this.labelX2.TabIndex = 54;
            this.labelX2.Text = "应用到其他服务器前先保存";
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
            this.tbServer.Location = new System.Drawing.Point(71, 11);
            this.tbServer.Name = "tbServer";
            this.tbServer.ReadOnly = true;
            this.tbServer.Size = new System.Drawing.Size(134, 22);
            this.tbServer.TabIndex = 53;
            this.tbServer.ButtonCustomClick += new System.EventHandler(this.tbServer_ButtonCustomClick);
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Image = global::GameToolsClient.Properties.Resources.edit;
            this.btnQuery.Location = new System.Drawing.Point(208, 10);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 55;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // counts
            // 
            this.counts.HeaderText = "目标数量";
            this.counts.Name = "counts";
            // 
            // dec
            // 
            this.dec.HeaderText = "描述";
            this.dec.Name = "dec";
            // 
            // rewardName1
            // 
            this.rewardName1.HeaderText = "奖励道具1";
            this.rewardName1.Name = "rewardName1";
            this.rewardName1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // count1
            // 
            this.count1.HeaderText = "数量1";
            this.count1.Name = "count1";
            this.count1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rewardName2
            // 
            this.rewardName2.HeaderText = "奖励道具2";
            this.rewardName2.Name = "rewardName2";
            this.rewardName2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Count2
            // 
            this.Count2.HeaderText = "数量2";
            this.Count2.Name = "Count2";
            this.Count2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rewardName3
            // 
            this.rewardName3.HeaderText = "奖励道具3";
            this.rewardName3.Name = "rewardName3";
            this.rewardName3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Count3
            // 
            this.Count3.HeaderText = "数量3";
            this.Count3.Name = "Count3";
            this.Count3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rewardName4
            // 
            this.rewardName4.HeaderText = "奖励道具4";
            this.rewardName4.Name = "rewardName4";
            this.rewardName4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Count4
            // 
            this.Count4.HeaderText = "数量4";
            this.Count4.Name = "Count4";
            this.Count4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // edit
            // 
            this.edit.FillWeight = 40F;
            this.edit.HeaderText = "";
            this.edit.Image = global::GameToolsClient.Properties.Resources.edit;
            this.edit.Name = "edit";
            this.edit.Visible = false;
            this.edit.Width = 20;
            // 
            // guid
            // 
            this.guid.HeaderText = "guid";
            this.guid.Name = "guid";
            this.guid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.guid.Visible = false;
            // 
            // selected
            // 
            this.selected.HeaderText = "";
            this.selected.Image = global::GameToolsClient.Properties.Resources.delete;
            this.selected.Name = "selected";
            this.selected.Width = 20;
            // 
            // CountManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1282, 474);
            this.CloseBox = true;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbTitle);
            this.IsShowCaptionImage = false;
            this.IsShowCaptionText = false;
            this.IsTitleSplitLine = false;
            this.Name = "CountManagers";
            this.Load += new System.EventHandler(this.CountManagers_Load);
            this.Controls.SetChildIndex(this.lbTitle, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbTitle;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btnCustomQuery;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX tbItemID;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvDataList;
        private DevComponents.DotNetBar.LabelX lbSaving;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.ButtonX applytoothers;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbServer;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn counts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn count1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardName3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardName4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count4;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn guid;
        private System.Windows.Forms.DataGridViewImageColumn selected;
    }
}
