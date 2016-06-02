namespace GameToolsClient
{
    partial class PushNotice
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
            this.btnSend = new DevComponents.DotNetBar.ButtonX();
            this.lbTitle = new DevComponents.DotNetBar.LabelX();
            this.tbTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbContext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dtStartDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dtStopDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtStartTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStopDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSend.Location = new System.Drawing.Point(261, 198);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSend.TabIndex = 53;
            this.btnSend.Text = "保存";
            this.btnSend.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTitle
            // 
            // 
            // 
            // 
            this.lbTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTitle.Location = new System.Drawing.Point(40, 57);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(57, 23);
            this.lbTitle.TabIndex = 43;
            this.lbTitle.Text = "标题：";
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbTitle.Border.Class = "TextBoxBorder";
            this.tbTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTitle.ForeColor = System.Drawing.Color.Black;
            this.tbTitle.Location = new System.Drawing.Point(103, 57);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(304, 32);
            this.tbTitle.TabIndex = 44;
            // 
            // tbContext
            // 
            this.tbContext.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbContext.Border.Class = "TextBoxBorder";
            this.tbContext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbContext.ForeColor = System.Drawing.Color.Black;
            this.tbContext.Location = new System.Drawing.Point(103, 102);
            this.tbContext.Multiline = true;
            this.tbContext.Name = "tbContext";
            this.tbContext.Size = new System.Drawing.Size(304, 33);
            this.tbContext.TabIndex = 44;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(40, 102);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 43;
            this.labelX1.Text = "内容：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX2.Location = new System.Drawing.Point(183, 19);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 23);
            this.labelX2.TabIndex = 43;
            this.labelX2.Text = "通知推送";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(40, 153);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(80, 23);
            this.labelX3.TabIndex = 63;
            this.labelX3.Text = "开始时间：";
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
            this.dtStartDate.Location = new System.Drawing.Point(104, 155);
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
            this.dtStartDate.TabIndex = 64;
            this.dtStartDate.Value = new System.DateTime(2015, 6, 30, 0, 0, 0, 0);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(227, 155);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(80, 23);
            this.labelX4.TabIndex = 66;
            this.labelX4.Text = "结束时间：";
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
            this.dtStopDate.Location = new System.Drawing.Point(291, 157);
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
            this.dtStopDate.TabIndex = 67;
            this.dtStopDate.Value = new System.DateTime(2015, 6, 30, 0, 0, 0, 0);
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
            this.dtStartTime.Location = new System.Drawing.Point(103, 198);
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
            this.dtStartTime.Size = new System.Drawing.Size(117, 21);
            this.dtStartTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtStartTime.TabIndex = 65;
            this.dtStartTime.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            this.dtStartTime.Value = new System.DateTime(2015, 6, 30, 12, 0, 0, 0);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(40, 198);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(67, 23);
            this.labelX5.TabIndex = 63;
            this.labelX5.Text = "发送时间：";
            // 
            // PushNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(446, 255);
            this.CloseBox = true;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tbContext);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dtStopDate);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.dtStartTime);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX3);
            this.IsShowCaptionImage = false;
            this.IsShowCaptionText = false;
            this.IsTitleSplitLine = false;
            this.Name = "PushNotice";
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.dtStartDate, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.dtStartTime, 0);
            this.Controls.SetChildIndex(this.tbTitle, 0);
            this.Controls.SetChildIndex(this.dtStopDate, 0);
            this.Controls.SetChildIndex(this.lbTitle, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.tbContext, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.btnSend, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStopDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSend;
        private DevComponents.DotNetBar.LabelX lbTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContext;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtStartDate;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtStopDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtStartTime;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}
