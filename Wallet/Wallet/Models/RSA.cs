using System;
using System.Collections.Generic;
using System.Text;

namespace Wallet.Models
{
    public static class RSA
    {

        /*
         * Sign() Method to serve with private and public key over NBitcoin network 
         * 
         * @param privateKey
         * @param messageToSign
         * @return signature
         */
        public static string Sign(string privateKey, string messageToSign)
        {
            var secret = NBitcoin.Network.Main.CreateBitcoinSecret(privateKey);
            var signature = secret.PrivateKey.SignMessage(messageToSign);
            var v = secret.PubKey.VerifyMessage(messageToSign, signature);

            return signature;
        }
    }
}
