namespace Uveghaz;

public class NovenyFaj
{
    private string nev;
    private int nedvessegtartalom; // 100 ideális
    private int egeszsegSzint; // 100 a max, 60 alatt beteg
    private int optimalisSuruseg;
    
    public NovenyFaj(string nev,  int optimalisSuruseg)
    {
        this.nev = nev;
        this.optimalisSuruseg = optimalisSuruseg;
        this.nedvessegtartalom = 100;
        this.egeszsegSzint = 100;
    }
    
    public string Nev { get => nev; set => nev = value; }
    public int Nedvessegtartalom { get => nedvessegtartalom; set => nedvessegtartalom = value; }
    public int EgeszsegSzint { get => egeszsegSzint; set => egeszsegSzint = value; }
    public int OptimalisSuruseg { get => optimalisSuruseg; set => optimalisSuruseg = value; }

    public string Azonosito
    {
        get
        {
            return this.nev.Substring(0, 3);
        }
    }

    public override bool Equals(object? obj)
    {
        obj = obj as NovenyFaj;
        if (this.nev == ((NovenyFaj)(obj)).nev)
        {
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"{this.nev} nedvesseg: {this.nedvessegtartalom} egészség: {this.egeszsegSzint} optimalis: {this.optimalisSuruseg}";
    }
}