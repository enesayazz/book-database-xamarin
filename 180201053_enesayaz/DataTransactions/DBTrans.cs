using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _180201053_enesayaz.Models;
using SQLite;


namespace _180201053_enesayaz.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<Author>();
            conn.CreateTable<Category>();
            conn.CreateTable<Book>();
            conn.CreateTable<Entroll>();
        }

        public List<Author> GeAllAuthors()
        {
            Init();
            return conn.Table<Author>().ToList();
        }
        public List<Category> GetAllCategories()
        {
            Init();
            return conn.Table<Category>().ToList();
        }
        public List<Book> GetAllBooks()
        {
            Init();
            return conn.Table<Book>().ToList();
        }
        public List<Entroll> GetEntrolls()
        {
            Init();
            return conn.Table<Entroll>().ToList();
        }
        public void Add(Author author)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(author);
        }
        public void AddCAT(Category category)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(category);
        }
        public void AddBOOK(Book book)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(book);
        }
        public void Delete(int auth_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Author { author_id = auth_id });

        }
        public void DeleteCAT(int cate_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Category { category_id = cate_id });
        }
        public void DeleteBOOK(int bok_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Book { book_id = bok_id });
        }
        public void EntrollADD(Entroll entroll)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(entroll);
        }
        public void DeleteENTROLL(int ent_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Entroll { entroll_id = ent_id });
        }
    }
}
