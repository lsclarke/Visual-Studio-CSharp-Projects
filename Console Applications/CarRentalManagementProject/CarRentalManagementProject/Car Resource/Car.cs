using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarRentalManagementProject.Product.Car.Exterior;
using static CarRentalManagementProject.Product.Car.Interior;
using static CarRentalManagementProject.Program;

namespace CarRentalManagementProject.Product
{
    internal class Car
    {
        private readonly int _id;
        public static int nextId = 0;

        /// <summary>
        /// When a car object is created the contructor will increment the _id, another contructor will be responsible for accessing all the interior and exterior data
        /// </summary>
        public Car()
        {
           
        }

        public Car(Interior i, Exterior e)
        {
            _id = nextId++;
        }

        /// <summary>
        /// The Interior class is responsible for all the interior design characteristics and features of the car! The texture material of the seats
        /// and the coloring as well. Also the Interior class has functions for deteriming if the car has extra features like gps, cameras and warmers
        /// </summary> 

        public class Interior(int seatCount, int seatMaterialNum, int seatColorNum, bool doeshasSeatWarmers, bool hasNav, bool hasAux)
        {
            #region Car Seat Detail Enums Variables 
            /// <summary>
            /// TextureMaterials and the Colors enum stores all the textures and colors for the car seat that can then be accessed later in the sub class
            /// </summary>
 
            public enum SeatTextureMaterials { Leather = 1, Vinyl, Faux_Leather, Polyester, Alcantara_Ultrasuede };
            private static SeatTextureMaterials _seatMaterials;
            public enum SeatColors { red = 1, blue, green, black, brown, white }
            private static SeatColors _seatColors;

            public string seatColorText = "";
            public string seatMaterialText = "";
            private static SeatTextureMaterials Get_Materials() => _seatMaterials;
            private static SeatColors Get_colors() => _seatColors;

            #endregion


            public int numberOfSeats = seatCount;

            //It will select the seat material based on the number input
            public string getSeatMaterial(string result)
            {
                result = "";
                int index = 0;
                while (index < 5)
                {
                    index++;
                    if (seatMaterialNum == index)
                    {
                        _seatMaterials = (SeatTextureMaterials)index;
                        result = _seatMaterials.ToString();
                    }
                }
                return result;
            }

            //It will select the seat color based on the number input
            public string getSeatColor(string result)
            {
                result = "";
                int index = 0;
                while (index < 4)
                {
                    index++;
                    if (seatColorNum == index)
                    {
                        _seatColors = (SeatColors)index;
                        result = _seatColors.ToString();
                    }
                }
                return result;
            }

            

            public bool hasSeatWarmers()
            {
                return doeshasSeatWarmers;
            }

            public bool hasGPSNavigation()
            {
                return hasNav;
            }

            public bool hasAuxPort()
            {
                return hasAux;
            }

        }

        /// <summary>
        /// The Exterior class is responsible for all the Exterior feature of the car! The texture material of the seats
        /// and the coloring as well. Also the Interior class has functions for deteriming if the car has extra features like gps, cameras and warmers
        /// </summary>
        public class Exterior(int carMaterialNum, int carColorNum, int wheelGradeNum, bool hasDashCam, bool hasBumperCam, bool hasSideCam, bool hasSpoiler, bool hasTinted)
        {

            #region Car Material Detail Enums Variables 
            /// <summary>
            /// CarBodyMaterials and the Colors enum stores all the materials and colors for the car's exterior body that can then be accessed later in the sub class
            /// </summary>
            public enum CarBodyMaterials { Steel = 1, Titanium, Aluminum };
            private static CarBodyMaterials _bodyMaterials;
            public enum CarColors { red = 1, blue, green, yellow, orange, silver, black, brown, white, grey = 10 }
            private static CarColors _carColors;


            public string carBodyMaterialText = "";
            public string carColorText = "";
            public string carWheelText = "";
            private static CarBodyMaterials Get_Materials() => _bodyMaterials;
            private static CarColors Get_colors() => _carColors;

            //It will select the seat material based on the number input
            public string getCarMaterial(string result)
            {
                result = "";
                int index = 0;
                while (index != 3)
                {
                    index++;
                    if (carMaterialNum == index)
                    {
                        _bodyMaterials = (CarBodyMaterials)index;
                        result = _bodyMaterials.ToString();
                    }
                }
                return result;
            }

            //It will select the seat color based on the number input
            public string getCarColor(string result)
            {
                result = "";
                int index = 0;
                while (index != 10)
                {
                    index++;
                    if (carColorNum == index)
                    {
                        _carColors = (CarColors)index;
                        result = _carColors.ToString();
                    }
                }
                return result;
            }

            #endregion

            /// <summary>
            /// checkWheelQuality is responsible for returning the grade level of the wheels. This is a repesentation of their current quality status since 
            /// past travel will have some wear and tear and the tires  
            /// </summary>

            public string checkWheelQuality(string result)
            {
                result = "";

                if (wheelGradeNum >= 90)
                {
                    result = "A";
                } else if (90 > wheelGradeNum && wheelGradeNum >= 80) {
                    result = "B";
                } else if (80 > wheelGradeNum && wheelGradeNum >= 70) {
                    result = "C";
                } else if (70 > wheelGradeNum && wheelGradeNum >= 60) {
                    result = "C";
                } else if (60 > wheelGradeNum && wheelGradeNum >= 50) {
                    result = "D";
                } else if (50 > wheelGradeNum) {
                    result = "E";
                }

                return result;
            }

            public bool hasDashCamera()
            {
                return hasDashCam;
            } 

            public bool hasBumperCamera()
            {
                return hasBumperCam;
            }
            public bool hasSideWindowCamera()
            {
                return hasSideCam;
            }

            public bool hasSpoilerOnCar()
            {
                return hasSpoiler;
            }
            public bool hasTintedWindows()
            {
                return hasTinted;
            }
        }
    }
}
