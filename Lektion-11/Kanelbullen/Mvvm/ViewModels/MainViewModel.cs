using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kanelbullen.Mvvm.Models;
using Kanelbullen.Mvvm.Services;
using Kanelbullen.Mvvm.Views;
using System.Collections.ObjectModel;

namespace Kanelbullen.Mvvm.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly MemberService _memberService;
    


    [ObservableProperty]
    private ObservableCollection<MemberModel> members;
    public MainViewModel(MemberService memberService)
    {
        _memberService = memberService;
        Members = new ObservableCollection<MemberModel>()
        {
            new MemberModel() { FirstName="Alexander", LastName="Widmark", Email="widmark.alexander@gmail.com"}
        };
        //GetMembers();
    }
    private void GetMembers()
    {
        Members.Clear();
        foreach (var member in _memberService.GetMembersFromList())
            Members.Add(member);
    }

    [RelayCommand]
    public async Task GoToDetail()
    {
        await Shell.Current.GoToAsync(nameof(DetailPage));
    }
    [RelayCommand]
    public async Task GoToEdit()
    {
        await Shell.Current.GoToAsync(nameof(EditPage));
    }
}
