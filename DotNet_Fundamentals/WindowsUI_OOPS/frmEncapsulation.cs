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
    public partial class frmEncapsulation : Form
    {
        clsProductEncapsulation objProductEncapsulation = new clsProductEncapsulation();
        public frmEncapsulation()
        {
            InitializeComponent();
        }
        private void btnEncapsulation_Click(object sender, EventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                objProductEncapsulation.Qty = Convert.ToInt16(txtqty.Text);
                CalculateCost();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtPerProductCost_TextChanged(object sender, EventArgs e)
        {
            try
            {

                objProductEncapsulation.PerProductCost = Convert.ToInt16(txtPerProductCost.Text);
                CalculateCost();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void CalculateCost()
        {
            txtTotalCost.Text = objProductEncapsulation.TotalCost.ToString();

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEncapsulation_Load(object sender, EventArgs e)
        {

        }
    }
}
