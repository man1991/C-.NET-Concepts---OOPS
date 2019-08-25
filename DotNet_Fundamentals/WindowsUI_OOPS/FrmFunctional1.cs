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
    public partial class FrmOOP1 : Form
    {
        public FrmOOP1()
        {
            InitializeComponent();
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // FrmOOP1
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "FrmOOP1";
        //    this.Text = "Product Project";
        //    this.ResumeLayout(false);

        //}

        private void btnOtherUI_Click(object sender, EventArgs e)
        {
            FrmOOP2 obj = new FrmOOP2();
            obj.ShowDialog();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int intPerProductCost = Convert.ToInt16(txtPerProductCost.Text);
            int intQty = Convert.ToInt16(txtqty.Text);
            txtTotalCost.Text = Convert.ToString(CalculateCost(intPerProductCost, intQty));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int intPerProductCost = Convert.ToInt16(txtPerProductCost.Text);
            int intQty = Convert.ToInt16(txtqty.Text);
            int intDiscount = Convert.ToInt16(txtDiscount.Text);

            clsProduct objProduct = new clsProduct();
            clsProductWithDiscount objProductWithDiscount = new clsProductWithDiscount();


            if (txtDiscount.Text.Length != 0)
            {
                txtTotalCost.Text = Convert.ToString(objProductWithDiscount.getTotalCost(intQty, intPerProductCost, intDiscount));
            }
            else
            {
                txtTotalCost.Text = Convert.ToString(objProduct.getTotalCost(intQty, intPerProductCost));

            }
        }
        private int CalculateCost(int intPerProductCost, int intQty)
        {

            return (intPerProductCost * intQty);
        }
        private int CalculateCostInterest(int intPerProductCost, int intQty, int intDiscount)
        {

            return ((intPerProductCost * intQty)) - intDiscount;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPerProductCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDiscount_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPolyMorphism obj = new FrmPolyMorphism();
            obj.ShowDialog();
        }
    }
}
