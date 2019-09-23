using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {

        var numList = new List<int>();
        var steps = n;

        foreach (char l in s) {
            int value = 0;
            if (l == 'D') { value = -1; }
            if (l == 'U') { value = 1; }
            numList.Add(value);
        }

        var elevation = new List<int>();
        int valleyCounter = 0;
        int idxcount = 0;
        int elesum = 0;
        foreach (int i in numList) {
            elesum += i;
            elevation.Add(elesum);

            if (elesum == 0 && elevation[idxcount - 1] == -1) {
                valleyCounter++;
            }
            idxcount++;
        }
        return valleyCounter;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
