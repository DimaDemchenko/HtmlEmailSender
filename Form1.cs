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
}