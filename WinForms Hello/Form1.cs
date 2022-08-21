namespace WinForms_Hello
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labSay.Text = "Hello World ! ";

        }
        bool f;
        private void btnCount_Click(object sender, EventArgs e)
        {
            int i = 1;
            f = true;
            while (f==true)
            {

                labCount.Text = i.ToString();
                i++;
                Refresh();
                System.Threading.Thread.Sleep(500);
                if (i == 11)
                {
                    i = 1;
                }
                Application.DoEvents();

            }
         }

        
        bool fg;
        private void btnTime_Click(object sender, EventArgs e)
        {
            int j = 0;
            fg = true;

            while (fg == true)
            {
                j++;
                labTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                Refresh();
                System.Threading.Thread.Sleep(1000);
                if (j == 1000)
                    j = 0;


                Application.DoEvents(); 


            }


        }

        private void btnTS_Click(object sender, EventArgs e)
        {
            fg = false;
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            f = false;

        }
    }
}
    