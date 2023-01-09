namespace _180201053_enesayaz;

using _180201053_enesayaz.DataTransactions;
using Models;

public partial class Page5 : ContentPage
{
    int tappedBookid;
    int tappedAuthid;
    public Page5()
        
	{ 

		InitializeComponent();
        Book_list_view.ItemsSource = App.DBTrans.GetAllBooks();
        Auth_list_view.ItemsSource = App.DBTrans.GeAllAuthors();
 
    }

    private  void Auth_list_view_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var tappedAuth = (Author)e.Item;
        tappedAuthid = tappedAuth.author_id;
 
    }

    private void Book_list_view_ItemTapped(object sender, ItemTappedEventArgs e)
    {
       var tappedBook = (Book)e.Item;
       tappedBookid = tappedBook.book_id;
        
       
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.EntrollADD(new Models.Entroll
        {

            author_id = tappedAuthid,
            book_id = tappedBookid,
            


        });
        authbook_entroll.ItemsSource = App.DBTrans.GetEntrolls();


    }
    
    

    private void Button_Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteENTROLL((int)button.BindingContext);
        authbook_entroll.ItemsSource = App.DBTrans.GetEntrolls();
    }
}