using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;

namespace sign_up
{
    public partial class Signup : Form
    {
        readonly string? supabaseUrl = System.Configuration.ConfigurationManager.AppSettings["SupabaseUrl"];
        readonly string? supabaseApi = System.Configuration.ConfigurationManager.AppSettings["SupabaseApi"];
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var user = textBox1.Text;
            var email = textBox2.Text;
            var pass = textBox3.Text;
            var confimpass = textBox4.Text;
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(confimpass))
            {
                if (pass == confimpass)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {supabaseApi}");
                        client.DefaultRequestHeaders.Add("apikey", supabaseApi);
                        var obj = new { email = email, User = user, Password = pass };
                        var json = JsonSerializer.Serialize(obj);
                        var data = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await client.PostAsync($"{supabaseUrl}/rest/v1/userbase", data);


                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Successful Registration");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registration Failed");
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Password and Confirm Password is not the same");
                }
            }
            else
            {
                MessageBox.Show("Please Fill up all the Fields available");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
