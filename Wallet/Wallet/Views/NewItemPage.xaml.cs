﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Wallet.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;

namespace Wallet.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        public NewItemPage()
        {
            InitializeComponent();

            var blocks = GetChain();
            var transaction = TransactionByAddress(Credential.PublicKey, blocks);
            decimal balance = 0;
            decimal receives = 0;
            decimal deduct = 0;

            List<string> lstStr = new List<string>();

            foreach (var item in transaction)
            {
                if (item.Recipient == Credential.PublicKey)
                {
                    balance = balance + item.Amount;
                    receives = receives + item.Amount;
                }
                else
                {
                    balance = balance - item.Amount;
                    deduct = deduct + item.Amount;
                }
                lstStr.Add(item.Sender + " sent " + item.Amount + " to " + item.Recipient);
            }

            txtReceives.Text = receives.ToString();
            txtDeduct.Text = deduct.ToString();
            txtBalance.Text = balance.ToString();

            lst.ItemsSource = lstStr;
        }

        /*
         * GetChain() Function to get (block)chain from API
         * 
         * @return data.chain
         */
        private List<Block> GetChain()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            try


            {
                var url = new Uri("http://192.168.1.29:5000" + "/api/chain"); // connection to dotnet-core-blockchain API
                var response = client.GetAsync(url).Result;

                var content = response.Content.ReadAsStringAsync().Result;
                var model = new
                {
                    chain = new List<Block>(),
                    length = 0
                };
                var data = JsonConvert.DeserializeAnonymousType(content,     model);

                return data.chain;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /*
         * TransactionByAddress() Function to get transactions by address
         * 
         * @param ownerAddress
         * @param chain
         * @return transactions
         */
        private List<Transaction> TransactionByAddress(string ownerAddress, List<Block> chain)
        {
            List<Transaction> transactions = new List<Transaction>();
            foreach (var block in chain.OrderByDescending(x => x.Index))
            {
                var ownerTransactions = block.Transactions.Where(x => x.Sender == ownerAddress || x.Recipient == ownerAddress).ToList();
                transactions.AddRange(ownerTransactions);
            }
            return transactions;
        }
    }
}