namespace GameToolsClient
{
    partial class LockRoleSender
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
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tbServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnKickout = new DevComponents.DotNetBar.ButtonX();
            this.tbRoleID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dtUnlockDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtUnlockTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.tbReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbLockDevice = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnLock = new DevComponents.DotNetBar.ButtonX();
            this.btnUnlock = new DevComponents.DotNetBar.ButtonX();
            this.btnLockChat = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtUnlockDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUnlockTime)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(60, 88);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(73, 23);
            this.labelX3.TabIndex = 51;
            this.labelX3.Text = "角色ID：";
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
            this.tbServer.Location = new System.Drawing.Point(112, 60);
            this.tbServer.Name = "tbServer";
            this.tbServer.ReadOnly = true;
            this.tbServer.Size = new System.Drawing.Size(220, 22);
            this.tbServer.TabIndex = 1;
            this.tbServer.ButtonCustomClick += new System.EventHandler(this.tbServer_ButtonCustomClick);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(59, 60);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 23);
            this.labelX1.TabIndex = 49;
            this.labelX1.Text = "服务器：";
            // 
            // btnKickout
            // 
            this.btnKickout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKickout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKickout.Image = global::GameToolsClient.Properties.Resources.im_kick_user;
            this.btnKickout.Location = new System.Drawing.Point(270, 239);
            this.btnKickout.Name = "btnKickout";
            this.btnKickout.Size = new System.Drawing.Size(75, 23);
            this.btnKickout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKickout.TabIndex = 10;
            this.btnKickout.Text = "踢出(&K)";
            this.btnKickout.Click += new System.EventHandler(this.btnKickout_Click);
            // 
            // tbRoleID
            // 
            this.tbRoleID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbRoleID.Border.Class = "TextBoxBorder";
            this.tbRoleID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbRoleID.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbRoleID.ButtonCustom.Visible = true;
            this.tbRoleID.ForeColor = System.Drawing.Color.Black;
            this.tbRoleID.Location = new System.Drawing.Point(112, 88);
            this.tbRoleID.Name = "tbRoleID";
            this.tbRoleID.Size = new System.Drawing.Size(219, 22);
            this.tbRoleID.TabIndex = 2;
            this.tbRoleID.ButtonCustomClick += new System.EventHandler(this.tbRoleID_ButtonCustomClick);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX5.Location = new System.Drawing.Point(20, 32);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(150, 23);
            this.labelX5.TabIndex = 55;
            this.labelX5.Text = "账户封停";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(24, 210);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(95, 23);
            this.labelX2.TabIndex = 56;
            this.labelX2.Text = "封停当前设备：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(49, 117);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(73, 23);
            this.labelX4.TabIndex = 57;
            this.labelX4.Text = "解封时间：";
            // 
            // dtUnlockDate
            // 
            // 
            // 
            // 
            this.dtUnlockDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtUnlockDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtUnlockDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtUnlockDate.ButtonDropDown.Visible = true;
            this.dtUnlockDate.IsPopupCalendarOpen = false;
            this.dtUnlockDate.Location = new System.Drawing.Point(112, 118);
            // 
            // 
            // 
            this.dtUnlockDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtUnlockDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtUnlockDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtUnlockDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtUnlockDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtUnlockDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtUnlockDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtUnlockDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtUnlockDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtUnlockDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtUnlockDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtUnlockDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.dtUnlockDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtUnlockDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtUnlockDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtUnlockDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtUnlockDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtUnlockDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtUnlockDate.MonthCalendar.TodayButtonVisible = true;
            this.dtUnlockDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtUnlockDate.Name = "dtUnlockDate";
            this.dtUnlockDate.Size = new System.Drawing.Size(116, 21);
            this.dtUnlockDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtUnlockDate.TabIndex = 3;
            this.dtUnlockDate.Value = new System.DateTime(2015, 6, 30, 0, 0, 0, 0);
            // 
            // dtUnlockTime
            // 
            // 
            // 
            // 
            this.dtUnlockTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtUnlockTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtUnlockTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtUnlockTime.FieldNavigation = DevComponents.Editors.eInputFieldNavigation.Tab;
            this.dtUnlockTime.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime;
            this.dtUnlockTime.IsPopupCalendarOpen = false;
            this.dtUnlockTime.Location = new System.Drawing.Point(236, 118);
            // 
            // 
            // 
            this.dtUnlockTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtUnlockTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtUnlockTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.dtUnlockTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtUnlockTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtUnlockTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtUnlockTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtUnlockTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtUnlockTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtUnlockTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtUnlockTime.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.dtUnlockTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtUnlockTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtUnlockTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtUnlockTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtUnlockTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtUnlockTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtUnlockTime.MonthCalendar.Visible = false;
            this.dtUnlockTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtUnlockTime.Name = "dtUnlockTime";
            this.dtUnlockTime.ShowUpDown = true;
            this.dtUnlockTime.Size = new System.Drawing.Size(96, 21);
            this.dtUnlockTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtUnlockTime.TabIndex = 4;
            this.dtUnlockTime.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            this.dtUnlockTime.Value = new System.DateTime(2015, 6, 30, 12, 0, 0, 0);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(49, 146);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(73, 23);
            this.labelX6.TabIndex = 62;
            this.labelX6.Text = "封停原因：";
            // 
            // tbReason
            // 
            this.tbReason.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbReason.Border.Class = "TextBoxBorder";
            this.tbReason.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbReason.ForeColor = System.Drawing.Color.Black;
            this.tbReason.Location = new System.Drawing.Point(112, 147);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(219, 57);
            this.tbReason.TabIndex = 5;
            // 
            // cbLockDevice
            // 
            // 
            // 
            // 
            this.cbLockDevice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbLockDevice.Location = new System.Drawing.Point(112, 210);
            this.cbLockDevice.Name = "cbLockDevice";
            this.cbLockDevice.Size = new System.Drawing.Size(21, 23);
            this.cbLockDevice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLockDevice.TabIndex = 7;
            // 
            // btnLock
            // 
            this.btnLock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLock.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLock.Image = global::GameToolsClient.Properties.Resources.lock_5;
            this.btnLock.Location = new System.Drawing.Point(9, 239);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLock.TabIndex = 8;
            this.btnLock.Text = "封停(&L)";
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUnlock.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUnlock.Image = global::GameToolsClient.Properties.Resources.lock_open;
            this.btnUnlock.Location = new System.Drawing.Point(183, 239);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(75, 23);
            this.btnUnlock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUnlock.TabIndex = 9;
            this.btnUnlock.Text = "解封(&U)";
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnLockChat
            // 
            this.btnLockChat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLockChat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLockChat.Image = global::GameToolsClient.Properties.Resources.lock_5;
            this.btnLockChat.Location = new System.Drawing.Point(96, 239);
            this.btnLockChat.Name = "btnLockChat";
            this.btnLockChat.Size = new System.Drawing.Size(75, 23);
            this.btnLockChat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLockChat.TabIndex = 63;
            this.btnLockChat.Text = "禁言(&C)";
            this.btnLockChat.Click += new System.EventHandler(this.btnLockChat_Click);
            // 
            // LockRoleSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 282);
            this.CloseBox = true;
            this.Controls.Add(this.btnLockChat);
            this.Controls.Add(this.cbLockDevice);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.dtUnlockDate);
            this.Controls.Add(this.dtUnlockTime);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.tbRoleID);
            this.Controls.Add(this.btnKickout);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.labelX1);
            this.Name = "LockRoleSender";
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.tbServer, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.btnKickout, 0);
            this.Controls.SetChildIndex(this.tbRoleID, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.dtUnlockTime, 0);
            this.Controls.SetChildIndex(this.dtUnlockDate, 0);
            this.Controls.SetChildIndex(this.labelX6, 0);
            this.Controls.SetChildIndex(this.tbReason, 0);
            this.Controls.SetChildIndex(this.btnLock, 0);
            this.Controls.SetChildIndex(this.btnUnlock, 0);
            this.Controls.SetChildIndex(this.cbLockDevice, 0);
            this.Controls.SetChildIndex(this.btnLockChat, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtUnlockDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUnlockTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbServer;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnKickout;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRoleID;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtUnlockDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtUnlockTime;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX tbReason;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbLockDevice;
        private DevComponents.DotNetBar.ButtonX btnLock;
        private DevComponents.DotNetBar.ButtonX btnUnlock;
        private DevComponents.DotNetBar.ButtonX btnLockChat;
    }
}