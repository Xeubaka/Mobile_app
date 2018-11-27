using App_standard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_standard
{
    public class Promotion
    {
        public static readonly string Url = "https://pastebin.com/raw/R9cJFBtG";
        public string Name { get; set; }
        public int Category_id { get; set; }
        public object Policies { get; set; }

        //implementar HttpRequest.FetchData<Promotion>(Url);
        public static async Task<List<Promotion>> GetPromotions()
        {
            var Promotions = await HttpRequest.FetchData<Promotion>(Url);
            return Promotions;
        }
    }
}