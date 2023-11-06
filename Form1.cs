using System.Security.Cryptography.Xml;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            listBox1.Items.Clear(); // Limpia el contenido anterior del ListBox

            int x = 0;
            do
            {
                listBox1.Items.Add(x);
                x++;
            }
            while (x <= 10);
        }


    }
}