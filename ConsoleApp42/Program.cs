using ConsoleApp42;

Console.WriteLine("How many rooms will be rented?");
int n = int.Parse(Console.ReadLine());

HostelSystem[] room = new HostelSystem[10];
for (int i = 0; i< n; i++)
{
    Console.WriteLine();
    Console.WriteLine("Rent #" + (i + 1));
    Console.Write("Name:");
    string name = Console.ReadLine();
    Console.Write("Email:");
    string email = Console.ReadLine();
    Console.Write("Room:");
    int roomnumber = int.Parse(Console.ReadLine());

    room[roomnumber] = new HostelSystem { Name = name, Email = email, Room = roomnumber };  

}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Busy rooms:");

for (int i = 0; i< 10; i++)
{
    if (room[i] != null)
    {
        Console.WriteLine(room[i]);
    }

}


 