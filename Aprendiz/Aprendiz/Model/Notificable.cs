

namespace Aprendiz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Text;

   public class Notificable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        #region  Interfaz

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        } 
        #endregion
    }
}
