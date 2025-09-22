using System;
namespace Empleados
{
    public class Empleados
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public double Salario { get; set; }

        public bool ContratoFijo { get; set; }

        public Empleados(String nombre, int edad, double salario, bool contratoFijo)
        {
            Nombre = nombre;
            Edad = edad;
            Salario = salario;
            ContratoFijo = contratoFijo;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, Salario ${Salario}, Contrato Fijo {(ContratoFijo ? "Si" : "No")}";
        }

    }
    class Aplicacion
    {
        public static void Main(string[] args)
        {

            List<Empleados> list = new List<Empleados>();
            list.Add(new Empleados("Ana García", 28, 32000.50, true));
            list.Add(new Empleados("Juan Martínez", 35, 45000.00, true));
            list.Add(new Empleados("Luisa Fernández", 22, 21000.75, false));
            list.Add(new Empleados("Carlos Rodríguez", 41, 55000.25, true));

            Console.WriteLine("--- Sistema de Gestión de Empleados --- ");
            Console.WriteLine("--- Lista de Empleados Registrados ---");

            foreach (Empleados empleado in list)
            {
                Console.WriteLine(empleado);
            }

            double salarioTotal = 0;
            int cont = 0;

            foreach (Empleados empleado in list)
            {
                salarioTotal += empleado.Salario;
            }

            foreach (Empleados numEmpleados in list)
            {
                cont++;
            }

            double mediaSalario = salarioTotal / cont;

            Console.WriteLine($"\n El salario promedio de la empresa es: ${mediaSalario:N2}");

            Empleados mejorPagado = list[0];
            foreach (Empleados empleado in list)
            {
                if (empleado.Salario > mejorPagado.Salario)
                {
                    mejorPagado = empleado;
                }
            }
            Console.WriteLine("\n--- Empleado con el Salario Más Alto --- ");
            Console.WriteLine(mejorPagado);
        }

    }
}
