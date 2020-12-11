using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsole
{
    /// <summary>
    /// An object of the class ParkingMachine represents a parking machine.
    /// 
    /// Insert money first. 
    /// 
    /// Then buy a ticket or select cancel to refund.
    /// </summary>
    public class ParkingMachine
    {
        // There is two places to save money.
        // Total in the machine, from all finnished purchases.
        private int total;

        // Total for the current customer.
        private int currentTotal;

        // Cost to park.
        private int costPerHour;

        public ParkingMachine()
        {
            total = 0;
            currentTotal = 0;
            costPerHour = 20;
        }

        public int CurrentTotal

        {

            get

            {

                return currentTotal;

            }

        }



        public int Total

        {

            get

            {

                return total;

            }

        }

        public void InsertMoney(int amount)

        {

            if (amount > 0)

            {

                currentTotal = amount + currentTotal;

            }

        }



        public int Cancel()

        {

            int refund = currentTotal;

            currentTotal = 0;

            return refund;

        }



        public string BuyTicket()

        {

            int dagar;

            int timmar;

            int minuter;





            minuter = 60 * currentTotal / costPerHour;



            timmar = minuter / 60;

            minuter = minuter % 60;



            dagar = timmar / 24;

            timmar = timmar % 24;



            total = Total + currentTotal;

            currentTotal = 0;







            return TimeToTicketText(dagar, timmar, minuter);

        }



        private string TimeToTicketText(int days, int hours, int minutes)
        {
            return "Parking ticket valid for:" + Environment.NewLine +
                days + " days" + Environment.NewLine +
                hours + " hours" + Environment.NewLine +
                minutes + " minutes";
        }







    }
}
