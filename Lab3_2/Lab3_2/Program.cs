namespace Lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Bienvenido al juego de Craps!");
            Craps juego = new Craps();
            juego.Jugar();
        }
    }
}
