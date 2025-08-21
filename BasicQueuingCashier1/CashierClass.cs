using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueuingCashier1
{
    public class CashierClass
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue = new Queue<string>();

        public CashierClass()
        {
            x = 10000;
            
        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString(); 
            return CashierNumber;
        }

        // method that validates if the queue is empty
        public static bool IsQueueEmpty()
        {
            return CashierQueue == null || CashierQueue.Count == 0;
        }

    }
}
