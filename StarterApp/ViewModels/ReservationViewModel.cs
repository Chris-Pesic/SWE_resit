using CommunityToolkit.Mvvm.ComponentModel;
using StarterApp.Database.Data;
using StarterApp.Database.Models;

public partial class ReservationsViewModel : ObservableObject
{
    private readonly AppDbContext _db;

    public ReservationsViewModel()
    {
        _db = new AppDbContext();
        LoadReservations();
    }

    [ObservableProperty]
    private List<ReservationDisplay> speakerReservations;

    private void LoadReservations()
    {
        int currentUserId = LoggedInUser.Id; // Replace this with your actual logged-in user access

        SpeakerReservations = _db.Reservations
            .Where(r => r.Conference.Speaker == LoggedInUser.FullName)
            .Select(r => new ReservationDisplay
            {
                ConferenceTitle = r.Conference.Speaker + " at " + r.Conference.Location,
                AttendeeName = r.User.FirstName + " " + r.User.LastName,
            })
            .ToList();
    }

    public class ReservationDisplay
    {
        public string ConferenceTitle { get; set; }
        public string AttendeeName { get; set; }
    }
}