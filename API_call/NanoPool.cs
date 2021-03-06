﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;

namespace API_call
{
    public static class NanoPool
    {
        public static float get_Balance(string address)
        {
            float balance = float.NaN;
            string url = "https://api.nanopool.org/v1/eth/balance/" + address;
            string txt = String.Empty;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            using (Stream stream = request.GetResponse().GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    txt = reader.ReadToEnd();
                }
            }

            string re1 = ".*?"; // Non-greedy match on filler
            string re2 = "([+-]?\\d*\\.\\d+)(?![-+0-9\\.])";    // Float 1

            Regex r = new Regex(re1 + re2, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m = r.Match(txt);
            balance = Convert.ToSingle(m.Groups[1].Value);
            return balance;
        }
        public static float get_Hashrate(string address, int hours)
        {
            float hashrate = float.NaN;
            string url = "https://api.nanopool.org/v1/eth/avghashratelimited/" + address + "/" + hours;
            string txt = String.Empty;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            using (Stream stream = request.GetResponse().GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    txt = reader.ReadToEnd();
                }
            }

            string re1, re2;
            try
            {
                re1 = ".*?"; // Non-greedy match on filler
                re2 = "([+-]?\\d*\\.\\d+)(?![-+0-9\\.])";    // Float 1
                Regex r = new Regex(re1 + re2, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                Match m = r.Match(txt);
                hashrate = Convert.ToSingle(m.Groups[1].Value);
            }
            catch (Exception ex)
            {
                re1 = ".*?"; // Non-greedy match on filler
                re2 = "(\\d+)";  // Integer Number 1
                Regex r = new Regex(re1 + re2, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                Match m = r.Match(txt);
                hashrate = Convert.ToSingle(m.Groups[1].Value);
            }
            return hashrate;
        }
        public static float get_CurrentHashrate(string address)
        {
            float hashrate = float.NaN;
            string url = "https://api.nanopool.org/v1/eth/hashrate/" + address;
            string txt = String.Empty;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            using (Stream stream = request.GetResponse().GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    txt = reader.ReadToEnd();
                }
            }

            string re1, re2;
            try
            {
                re1 = ".*?"; // Non-greedy match on filler
                re2 = "([+-]?\\d*\\.\\d+)(?![-+0-9\\.])";    // Float 1
                Regex r = new Regex(re1 + re2, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                Match m = r.Match(txt);
                hashrate = Convert.ToSingle(m.Groups[1].Value);
            }
            catch (Exception ex)
            {
                re1 = ".*?"; // Non-greedy match on filler
                re2 = "(\\d+)";  // Integer Number 1
                Regex r = new Regex(re1 + re2, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                Match m = r.Match(txt);
                hashrate = Convert.ToSingle(m.Groups[1].Value);
            }
            return hashrate;
        }
        public static float get_eth_usd_rate()
        {
            float exchange = float.NaN;
            string url = "https://api.nanopool.org/v1/eth/prices";
            string txt = String.Empty;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            using (Stream stream = request.GetResponse().GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    txt = reader.ReadToEnd();
                }
            }

            string re1 = ".*?"; // Non-greedy match on filler
            string re2 = "([+-]?\\d*\\.\\d+)(?![-+0-9\\.])";    // Float 1

            Regex r = new Regex(re1 + re2, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m = r.Match(txt);
            exchange = Convert.ToSingle(m.Groups[1].ToString());
            return exchange;
        }
        public static float get_eth_btc_rate()
        {
            float exchange = float.NaN;
            string url = "https://api.nanopool.org/v1/eth/prices";
            string txt = String.Empty;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            using (Stream stream = request.GetResponse().GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    txt = reader.ReadToEnd();
                }
            }

            string re1 = ".*?"; // Non-greedy match on filler
            string re2 = "[+-]?\\d*\\.\\d+(?![-+0-9\\.])";  // Uninteresting: float
            string re3 = ".*?"; // Non-greedy match on filler
            string re4 = "([+-]?\\d*\\.\\d+)(?![-+0-9\\.])";    // Float 1

            Regex r = new Regex(re1 + re2 + re3 + re4, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m = r.Match(txt);
            exchange = Convert.ToSingle(m.Groups[1].ToString());
            return exchange;
        }
        public static float get_USD_Balance(string address)
        {
            float eth_balance = get_Balance(address);
            float eth_USD_Price = get_eth_usd_rate();
            return eth_balance * eth_USD_Price;
        }
    }
}
