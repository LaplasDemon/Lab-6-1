using System;
using lab4._2_2_;

namespace lab4._2_2_
{
    interface Running
    {
        void Result(int m_temperature);
    }
    public class Meteo : Running
    {
        private string date;
        private int temperature;
        private int atmo;

        public Meteo()
        {
            date = "";
            temperature = 0;
            atmo = 0;
        }

        public Meteo(string Date, int Temperature, int Atmo)
        {
            date = Date;
            temperature = Temperature;
            atmo = Atmo;
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }

        public int Atmosphere
        {
            get
            {
                return atmo;
            }
            set
            {
                atmo = value;
            }
        }

        public void printResult()
        {
            Console.WriteLine("|" + date + "|" + temperature + "|" + atmo + "|\n");
        }

        public void Result(int m_temperature)
        {
            if (temperature > m_temperature)
                printResult();

        }

    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введiть кiлькiсть подiй :");
        int k = int.Parse(Console.ReadLine());
        string d;
        int t, a;
        Meteo[] arr = new Meteo[k];
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine("Введiть дату :");
            d = Console.ReadLine();

            Console.WriteLine("Введiть температуру :");
            t = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть показник атмосферного тиску :");
            a = int.Parse(Console.ReadLine());

            arr[i] = new Meteo(d, t, a);
        }

        Console.WriteLine("Введiть мiнiмально допустиму температуру :");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            arr[i].Result(n);
        }

    }
}
