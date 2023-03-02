using System;

//Funciones
class Program
{      
    static void Main(){
    //Funcion para optimizar el metodo WriteLine
        void Write(string texto){
            Console.WriteLine("Hola {0}", texto);
        }

        Console.WriteLine("Escribe tu nombre: ");
        string name =  Console.ReadLine();
        Write(name);

    }
}