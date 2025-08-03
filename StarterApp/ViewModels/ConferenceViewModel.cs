using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StarterApp.Database.Models;
using StarterApp.Database.Data;
using StarterApp.Services;

public partial class ConferenceViewModel : ObservableObject
{
    private readonly AppDbContext db;

    public ConferenceViewModel()
    {
        db = new AppDbContext();
        NewConference = new();
        LoadConferences();
    }

    [ObservableProperty]
    private List<Conference> upcomingConferences;

    [ObservableProperty]
    private Conference newConference;

    [RelayCommand]
    private void LoadConferences()
    {
        UpcomingConferences = db.Conferences
            .Where(c => c.Time > DateTime.Now)
            .OrderBy(c => c.Time)
            .ToList();
    }

    [RelayCommand]
    private void AddConference()
    {
        if (NewConference == null) return;

        db.Conferences.Add(NewConference);
        db.SaveChanges();

        NewConference = new Conference();
        LoadConferences();
    }
}