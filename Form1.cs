namespace Time_Clock
{
    public partial class Form1 : Form
    {
        private List<DateTime> wtime = new List<DateTime>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var currTime = DateTime.Pdt;
            //checkinlbl.Text = currTime.ToString("T"); 

            //Search the Pacific Standard Time by Id
            var zone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            //Get the utc time
            var utc = DateTime.UtcNow;

            //Convert utc time to Pacific Standard Time zone
            var pacificNow = TimeZoneInfo.ConvertTimeFromUtc(utc, zone);

            //display check-in time
            checkinlbl.Text = pacificNow.ToString("t");
            wtime.Add(pacificNow);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var zone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            var utc = DateTime.UtcNow;
            var pacificNow = TimeZoneInfo.ConvertTimeFromUtc(utc, zone);
            checkoutlbl.Text = pacificNow.ToString("t");
            wtime.Add(pacificNow);


            TimeSpan tspan = wtime[1] - wtime[0];
            totalHoursWorkedlbl.Text = tspan.ToString("t");


        }
    }
}
