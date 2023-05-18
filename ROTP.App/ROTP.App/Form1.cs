using LOTPHI.OTPGenerator.OTPServices.Servises;

namespace ROTP.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var otp = OTPGeneratorService.GenerateOtp(textBox1.Text, 5);

            textBox2.Text = otp;

            var time = DateTime.UtcNow.ToLongTimeString();

            label4.Text = time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var otp = OTPGeneratorService.ValidateOtp(textBox1.Text, textBox2.Text, 120);

            MessageBox.Show("Validate status: " + otp.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ThreadPool.QueueUserWorkItem(ValitdateOtp);
        }

        private  void ValitdateOtp(object obj)
        {
            var otp = OTPGeneratorService.ValidateOtp(textBox1.Text, textBox2.Text, 120); // 120 is 2 minutes

            while (otp)
            {
                Thread.Sleep(1000);
                otp = OTPGeneratorService.ValidateOtp(textBox1.Text, textBox2.Text, 120);

                listBox1.Items.Add("Validate status: " + otp.ToString());
            }

            var time = DateTime.UtcNow.ToLongTimeString();

            MessageBox.Show("Expier at =" + time);
        }

    }
}