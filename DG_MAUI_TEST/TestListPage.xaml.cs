namespace DG_MAUI_TEST;

public partial class TestListPage : ContentPage
{
	public TestListPage()
	{
		InitializeComponent();

		SetLabel_Tap_Event();
	}
	private void backBtn_Clicked(object sender, EventArgs e)
	{
		Application.Current.MainPage = new NavigationPage(new MainPage());
	}

	public void SetLabel_Tap_Event()
	{
		var moveTo_tap = new TapGestureRecognizer();
		moveTo_tap.Tapped += (s, e) =>
		{
			//
			//  Do your work here.
			//
		};
		moveToLbl.GestureRecognizers.Add(moveTo_tap);
	}

	private void moveToBtn_Clicked(object sender, EventArgs e)
	{

	}
}
