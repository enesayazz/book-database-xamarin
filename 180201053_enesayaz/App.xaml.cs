using _180201053_enesayaz.DataTransactions;

namespace _180201053_enesayaz;

public partial class App : Application
{
	public static DBTrans DBTrans { get;private set; }
	public App(DBTrans dbtrans)
	{
		InitializeComponent();

		MainPage = new AppShell();
		DBTrans = dbtrans;
	}
}
