namespace Troco
{
    partial class frmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnTroco = new System.Windows.Forms.Button();
            this.txtVlrPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVlrCompra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnTroco);
            this.groupBox1.Controls.Add(this.txtVlrPago);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVlrCompra);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 211);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retorna Troco";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(136, 124);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnTroco
            // 
            this.btnTroco.Location = new System.Drawing.Point(217, 124);
            this.btnTroco.Name = "btnTroco";
            this.btnTroco.Size = new System.Drawing.Size(75, 23);
            this.btnTroco.TabIndex = 9;
            this.btnTroco.Text = "Troco";
            this.btnTroco.UseVisualStyleBackColor = true;
            this.btnTroco.Click += new System.EventHandler(this.btnTroco_Click);
            // 
            // txtVlrPago
            // 
            this.txtVlrPago.Location = new System.Drawing.Point(141, 83);
            this.txtVlrPago.Name = "txtVlrPago";
            this.txtVlrPago.Size = new System.Drawing.Size(161, 20);
            this.txtVlrPago.TabIndex = 8;
            //this.txtVlrPago.TextChanged += new System.EventHandler(this.txtVlrPago_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor total compra ";
            // 
            // txtVlrCompra
            // 
            this.txtVlrCompra.Location = new System.Drawing.Point(141, 56);
            this.txtVlrCompra.Name = "txtVlrCompra";
            this.txtVlrCompra.Size = new System.Drawing.Size(161, 20);
            this.txtVlrCompra.TabIndex = 5;
            //this.txtVlrCompra.TextChanged += new System.EventHandler(this.txtVlrCompra_TextChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 235);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipal";
            this.Text = "Retorna Troco";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnTroco;
        private System.Windows.Forms.TextBox txtVlrPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVlrCompra;
    }
}

