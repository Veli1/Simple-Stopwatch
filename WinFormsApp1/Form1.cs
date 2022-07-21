namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int saniye = 0, dakika = 0, saat = 0;
        int durum = 0;
        int tur = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Start";
            button2.Text = "Reset";



        }



        private void button2_Click(object sender, EventArgs e)
        {
            saniye = 0;
            dakika = 0;
            saat = 0;
            tur= 0;

            label1.Text = "00:00:00";
            label2.Text = "00:00:00";
            label3.Text = "00:00:00";
            label4.Text = "00:00:00";
            label5.Text = "00:00:00";
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (durum == 1)
            {
                if (tur == 0)
                {
                    label2.Text = label1.Text;
                    tur = 1;
                }
                else if (tur == 1)
                {
                    label3.Text = label1.Text;
                    tur = 2;
                }
                else if (tur == 2)
                {
                    label4.Text = label1.Text;
                    tur = 3;
                }
                else if (tur == 3)
                {
                    label5.Text = label1.Text;
                    tur = 4;
                    button3.Text = "Reset Lap";
                    button3.BackColor = Color.Red;
                }
                else if (tur == 4)
                {

                    label2.Text = "00:00:00";
                    label3.Text = "00:00:00";
                    label4.Text = "00:00:00";
                    label5.Text = "00:00:00";

                    tur = 0;

                    button3.Text = "Lap";
                    button3.BackColor = Color.Cyan;
                }
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (durum == 0)//Timer Start
            {
                button1.Text = "Stop";
                durum = 1;
                timer1.Start();
                button1.BackColor = Color.Gray;
            }
            else if (durum == 1)//Timer Stop
            {
                button1.Text = "Start";
                durum = 0;
                timer1.Stop();
                button1.BackColor = Color.Lime;
            }

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            if (dakika == 60)
            {
                saniye = 0;
                dakika = 0;
                saat++;
            }


            label1.Text = String.Format("{0:D2}", saat) + ":" + String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
            saniye++;



        }
    }
}