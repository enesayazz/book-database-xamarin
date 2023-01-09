using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180201053_enesayaz.Models
{
    public class Author
    {
        [PrimaryKey, AutoIncrement]
        public int author_id { get; set; }
        public string author_name { get; set; }
    }
}
