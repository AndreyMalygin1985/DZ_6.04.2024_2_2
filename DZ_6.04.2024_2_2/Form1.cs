namespace DZ_6._04._2024_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            {
                DateTime startDate = startDatePicker.Value.Date;
                DateTime endDate = endDatePicker.Value.Date;

                TimeSpan difference = endDate - startDate;
                int daysDifference = difference.Days;

                resultLabel.Text = $"���������� ���� ����� {startDate.ToShortDateString()} � {endDate.ToShortDateString()} ���������� {daysDifference} ����.";
            }
        }
    }
}
