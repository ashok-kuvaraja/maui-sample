namespace MauiProject;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        label.Loaded += Label_Loaded;
	}

    private void Label_Loaded(object sender, EventArgs e)
    {
        if (label.IsLabelMeasured)
        {
            label.Text = "Label is measured when invoking its loaded event";
        }
        else
        {
            label.Text = "Label isn't measured when invoking its loaded event";
        }
    }
}

