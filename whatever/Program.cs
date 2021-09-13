﻿using System;

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
                    return _year;
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

            private bool _legacy;
            public string Legacy
            {
                get
                {
                    if (_legacy)
                        return "Yes";
                    else
                        return "No";
                }
            }

            public MotorVehicle()
            {
                _model = "";
                _make = "";
                _year = "";
                _engineOn = false;
                _legacy = false;
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
            const int NUM_VEHICLES = 4;
            MotorVehicle[] auto = new MotorVehicle[NUM_VEHICLES];

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                auto[i] = new MotorVehicle();
            }

            auto[0].Make = "Toyota";
            auto[0].Model = "Camry";
            auto[0].Year = "2012";

            auto[1].Make = "Honda";
            auto[1].Model = "Civic";
            auto[1].Year = "2015";

            auto[2].Make = "Mazda";
            auto[2].Model = "3";
            auto[2].Year = "2017";

            auto[3].Make = "Subaru";
            auto[3].Model = "Legacy";
            auto[3].Year = "2017";

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", auto[i].Year, auto[i].Make, auto[i].Model, auto[i].Engine);
            }
            auto[0].Ignition("On", "1234");
            auto[1].Ignition("On", "0000");
            auto[2].Ignition("On", "4321");
            auto[1].Ignition("On", "0000");

            Console.WriteLine("--------------");
            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2}", auto[i].Make, auto[i].Model, auto[i].Engine);
            }

            auto[0].Ignition("Off", "1234");
            auto[1].Ignition("Off", "0000");
            auto[2].Ignition("Off", "4321");
            auto[1].Ignition("Off", "0000");

            Console.WriteLine("--------------");
            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2}", auto[i].Make, auto[i].Model, auto[i].Engine);
            }

            Console.ReadLine();
        }
    }

}