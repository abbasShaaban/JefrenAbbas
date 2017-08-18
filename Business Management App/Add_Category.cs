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
    public partial class Add_Category : Form
    {
        ShopDataBaseDataContext database = new ShopDataBaseDataContext();
        BindingSource src = new BindingSource();
        public Add_Category()
        {
            InitializeComponent();
        }
        
        private void Add_Category_Load(object sender, EventArgs e)
        {
            
            src.DataSource = from C in database.Categories
                             select C;
            categoryDataGridView.DataSource = src;
            
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataBaseDataSet);

        }

        private void btn_Add_Category_Click(object sender, EventArgs e)
        {
            if (txb_Category_Name.Text.ToString() == "")
            {
                MessageBox.Show("No Category were entered");
                return;
            }
            Category new_Category = new Category();
            new_Category.Name = txb_Category_Name.Text.ToString();
            try
            {
                database.Categories.InsertOnSubmit(new_Category);
                database.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                MessageBox.Show("Category was inserted successfully");
                src.DataSource = from C in database.Categories
                                 select C;
                categoryDataGridView.DataSource = src;
            }
        }
    }
}
