using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ListaPokemon
{
    public partial class MainPage : ContentPage
    {
        internal ObservableCollection<Pokemon> Pokemons = new ObservableCollection<Pokemon>
        {
            new Pokemon{ Nome = "Abra", Tipo = "Psi", Image = "abra.png"},
            new Pokemon{ Nome = "Alakazam", Tipo = "Psi", Image = "alakazam.png"},
            new Pokemon{ Nome = "Blastoise", Tipo = "Água", Image = "blastoise.png"},
            new Pokemon{ Nome = "Bullnasaur", Tipo = "Grama", Image = "Bulbasaur.png"}
        };

        public MainPage()
        {
            InitializeComponent();
            lsPokemon.ItemsSource = Pokemons;
        }

        void OnSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            DisplayAlert("Item selecionado", ((Pokemon)e.SelectedItem).Nome, "OK");
            lsPokemon.SelectedItem = null;
        }


    }
}
