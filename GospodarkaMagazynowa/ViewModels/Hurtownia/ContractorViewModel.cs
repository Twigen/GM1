using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GospodarkaMagazynowa.Events;

namespace GospodarkaMagazynowa.ViewModels.Hurtownia
{
   public class ContractorViewModel :ViewModelBase
    {
        public ContractorViewModel()
        {

        }



        private RelayCommand _addContractorCommand;

        public RelayCommand AddContractorCommand
        {
            get
            {
                if (_addContractorCommand == null)
                    _addContractorCommand = new RelayCommand(ExecuteAddContractorCommandAction);
                return _addContractorCommand;
            }
        }

        private void ExecuteAddContractorCommandAction()
        {
          
        }

        private RelayCommand _showContractorListCommand;

        public RelayCommand ShowContractorListCommand
        {
            get
            {
                if (_showContractorListCommand == null)
                    _showContractorListCommand = new RelayCommand(ExecuteShowContractorListCommandAction);
                return _showContractorListCommand;
            }
        }

        private void ExecuteShowContractorListCommandAction()
        {
          //  new MainView().Show();
        }

       private RelayCommand _returnToHurtowniaCommand;

       public RelayCommand ReturnToHurtowniaCommand
       {
           get
           {
               if (_returnToHurtowniaCommand == null)
                   _returnToHurtowniaCommand = new RelayCommand(ExecuteReturnToHurtowniaCommandAction);
               return _returnToHurtowniaCommand;
           }
       }

       private void ExecuteReturnToHurtowniaCommandAction()
       {
           MessengerInstance.Send<ShowUserControls>(new ShowUserControls {_showHurtownia = true});
       }
    }
}
