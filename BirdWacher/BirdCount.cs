using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWacher
{
    class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            int[] lastWeek = { 0, 2, 5, 3, 7, 8, 4 };
            foreach (int i in lastWeek)
            {
                Console.Write(i + ", ");
            }
            return lastWeek;
        }

        public int Today()
        {
            return birdsPerDay.Last();
        }

        public void IncrementTodaysCount()
        {
            Console.WriteLine(birdsPerDay[birdsPerDay.Length - 1]++);
        }

        public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);


        public int CountForFirstDays(int numberOfDays) => birdsPerDay.Take(numberOfDays).Sum();
        /*{
            int countForFirstDays = 0;
            for (int i = 0; i<numberOfDays; i++)
            {
                countForFirstDays += birdsPerDay[i];
            }
            return countForFirstDays;
        }*/


        public int BusyDays() => birdsPerDay.Where(x => x >= 5).Count();
        /*{
            int busyDays = 0;
            foreach (var count in birdsPerDay)
            {
                if(count >= 5)
                {
                    busyDays += 1;
                }
            }
            return busyDays;
        }*/
    }
}
