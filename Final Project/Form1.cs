using sign_up;
using System.Net.Mime;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Final_Project.AA;
using MimeKit;
using MailKit.Net.Smtp;

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
            string username = textBox1.Text.Trim();
            string password = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {supabaseApi}");
                client.DefaultRequestHeaders.Add("apikey", supabaseApi);

                string query = $"{supabaseUrl}/rest/v1/userbase?User=eq.{username}&select=email";
                var response = await client.GetAsync(query);
                string content = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Server error. Please try again.");
                    return;
                }

                MessageBox.Show($"Query: {query}\n\nResponse: {content}\n{textBox1.Text}\n{textBox3.Text}");

                var users = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(content);

                if (users == null || users.Count == 0)
                {
                    MessageBox.Show("Invalid username or password.");
                    return;
                }

                string userEmail = users[0]["email"];
                string otp = GenerateOtp();

                bool sent = await SendOtpEmail(client, userEmail, otp);

                if (sent)
                {
                    Otpoo otpForm = new Otpoo(otp, userEmail);
                    this.Hide();
                    otpForm.Show();
                }
                else
                {
                    MessageBox.Show("Login verified but failed to send OTP. Please try again.");
                }
            }
        }
        private string GenerateOtp()
        {
            Random rng = new Random();
            return rng.Next(100000, 999999).ToString();
        }
        private async Task<bool> SendOtpEmail(HttpClient client, string toEmail, string otp)
        {
            try
            {
                var otpRecord = new { email = toEmail, code = otp };
                var otpJson = JsonSerializer.Serialize(otpRecord);
                var otpBody = new StringContent(otpJson, System.Text.Encoding.UTF8, "application/json");
                var otpResponse = await client.PostAsync($"{supabaseUrl}/rest/v1/otp_codes", otpBody);

                if (!otpResponse.IsSuccessStatusCode) return false;

                var message = new MimeKit.MimeMessage();
                message.From.Add(new MimeKit.MailboxAddress("AAAAA", "jadericmc06@gmail.com"));
                message.To.Add(new MimeKit.MailboxAddress("", toEmail));
                message.Subject = "Your OTP Code";
                message.Body = new MimeKit.TextPart("plain") { Text = $"Your verification code is: {otp}" };

                using var smtp = new MailKit.Net.Smtp.SmtpClient();
                await smtp.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync("jadericmc06@gmail.com", "ltqi tcaj fdgb xpbn");
                await smtp.SendAsync(message);
                await smtp.DisconnectAsync(true);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Email error: {ex.Message}");
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Signup sign = new Signup();
            sign.Show();
        }
    }
}
