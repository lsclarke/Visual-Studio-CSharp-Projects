using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarRentalManagementProject.Product.Car.Exterior;
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
            _id = nextId++;
        }

        public Car(Interior i, Exterior e)
        {

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
 
            public enum SeatTextureMaterials { Leather, Vinyl, Faux_Leather, Polyester, Alcantara_Ultrasuede };
            private static SeatTextureMaterials _seatMaterials;
            public enum SeatColors { red, blue, green, black, brown, white }
            private static SeatColors _seatColors;

            public string seatColorText = _seatColors.ToString();
            public string seatMaterialText = _seatMaterials.ToString();

            private static SeatTextureMaterials Get_Materials() => _seatMaterials;
            private static SeatColors Get_colors() => _seatColors;

            #endregion


            public int setSeatCount(int num)
            {
                seatCount = num;
                return seatCount;
            }

            //It will select the seat material based on the number input
            public int setSeatMaterial()
            {
                switch (seatMaterialNum)
                {
                    case 0:
                        _seatMaterials = SeatTextureMaterials.Leather;
                        seatMaterialText = _seatMaterials.ToString();
                        break;
                    case 1:
                        _seatMaterials = SeatTextureMaterials.Vinyl;
                        seatMaterialText = _seatMaterials.ToString();
                        break;
                    case 2:
                        _seatMaterials = SeatTextureMaterials.Faux_Leather;
                        seatMaterialText = _seatMaterials.ToString();
                        break;
                    case 3:
                        _seatMaterials = SeatTextureMaterials.Polyester;
                        seatMaterialText = _seatMaterials.ToString();
                        break;
                    case 4:
                        _seatMaterials = SeatTextureMaterials.Alcantara_Ultrasuede;
                        seatMaterialText = _seatMaterials.ToString();
                        break;
                }

                return seatMaterialNum;
            }

            //It will select the seat color based on the number input
            public int setSeatColor(int num)
            {
                seatColorNum = num;
                switch (num) {
                    case 0:
                        _seatColors = SeatColors.red;
                        seatColorText = _seatColors.ToString();
                        break;
                    case 1:
                        _seatColors = SeatColors.blue;
                        seatColorText = _seatColors.ToString();
                        break;
                    case 2:
                        _seatColors = SeatColors.green;
                        seatColorText = _seatColors.ToString();
                        break;
                    case 3:
                        _seatColors = SeatColors.black;
                        seatColorText = _seatColors.ToString();
                        break;
                    case 4:
                        _seatColors = SeatColors.brown;
                        seatColorText = _seatColors.ToString();
                        break;
                    case 5:
                        _seatColors = SeatColors.white;
                        seatColorText = _seatColors.ToString();
                        break;
                }

                return num;
            }

            public bool hasSeatWarmers(bool hasWarmers)
            {
                hasWarmers = doeshasSeatWarmers;
                return hasWarmers;
            }

            public bool hasGPSNavigation(bool hasGPS)
            {
                hasGPS = hasNav;
                return hasGPS;
            }

            public bool hasAuxPort(bool hasPort)
            {
                hasPort = hasAux;
                return hasPort;
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
            public enum CarBodyMaterials { Steel, Titanium, Aluminum };
            private static CarBodyMaterials _bodyMaterials;
            public enum CarColors { red, blue, green, yellow, orange, silver, black, brown, white, grey }
            private static CarColors _carColors;

            private static CarBodyMaterials Get_Materials() => _bodyMaterials;

            private static CarColors Get_colors() => _carColors;

            //It will select the seat material based on the number input
            public string setCarMaterial(int num)
            {
                string result = "";
                int index = 0;
                num = carMaterialNum;
                while (num > -1)
                {
                    index++;
                    if (num == index)
                    {
                        _bodyMaterials = (CarBodyMaterials)index;
                        result = _bodyMaterials.ToString();
                    }
                }
                return result;
            }

            //It will select the seat color based on the number input
            public string setCarColor(int num)
            {
                string result = "";
                int index = 0;
                num = carColorNum;
                while (num > -1)
                {
                    index++;
                    if(num == index)
                    {
                        _carColors = (CarColors)index;
                        result = _carColors.ToString();
                    }
                }
                return result;
            }

            #endregion

            public string checkWheelQuality(int gradeNum) 
            {
                string result = "";
                wheelGradeNum = gradeNum;

                if (gradeNum >= 90)
                {
                    result = "A";
                } else if ( 90 > gradeNum  && gradeNum >= 80) {
                    result = "B";
                } else if (80 > gradeNum && gradeNum >= 70) {
                    result = "C";
                } else if (70 > gradeNum && gradeNum >= 60) {
                    result = "C";
                } else if (60 > gradeNum && gradeNum >= 50) {
                    result = "D";
                } else if (50 > gradeNum) {
                    result = "E";
                }

                return result;
            }
            public bool hasDashCamera(bool hasCam)
            {
                hasCam = hasDashCam;
                return hasCam;
            } 

            public bool hasBumperCamera(bool hasCam)
            {
                hasCam = hasBumperCam;
                return hasCam;
            }
            public bool hasSideWindowCamera(bool hasCam)
            {
                hasCam = hasSideCam;
                return hasCam;
            }

            public bool hasSpoilerOnCar(bool check)
            {
                check = hasSpoiler;
                return check;
            }
            public bool hasTintedWindows(bool check)
            {
                check = hasTinted;
                return check;
            }
        }
    }
}
