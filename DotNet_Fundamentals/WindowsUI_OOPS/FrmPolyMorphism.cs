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
    public partial class FrmPolyMorphism : Form
    {
        public FrmPolyMorphism()
        {
            InitializeComponent();
        }
        private void FrmPolyMorphism_Load(object sender, EventArgs e)
        {

        }

        private void btnStaticPoly_Click(object sender, EventArgs e)
        {
            clsProduct objProduct = new clsProduct();
            int intPerProductCost = Convert.ToInt16(txtPerProductCost.Text);
            int intQty = Convert.ToInt16(txtqty.Text);
            int intDiscount = Convert.ToInt16(txtDiscount.Text);

            if (intDiscount == 0)
            {
                txtTotalCost.Text = objProduct.getTotalCost(intQty, intPerProductCost).ToString();
            }
            else
            {
                txtTotalCost.Text = objProduct.getTotalCost(intQty, intPerProductCost, intDiscount).ToString();
            }
        }

        private void btnCalculateByDynamic_Click(object sender, EventArgs e)
        {
            clsProduct objProduct;

            int intPerProductCost = Convert.ToInt16(txtPerProductCost.Text);
            int intQty = Convert.ToInt16(txtqty.Text);
            int intDiscount = Convert.ToInt16(txtDiscount.Text);

            if (intDiscount == 0)
            {
                objProduct = new clsProduct();
                MessageBox.Show(objProduct.getTotalCost(intQty, intPerProductCost, "INR").ToString());
            }
            else
            {
                objProduct = new clsProductWithDiscount();
                MessageBox.Show(objProduct.getTotalCost(intQty, intPerProductCost, "INR").ToString());
            }
        }
    }
}
