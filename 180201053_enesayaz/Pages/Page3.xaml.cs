

namespace _180201053_enesayaz;

public partial class Page3 : ContentPage
{
	public Page3()
    {
        InitializeComponent();
        Cat_list_view.ItemsSource = App.DBTrans.GetAllCategories();

    }
    private void Button_add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddCAT(new Models.Category
        {

            category_name = category_NAME.Text,

        });
        Cat_list_view.ItemsSource = App.DBTrans.GetAllCategories();
    }



    private void Button_Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteCAT((int)button.BindingContext);
        Cat_list_view.ItemsSource = App.DBTrans.GetAllCategories();
    }
}