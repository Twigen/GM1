using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GospodarkaMagazynowa.Events;
using GospodarkaMagazynowa.ViewModels.Hurtownia;

namespace GospodarkaMagazynowa
{
   public class MainViewModel :ViewModelBase
   {
       public static bool _showContractorUserControlVariable;
       public static bool _showHurtowniaUserControlVariable;
       private HurtowniaViewModel _hurtowniaViewModel = new HurtowniaViewModel();

       public MainViewModel()
       {
            MessengerInstance.Register<ShowUserControls>(this, ShowHurtowniaChanged);
            ShowHurtowniaUserControl = true;
         //   _hurtowniaViewModel = new HurtowniaViewModel();
            _hurtowniaViewModel.PropertyChanged +=HurtowniaViewModelOnPropertyChanged;
       }

        private void HurtowniaViewModelOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName == "Test")
            {
                RaisePropertyChangedContractor();
                RaisePropertyChangedHurtownia();
            }
        }

        private const string _showContractorUserControlPropertyName = "ShowContractorUserControl";
       public bool _showContractorUserControl;

       public bool ShowContractorUserControl
       {
           get { return _showContractorUserControl; }
           set
           {
               _showContractorUserControl = value;
               RaisePropertyChanged(_showContractorUserControlPropertyName);
           }
       }

       private const string _showHurtowniaUserControlPropertyName = "ShowHurtowniaUserControl";
       private bool _showHurtowniaUserControl;

       public bool ShowHurtowniaUserControl
       {
           get { return _showHurtowniaUserControl; }
           set
           {
               _showHurtowniaUserControl = value;
               RaisePropertyChanged(_showHurtowniaUserControlPropertyName);
           }
       }

       public void SetHurtownia()
       {
           ShowHurtowniaUserControl = _showHurtowniaUserControlVariable;
           ShowContractorUserControl = _showContractorUserControlVariable;
          //  RaisePropertyChangedHurtownia();
          //  RaisePropertyChangedContractor();
       }

       public void RaisePropertyChangedHurtownia()
       {
           RaisePropertyChanged("ShowHurtowniaUserControl");
       }

       public void RaisePropertyChangedContractor()
       {
           RaisePropertyChanged("ShowContractorUserControl");
       }
        private void ShowHurtowniaChanged(ShowUserControls eventArgs)
        {
            ShowHurtowniaUserControl = eventArgs._showHurtownia;
            ShowContractorUserControl = eventArgs._showContractor;
        }
    }
}
