using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using QLQuanCafe.Common;
using QLQuanCafe.DAO;
using QLQuanCafe.DTO;
using QLQuanCafe.GUI;
using QLQuanCafe.GUI.Dialog;

namespace QLQuanCafe.BLL
{
    public class MenuCategoryAndMenuItemBll : BllBase
    {

        #region Properties

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
            set { SetProperty(ref _menuCategorySelected, value); }
        }

        private MenuCategoryData _menuCategoryToSave;
        public MenuCategoryData MenuCategoryToSave
        {
            get { return _menuCategoryToSave; }
            set { SetProperty(ref _menuCategoryToSave, value); }
        }

        private List<MenuItemData> _listMenuItem;
        public List<MenuItemData> ListMenuItem
        {
            get { return _listMenuItem; }
            set { SetProperty(ref _listMenuItem, value); }
        }

        private MenuItemData _menuItemSelected;
        public MenuItemData MenuItemSelected
        {
            get { return _menuItemSelected; }
            set { SetProperty(ref _menuItemSelected, value); }
        }

        private MenuItemData _menuItemToSave;
        public MenuItemData MenuItemToSave
        {
            get { return _menuItemToSave; }
            set { SetProperty(ref _menuItemToSave, value); }
        }

        private List<UnitData> _listUnit;
        public List<UnitData> ListUnit
        {
            get { return _listUnit; }
            set { SetProperty(ref _listUnit, value); }
        }

        private UnitData _unitSelected;
        public UnitData UnitSelected
        {
            get { return _unitSelected; }
            set { SetProperty(ref _unitSelected, value); }
        }

        #endregion

        #region Commands

        /// <summary>
        /// Command xảy ra khi chọn một loại món ăn.
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

        private ICommand _showAddMenuCategoryWindowCommand;
        public ICommand ShowAddMenuCategoryWindowCommand
        {
            get
            {
                if (_showAddMenuCategoryWindowCommand == null)
                    _showAddMenuCategoryWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            MenuCategoryToSave = new MenuCategoryData();
                            ThemLoaiMonAn themLoaiMonAn = new ThemLoaiMonAn();
                            themLoaiMonAn.ShowDialog();
                        },
                        p => true);
                return _showAddMenuCategoryWindowCommand;
            }
            set { _showAddMenuCategoryWindowCommand = value; }
        }

        private ICommand _showEditMenuCategoryWindowCommand;
        public ICommand ShowEditMenuCategoryWindowCommand
        {
            get
            {
                if (_showEditMenuCategoryWindowCommand == null)
                    _showEditMenuCategoryWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            MenuCategoryToSave = new MenuCategoryData
                            {
                                MenuCategoryId = MenuCategorySelected.MenuCategoryId,
                                MenuCategoryName = MenuCategorySelected.MenuCategoryName
                            };
                            SuaLoaiMonAn suaLoaiMonAn = new SuaLoaiMonAn();
                            suaLoaiMonAn.ShowDialog();
                        },
                        p => MenuCategorySelected != null);
                return _showEditMenuCategoryWindowCommand;
            }
            set { _showEditMenuCategoryWindowCommand = value; }
        }

        private ICommand _deleteMenuCategoryCommand;
        public ICommand DeleteMenuCategoryCommand
        {
            get
            {
                if (_deleteMenuCategoryCommand == null)
                    _deleteMenuCategoryCommand = new RelayCommand<object>(
                        p =>
                        {
                            try
                            {
                                LocatorDataSource.MenuCategoryDS.DeleteMenuCategory(MenuCategorySelected);

                                ListMenuCategory = LocatorDataSource.MenuCategoryDS.GetAllMenuCategory();
                            }
                            catch (MySqlException ex)
                            {
                                MessageDialogHelper.CreateErrorMessage(ex.Message);
                            }
                        },
                        p => MenuCategorySelected != null);
                return _deleteMenuCategoryCommand;
            }
            set { _deleteMenuCategoryCommand = value; }
        }

        /// <summary>
        /// Command xảy ra khi chọn một món ăn.
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

        private ICommand _showAddMenuItemWindowCommand;
        public ICommand ShowAddMenuItemWindowCommand
        {
            get
            {
                if (_showAddMenuItemWindowCommand == null)
                    _showAddMenuItemWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            try
                            {
                                MenuItemToSave = new MenuItemData
                                {
                                    MenuCategory = MenuCategorySelected
                                };

                                ListUnit = LocatorDataSource.UnitDS.GetAllUnit();
                                UnitSelected = null;
                                ThemMonAn themMonAn = new ThemMonAn();
                                themMonAn.ShowDialog();
                            }
                            catch (MySqlException ex)
                            {
                                MessageDialogHelper.CreateErrorMessage(ex.Message);
                            }
                        },
                        p => MenuCategorySelected != null);
                return _showAddMenuItemWindowCommand;
            }
            set { _showAddMenuItemWindowCommand = value; }
        }

        private ICommand _showEditMenuItemWindowCommand;
        public ICommand ShowEditMenuItemWindowCommand
        {
            get
            {
                if (_showEditMenuItemWindowCommand == null)
                    _showEditMenuItemWindowCommand = new RelayCommand<object>(
                        p =>
                        {
                            MenuItemToSave = new MenuItemData
                            {
                                MenuItemId = MenuItemSelected.MenuItemId,
                                MenuItemName = MenuItemSelected.MenuItemName,
                                ImagePath = MenuItemSelected.ImagePath,
                                Price = MenuItemSelected.Price
                            };

                            MenuItemToSave.MenuCategory = ListMenuCategory.SingleOrDefault(m => m.MenuCategoryId == MenuItemSelected.MenuCategory.MenuCategoryId);

                            ListUnit = LocatorDataSource.UnitDS.GetAllUnit();
                            MenuItemToSave.Unit = ListUnit.SingleOrDefault(u => u.UnitId == MenuItemSelected.Unit.UnitId);

                            SuaMonAn suaMonAn = new SuaMonAn();
                            suaMonAn.ShowDialog();

                        },
                        p => MenuItemSelected != null);
                return _showEditMenuItemWindowCommand;
            }
            set { _showEditMenuItemWindowCommand = value; }
        }

        private ICommand _deleteMenuItemCommand;
        public ICommand DeleteMenuItemCommand
        {
            get
            {
                if (_deleteMenuItemCommand == null)
                    _deleteMenuItemCommand = new RelayCommand<object>(
                        p =>
                        {
                            try
                            {
                                LocatorDataSource.MenuItemDS.DeleteMenuItem(MenuItemSelected);

                                ListMenuItem = LocatorDataSource.MenuItemDS.GetAllMenuItem(MenuCategorySelected);
                            }
                            catch (MySqlException ex)
                            {
                                MessageDialogHelper.CreateErrorMessage(ex.Message);
                            }
                        },
                        p => MenuItemSelected != null);
                return _deleteMenuItemCommand;
            }
            set { _deleteMenuItemCommand = value; }
        }

        #endregion

        #region Actions

        private void SelectMenuCategoryAction(object obj)
        {
            if (obj != null)
            {
                MenuCategorySelected = ((DataGridViewRow)obj).DataBoundItem as MenuCategoryData;

                try
                {
                    ListMenuItem = LocatorDataSource.MenuItemDS.GetAllMenuItem(MenuCategorySelected);
                }
                catch (MySqlException ex)
                {
                    MessageDialogHelper.CreateErrorMessage(ex.Message);
                }
            }
        }

        private void SelectMenuItemAction(object obj)
        {
            if (obj != null)
            {
                MenuItemSelected = ((DataGridViewRow)obj).DataBoundItem as MenuItemData;
            }
        }

        #endregion

        #region Methods

        public override void Load()
        {
            try
            {
                ListMenuCategory = LocatorDataSource.MenuCategoryDS.GetAllMenuCategory();
                MenuCategorySelected = null;
                ListMenuItem = null;
                MenuItemSelected = null;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
            }
        }

        public bool AddMenuCategory()
        {
            try
            {
                LocatorDataSource.MenuCategoryDS.AddMenuCategory(MenuCategoryToSave);
                ListMenuCategory = LocatorDataSource.MenuCategoryDS.GetAllMenuCategory();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
                return false;
            }
        }

        public bool EditMenuCategory()
        {
            try
            {
                LocatorDataSource.MenuCategoryDS.UpdateMenuCategory(MenuCategoryToSave);
                ListMenuCategory = LocatorDataSource.MenuCategoryDS.GetAllMenuCategory();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
                return false;
            }
        }

        public bool AddMenuItem()
        {
            try
            {
                MenuItemToSave.ImagePath = ImageHelper.CreateImage(MenuItemToSave.ImagePath);

//                MenuItemToSave.Unit = UnitSelected;
                LocatorDataSource.MenuItemDS.AddMenuItem(MenuItemToSave);
                ListMenuItem = LocatorDataSource.MenuItemDS.GetAllMenuItem(MenuCategorySelected);

                return true;
            }
            catch (MySqlException ex)
            {
                MessageDialogHelper.CreateErrorMessage(ex.Message);
                return false;
            }
        }

        public bool EditMenuItem()
        {
            try
            {
                MenuItemToSave.ImagePath = ImageHelper.CreateImage(MenuItemToSave.ImagePath);

                LocatorDataSource.MenuItemDS.UpdateMenuItem(MenuItemToSave);
                ListMenuItem = LocatorDataSource.MenuItemDS.GetAllMenuItem(MenuCategorySelected);

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
