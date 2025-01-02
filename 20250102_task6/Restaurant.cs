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
    public class Restaurant : Wagon
    {
        public override string Type { get; set; }
        public Restaurant()
        {
            Type = "Restaurant";
        }
        public override string ToString()
        {
            return $"{Type}";
        }
    }
}
