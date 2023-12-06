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
            HouseRulesButton.Location = new Point(430, 329);
            HouseRulesButton.Margin = new Padding(3, 4, 3, 4);
            HouseRulesButton.Name = "HouseRulesButton";
            HouseRulesButton.Size = new Size(286, 113);
            HouseRulesButton.TabIndex = 0;
            HouseRulesButton.Text = "House Rules";
            HouseRulesButton.UseVisualStyleBackColor = true;
            HouseRulesButton.Click += HouseRulesButton_Click;
            // 
            // AgreementsButton
            // 
            AgreementsButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AgreementsButton.Location = new Point(430, 180);
            AgreementsButton.Margin = new Padding(3, 4, 3, 4);
            AgreementsButton.Name = "AgreementsButton";
            AgreementsButton.Size = new Size(286, 113);
            AgreementsButton.TabIndex = 1;
            AgreementsButton.Text = "Agreements";
            AgreementsButton.UseVisualStyleBackColor = true;
            AgreementsButton.Click += button2_Click;
            // 
            // GroceriesButton
            // 
            GroceriesButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            GroceriesButton.Location = new Point(430, 479);
            GroceriesButton.Margin = new Padding(3, 4, 3, 4);
            GroceriesButton.Name = "GroceriesButton";
            GroceriesButton.Size = new Size(286, 113);
            GroceriesButton.TabIndex = 2;
            GroceriesButton.Text = "Grocery Payments";
            GroceriesButton.UseVisualStyleBackColor = true;
            GroceriesButton.Click += GroceriesButton_Click;
            // 
            // TaskCalendarButton
            // 
            TaskCalendarButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TaskCalendarButton.Location = new Point(430, 31);
            TaskCalendarButton.Margin = new Padding(3, 4, 3, 4);
            TaskCalendarButton.Name = "TaskCalendarButton";
            TaskCalendarButton.Size = new Size(286, 113);
            TaskCalendarButton.TabIndex = 3;
            TaskCalendarButton.Text = "Task Calendar";
            TaskCalendarButton.UseVisualStyleBackColor = true;
            TaskCalendarButton.Click += TaskCalendarButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutButton.Location = new Point(14, 779);
            LogoutButton.Margin = new Padding(3, 4, 3, 4);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(286, 113);
            LogoutButton.TabIndex = 4;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            // 
            // AnnouncmentsButton
            // 
            AnnouncmentsButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AnnouncmentsButton.Location = new Point(430, 625);
            AnnouncmentsButton.Margin = new Padding(3, 4, 3, 4);
            AnnouncmentsButton.Name = "AnnouncmentsButton";
            AnnouncmentsButton.Size = new Size(286, 113);
            AnnouncmentsButton.TabIndex = 6;
            AnnouncmentsButton.Text = "Announcements";
            AnnouncmentsButton.UseVisualStyleBackColor = true;
            AnnouncmentsButton.Click += AnnouncmentsButton_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 908);
            Controls.Add(AnnouncmentsButton);
            Controls.Add(LogoutButton);
            Controls.Add(TaskCalendarButton);
            Controls.Add(GroceriesButton);
            Controls.Add(AgreementsButton);
            Controls.Add(HouseRulesButton);
            Margin = new Padding(3, 4, 3, 4);
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