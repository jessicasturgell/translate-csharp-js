using System;

namespace DinnerParty
{
    // Define Guest and Table classes
    public class Guest
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Bio { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public List<Guest> Guests { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Empty Tables to Store Guests
            List<Table> tables = new List<Table>()
            {
                new Table() { Name = "Table 1", Guests = new List<Guest>() },
                new Table() { Name = "Table 2", Guests = new List<Guest>() },
            };
            List<Guest> guests = new List<Guest>()
            {
                new Guest()
                {
                    Name = "Marilyn Monroe",
                    Occupation = "entertainer",
                    Bio = "(1926 - 1962) American actress, singer, model"
                },
                new Guest()
                {
                    Name = "Abraham Lincoln",
                    Occupation = "politician",
                    Bio = "(1809 - 1865) US President during American civil war"
                },
                new Guest()
                {
                    Name = "Martin Luther King",
                    Occupation = "activist",
                    Bio = "(1929 - 1968)  American civil rights campaigner"
                },
                new Guest()
                {
                    Name = "Rosa Parks",
                    Occupation = "activist",
                    Bio = "(1913 - 2005)  American civil rights activist"
                },
                new Guest()
                {
                    Name = "Peter Sellers",
                    Occupation = "entertainer",
                    Bio = "(1925 - 1980) British actor and comedian"
                },
                new Guest()
                {
                    Name = "Alan Turing",
                    Occupation = "computer scientist",
                    Bio =
                        "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                },
                new Guest()
                {
                    Name = "Admiral Grace Hopper",
                    Occupation = "computer scientist",
                    Bio =
                        "(1906 - 1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                },
                new Guest()
                {
                    Name = "Indira Gandhi",
                    Occupation = "politician",
                    Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"
                }
            };
            foreach (Guest guest in guests)
            {
                // Get occupations of guests at Table 1
                var table1Occupations = tables[0].Guests.Select(g => g.Occupation).ToList();
                // Check if the guest's occupation exists in Table 1
                if (table1Occupations.Contains(guest.Occupation))
                {
                    // Assign the guest to Table 2
                    tables[1].Guests.Add(guest);
                }
                else
                {
                    // Assign the guest to Table 1
                    tables[0].Guests.Add(guest);
                }
            }

            foreach (Table table in tables)
            {
                Console.WriteLine($"{table.Name}");
                foreach (Guest guest in table.Guests)
                {
                    Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
                }
            }
        }
    }
}
