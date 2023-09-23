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
    public partial class MaestroDetalle : FlyoutPage
    {
        public MaestroDetalle()
        {
            InitializeComponent();
            this.Flyout = new CollectionView();

            this.Detail = new NavigationPage(new Detalle());


            App.flyoutPage = this;
        }
    }
}