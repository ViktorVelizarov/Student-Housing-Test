namespace Agreements_Page
{
    partial class AgreementsPage
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
            ViewFolders = new Button();
            BackButton = new Button();
            AgreementTextBox = new RichTextBox();
            AgreementLabel = new Label();
            OfferToLabel = new Label();
            OfferToComboBox = new ComboBox();
            SubmitButton = new Button();
            button1 = new Button();
            AgreementValidUntilLabel = new Label();
            AgreementValidUntilDate = new DateTimePicker();
            SuspendLayout();
            // 
            // ViewFolders
            // 
            ViewFolders.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ViewFolders.Location = new Point(378, 597);
            ViewFolders.Name = "ViewFolders";
            ViewFolders.Size = new Size(228, 72);
            ViewFolders.TabIndex = 0;
            ViewFolders.Text = "View Offers";
            ViewFolders.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(12, 597);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(244, 72);
            BackButton.TabIndex = 1;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // AgreementTextBox
            // 
            AgreementTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AgreementTextBox.Location = new Point(285, 43);
            AgreementTextBox.Name = "AgreementTextBox";
            AgreementTextBox.Size = new Size(414, 429);
            AgreementTextBox.TabIndex = 2;
            AgreementTextBox.Text = "";
            // 
            // AgreementLabel
            // 
            AgreementLabel.AutoSize = true;
            AgreementLabel.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AgreementLabel.Location = new Point(362, 9);
            AgreementLabel.Name = "AgreementLabel";
            AgreementLabel.Size = new Size(244, 31);
            AgreementLabel.TabIndex = 3;
            AgreementLabel.Text = "Make An Agreement:";
            // 
            // OfferToLabel
            // 
            OfferToLabel.AutoSize = true;
            OfferToLabel.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            OfferToLabel.Location = new Point(506, 475);
            OfferToLabel.Name = "OfferToLabel";
            OfferToLabel.Size = new Size(60, 16);
            OfferToLabel.TabIndex = 4;
            OfferToLabel.Text = "Offer To:";
            OfferToLabel.Click += label1_Click;
            // 
            // OfferToComboBox
            // 
            OfferToComboBox.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OfferToComboBox.FormattingEnabled = true;
            OfferToComboBox.Items.AddRange(new object[] { "Tenant 1", "Tenant 2", "Tenant 3", "Tenant 4", "Tenant 5", "Landlord" });
            OfferToComboBox.Location = new Point(506, 494);
            OfferToComboBox.Name = "OfferToComboBox";
            OfferToComboBox.Size = new Size(193, 23);
            OfferToComboBox.TabIndex = 5;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitButton.Location = new Point(378, 523);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(228, 53);
            SubmitButton.TabIndex = 6;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(728, 597);
            button1.Name = "button1";
            button1.Size = new Size(244, 72);
            button1.TabIndex = 7;
            button1.Text = "All Agreements";
            button1.UseVisualStyleBackColor = true;
            // 
            // AgreementValidUntilLabel
            // 
            AgreementValidUntilLabel.AutoSize = true;
            AgreementValidUntilLabel.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AgreementValidUntilLabel.Location = new Point(285, 475);
            AgreementValidUntilLabel.Name = "AgreementValidUntilLabel";
            AgreementValidUntilLabel.Size = new Size(131, 16);
            AgreementValidUntilLabel.TabIndex = 8;
            AgreementValidUntilLabel.Text = "Agreement Valid Until:";
            // 
            // AgreementValidUntilDate
            // 
            AgreementValidUntilDate.Location = new Point(285, 494);
            AgreementValidUntilDate.Name = "AgreementValidUntilDate";
            AgreementValidUntilDate.Size = new Size(193, 23);
            AgreementValidUntilDate.TabIndex = 9;
            // 
            // AgreementsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 681);
            Controls.Add(AgreementValidUntilDate);
            Controls.Add(AgreementValidUntilLabel);
            Controls.Add(button1);
            Controls.Add(SubmitButton);
            Controls.Add(OfferToComboBox);
            Controls.Add(OfferToLabel);
            Controls.Add(AgreementLabel);
            Controls.Add(AgreementTextBox);
            Controls.Add(BackButton);
            Controls.Add(ViewFolders);
            Name = "AgreementsPage";
            Text = "Agreements Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ViewFolders;
        private Button BackButton;
        private RichTextBox AgreementTextBox;
        private Label AgreementLabel;
        private Label OfferToLabel;
        private ComboBox OfferToComboBox;
        private Button SubmitButton;
        private Button button1;
        private Label AgreementValidUntilLabel;
        private DateTimePicker AgreementValidUntilDate;
    }
}