namespace Ginga_Alexandra_Lab7;
using Ginga_Alexandra_Lab7.Models;
using Ginga_Alexandra_Lab7.Data;



public partial class ListEntryPage : ContentPage
{
    public ListEntryPage()
    {
       // InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
       // ListView.ItemsSource = await App.Database.GetShopListsAsync();
    }
    async void OnShopListAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPage
        {
            BindingContext = new ShopList()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = e.SelectedItem as ShopList
            });
        }
    }
}