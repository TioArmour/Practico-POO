using System;

namespace Fraccion
{
    class Fraccion
    {
        private int numerador;
        private int denominador;

        public Fraccion()
        {
            numerador = 0;
            denominador = 0;
        }
        public Fraccion(int Numerador, int Denominador)
        {
            numerador = Numerador;
            denominador = Denominador;
        }

        public void Sumar(Fraccion Fraccion1, Fraccion Fraccion2)
        {
            int DenominadorTotal = Fraccion1.denominador * Fraccion2.denominador;
            int NumeradorTotal = Fraccion1.numerador * (DenominadorTotal / Fraccion1.denominador) 
                                 + Fraccion2.numerador * (DenominadorTotal / Fraccion2.denominador);
            Console.WriteLine("La suma de las fracciones es: " + NumeradorTotal + "/" + DenominadorTotal);
        }

        public void Restar(Fraccion Fraccion1, Fraccion Fraccion2)
        {
            int DenominadorTotal = Fraccion1.denominador * Fraccion2.denominador;
            int NumeradorTotal = Fraccion1.numerador * (DenominadorTotal / Fraccion1.denominador)
                                 - Fraccion2.numerador * (DenominadorTotal / Fraccion2.denominador);
            Console.WriteLine("La resta de las fracciones es: " + NumeradorTotal + "/" + DenominadorTotal);
        }

        public void Multiplicar(Fraccion Fraccion1, Fraccion Fraccion2)
        {
            int DenominadorTotal = Fraccion1.denominador * Fraccion2.denominador;
            int NumeradorTotal = Fraccion1.numerador * Fraccion2.numerador;
            Console.WriteLine("La multiplicacion de las fracciones es: " + NumeradorTotal + "/" + DenominadorTotal);
        }

        public void Dividir(Fraccion Fraccion1, Fraccion Fraccion2)
        {
            int NumeradorTotal = Fraccion1.numerador * Fraccion2.denominador;
            int DenominadorTotal = Fraccion1.denominador * Fraccion2.numerador;
            Console.WriteLine("La division de las fracciones es: " + NumeradorTotal + "/" + DenominadorTotal);
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Bienvenido!");
            Console.WriteLine("Realizaremos operaciones aritmeticas con fracciones.");
            Console.WriteLine();
            Fraccion Operaciones = new Fraccion();
            Fraccion FraccionUno = new Fraccion(5, 9);
            Fraccion FraccionDos = new Fraccion(4, 7);
            Console.WriteLine("Si las fraciones son: " + FraccionUno.numerador + "/" + FraccionUno.denominador  + " y "
                              + FraccionDos.numerador + "/" + FraccionDos.denominador);
            Console.WriteLine();
            Operaciones.Sumar(FraccionUno, FraccionDos);
            Console.WriteLine();
            Operaciones.Restar(FraccionUno, FraccionDos);
            Console.WriteLine();
            Operaciones.Multiplicar(FraccionUno, FraccionDos);
            Console.WriteLine();
            Operaciones.Dividir(FraccionUno, FraccionDos);
            Console.ReadKey();


        }
    }
}
