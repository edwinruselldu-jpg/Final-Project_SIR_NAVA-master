using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Otpoo : Form
    {
        readonly string? supabaseUrl = System.Configuration.ConfigurationManager.AppSettings["SupabaseUrl"];
        readonly string? supabaseApi = System.Configuration.ConfigurationManager.AppSettings["SupabaseApi"];

        private readonly string _expectedOtp;
        private readonly string _userEmail;
        public Otpoo(string expectedOtp, string userEmail)
        {
            InitializeComponent();
            _expectedOtp = expectedOtp;
            _userEmail = userEmail;
            label1.Text = $"A verification code was sent to {userEmail}. Please enter it below.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string entered = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(entered))
            {
                MessageBox.Show("Please enter the OTP code.");
                return;
            }
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {supabaseApi}");
                client.DefaultRequestHeaders.Add("apikey", supabaseApi);

                string query = $"{supabaseUrl}/rest/v1/otp_codes?email=eq.{Uri.EscapeDataString(_userEmail)}&code=eq.{Uri.EscapeDataString(entered)}&select=*&limit=1";
                var response = await client.GetAsync(query);
                string content = await response.Content.ReadAsStringAsync();

                var matches = JsonSerializer.Deserialize<List<JsonElement>>(content);

                if (matches != null && matches.Count > 0)
                {
                    await client.DeleteAsync($"{supabaseUrl}/rest/v1/otp_codes?email=eq.{Uri.EscapeDataString(_userEmail)}");
                    MessageBox.Show("Login successful! Welcome.");
                    Form2 home = new Form2();
                    this.Close();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid or expired OTP. Please try again.");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Otpoo_Load(object sender, EventArgs e)
        {

        }
    }

}

