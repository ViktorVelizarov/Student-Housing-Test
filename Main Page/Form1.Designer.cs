namespace Main_Page
{
    partial class MainPage
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
            HouseRulesButton = new Button();
            AgreementsButton = new Button();
            GroceriesButton = new Button();
            TaskCalendarButton = new Button();
            LogoutButton = new Button();
            AnnouncmentsButton = new Button();
            SuspendLayout();
            // 
            // HouseRulesButton
            // 
            HouseRulesButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            HouseRulesButton.Location = new Point(376, 247);
            HouseRulesButton.Name = "HouseRulesButton";
            HouseRulesButton.Size = new Size(250, 85);
            HouseRulesButton.TabIndex = 0;
            HouseRulesButton.Text = "House Rules";
            HouseRulesButton.UseVisualStyleBackColor = true;
            // 
            // AgreementsButton
            // 
            AgreementsButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AgreementsButton.Location = new Point(376, 135);
            AgreementsButton.Name = "AgreementsButton";
            AgreementsButton.Size = new Size(250, 85);
            AgreementsButton.TabIndex = 1;
            AgreementsButton.Text = "Agreements";
            AgreementsButton.UseVisualStyleBackColor = true;
            AgreementsButton.Click += button2_Click;
            // 
            // GroceriesButton
            // 
            GroceriesButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            GroceriesButton.Location = new Point(376, 359);
            GroceriesButton.Name = "GroceriesButton";
            GroceriesButton.Size = new Size(250, 85);
            GroceriesButton.TabIndex = 2;
            GroceriesButton.Text = "Grocery Payments";
            GroceriesButton.UseVisualStyleBackColor = true;
            // 
            // TaskCalendarButton
            // 
            TaskCalendarButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TaskCalendarButton.Location = new Point(376, 23);
            TaskCalendarButton.Name = "TaskCalendarButton";
            TaskCalendarButton.Size = new Size(250, 85);
            TaskCalendarButton.TabIndex = 3;
            TaskCalendarButton.Text = "Task Calendar";
            TaskCalendarButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutButton.Location = new Point(12, 584);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(250, 85);
            LogoutButton.TabIndex = 4;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            // 
            // AnnouncmentsButton
            // 
            AnnouncmentsButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AnnouncmentsButton.Location = new Point(376, 469);
            AnnouncmentsButton.Name = "AnnouncmentsButton";
            AnnouncmentsButton.Size = new Size(250, 85);
            AnnouncmentsButton.TabIndex = 6;
            AnnouncmentsButton.Text = "Announcements";
            AnnouncmentsButton.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 681);
            Controls.Add(AnnouncmentsButton);
            Controls.Add(LogoutButton);
            Controls.Add(TaskCalendarButton);
            Controls.Add(GroceriesButton);
            Controls.Add(AgreementsButton);
            Controls.Add(HouseRulesButton);
            Name = "MainPage";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button HouseRulesButton;
        private Button AgreementsButton;
        private Button GroceriesButton;
        private Button TaskCalendarButton;
        private Button LogoutButton;
        private Button AnnouncmentsButton;
    }
}