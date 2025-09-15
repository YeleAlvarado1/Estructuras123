public class TareaSemana13
{
    public static void run()
    {
        Catalogo catalogo = new Catalogo();
        // Variables para el menu
        string opcion = "";
        string entrada = "";

        // Bucle del menu principal
        while (opcion != "3")
        {
            System.Console.WriteLine("\n--- MENU PRINCIPAL ---");
            System.Console.WriteLine("1. Mostrar catalogo");
            System.Console.WriteLine("2. Buscar revista por titulo");
            System.Console.WriteLine("3. Salir");
            System.Console.Write("Seleccione una opcion: ");
            opcion = System.Console.ReadLine();
        if (opcion == "1")
        {
            catalogo.Mostrar(); // Llama al metodo que imprime las revistas
        }
        else if (opcion == "2")
        {
            System.Console.Write("Ingrese el título a buscar: ");
            entrada = System.Console.ReadLine();
        }
            

    }
}