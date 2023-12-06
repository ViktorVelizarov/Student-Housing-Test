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
                RulesComboBox.Visible = true;
                DeleteRule.Visible = true;

                foreach (string rule in RulesListbox1.Items)
                {
                    RulesComboBox.Items.Add(rule);
                }

            }
            else
            {
                AddRuleTextbox.Visible = false;
                AddRule.Visible = false;
                RulesComboBox.Visible = false;
                DeleteRule.Visible = false;
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

            foreach (string rule in RulesListbox1.Items)
            {
                RulesComboBox.Items.Add(rule);
            }
        }

        private void DeleteRule_Click(object sender, EventArgs e)
        {
            int selectedRule = RulesComboBox.SelectedIndex;
            RulesListbox1.Items.RemoveAt(selectedRule);
            RulesComboBox.Items.RemoveAt(selectedRule);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}