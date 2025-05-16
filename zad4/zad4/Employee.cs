namespace zad4;

public class Employee
{
    public string Imie { get; }
    public string Nazwisko { get; }
    public Contract Kontrakt { get; private set; }

    public Employee(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Kontrakt = new InternshipContract();
    }

    public void ZmienKontrakt(Contract nowyKontrakt)
    {
        Kontrakt = nowyKontrakt;
    }

    public decimal ObliczPensje()
    {
        return Kontrakt.Pensja();
    }

    public override string ToString()
    {
        return $"{Imie} {Nazwisko}, Pensja: {ObliczPensje():C}";
    }
}