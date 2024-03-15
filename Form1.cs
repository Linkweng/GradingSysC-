namespace GradingSys
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            
            InitializeComponent();
        }

        private void Compute_Clicked(object sender, EventArgs e)
        {

            
            int total = Convert.ToInt32((textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text));

            int average = total / 4;

            label1.Text = Convert.ToString(average);

            if (average < 75  )
            {
                label1.ForeColor = Color.Red;
            }else if (average > 80)
            {
                label1.ForeColor = Color.Green;
            }
        }
    }
}
