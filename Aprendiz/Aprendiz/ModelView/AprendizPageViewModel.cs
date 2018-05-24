

namespace Aprendiz.ModelView
{
    using Aprendiz.Model;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using Xamarin.Forms;

    public class AprendizPageViewModel:Notificable
    {
        #region Atributo
        private ObservableCollection<Aprendiz> aprendices; 
        #endregion

        #region Propiedades
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

        private bool isEnable;

        public bool IsEnable
        {
            get { return isEnable; }
            set {
                if (isEnable == value)
                {
                    return;
                }
                isEnable = value;
                OnPropertyChanged();
            }
        }
        private Command cargarAprendizCommand;

        public Command CargarAprendizCommand
        {
            get { return cargarAprendizCommand; }
            set { cargarAprendizCommand = value; }
        }

        public AprendizPageViewModel()
        {
            Aprendices
        }

        #endregion

    }
}
