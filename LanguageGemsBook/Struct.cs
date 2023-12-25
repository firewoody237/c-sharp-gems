using System.Runtime.Intrinsics.X86;

namespace LanguageGemsBook;

struct Point3D
{
    public int X;
    public int Y;
    public int Z;

    public Point3D(int X, int Y, int Z)
    {
        this.X = X;
        this.Y = Y;
        this.Z = Z;
    }

    public override string ToString()
    {
        return $"{X} {Y} {Z}";
    }
}

readonly struct ReadOnlyPoint3D
{
    public readonly int X;
    public readonly int Y;
    public readonly int Z;

    public ReadOnlyPoint3D(int X, int Y, int Z)
    {
        this.X = X;
        this.Y = Y;
        this.Z = Z;
    }
}

public class Struct
{
    public void method()
    {
        Point3D p3d = new Point3D(1, 2, 3);
        p3d.X = 1; //가능
        Console.WriteLine(p3d.ToString());

        ReadOnlyPoint3D rop3d = new ReadOnlyPoint3D(1, 2, 3);
        //rop3d.X = 1; //불가능
        Console.WriteLine(rop3d.ToString());
    }
}