using System;

namespace SmartParkingSystem
{
    public class Parking
    {
        public string PlateNumber { get; set; }
        public string VehicleType { get; set; }
        public int HoursParked { get; set; }
        public string SlotNumber { get; set; }

        private double ratePerHour;
        private const double serviceCharge = 20;

        public Parking(string plate, string type, int hours, string slot)
        {
            PlateNumber = plate;
            VehicleType = type;
            HoursParked = hours;
            SlotNumber = slot;

            SetRate();
        }

        private void SetRate()
        {
            if (VehicleType == "Car") ratePerHour = 50;
            else if (VehicleType == "Motorcycle") ratePerHour = 30;
            else if (VehicleType == "Van") ratePerHour = 70;
        }

        public double GetOvertimeFee()
        {
            if (HoursParked > 8)
                return (HoursParked - 8) * 20;

            return 0;
        }

        public double ComputeFee()
        {
            return (HoursParked * ratePerHour) + GetOvertimeFee() + serviceCharge;
        }
    }
}