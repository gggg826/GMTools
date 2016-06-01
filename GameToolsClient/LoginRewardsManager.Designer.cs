namespace GameToolsClient
{
    partial class LoginRewardsManager
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.gvDataList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.applytoothers = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).BeginInit();
            this.order = System.Windows.Forms.SortOrder.Ascending;
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            // 
            //
            //
            //
            // 
            this.lbTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTitle.Location = new System.Drawing.Point(450, 26);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(196, 23);
            this.lbTitle.TabIndex = 57;
            this.lbTitle.Text = "累计登录奖励编辑";
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Image = global::GameToolsClient.Properties.Resources.user_new;
            this.btnNew.Location = new System.Drawing.Point(343, 61);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 23);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 50;
            this.btnNew.Text = "新增活动(&N)";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(41, 62);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 23);
            this.labelX1.TabIndex = 54;
            this.labelX1.Text = "服务器：";
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
            this.tbServer.Location = new System.Drawing.Point(94, 62);
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
            this.btnQuery.Location = new System.Drawing.Point(235, 61);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 55;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
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
            this.days,
            this.kindReward,
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
            this.gvDataList.EnableHeadersVisualStyles = false;
            this.gvDataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvDataList.Location = new System.Drawing.Point(37, 90);
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
            this.gvDataList.Size = new System.Drawing.Size(1052, 390);
            this.gvDataList.TabIndex = 43;
            this.gvDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDataList_CellClick);
            this.gvDataList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(gvDataList_ColumnHeaderMouseClick);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::GameToolsClient.Properties.Resources.document_save_3;
            this.btnSave.Location = new System.Drawing.Point(457, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 119;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // applytoothers
            // 
            this.applytoothers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.applytoothers.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.applytoothers.Image = global::GameToolsClient.Properties.Resources.user_new;
            this.applytoothers.Location = new System.Drawing.Point(563, 61);
            this.applytoothers.Name = "applytoothers";
            this.applytoothers.Size = new System.Drawing.Size(173, 23);
            this.applytoothers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.applytoothers.TabIndex = 119;
            this.applytoothers.Text = "应用到其他服务器(&B)";
            this.applytoothers.Click += new System.EventHandler(this.applytoothers_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelX2.Location = new System.Drawing.Point(766, 62);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(183, 23);
            this.labelX2.TabIndex = 54;
            this.labelX2.Text = "应用到其他服务器前先保存";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // days
            // 
            this.days.HeaderText = "天数";
            this.days.Name = "days";
            // 
            // kindReward
            // 
            this.kindReward.HeaderText = "奖励类型";
            this.kindReward.Name = "kindReward";
            this.kindReward.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // LoginRewardsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1115, 507);
            this.CloseBox = true;
            this.Controls.Add(this.gvDataList);
            this.Controls.Add(this.applytoothers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnNew);
            this.IsShowCaptionImage = false;
            this.IsShowCaptionText = false;
            this.IsTitleSplitLine = false;
            this.Name = "LoginRewardsManager";
            this.Load += new System.EventHandler(this.LoginRewardsManager_Load);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.tbServer, 0);
            this.Controls.SetChildIndex(this.btnQuery, 0);
            this.Controls.SetChildIndex(this.lbTitle, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.applytoothers, 0);
            this.Controls.SetChildIndex(this.gvDataList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbTitle;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbServer;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvDataList;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX applytoothers;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindReward;
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
        private System.Windows.Forms.SortOrder order;
    }
}
