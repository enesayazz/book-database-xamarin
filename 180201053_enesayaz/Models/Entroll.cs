using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace _180201053_enesayaz.Models
{
    public class Entroll
    {
        [PrimaryKey, AutoIncrement]
        public int entroll_id { get; set; }

        public int book_id { get; set; }

        public int author_id { get; set; }

        public int category_id { get; set; }
    }
}
