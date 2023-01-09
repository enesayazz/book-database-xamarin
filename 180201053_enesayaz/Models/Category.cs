using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180201053_enesayaz.Models
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int category_id { get; set; }

        public string category_name { get; set; }
    }
}
