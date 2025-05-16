namespace zad4;

public class FullTimeContract : Contract
{
    public decimal StawkaMiesieczna { get; }
    public int IloscNadgodzin { get; }

    public FullTimeContract() : this(5000m, 0)
    {
    }

    public FullTimeContract(decimal stawka, int nadgodziny)
    {
        StawkaMiesieczna = stawka;
        IloscNadgodzin = nadgodziny;
    }

    public override decimal Pensja()
    {
        return StawkaMiesieczna + IloscNadgodzin * (StawkaMiesieczna / 60);
    }
}