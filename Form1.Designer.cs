namespace Assignment4
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
            loginBtn = new Button();
            passwordTxt = new TextBox();
            emailTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(153, 275);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 9;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(240, 156);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(193, 27);
            passwordTxt.TabIndex = 8;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(240, 81);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(193, 27);
            emailTxt.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 163);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 88);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 5;
            label1.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(339, 275);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Cancle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 387);
            Controls.Add(button1);
            Controls.Add(loginBtn);
            Controls.Add(passwordTxt);
            Controls.Add(emailTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private TextBox passwordTxt;
        private TextBox emailTxt;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
