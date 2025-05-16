using System;

namespace zad4;

class Program
{
    static void Main(string[] args)
    {
        Employee pracownik = new Employee("Jan", "Kowalski");
        Console.WriteLine(pracownik); // Jan Kowalski, Pensja: 1000,00 zł

        pracownik.ZmienKontrakt(new FullTimeContract());
        Console.WriteLine(pracownik); // Jan Kowalski, Pensja: 5000,00 zł

        pracownik.ZmienKontrakt(new FullTimeContract(6000m, 10));
        Console.WriteLine(pracownik); // Jan Kowalski, Pensja: 7000,00 zł
    }
}