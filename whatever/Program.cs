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

            private int _people;
            public int People
            {
                get
                {
                    if (_people > 0 && _people <= 6)
                    {
                        return _people;
                    }
                    else
                    {
                        return 1;
                    }
                }
                set
                {
                    if (value != 0)
                    {
                        _people = value;
                    }
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

            public bool Ignition(int backdoor, string action, string key)
            {

                bool rv = false;

                if (backdoor == 1)
                {
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
                }
                else
                {
                    rv = true;
                }
                return rv;
            }


        }

        public class PickUpTruck : MotorVehicle
        {
            new private enum TransType
            {
                Automatic,
                Manual,
            }

            private TransType _transmission;
            new private string Transmission
                {
                get
                {
                    if (_transmission == TransType.Automatic)
                    {
                        return "Automatic";
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

            private string _cab;

            public string Cab
            {
                get
                {
                    if (_cab == "Regular")
                    {
                        return "Regular";
                    }
                    if (_cab == "Extended")
                    {
                        return "Extended";
                    }
                    if (_cab == "Crew")
                    {
                        return "Crew";
                    }
                    else
                    {
                        return "null";
                    }
                }
                set
                {
                    if (string.Compare(value, "Regular") == 0)
                    {
                        _cab = "Regular";
                    }
                    else if (string.Compare(value, "Extended") == 0)
                    {
                        _cab = "Extended";
                    }
                    else if (string.Compare(value, "Crew") == 0)
                    {
                        _cab = "Crew";
                    }
                    else
                    {
                        _cab = "null";
                    }
                }

            }


            private int _people;

            new private int People
            {
                get
                {
                    if (_people >= 2 && _people <= 6)
                    {
                        return _people;
                    }
                    else
                    {
                        return 1;
                    }
                }
                set
                {
                    if (value != 0)
                    {
                        _people = value;
                    }
                }
            }
        }



        public class Car : MotorVehicle
        {
            private string _type;

            public string Type
            {
                get
                {
                    if (_type == "Sedan")
                    {
                        return "Sedan";
                    }
                    if (_type == "Coupe")
                    {
                        return "Coupe";
                    }
                    if (_type == "Hatchback")
                    {
                        return "Hatchback";
                    }
                    else
                    {
                        return "null";
                    }
                }
                set
                {
                    if (string.Compare(value, "Sedan") == 0)
                    {
                        _type = "Sedan";
                    }
                    else if (string.Compare(value, "Coupe") == 0)
                    {
                        _type = "Coupe";
                    }
                    else if (string.Compare(value, "Hatchback") == 0)
                    {
                        _type = "Hatchback";
                    }
                    else
                    {
                        _type = "null";
                    }

                }

            }

            private int _people;

            new private int People
            {
                get
                {
                    if (_people >= 2 && _people <= 6)
                    {
                        return _people;
                    }
                    else
                    {
                        return 1;
                    }
                }
                set
                {
                    if (value != 0)
                    {
                        _people = value;
                    }
                }
            }
        }

        public class MotorCycle : MotorVehicle
        {
            public int _wheels;

            public int Wheels
            {
                get
                {
                    if (_wheels == 2)
                    {
                        return _wheels;
                    }
                    if (_wheels == 3)
                    {
                        return _wheels;
                    }
                    if (_wheels == 4)
                    {
                        return _wheels;
                    }
                    else
                    {
                        return 0;
                    }
                }
                set
                {
                    if (value == 2)
                    {
                        _wheels = 2;
                    }
                    else if (value == 3)
                    {
                        _wheels = 3;
                    }
                    else if (value == 4)
                    {
                        _wheels = 4;
                    }
                    else
                    {
                        _wheels = 0;
                    }
                }


            }

            private int _people;

            new private int People
            {
                get
                {
                    if (_people == 1 || _people == 2)
                    {
                        return _people;
                    }
                    else
                    {
                        return 1;
                    }
                }
                set
                {
                    if (value != 0)
                    {
                        _people = value;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            const int NUM_VEHICLES = 5;
            Car[] car = new Car[NUM_VEHICLES];

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                car[i] = new Car();
            }

            car[0].Make = "Toyota";
            car[0].Model = "Camry";
            car[0].Year = "2012";
            car[0].Transmission = "Default";
            car[0].Type = "Sedan";
            car[0].People = 4;

            car[1].Make = "Honda";
            car[1].Model = "Civic";
            car[1].Year = "2015";
            car[1].Transmission = "Default";
            car[1].Type = "Coupe";
            car[1].People = 3;

            car[2].Make = "Mazda";
            car[2].Model = "3";
            car[2].Year = "2017";
            car[2].Transmission = "Stick";
            car[2].Type = "Hatchback";
            car[2].People = 5;

            car[3].Make = "Subaru";
            car[3].Model = "Legacy";
            car[3].Year = "1967";
            car[3].Transmission = "Hybrid";
            car[3].Type = "Sedan";
            car[3].People = 2;

            car[4].Make = "Ford";
            car[4].Model = "Mustang";
            car[4].Year = "Default";
            car[4].Transmission = "Stick";
            car[4].Type = "Coupe";
            car[4].People = 6;

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", car[i].Year, car[i].Make, car[i].Model, car[i].Type, car[i].Engine, car[i].Transmission, car[i].People);
            }
            car[0].Ignition("On", "1234");
            car[1].Ignition("On", "0000");
            car[2].Ignition(1, "On", "4321");
            car[3].Ignition("On", "0000");
            car[4].Ignition("On", "1234");

            PickUpTruck[] truck = new PickUpTruck[NUM_VEHICLES];

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                truck[i] = new PickUpTruck();
            }

            truck[0].Make = "Ford";
            truck[0].Model = "F250";
            truck[0].Year = "2020";
            truck[0].Transmission = "Default";
            truck[0].Cab = "Crew";
            truck[0].People = 2;

            truck[1].Make = "Dodge";
            truck[1].Model = "3500";
            truck[1].Year = "2010";
            truck[1].Transmission = "Default";
            truck[1].Cab = "Extended";
            truck[1].People = 4;

            truck[2].Make = "Chevrolet";
            truck[2].Model = "1500";
            truck[2].Year = "1998";
            truck[2].Transmission = "Default";
            truck[2].Cab = "Regular";
            truck[2].People = 4;

            truck[3].Make = "GMC";
            truck[3].Model = "1500";
            truck[3].Year = "2020";
            truck[3].Transmission = "Default";
            truck[3].Cab = "Crew";
            truck[3].People = 3;

            truck[4].Make = "Ford";
            truck[4].Model = "F150";
            truck[4].Year = "2017";
            truck[4].Transmission = "Hybrid";
            truck[4].Cab = "Extended";
            truck[4].People = 6;

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", truck[i].Year, truck[i].Make, truck[i].Model, truck[i].Cab, truck[i].Engine, truck[i].Transmission, truck[i].People);
            }
            truck[0].Ignition("On", "1234");
            truck[1].Ignition("On", "0000");
            truck[2].Ignition("On", "4321");
            truck[3].Ignition("On", "0000");
            truck[4].Ignition(0, "On", "1234");


            MotorCycle[] bike = new MotorCycle[NUM_VEHICLES];

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                bike[i] = new MotorCycle();
            }

            bike[0].Make = "BMW";
            bike[0].Model = "S1000 RP";
            bike[0].Year = "2012";
            bike[0].Transmission = "Default";
            bike[0].Wheels= 2;
            bike[0].People = 1;

            bike[1].Make = "Ducati";
            bike[1].Model = "Panigale";
            bike[1].Year = "2015";
            bike[1].Transmission = "Default";
            bike[1].Wheels = 3;
            bike[1].People = 2;

            bike[2].Make = "Honda";
            bike[2].Model = "Gold Wing";
            bike[2].Year = "2017";
            bike[2].Transmission = "Default";
            bike[2].Wheels = 4;
            bike[2].People = 2;

            bike[3].Make = "Kawasaki";
            bike[3].Model = "Ninja";
            bike[3].Year = "1967";
            bike[3].Transmission = "Default";
            bike[3].Wheels = 3;
            bike[3].People = 1;

            bike[4].Make = "Suzuki";
            bike[4].Model = "V Storm";
            bike[4].Year = "Default";
            bike[4].Transmission = "Default";
            bike[4].Wheels = 2;
            bike[4].People = 2;

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", bike[i].Year, bike[i].Make, bike[i].Model, bike[i].Wheels, bike[i].Engine, bike[i].Transmission, bike[i].People);
            }
            bike[0].Ignition("On", "1234");
            bike[1].Ignition("On", "0000");
            bike[2].Ignition(1, "On", "4321");
            bike[3].Ignition("On", "0000");
            bike[4].Ignition("On", "1234");


            Console.WriteLine("--------------");
            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2}", car[i].Make, car[i].Model, car[i].Engine);
            }

            car[0].Ignition("Off", "1234");
            car[1].Ignition("Off", "0000");
            car[2].Ignition("Off", "4321");
            car[3].Ignition("Off", "0000");
            car[4].Ignition("Off", "1234");

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2}", truck[i].Make, truck[i].Model, truck[i].Engine);
            }

            truck[0].Ignition("Off", "1234");
            truck[1].Ignition("Off", "0000");
            truck[2].Ignition("Off", "4321");
            truck[3].Ignition("Off", "0000");
            truck[4].Ignition("Off", "1234");

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2}", bike[i].Make, bike[i].Model, bike[i].Engine);
            }
            bike[0].Ignition("On", "1234");
            bike[1].Ignition("On", "0000");
            bike[2].Ignition("On", "4321");
            bike[3].Ignition("On", "0000");
            bike[4].Ignition("On", "1234");

            Console.WriteLine("--------------");
            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2}", car[i].Make, car[i].Model, car[i].Engine);
            }
            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2}", truck[i].Make, truck[i].Model, truck[i].Engine);
            }
            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                Console.WriteLine("{0} {1} {2}", bike[i].Make, bike[i].Model, bike[i].Engine);
            }

            Console.ReadLine();
        }
    }

}