using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrabajoMovil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleSeleccion : ContentPage
    {
        
        public DetalleSeleccion(Product info)
        {
            InitializeComponent();
            this.BindingContext = info; 
            
        }
    }
}