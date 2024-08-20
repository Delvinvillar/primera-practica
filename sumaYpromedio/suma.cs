

namespace sumaYpromedio
{
    public class suma
    {
        public void promedio()
        {
            decimal num = 0;
            decimal num1 = 0;
            decimal num2 = 0;
            decimal num3 = 0;
            decimal total = 0;
            decimal promedio = 0;
            try
            {
                Console.WriteLine("ingrese el primer valor ");
                num = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("ingrese el segundo  valor ");
                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("ingrese el tecer valor ");
                num2 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("ingrese el cuarto valor ");
                num3 = Convert.ToDecimal(Console.ReadLine());

                total = num + num1 + num2 + num3;
                promedio = (num + num1 + num2 + num3) / 4;
                Console.WriteLine($"la suma es :{total} y el promedio es :{promedio}");



            }
            catch (OverflowException)
            {
                Console.WriteLine("el numero que usted ingreso es demaciado grande");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"hay un error :{ex.Message}");
            }

        }
    }
}
