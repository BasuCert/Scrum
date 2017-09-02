using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyScrumWebService
{
    public class MyHash
    {
        public string Input{ get; set; }
        public MyHash(string input)
        {
            Input = input;
        }
        public string GetSha1()
        {
            return System.Security.Cryptography.SHA1.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(Input)).Aggregate(string.Empty, (current, next) => current + next.ToString("X2"));
        }
    }
}