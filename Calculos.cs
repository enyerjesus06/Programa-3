



    public class Calculos
    {
        public void Dosenteros()
        {
            //Declarar la variable NumEntero, linea//

                int NumEntero = 0;
                string linea = string.Empty;
            

                // Pedir al usuario que ingrese un número
                Console.WriteLine("Ingresen un número positivo de uno o dos dígitos");

                linea = Console.ReadLine();
                NumEntero = Convert.ToInt32(linea);
               


                // Verificar si el número tiene uno o dos dígitos
                if (NumEntero >= 1 && NumEntero <= 9)
                {
                    Console.WriteLine("Este número tiene un dígito.");
                }
                else if (NumEntero >= 10 && NumEntero <= 99)
                {
                    Console.WriteLine("Este número tiene dos dígitos.");
                }
                else
                {
                    Console.WriteLine("El número que ingresaste no es válido para que sea valido debe estar entre 1 y 99.");
                }
            

        }
        

    }

