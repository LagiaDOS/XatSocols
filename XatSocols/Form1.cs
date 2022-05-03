

namespace XatSocols
{
   
    public partial class Form1 : Form
    {
        Client client;
        public Form1()
        {
            client = new Client();
            client.Run();
            Console.WriteLine("test");
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            client.missatge = textbox_missatge.Text;
            



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}