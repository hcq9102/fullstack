
// provide birth date
DateTime birthDate = new DateTime(1996, 12, 11); // Example birth date, change as needed

// get the current date
DateTime currentDate = DateTime.Now;

// Calculate the days
TimeSpan ageSpan = currentDate - birthDate;
int daysOld = ageSpan.Days;

// Output the days
Console.WriteLine($"You are {daysOld} days old.");

// Calculate the days until the next 10,000day anniversary
int daysToNextAnniversary = 10000 - (daysOld % 10000);

// Calculate the date of the next 10,000day anniversary
DateTime nextAnniversary = currentDate.AddDays(daysToNextAnniversary);

// Output the date of the next 10,000day anniversary
Console.WriteLine($"Your next 10,000day anniversary will be on {nextAnniversary.ToShortDateString()}.");
