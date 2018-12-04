using App_standard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_standard
{
    public class Iten
    {
        public static string Url = "https://pastebin.com/raw/eVqp7pfX";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public double Price { get; set; }
        public int? Category_Id { get; set; }

        public int btn_less_id{ get; set;}
        public int btn_plus_id { get; set; }
        public int Quantidade { get; set; }

        public static async Task<List<Iten>> GetItens()
        {
            List<Iten> itens = await HttpRequest.FetchData<Iten>(Url);
            return itens;
        }
    }
}
