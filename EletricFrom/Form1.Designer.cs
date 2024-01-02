namespace EletricFrom
{
    partial class Form1
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
            this.lblEletric = new System.Windows.Forms.Label();
            this.lblTotalpayment = new System.Windows.Forms.Label();
            this.lblTotalEletric = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Paymnet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEletric
            // 
            this.lblEletric.AutoSize = true;
            this.lblEletric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEletric.Location = new System.Drawing.Point(24, 25);
            this.lblEletric.Name = "lblEletric";
            this.lblEletric.Size = new System.Drawing.Size(69, 24);
            this.lblEletric.TabIndex = 0;
            this.lblEletric.Text = "Eletric";
            // 
            // lblTotalpayment
            // 
            this.lblTotalpayment.AutoSize = true;
            this.lblTotalpayment.Location = new System.Drawing.Point(24, 230);
            this.lblTotalpayment.Name = "lblTotalpayment";
            this.lblTotalpayment.Size = new System.Drawing.Size(80, 13);
            this.lblTotalpayment.TabIndex = 1;
            this.lblTotalpayment.Text = "Total_paymnet:";
            // 
            // lblTotalEletric
            // 
            this.lblTotalEletric.AutoSize = true;
            this.lblTotalEletric.Location = new System.Drawing.Point(38, 189);
            this.lblTotalEletric.Name = "lblTotalEletric";
            this.lblTotalEletric.Size = new System.Drawing.Size(69, 13);
            this.lblTotalEletric.TabIndex = 2;
            this.lblTotalEletric.Text = "Total_Eletric:";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(166, 105);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "calcluate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(128, 29);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(206, 20);
            this.txtbox.TabIndex = 4;
            this.txtbox.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(141, 189);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "...";
            // 
            // Paymnet
            // 
            this.Paymnet.AutoSize = true;
            this.Paymnet.Location = new System.Drawing.Point(141, 230);
            this.Paymnet.Name = "Paymnet";
            this.Paymnet.Size = new System.Drawing.Size(16, 13);
            this.Paymnet.TabIndex = 6;
            this.Paymnet.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Paymnet);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblTotalEletric);
            this.Controls.Add(this.lblTotalpayment);
            this.Controls.Add(this.lblEletric);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEletric;
        private System.Windows.Forms.Label lblTotalpayment;
        private System.Windows.Forms.Label lblTotalEletric;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label Paymnet;
    }
}

