using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address(streetAddress: "18 ring road", city: "Johannesburg", stateOrProvince: "Gauteng", country: "South Africa");

        Address receptionAddress = new Address(streetAddress: "415 Dorp Str", city: "Cape Town", stateOrProvince: "Western Cape", country: "South Africa");

        Address outdoorAddress = new Address(streetAddress: "Malandelas", city: "Malkerns", stateOrProvince: "Manzini", country: "Eswatini");

        Lecture lecture = new Lecture(title: "Thermodynamics", description:"Science of the relationship between heat, work, temperature, and energy", date: "5 Jan 2024", time: "0800hrs", address: lectureAddress, speaker: "Justin Khan", capacity: 100);

        Reception reception = new Reception(title: "Save The Children", description:"Fundraising dinner to pay university fees for economically disadvantaged students", date: "20 Dec 2023", time: "1800hrs", address: receptionAddress, rsvpEmail: "rsvp@savethechildren.org");

        Outdoor outdoor = new Outdoor(title: "Bushfire Festival", description:"Renowned festival bringing music lovers from all parts of the world together for 3 days of dancing and vibing", date: "12 May 2024", time: "1300hrs", address: outdoorAddress,weather: "Sunny and clear skies");

        Console.WriteLine("LECTURE EVENT MARKETING MESSAGES:");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandardMessage());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateFullDetailsMessage());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("=================================================================================================================");

        Console.WriteLine();
        Console.WriteLine("RECEPTION EVENT MARKETING MESSAGES:");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandardMessage());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(reception.GenerateFullDetailsMessage());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("=================================================================================================================");
        
        Console.WriteLine();
        Console.WriteLine("OUTDOOR EVENT MARKETING MESSAGES:");
        Console.WriteLine();
        Console.WriteLine(outdoor.GenerateStandardMessage());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(outdoor.GenerateFullDetailsMessage());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(outdoor.GenerateShortDescription());
    }
}