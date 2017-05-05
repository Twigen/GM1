using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace GM1
{
   public class MainViewModel:ViewModelBase
    {
       private RelayCommand _showGospodarkaMagazynowaCommand;

       public RelayCommand ShowGospodarkaMagazynowaCommand
       {
           get
           {
               if (_showGospodarkaMagazynowaCommand == null)
                   _showGospodarkaMagazynowaCommand = new RelayCommand(ExecuteShowGospodarkaMagazynowaCommandAction);
               return _showGospodarkaMagazynowaCommand;
           }
       }

       private void ExecuteShowGospodarkaMagazynowaCommandAction()
       {
           new GospodarkaMagazynowa.MainWindow().Show();
       }
    }
}
