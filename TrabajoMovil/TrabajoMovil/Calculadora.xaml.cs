using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrabajoMovil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadora :  ContentPage
    {
        private bool mostrandoResultado = false;
        public Calculadora()
        {
            InitializeComponent();
        }
        private void teclaPresionada(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = button.Text;

            if (mostrandoResultado)
            {

                if (text == "*" || text == "+" || text == "/" || text == "-")
                {

                    InputField.Text += text;
                    mostrandoResultado = false;
                }
                else
                {

                    InputField.Text = text;
                    mostrandoResultado = false;
                }
            }
            else
            {
                InputField.Text += text;
                mostrandoResultado = false;
            }
        }

        private void botonIgual(object sender, EventArgs e)
        {

            try
            {

                string expression = InputField.Text;
                DataTable dt = new DataTable();
                var resultado = dt.Compute(expression, "");


                InputField.Text = $" = {resultado.ToString()}";
                mostrandoResultado = true;
            }
            catch (Exception ex)
            {
                InputField.Text = "Error";
            }
        }

        private void borrarDigito(object sender, EventArgs e)
        {
            if (InputField.Text.Length > 0)
            {
                InputField.Text = InputField.Text.Substring(0, InputField.Text.Length - 1);
            }

        }

        private void resetear(object sender, EventArgs e)
        {
            InputField.Text = "";

        }

        private void InputField_TextChanged(object sender, TextChangedEventArgs e)
        {

            op.Text = e.OldTextValue;
        }
    }

}

