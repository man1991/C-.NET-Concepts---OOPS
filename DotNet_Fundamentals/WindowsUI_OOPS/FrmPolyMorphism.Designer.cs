namespace WindowsUI_OOPS
{
    partial class FrmPolyMorphism
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStaticPoly = new System.Windows.Forms.Button();
            this.txtPerProductCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnCalculateByDynamic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(107, 147);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 26;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(20, 150);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 25;
            this.lblDiscount.Text = "Discount";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(107, 112);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total Cost";
            // 
            // btnStaticPoly
            // 
            this.btnStaticPoly.Location = new System.Drawing.Point(15, 186);
            this.btnStaticPoly.Name = "btnStaticPoly";
            this.btnStaticPoly.Size = new System.Drawing.Size(171, 23);
            this.btnStaticPoly.TabIndex = 20;
            this.btnStaticPoly.Text = "Calculate By Static Polymorphism";
            this.btnStaticPoly.UseVisualStyleBackColor = true;
            this.btnStaticPoly.Click += new System.EventHandler(this.btnStaticPoly_Click);
            // 
            // txtPerProductCost
            // 
            this.txtPerProductCost.Location = new System.Drawing.Point(107, 75);
            this.txtPerProductCost.Name = "txtPerProductCost";
            this.txtPerProductCost.Size = new System.Drawing.Size(100, 20);
            this.txtPerProductCost.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Per product Cost";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(107, 40);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(100, 20);
            this.txtqty.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(107, 6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 14;
            // 
            // btnCalculateByDynamic
            // 
            this.btnCalculateByDynamic.Location = new System.Drawing.Point(192, 186);
            this.btnCalculateByDynamic.Name = "btnCalculateByDynamic";
            this.btnCalculateByDynamic.Size = new System.Drawing.Size(147, 23);
            this.btnCalculateByDynamic.TabIndex = 27;
            this.btnCalculateByDynamic.Text = "Calculate By Dynamic Polymorphism";
            this.btnCalculateByDynamic.UseVisualStyleBackColor = true;
            this.btnCalculateByDynamic.Click += new System.EventHandler(this.btnCalculateByDynamic_Click);
            // 
            // FrmPolyMorphism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 221);
            this.Controls.Add(this.btnCalculateByDynamic);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStaticPoly);
            this.Controls.Add(this.txtPerProductCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductName);
            this.Name = "FrmPolyMorphism";
            this.Text = "FrmPolyMorphism";
            this.Load += new System.EventHandler(this.FrmPolyMorphism_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStaticPoly;
        private System.Windows.Forms.TextBox txtPerProductCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnCalculateByDynamic;
    }
}