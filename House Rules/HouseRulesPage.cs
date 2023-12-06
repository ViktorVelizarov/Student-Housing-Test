namespace A_2._0
{
    public partial class Form1 : Form
    {
        private bool admin = true;
        public Form1()
        {
            InitializeComponent();
            if (admin)
            {
                AddRuleTextbox.Visible = true;
                AddRule.Visible = true;
<<<<<<< HEAD
                RulesComboBox.Visible = true;
                DeleteRule.Visible = true;

                foreach (string rule in RulesListbox1.Items)
                {
                    RulesComboBox.Items.Add(rule);
                }

=======
>>>>>>> parent of 944b912 (add a DeleteRule button which only shows up for Admins)
            }
            else
            {
                AddRuleTextbox.Visible = false;
                AddRule.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddRule_Click(object sender, EventArgs e)
        {
            string newRule = AddRuleTextbox.Text;
            RulesListbox1.Items.Add(newRule);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}