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
            products.Add(new Product
            {
                Name = "Calculadora",
                Icon = "calculator"
            });
            this.BindingContext = this;

        }
    }
}