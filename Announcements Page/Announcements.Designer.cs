namespace Announcements_Page
{
    partial class AnnouncementsPage
    {
        /// <summy>
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
            SubmitDate = new DateTimePicker();
            SubmitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // SubmitDate
            // 
            SubmitDate.Location = new Point(623, 646);
            SubmitDate.Name = "SubmitDate";
            SubmitDate.Size = new Size(200, 23);
            SubmitDate.TabIndex = 0;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(542, 646);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(623, 628);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 4;
            label1.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(834, 628);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 5;
            label2.Text = "hrs";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(880, 628);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "mins";
            label3.Click += label3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(542, 475);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(378, 144);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(834, 644);
            numericUpDown1.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(40, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(880, 644);
            numericUpDown2.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(40, 23);
            numericUpDown2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(655, 457);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 10;
            label4.Text = "Make an announcement";
            label4.Click += label4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "This is an announcement" });
            listBox1.Location = new Point(12, 58);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 199);
            listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "This is an other announcement" });
            listBox2.Location = new Point(12, 288);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(308, 199);
            listBox2.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 9);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 13;
            label5.Text = "Announcements";
            // 
            // AnnouncementsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 681);
            Controls.Add(label5);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SubmitButton);
            Controls.Add(SubmitDate);
            Name = "AnnouncementsPage";
            Text = "Announcements Page";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SubmitDate;
        private Button SubmitButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label5;
    }
}