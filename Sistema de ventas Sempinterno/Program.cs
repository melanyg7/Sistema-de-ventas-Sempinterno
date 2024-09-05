using System;

class Sempinterno
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("//// Bienvenido al Sistema de Ventas Sempinterno ////");
            Console.Write(" Favor Ingresar Su Nombre:");
            string nombre = Console.ReadLine();
            Console.Write(" Favor Ingresar Su Edad:");
            string edad = Console.ReadLine();

            Console.WriteLine("///Elija Su Genero Literario Favorito///");
            Console.WriteLine("1. Romance...");
            Console.WriteLine("2. Ficcion...");
            Console.WriteLine("3. Comedia...");
            Console.WriteLine("4. Terror...");
            Console.WriteLine("5. Fantasia...");
            Console.WriteLine("6. Clasicos...");
            Console.WriteLine("7. Salir...");
            Console.WriteLine("==============");
            Console.WriteLine("Seleccione una opcion ");
            string categoria = Console.ReadLine();
            double precio = 0;
            double Impuesto = 0;
            double descuento = 0;
            int cantidad = 0;
            double totalCompra = 0;

            if (categoria == "1")
            {
                Console.WriteLine("-- Romance --");
                Console.WriteLine("1. Orgullo y Prejuicio 400Lps..");
                Console.WriteLine("2. Nosotros en la Luna 450Lps..");
                Console.WriteLine("3. Sigue Mi Voz 450Lps..");
                Console.WriteLine("4. El Perfume Del Rey 500Lps..");
                Console.WriteLine("5. Irresistible Error 500Lps..");
                Impuesto = 0.04;
            }
            else if (categoria == "2")
            {
                Console.WriteLine("-- Ficcion --");
                Console.WriteLine("1. El Nuevo Mundo 450Lps..");
                Console.WriteLine("2. La Revelacion 450Lps..");
                Console.WriteLine("3. Almas Perdidas 480Lps..");
                Console.WriteLine("4. Damian 500Lps..");
                Console.WriteLine("5. La Reyna de las Espinas 500Lps..");
                Impuesto = 0.12;
            }
            else if (categoria == "3")
            {
                Console.WriteLine("-- Comedia --");
                Console.WriteLine("1. El elevador del Central Park 380Lps..");
                Console.WriteLine("2. Una Perfecta Confusion 400Lps..");
                Console.WriteLine("3. Un Demonio entre Recetas 450Lps..");
                Console.WriteLine("4. Reunion de Familia 390Lps..");
                Console.WriteLine("5. Si me dices que No 400Lps..");
                Impuesto = 0.06;
            }
            else if (categoria == "4")
            {
                Console.WriteLine("-- Terror --");
                Console.WriteLine("1. Cazador de Sombras 500Lps..");
                Console.WriteLine("2. Relatos de la Noche 350Lps..");
                Console.WriteLine("3. La Chica de al lado 300Lps..");
                Console.WriteLine("4. Suspiros Robados 450Lps..");
                Console.WriteLine("5. HEX 400Lps..");
                Impuesto = 0.12;
            }
            else if (categoria == "5")
            {
                Console.WriteLine("-- Fantasia --");
                Console.WriteLine("1. El señor de los anillos 450Lps..");
                Console.WriteLine("2. Alas de Sangre 600Lps..");
                Console.WriteLine("3. Harry Potter");
                Console.WriteLine("4. Los Recuerdos Robados 400Lps..");
                Console.WriteLine("5. Strange 500Lps..");
                Impuesto = 0.18;
            }
            else if (categoria == "6")
            {
                Console.WriteLine("-- Clasicos --");
                Console.WriteLine("1. Crimen y Castigo 300Lps..");
                Console.WriteLine("2. El retrato de Dorian Gray 400Lps..");
                Console.WriteLine("3. Los Miserables 400Lps..");
                Console.WriteLine("4. La Odisea 400Lps..");
                Console.WriteLine("5. Mujercitas 400Lps..");
                Impuesto = 0.03;
            }
            else if (categoria == "7")
            {
                continuar = false;
                Console.WriteLine("Gracias por usar el sistema de ventas Sempinterno LVY :) ");
                break;
            }
            else
            {
                Console.WriteLine("Opción no valida, favor intente mas tarde ;) ");
                continue;
            }

            if (categoria == "7")
                break;

            Console.WriteLine("Seleccione un producto: ");
            int producto = Convert.ToInt32(Console.ReadLine());

            if (producto == 1)
                precio = 400;
            else if (producto == 2)
                precio = 450;
            else if (producto == 3)
                precio = 450;
            else if (producto == 4)
                precio = 500;
            else if (producto == 5)
                precio = 500;
            else
            {
                Console.WriteLine("Lo sentimos, no tenemos el libro seleccionado. Intente de nuevo...");
                continue;
            }

            Console.WriteLine($"El precio del libro seleccionado es: {precio} Lps");

            Console.WriteLine("Ingrese la cantidad (maximo 100): ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            if (cantidad <= 0 || cantidad > 100)
            {
                Console.WriteLine("Cantidad no valida, favor intente de nuevo.");
                continue;
            }

            if (cantidad >= 10 && cantidad <= 50)
                descuento = 0.15;
            else if (cantidad > 50)
                descuento = 0.20;

            double subtotal = precio * cantidad;
            double totalDescuento = subtotal * descuento;
            double impuesto = subtotal * Impuesto;
            double total = subtotal - totalDescuento + impuesto;

            Console.WriteLine("El valor a pagar es de:" + total, "Usted esta pagando un impuesto de:" + impuesto, "Y un descuento de:" + descuento);
            Console.WriteLine($"El valor a pagar es de;); {total} Usted esta pagando un impuesto de: {impuesto} Y un descuento de: {descuento} ");

            totalCompra += total;

            continuar = false;
            Console.WriteLine($"Total de la compra: {totalCompra} Lps");
            Console.WriteLine("/// Gracias por su compra MY LOVE :) ///");

           
         }     
    }
}

