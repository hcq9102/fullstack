// Get the current time
DateTime currentTime = DateTime.Now;
int currentHour = currentTime.Hour;

// provide appropriate greeting based on the current time(hour)
if (currentHour >= 5 && currentHour < 12)
{
    Console.WriteLine("Good Morning");
}
else if (currentHour >= 12 && currentHour < 17)
{
    Console.WriteLine("Good Afternoon");
}
else if (currentHour >= 17 && currentHour < 21)
{
    Console.WriteLine("Good Evening");
}
else if ((currentHour >= 21 && currentHour <= 23) || (currentHour >= 0 && currentHour < 5))
{
    Console.WriteLine("Good Night");
}
