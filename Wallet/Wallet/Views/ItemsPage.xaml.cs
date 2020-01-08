using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Wallet.Models;
using Wallet.Views;
using Wallet.ViewModels;

namespace Wallet.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        public Transaction Transaction { get; set; }

        /*
         * Constructor
         * 
         */ 
        public ItemsPage()
        {
            InitializeComponent();
            Transaction = new Transaction
            {
                PrivateKey = "L3aq7WPiSois3N7GxTr6ZSXMNdfbAZWNebiYvKK5hAUBCijk95rL", //L3aq7WPiSois3N7GxTr6ZSXMNdfbAZWNebiYvKK5hAUBCijk95rL
                Sender = "18jp31DcT3n5vsYHGVhhQa2qsvEve4EUoQ", //18jp31DcT3n5vsYHGVhhQa2qsvEve4EUoQ
            };

            BindingContext = this;
        }

        /*
         * Saved_Clicked() Event to save public and private keys
         * 
         */
        async void Save_Clicked(object sender, EventArgs e)
        {
            Credential.PublicKey = Transaction.Sender;
            Credential.PrivateKey = Transaction.PrivateKey;

            await DisplayAlert("Credential", "Keys Updated", "OK");
        }

        /*
         * CreateSign_Clicked() Event to navigate through item page
         * 
         */
        async void CreateSign_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }


    }
}