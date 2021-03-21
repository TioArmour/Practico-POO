using System;

namespace Contador
{
    class Contador
    {
        private int valor;

        //Constructor copia
        public Contador(Contador contador)
        {
            valor = contador.valor;
        }

        //Constructor por defecto
        public Contador()
        {
            valor = 0;
        }

        //Constructor con parametros
        public Contador(int valor_contador)
        {
            valor = valor_contador;
        }

        //Setter
        public void setValorContador(int valor_contador)
        {
            valor = valor_contador;
        }

        //Getter
        public string getValorContador()
        {
            return "El valor del contador es: " + valor;
        }
        
        static void Main(String[] args)
        {
            Contador MiContador = new Contador();
            int valor;
            string Respuesta;

            Console.WriteLine("Bienvenido!");
            Console.WriteLine();
            Console.Write("¿Quieres introducir el valor de tu contador? (Si/No): ");
            Respuesta = Console.ReadLine().ToLower();
            if (Respuesta == "si")
            {
                Console.Write("Introduce el valor del contador: ");
                valor = Int32.Parse(Console.ReadLine());
                MiContador.setValorContador(valor);
                Console.WriteLine("El nuevo valor de tu contador es: " + MiContador.getValorContador());
            }
            else
            {
                Console.WriteLine("El valor de tu contador es: " + MiContador.getValorContador());
            }

            Contador ContadorCopia = new Contador(MiContador);
            Console.WriteLine("El valor del contador copia es: " + ContadorCopia.getValorContador());
        }
    }

}
