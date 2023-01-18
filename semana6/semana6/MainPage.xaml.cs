using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace semana6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void btnInsertar_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();

                parametros.Add("codigo", txtId.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);

                cliente.UploadValues("http://10.2.4.225/uisrael2023/post.php", "POST", parametros);
            }
            catch (Exception ex)
            {
                DisplayAlert("alerta", ex.Message, "cancelar");
            }
        }

        void btnCancelar_Clicked(System.Object sender, System.EventArgs e)
        {
        }

       
    }
}

