namespace HTML_email_sender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSMTP = new System.Windows.Forms.TextBox();
            this.LabelSmtp = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelSendFrom = new System.Windows.Forms.Label();
            this.textBoxSendFrom = new System.Windows.Forms.TextBox();
            this.labelSendTo = new System.Windows.Forms.Label();
            this.textBoxSendTo = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.richTextBoxHTML = new System.Windows.Forms.RichTextBox();
            this.labelHTML = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSMTP
            // 
            this.textBoxSMTP.Location = new System.Drawing.Point(12, 37);
            this.textBoxSMTP.Name = "textBoxSMTP";
            this.textBoxSMTP.Size = new System.Drawing.Size(128, 23);
            this.textBoxSMTP.TabIndex = 0;
            // 
            // LabelSmtp
            // 
            this.LabelSmtp.AutoSize = true;
            this.LabelSmtp.Location = new System.Drawing.Point(12, 20);
            this.LabelSmtp.Name = "LabelSmtp";
            this.LabelSmtp.Size = new System.Drawing.Size(37, 15);
            this.LabelSmtp.TabIndex = 1;
            this.LabelSmtp.Text = "SMTP";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(146, 20);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 15);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "PORT";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(146, 37);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(128, 23);
            this.textBoxPort.TabIndex = 2;
            this.textBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPort_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pass";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(146, 90);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(128, 23);
            this.textBoxPass.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(12, 90);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(128, 23);
            this.textBoxLogin.TabIndex = 4;
            // 
            // labelSendFrom
            // 
            this.labelSendFrom.AutoSize = true;
            this.labelSendFrom.Location = new System.Drawing.Point(146, 131);
            this.labelSendFrom.Name = "labelSendFrom";
            this.labelSendFrom.Size = new System.Drawing.Size(91, 15);
            this.labelSendFrom.TabIndex = 11;
            this.labelSendFrom.Text = "SendFrom(Title)";
            // 
            // textBoxSendFrom
            // 
            this.textBoxSendFrom.Location = new System.Drawing.Point(146, 148);
            this.textBoxSendFrom.Name = "textBoxSendFrom";
            this.textBoxSendFrom.Size = new System.Drawing.Size(128, 23);
            this.textBoxSendFrom.TabIndex = 10;
            // 
            // labelSendTo
            // 
            this.labelSendTo.AutoSize = true;
            this.labelSendTo.Location = new System.Drawing.Point(12, 131);
            this.labelSendTo.Name = "labelSendTo";
            this.labelSendTo.Size = new System.Drawing.Size(45, 15);
            this.labelSendTo.TabIndex = 9;
            this.labelSendTo.Text = "SendTo";
            // 
            // textBoxSendTo
            // 
            this.textBoxSendTo.Location = new System.Drawing.Point(12, 148);
            this.textBoxSendTo.Name = "textBoxSendTo";
            this.textBoxSendTo.Size = new System.Drawing.Size(128, 23);
            this.textBoxSendTo.TabIndex = 8;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(12, 182);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(78, 15);
            this.labelSubject.TabIndex = 13;
            this.labelSubject.Text = "Email Subject";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(12, 199);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(262, 23);
            this.textBoxSubject.TabIndex = 12;
            this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
            // 
            // richTextBoxHTML
            // 
            this.richTextBoxHTML.Location = new System.Drawing.Point(12, 250);
            this.richTextBoxHTML.Name = "richTextBoxHTML";
            this.richTextBoxHTML.Size = new System.Drawing.Size(262, 151);
            this.richTextBoxHTML.TabIndex = 14;
            this.richTextBoxHTML.Text = "";
            // 
            // labelHTML
            // 
            this.labelHTML.AutoSize = true;
            this.labelHTML.Location = new System.Drawing.Point(12, 232);
            this.labelHTML.Name = "labelHTML";
            this.labelHTML.Size = new System.Drawing.Size(39, 15);
            this.labelHTML.TabIndex = 15;
            this.labelHTML.Text = "HTML";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(101, 429);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 16;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 475);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelHTML);
            this.Controls.Add(this.richTextBoxHTML);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.labelSendFrom);
            this.Controls.Add(this.textBoxSendFrom);
            this.Controls.Add(this.labelSendTo);
            this.Controls.Add(this.textBoxSendTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.LabelSmtp);
            this.Controls.Add(this.textBoxSMTP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxSMTP;
        private Label LabelSmtp;
        private Label labelPort;
        private TextBox textBoxPort;
        private Label label1;
        private TextBox textBoxPass;
        private Label label2;
        private TextBox textBoxLogin;
        private Label labelSendFrom;
        private TextBox textBoxSendFrom;
        private Label labelSendTo;
        private TextBox textBoxSendTo;
        private Label labelSubject;
        private TextBox textBoxSubject;
        private RichTextBox richTextBoxHTML;
        private Label labelHTML;
        private Button buttonSend;
    }
}