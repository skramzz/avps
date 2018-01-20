using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Math;

namespace AVPS.Persistence
{
    public class VehicleData
    {
        public long id { get; set; }

        public VehicleClass vehicleClass { get; set; }

        public string friendlyName { get; set; }

        public int modelHash { get; set; }

        public Vector3 position { get; set; }

        public float heading { get; set; }

        public VehicleColor primaryColor { get; set; }

        public VehicleColor secondaryColor { get; set; }

        public VehicleColor pearlescentColor { get; set; }

        public VehicleColor rimColor { get; set; }

        public VehicleColor trimColor { get; set; }

        public VehicleColor dashboardColor { get; set; }

        public Color? customPrimaryColor { get; set; }

        public Color? customSecondaryColor { get; set; }

        public float dirtLevel { get; set; }

        public int livery { get; set; }

        public VehicleLockStatus lockState { get; set; }

        public NumberPlateType plateType { get; set; }

        public NumberPlateMounting plateMounting { get; set; }

        public string plateNumer { get; set; }

        public VehicleRoofState roofState { get; set; }

        public Color tireSmokeColor { get; set; }

        public VehicleWheelType wheelType { get; set; }

        public VehicleWindowTint windowTint { get; set; }

        public bool[] hasNeons { get; set; }

        public Color neonColor { get; set; }

        public bool canTiresBurst { get; set; }

        public float[] health { get; set; }

        public float fuelLevel { get; set; }

        public bool[] bumpersOff { get; set; }

        public bool[] headlightsBroken { get; set; }

        public bool highbeamsOn { get; set; }

        public bool[] tireBurst { get; set; }

        public int customRoof { get; set; }

        public int[] modkits { get; set; }

        public bool[] extras { get; set; }
    }
}
