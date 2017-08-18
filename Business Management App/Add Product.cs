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
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }
        ShopDataBaseDataContext database = new ShopDataBaseDataContext();

        private void btn_Add_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataBaseDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.shopDataBaseDataSet.Category);
            BindingSource src = new BindingSource();
            src.DataSource = from C in database.Categories
                             select C;
            categoryComboBox.DataSource = src;

        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataBaseDataSet);

        }
    }
}
