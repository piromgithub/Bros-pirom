using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletricFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double price1 = 650, price2 = 750, price3 = 850, price4 = 950;
            double   Eletric ,  Total2,Total3,Total1;
            double Payment ;
            Eletric = double.Parse(txtbox.Text);
            Payment = double.Parse(txtbox.Text);
      



            if(Eletric > 50)
            {

                if (Eletric >= 50 && Eletric <= 100)
                {

                    Payment = (Eletric - 50) * price2 + (price1 * 50);
                }
                else if (Eletric > 100 && Eletric <=200) 

                {
                   
                    Payment = (Eletric - 100  )* price3 + (price2 * 50) + (price1 * 50);
                }
                else  
                {
                  

                    Payment = (Eletric - 200 ) * price4 + (price3 * 100) + (price2 * 50) + (price1 * 50);a
                }
               

            }
            else
            {
                Payment = Eletric * price1;
            }
            lblTotal.Text = Eletric + "";
            Paymnet.Text = Payment + ""; 













        }

        private void txtbox_TextChanged(object sender, EventArgs e)
       {

        }
    }
}
