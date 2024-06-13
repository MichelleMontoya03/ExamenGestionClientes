using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGestionClientes
{
    public class Cliente
    {
        public string Nombre;
        public string Direccion;
        public string Email;
        public string Telefono;
        public string Cedula;
    }
    public class SistemaClientes
    {

        public string Nombre;
        public string Direccion;
        public string Email;
        public string Telefono;
        public string Cedula;
        public static string nombre, direccion, email, telefono, cedula;
        public static List<Cliente> clientes = new List<Cliente>();

        public static void Agregar()
        {
            try
            {
                Cliente nuevoCliente = new Cliente
                {
                    Nombre = nombre,
                    Direccion = direccion,
                    Email = email,
                    Telefono = telefono,
                    Cedula = cedula
                };

                // Agregar a la base de datos (lista en este caso)
                clientes.Add(nuevoCliente);

                // Confirmación
                Console.WriteLine("Cliente agregado exitosamente");

            } catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar cliente: {ex.Message}");
            }
        }
        public static void Borrar(string identificador)
        {
            try
            {
                // Buscar cliente por cédula o email
                Cliente clienteAEliminar = clientes.Find(c => c.Cedula == identificador || c.Email == identificador);

                if (clienteAEliminar == null)
                {
                    throw new Exception("Cliente no encontrado");
                }

                // Eliminar cliente
                clientes.Remove(clienteAEliminar);

                // Confirmación
                Console.WriteLine("Cliente eliminado exitosamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar cliente: {ex.Message}");
            }

        }
      
        public static void Consultar(string identificador)
        {
            try
            {
                // Buscar cliente por cédula o email
                Cliente clienteAConsultar = clientes.Find(c => c.Cedula == identificador || c.Email == identificador);

                if (clienteAConsultar == null)
                {
                    throw new Exception("Cliente no encontrado");
                }

                // Mostrar datos del cliente
                Console.WriteLine($"Nombre: {clienteAConsultar.Nombre}");
                Console.WriteLine($"Dirección: {clienteAConsultar.Direccion}");
                Console.WriteLine($"Email: {clienteAConsultar.Email}");
                Console.WriteLine($"Teléfono: {clienteAConsultar.Telefono}");
                Console.WriteLine($"Cédula: {clienteAConsultar.Cedula}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar cliente: {ex.Message}");
            }
        }



    }
    public class Program
    { 
        static void Main(string[] args)
        {
            SistemaClientes.nombre = "Michelle";
            SistemaClientes.direccion = "Alajuela,Poas";
            SistemaClientes.email = "michelle.montoya1998@outlook.es";
            SistemaClientes.telefono = "6223-2230";
            SistemaClientes.cedula = "1-1698-0236";

          
            SistemaClientes.Agregar();
            SistemaClientes.Consultar("1-1698-0236");
            SistemaClientes.Borrar("1-1698-0236");


            Console.Read();
        
        }
    
        
    
    }
}
