using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using FengNiao.GameToolsCommon;
using System.Net;
using GameToolsCommon;

namespace GameToolsClient
{
    public partial class FirstRecharge :BaseForm
    {
        public FirstRecharge()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.TopMostBox = false;


           // loadingControl.Dock = DockStyle.Fill;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RefreshLayout();
        }

        private void RefreshLayout()
        {
            //if (this.IsHandleCreated && gvDataList.IsHandleCreated)
            {
                //panelParent.Left = base.ClientBounds.X;
                //panelParent.Top = base.ClientBounds.Y;
                //panelParent.Width = base.ClientBounds.Width;
                //panelParent.Height = base.ClientBounds.Height;
            }
        }

        private void FirstRecharge_Load(object sender, EventArgs e)
        {
            RefreshLayout();
            Init();
        }

        private void Init()
        {
           // loadingControl.Visible = true;
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.First_Recharge, HttpMethodType.GetList);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
        }
        private void btnMin_Load(object sender, EventArgs e)
        {

        }

        private void pbTitleCaption_Click(object sender, EventArgs e)
        {

        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            //FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            //if (serverData == null)
            {
            //    CustomMessageBox.Error(this, "没有选择服务器");
             //   return;
            }
            FirstRechargeAddInfo frmNoticeConfigDetails = new FirstRechargeAddInfo();
            frmNoticeConfigDetails.SetParent(this);
            if (frmNoticeConfigDetails.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                //GetList();
            }
            //frmNoticeConfigDetails.GetData();
            //frmNoticeConfigDetails.Close();
            //string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.First_Recharge, HttpMethodType.GetList);
            //CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
        }
        Color errorColor = Color.DarkGray;
        Color successColor = Color.GreenYellow;
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isError = false;
            string strErrorMsg = string.Empty;

            List<OperationType> operationTypes = new List<OperationType>();
            List<FengNiao.GMTools.Database.Model.tbl_first_recharge> dataList = new List<FengNiao.GMTools.Database.Model.tbl_first_recharge>();
            List<string> guidList = new List<string>();
            for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
            {
               

                int cellIndex = 0;
                 long record_id = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    record_id = long.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                //cellIndex ++;
                //int serverid = 0;
                //if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                //{
                //    serverid = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                //}
                cellIndex++;
                string itemid =null;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    itemid = dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString();
                }

                cellIndex++;
                int index = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    if (int.TryParse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString(), out index))
                        index = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                    else
                    {
                        CustomMessageBox.Error(this, "请确认item为数值类型");
                        return;
                    }
                }

                cellIndex++;
                string name = string.Empty;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    name = dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString();
                    //isError = true;
                    //dataGridViewX1.Rows[i].DefaultCellStyle.BackColor = errorColor;
                    //dataGridViewX1.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                }
                cellIndex++;
                string dec = string.Empty;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    dec = dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString();
                }
                cellIndex++;
                int icon = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    icon = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int RMBprice = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    RMBprice = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int IsOnlyOnce = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    IsOnlyOnce = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int diamonds = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    diamonds = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int giveDiamonds = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    giveDiamonds = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int normalGiveDiamonds = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    normalGiveDiamonds = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int activeGiveDiamonds = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    activeGiveDiamonds = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                DateTime activeStartTime = DateTime.Now;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    activeStartTime = DateTime.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                DateTime activeEndTime = DateTime.Now;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    activeEndTime = DateTime.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int isWeekCard = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    isWeekCard = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int isMonthCard = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    isMonthCard = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                string channel = string.Empty;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    channel = dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString();
                }
                cellIndex++;
                int sellStatc = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    sellStatc = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int FirstRechargeItem1 = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    FirstRechargeItem1 = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int Num1 = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    Num1 = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int FirstRechargeItem2 = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    FirstRechargeItem2 = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int Num2 = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    Num2 = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int FirstRechargeItem3 = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    FirstRechargeItem3 = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int Num3 = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    Num3 = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int FirstRechargeItem4 = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    FirstRechargeItem4 = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int Num4 = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    Num4 = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int FirstRechargeItem5 = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    FirstRechargeItem5 = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int Num5 = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    Num5 = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int FirstRechargeItem6 = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    FirstRechargeItem6 = int.Parse(dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int Num6 = 0;
                if (dataGridViewX1.Rows[i].Cells[cellIndex].Value != null)
                {
                    string str = dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString();
                    Num6 = int.Parse(str);
                }

                cellIndex = 31;
                string guid = dataGridViewX1.Rows[i].Cells[cellIndex].Value.ToString();

                if (dataGridViewX1.Rows[i].Tag == null)
                {
                    FengNiao.GMTools.Database.Model.tbl_first_recharge data = new FengNiao.GMTools.Database.Model.tbl_first_recharge();
                    //data.serverid = serverid;
                    data.itemid = itemid;
                    data.index = index;
                    data.name = name;
                    data.dec = dec;
                    data.icon = icon;
                    data.RMBprice = RMBprice;

                    data.IsOnlyOnce = IsOnlyOnce;
                    data.diamonds = diamonds;
                    data.giveDiamonds = giveDiamonds;
                    data.normalGiveDiamonds = normalGiveDiamonds;
                    data.activeGiveDiamonds = activeGiveDiamonds;
                    data.activeStartTime = activeStartTime;
                    data.activeEndTime = activeEndTime;

                    data.isWeekCard = isWeekCard;
                    data.isMonthCard = isMonthCard;
                    data.channel = channel;
                    data.sellStatc = sellStatc;
                    data.FirstRechargeItem1 = FirstRechargeItem1;
                    data.Num1 = Num1;
                    data.FirstRechargeItem2 = FirstRechargeItem2;
                    data.Num2 = Num2;
                    data.FirstRechargeItem3 = FirstRechargeItem3;
                    data.Num3 = Num3;
                    data.FirstRechargeItem4 = FirstRechargeItem4;
                    data.Num4 = Num4;
                    data.FirstRechargeItem5 = FirstRechargeItem5;
                    data.Num5 = Num5;
                    data.FirstRechargeItem6 = FirstRechargeItem6;
                    data.Num6 = Num6;


                    dataList.Add(data);
                    operationTypes.Add(OperationType.Add);
                    guidList.Add(guid);
                }
                else
                {
                    FengNiao.GMTools.Database.Model.tbl_first_recharge data = dataGridViewX1.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_first_recharge;
                    data.record_id = record_id;
                    //data.serverid = serverid;
                    data.itemid = itemid;
                    data.index = index;
                    data.name = name;
                    data.dec = dec;
                    data.icon = icon;
                    data.RMBprice = RMBprice;

                    data.IsOnlyOnce = IsOnlyOnce;
                    data.diamonds = diamonds;
                    data.giveDiamonds = giveDiamonds;
                    data.normalGiveDiamonds = normalGiveDiamonds;
                    data.activeGiveDiamonds = activeGiveDiamonds;
                    data.activeStartTime = activeStartTime;
                    data.activeEndTime = activeEndTime;

                    data.isWeekCard = isWeekCard;
                    data.isMonthCard = isMonthCard;
                    data.channel = channel;
                    data.sellStatc = sellStatc;
                    data.FirstRechargeItem1 = FirstRechargeItem1;
                    data.Num1 = Num1;
                    data.FirstRechargeItem2 = FirstRechargeItem2;
                    data.Num2 = Num2;
                    data.FirstRechargeItem3 = FirstRechargeItem3;
                    data.Num3 = Num3;
                    data.FirstRechargeItem4 = FirstRechargeItem4;
                    data.Num4 = Num4;
                    data.FirstRechargeItem5 = FirstRechargeItem5;
                    data.Num5 = Num5;
                    data.FirstRechargeItem6 = FirstRechargeItem6;
                    data.Num6 = Num6;

                    dataList.Add(data);
                    operationTypes.Add(OperationType.Update);
                    guidList.Add(guid);
                }
            }
            if (isError)
            {
                CustomMessageBox.Error(this, "保存失败，请根据提示检查数据");
            }
            else
            {
                
                //if (dataList.Count == operationTypes.Count)
                if (dataList.Count == operationTypes.Count && dataList.Count == guidList.Count)
                {
                    dataGridViewX1.Visible = true;
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        dataGridViewX1.Rows[i].Tag = dataList[i];
                    }

                    string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.First_Recharge, HttpMethodType.Update);
                    string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_first_recharge>>(dataList);
                    string strOperationTypes = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<OperationType>>(operationTypes);
                    string strGuids = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(guidList);
                    strArgs = string.Format("{0}&Model={1}&OperationType={2}&guid={3}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8), strOperationTypes, strGuids);
                    CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, UpdateCallback);
                }
            }
        }
        private void UpdateCallback(object sender, UploadDataCompletedEventArgs e)
        {

            //loadingControl.Visible = false;
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        List<OperateResultModel> resultModelList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<OperateResultModel>(requestResultModel.Content);
                        foreach (OperateResultModel resultModel in resultModelList)
                        {
                            int rowIndex = GetRowIndexByGuid(resultModel.Guid);
                            if (rowIndex != -1)
                            {
                                if (resultModel.IsSuccess)
                                {
                                    dataGridViewX1.Rows[rowIndex].Cells[1].Style.BackColor = successColor;
                                }
                                else
                                {
                                    dataGridViewX1.Rows[rowIndex].Tag = null;
                                    dataGridViewX1.Rows[rowIndex].Cells[1].Style.BackColor = errorColor;
                                    dataGridViewX1.Rows[rowIndex].Cells[1].ErrorText = resultModel.Content;
                                }
                            }
                        }
                        CustomMessageBox.Info(this, "保存完毕");
                        Init();
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("保存失败\r\n{0}", requestResultModel.Content));
                    }
                }
                catch
                {
                    CustomMessageBox.Error(this, "服务器返回的数据无效");
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Init();
        }
        private int GetRowIndexByGuid(string guid)
        {
            /*for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
            {
                if (dataGridViewX1.Rows[i].Cells[31].Value.ToString().Equals(guid))
                {
                    return i;
                }
            }*/
            return -1;
        }
        private void GetListCallback(object sender, UploadDataCompletedEventArgs e)
        {
            //loadingControl.Visible = false;
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        List<FengNiao.GMTools.Database.Model.tbl_first_recharge> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_first_recharge>(requestResult.Content);
                        GlobalObject.FirstRechargeList = dataList;
                        InitList(GlobalObject.FirstRechargeList);
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("获取数据失败\r\n{0}", requestResult.Content));
                    }
                }
                catch
                {
                    CustomMessageBox.Error(this, "服务器返回的数据无效");
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
        }
        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_first_recharge> dataList)
        {

            dataGridViewX1.Rows.Clear();
            int i = 0;
            foreach (FengNiao.GMTools.Database.Model.tbl_first_recharge data in dataList)
            {
                int rowIndex = dataGridViewX1.Rows.Add(data.record_id, data.itemid, data.index,
                    data.name,data.dec,data.icon,data.RMBprice,data.IsOnlyOnce,data.diamonds,
                    data.giveDiamonds,data.normalGiveDiamonds,data.activeGiveDiamonds,data.activeStartTime,
                    data.activeEndTime,data.isWeekCard,data.isMonthCard,data.channel,data.sellStatc,
                    data.FirstRechargeItem1,data.Num1,data.FirstRechargeItem2,data.Num2,data.FirstRechargeItem3,
                    data.Num3,data.FirstRechargeItem4,data.Num4,data.FirstRechargeItem5,data.Num5,data.FirstRechargeItem6,
                    data.Num6);
                dataGridViewX1.Rows[rowIndex].Tag = data;
               //int rowIndex = dataGridViewX1.Rows.Add(data.fld_record_id, data.fld_notice, data.fld_tester_notice, data.fld_package_name, data.fld_version, data.fld_create_time, data.fld_modif_time);
               // dataGridViewX1.Rows[rowIndex].Cells[7] = GlobalObject.GetCommonCell("启用", "禁用");
               // dataGridViewX1.Rows[rowIndex].Cells[7].Value = data.fld_deleted;
               // dataGridViewX1.Rows[rowIndex].Tag = data;
                dataGridViewX1.Rows[rowIndex].Cells[31].Value = Guid.NewGuid();
            }
        }
        public void AddlocalRowInfo(FengNiao.GMTools.Database.Model.tbl_first_recharge data)
        {
            int count = dataGridViewX1.Rows.Count;
            int rowIndex = dataGridViewX1.Rows.Add(data.record_id, data.itemid, data.index,
                    data.name, data.dec, data.icon, data.RMBprice, data.IsOnlyOnce, data.diamonds,
                    data.giveDiamonds, data.normalGiveDiamonds, data.activeGiveDiamonds, data.activeStartTime,
                    data.activeEndTime, data.isWeekCard, data.isMonthCard, data.channel, data.sellStatc,
                    data.FirstRechargeItem1, data.Num1, data.FirstRechargeItem2, data.Num2, data.FirstRechargeItem3,
                    data.Num3, data.FirstRechargeItem4, data.Num4, data.FirstRechargeItem5, data.Num5, data.FirstRechargeItem6,
                    data.Num6);
            dataGridViewX1.Rows[rowIndex].Cells[31].Value = Guid.NewGuid();
        }

        public bool isCanAdd(int chanel, string item, int index)
        {
            for(int i = 0 ;i < dataGridViewX1.RowCount;i++)
            {
                int value;
                if(int.TryParse(dataGridViewX1.Rows[i].Cells[16].Value.ToString(), out value))
                {
                    if(value==chanel)
                    {
                        if (item == dataGridViewX1.Rows[i].Cells[1].Value.ToString())
                            return false;
                        int.TryParse(dataGridViewX1.Rows[i].Cells[2].Value.ToString(), out value);
                        if (value == index)
                            return false;
                    }

                }
            }
            return true;
            
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > (dataGridViewX1.RowCount - 1) || e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 31)
            {
                if (dataGridViewX1.Rows[e.RowIndex].Tag != null)
                {
                    CustomMessageBox.Error(this, "不能删除已经生效的数据");
                    return;
                }
                if (DialogResult.Yes == CustomMessageBox.Confirm(this, "确定要删除记录么?"))
                {
                    dataGridViewX1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

    }
}
