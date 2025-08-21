using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier1
{
    public partial class CustomerView : Form
    {
        private System.Windows.Forms.Timer timer;
        private string currentlyServing = "";
       
        public CustomerView()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000); // 1 second
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DisplayCurrentlyServing();
        }

        private void DisplayCurrentlyServing()
        {
            //  condition validation 
            if (CashierClass.CashierQueue.Count > 0)
            {
                string nextToServe = CashierClass.CashierQueue.Peek(); // Use Peek() 

                // Use Contains() 
                if (CashierClass.CashierQueue.Contains(nextToServe))
                {
                    lblNextCustomer.Text = nextToServe;
                    currentlyServing = nextToServe;
                }
            }
            else
            {
                lblNextCustomer.Text = "No Queue"; // displays at the beginning
                currentlyServing = "";
            }
        }
    }
}