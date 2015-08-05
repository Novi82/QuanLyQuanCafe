using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.DTO;
using QLQuanCafe.Common;
using QLQuanCafe.DAO;
using System.Windows.Input;
using MySql.Data.MySqlClient;
namespace QLQuanCafe.BLL
{
    public class MaterialViewModel : BllBase
    {

        #region Properties

        private List<MaterialData> _listMaterial;
        public List<MaterialData> ListMaterial
        {
            get { return _listMaterial; }
            set { SetProperty<List<MaterialData>>(ref _listMaterial, value); }
        }

        private MaterialData _materialSelected;
        public MaterialData MaterialSelected
        {
            get { return _materialSelected; }
            set { SetProperty<MaterialData>(ref _materialSelected, value); }
        }

        private MaterialData _materialToSave;
        public MaterialData MaterialToSave
        {
            get { return _materialToSave; }
            set { SetProperty<MaterialData>(ref _materialToSave, value); }
        }

        private List<UnitData> _listUnit;
        public List<UnitData> ListUnit
        {
            get { return _listUnit; }
            set { SetProperty<List<UnitData>>(ref _listUnit, value); }
        }

        private UnitData _unitSelected;
        public UnitData UnitSelected
        {
            get { return _unitSelected; }
            set { SetProperty<UnitData>(ref _unitSelected, value); }
        }

        #endregion

        #region Commands

        private ICommand _selectMaterialCommand;
        public ICommand SelectMaterialCommand
        {
            get
            {
                if (_selectMaterialCommand == null)
                    _selectMaterialCommand = new RelayCommand<object>(
                        p => SelectMaterialAction(p),
                        p => true);
                return _selectMaterialCommand;
            }
            set { _selectMaterialCommand = value; }
        }

        private ICommand _showAddMaterialWindowCommand;
        public ICommand ShowAddMaterialWindowCommand
        {
            get
            {
                if (_showAddMaterialWindowCommand == null)
                    _showAddMaterialWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            MaterialToSave = new MaterialData();

                            try
                            {
                                ListUnit = LocatorDataSource.UnitDS.GetAllUnit();

                                UnitSelected = null;
                            }
                            catch (MySqlException ex)
                            {
                                MessageDialogHelper.CreateErrorMessage(ex.Message);
                            }
                            //HACK VIEW
                            //AddMaterialWindow addMaterialWindow = new AddMaterialWindow();
                            //addMaterialWindow.ShowDialog();
                        },
                        p => true);
                return _showAddMaterialWindowCommand;
            }
            set { _showAddMaterialWindowCommand = value; }
        }

        private ICommand _showEditMaterialWindowCommand;
        public ICommand ShowEditMaterialWindowCommand
        {
            get
            {
                if (_showEditMaterialWindowCommand == null)
                    _showEditMaterialWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            MaterialToSave = new MaterialData()
                            {
                                MaterialId = MaterialSelected.MaterialId,
                                MaterialName = MaterialSelected.MaterialName,
                                Price = MaterialSelected.Price,
                            };

                            try
                            {
                                ListUnit = LocatorDataSource.UnitDS.GetAllUnit();
                                UnitSelected = ListUnit.SingleOrDefault(u => u.UnitId == MaterialSelected.Unit.UnitId);
                            }
                            catch (MySqlException ex)
                            {
                                MessageDialogHelper.CreateErrorMessage(ex.Message);
                            }
                            //HACK VIEW
                            //EditMaterialWindow editMaterialWindow = new EditMaterialWindow();
                            //editMaterialWindow.ShowDialog();
                        },
                        p => MaterialSelected != null);
                return _showEditMaterialWindowCommand;
            }
            set { _showEditMaterialWindowCommand = value; }
        }

        private ICommand _deleteMaterialCommand;
        public ICommand DeleteMaterialCommand
        {
            get
            {
                if (_deleteMaterialCommand == null)
                    _deleteMaterialCommand = new RelayCommand<object>(
                        p =>
                        {
                            try
                            {
                                LocatorDataSource.MaterialDS.DeleteMaterial(MaterialSelected);

                                ListMaterial = LocatorDataSource.MaterialDS.GetAllMaterial();
                            }
                            catch (MySqlException ex)
                            {
                                MessageDialogHelper.CreateErrorMessage(ex.Message);
                            }
                        },
                        p => MaterialSelected != null);
                return _deleteMaterialCommand;
            }
            set { _deleteMaterialCommand = value; }
        }

        private ICommand _showImportMaterialWindowCommand;
        public ICommand ShowImportMaterialWindowCommand
        {
            get
            {
                if (_showImportMaterialWindowCommand == null)
                    _showImportMaterialWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            MaterialToSave = new MaterialData()
                            {
                                MaterialId = MaterialSelected.MaterialId,
                                MaterialName = MaterialSelected.MaterialName,
                                Price = MaterialSelected.Price,
                                Quantity = 0,
                                Unit = MaterialSelected.Unit,
                            };
                            //HACK VIEW
                            //ImportMaterialWindow importMaterialWindow = new ImportMaterialWindow();
                            //importMaterialWindow.ShowDialog();
                        },
                        p => MaterialSelected != null);
                return _showImportMaterialWindowCommand;
            }
            set { _showImportMaterialWindowCommand = value; }
        }

        private ICommand _showExportMaterialWindowCommand;
        public ICommand ShowExportMaterialWindowCommand
        {
            get
            {
                if (_showExportMaterialWindowCommand == null)
                    _showExportMaterialWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            MaterialToSave = new MaterialData()
                            {
                                MaterialId = MaterialSelected.MaterialId,
                                MaterialName = MaterialSelected.MaterialName,
                                Price = MaterialSelected.Price,
                                Quantity = 0,
                                Unit = MaterialSelected.Unit,
                            };
                            //HACK VIEW
                            //ExportMaterialWindow exportMaterialWindow = new ExportMaterialWindow();
                            //exportMaterialWindow.ShowDialog();
                        },
                        p => MaterialSelected != null);
                return _showExportMaterialWindowCommand;
            }
            set { _showExportMaterialWindowCommand = value; }
        }

        private ICommand _showUpdateInventoryWindowCommand;
        public ICommand ShowUpdateInventoryWindowCommand
        {
            get
            {
                if (_showUpdateInventoryWindowCommand == null)
                    _showUpdateInventoryWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            MaterialToSave = new MaterialData()
                            {
                                MaterialId = MaterialSelected.MaterialId,
                                MaterialName = MaterialSelected.MaterialName,
                                Price = MaterialSelected.Price,
                                Quantity = MaterialSelected.Quantity,
                                Unit = MaterialSelected.Unit,
                            };
                            // HACK VIEW
                            //UpdateInventoryWindow updateInventoryWindow = new UpdateInventoryWindow();
                            //updateInventoryWindow.ShowDialog();
                        },
                        p => MaterialSelected != null);
                return _showUpdateInventoryWindowCommand;
            }
            set { _showUpdateInventoryWindowCommand = value; }
        }

        #endregion

        #region Actions

        private void SelectMaterialAction(object obj)
        {
            if (obj != null)
            {
                MaterialSelected = obj as MaterialData;
            }
        }

        #endregion

        #region Methods

        public override void Load()
        {
            try
            {
                ListMaterial = LocatorDataSource.MaterialDS.GetAllMaterial();
                MaterialSelected = null;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        public bool AddMaterial()
        {
            try
            {
                MaterialToSave.Unit = UnitSelected;
                LocatorDataSource.MaterialDS.AddMaterial(MaterialToSave);

                ListMaterial = LocatorDataSource.MaterialDS.GetAllMaterial();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);

                return false;
            }
        }

        public bool EditMaterial()
        {
            try
            {
                MaterialToSave.Unit = UnitSelected;
                LocatorDataSource.MaterialDS.UpdateMaterial(MaterialToSave);

                ListMaterial = LocatorDataSource.MaterialDS.GetAllMaterial();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);

                return false;
            }
        }

        public bool ImportMaterial()
        {
            try
            {
                LocatorDataSource.MaterialDS.ImportMaterial(MaterialToSave);

                ListMaterial = LocatorDataSource.MaterialDS.GetAllMaterial();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);

                return false;
            }
        }

        public bool ExportMaterial()
        {
            try
            {
                LocatorDataSource.MaterialDS.ExportMaterial(MaterialToSave);

                ListMaterial = LocatorDataSource.MaterialDS.GetAllMaterial();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);

                return false;
            }
        }

        public bool UpdateInventory()
        {
            try
            {
                LocatorDataSource.MaterialDS.UpdateInventory(MaterialToSave);

                ListMaterial = LocatorDataSource.MaterialDS.GetAllMaterial();

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
