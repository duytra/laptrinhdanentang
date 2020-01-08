﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlockChainClient.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace BlockChainClient.Controllers
{

    /**
    * Used to define main interactions with MVC application 
    * 
    * @author Davain Pablo Edwards
    * @license MIT 
    * @version 1.0
    */
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*
         * MakeTransactions() action Method to show 'make action' view 
         * 
         * @return View()
         */
        public IActionResult MakeTransaction()
        {
            return View();
        }

        /*
         * ViewTransaction() action Method to show 'transaction' view
         * 
         * @return View()
         */
        public IActionResult ViewTransaction()
        {
            return View();
        }

        /*
         * ViewTransaction() http web action method to post transactions on blockchain
         * 
         * @param node_url
         * @return View()
         */
        [HttpPost]
        public IActionResult ViewTransaction(string node_url)
        {
            node_url = "http://localhost:63385";

            var url = new Uri(node_url + "/chain");
            ViewBag.Blocks = GetChain(url);
            return View();
        }

        /*
         * WalletTransaction() action Method to show transaction list in 'wallet transaction' view
         * 
         * @return View(new List<Transaction>())
         */
        public IActionResult WalletTransaction()
        {
            return View(new List<Transaction>());
        }

        /*
         * WalletTransaction() http web action Method to post wallet transactions on blockchain
         * 
         * @param publicKey
         * @return View(TransactionByAddress(publicKey, blocks))
         */
        [HttpPost]
        public IActionResult WalletTransaction(string publicKey)
        {
            var url = new Uri("http://localhost:63385" + "/chain"); // blockchain node URI
            var blocks = GetChain(url);
            ViewBag.publicKey = publicKey;

            return View(TransactionByAddress(publicKey, blocks));
        }

        /*
         * TransactionByAddress() Method to check all transactions by address
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

        /*
        * GetChain() Method to get blockchain by http web request
        * 
        * @param url 
        * @return data.chain
        * @return null;
        */
        private List<Block> GetChain(Uri url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var model = new
                {
                    chain = new List<Block>(),
                    length = 0
                };
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var data = JsonConvert.DeserializeAnonymousType(json, model);

                return data.chain;
            }
            return null;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
