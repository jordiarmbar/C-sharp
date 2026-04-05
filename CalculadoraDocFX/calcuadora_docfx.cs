using System;

namespace CalculadoraDocFX
{
    /// <summary>
    /// Proporciona una implementación robusta de operaciones aritméticas básicas y avanzadas.
    /// Esta clase sirve como núcleo lógico para una aplicación de consola interactiva, 
    /// garantizando la validación de datos y el manejo de excepciones matemáticas.
    /// </summary>
    public class Calculadora
    {
        static void Main(string[] args)
        {
            int numero1 = LeerNumero("Escriba el primer número: ");
            int numero2 = LeerNumero("Escriba el segundo número: ");
            int opcion = 0;

            do
            {
                Console.WriteLine("\n~~~ Menú de la Calculadora ~~~");
                Console.WriteLine("1.- Sumar\n2.- Restar\n3.- Multiplicar\n4.- Dividir\n5.- Potencia\n6.- Raíz Cuadrada\n7.- Salir");

                Console.Write("Selecciona una opción: ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion, numero1, numero2);
                }
            } while (opcion != 7);
        }

        /// <summary>
        /// Solicita la entrada de un número entero por consola y valida que el formato sea correcto.
        /// </summary>
        /// <param name="mensaje">Cadena de texto que se muestra al usuario como instrucción.</param>
        /// <returns>El valor entero procesado tras una validación exitosa.</returns>
        private static int LeerNumero(string mensaje)
        {
            int numero;
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out numero)) return numero;
                Console.WriteLine("Error: El valor introducido no es un número entero válido.");
            }
        }

        private static void ProcesarOpcion(int opcion, int n1, int n2)
        {
            switch (opcion)
            {
                case 1: Console.WriteLine("Resultado: " + Sumar(n1, n2)); break;
                case 2: Console.WriteLine("Resultado: " + Restar(n1, n2)); break;
                case 3: Console.WriteLine("Resultado: " + Multiplicacion(n1, n2)); break;
                case 4:
                    double div = Division(n1, n2);
                    if (!double.IsNaN(div)) Console.WriteLine("Resultado: " + div);
                    break;
                case 5: Console.WriteLine("Resultado: " + Potencia(n1, n2)); break;
                case 6:
                    double raiz = RaizCuadrada(n1);
                    if (!double.IsNaN(raiz)) Console.WriteLine("Resultado: " + raiz);
                    break;
            }
        }

        /// <summary>
        /// Realiza la operación aritmética de adición entre dos operandos enteros.
        /// </summary>
        /// <param name="numero1">Primer valor entero (sumando).</param>
        /// <param name="numero2">Segundo valor entero (sumando).</param>
        /// <returns>La suma aritmética de ambos parámetros.</returns>
        public static int Sumar(int numero1, int numero2) => numero1 + numero2;

        /// <summary>
        /// Realiza la operación de sustracción entre dos números enteros.
        /// </summary>
        /// <param name="numero1">Valor inicial (minuendo).</param>
        /// <param name="numero2">Valor a restar (sustraendo).</param>
        /// <returns>La diferencia resultante entre numero1 y numero2.</returns>
        public static int Restar(int numero1, int numero2) => numero1 - numero2;

        /// <summary>
        /// Calcula el producto escalar de dos factores enteros.
        /// </summary>
        /// <param name="numero1">Primer factor de la multiplicación.</param>
        /// <param name="numero2">Segundo factor de la multiplicación.</param>
        /// <returns>El producto total de la operación.</returns>
        public static int Multiplicacion(int numero1, int numero2) => numero1 * numero2;

        /// <summary>
        /// Ejecuta la división racional de dos números. Implementa una guarda de seguridad para evitar la división por cero.
        /// </summary>
        /// <param name="numero1">El valor que será dividido (dividendo).</param>
        /// <param name="numero2">El divisor. No debe ser igual a cero.</param>
        /// <returns>El cociente de la división. Si el divisor es 0, retorna NaN.</returns>
        public static double Division(int numero1, int numero2)
        {
            if (numero2 == 0) { Console.WriteLine("Error crítico: No se permite la división por cero."); return double.NaN; }
            return (double)numero1 / numero2;
        }

        /// <summary>
        /// Eleva un número base a la potencia de un exponente determinado utilizando funciones matemáticas de precisión.
        /// </summary>
        /// <param name="numero1">La base de la potencia.</param>
        /// <param name="numero2">El exponente al que se elevará la base.</param>
        /// <returns>El resultado de la potenciación como un valor de punto flotante.</returns>
        public static double Potencia(int numero1, int numero2) => Math.Pow(numero1, numero2);

        /// <summary>
        /// Calcula la raíz cuadrada principal de un número entero. Valida que el radicando sea un valor no negativo.
        /// </summary>
        /// <param name="numero1">El radicando de la operación. Debe ser mayor o igual a cero.</param>
        /// <returns>La raíz cuadrada del número. Si el valor es negativo, retorna NaN.</returns>
        public static double RaizCuadrada(int numero1)
        {
            if (numero1 < 0) { Console.WriteLine("Error matemático: No se puede calcular la raíz cuadrada de un número negativo."); return double.NaN; }
            return Math.Sqrt(numero1);
        }
    }
}