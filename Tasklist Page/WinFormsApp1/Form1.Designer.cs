namespace WinFormsApp1
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
            daycontainer = new FlowLayoutPanel();
            btnprevious = new Button();
            btnnext = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbdate = new Label();
            SuspendLayout();
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(12, 112);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1324, 523);
            daycontainer.TabIndex = 0;
            // 
            // btnprevious
            // 
            btnprevious.Location = new Point(1105, 641);
            btnprevious.Name = "btnprevious";
            btnprevious.Size = new Size(113, 40);
            btnprevious.TabIndex = 1;
            btnprevious.Text = "Previous";
            btnprevious.UseVisualStyleBackColor = true;
            btnprevious.Click += btnprevious_Click;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(1224, 641);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(108, 40);
            btnnext.TabIndex = 2;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 65);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 3;
            label1.Text = "Sunday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(252, 65);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 4;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(617, 65);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 6;
            label3.Text = "Wednesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(452, 65);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 5;
            label4.Text = "Tuesday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1196, 65);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 9;
            label6.Text = "Saturday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1013, 65);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 8;
            label7.Text = "Friday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(808, 65);
            label8.Name = "label8";
            label8.Size = new Size(105, 25);
            label8.TabIndex = 7;
            label8.Text = "Thursday";
            // 
            // lbdate
            // 
            lbdate.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbdate.Location = new Point(452, 9);
            lbdate.Name = "lbdate";
            lbdate.Size = new Size(461, 37);
            lbdate.TabIndex = 10;
            lbdate.Text = "month year";
            lbdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(lbdate);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnnext);
            Controls.Add(btnprevious);
            Controls.Add(daycontainer);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel daycontainer;
        private Button btnprevious;
        private Button btnnext;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lbdate;
    }
}