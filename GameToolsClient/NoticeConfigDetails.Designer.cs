namespace GameToolsClient
{
    partial class NoticeConfigDetails
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
            this.lbTitle = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.cbIsOpen = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.dtStopTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtStopDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dtStartTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtStartDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tbServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tbContent = new System.Windows.Forms.RichTextBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.tbImage = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnOpen = new DevComponents.DotNetBar.ButtonX();
            this.btnSaveTemplate = new DevComponents.DotNetBar.ButtonX();
            this.btnColor = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtStopTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStopDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate)).BeginInit();
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
            this.lbTitle.Location = new System.Drawing.Point(12, 27);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(150, 23);
            this.lbTitle.TabIndex = 59;
            this.lbTitle.Text = "新公告";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::GameToolsClient.Properties.Resources.dialog_cancel_4;
            this.btnCancel.Location = new System.Drawing.Point(198, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 27);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::GameToolsClient.Properties.Resources.document_save_3;
            this.btnSave.Location = new System.Drawing.Point(56, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbIsOpen
            // 
            // 
            // 
            // 
            this.cbIsOpen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsOpen.Location = new System.Drawing.Point(94, 367);
            this.cbIsOpen.Name = "cbIsOpen";
            this.cbIsOpen.Size = new System.Drawing.Size(24, 23);
            this.cbIsOpen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsOpen.TabIndex = 84;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(29, 367);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(72, 23);
            this.labelX6.TabIndex = 83;
            this.labelX6.Text = "是否启用：";
            // 
            // dtStopTime
            // 
            // 
            // 
            // 
            this.dtStopTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtStopTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStopTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtStopTime.FieldNavigation = DevComponents.Editors.eInputFieldNavigation.Tab;
            this.dtStopTime.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime;
            this.dtStopTime.IsPopupCalendarOpen = false;
            this.dtStopTime.Location = new System.Drawing.Point(218, 333);
            // 
            // 
            // 
            this.dtStopTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtStopTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStopTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.dtStopTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtStopTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStopTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtStopTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtStopTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtStopTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtStopTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStopTime.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.dtStopTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtStopTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtStopTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtStopTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStopTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtStopTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStopTime.MonthCalendar.Visible = false;
            this.dtStopTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtStopTime.Name = "dtStopTime";
            this.dtStopTime.ShowUpDown = true;
            this.dtStopTime.Size = new System.Drawing.Size(96, 21);
            this.dtStopTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtStopTime.TabIndex = 82;
            this.dtStopTime.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            this.dtStopTime.Value = new System.DateTime(2015, 6, 30, 12, 0, 0, 0);
            // 
            // dtStopDate
            // 
            // 
            // 
            // 
            this.dtStopDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtStopDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStopDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtStopDate.ButtonDropDown.Visible = true;
            this.dtStopDate.IsPopupCalendarOpen = false;
            this.dtStopDate.Location = new System.Drawing.Point(94, 333);
            // 
            // 
            // 
            this.dtStopDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtStopDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStopDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtStopDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtStopDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtStopDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStopDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtStopDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtStopDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtStopDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtStopDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStopDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.dtStopDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtStopDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtStopDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtStopDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStopDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtStopDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStopDate.MonthCalendar.TodayButtonVisible = true;
            this.dtStopDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtStopDate.Name = "dtStopDate";
            this.dtStopDate.Size = new System.Drawing.Size(116, 21);
            this.dtStopDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtStopDate.TabIndex = 81;
            this.dtStopDate.Value = new System.DateTime(2015, 6, 30, 0, 0, 0, 0);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(30, 331);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(80, 23);
            this.labelX4.TabIndex = 80;
            this.labelX4.Text = "结束时间：";
            // 
            // dtStartTime
            // 
            // 
            // 
            // 
            this.dtStartTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtStartTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStartTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtStartTime.FieldNavigation = DevComponents.Editors.eInputFieldNavigation.Tab;
            this.dtStartTime.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime;
            this.dtStartTime.IsPopupCalendarOpen = false;
            this.dtStartTime.Location = new System.Drawing.Point(218, 295);
            // 
            // 
            // 
            this.dtStartTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtStartTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStartTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.dtStartTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtStartTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStartTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtStartTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtStartTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStartTime.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.dtStartTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtStartTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtStartTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStartTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtStartTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStartTime.MonthCalendar.Visible = false;
            this.dtStartTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.ShowUpDown = true;
            this.dtStartTime.Size = new System.Drawing.Size(96, 21);
            this.dtStartTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtStartTime.TabIndex = 79;
            this.dtStartTime.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            this.dtStartTime.Value = new System.DateTime(2015, 6, 30, 12, 0, 0, 0);
            // 
            // dtStartDate
            // 
            // 
            // 
            // 
            this.dtStartDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtStartDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStartDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtStartDate.ButtonDropDown.Visible = true;
            this.dtStartDate.IsPopupCalendarOpen = false;
            this.dtStartDate.Location = new System.Drawing.Point(94, 295);
            // 
            // 
            // 
            this.dtStartDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtStartDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStartDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtStartDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtStartDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStartDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.dtStartDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtStartDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtStartDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtStartDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtStartDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtStartDate.MonthCalendar.TodayButtonVisible = true;
            this.dtStartDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(116, 21);
            this.dtStartDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtStartDate.TabIndex = 78;
            this.dtStartDate.Value = new System.DateTime(2015, 6, 30, 0, 0, 0, 0);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(30, 293);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(80, 23);
            this.labelX3.TabIndex = 77;
            this.labelX3.Text = "开始时间：";
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
            this.tbServer.ForeColor = System.Drawing.Color.Black;
            this.tbServer.Location = new System.Drawing.Point(94, 68);
            this.tbServer.Name = "tbServer";
            this.tbServer.ReadOnly = true;
            this.tbServer.Size = new System.Drawing.Size(220, 21);
            this.tbServer.TabIndex = 73;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(41, 68);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 23);
            this.labelX1.TabIndex = 74;
            this.labelX1.Text = "服务器：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(51, 101);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 23);
            this.labelX2.TabIndex = 87;
            this.labelX2.Text = "标题：";
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbTitle.Border.Class = "TextBoxBorder";
            this.tbTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTitle.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbTitle.ForeColor = System.Drawing.Color.Black;
            this.tbTitle.Location = new System.Drawing.Point(94, 101);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(220, 48);
            this.tbTitle.TabIndex = 88;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(54, 176);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(44, 23);
            this.labelX5.TabIndex = 89;
            this.labelX5.Text = "内容：";
            // 
            // tbContent
            // 
            this.tbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbContent.Location = new System.Drawing.Point(94, 180);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(220, 73);
            this.tbContent.TabIndex = 90;
            this.tbContent.Text = "";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(51, 200);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(44, 23);
            this.labelX7.TabIndex = 89;
            this.labelX7.Text = "内容1：";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(54, 264);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(44, 23);
            this.labelX8.TabIndex = 91;
            this.labelX8.Text = "图片：";
            // 
            // tbImage
            // 
            this.tbImage.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbImage.Border.Class = "TextBoxBorder";
            this.tbImage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbImage.ButtonCustom.Image = global::GameToolsClient.Properties.Resources.edit;
            this.tbImage.ForeColor = System.Drawing.Color.Black;
            this.tbImage.Location = new System.Drawing.Point(94, 266);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(220, 21);
            this.tbImage.TabIndex = 92;
            // 
            // btnOpen
            // 
            this.btnOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOpen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOpen.Image = global::GameToolsClient.Properties.Resources.folder_open;
            this.btnOpen.Location = new System.Drawing.Point(92, 155);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 23);
            this.btnOpen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOpen.TabIndex = 96;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveTemplate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveTemplate.Image = global::GameToolsClient.Properties.Resources.document_save_5;
            this.btnSaveTemplate.Location = new System.Drawing.Point(121, 155);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(23, 23);
            this.btnSaveTemplate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveTemplate.TabIndex = 95;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // btnColor
            // 
            this.btnColor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnColor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnColor.Image = global::GameToolsClient.Properties.Resources.color_wheel;
            this.btnColor.Location = new System.Drawing.Point(150, 155);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(23, 23);
            this.btnColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnColor.TabIndex = 94;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // NoticeConfigDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 448);
            this.CloseBox = true;
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbIsOpen);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.dtStopTime);
            this.Controls.Add(this.dtStopDate);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.dtStartTime);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lbTitle);
            this.Name = "NoticeConfigDetails";
            this.Controls.SetChildIndex(this.lbTitle, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.tbServer, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.dtStartDate, 0);
            this.Controls.SetChildIndex(this.dtStartTime, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.dtStopDate, 0);
            this.Controls.SetChildIndex(this.dtStopTime, 0);
            this.Controls.SetChildIndex(this.labelX6, 0);
            this.Controls.SetChildIndex(this.cbIsOpen, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.tbTitle, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.tbContent, 0);
            this.Controls.SetChildIndex(this.labelX8, 0);
            this.Controls.SetChildIndex(this.tbImage, 0);
            this.Controls.SetChildIndex(this.btnColor, 0);
            this.Controls.SetChildIndex(this.btnSaveTemplate, 0);
            this.Controls.SetChildIndex(this.btnOpen, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtStopTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStopDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbTitle;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsOpen;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtStopTime;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtStopDate;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtStartTime;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtStartDate;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbServer;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTitle;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.RichTextBox tbContent;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX tbImage;
        private DevComponents.DotNetBar.ButtonX btnOpen;
        private DevComponents.DotNetBar.ButtonX btnSaveTemplate;
        private DevComponents.DotNetBar.ButtonX btnColor;
    }
}