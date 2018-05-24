

namespace Aprendiz.Model
{
    using System;
  
    using System.Collections.ObjectModel;
    using System.Text;
    public class Data : Notificable
    {
        #region Atributo

        private ObservableCollection<Aprendiz> aprendices = new ObservableCollection<Aprendiz>();

        #endregion



        #region Propiedad
        public ObservableCollection<Aprendiz> Aprendices
        {
            get { return aprendices; }
            set
            {
                if (aprendices == value)
                {
                    return;
                }
                aprendices = value;
                OnPropertyChanged();
            }
        } 
        #endregion


    }
}
