using System;
using System.Collections.Generic;
using System.Linq;

namespace HRCountingValleys {
    class Program {
        static void Main(string[] args) {

            int n = 8;
            string s1 = "DDDUDUUU"; // 1 valley
            string s2 = "UUDDDUDU"; // 2 valleys

            // assign +1 -1 values to U / D
            // tracker that sums each value
            // whenever it goes from negative to 0, increment valley counter

            var numList = new List<int>();

            int AssignValue(char letter) {
                int value = 0;
                if (letter == 'D') { value = -1; }
                if (letter == 'U') { value = 1;  }
                return value;
            }

            foreach (char l in s2) {
                numList.Add(AssignValue(l));
            }            

            var elevation = new List<int>();
            int valleyCounter = 0;
            int idxcount = 0;
            int elesum = 0;
            foreach(int i in numList) {
                elesum += i;
                elevation.Add(elesum);

                if(elesum == 0 && elevation[idxcount - 1] == -1) {
                    valleyCounter++;
                }
                Console.WriteLine($"Elevation {elevation[idxcount]}  valleys {valleyCounter}");
                idxcount++;
            }

            // could just check for zeroes where previous int is negative and tally those
        }
    }
}
