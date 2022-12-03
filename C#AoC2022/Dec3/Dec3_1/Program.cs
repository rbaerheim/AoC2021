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

// Dictionary of scores
var scores = new Dictionary<string, int>() {
    { "a", 1 },
    { "b", 2 },
    { "c", 3 },
    { "d", 4 },
    { "e", 5 },
    { "f", 6 },
    { "g", 7 },
    { "h", 8 },
    { "i", 9 },
    { "j", 10 },
    { "k", 11 },
    { "l", 12 },
    { "m", 13 },
    { "n", 14 },
    { "o", 15 },
    { "p", 16 },
    { "q", 17 },
    { "r", 18 },
    { "s", 19 },
    { "t", 20 },
    { "u", 21 },
    { "v", 22 },
    { "w", 23 },
    { "x", 24 },
    { "y", 25 },
    { "z", 26 },
    { "A", 27 },
    { "B", 28 },
    { "C", 29 },
    { "D", 30 },
    { "E", 31 },
    { "F", 32 },
    { "G", 33 },
    { "H", 34 },
    { "I", 35 },
    { "J", 36 },
    { "K", 37 },
    { "L", 38 },
    { "M", 39 },
    { "N", 40 },
    { "O", 41 },
    { "P", 42 },
    { "Q", 43 },
    { "R", 44 },
    { "S", 45 },
    { "T", 46 },
    { "U", 47 },
    { "V", 48 },
    { "W", 49 },
    { "X", 50 },
    { "Y", 51 },
    { "Z", 52 },
};

// Looping through the input lines
foreach (string line in enumLines)
{
    // Trim away newlines etc
    line.Trim();

    // Splitting the string into two substrings, first and second half.
    char[] firstHalf = line.Substring(0, (line.Length / 2)).ToCharArray();
    char[] secondHalf = line.Substring((line.Length / 2), (line.Length / 2)).ToCharArray();

    // Concat arrays to get the intersection
    string noDupes = new string(firstHalf.Intersect(secondHalf).ToArray());

    // Add Score to totalscore
    totalScore += scores[noDupes];
}

// Prints the totalScore to console
Console.WriteLine(totalScore); // 7903

// Stops the benchmarking and prints it to the console.
watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds); // 18ms