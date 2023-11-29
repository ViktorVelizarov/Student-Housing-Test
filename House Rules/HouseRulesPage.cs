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
    }
}