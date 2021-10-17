using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablas_multiplicar
{

   class Animal {
      //Propiedades de la clase
      string Ambiente_atributo = "";
      string Tipo_Animal = "";
      string Nombre = "";
      //Constructor de la clase.
      public  Animal() {}

      /// <summary>
      /// Metodos
      /// </summary>
      public void Respira() {
         Console.WriteLine("ZZZZZZZZZZ......");
      }

      public void SetCome(string Ambiente) {
         Ambiente_atributo = Ambiente;
      }
      public void SetTipo(string TipoAnimal) {
         Tipo_Animal = TipoAnimal;
         
      }
      public string GetCome() {
         return Ambiente_atributo;
      }
      public string GetTipo() {
         return Tipo_Animal;
      }
        public string GetCome() {
         return Ambiente_atributo;
      }
      public string GetTipo() {
         return Tipo_Animal;
      }
      public string GetRaza() {
      return Raza_atributo;
      }

      public string GetVacuna()
      {
      return Vacuna_atributo;
      }


        public string GetTipo()
        {
            return Tipo_Animal;
        }







        public void SetNombre(string NombreParam) {

         Nombre=NombreParam;
      }
      public string GetNombre()
      {
         return Nombre;
      }


      //Tarea....
      //Los tipos de datos en C#
   }



   //Clase principal , la que va ejecutar el metodo MAIN, para iniciar el programa.
   class Program
   {
      static void Main(string[] args)
      {
         //Instancia de la clase
         Animal AnimalPerro = new Animal();
         //En la instancia hago uso de los metodos, para acceder a sus atributos.
         Console.WriteLine("¿Qué tipo de anima es: ?");
         AnimalPerro.SetTipo(Console.ReadLine());
         AnimalPerro.Respira();
         Console.WriteLine("¿Qué come tu animal?");
         AnimalPerro.SetCome(Console.ReadLine());
         Console.WriteLine("¿Qué raza es tu perro?");
         AnimalPerro.SetCome(Console.ReadLine());
         Console.WriteLine("¿Tú perro tiene toda sus vacunas?");
         AnimalPerro.SetCome(Console.ReadLine());

            Console.WriteLine("¿Cómo se llama el "+AnimalPerro.GetTipo() +"?");
         //ReadLine Lee la linea para la entrada del usuario.
         AnimalPerro.SetNombre( Console.ReadLine());

         
         
         //Escribe en pantalla el mensaje con un salto de linea.
         Console.WriteLine("Mi animal es: " +AnimalPerro.GetTipo());
         Console.WriteLine("¿Qué comio?, El "+ AnimalPerro.GetTipo() + " Comio: " + AnimalPerro.GetCome());
         Console.WriteLine("El perro se llama: " + AnimalPerro.GetNombre());
         Console.WriteLine("El perro es de raza: " + AnimalPerro.GetNombre());
         Console.WriteLine("El perro tiene sus vacunas: " + AnimalPerro.GetNombre());
         Console.ReadKey();
      }
   }
}
