namespace CollegeFestMVC.Extensions;

public static class ParticipantExtensions
{
    public static string GetRegistrationStatus(this Participant participant)
    {
        return participant.IsConfirmed == true ? "Confirmed" : "Pending";
    }

    public static string GetFeeCategory(this Participant participant)
    {
        decimal fee = participant.RegistrationFee ?? 0m;

        if (fee <= 0m)
            return "Free Event";

        if (fee <= 500m)
            return "Standard Event";

        return "Premium Event";
    }
}
