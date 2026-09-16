namespace ProyectoConsola1
{

    internal class File1
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;

            Clase1 Laclase1 = new Clase1();
            Console.WriteLine(Laclase1.Descripcion);

            ClassLibrary1.Clase2 Laclase2 = new ClassLibrary1.Clase2();
            Console.WriteLine(Laclase2.Descripcion);

            Console.WriteLine("Hello, World!");
            string imput = Console.ReadLine();
            Console.WriteLine(imput);

        }
    }
}