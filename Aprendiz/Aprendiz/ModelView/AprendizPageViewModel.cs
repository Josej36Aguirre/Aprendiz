﻿

namespace Aprendiz.ModelView
{
    using Aprendiz.Model;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using Model.Services;

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
        public Command CargarAprendizCommand { get; set; }

        public AprendizPageViewModel()
        {
            Aprendices = new ObservableCollection<Aprendiz>();
            CargarAprendizCommand = new Command((obj)=>CargarAprendices());
        }

        private async void CargarAprendices()
        {
            if (!IsEnable)
            {
                isEnable = true;
                await Task.Delay(3000);
                Data listAprendices = CaracterizacionAprendices.CargarAprendiz();
                Aprendices = listAprendices.Aprendices;
                IsEnable = false;
            }
        }
        #endregion

    }
}
