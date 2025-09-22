using System;

//dotnet new console -o Maskotas --use-program-main
namespace Maskotas //--> asi podemos tener varios codigos en uno, varias clases
// normalmente es el nombre del programa
{
   // Definición de la clase Mascota
   public class Mascota
   {
       // Propiedades de la clase
       public string Nombre { get; set; }
       public int Edad { get; set; }
       public string Tipo { get; set; }

       public Mascota();//constructor sin argumentos
       // Constructor para inicializar las propiedades
       public Mascota(string nombre, int edad, string tipo)
       {
           Nombre = nombre;
           Edad = edad;
           Tipo = tipo;
       }


       // Método para calcular la edad humana
       public int EdadHumana()
       {
           switch (Tipo.ToLower()) // Usamos ToLower() para no distinguir entre mayúsculas y minúsculas
           {
               case "perro":
                   return Edad * 7;
               case "gato":
                   return Edad * 6;
               default:
                   return Edad;
           }
       }
   }


   // Clase principal del programa
   class Program
   {
        static void Main(string[] args)
        {
            /*
                Mascota mascota1 = new Mascota("Rocky", 3, "Perro");
               Mascota mascota2 = new Mascota("Mishi", 3, "Gato");
               Mascota mascota3 = new Mascota("Piolín", 2, "Canario");

                Console.WriteLine($"Mascota: {mascota1.Nombre}, Edad Humana: {mascota1.EdadHumana()}");
               Console.WriteLine($"Mascota: {mascota2.Nombre}, Edad Humana: {mascota2.EdadHumana()}");
               Console.WriteLine($"Mascota: {mascota3.Nombre}, Edad Humana: {mascota3.EdadHumana()}");
            */
            List<Mascota> list = new List<Mascota>();
            list.Add(new Mascota("Rocky", 3, "Perro"));
            list.Add(new Mascota("Mishi", 3, "Gato"));
            list.Add(new Mascota("Piolín", 2, "Canario"));
            Mascota maskota = new Mascota();

            //alternativa a lo anterior
            maskota.Nombre = "PERRO";
            maskota.Tipo = "gato";
            maskota.Edad = 64;
            list.Add(maskota);
            //TO DO: persistir lista, persistencia, guardarlo en un disco duro. Tambien se puede guardar en una base de datos
            foreach (Mascota mascota in list)
            {
                Console.WriteLine($"Mascota: {mascota.Nombre}, Edad Humana: {mascota.EdadHumana()}");
            }       
         
       }
   }
}

