namespace Uveghaz;

internal class Adattar
{
    private List<Kezelo> kezelok;
    private List<NovenyFaj> novenyek;
    private UveghazRacs uveghaz;

    internal UveghazRacs Uveghaz { get => uveghaz; set => uveghaz = value; }

    public Adattar()
    {
        this.kezelok = new List<Kezelo>()
        {
            new Kezelo("Gipsz Jakab", "GJ", Szerepkor.KERTESZ),
            new Kezelo("Aranka néni", "Ari", Szerepkor.ADMIN)
        };
        this.novenyek = new List<NovenyFaj>();
        this.uveghaz = new UveghazRacs(4);
        uveghaz.Parcellazas();
    }

    public void UjNoveny(NovenyFaj noveny)
    {
        novenyek.Add(noveny);
    }

    public void NovenyekListazasa()
    {
        foreach (var noveny in novenyek)
        {
            Console.WriteLine(noveny);
        }
    }

    public void Ultetes()
    {
        uveghaz.Ultetes(novenyek);
    }
}