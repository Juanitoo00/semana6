using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace semana6
{
    public partial class usuario : ContentPage
    {
        private const string Url = "http://10.2.4.225/uisrael2023/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection <semana6.Datos>_post;

        public usuario()
        {
            InitializeComponent();
            this.obtenerDatos();
        }

        public async void obtenerDatos()
        {
            var content = await client.GetStringAsync(Url);
            List<semana6.Datos> posts = JsonConvert.DeserializeObject<List<semana6.Datos>>(content);
            _post = new ObservableCollection<semana6.Datos>(posts);

            MyListView.ItemsSource = _post;
        }

      

        void btnLlamadoApi_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        async void btnGet_Clicked(System.Object sender, System.EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<semana6.Datos> posts = JsonConvert.DeserializeObject <List<semana6.Datos>>(content);
            _post = new ObservableCollection<semana6.Datos>(posts);

            MyListView.ItemsSource = _post;
        }

        void btnInsertar_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}

