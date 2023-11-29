namespace WinFormsApp1
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbdays = new Label();
            lbname = new Label();
            SuspendLayout();
            // 
            // lbdays
            // 
            lbdays.AutoSize = true;
            lbdays.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbdays.Location = new Point(17, 15);
            lbdays.Name = "lbdays";
            lbdays.Size = new Size(34, 28);
            lbdays.TabIndex = 0;
            lbdays.Text = "00";
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbname.Location = new Point(116, 15);
            lbname.Name = "lbname";
            lbname.Size = new Size(34, 28);
            lbname.TabIndex = 1;
            lbname.Text = "00";
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbname);
            Controls.Add(lbdays);
            Name = "UserControlDays";
            Size = new Size(183, 81);
            Load += UserControlDays_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdays;
        private Label lbname;
    }
}
