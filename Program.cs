using System;
namespace acfour_alejandro_martin
{
    public class Implementacio
    {
        public static void Main()
        {
            const string MSG1 = "Inserta el numero de numeros que vols insertar";
            const string MSG2 = "Inserta el {0} numero:";
            const string Error = "Error";
            int numDeInputs = 0;
            do
            {
                Console.WriteLine(MSG1);
                numDeInputs = Convert.ToInt32(Console.ReadLine());
            } while (numDeInputs <= 0);
            int[] userNums = new int[numDeInputs];
            try
            {
                for (int i = 0; i < userNums.Length; i++) {
                    Console.WriteLine(MSG2);
                    userNums(i) = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (FormatException) {
                Console.WriteLine(Error);
            } 
        }
    }
}
