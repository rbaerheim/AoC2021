﻿using System.Text;
using System.Diagnostics;

// Benchmarking my code
var watch = new Stopwatch();
watch.Start();

// Path for the input
var path = @"input.txt";

// Reading lines in input
var enumLines = File.ReadLines(path, Encoding.UTF8);

// Total score variable
int totalScore = 0;

// Looping through the input lines
foreach (string line in enumLines)
{
    // Trim away newlines etc
    line.Trim();
}

// Prints the totalScore to console
Console.WriteLine(totalScore);

// Stops the benchmarking and prints it to the console.
watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);