using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap5
{
    internal class ListCity
    {

        public string tenCity;
        public double danSo1940;
        public double danSo1950;

        public void nhapCity()
        {
            Console.Write("Enter city name:");
            this.tenCity = Console.ReadLine();

            Console.Write("Enter population in 1940:");
            this.danSo1940 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter population in 1950:");
            this.danSo1950 = Convert.ToDouble(Console.ReadLine());

        }

        public void showCity()
        {
            Console.WriteLine("{0, -15} {1, 0} {2, 12} {3, 10} {4, 12} {5, 15}", this.tenCity , "1940", this.danSo1940 , "1950", this.danSo1950 , ((this.danSo1950-this.danSo1940)/this.danSo1940)*100 +"%");
        }


    }
}
