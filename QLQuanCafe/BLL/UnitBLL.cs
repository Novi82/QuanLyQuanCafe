using System.Collections.Generic;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using QLQuanCafe.Common;
using QLQuanCafe.DAO;
using QLQuanCafe.DTO;
using QLQuanCafe.GUI;
using System.Windows.Forms;
using QLQuanCafe.GUI.Dialog;

namespace QLQuanCafe.BLL
{
    public class UnitBll : BllBase
    {
        #region Properties

        private List<UnitData> _listUnit;
        public List<UnitData> ListUnit
        {
            get
            {
                Load();
                return _listUnit;
            }
            set { SetProperty(ref _listUnit, value); }
        }

        private UnitData _unitSelected;
        public UnitData UnitSelected
        {
            get { return _unitSelected; }
            set { SetProperty(ref _unitSelected, value); }
        }

        private UnitData _unitToSave;
        public UnitData UnitToSave
        {
            get { return _unitToSave; }
            set { SetProperty(ref _unitToSave, value); }
        }

        #endregion

        #region Commands

        /// <summary>
        /// Command xảy ra khi chọn một đơn vị tính.
        /// </summary>
        private ICommand _selectUnitCommand;
        public ICommand SelectUnitCommand
        {
            get
            {
                if (_selectUnitCommand == null)
                    _selectUnitCommand = new RelayCommand<object>(
                        p => SelectUnitAction(p),
                        p => true);
                return _selectUnitCommand;
            }
            set { _selectUnitCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi nhấn thêm đơn vị tính.
        /// </summary>
        private ICommand _showAddUnitWindowCommand;
        public ICommand ShowAddUnitWindowCommand
        {
            get
            {
                if (_showAddUnitWindowCommand == null)
                    _showAddUnitWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            UnitToSave = new UnitData();
                            //HACK VIEW
                            ThemDonViTinh themDonViTinh = new ThemDonViTinh();
                            themDonViTinh.ShowDialog();
                            //AddUnitWindow addUnitWindow = new AddUnitWindow();
                            //addUnitWindow.ShowDialog();
                        },
                        p => true);
                return _showAddUnitWindowCommand;
            }
            set { _showAddUnitWindowCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi nhấn sửa đơn vị tính.
        /// </summary>
        private ICommand _showEditUnitWindowCommand;
        public ICommand ShowEditUnitWindowCommand
        {
            get
            {
                if (_showEditUnitWindowCommand == null)
                    _showEditUnitWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            UnitToSave = new UnitData
                            {
                                UnitId = UnitSelected.UnitId,
                                UnitName = UnitSelected.UnitName
                            };
                            //HACK VIEW
                            SuaDonViTinh suaDonViTinh = new SuaDonViTinh();
                            suaDonViTinh.ShowDialog();
                            //EditUnitWindow editUnitWindow = new EditUnitWindow();
                            //editUnitWindow.ShowDialog();
                        },
                        p => UnitSelected != null);
                return _showEditUnitWindowCommand;
            }
            set { _showEditUnitWindowCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi nhấn xóa đơn vị tính.
        /// </summary>
        private ICommand _deleteUnitCommand;
        public ICommand DeleteUnitCommand
        {
            get
            {
                if (_deleteUnitCommand == null)
                    _deleteUnitCommand = new RelayCommand<object>(
                        p =>
                        {
                            try
                            {
                                LocatorDataSource.UnitDS.DeleteUnit(UnitSelected);

                                ListUnit = LocatorDataSource.UnitDS.GetAllUnit();
                            }
                            catch (MySqlException ex)
                            {
                                MessageDialogHelper.CreateErrorMessage(ex.Message);
                            }
                        },
                        p => UnitSelected != null);
                return _deleteUnitCommand;
            }
            set { _deleteUnitCommand = value; }
        }

        #endregion

        #region Actions

        private void SelectUnitAction(object obj)
        {
            if (obj != null)
            {
                UnitSelected = ((DataGridViewRow) obj).DataBoundItem as UnitData;
            }
        }

        #endregion

        #region Methods

        public override void Load()
        {
            try
            {
                ListUnit = LocatorDataSource.UnitDS.GetAllUnit();

                UnitSelected = null;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        public bool AddUnit()
        {
            try
            {
                LocatorDataSource.UnitDS.AddUnit(UnitToSave);

                ListUnit = LocatorDataSource.UnitDS.GetAllUnit();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);

                return false;
            }
        }

        public bool EditUnit()
        {
            try
            {
                LocatorDataSource.UnitDS.UpdateUnit(UnitToSave);

                ListUnit = LocatorDataSource.UnitDS.GetAllUnit();

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
