using System.Text.RegularExpressions;

namespace HTML_email_sender
{
    public partial class Form1 : Form
    {
        Email email = new Email();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click_1(object sender, EventArgs e)
        {
            if (Validation())
            {
                email.smtp = textBoxSMTP.Text;
                email.port = int.Parse(textBoxPort.Text);
                email.login = textBoxLogin.Text;
                email.pass = textBoxPass.Text;
                email.sendTo = textBoxSendTo.Text;
                email.sendFrom = textBoxSendFrom.Text;
                email.emailSubject = textBoxSubject.Text;
                email.HTMLtext = richTextBoxHTML.Text;
                email.SendMail();
            }
        }

        private bool Validation()
        {
            if (textBoxLogin.Text.Trim() == "")
            {
                MessageBox.Show("Please input login");
                return false;
            }
            if (textBoxSMTP.Text.Trim() == "")
            {
                MessageBox.Show("Please input SMTP server");
                return false;
            }
            if (textBoxPort.Text.Trim() == "")
            {
                MessageBox.Show("Please input SMTP port");
                return false;
            }
            if (textBoxPass.Text.Trim() == "")
            {
                MessageBox.Show("Please input password");
                return false;
            }
            if (textBoxSendTo.Text.Trim() == "")
            {
                MessageBox.Show("Please input reciever");
                return false;
            }
            if (textBoxSendFrom.Text.Trim() == "")
            {
                MessageBox.Show("Please input title");
                return false;
            }
            if (textBoxSubject.Text.Trim() == "")
            {
                MessageBox.Show("Please input Subject");
                return false;
            }
            if (richTextBoxHTML.Text.Trim() == "")
            {
                MessageBox.Show("Please input HTML");
                return false;
            }
            if (Email.email_validation().IsMatch(textBoxSendTo.Text) != true)
            {
                MessageBox.Show("Reciever's email is invalid");
                return false;
            }
            if (Email.email_validation().IsMatch(textBoxLogin.Text) != true)
            {
                MessageBox.Show("Login email is invalid");
                return false;
            }
            return true;
        }

        private void textBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8) 
                return;
            else
                e.Handled = true;
        }
    }
}