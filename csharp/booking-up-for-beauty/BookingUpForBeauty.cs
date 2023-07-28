using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return DateTime.Compare(appointmentDate, DateTime.Now) < 0;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        int appointmentHour = appointmentDate.TimeOfDay.Hours;
        return appointmentHour >=12 & appointmentHour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15);
    }
}
