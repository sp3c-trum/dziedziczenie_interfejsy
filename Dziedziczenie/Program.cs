public class Produkt : IProdukt
{
    private float cena;
    private int ilosc;
    private string opis;
    private string nazwa;

    public Produkt(float cena, int ilosc, string opis, string nazwa)
    {
        this.opis = opis;
        this.cena = cena;
        this.ilosc = ilosc;
        this.nazwa = nazwa;
    }
    public float AktualnaCena()
    {
        return this.cena;
    }

    public void DostepnaIlosc()
    {
        Console.WriteLine("Dostępna ilość: " + ilosc);
    }

    public void WyswietlInfo()
    {
        Console.WriteLine(opis);
    }
}

public class Ksiazka : Produkt
{
    public string autor;
    public int iloscStron;
    public Ksiazka(float cena, int ilosc, string opis, string nazwa, string autor, int iloscStron)
        : base(cena, ilosc, opis, nazwa)
    {
        this.autor = autor;
        this.iloscStron = iloscStron;
    }

}

public class Elektronika : Produkt
{
    public string specyfikacje;
    public Elektronika(float cena, int ilosc, string opis, string nazwa, string specyfikacje)
    : base(cena, ilosc, opis, nazwa)
    {
        this.specyfikacje = specyfikacje;
    }
}

public class Odziez : Produkt
{
    public int rozmiar;
        public Odziez(float cena, int ilosc, string opis, string nazwa, int rozmiar)
        : base(cena, ilosc, opis, nazwa)
    {
        this.rozmiar = rozmiar;
    }
}

public abstract class Osoba
{
    public string imie;
    public string nazwisko;
    public int wiek;
}

public class Klient : Osoba
{
    List<IProdukt> koszyk;
    public Klient()
    {
        koszyk = new List<IProdukt>();
    }

    public void dodajProdukt(IProdukt produkt)
    {
        koszyk.Add(produkt);
    }

    public void wyswietlCena(IProdukt produkt)
    {
        Console.WriteLine("Cena produktu: " + produkt.AktualnaCena());
    }

    public float obliczKoszyk()
    {
        float calkowitaCena = 0;
        foreach (var produkt in koszyk)
        {
            calkowitaCena += produkt.AktualnaCena();
        }
        return calkowitaCena;
    }
}
public interface IProdukt
{
    public void WyswietlInfo();
    public float AktualnaCena();
    public void DostepnaIlosc();
}

