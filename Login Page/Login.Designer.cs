namespace Login_Page
{
    partial class LoginPage
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
            EmailLabel = new Label();
            PasswordLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(260, 216);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(99, 36);
            EmailLabel.TabIndex = 0;
            EmailLabel.Text = "Email:";
            EmailLabel.Click += label1_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(215, 306);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(144, 36);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(395, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 44);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(395, 298);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 44);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(395, 411);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(267, 76);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 681);
            Controls.Add(LoginButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailLabel);
            Name = "LoginPage";
            Text = "Login Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EmailLabel;
        private Label PasswordLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button LoginButton;
    }
}