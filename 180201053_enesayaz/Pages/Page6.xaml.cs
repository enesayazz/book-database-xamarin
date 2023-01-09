using _180201053_enesayaz.Models;

namespace _180201053_enesayaz;

public partial class Page6 : ContentPage
{
    private int tappedCatid;
    private int tappedBookid;
	public Page6()
	{
		InitializeComponent();
		Book_list_view.ItemsSource = App.DBTrans.GetAllBooks();
		Cat_list_view.ItemsSource = App.DBTrans.GetAllCategories();
	}

    private void Cat_list_view_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var tappedCat = e.Item as Category;
        tappedCatid = tappedCat.category_id;
    }

    private void Book_list_view_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var tappedBook = e.Item as Book;
        tappedBookid = tappedBook.book_id;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        {
            App.DBTrans.EntrollADD(new Models.Entroll
            {

                category_id = tappedCatid,
                book_id = tappedBookid,



            });
            catbook_entroll.ItemsSource = App.DBTrans.GetEntrolls();


        }
    }
    private void Button_Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteENTROLL((int)button.BindingContext);
        catbook_entroll.ItemsSource = App.DBTrans.GetEntrolls();
    }
}