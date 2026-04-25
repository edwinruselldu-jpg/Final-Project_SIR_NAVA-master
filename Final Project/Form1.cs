using sign_up;
using System.Net.Mime;
using System.Text.Json;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        readonly string supabaseUrl = "https://edfvfzshguwadnuzivgn.supabase.co";
        readonly string supabaseApi = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImVkZnZmenNoZ3V3YWRudXppdmduIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NzY2NzE4MjMsImV4cCI6MjA5MjI0NzgyM30.33hlUCaWSGxfSqFdM-3sgBEPWMQhqUSTBZObVfdjZt4";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {supabaseApi}");
                client.DefaultRequestHeaders.Add("apikey", supabaseApi);
                var response = await client.GetAsync($"{supabaseUrl}/rest/v1/userbase?select=*&User=eq.{textBox1.Text}&Password=eq.{textBox3.Text}");
                string content = await response.Content.ReadAsStringAsync();


                if (response.IsSuccessStatusCode)
                {
                    if (content == "[]")
                    {
                        MessageBox.Show("Invalid Login");
                    }

                    else
                    {
                        MessageBox.Show("REYAL SUGEGES");
                    }

                }
                else
                {
                    MessageBox.Show("PEYK");

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup sign = new Signup();
            sign.Show();
        }
    }
}
