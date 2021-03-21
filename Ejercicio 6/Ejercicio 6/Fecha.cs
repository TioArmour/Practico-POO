using System;

namespace Fecha
{
    class Fecha
    {
        private int dia;
        private int mes;
        private int age;

        public Fecha()
        {
            dia = 0;
            mes = 0;
            age = 0;
        }

        public int setFecha(int Dia, int Mes, int Age)
        {
            dia = Dia;
            mes = Mes;
            age = Age;
        }

        public Boolean Validacion()
        {
            string CadenaFecha;
            CadenaFecha = mes.ToString() + "/" + dia.ToString() + "/" + age.ToString();
            Console.WriteLine(CadenaFecha);
            try
            {
                DateTime.Parse(CadenaFecha);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void setFechaSiguiente()
        {
            if (mes == 1 ^ mes == 3 ^ mes == 5 ^ mes == 7 ^ mes == 8 ^ mes == 10 ^ mes == 12)
            {
                if(dia >= 31)
                {
                    dia = 1;
                    if(mes >= 12)
                    {
                        mes = 1;
                        age = age + 1;
                    }
                    else
                    {
                        mes = mes + 1;
                    }
                }
                else
                {
                    if(dia > 0)
                    {
                        dia = dia + 1;
                    }
                }
            }
            else
            {
                if(mes == 2)
                {
                    if ((age % 4 == 0 && age % 100 != 0 ) ^ age % 400 == 0)
                    {
                        if (dia >= 29)
                        {
                            dia = 1;
                            if(mes >= 12)
                            {
                                mes =1;
                                age = age + 1;
                            }
                            else
                            {
                                mes = mes + 1;
                            }
                        }
                        else
                        {
                            dia = dia + 1;
                        }
                    }
                    else
                    {
                        if(dia >= 28)
                        {
                            dia = 1;
                            if(mes >= 12)
                            {
                                mes = 1;
                                age = age + 1;
                            }
                            else
                            {
                                mes = mes + 1;
                            }
                        }
                    }
                }
                else
                {
                    if (mes == 4 ^ mes == 6 ^ mes == 9 ^ mes == 11)
                    {
                        if(dia > 30)
                        {
                            dia = 1;
                            mes = mes + 1;
                        }
                        else
                        {
                            dia = dia + 1;
                        }
                    }
                }
            }
            Console.WriteLine("La nueva fecha es: " + mes.ToString() + "/" + dia.ToString() + "/" + age.ToString());
        }

        static void Main(String[] args)
        {
            int Dia;
            int Mes;
            int Age;
            Console.WriteLine("Introduce una fecha en el siguiente formato (MM/DD/AAAA)");
            Console.Write("Introduce MM: ");
            Mes = Int32.Parse(Console.ReadLine());
            Console.Write("Introduce DD: ");
            Dia = Int32.Parse(Console.ReadLine());
            Console.Write("Introduce AA: ");
            Age = Int32.Parse(Console.ReadLine());

            Fecha NuevaFecha = new Fecha();
            NuevaFecha.setFecha(Dia, Mes, Age);

            if (NuevaFecha.Validacion())
            {
                Console.WriteLine("La fecha introducida es correcta.");
            }
            else
            {
                Console.WriteLine("La fecha introducida es incorrecta.");
            }
            NuevaFecha.setFechaSiguiente();
            Console.ReadKey();
        }



    }
}
