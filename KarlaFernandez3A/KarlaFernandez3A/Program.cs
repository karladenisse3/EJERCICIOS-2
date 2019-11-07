using System;

namespace KarlaFernandez3A
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            int op = 0;

            NodoPilaCola pilacola = null;

            Console.WriteLine("Escoja La estructura de datos a usar\n"
                        + "(1) Pila  \n"
                        + "(2) Cola \n" );
                         int  op0 = int.Parse(Console.ReadLine());
           


            do
            {
               Console.WriteLine("Ingrese opción \n"
                        + "(1) Crear  \n"
                        + "(2) Apilar - Encolar \n" +
                        "(3) Desapilar - Desencolar\n" +
                        "(4) Cima\n" +
                        "(5) Preguntar si la estructura de datos esta vacia \n" +
                        "(6) Imprimir Toda La estructura de datos \n" +
                        "(7) Salir \n");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        pilacola = NodoPilaCola.Crear(pilacola);
                        break;
                    case 2:
                        pilacola = NodoPilaCola.APilarEncolar(pilacola);
                        break;
                    case 3:
                        pilacola = NodoPilaCola.DesapilarDesencolar(pilacola, op0);
                        break;
                    case 4:
                        NodoPilaCola.ImprimirCima(pilacola);
                        break;
                    case 5:
                        NodoPilaCola.estaVacia(pilacola);
                        break;
                    case 6:
                        NodoPilaCola.Imprimir(pilacola);
                        break;

                }
            } while (op != 7);

        }

    }
}
    