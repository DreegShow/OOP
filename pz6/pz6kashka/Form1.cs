namespace pz6kashka
{
    record PhoneList(string FirstName, string LastName, long PhoneNumber, string Gmail);

    public partial class Form1 : Form
    {
        private List<PhoneList> phoneList = new List<PhoneList>()
        {
            new PhoneList("Max", "Levcheko", +380962424242, "dreegshow@gmail.com"),
            new PhoneList("Oexashko", "gArabiski", +9999999999, "puk@gmail.com")
        };

        public Form1()
        {
            InitializeComponent();
            UpdateList();
        }


        private void UpdateList()
        {
            var filteredContacts = phoneList.Where(phone => phone.LastName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                                                         phone.FirstName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase));
            var listItems = filteredContacts.Select(phone => new ListViewItem(new[] { phone.FirstName, phone.LastName, phone.PhoneNumber.ToString(), phone.Gmail }));
            PhoneList.Items.Clear();

            foreach (var phoneItem in listItems)
            {
                PhoneList.Items.Add(phoneItem);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            PhoneList newContact = new PhoneList(txtFirstName.Text, txtLastName.Text, Convert.ToInt64(txtPhoneNumber.Text), txtGmail.Text);
            phoneList.Add(newContact); 
            UpdateList(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (PhoneList.SelectedItems.Count > 0)
            {
                phoneList.RemoveAt(PhoneList.SelectedItems[0].Index);
                UpdateList(); 
            }
            else
            {
                MessageBox.Show("Виберіть контакт для видалення.");
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateList(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}

