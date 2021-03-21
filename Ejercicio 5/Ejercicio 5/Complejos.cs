using System;

namespace Complejos
{
    class Complejos
    {
        private double ParteReal;
        private double ParteImaginaria;
        
        public Complejos()
        {
            ParteReal = 0;
            ParteImaginaria = 0;
        }

        public Complejos(double Real, double Imaginaria)
        {
            ParteReal = Real;
            ParteImaginaria = Imaginaria;
        }

        public void Sumar(Complejos Complejo1, Complejos Complejo2)
        {
            double SumaReal = Complejo1.ParteReal + Complejo2.ParteReal;
            double SumaImaginaria = Complejo1.ParteImaginaria + Complejo2.ParteImaginaria;
            if (SumaImaginaria > 0)
            {
                Console.WriteLine("La suma de los numeros complejos es: " + SumaReal + " + " + SumaImaginaria  + "i");
            }
            else
            {
                
                Console.WriteLine("La suma de los numeros complejos es: " + SumaReal +" - "+ Math.Abs(SumaImaginaria)  + "i");
            }
        }

        public void Restar(Complejos Complejo1, Complejos Complejo2)
        {
            double SumaReal = Complejo1.ParteReal - Complejo2.ParteReal;
            double SumaImaginaria = Complejo1.ParteImaginaria - Complejo2.ParteImaginaria;
            if (SumaImaginaria > 0)
            {
                Console.WriteLine("La resta de los numeros complejos es: " + SumaReal + " + " + SumaImaginaria);
            }
            else
            {

                Console.WriteLine("La resta de los numeros complejos es: " + SumaReal + " - " + Math.Abs(SumaImaginaria) + "i");
            }
        }

        public void Multiplicar(Complejos Complejo1, Complejos Complejo2)
        {
            /* Hallamos el modulo de los dos numeros complejos */
            double Modulo1 = Math.Sqrt(Math.Pow(Complejo1.ParteReal, 2) + Math.Pow(Complejo1.ParteImaginaria,2)); 
            double Modulo2 = Math.Sqrt(Math.Pow(Complejo2.ParteReal, 2) + Math.Pow(Complejo2.ParteImaginaria, 2));

            /* Hallamos el angulo de los numeros complejos, como el resultado sale en Radianes se lo convierte a sexagesimal */
            double Tan1 = Math.Atan(Complejo1.ParteImaginaria / Complejo1.ParteReal)*(180/Math.PI);
            double Tan2 = Math.Atan(Complejo2.ParteImaginaria / Complejo2.ParteReal)*(180/Math.PI);
            double Angulo1 = 0;
            double Angulo2 = 0;

            /* ? Se lleva el angulo obtenido anteriormente al siguiente rango (0° - 360°=) :   0° < angulo < 360° */
            if (Complejo1.ParteReal > 0 && Complejo1.ParteImaginaria > 0)
            {
                Angulo1 = Tan1;
            }
            else
            {
                if(Complejo1.ParteReal < 0 && Complejo1.ParteImaginaria > 0)
                {
                    Angulo1 = 180 + Tan1;
                }
                else
                {
                    if(Complejo1.ParteReal < 0 && Complejo1.ParteImaginaria < 0)
                    {
                        Angulo1 = 180 + Tan1;
                    }
                    else
                    {
                        if(Complejo1.ParteReal > 0 && Complejo1.ParteImaginaria < 0)
                        {
                            Angulo1 = 360 + Tan1;
                        }
                    }
                }
            }

            if (Complejo2.ParteReal > 0 && Complejo2.ParteImaginaria > 0)
            {
                Angulo2 = Tan2;
            }
            else
            {
                if (Complejo2.ParteReal < 0 && Complejo2.ParteImaginaria > 0)
                {
                    Angulo2 = 180 + Tan2;
                }
                else
                {
                    if (Complejo2.ParteReal < 0 && Complejo2.ParteImaginaria < 0)
                    {
                        Angulo2 = 180 + Tan2;
                    }
                    else
                    {
                        if (Complejo2.ParteReal > 0 && Complejo2.ParteImaginaria < 0)
                        {
                            Angulo2 = 360 + Tan2;
                            
                        }
                    }
                }
            }
    
            /* Hallamos el valor del modulo y el angulo resultante */
            double ModuloResultante = Modulo1 * Modulo2;
            double AnguloResultante = Angulo1 + Angulo2;

            /* Covertimos el AnguloResultante a Radianes para poder realizar el calculo */
            double AnguloCalculo = (AnguloResultante * Math.PI) / 180;
            
            /* Operacion Final para hallar el resultado de la parte real e imaginaria en forma binaria */
            decimal ResultadoReal = Math.Round(Convert.ToDecimal(ModuloResultante * Math.Cos(AnguloCalculo)),0);
            decimal ResultadoImaginario = Math.Round(Convert.ToDecimal(ModuloResultante * Math.Sin(AnguloCalculo)),0);
                        
            /* Mostramos el resultado por consola */
            if (ResultadoImaginario > 0)
            {
                Console.WriteLine("La multiplicacion de los numeros complejos es: " + ResultadoReal + " + " + ResultadoImaginario + "i");
            }
            else
            {

                Console.WriteLine("La multiplicacion de los numeros complejos es: " + ResultadoReal + " - " + Math.Abs(ResultadoImaginario) + "i");
            }

            Console.WriteLine("El resultado en la forma polar es : " + "Modulo --> " + Math.Round(Convert.ToDecimal(ModuloResultante), 2) + " ; Angulo --> " + Math.Round(Convert.ToDecimal(AnguloResultante), 2));
        }


        public void Dividir(Complejos Complejo1, Complejos Complejo2)
        {
            /* Hallamos el modulo de los dos numeros complejos */
            double Modulo1 = Math.Sqrt(Math.Pow(Complejo1.ParteReal, 2) + Math.Pow(Complejo1.ParteImaginaria, 2));
            double Modulo2 = Math.Sqrt(Math.Pow(Complejo2.ParteReal, 2) + Math.Pow(Complejo2.ParteImaginaria, 2));

            /* Hallamos el angulo de los numeros complejos, como el resultado sale en Radianes se lo convierte a sexagesimal */
            double Tan1 = Math.Atan(Complejo1.ParteImaginaria / Complejo1.ParteReal) * (180 / Math.PI);
            double Tan2 = Math.Atan(Complejo2.ParteImaginaria / Complejo2.ParteReal) * (180 / Math.PI);
            double Angulo1 = 0;
            double Angulo2 = 0;

            /* Se lleva el angulo obtenido anteriormente al siguiente rango (0° - 360°=) :   0° < angulo < 360° */
            if (Complejo1.ParteReal > 0 && Complejo1.ParteImaginaria > 0)
            {
                Angulo1 = Tan1;
            }
            else
            {
                if (Complejo1.ParteReal < 0 && Complejo1.ParteImaginaria > 0)
                {
                    Angulo1 = 180 + Tan1;
                }
                else
                {
                    if (Complejo1.ParteReal < 0 && Complejo1.ParteImaginaria < 0)
                    {
                        Angulo1 = 180 + Tan1;
                    }
                    else
                    {
                        if (Complejo1.ParteReal > 0 && Complejo1.ParteImaginaria < 0)
                        {
                            Angulo1 = 360 + Tan1;
                        }
                    }
                }
            }

            if (Complejo2.ParteReal > 0 && Complejo2.ParteImaginaria > 0)
            {
                Angulo2 = Tan2;
            }
            else
            {
                if (Complejo2.ParteReal < 0 && Complejo2.ParteImaginaria > 0)
                {
                    Angulo2 = 180 + Tan2;
                }
                else
                {
                    if (Complejo2.ParteReal < 0 && Complejo2.ParteImaginaria < 0)
                    {
                        Angulo2 = 180 + Tan2;
                    }
                    else
                    {
                        if (Complejo2.ParteReal > 0 && Complejo2.ParteImaginaria < 0)
                        {
                            Angulo2 = 360 + Tan2;

                        }
                    }
                }
            }

            /* Hallamos el valor del modulo y el angulo resultante */
            double ModuloResultante = Modulo1 / Modulo2;
            double AnguloResultante = Angulo1 - Angulo2;

            /* Covertimos el AnguloResultante a Radianes para poder realizar el calculo */
            double AnguloCalculo = (AnguloResultante * Math.PI) / 180;

            /* Operacion Final para hallar el resultado de la parte real e imaginaria en forma binaria */
            decimal ResultadoReal = Math.Round(Convert.ToDecimal(ModuloResultante * Math.Cos(AnguloCalculo)), 3);
            decimal ResultadoImaginario = Math.Round(Convert.ToDecimal(ModuloResultante * Math.Sin(AnguloCalculo)), 3);

            /* Mostramos el resultado por consola */
            if (ResultadoImaginario > 0)
            {
                Console.WriteLine("La division de los numeros complejos es: " + ResultadoReal + " + " + ResultadoImaginario + "i");
            }
            else
            {

                Console.WriteLine("La division de los numeros complejos es: " + ResultadoReal + " - " + Math.Abs(ResultadoImaginario) + "i");
            }

            Console.WriteLine("El resultado en la forma polar es : " + "Modulo --> " + Math.Round(Convert.ToDecimal(ModuloResultante), 2) + " ; Angulo --> " + Math.Round(Convert.ToDecimal(AnguloResultante), 2));
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Bienvenido!");
            Complejos Operaciones = new Complejos();
            Complejos ComplejoUno = new Complejos(6, 1);
            Complejos ComplejoDos = new Complejos(5.196, 3);
            Console.WriteLine();
            Operaciones.Sumar(ComplejoUno, ComplejoDos);
            Console.WriteLine();
            Operaciones.Restar(ComplejoUno, ComplejoDos);
            Console.WriteLine();
            Operaciones.Multiplicar(ComplejoUno, ComplejoDos);
            Console.WriteLine();
            Operaciones.Dividir(ComplejoUno, ComplejoDos);
        }
    }
}
