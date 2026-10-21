namespace CollegeFestMVC.Models;

public class Participant
{
    public int ParticipantId { get; set; }

    [Required(ErrorMessage = "Please enter your name.")]
    [StringLength(80, MinimumLength = 2)]
    public string ParticipantName { get; set; } = string.Empty;

    [Required]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Choose your department.")]
    public string Department { get; set; } = string.Empty;

    [Required(ErrorMessage = "Choose your year.")]
    public string Year { get; set; } = string.Empty;

    [Required(ErrorMessage = "Choose an event.")]
    public string EventName { get; set; } = string.Empty;

    public bool IsTeamEvent { get; set; }

    // Null means the registration has not yet been reviewed.
    public bool? IsConfirmed { get; set; } = true;

    public decimal? RegistrationFee { get; set; } = 0m;
}
