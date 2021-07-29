using System;
using System.Collections.Generic;
using System.Text;

namespace LTI_Assignment_1
{
    class bill
    {
        internal float electricityBill(int units)
        {
            float totalAmount;
            int remainingUnit;
            float Amount;
            if(units<0)
            {
                
                return -1;
            }
            else if(units <=100)
            {
                totalAmount = (float)(units * 1.2);
                return totalAmount;
            }
            else if(units<=300)
            {
                remainingUnit = (units - 100);
                Amount = (remainingUnit * 2);
                totalAmount = (float)(100 * 1.2) + Amount;
                return totalAmount;
            }
            else 
            {
                remainingUnit = (units - 300);
                Amount = (remainingUnit * 3);
                totalAmount = (float)((100 * 1.2) + (200 * 2) + (Amount * 3));
                return totalAmount;
            }
            
        }
    }


    class question1
    {

        static void Main()
        {
            int units;
            float totalAmount;
            bill bill = new bill();
            Console.WriteLine("Enter the number of units used by the customer: ");
            units = Convert.ToInt32(Console.ReadLine());
            totalAmount=bill.electricityBill(units);
            Console.WriteLine("The Amount customer has to pay is:  {0}", totalAmount);
        }
    }
}
