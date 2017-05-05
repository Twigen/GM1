using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GospodarkaMagazynowa.Events;

namespace GospodarkaMagazynowa.ViewModels.Hurtownia
{
   public class HurtowniaViewModel :ViewModelBase,INotifyPropertyChanged
   {
       
        

       public HurtowniaViewModel()
       {
           
           Test = false;
       }

        private RelayCommand _showContractorCommand;

        public RelayCommand ShowContractorCommand
        {
            get
            {
                if (_showContractorCommand == null)
                    _showContractorCommand = new RelayCommand(ExecuteShowContractorCommandAction);
                return _showContractorCommand;
            }
        }

        private void ExecuteShowContractorCommandAction()
        {
             MessengerInstance.Send<ShowUserControls>(new ShowUserControls {_showHurtownia = false,_showContractor = true});

        }

        private RelayCommand _showInfoCommand;

        public RelayCommand ShowInfoCommand
        {
            get
            {
                if (_showInfoCommand == null)
                    _showInfoCommand = new RelayCommand(ExecuteShowInfoCommandAction);
                return _showInfoCommand;
            }
        }

        private void ExecuteShowInfoCommandAction()
        {
            MessageBox.Show("Witaj w Hurtowni");
        }

        private RelayCommand _magInfoCommand;

        public RelayCommand MagInfoCommand
        {
            get
            {
                if (_magInfoCommand == null)
                    _magInfoCommand = new RelayCommand(ExecuteMagInfoCommandAction);
                return _magInfoCommand;
            }
        }

        private void ExecuteMagInfoCommandAction()
        {
            MessageBox.Show("Nie oprogramowano");
        }

        private RelayCommand _openStorehouseListCommand;

        public RelayCommand OpenStorehouseListCommand
        {
            get
            {
                if (_openStorehouseListCommand == null)
                    _openStorehouseListCommand = new RelayCommand(ExecuteOpenStorehouseListCommandAction);
                return _openStorehouseListCommand;
            }
        }

        private void ExecuteOpenStorehouseListCommandAction()
        {
        //    new ListStorehouseItemsWindow().Show();
        }

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
         //   new DisplayDictionariesWindow().Show();
        }

        private RelayCommand _showStorehouseCommand;

        public RelayCommand ShowStorehouseCommand
        {
            get
            {
                if (_showStorehouseCommand == null)
                    _showStorehouseCommand = new RelayCommand(ExecuteShowStorehouseCommandAction);
                return _showStorehouseCommand;
            }
        }

        private void ExecuteShowStorehouseCommandAction()
        {
         //   new StorehouseWindow().Show();
        }

       private const string _TestPropertyName = "Test";
       private bool _Test;

       public bool Test
       {
           get { return _Test; }
           set
           {
               _Test = value;
               RaisePropertyChanged(_TestPropertyName);
           }
       }

       
    }
}
