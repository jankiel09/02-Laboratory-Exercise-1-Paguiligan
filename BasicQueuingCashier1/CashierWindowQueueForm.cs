using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier1
{
    public partial class CashierWindowQueue : Form
    {
        private System.Windows.Forms.Timer timer;
        public CashierWindowQueue()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);// 1 sec 
            timer.Tick += new EventHandler(timer1_tick_Click);
            timer.Start();
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();

            foreach (object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
       
        private void btnNext_Click(object sender, EventArgs e)
        {
            CashierClass.CashierQueue.Dequeue();
            DisplayCashierQueue(CashierClass.CashierQueue);

        }

        private void timer1_tick_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
