namespace _180201053_enesayaz;
using Models;
public partial class Page4 : ContentPage
{
    
	public Page4()
    {
        InitializeComponent();
        Book_list_view.ItemsSource = App.DBTrans.GetAllBooks();
        Category_picker.ItemsSource = App.DBTrans.GetAllCategories();
        Author_picker.ItemsSource = App.DBTrans.GeAllAuthors();
        

    }
    private void Button_add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddBOOK(new Models.Book
        {

            book_name = Book_Name.Text,
            author_id = Author_picker.SelectedIndex,
            category_id = Category_picker.SelectedIndex,
            

        });
        Book_list_view.ItemsSource = App.DBTrans.GetAllBooks();

    }



    private void Button_Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteBOOK((int)button.BindingContext);
        Book_list_view.ItemsSource = App.DBTrans.GetAllBooks();
    }

}