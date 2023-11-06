namespace Timer_ile_Dijital_Saat_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }


        int saat = 0, dakika = 0, saniye = 0, lblsayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            saniye++;
            label3.Text = saniye.ToString();

            lblsayac++;
            if (lblsayac < 30)
            {

                label4.BackColor = Color.Yellow;
            }
            else if (lblsayac>=30 &&   lblsayac <= 60)
            {
                label4.BackColor = Color.Blue;
               
            }
            if (saniye == 60)
            {
                lblsayac = 0;
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
                if (dakika == 60)
                {
                    label4.BackColor = Color.Yellow;
                    saat = saat + 1;
                    label1.Text = saat.ToString();
                    dakika = 0;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}