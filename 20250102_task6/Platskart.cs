using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250102_task6
{
    /*
         В пассажирском поезде 15 вагонов. 
        Известно, что все вагоны с четными номерами купейные (36 мест), 
        а с нечетными номерами плацкартные (52 места). 
        Обеспечить ввод количества занятых мест в каждом вагоне. 
        Учесть, что вагон No10 – это ресторан. 
        Выдать на печать номера вагонов, в которых есть свободные места, использовать List.
         */
    public class Platskart : Wagon
    {
        public override string Type { get; set; }
        public bool[] Seats { get; set; }
        public Platskart()
        {
            Type = "Platskart";
            bool[] seats = new bool[52];
            Random random = new Random();
            for (int i = 0; i < seats.Length; i++)
            {
                if (random.Next(0, 2) == 0)
                    seats[i] = false;
                else
                    seats[i] = true;
            }
            Seats = seats;
        }
        public override string ToString()
        {
            int occupied = 0;
            for (int i = 0; i < Seats.Length; i++)
            {
                if (Seats[i] == true) 
                { 
                    occupied++;
                }
            }
            return $"{Type}. Occupied: {occupied} seats, available: {Seats.Length - occupied} seats";
        }
    }
}
