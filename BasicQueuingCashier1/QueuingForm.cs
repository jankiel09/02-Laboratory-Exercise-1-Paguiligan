namespace BasicQueuingCashier1
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();

            // Show both forms
            CashierWindowQueue queue = new CashierWindowQueue();
            queue.Show();

            CustomerView customerView = new CustomerView();
            customerView.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            string newNumber = cashier.CashierGeneratedNumber("P - ");
            lblQueue.Text = newNumber;
            CashierClass.getNumberInQueue = newNumber;
            CashierClass.CashierQueue.Enqueue(newNumber);
        }
    }
}

