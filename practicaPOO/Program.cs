using System;

namespace practicaPOO
{
    class cuentaBancaria
    {
        static void Main(string[] args)
        {
           
            cuenta[] cuentas = new cuenta[4];

            cuentas[1].Titular = "Javier Miras";
            cuentas[1].NumeroCuenta = 1;
            cuentas[1].Saldo = 100.00;

            cuentas[2].Titular = "José Pérez";
            cuentas[2].NumeroCuenta = 2;
            cuentas[2].Saldo = 50.00;

            cuentas[3].Titular = "Andrés Picó";
            cuentas[3].NumeroCuenta = 3;
            cuentas[3].Saldo = 20.00;

            Console.WriteLine("Identifícate, introduce tu número de cuenta");
            int identificacion;
            try
            {
                switch (identificacion = int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine($"Hola {cuentas[identificacion].Titular}, bienvenido");
                        break;
                    case 2:
                        Console.WriteLine($"Hola {cuentas[identificacion].Titular}, bienvenido");
                        break;
                    case 3:
                        Console.WriteLine($"Hola {cuentas[identificacion].Titular}, bienvenido");
                        break;
                    default:
                        Console.WriteLine("Numero de cuenta incorrecto");
                        break;
                }

                Console.WriteLine("¿Qué operacion deseas realizar?");
                Console.WriteLine("Ingresar / Retirar / Consultar / Informar");
               

                try
                {
                    switch (Console.ReadLine())
                    {
                        case "Ingresar":
                            Console.WriteLine("¿Cuanto dinero deseas ingresar?");
                            cuentas[identificacion].Saldo=ingresar(double.Parse(Console.ReadLine()));
                            Console.WriteLine("El nuevo saldo es de: " + cuentas[identificacion].Saldo + " euros");
                            break;

                        case "Retirar":
                            Console.WriteLine("¿Cuanto dinero deseas retirar?");
                            cuentas[identificacion].Saldo = retirar(double.Parse(Console.ReadLine()));                            
                            Console.WriteLine("El nuevo saldo es de: " + cuentas[identificacion].Saldo + " euros");
                            break;

                        case "Consultar":
                            Console.WriteLine("El saldo actual de la cuenta es de: " + consultar() + " euros"); ;
                            break;

                        case "Informar":
                            informar();
                            break;

                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;

                    }

                    double ingresar(double ingreso)
                    {
                        double total = (ingreso + cuentas[identificacion].Saldo);
                        return total;
                    }
                    double retirar(double retiro)
                    {
                        double total = (cuentas[identificacion].Saldo - retiro);
                        return total;
                    }
                    double consultar() {return cuentas[identificacion].Saldo;
                    }

                    void informar() {
                        Console.WriteLine("Estos son los datos de tu cuenta");
                        Console.WriteLine("Nombre del titular: " + cuentas[identificacion].Titular);
                        Console.WriteLine("Número de cuenta: " + cuentas[identificacion].NumeroCuenta);
                        Console.WriteLine("Saldo de la cuenta: " + cuentas[identificacion].Saldo + " euros");
                    }

                }
                catch(Exception e) {
                    Console.WriteLine("Error al introducir la operación, revisa bien el texto introducido");
                    Console.WriteLine("Más detalles: " + e.Message);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la identificación");
                Console.WriteLine("Más detalles: " + e.Message);
            }



        }
        public struct cuenta
        {
            public string Titular;
            public int NumeroCuenta;
            public double Saldo;
        }






    }
    
}
