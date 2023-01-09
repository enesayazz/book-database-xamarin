namespace _180201053_enesayaz;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
		Auth_List_View.ItemsSource = App.DBTrans.GeAllAuthors();

	}
	private void Button_Add_Clicked(object sender, EventArgs e) 
	{
		App.DBTrans.Add(new Models.Author
		{
			
			author_name = Auth_NAME.Text,

		});
		Auth_List_View.ItemsSource = App.DBTrans.GeAllAuthors();
	}



	private void Button_Delete_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		App.DBTrans.Delete((int)button.BindingContext);
		Auth_List_View.ItemsSource = App.DBTrans.GeAllAuthors();
	}
}