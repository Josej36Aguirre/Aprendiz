using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aprendiz.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aprendiz.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalleAprendiz : ContentPage
	{
		public DetalleAprendiz ()
		{
			InitializeComponent ();
		}

        public DetalleAprendiz(Model.Aprendiz aprendizSeleccionado)
        {
        }
    }
}