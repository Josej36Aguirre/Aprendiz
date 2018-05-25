


namespace Aprendiz.Model.Services
{
    using System;
    using System.Collections.ObjectModel;
  public  class CaracterizacionAprendices
    {

        #region Método
        public static Data CargarAprendiz()
        {
            ObservableCollection<Aprendiz> aprendices = new ObservableCollection<Aprendiz>();
            Data carAprendices = new Data();

            string[] nombres = {"Oscar","Elkin","Francisco","Victor Manuel",
                "Alejandro", "Diana", "OLiverio", "Mauricio", "Jesús"};
            string[] apellidos = {"Cárdenas", "Ortua", "Martinez", "López",
            "Gonzáles"};
            string[] programas = {"Contabilidad y Finanzas", "Produccion Multimedia",
                "ADSI", "Animación 3D", "Diseño Grafico"};
            Random rnd = new Random(DateTime.Now.Millisecond);
            aprendices = new ObservableCollection<Aprendiz>();

            for (int i = 0; i < 20; i++)
            {
                Aprendiz aprendiz = new Aprendiz();
                aprendiz.Nombre = nombres[rnd.Next(0, 8)];
                aprendiz.Apellido = $"{apellidos[rnd.Next(0, 4)]} {apellidos[rnd.Next(0, 4)]}";
                double ficha = rnd.Next(1618618, 2000000);
                aprendiz.Ficha = ficha;
                aprendiz.Programa = programas[rnd.Next(0, 4)];
                aprendiz.Promedio = rnd.Next(100, 1000);
                aprendices.Add(aprendiz);
            }
            carAprendices.Aprendices = aprendices;
            return carAprendices;
        } 
        #endregion
    }
}
