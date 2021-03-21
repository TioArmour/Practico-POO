using System;

namespace Cuenta
{
    class Cuenta
    {
        private long numero_cuenta;
        private double saldo_cuenta;

        //Constructor copia
        public Cuenta(Cuenta cuenta)
        {
            numero_cuenta = cuenta.numero_cuenta;
            saldo_cuenta = cuenta.saldo_cuenta;
        }

        //Constructor por defecto
        public Cuenta()
        {
            numero_cuenta = 0;
            saldo_cuenta = 0;
        }

        //Constructores con parametros
        public Cuenta(long cuenta, double saldo)
        {
            numero_cuenta = cuenta;
            saldo_cuenta = saldo;
        }

        //Setter
        public void setNumeroCuenta(long cuenta)
        {
            numero_cuenta = cuenta;
        }

        public void setSaldoCuenta(double saldo)
        {
            saldo_cuenta = saldo;
        }

        //Getter
        public string getNumeroCuenta()
        {
            return "Su numero de cuenta es: " + numero_cuenta;
        }

        public string getSaldoCuenta()
        {
            return "El saldo de su cuenta es: " + saldo_cuenta + "Bs";
        }

        //Metodos
        public void IngresarDinero(double monto)
        {
            saldo_cuenta += monto;
        }

        public void Transferencia(double monto)
        {
            saldo_cuenta -= monto;
        }

        public void Reintegro(double monto)
        {
            saldo_cuenta += monto;
        }

        static void Main(String[] args)
        {
            long NumeroCuenta;
            double SaldoCuenta;
            double Monto;
            string Respuesta;

            Console.WriteLine("Bienvenido");
            Cuenta MiCuenta = new Cuenta();
            Console.Write("Introduzca su numero de cuenta bancaria: ");
            NumeroCuenta = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            MiCuenta.setNumeroCuenta(NumeroCuenta);
            Console.Write("Introduzca el saldo de su cuenta:");
            SaldoCuenta = float.Parse(Console.ReadLine());
            MiCuenta.setSaldoCuenta(SaldoCuenta);
            Console.WriteLine();
            Console.Write("¿Que operacion desea realizar? Introduzca I(Ingreso), T(Transferencia) o R(Reintegro): ");
            Respuesta = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (Respuesta == "i")
            {
                Console.Write("Ingresa el monto de dinero en bolivianos: ");
                Monto = float.Parse(Console.ReadLine());
                MiCuenta.IngresarDinero(Monto);
                Console.WriteLine(MiCuenta.getSaldoCuenta());
            }
            else
            {
                if (Respuesta == "t")
                {
                    Console.Write("Ingrese el numero de cuenta a donde ira el dinero: ");
                    NumeroCuenta = Int32.Parse(Console.ReadLine());
                    Cuenta Cuenta1 = new Cuenta();
                    Cuenta1.setNumeroCuenta(NumeroCuenta);
                    Console.WriteLine();

                    Console.Write("Ingrese el monto en bolivianos a transferir: ");
                    Monto = float.Parse(Console.ReadLine());
                    MiCuenta.Transferencia(Monto);
                    Cuenta1.IngresarDinero(Monto);
                    Console.WriteLine(MiCuenta.getSaldoCuenta());
                }
                else
                {
                    if (Respuesta == "r")
                    {
                        Console.Write("Ingrese el monto del reintegro");
                        Monto = float.Parse(Console.ReadLine());
                        MiCuenta.Reintegro(Monto);
                        Console.WriteLine(MiCuenta.getSaldoCuenta());
                    }
                    else
                    {
                        Console.WriteLine("No existe la operacion que desea realizar");
                        Console.ReadKey();
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Instanciamos un nuevo objeto con el constructor copia");
            Cuenta CuentaCopia = new Cuenta(MiCuenta);
            Console.WriteLine("El saldo de la cuenta copia es: " + CuentaCopia.saldo_cuenta + "Bs.");
            Console.WriteLine(CuentaCopia.getNumeroCuenta());
        }

    }
}
