using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kanelbullen.Mvvm.Models;
using Kanelbullen.Mvvm.Services;

namespace Kanelbullen.Mvvm.ViewModels;

public partial class EditViewModel : ObservableObject
{
    private readonly MemberService _memberService;
    {
    public EditViewModel(MemberService memberService)
    {
        _member
    }


    [ObservableProperty]
    private string firstName;
    [ObservableProperty]
    private string lastName;
    [ObservableProperty]
    private string email;


    [RelayCommand]
    public async Task Save()
    {
        var member = new MemberModel()
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };

        _memberService
        await Shell.Current.GoToAsync("..");
    }
}
