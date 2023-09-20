namespace PV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zlomek z1 = new Zlomek(1, 7);
            Zlomek z2 = new Zlomek(2, 9);
            Zlomek z3 = Zlomek.scitani(z1, z2);
            Console.WriteLine(z3);
            Zlomek z4 = Zlomek.odcitani(z1, z2);
            Console.WriteLine(z4);
            Zlomek z5 = Zlomek.nasobeni(z1, z2);
            Console.WriteLine(z5);
            Zlomek z6 = Zlomek.deleni(z1, z2);
            Console.WriteLine(z6);
        }
    }
}