using System.Runtime.CompilerServices;

namespace BackgroundServiceDemo;

public partial class MainPage : ContentPage
{
    IService _service;
	public MainPage(IService service)
	{
		InitializeComponent();
        _service = service;
	}

   private void Start_Clicked(object sender, EventArgs e)
    {
        _service.Start();
    }

    private void Stop_Clicked(object sender, EventArgs e)
    {
        _service.Stop();
    }
}

