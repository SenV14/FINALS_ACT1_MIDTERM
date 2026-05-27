using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALS_ACT1_MIDTERM
{
    public class Parking_Registration_Calculation
    {
        public string Plate_number { get; set; }
        public string Vehicle_model { get; set; }
        public int Hours_Parked { get; set; }
        //private readonly ParkingManager parkingManager = new ParkingManager();
        //private readonly Dictionary<string, Button> spotButtons = new Dictionary<string, Button>();
        //private Button? selectedSpot = null;

        //// Form Controls
        //private TextBox txtPlateNumber, txtHoursParked;
        //private ComboBox cmbVehicleType;
        //private ListBox lstParkedVehicles;

        public Parking_Registration_Calculation(string plate_number, string vehicle_model, int hoursParked)
        {
            Plate_number = plate_number;
            Vehicle_model = vehicle_model;
            Hours_Parked = hoursParked;
        }
}
    }
