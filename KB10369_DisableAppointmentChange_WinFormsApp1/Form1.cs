using Infragistics.Win.UltraWinSchedule;

namespace KB10369_DisableAppointmentChange_WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ultraTimelineView1.CalendarInfo = ultraCalendarInfo1;
        ultraTimelineView1.EnsureDateTimeVisible(DateTime.Today.AddHours(9));

        Appointment appointment = ultraCalendarInfo1.Appointments.Add(new Appointment(DateTime.Today.AddHours(9), DateTime.Today.AddHours(12)));
        appointment.Subject = "予定(変更不可)";
        appointment.Locked = true;

    }
}
