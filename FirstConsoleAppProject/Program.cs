// See https://aka.ms/new-console-template for more information
using FirstConsoleAppProject;
using static FirstConsoleAppProject.Questions;

Questions questions = new Questions();
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
questions.AskAboutYou(name);
