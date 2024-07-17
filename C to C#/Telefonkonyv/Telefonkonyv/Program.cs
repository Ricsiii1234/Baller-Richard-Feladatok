using System;
using System.IO;

class Program
{
    struct Person
    {
        public string Name;
        public string Address;
        public string FatherName;
        public string MotherName;
        public long MobileNo;
        public string Sex;
        public string Email;
        public string CitizenNo;
    }

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Start();
    }

    static void Start()
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("\t\t**********Üdvözlünk a telefonkönyvnél*************");
        Console.WriteLine("\n\n\t\t\t MENU\t\t\n\n");
        Console.WriteLine("\t1.Új hozzáadása \t2.Rekord \t3.Kilépés \n\t4.Változtatás \t5.Keresés\t6.Törlés");
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.D1:
                AddRecord();
                break;
            case ConsoleKey.D2:
                ListRecord();
                break;
            case ConsoleKey.D3:
                Environment.Exit(0);
                break;
            case ConsoleKey.D4:
                ModifyRecord();
                break;
            case ConsoleKey.D5:
                SearchRecord();
                break;
            case ConsoleKey.D6:
                DeleteRecord();
                break;
            default:
                Console.Clear();
                Console.WriteLine("\nAdja meg 1-től 6-ig.");
                Console.WriteLine("\n Nyomjon meg bármilyen gombot");
                Console.ReadKey();
                Menu();
                break;
        }
    }

    static void AddRecord()
    {
        Console.Clear();
        Person p = new Person();

        using (FileStream fs = new FileStream("project", FileMode.Append, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            Console.Write("\n Adja meg a nevet: ");
            p.Name = Console.ReadLine();
            Console.Write("\n Adja meg a címet: ");
            p.Address = Console.ReadLine();
            Console.Write("\n Adja meg apja nevét: ");
            p.FatherName = Console.ReadLine();
            Console.Write("\n Adja meg anyja nevét: ");
            p.MotherName = Console.ReadLine();
            Console.Write("\n Adja meg a telefonszámát: ");
            p.MobileNo = long.Parse(Console.ReadLine());
            Console.Write("Adja meg a nemét: ");
            p.Sex = Console.ReadLine();
            Console.Write("\n Adja meg az e-mail-t: ");
            p.Email = Console.ReadLine();
            Console.Write("\nAdja meg a személyazonosítóját: ");
            p.CitizenNo = Console.ReadLine();

            writer.Write(p.Name);
            writer.Write(p.Address);
            writer.Write(p.FatherName);
            writer.Write(p.MotherName);
            writer.Write(p.MobileNo);
            writer.Write(p.Sex);
            writer.Write(p.Email);
            writer.Write(p.CitizenNo);
        }

        Console.WriteLine("\n Rekord elmentve");
        Console.WriteLine("\n\n Nyomjon meg bármilyen gombot.");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

    static void ListRecord()
    {
        Console.Clear();
        using (FileStream fs = new FileStream("project", FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            while (fs.Position < fs.Length)
            {
                Person p = new Person
                {
                    Name = reader.ReadString(),
                    Address = reader.ReadString(),
                    FatherName = reader.ReadString(),
                    MotherName = reader.ReadString(),
                    MobileNo = reader.ReadInt64(),
                    Sex = reader.ReadString(),
                    Email = reader.ReadString(),
                    CitizenNo = reader.ReadString()
                };

                Console.WriteLine("\n\n\n A rekordod: \n\n ");
                Console.WriteLine($"\nNév={p.Name}\nCím={p.Address}\nApja neve={p.FatherName}\nAnyja neve={p.MotherName}\ntelefonszáma={p.MobileNo}\nNeme={p.Sex}\nE-mail={p.Email}\nSzemélyazonosítója={p.CitizenNo}");
                Console.ReadKey();
                Console.Clear();
            }
        }

        Console.WriteLine("\n Nyomjon meg bármilyen gombot.");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

    static void SearchRecord()
    {
        Console.Clear();
        Console.Write("\nAdja meg a személy nevét akit keres\n");
        string name = Console.ReadLine();
        bool found = false;

        using (FileStream fs = new FileStream("project", FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            while (fs.Position < fs.Length)
            {
                Person p = new Person
                {
                    Name = reader.ReadString(),
                    Address = reader.ReadString(),
                    FatherName = reader.ReadString(),
                    MotherName = reader.ReadString(),
                    MobileNo = reader.ReadInt64(),
                    Sex = reader.ReadString(),
                    Email = reader.ReadString(),
                    CitizenNo = reader.ReadString()
                };

                if (p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\n\tRészletes információ {name}");
                    Console.WriteLine($"\nNeve:{p.Name}\nCíme:{p.Address}\nApja neve:{p.FatherName}\nAnyja neve:{p.MotherName}\nTelefonszáma:{p.MobileNo}\nNeme:{p.Sex}\nEmail-je:{p.Email}\nSzemélyazonosítója:{p.CitizenNo}");
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("A fájl nem található");
        }

        Console.WriteLine("\n Nyomjon meg bármilyen gombot.");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

    static void DeleteRecord()
    {
        Console.Clear();
        Console.Write("Adja meg a személy nevét: ");
        string name = Console.ReadLine();
        bool found = false;

        using (FileStream fs = new FileStream("project", FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fs))
        using (FileStream tempFs = new FileStream("temp", FileMode.Create, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(tempFs))
        {
            while (fs.Position < fs.Length)
            {
                Person p = new Person
                {
                    Name = reader.ReadString(),
                    Address = reader.ReadString(),
                    FatherName = reader.ReadString(),
                    MotherName = reader.ReadString(),
                    MobileNo = reader.ReadInt64(),
                    Sex = reader.ReadString(),
                    Email = reader.ReadString(),
                    CitizenNo = reader.ReadString()
                };

                if (!p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    writer.Write(p.Name);
                    writer.Write(p.Address);
                    writer.Write(p.FatherName);
                    writer.Write(p.MotherName);
                    writer.Write(p.MobileNo);
                    writer.Write(p.Sex);
                    writer.Write(p.Email);
                    writer.Write(p.CitizenNo);
                }
                else
                {
                    found = true;
                }
            }
        }

        if (found)
        {
            File.Delete("project");
            File.Move("temp", "project");
            Console.WriteLine("Rekord sikeresen törölve.");
        }
        else
        {
            Console.WriteLine("Nincs semmilyen rekord amit törölni lehet.");
            File.Delete("temp");
        }

        Console.WriteLine("\n Nyomjon meg bármilyen gombot.");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

    static void ModifyRecord()
    {
        Console.Clear();
        Console.Write("\nAdja meg a személy nevét amit változtatni szeretne:\n");
        string name = Console.ReadLine();
        bool found = false;

        using (FileStream fs = new FileStream("project", FileMode.Open, FileAccess.ReadWrite))
        using (BinaryReader reader = new BinaryReader(fs))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            while (fs.Position < fs.Length)
            {
                long recordPosition = fs.Position;

                Person p = new Person
                {
                    Name = reader.ReadString(),
                    Address = reader.ReadString(),
                    FatherName = reader.ReadString(),
                    MotherName = reader.ReadString(),
                    MobileNo = reader.ReadInt64(),
                    Sex = reader.ReadString(),
                    Email = reader.ReadString(),
                    CitizenNo = reader.ReadString()
                };

                if (p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("\n Adja meg a nevet: ");
                    p.Name = Console.ReadLine();
                    Console.Write("\nAdja meg a címet: ");
                    p.Address = Console.ReadLine();
                    Console.Write("\nAdja meg az apa nevét: ");
                    p.FatherName = Console.ReadLine();
                    Console.Write("\nAdja meg az anya nevét: ");
                    p.MotherName = Console.ReadLine();
                    Console.Write("\nAdja meg a telefonszámot: ");
                    p.MobileNo = long.Parse(Console.ReadLine());
                    Console.Write("\nAdja meg a nemet: ");
                    p.Sex = Console.ReadLine();
                    Console.Write("\nAdja meg az e-mail címet: ");
                    p.Email = Console.ReadLine();
                    Console.Write("\nAdja meg a személyazonosítót:\n");
                    p.CitizenNo = Console.ReadLine();

                    fs.Seek(recordPosition, SeekOrigin.Begin);
                    writer.Write(p.Name);
                    writer.Write(p.Address);
                    writer.Write(p.FatherName);
                    writer.Write(p.MotherName);
                    writer.Write(p.MobileNo);
                    writer.Write(p.Sex);
                    writer.Write(p.Email);
                    writer.Write(p.CitizenNo);
                    found = true;
                    break;
                }
            }
        }

        if (found)
        {
            Console.WriteLine("\n Az adatok módosítva lettek.");
        }
        else
        {
            Console.WriteLine("\n Nem találhatóak az adatok.");
        }

        Console.WriteLine("\n Nyomjon meg bármilyen gombot.");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}

