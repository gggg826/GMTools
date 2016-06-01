namespace GameToolsClient
{
    partial class QueryRole
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
            this.tbServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbRoleName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbRoleID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tbUserID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tbRoleInfo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(20, 63);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 23);
            this.labelX1.TabIndex = 43;
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
            this.tbServer.Location = new System.Drawing.Point(75, 63);
            this.tbServer.Name = "tbServer";
            this.tbServer.ReadOnly = true;
            this.tbServer.Size = new System.Drawing.Size(113, 22);
            this.tbServer.TabIndex = 44;
            this.tbServer.ButtonCustomClick += new System.EventHandler(this.tbServer_ButtonCustomClick);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(378, 63);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(73, 23);
            this.labelX2.TabIndex = 45;
            this.labelX2.Text = "角色名称：";
            // 
            // tbRoleName
            // 
            this.tbRoleName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbRoleName.Border.Class = "TextBoxBorder";
            this.tbRoleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbRoleName.ForeColor = System.Drawing.Color.Black;
            this.tbRoleName.Location = new System.Drawing.Point(440, 63);
            this.tbRoleName.Name = "tbRoleName";
            this.tbRoleName.Size = new System.Drawing.Size(113, 21);
            this.tbRoleName.TabIndex = 46;
            // 
            // tbRoleID
            // 
            this.tbRoleID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbRoleID.Border.Class = "TextBoxBorder";
            this.tbRoleID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbRoleID.ForeColor = System.Drawing.Color.Black;
            this.tbRoleID.Location = new System.Drawing.Point(250, 63);
            this.tbRoleID.Name = "tbRoleID";
            this.tbRoleID.Size = new System.Drawing.Size(113, 21);
            this.tbRoleID.TabIndex = 48;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(198, 63);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(73, 23);
            this.labelX3.TabIndex = 47;
            this.labelX3.Text = "角色ID：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(564, 63);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(59, 23);
            this.labelX4.TabIndex = 49;
            this.labelX4.Text = "用户ID：";
            // 
            // tbUserID
            // 
            this.tbUserID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbUserID.Border.Class = "TextBoxBorder";
            this.tbUserID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbUserID.ForeColor = System.Drawing.Color.Black;
            this.tbUserID.Location = new System.Drawing.Point(616, 63);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(113, 21);
            this.tbUserID.TabIndex = 50;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Image = global::GameToolsClient.Properties.Resources.edit;
            this.btnQuery.Location = new System.Drawing.Point(748, 61);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 51;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX5.Location = new System.Drawing.Point(20, 27);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(150, 23);
            this.labelX5.TabIndex = 52;
            this.labelX5.Text = "用户信息查询";
            // 
            // tbRoleInfo
            // 
            this.tbRoleInfo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbRoleInfo.Border.Class = "TextBoxBorder";
            this.tbRoleInfo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbRoleInfo.ForeColor = System.Drawing.Color.Black;
            this.tbRoleInfo.Location = new System.Drawing.Point(22, 105);
            this.tbRoleInfo.Multiline = true;
            this.tbRoleInfo.Name = "tbRoleInfo";
            this.tbRoleInfo.ReadOnly = true;
            this.tbRoleInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRoleInfo.Size = new System.Drawing.Size(801, 455);
            this.tbRoleInfo.TabIndex = 53;
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Image = global::GameToolsClient.Properties.Resources.edit_clear_2;
            this.btnClear.Location = new System.Drawing.Point(355, 574);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 23);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = "清除查询结果(&C)";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // QueryRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 614);
            this.CloseBox = true;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbRoleInfo);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.tbRoleID);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tbRoleName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.labelX1);
            this.Name = "QueryRole";
            this.Load += new System.EventHandler(this.QeuryRole_Load);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.tbServer, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.tbRoleName, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.tbRoleID, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.tbUserID, 0);
            this.Controls.SetChildIndex(this.btnQuery, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.tbRoleInfo, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbServer;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRoleName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRoleID;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX tbUserID;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRoleInfo;
        private DevComponents.DotNetBar.ButtonX btnClear;
    }
}