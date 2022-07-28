// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Models;

Console.WriteLine("Welcome to Tennis Match Simulator");
var match = new Match("Adam","Tom");
match.InitiateMatch();
Console.ReadLine();
