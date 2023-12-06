namespace A_2._0
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
            RulesListbox1 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            AddRule = new Button();
            AddRuleTextbox = new TextBox();
            DeleteRule = new Button();
            RulesComboBox = new ComboBox();
            SuspendLayout();
            // 
            // RulesListbox1
            // 
            RulesListbox1.FormattingEnabled = true;
            RulesListbox1.ItemHeight = 20;
            RulesListbox1.Items.AddRange(new object[] { "Ayyyy", "Rule Number one - There are rules!", "rule no 2. - we must follow them!", "3 Structure", "CONSISTENCY IS THE FOURTH RULLE" });
            RulesListbox1.Location = new Point(373, 185);
            RulesListbox1.Margin = new Padding(3, 4, 3, 4);
            RulesListbox1.Name = "RulesListbox1";
            RulesListbox1.Size = new Size(350, 464);
            RulesListbox1.TabIndex = 0;
            RulesListbox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(14, 837);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(150, 55);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(448, 68);
            label1.Name = "label1";
            label1.Size = new Size(190, 39);
            label1.TabIndex = 3;
            label1.Text = "House Rules";
            label1.Click += label1_Click;
            // 
            // AddRule
            // 
            AddRule.Location = new Point(845, 230);
            AddRule.Name = "AddRule";
            AddRule.Size = new Size(250, 48);
            AddRule.TabIndex = 4;
            AddRule.Text = "Add Rule";
            AddRule.UseVisualStyleBackColor = true;
            AddRule.Click += AddRule_Click;
            // 
            // AddRuleTextbox
            // 
            AddRuleTextbox.Location = new Point(845, 185);
            AddRuleTextbox.Name = "AddRuleTextbox";
            AddRuleTextbox.Size = new Size(250, 27);
            AddRuleTextbox.TabIndex = 5;
            // 
            // DeleteRule
            // 
            DeleteRule.Location = new Point(845, 394);
            DeleteRule.Name = "DeleteRule";
            DeleteRule.Size = new Size(250, 48);
            DeleteRule.TabIndex = 6;
            DeleteRule.Text = "Delete Rule";
            DeleteRule.UseVisualStyleBackColor = true;
            DeleteRule.Click += DeleteRule_Click;
            // 
            // RulesComboBox
            // 
            RulesComboBox.FormattingEnabled = true;
            RulesComboBox.Location = new Point(845, 350);
            RulesComboBox.Name = "RulesComboBox";
            RulesComboBox.Size = new Size(250, 28);
            RulesComboBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 908);
            Controls.Add(RulesComboBox);
            Controls.Add(DeleteRule);
            Controls.Add(AddRuleTextbox);
            Controls.Add(AddRule);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(RulesListbox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "A.2.0 House Rules Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox RulesListbox1;
        private Button button1;
        private Label label1;
        private Button AddRule;
        private TextBox AddRuleTextbox;
        private Button DeleteRule;
        private ComboBox RulesComboBox;
    }
}