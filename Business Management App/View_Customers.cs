using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Management_App
{
    public partial class View_Customers : Form
    {
        public View_Customers()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataBaseDataSet);

        }
        ShopDataBaseDataContext database = new ShopDataBaseDataContext();
        private void View_Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataBaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.shopDataBaseDataSet.Customer);
            comboBox1.Items.Insert(0, "By First Name");
            comboBox1.Items.Add("By Last Name");
            comboBox1.Items.Add("By Phone Number");
            comboBox1.Items.Add("By Address");
            comboBox1.SelectedIndex = 0;

            BindingSource src = new BindingSource();
           /* src.DataSource = from A in database.Customers
                             select A;
            customerDataGridView.DataSource = src;*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                comboBox1.Text = "By First Name";
            }
            else
            {
                comboBox1.Text = comboBox1.SelectedText;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
