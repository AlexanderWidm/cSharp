using CimoApp.Mvvm.Models;
using CimoApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace CimoApp.Mvvm.ViewModels;

public partial class AddViewModel : ObservableObject
{
    [ObservableProperty]
    ContactModel contact = new ContactModel();

    [RelayCommand]
    async Task Add()
    {
        try
        {
            //lägga till i en lista
            ContactService.AddToList(Contact);

            Contact = new ContactModel();
            await Shell.Current.GoToAsync("..");
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
    }

    [RelayCommand]
    async Task GoBack()
    {
        try
        {
            await Shell.Current.GoToAsync("..");
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

    }
}
