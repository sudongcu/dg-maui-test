namespace DG_MAUI_TEST;

public partial class MainPage : ContentPage
{
	double count = 0;
	int maxCount = 10;

	public MainPage()
	{
		InitializeComponent();

		countLbl.Text = $"0/{maxCount}";
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count > maxCount)
		{
			CounterBtn.Text = $"Counted at max limit";
			return;
		}

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";


		countLbl.Text = $"{count}/{maxCount}";
		progressBar.Progress = count / 10;

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

