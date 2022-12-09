﻿using System.Diagnostics;

// Benchmarking my code
var watch = new Stopwatch();
watch.Start();

// Total score variable
int totalScore = 0;

// Looping through the input and reading the input lines
foreach (string line in System.IO.File.ReadLines(@"input.txt"))
{
    // Trim away newlines etc
    line.Trim();
    Console.WriteLine(line);
    break;
}

// Prints the totalScore to console
// Console.WriteLine(totalScore);

// Stops the benchmarking and prints it to the console.
watch.Stop();
// Console.WriteLine(watch.ElapsedMilliseconds);