namespace Uveghaz;

internal class Kezelo
{
    

    private string nev;
    private string azonosito;
    Szerepkor szerepkor;
    
    public Kezelo(string nev, string azonosito, Szerepkor szerepkor)
    {
        this.nev = nev;
        this.azonosito = azonosito;
        this.szerepkor = szerepkor;
    }
    
    public string Nev { get => nev; set => nev = value; }
    public string Azonosito { get => azonosito; set => azonosito = value; }
    public Szerepkor Szerepkor { get => szerepkor; set => szerepkor = value; }

    public override string ToString()
    {
        return $"{Nev} - {azonosito} - {szerepkor}";
    }
}