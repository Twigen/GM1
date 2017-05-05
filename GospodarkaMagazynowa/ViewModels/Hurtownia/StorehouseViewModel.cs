using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace GospodarkaMagazynowa.ViewModels.Hurtownia
{
   public class StorehouseViewModel :ViewModelBase
    {
        private RelayCommand _showAddStorehouseItemCommand;

        public RelayCommand ShowAddStorehouseItemCommand
        {
            get
            {
                if (_showAddStorehouseItemCommand == null)
                    _showAddStorehouseItemCommand = new RelayCommand(ExecuteShowAddStorehouseItemCommandAction);
                return _showAddStorehouseItemCommand;
            }
        }

        private void ExecuteShowAddStorehouseItemCommandAction()
        {
        //    new AddStorehouseItem().Show();
        }

        

        private RelayCommand _showStorehouseDictionariesCommand;

        public RelayCommand ShowStorehouseDictionariesCommand
        {
            get
            {
                if (_showStorehouseDictionariesCommand == null)
                    _showStorehouseDictionariesCommand = new RelayCommand(ExecuteShowStorehouseDictionariesCommandAction);
                return _showStorehouseDictionariesCommand;
            }
        }

        private void ExecuteShowStorehouseDictionariesCommandAction()
        {
        //    new DisplayDictionariesWindow().Show();
        }

        private RelayCommand _showListStorehouseItemsCommand;

        public RelayCommand ShowStorehouseItemsCommand
        {
            get
            {
                if (_showListStorehouseItemsCommand == null)
                    _showListStorehouseItemsCommand = new RelayCommand(ExecuteShowStorehouseItemsCommandAction);
                return _showListStorehouseItemsCommand;
            }
        }

        private void ExecuteShowStorehouseItemsCommandAction()
        {
        //    new ListStorehouseItemsWindow().Show();
        }
    }
}
