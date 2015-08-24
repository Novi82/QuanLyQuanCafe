using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using QLQuanCafe.Common;
using QLQuanCafe.DAO;
using QLQuanCafe.DTO;

namespace QLQuanCafe.BLL
{
    public class BillBll : BllBase
    {
        #region Properties

        private DateTime _fromDate;
        public DateTime FromDate
        {
            get { return _fromDate; }
            set { SetProperty(ref _fromDate, value); }
        }

        private DateTime _toDate;
        public DateTime ToDate
        {
            get { return _toDate; }
            set { SetProperty(ref _toDate, value); }
        }

        private List<AreaData> _listArea;
        public List<AreaData> ListArea
        {
            get { return _listArea; }
            set { SetProperty(ref _listArea, value); }
        }

        private AreaData _areaSelected;
        public AreaData AreaSelected
        {
            get { return _areaSelected; }
            set
            {
                if (SetProperty(ref _areaSelected, value))
                {
                    if (AreaSelected != null)
                    {
                        try
                        {
                            ListTable = LocatorDataSource.TableDS.GetAllTableToChoose(AreaSelected);
                            TableSelected = ListTable[0];
                        }
                        catch (MySqlException ex)
                        {
                            MessageDialogHelper.CreateErrorMessage(ex.Message);
                        }
                    }
                }
            }
        }

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
                    if (TableSelected != null && !string.IsNullOrEmpty(TableSelected.TableId))
                    {
                        AreaSelected = ListArea.SingleOrDefault(a => a.AreaId == TableSelected.Area.AreaId);
                    }
                }
            }
        }

        private List<BillData> _listBill;
        public List<BillData> ListBill
        {
            get
            {
                //Load();
                return _listBill;
            }
            set { SetProperty(ref _listBill, value); }
        }


        #endregion

        #region Commands

        private ICommand _selectAreaCommand;
        public ICommand SelectAreaCommand
        {
            get
            {
                if (_selectAreaCommand == null)
                    _selectAreaCommand = new RelayCommand<object>(
                        p => SelectAreaAction(p),
                        p => true);
                return _selectAreaCommand;
            }
            set { _selectAreaCommand = value; }
        }

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

        private ICommand _searchBillCommand;
        public ICommand SearchBillCommand
        {
            get
            {
                if (_searchBillCommand == null)
                    _searchBillCommand = new RelayCommand<object>(
                        p => SearchBillAction(),
                        p => true);
                return _searchBillCommand;
            }
            set { _searchBillCommand = value; }
        }

        private ICommand _refreshBillCommand;
        public ICommand RefreshBillCommand
        {
            get
            {
                if (_refreshBillCommand == null)
                    _refreshBillCommand = new RelayCommand<object>(
                        p => RefreshBillAction(),
                        p => true);
                return _refreshBillCommand;
            }
            set { _refreshBillCommand = value; }
        }

        #endregion

        #region Actions

        private void SelectAreaAction(object obj)
        {
            if (obj != null)
            {
                AreaSelected = obj as AreaData;
            }
        }

        private void SelectTableAction(object obj)
        {
            if (obj != null)
            {
                TableSelected = obj as TableData;
            }
        }

        private void SearchBillAction()
        {
            try
            {
                ListBill = LocatorDataSource.BillDS.FindBill(FromDate, ToDate, TableSelected.TableId, AreaSelected.AreaId);
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        private void RefreshBillAction()
        {
            Load();
        }

        #endregion

        #region Methods

        public override void Load()
        {
            try
            {
                FromDate = DateTime.Now;
                ToDate = DateTime.Now;

                ListArea = LocatorDataSource.AreaDS.GetAllAreaToChoose();
                AreaSelected = ListArea[0];

                ListBill = LocatorDataSource.BillDS.FindBill(FromDate, ToDate, TableSelected.TableId, AreaSelected.AreaId);
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        #endregion
    }
}
