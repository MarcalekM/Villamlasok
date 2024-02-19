namespace Villamlasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Villam> villamok = new();
            using StreamReader sr = new(
                path: @"..\..\..\src\villam.txt",
                encoding: System.Text.Encoding.UTF8);
            while (!sr.EndOfStream) villamok.Add(new(sr.ReadLine()));
            foreach (var villam in villamok) Console.WriteLine(villam.ToString());

            Console.WriteLine("\n3. feladat:");
            int f3 = 0;
            int f3Nap = 0;
            int f3Ora = 0;
            for (int i = 0; i < villamok.Count; i++)
            {
                for (int j = 0; j < villamok[i]._orak.Count; j++)
                {
                    if (villamok[i]._orak[j] >f3)
                    {
                        f3 = villamok[i]._orak[j];
                        f3Nap = i+1;
                        f3Ora = j+1;
                    }
                }
            }
            Console.WriteLine($"\tA legtöbb villám augusztus {f3Nap}. napjának {f3Ora}. órájában volt: {f3} darab");

            Console.WriteLine("\n4. feladat:");
            Dictionary<int, int> f4 = new();
            for (int i = 0; i < villamok.Count; i++)
            {
                for (int j = 0; j < villamok[i]._orak.Count; j++)
                {
                    if (villamok[i]._orak[j] != 0 && !f4.ContainsKey(i+1))
                    {
                        f4.Add(i + 1, j + 1);
                    }
                }
                if (!f4.ContainsKey(i+1)) f4.Add(i+1, 0);
            }
            foreach (var f in f4) Console.WriteLine($"\tAugusztus {f.Key}: {f.Value}");

            Console.WriteLine($"\n5. feladat:");
            int f5 = 0;
            for (int i = 0; i < villamok.Count; i++)
            {
                for (int j = 0; j < villamok[i]._orak.Count; j++)
                {
                    if (villamok[i]._orak[j] != 0) f5++;
                }
            }
            Console.WriteLine($"\t{f5} darb órában villámlott");

            Console.WriteLine($"\n6. feladat:");
            int f6 = 0;
            for (int i = 0; i < villamok.Count; i++)
            {
                if (villamok[i]._orak.Sum() < 200 && f6 == 0) f6 = i+1;
            }
            Console.WriteLine($"\tAugusztus {f6}. napján volt 200-nál kevesebb villámlás");

            Console.WriteLine($"\n7. feladat:");
            List<int> f7 = new();
            for (int i = 0; i < villamok.Count; i++)
            {
                if (villamok[i]._orak.Sum().Equals(0)) f7.Add(i+1);
            }
            if (!f7.Count.Equals(0)) Console.WriteLine($"\tAugusztus {f7.First()}.-e volt az első nap, amikor nem villámlott");
            else Console.WriteLine("\tNincs ilyen nap");

            Console.WriteLine("\n8. feladat:");
            int f8 = 0;
            for (int i = 0; i < villamok.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (villamok[i]._orak[j] != 0) f8++;
                }
            }
            Console.WriteLine($"\t{f8} darab ilyen óra volt augusztusban");


            Console.ReadLine();
        }
    }
}
