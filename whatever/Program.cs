using System;

namespace MotorVehicle1
{
    class Program
    {
        public class MotorVehicle
        {
            // The following statements define a property with a private field.
            private string _make;
            public string Make
            {
                get
                {
                    return _make;
                }
                set
                {
                    if (value != null)
                        _make = value;
                }
            }

            private string _model;
            public string Model
            {
                get
                {
                    return _model;
                }
                set
                {
                    if (value != null)
                        _model = value;
                }
            }

            private string _year;
            public string Year
            {
                get
                {
                    if (_year != "Default")
                    {
                        if (Int32.Parse(_year) >= 1930 && Int32.Parse(_year) <= 2020)
                        {
                            return _year;
                        }
                        else
                        {
                            return "2020";
                        }
                    }
                    else
                    {
                        return "2020";
                    }

                }
                set
                {
                    if (value != null)
                        _year = value;
                }
            }

            private bool _engineOn;
            public string Engine
            {
                get
                {
                    if (_engineOn)
                        return "On";
                    else
                        return "Off";
                }
            }

            public enum TransType
            {
                Automatic,
                Manual,
                DualClutch,
            }

            private TransType _transmission;

            public string Transmission
            {
                get
                {
                    if (_transmission == TransType.Automatic)
                    {
                        return "Automatic";
                    }
                    if (_transmission == TransType.DualClutch)
                    {
                        return "Hybrid";
                    }
                    if (_transmission == TransType.Manual)
                    {
                        return "Stick";
                    }
                    else
                    {
                    return "Automatic";
                    }
                }
                set
                {
                    if (value != "Default")
                    {
                        if (value == "Automatic")
                        {
                            _transmission = TransType.Automatic;
                        }
                        if(value == "Hybrid")
                        {
                            _transmission = TransType.DualClutch;
                        }
                        if (value == "Stick")
                        {
                            _transmission = TransType.Manual;
                        }
                    }
                    else
                    {
                        _transmission = TransType.Automatic;
                    }
                }
            }

            public MotorVehicle()
            {
                _model = "";
                _make = "";
                _year = "";
                _transmission = TransType.Automatic;
                _engineOn = false;
            }

            public bool Ignition(string action, string key)
            {
                bool rv = false;

                if (string.Compare(key, "1234") == 0)
                {
                    if (string.Compare(action, "On") == 0)
                    {
                        _engineOn = true;
                        rv = true;
                    }
                    else if (string.Compare(action, "Off") == 0)
                    {
                        _engineOn = false;
                        rv = true;
                    }
                }
                return rv;
            }
        }


        static void Main(string[] args)
        {
            const int NUM_VEHICLES = 5;
            MotorVehicle[] auto = new MotorVehicle[NUM_VEHICLES];

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                auto[i] = new MotorVehicle();
            }

            auto[0].Make = "Toyota";
            auto[0].Model = "Camry";
            auto[0].Year = "2012";
            auto[0].Transmission = "Default";

            auto[1].Make = "Honda";
            auto[1].Model = "Civic";
            auto[1].Year = "2015";
            auto[1].Transmission = "Default";

            auto[2].Make = "Mazda";
            auto[2].Model = "3";
            auto[2].Year = "2017";
            auto[2].Transmission = "Stick";

            auto[3].Make = "Subaru";
            auto[3].Model = "Legacy";
            auto[3].Year = "1967";
            auto[3].Transmission = "Hybrid";

            auto[4].Make = "Ford";
            auto[4].Model = "Mustang";
            auto[4].Year = "Default";
            auto[4].Transmission = "Stick";

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", auto[i].Year, auto[i].Make, auto[i].Model, auto[i].Engine, auto[i].Transmission);
            }
            auto[0].Ignition("On", "1234");
            auto[1].Ignition("On", "0000");
            auto[2].Ignition("On", "4321");
            auto[3].Ignition("On", "0000");
            auto[4].Ignition("On", "1234");

            Console.WriteLine("--------------");
            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2}", auto[i].Make, auto[i].Model, auto[i].Engine);
            }

            auto[0].Ignition("Off", "1234");
            auto[1].Ignition("Off", "0000");
            auto[2].Ignition("Off", "4321");
            auto[3].Ignition("Off", "0000");
            auto[4].Ignition("Off", "1234");

            Console.WriteLine("--------------");
            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2}", auto[i].Make, auto[i].Model, auto[i].Engine);
            }

            Console.ReadLine();
        }
    }

}