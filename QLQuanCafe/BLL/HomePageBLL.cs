using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using QLQuanCafe.Common;
using QLQuanCafe.DAO;
using QLQuanCafe.DTO;
using QLQuanCafe.GUI;
using QLQuanCafe.GUI.Dialog;
using QLQuanCafe.GUI.UserControl;

namespace QLQuanCafe.BLL
{
    public class HomePageBll : BllBase
    {
        public delegate void UpdateView(object myObject, 
                                             EventArgs myArgs);
        public event UpdateView OnUpdateView;
        /// <summary>
        /// Các thao tác trên bàn.
        /// </summary>
        private enum Action
        {
            Normal,
            ChangeTable,
            GroupTable
        }


        private Action _action;

        private bool _isNewBillDetail;

        #region Properties

        private List<TableData> _listTable;

        public List<TableData> ListTable
        {
            get { return _listTable; }
            set { SetProperty(ref _listTable, value); }
        }

        private TableData _tableSelected;

        public TableData TableSelected
        {
            get { return _tableSelected; }
            set
            {
                if (SetProperty(ref _tableSelected, value))
                {
                    try
                    {
                        BillData bill = LocatorDataSource.BillDS.GetLastBill(TableSelected);
                        if (bill != null)
                        {
                            BillOfTableSelected = bill;
                        }

                        ((RelayCommand<object>) OpenTableCommand).RaiseCanExecuteChanged();
                        ((RelayCommand<object>) ChangeTableCommand).RaiseCanExecuteChanged();
                    }
                    catch (MySqlException ex)
                    {
                        MessageDialogHelper.CreateErrorMessage(ex.Message);
                    }
                }
            }
        }

        private List<MenuItemData> _listMenuItem;

        public List<MenuItemData> ListMenuItem
        {
            get { return _listMenuItem; }
            set { SetProperty(ref _listMenuItem, value); }
        }

        private BillData _billOfTableSelected;

        public BillData BillOfTableSelected
        {
            get { return _billOfTableSelected; }
            set
            {
                if (SetProperty(ref _billOfTableSelected, value))
                {
                    try
                    {
                        BillDetaisOfTableSelected = LocatorDataSource.BillDetailDS.GetAllBillDetail(BillOfTableSelected);
                        ((RelayCommand<object>) GroupTableCommand).RaiseCanExecuteChanged();
                        ((RelayCommand<object>) UnGroupTableCommand).RaiseCanExecuteChanged();
                    }
                    catch (MySqlException ex)
                    {
                        MessageDialogHelper.CreateErrorMessage(ex.Message);
                    }
                }
            }
        }

        private List<BillDetailData> _billDetaisOfTableSelected;

        public List<BillDetailData> BillDetaisOfTableSelected
        {
            get { return _billDetaisOfTableSelected; }
            set
            {
                if (SetProperty(ref _billDetaisOfTableSelected, value))
                {
                    ((RelayCommand<object>) PayBillCommand).RaiseCanExecuteChanged();
                }
            }
        }

        private BillDetailData _billDetaiSelected;

        public BillDetailData BillDetaiSelected
        {
            get { return _billDetaiSelected; }
            set { SetProperty(ref _billDetaiSelected, value); }
        }

        private List<BillData> _listBillToday;

        public List<BillData> ListBillToday
        {
            get { return _listBillToday; }
            set { SetProperty(ref _listBillToday, value); }
        }

        private List<MenuCategoryData> _listMenuCategory;

        public List<MenuCategoryData> ListMenuCategory
        {
            get { return _listMenuCategory; }
            set { SetProperty(ref _listMenuCategory, value); }
        }

        private MenuCategoryData _menuCategorySelected;

        public MenuCategoryData MenuCategorySelected
        {
            get { return _menuCategorySelected; }
            set
            {
                if (SetProperty(ref _menuCategorySelected, value))
                {
                    if (MenuCategorySelected != null)
                    {
                        try
                        {
                            SearchTextMenuItem = string.Empty;
                            ListMenuItem = LocatorDataSource.MenuItemDS.FindMenuItems(SearchTextMenuItem,
                                MenuCategorySelected.MenuCategoryId);
                        }
                        catch (MySqlException ex)
                        {
                            MessageDialogHelper.CreateErrorMessage(ex.Message);
                        }
                    }
                }
            }
        }

        private string _searchTextMenuItem;

        public string SearchTextMenuItem
        {
            get { return _searchTextMenuItem; }
            set { SetProperty(ref _searchTextMenuItem, value); }
        }

        #endregion

        #region Commands

        /// <summary>
        /// Command xảy ra khi một bàn trong list bàn được chọn.
        /// </summary>
        private ICommand _selectTableCommand;

        public ICommand SelectTableCommand
        {
            get
            {
                if (_selectTableCommand == null)
                    _selectTableCommand = new RelayCommand<object>(
                        p => SelectTableAction(p),
                        p => true);
                return _selectTableCommand;
            }
            set { _selectTableCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi mở bàn.
        /// </summary>
        private ICommand _openTableCommand;

        public ICommand OpenTableCommand
        {
            get
            {
                if (_openTableCommand == null)
                    _openTableCommand = new RelayCommand<object>(
                        p => OpenTableAction(),
                        p => TableSelected != null && TableSelected.TableState == "Trong");
                return _openTableCommand;
            }
            set { _openTableCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi hủy bàn.
        /// </summary>
        private ICommand _closeTableCommand;

        public ICommand CloseTableCommand
        {
            get
            {
                if (_closeTableCommand == null)
                    _closeTableCommand = new RelayCommand<object>(
                        p => CloseTableAction(),
                        p => true);
                return _closeTableCommand;
            }
            set { _closeTableCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi đặt bàn.
        /// </summary>
        private ICommand _orderTableCommand;

        public ICommand OrderTableCommand
        {
            get
            {
                if (_orderTableCommand == null)
                    _orderTableCommand = new RelayCommand<object>(
                        p => OrderTableAction(),
                        p => true);
                return _orderTableCommand;
            }
            set { _orderTableCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi hủy đặt bàn.
        /// </summary>
        private ICommand _cancelOrderTableCommand;

        public ICommand CancelOrderTableCommand
        {
            get
            {
                if (_cancelOrderTableCommand == null)
                    _cancelOrderTableCommand = new RelayCommand<object>(
                        p => CancelOrderTableAction(),
                        p => true);
                return _cancelOrderTableCommand;
            }
            set { _cancelOrderTableCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi chuyển bàn.
        /// </summary>
        private ICommand _changeTableCommand;

        public ICommand ChangeTableCommand
        {
            get
            {
                if (_changeTableCommand == null)
                    _changeTableCommand = new RelayCommand<object>(
                        p => ChangeTableAction(),
                        p => TableSelected != null && TableSelected.TableState == "CoNguoi");
                return _changeTableCommand;
            }
            set { _changeTableCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi gộp bàn.
        /// </summary>
        private ICommand _groupTableCommand;

        public ICommand GroupTableCommand
        {
            get
            {
                if (_groupTableCommand == null)
                    _groupTableCommand = new RelayCommand<object>(
                        p => GroupTableAction(),
                        p => BillOfTableSelected != null && BillOfTableSelected.TableLiquidate != null &&
                             BillOfTableSelected.Table != null &&
                             BillOfTableSelected.TableLiquidate.TableId == BillOfTableSelected.Table.TableId);
                return _groupTableCommand;
            }
            set { _groupTableCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi tách bàn.
        /// </summary>
        private ICommand _unGroupTableCommand;

        public ICommand UnGroupTableCommand
        {
            get
            {
                if (_unGroupTableCommand == null)
                    _unGroupTableCommand = new RelayCommand<object>(
                        p => UnGroupTableAction(),
                        p => BillOfTableSelected != null && BillOfTableSelected.TableLiquidate != null &&
                             BillOfTableSelected.Table != null &&
                             BillOfTableSelected.TableLiquidate.TableId != BillOfTableSelected.Table.TableId);
                return _unGroupTableCommand;
            }
            set { _unGroupTableCommand = value; }
        }

        /// <summary>
        /// Command xảy ra chọn loại món ăn để xem các món ăn trong đó.
        /// </summary>
        private ICommand _selectMenuCategoryCommand;

        public ICommand SelectMenuCategoryCommand
        {
            get
            {
                if (_selectMenuCategoryCommand == null)
                    _selectMenuCategoryCommand = new RelayCommand<object>(
                        p => SelectMenuCategoryAction(p),
                        p => true);
                return _selectMenuCategoryCommand;
            }
            set { _selectMenuCategoryCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi chọn một món ăn mà khách yêu cầu.
        /// </summary>
        private ICommand _selectMenuItemCommand;

        public ICommand SelectMenuItemCommand
        {
            get
            {
                if (_selectMenuItemCommand == null)
                    _selectMenuItemCommand = new RelayCommand<object>(
                        p => SelectMenuItemAction(p),
                        p => true);
                return _selectMenuItemCommand;
            }
            set { _selectMenuItemCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi bấm nút search món ăn.
        /// </summary>
        private ICommand _searchMenuItemCommand;

        public ICommand SearchMenuItemCommand
        {
            get
            {
                if (_searchMenuItemCommand == null)
                    _searchMenuItemCommand = new RelayCommand<object>(
                        p =>
                        {
                            try
                            {
                                ListMenuItem = LocatorDataSource.MenuItemDS.FindMenuItems(SearchTextMenuItem,
                                    MenuCategorySelected.MenuCategoryId);
                            }
                            catch (MySqlException ex)
                            {
                                MessageDialogHelper.CreateErrorMessage(ex.Message);
                            }
                        },
                        p => true);
                return _searchMenuItemCommand;
            }
            set { _searchMenuItemCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi bấm nút Ok trong phần yêu cầu món ăn.
        /// </summary>
        private ICommand _acceptRequireMenuItemCommand;

        public ICommand AcceptRequireMenuItemCommand
        {
            get
            {
                if (_acceptRequireMenuItemCommand == null)
                    _acceptRequireMenuItemCommand = new RelayCommand<object>(
                        p => AcceptRequireMenuItemAction(),
                        p => true);
                return _acceptRequireMenuItemCommand;
            }
            set { _acceptRequireMenuItemCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi muốn thay đổi số lượng của món đã chọn.
        /// </summary>
        private ICommand _selectBillDetailCommand;

        public ICommand SelectBillDetailCommand
        {
            get
            {
                if (_selectBillDetailCommand == null)
                    _selectBillDetailCommand = new RelayCommand<object>(
                        p => SelectBillDetailAction(p),
                        p => true);
                return _selectBillDetailCommand;
            }
            set { _selectBillDetailCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi hủy chi tiết hóa đơn trong hóa đơn.
        /// </summary>
        private ICommand _deleteBillDetailCommand;

        public ICommand DeleteBillDetailCommand
        {
            get
            {
                if (_deleteBillDetailCommand == null)
                    _deleteBillDetailCommand = new RelayCommand<object>(
                        p => DeleteBillDetailAction(),
                        p => BillDetaiSelected != null && BillDetaiSelected.IsPrepare == false);
                return _deleteBillDetailCommand;
            }
            set { _deleteBillDetailCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi nhấn vào nút chuẩn bị món.
        /// Cập nhật tất cả các chi tiết hóa đơn mà chưa chuẩn bị thành chuẩn bị.
        /// </summary>
        private ICommand _prepareBillDetailsCommand;

        public ICommand PrepareBillDetailsCommand
        {
            get
            {
                if (_prepareBillDetailsCommand == null)
                    _prepareBillDetailsCommand = new RelayCommand<object>(
                        p => PrepareBillDetailsAction(),
                        p => true);
                return _prepareBillDetailsCommand;
            }
            set { _prepareBillDetailsCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi nhấn vào nút thanh toán.
        /// </summary>
        private ICommand _payBillCommand;

        public ICommand PayBillCommand
        {
            get
            {
                if (_payBillCommand == null)
                    _payBillCommand = new RelayCommand<object>(
                        p => PayBillAction(),
                        p => BillDetaisOfTableSelected != null && BillDetaisOfTableSelected.Count > 0 &&
                             BillDetaisOfTableSelected.FindAll(b => b.IsPrepare).Count ==
                             BillDetaisOfTableSelected.Count);
                return _payBillCommand;
            }
            set { _payBillCommand = value; }
        }

        #endregion

        #region Command Action

        private void SelectTableAction(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (_action == Action.Normal)
                    {
                        TableData tableSelected = obj as TableData;
                        TableSelected = LocatorDataSource.TableDS.GetTable(tableSelected);
                    }
                    else if (_action == Action.ChangeTable)
                    {
                        TableData tableSelected = obj as TableData;
                        if (tableSelected != null && tableSelected.TableState != "Trong")
                        {
                            MessageDialogHelper.CreateErrorMessage("Chỉ được chuyển đến bàn trống.");
                            return;
                        }
                        if (tableSelected != null)
                        {
                            LocatorDataSource.BillDS.ChangeBill(BillOfTableSelected.BillId, tableSelected.TableId);

                            MessageDialogHelper.CreateInformationMessage("Đã chuyển bàn thành công!\ntừ bàn " +
                                                                         TableSelected.TableName + " đến bàn " +
                                                                         tableSelected.TableName + ".");

                            ListTable = LocatorDataSource.TableDS.GetAllTable();
                            TableSelected = LocatorDataSource.TableDS.GetTable(tableSelected);
                            OnUpdateView(this , new EventArgs());
                        }
                        _action = Action.Normal;
                    }
                    else if (_action == Action.GroupTable)
                    {
                        TableData tableSelected = obj as TableData;

                        if (tableSelected != null && tableSelected.TableId == TableSelected.TableId)
                        {
                            return;
                        }
                        if (tableSelected != null && tableSelected.TableState != "CoNguoi")
                        {
                            MessageDialogHelper.CreateInformationMessage("Chỉ được gộp với bàn đã có người.");
                            return;
                        }
                        BillData billOfTableSelected = LocatorDataSource.BillDS.GetLastBill(tableSelected);
                        if (billOfTableSelected != null && billOfTableSelected.TableLiquidate != null &&
                            billOfTableSelected.Table != null &&
                            billOfTableSelected.Table.TableId != billOfTableSelected.TableLiquidate.TableId)
                        {
                            MessageDialogHelper.CreateInformationMessage("Bàn này đã được gộp với bàn khác.");
                            return;
                        }

                        if (tableSelected != null)
                        {
                            LocatorDataSource.BillDS.GroupBill(BillOfTableSelected.BillId, tableSelected.TableId);

                            MessageDialogHelper.CreateInformationMessage("Đã gộp thành công bàn " + TableSelected.TableName +
                                                                         " và bàn " + tableSelected.TableName + ".");

                            ListTable = LocatorDataSource.TableDS.GetAllTable();
                            TableSelected = LocatorDataSource.TableDS.GetTable(tableSelected);
                            OnUpdateView(this, new EventArgs());
                        }
                        _action = Action.Normal;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        private void OpenTableAction()
        {
            if (TableSelected != null && TableSelected.TableState != "CoNguoi")
            {
                BillOfTableSelected = new BillData();
                BillOfTableSelected.Table = TableSelected;

                // Thêm mới hóa đơn cho bàn mới mở.
                try
                {
                    LocatorDataSource.BillDS.AddBill(BillOfTableSelected);

                    TableSelected = LocatorDataSource.TableDS.GetTable(TableSelected);

                    // Update lại trạng thái cho bàn ngoài list.
                    TableData tableChanged = ListTable.SingleOrDefault(p => p.TableId == TableSelected.TableId);
                    if (tableChanged != null) tableChanged.TableState = TableSelected.TableState;
                }
                catch (MySqlException ex)
                {
                    MessageDialogHelper.CreateErrorMessage(ex.Message);
                }
            }
        }

        private void CloseTableAction()
        {
            if (TableSelected != null)
            {
                try
                {
                    LocatorDataSource.BillDS.DeleteBill(BillOfTableSelected);

                    TableSelected = LocatorDataSource.TableDS.GetTable(TableSelected);

                    // Update lại trạng thái cho bàn ngoài list.
                    TableData tableChanged = ListTable.SingleOrDefault(p => p.TableId == TableSelected.TableId);
                    if (tableChanged != null) 
                        tableChanged.TableState = TableSelected.TableState;
                }
                catch (MySqlException ex)
                {
                    MessageDialogHelper.CreateErrorMessage(ex.Message);
                }
            }
        }

        private void OrderTableAction()
        {
            try
            {
                LocatorDataSource.TableDS.OrderTable(TableSelected);

                TableSelected = LocatorDataSource.TableDS.GetTable(TableSelected);

                // Update lại trạng thái cho bàn ngoài list.
                TableData tableChanged = ListTable.SingleOrDefault(p => p.TableId == TableSelected.TableId);
                if (tableChanged != null) tableChanged.TableState = TableSelected.TableState;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        private void CancelOrderTableAction()
        {
            try
            {
                LocatorDataSource.TableDS.CancelOrderTable(TableSelected);

                TableSelected = LocatorDataSource.TableDS.GetTable(TableSelected);

                // Update lại trạng thái cho bàn ngoài list.
                TableData tableChanged = ListTable.SingleOrDefault(p => p.TableId == TableSelected.TableId);
                if (tableChanged != null) tableChanged.TableState = TableSelected.TableState;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        private void ChangeTableAction()
        {
            if (TableSelected.TableState == "CoNguoi")
            {
                MessageDialogHelper.CreateInformationMessage(
                    "Bạn đang thực hiện thao tác chuyển bàn.\nBạn chỉ có thể chuyển đến bàn trống.\nHãy chọn bàn muốn chuyển đến.");
                _action = Action.ChangeTable;
            }
            else
            {
                MessageDialogHelper.CreateErrorMessage("Chỉ được chuyển bàn có người.");
            }
        }

        private void GroupTableAction()
        {
            if (TableSelected.TableState == "CoNguoi")
            {
                MessageDialogHelper.CreateInformationMessage(
                    "Bạn đang thực hiện thao tác gộp bàn.\nBạn chỉ có thể chuyển gộp với bàn có người.\nHãy chọn bàn muốn gộp với.");
                _action = Action.GroupTable;
            }
            else
            {
                MessageDialogHelper.CreateErrorMessage("Chỉ được chuyển bàn có người.");
            }
        }

        private void UnGroupTableAction()
        {
            try
            {
                if (BillOfTableSelected != null &&
                    BillOfTableSelected.TableLiquidate.TableId != BillOfTableSelected.Table.TableId)
                {
                    // Tách bàn.
                    try
                    {
                        LocatorDataSource.BillDS.UnGroupBill(BillOfTableSelected);

                        ListTable = LocatorDataSource.TableDS.GetAllTable();

                        TableSelected = LocatorDataSource.TableDS.GetTable(TableSelected);
                    }
                    catch (MySqlException ex)
                    {
                        MessageDialogHelper.CreateErrorMessage(ex.Message);
                    }
                }
                else
                {
                    MessageDialogHelper.CreateErrorMessage("Bàn này không gộp với bàn nào.");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void SelectMenuCategoryAction(object obj)
        {
            if (obj != null)
            {
                MenuCategorySelected = obj as MenuCategoryData;
                // Lấy ra bill của bàn.
            }
        }

        private void SelectMenuItemAction(object obj)
        {
            if (obj != null)
            {
                MenuItemData menuItemSelected = obj as MenuItemData;
                BillDetaiSelected = new BillDetailData();
                BillDetaiSelected.BillId = BillOfTableSelected.BillId;
                BillDetaiSelected.MenuItem = menuItemSelected;

                _isNewBillDetail = true;

                //HACK view
                YeuCauMon yeuCauMon = new YeuCauMon();
                yeuCauMon.ShowDialog();
            }
        }

        private void AcceptRequireMenuItemAction()
        {
            if (_isNewBillDetail) // Gọi mới một món
            {
                try
                {
                    LocatorDataSource.BillDetailDS.AddBillDetail(BillDetaiSelected);

                    BillDetaisOfTableSelected = LocatorDataSource.BillDetailDS.GetAllBillDetail(BillOfTableSelected);
                    BillOfTableSelected = LocatorDataSource.BillDS.GetLastBill(TableSelected);
                }
                catch (MySqlException ex)
                {
                    MessageDialogHelper.CreateErrorMessage(ex.Message);
                }
            }
            else // Thay đổi số lượng món được chọn.
            {
                if (BillDetaiSelected.Quantity == 0) // Nếu số lượng thay đổi là 0 thì xóa món đó đi.
                {
                    try
                    {
                        LocatorDataSource.BillDetailDS.DeleteBillDetail(BillDetaiSelected);

                        BillDetaisOfTableSelected = LocatorDataSource.BillDetailDS.GetAllBillDetail(BillOfTableSelected);
                    }
                    catch (MySqlException ex)
                    {
                        MessageDialogHelper.CreateErrorMessage(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        LocatorDataSource.BillDetailDS.UpdateBillDetail(BillDetaiSelected);

                        BillDetaisOfTableSelected = LocatorDataSource.BillDetailDS.GetAllBillDetail(BillOfTableSelected);
                    }
                    catch (MySqlException ex)
                    {
                        MessageDialogHelper.CreateErrorMessage(ex.Message);
                    }
                }
            }
        }

        private void SelectBillDetailAction(object obj)
        {
            if (obj != null)
            {
                BillDetailData billDetail = obj as BillDetailData;
                if (billDetail != null && billDetail.IsPrepare == false)
                {
                    BillDetaiSelected = billDetail;

                    //_isNewBillDetail = false;
//                    GoiMon goiMon =new GoiMon();
//                    goiMon.ShowDialog();
                }
            }
        }

        private void DeleteBillDetailAction()
        {
            try
            {
                LocatorDataSource.BillDetailDS.DeleteBillDetail(BillDetaiSelected);

                BillOfTableSelected = LocatorDataSource.BillDS.GetLastBill(TableSelected);
                BillDetaisOfTableSelected = LocatorDataSource.BillDetailDS.GetAllBillDetail(BillOfTableSelected);
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        private void PrepareBillDetailsAction()
        {
            try
            {
                LocatorDataSource.BillDS.PrepareBill(BillOfTableSelected);

                BillDetaisOfTableSelected = LocatorDataSource.BillDetailDS.GetAllBillDetail(BillOfTableSelected);
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        private void PayBillAction()
        {
            try
            {
                String billID = BillOfTableSelected.BillId;
                BillData bill = LocatorDataSource.BillDS.GetLastBill(TableSelected);
               
                LocatorDataSource.BillDS.PayBill(BillOfTableSelected);

                TableSelected = LocatorDataSource.TableDS.GetTable(TableSelected);

                // Update lại trạng thái cho bàn ngoài list.
                ListTable = LocatorDataSource.TableDS.GetAllTable();

                ListBillToday = LocatorDataSource.BillDS.FindBill(DateTime.Now, DateTime.Now, "", "");
               
               
                //Xuat bill
                //HACK VIEW
                XacNhanThanhToan xacNhanThanhToan = new XacNhanThanhToan(bill);
               
                xacNhanThanhToan.ShowDialog();

                //BillWindow billWindow = new BillWindow(billID);
                //billWindow.ShowDialog();
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        #endregion

        #region Methods

        public override void Load()
        {
            try
            {
                ListTable = LocatorDataSource.TableDS.GetAllTable();

                ListMenuCategory = LocatorDataSource.MenuCategoryDS.GetAllMenuCategoryToChoose();
                MenuCategorySelected = ListMenuCategory[0];
                ListBillToday = LocatorDataSource.BillDS.FindBill(DateTime.Now, DateTime.Now, "", "");

                _action = Action.Normal;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        #endregion
    }
}