using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "Austin", "TX", "USA");

        Event lecture = new Lecture("Tech Talk", "A talk on the latest in technology.", "2024-08-12", "10:00 AM", address1, "Ted Nugget", 100);
        Event reception = new Reception("Networking Event", "An event to network with professionals.", "2024-08-13", "06:00 PM", address2, "rsvp@events.com");
        Event outdoorGathering = new Outdoor("Community Picnic", "A picnic for the community.", "2024-08-14", "01:00 PM", address3, "Sunny");

        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}