using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrabajoMovil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionView : ContentPage
    {

        public ObservableCollection<Product> products { get; set; }
        public CollectionView()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();

            products.Add(new Product
            {
                Name = "Tecnologia",
                Icon = "home"
            });
            products.Add(new Product
            {
                Name = "Mi cuenta",
                Icon = "perfil"
            });
        
            this.BindingContext = this;

        }


        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product itemSeleccionado = (Product)e.CurrentSelection.FirstOrDefault();
            App.flyoutPage.Detail.Navigation.PushAsync(new DetalleSeleccion(itemSeleccionado));
            App.flyoutPage.IsPresented = false;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calculadora());
        }
    }
}