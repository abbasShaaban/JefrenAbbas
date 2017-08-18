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
    public partial class Add_Purchase_Order : Form
    {
        public Add_Purchase_Order()
        {
            InitializeComponent();
        }

        private void Add_Purchase_Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataBaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.shopDataBaseDataSet.Product);

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataBaseDataSet);

        }
    }
}
