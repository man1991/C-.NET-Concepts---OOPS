using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Product;
namespace WindowsUI_OOPS
{
    public partial class FrmOOP2 : Form
    {
        public FrmOOP2()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            int intProductQty = 0;
            int intProductPerCost = 0;
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
            {
                intProductQty = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[2].Value != null)
            {
                intProductPerCost = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            }

            // Functional
            //dataGridView1.Rows[e.RowIndex].Cells[3].Value = Convert.ToString(CalculateCost(intProductPerCost,intProductQty));

            // Object oriented
            clsProduct objProduct = new clsProduct();

            clsProductWithDiscount objProduct1 = new clsProductWithDiscount();
            objProduct1.getTotalCost(20, 3);
            objProduct1.getTotalCost(20, 3, 10);



            dataGridView1.Rows[e.RowIndex].Cells[3].Value = Convert.ToString(objProduct.getTotalCost(intProductPerCost, intProductQty));
            int intDiscount = Convert.ToInt16(txtDiscount.Text);
            dataGridView1.Rows[e.RowIndex].Cells[4].Value = Convert.ToString(objProduct1.getTotalCost(intProductPerCost, intProductQty, intDiscount));
        }
        private int CalculateCost(int intPerProductCost, int intQty)
        {
            return (intPerProductCost * intQty);
        }
        private int CalculateCostByDiscount(int intPerProductCost, int intQty, int intDiscount)
        {
            return ((CalculateCost(intPerProductCost, intQty) - intDiscount));
        }
        private void FrmOOP2_Load(object sender, EventArgs e)
        {
        }
    }
}
