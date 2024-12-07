using System.Collections.Generic;

public class DtcCodeTranslatorService
{
    private readonly Dictionary<string, string> _dtcCodes = new Dictionary<string, string>
{
    // Engine codes
    { "P0010", "*Engine* Camshaft Position Actuator Circuit (Bank 1)" },
    { "P0171", "*Engine* System Too Lean (Bank 1)" },
    { "P0300", "*Engine* Random/Multiple Cylinder Misfire Detected" },
    { "P0420", "*Engine* Catalyst System Efficiency Below Threshold (Bank 1)" },
    { "P0335", "*Engine* Crankshaft Position Sensor A Circuit" },
    { "P0455", "*Engine* Evaporative Emission Control System Leak Detected" },
    { "P0500", "*Engine* Vehicle Speed Sensor A" },
    { "P0100", "*Engine* Mass or Volume Air Flow Sensor Circuit" },
    { "P0123", "*Engine* Throttle/Pedal Position Sensor Circuit High Input" },
    { "P0130", "*Engine* Oxygen Sensor Circuit Malfunction (Bank 1, Sensor 1)" },

    // Transmission codes
    { "P0700", "*Transmission* Transmission Control System (MIL Request)" },
    { "P0740", "*Transmission* Torque Converter Clutch Circuit Malfunction" },
    { "P0841", "*Transmission* Transmission Fluid Pressure Sensor/Switch Circuit Range/Performance" },
    { "P0770", "*Transmission* Shift Solenoid E Malfunction" },
    { "P0847", "*Transmission* Transmission Fluid Pressure Sensor/Switch Circuit Low" },
    { "P0730", "*Transmission* Incorrect Gear Ratio" },
    { "P0720", "*Transmission* Output Speed Sensor Circuit Malfunction" },
    { "P0750", "*Transmission* Shift Solenoid A Malfunction" },
    { "P0760", "*Transmission* Shift Solenoid B Malfunction" },
    { "P0780", "*Transmission* Shift Malfunction" },

    // Chassis codes
    { "C0035", "*Chassis* Left Front Wheel Speed Sensor Circuit" },
    { "C0040", "*Chassis* Right Front Wheel Speed Sensor Circuit" },
    { "C0200", "*Chassis* Left Rear Wheel Speed Sensor Circuit" },
    { "C0220", "*Chassis* Right Rear Wheel Speed Sensor Circuit" },
    { "C1234", "*Chassis* Left Rear Suspension Position Sensor Circuit" },
    { "C1255", "*Chassis* Yaw Rate Sensor Circuit Malfunction" },
    { "C1441", "*Chassis* Brake Pedal Switch Circuit Malfunction" },
    { "C1460", "*Chassis* Steering Angle Sensor Malfunction" },
    { "C1700", "*Chassis* Left Front Suspension Position Sensor Malfunction" },
    { "C2150", "*Chassis* Vehicle Dynamic Control Malfunction" },

    // Body codes
    { "B0001", "*Body* Driver Airbag Circuit" },
    { "B0020", "*Body* Passenger Side Airbag Circuit" },
    { "B0090", "*Body* Driver Seatbelt Pretensioner Circuit" },
    { "B1201", "*Body* Body Control Module Power Supply" },
    { "B1402", "*Body* Passenger Door Switch Circuit Malfunction" },
    { "B2201", "*Body* Electric Power Steering Control Module" },
    { "B2630", "*Body* Left Rear Window Motor Circuit" },
    { "B2899", "*Body* Seat Adjustment Motor Circuit Malfunction" },
    { "B3200", "*Body* Interior Lighting Circuit Malfunction" },
    { "B3800", "*Body* Fuel Gauge Sender Circuit Malfunction" },
};

    public string TranslateDtcCode(string code)
    {
        if (_dtcCodes.ContainsKey(code))
        {
            return _dtcCodes[code];
        }
        else
        {
            return "Unknown DTC Code";
        }
    }
}
