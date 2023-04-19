using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManagerFormApp
{
    public partial class PhoneDetail : Form
    {

        public bool InsertOrUpadate { get; set; } // false : insert , true: update

        public Phone PhoneInfo { get; set; }
        public PhoneDetail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PhoneDetail_Load(object sender, EventArgs e)
        {
            var list = Actions.GetManufacturers();
            foreach (var item in list)
            {
                if (!comboBox1.Items.Contains(item.Id))
                {
                    comboBox1.Items.Add(item.Id);
                }
            }
            if (InsertOrUpadate)
            {
                txtId.Text = PhoneInfo.Id.ToString();
                txtName.Text = PhoneInfo.Name;
                txtDescription.Text = PhoneInfo.Description;
                dateTimePicker1.Value = PhoneInfo.ReleaseDate;
                numericUpDown1.Value = PhoneInfo.Quantity;
                comboBox1.Text = PhoneInfo.ManufacturerId.ToString();
                txtPrice.Text = PhoneInfo.Price.ToString();
                txtManufacturer.Text = GetManufacturerName(PhoneInfo.ManufacturerId);
            }
            else comboBox1.SelectedIndex = 0;
        }

        private string GetManufacturerName(int manufacturerId)
        {
            var list = Actions.GetManufacturers();
            var x = list.Where(l => l.Id == manufacturerId).FirstOrDefault();
            return x.Name;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertOrUpadate == true)
                {
                    var phone = new Phone
                    {
                        Id = int.Parse(txtId.Text),
                        Name = txtName.Text,
                        Description = txtDescription.Text,
                        Price = Decimal.Parse(txtPrice.Text.Trim()),
                        ManufacturerId = int.Parse(comboBox1.Text),
                        Quantity = int.Parse(numericUpDown1.Value.ToString()),
                        ReleaseDate = dateTimePicker1.Value,
                    };

                    int x = Actions.UpdatePhone(phone);
                    this.DialogResult = DialogResult.OK;
                }
                else if (InsertOrUpadate == false)
                {
                    var phone = new Phone
                    {
                        Name = txtName.Text,
                        Description = txtDescription.Text,
                        Price = Decimal.Parse(txtPrice.Text.Trim()),
                        ManufacturerId = int.Parse(comboBox1.Text),
                        Quantity = int.Parse(numericUpDown1.Value.ToString()),
                        ReleaseDate = dateTimePicker1.Value,
                    };
                    int x = Actions.InsertPhone(phone);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            int manufacturerId;
            if (int.TryParse(comboBox1.Text.Trim(), out manufacturerId))
            {
                txtManufacturer.Text = GetManufacturerName(manufacturerId);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
