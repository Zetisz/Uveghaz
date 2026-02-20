namespace Uveghaz;

internal class Pozicio
{
    private int x;
    private int y;
    
    public int X { get => x; set => x = value; }
    public int Y { get => y; set => y = value; }
    internal Pozicio(int x, int y) { this.x = x; this.y = y; }
}