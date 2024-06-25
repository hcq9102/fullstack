 // See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter number of centuries: ");
int centuries = int.Parse(Console.ReadLine());

 // transformation

 int years = centuries * 100;
 long days = (long)(years * 365.2425); // leap years over the centuries
 long hours = days * 24;
 long minutes = hours * 60;
 long seconds = minutes * 60;
 long milliseconds = seconds * 1000;
 decimal microseconds = milliseconds * 1000m;
 decimal nanoseconds = microseconds * 1000m;

// print results
 Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
