using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace numfortuneuno.Presentation;

public partial class MainModel : ObservableObject
{
    private INavigator _navigator;

    public MainModel(
        IOptions<AppConfig> appInfo,
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "numerone's fortune uno";
        Title += $" - {appInfo?.Value?.Environment}";
        client = new HttpClient();
        Click = new AsyncRelayCommand(OnTick_Click);
        OnTick_Click();
    }

    public ICommand Click { get; }
    private async Task OnTick_Click()
    {

        try
        {
            httpResponse = await client.GetAsync("https://helloacm.com/api/fortune/");
            
        }
        catch (Exception ex)
        {
            Error = ex.Message;
            MainPage.Current?.DispatcherQueue?.TryEnqueue(() =>
            {
                OnPropertyChanged(nameof(Error));
            });
            MainPage.Current.ShowSnackbar();
            return;
        }

        if (httpResponse.IsSuccessStatusCode)
        {
            String s = await httpResponse.Content.ReadAsStringAsync();
            s = s.Substring(1, s.Length - 2);
            s = s.Replace("\\n", System.Environment.NewLine);
            s = s.Replace("\\t", "	");
            s = s.Replace("\\b", "");
            s = s.Replace("\\\"", "\"");
            Cookie = s;
        }
        else
        {
            Error = $"The HTTP status code is ${httpResponse.StatusCode}";
            MainPage.Current?.DispatcherQueue?.TryEnqueue(() =>
            {
                OnPropertyChanged(nameof(Error));
            });
            MainPage.Current.ShowSnackbar();
        }
        MainPage.Current?.DispatcherQueue?.TryEnqueue(() =>
        {
            OnPropertyChanged(nameof(Cookie));
        });

    }
    public string? Title { get; }
    public string? Cookie { get; private set; }
    public string? Error { get; private set; }
    private HttpResponseMessage httpResponse;
    private HttpClient client;
}
