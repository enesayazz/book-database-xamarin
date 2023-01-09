using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180201053_enesayaz.Models
{
    public class Book
    {
        [PrimaryKey, AutoIncrement]
        public int book_id { get; set; }
        public string book_name { get; set; }
        public int author_id { get; set; }
        public int category_id { get; set; }

    }
}
