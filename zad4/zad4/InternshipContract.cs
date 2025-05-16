namespace zad4;

public class InternshipContract : Contract
{
    public decimal StawkaMiesieczna { get; }

    public InternshipContract() : this(1000m)
    {
    }

    public InternshipContract(decimal stawka)
    {
        StawkaMiesieczna = stawka;
    }

    public override decimal Pensja()
    {
        return StawkaMiesieczna;
    }
}