﻿using System.Diagnostics;

namespace Decx_y;
class Program
{
    static void Main(string[] args)
    {
        // Benchmarking my code
        var watch = new Stopwatch();
        watch.Start();

        // Reads input
        var input = System.IO.File.ReadLines(@"input.txt");

        // Variables used
        var solution = 0;

        // Looping through the input and reading the input lines
        foreach (string line in input)
        {
            // Trim away newlines etc
            line.Trim();
        }

        // Stops timer and prints the solution to console and elapsed time to console
        Console.WriteLine($": {solution}, Code runtime: {watch.ElapsedMilliseconds}");

        // * *    SOLUTION STRING    * *
    }
}