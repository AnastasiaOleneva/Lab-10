using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {

            Angle angle = new Angle(45, 11, 23);
            angle.ToRadians();
            Console.ReadKey();

        }
    }


    class Angle
    {

        int degree;
        public int Sec { get; set; }

        public int Min { get; set; }
        public int Degree
        {
            set
            {
                if (value <= 360)
                {
                    degree = value;
                }

                else
                {
                    Console.WriteLine("Ошибка,данные некорректны");


                }

            }
            get
            {

                return degree;


            }
        }

        public Angle (int degree, int min, int sec)
        {
            Degree = degree;
            Min = min;
            Sec = sec;

        }

        public double ToRadians() 
        {

            double minToDegree = Min / 60;
            double secToDegree = Sec / 3600;
            double radians = ((Degree + minToDegree + secToDegree) * Math.PI) / 180;
            Console.WriteLine("Угол {0} ° , {1} минут, {2} секунд равен {3} радиан",Degree,Min,Sec,radians);
            return radians;

        }


    }
    
    
    
    
    
    
  
}
