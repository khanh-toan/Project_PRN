using System.Globalization;

namespace PhoneManagerFormApp
{
    public partial class Form1 : Form
    {
        public int RowData { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Phone> phones = Actions.GetAllPhones();
            foreach (Phone item in phones)
            {
                dataGridView1.Rows.Add(item.Id, item.Name, item.ManufacturerName,
                    item.ReleaseDate.ToString(("MM-dd-yyyy")), item.Country, item.Quantity, item.Price, item.Description);
            }
            var list = Actions.GetManufacturers();
            var l = list.Select(x => x.Name).Distinct().ToList();
            cboManufacturer.Items.Clear();
            cboManufacturer.DisplayMember = "string";
            cboManufacturer.ValueMember = "string";
            cboManufacturer.Items.Add("All manufacturers");
            foreach (var item in l)
            {
                cboManufacturer.Items.Add(item);
            }

            var l1 = list.Select(x => x.Country).Distinct().ToList();
            cboCountry.Items.Clear();
            cboCountry.DisplayMember = "string";
            cboCountry.ValueMember = "string";
            cboCountry.Items.Add("All countries");
            foreach (var item in l1)
            {
                cboCountry.Items.Add(item);
            }

            cboManufacturer.SelectedIndex = 0;
            cboCountry.SelectedIndex = 0;
            radioButton4.Checked = true;
            radioButton1.Checked = true;
        }

        public void Load_Data()
        {
            dataGridView1.Rows.Clear();
            List<Phone> phones = Actions.GetAllPhones();
            foreach (Phone item in phones)
            {
                dataGridView1.Rows.Add(item.Id, item.Name, item.ManufacturerName,
                    item.ReleaseDate.ToString(("MM-dd-yyyy")), item.Country, item.Quantity, item.Price, item.Description);
            }
        }

        public void Load_Filter(string x, string y, string z, int a, int b)
        {
            dataGridView1.Rows.Clear();
            List<Phone> phones = Actions.GetPhoneFilter(x, y, z, a, b);
            foreach (Phone item in phones)
            {
                dataGridView1.Rows.Add(item.Id, item.Name, item.ManufacturerName,
                    item.ReleaseDate.ToString(("MM-dd-yyyy")), item.Country, item.Quantity, item.Price, item.Description);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var id = dataGridView1.Rows[row].Cells[0].Value;
            var name = dataGridView1.Rows[row].Cells[1].Value;

            var manufacturer = dataGridView1.Rows[row].Cells[2].Value;
            var releaseYear = dataGridView1.Rows[row].Cells[3].Value;
            var country = dataGridView1.Rows[row].Cells[4].Value;
            var quantity = dataGridView1.Rows[row].Cells[5].Value;
            var price = dataGridView1.Rows[row].Cells[6].Value;
            var description = dataGridView1.Rows[row].Cells[7].Value;

            txtId.Text = id.ToString();
            txtCountry.Text = country.ToString();
            txtName.Text = name.ToString();
            txtManufacturer.Text = manufacturer.ToString();
            txtDescription.Text = description.ToString();
            txtQuantity.Text = quantity.ToString();
            txtPrice.Text = price.ToString();
            dateTimePicker1.Value = DateTime.ParseExact(releaseYear.ToString(),
                    "MM-dd-yyyy", CultureInfo.InvariantCulture);
            //dateTimePicker1.Value = DateTime.Parse(releaseYear.ToString());

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PhoneDetail p = new PhoneDetail
            {
                Text = "Update Phone",
                InsertOrUpadate = true,
                PhoneInfo = Actions.GetPhone(int.Parse(txtId.Text))
            };
            if (p.ShowDialog() == DialogResult.OK)
            {
                Load_Data();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhoneDetail p = new PhoneDetail
            {
                Text = "Add Phone",
                InsertOrUpadate = false,
                PhoneInfo = new Phone()
            };
            if (p.ShowDialog() == DialogResult.OK)
            {
                Load_Data();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want delete record?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int x = int.Parse(txtId.Text.Trim());
                    Actions.DeletePhone(x);
                    Load_Data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete a phone");
                }
            }
        }

        private void ChangeFilterReloadData()
        {
            string name = txtFilterName.Text.Trim();
            string man = cboManufacturer.Text.Trim();
            string count = cboCountry.Text.Trim();

            int price = 0;
            if (radioButton2.Checked == true) price = 1;
            else if (radioButton3.Checked == true) price = 2;

            int date = 0;
            if (radioButton5.Checked == true) date = 1;
            else if (radioButton6.Checked == true) date = 2;
            Load_Filter(name, man, count, price, date);


        }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            ChangeFilterReloadData();
        }

        private void cboManufacturer_TextChanged(object sender, EventArgs e)
        {
            ChangeFilterReloadData();
        }

        private void cboCountry_TextChanged(object sender, EventArgs e)
        {
            ChangeFilterReloadData();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFilterReloadData();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFilterReloadData();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFilterReloadData();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFilterReloadData();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFilterReloadData();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFilterReloadData();
        }

    }
}