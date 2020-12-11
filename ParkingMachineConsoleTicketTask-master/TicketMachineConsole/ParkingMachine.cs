using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsoleTicket
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

        
        private int currentTotal;

        // Cost to park.
        private int costPerHour;

        public ParkingMachine(int costPerHour)
        {
            total = 0;
            currentTotal = 0;
            this.costPerHour = costPerHour;
        }

    }
}
