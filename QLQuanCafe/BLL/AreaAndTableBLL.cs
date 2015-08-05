using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using QLQuanCafe.Common;
using QLQuanCafe.DAO;
using QLQuanCafe.DTO;

namespace QLQuanCafe.BLL
{
    public class AreaAndTableBll : BllBase
    {
        #region Properties

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
                    ((RelayCommand<object>)ShowEditAreaWindowCommand).RaiseCanExecuteChanged();
                    ((RelayCommand<object>)DeleteAreaCommand).RaiseCanExecuteChanged();
                }
            }
        }

        private AreaData _areaToSave;
        public AreaData AreaToSave
        {
            get { return _areaToSave; }
            set
            {
                SetProperty(ref _areaToSave, value);
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
                    ((RelayCommand<object>)ShowEditTableWindowCommand).RaiseCanExecuteChanged();
                    ((RelayCommand<object>)DeleteTableCommand).RaiseCanExecuteChanged();
                }
            }
        }

        private TableData _tableToSave;
        public TableData TableToSave
        {
            get { return _tableToSave; }
            set
            {
                SetProperty(ref _tableToSave, value);
            }
        }

        #endregion

        #region Commands

        /// <summary>
        /// Command xảy ra khi chọn một khu vực.
        /// </summary>
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

        /// <summary>
        /// Command xảy ra khi nhấn thêm khu vực.
        /// </summary>
        private ICommand _showAddAreaWindowCommand;
        public ICommand ShowAddAreaWindowCommand
        {
            get
            {
                if (_showAddAreaWindowCommand == null)
                    _showAddAreaWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            AreaToSave = new AreaData();
                            //HACK form view
                            //AddAreaWindow addAreaWindow = new AddAreaWindow(); 
                            //addAreaWindow.ShowDialog();
                        },
                        p => true);
                return _showAddAreaWindowCommand;
            }
            set { _showAddAreaWindowCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi nhấn sửa khu vực.
        /// </summary>
        private ICommand _showEditAreaWindowCommand;
        public ICommand ShowEditAreaWindowCommand
        {
            get
            {
                if (_showEditAreaWindowCommand == null)
                    _showEditAreaWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            AreaToSave = new AreaData
                            {
                                AreaId = AreaSelected.AreaId,
                                AreaName = AreaSelected.AreaName
                            };
                            // HACK from view
                            //EditAreaWindow editAreaWindow = new EditAreaWindow();
                            //editAreaWindow.ShowDialog();
                        },
                        p => AreaSelected != null);
                return _showEditAreaWindowCommand;
            }
            set { _showEditAreaWindowCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi nhấn xóa khu vực.
        /// </summary>
        private ICommand _deleteAreaCommand;
        public ICommand DeleteAreaCommand
        {
            get
            {
                if (_deleteAreaCommand == null)
                    _deleteAreaCommand = new RelayCommand<object>(
                        p =>
                        {
                            try
                            {
                                LocatorDataSource.AreaDS.DeleteArea(AreaSelected);

                                if (MessageDialogHelper.CreateInformationMessage("Đã xóa thành công khu vực") == DialogResult.OK)
                                {
                                    ListArea = LocatorDataSource.AreaDS.GetAllArea();
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageDialogHelper.CreateErrorMessage(ex.Message);
                            }
                        },
                        p => AreaSelected != null);
                return _deleteAreaCommand;
            }
            set { _deleteAreaCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi chọn một bàn.
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
        /// Command xảy ra khi nhấn thêm bàn.
        /// </summary>
        private ICommand _showAddTableWindowCommand;
        public ICommand ShowAddTableWindowCommand
        {
            get
            {
                if (_showAddTableWindowCommand == null)
                    _showAddTableWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            TableToSave = new TableData
                            {
                                Area = AreaSelected
                            };
                            //HACK from view
                            //AddTableWindow addTableWindow = new AddTableWindow();
                            //addTableWindow.ShowDialog();

                        },
                        p => AreaSelected != null);
                return _showAddTableWindowCommand;
            }
            set { _showAddTableWindowCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi nhấn sửa bàn.
        /// </summary>
        private ICommand _showEditTableWindowCommand;
        public ICommand ShowEditTableWindowCommand
        {
            get
            {
                if (_showEditTableWindowCommand == null)
                    _showEditTableWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            TableToSave = new TableData
                            {
                                TableId = TableSelected.TableId,
                                TableName = TableSelected.TableName,
                                Area = AreaSelected
                            };
                            //HACK from view
                            //EditTableWindow editTableWindow = new EditTableWindow();
                            //editTableWindow.ShowDialog();
                        },
                        p => TableSelected != null);
                return _showEditTableWindowCommand;
            }
            set { _showEditTableWindowCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi nhấn xóa bàn.
        /// </summary>
        private ICommand _deleteTableCommand;
        public ICommand DeleteTableCommand
        {
            get
            {
                if (_deleteTableCommand == null)
                    _deleteTableCommand = new RelayCommand<object>(
                        p =>
                        {
                            try
                            {
                                LocatorDataSource.TableDS.DeleteTable(TableSelected);

                                if (MessageDialogHelper.CreateInformationMessage("Đã xóa thành công bàn") == DialogResult.OK)
                                {
                                    ListTable = LocatorDataSource.TableDS.GetAllTable(AreaSelected);
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageDialogHelper.CreateErrorMessage(ex.Message);
                            }
                        },
                        p => TableSelected != null);
                return _deleteTableCommand;
            }
            set { _deleteTableCommand = value; }
        }

        #endregion

        #region Actions

        private void SelectAreaAction(object obj)
        {
            if (obj != null)
            {
                AreaSelected = obj as AreaData;

                ListTable = LocatorDataSource.TableDS.GetAllTable(AreaSelected);
            }
        }

        private void SelectTableAction(object obj)
        {
            if (obj != null)
            {
                TableSelected = obj as TableData;
            }
        }

        #endregion

        #region Methods

        public override void Load()
        {
            try
            {
                ListArea = LocatorDataSource.AreaDS.GetAllArea();
                AreaSelected = null;
                ListTable = null;
                TableSelected = null;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        public bool AddArea()
        {
            try
            {
                LocatorDataSource.AreaDS.AddArea(AreaToSave);

                ListArea = LocatorDataSource.AreaDS.GetAllArea();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);

                return false;
            }
        }

        public bool EditArea()
        {
            try
            {
                LocatorDataSource.AreaDS.UpdateArea(AreaToSave);

                ListArea = LocatorDataSource.AreaDS.GetAllArea();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);

                return false;
            }
        }

        public bool AddTable()
        {
            try
            {
                LocatorDataSource.TableDS.AddTable(TableToSave);

                ListTable = LocatorDataSource.TableDS.GetAllTable(AreaSelected);

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);

                return false;
            }
        }

        public bool EditTable()
        {
            try
            {
                LocatorDataSource.TableDS.UpdateTable(TableToSave);

                ListTable = LocatorDataSource.TableDS.GetAllTable(AreaSelected);

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);

                return false;
            }
        }

        #endregion
    }
}