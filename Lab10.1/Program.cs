using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corn corn = new Corn(-10, 90, 15);
            Console.ReadKey();
        }

    }
    class Corn
    {
        public int gradus { get; set; }
        public int minute { get; set; }
        public int sec { get; set; }

        public int Gradus
        {
            set
            {
                if (value >= 0)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Введённые данные не корректны");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Minute
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    minute = value;
                }
                else
                {
                    Console.WriteLine("Введённые данные не корректны");
                }
            }
            get { return minute; }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Введённые данные не корректны");
                }
            }
            get { return sec; }
        }
        public Corn(int gradus, int minute, int sec)
        {
            Gradus = gradus;
            Minute = minute;
            Sec = sec;
        }

        public void ToRadians()
        {
            double Radians = (Math.PI / 180) * (gradus+minute+sec);
            Console.WriteLine(Radians);
        }
    }


}

