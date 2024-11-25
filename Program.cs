using System;
namespace acfour_alejandro_martin
{
    public class Implementacio
    {
        public static void Main()
        {
            const string MSG1 = "Inserta el numero de numeros que vols insertar";
            const string MSG2 = "Inserta el {0} numero:";
            const string MSG3 = "Els teus numeros ordenats descendentment:";
            const string Error = "Error";
            int numDeInputs = 0;
            try
            {
                do
                {
                    Console.WriteLine(MSG1);
                    numDeInputs = Convert.ToInt32(Console.ReadLine());
                } while (numDeInputs <= 0);
                int[] userNums = new int[numDeInputs];
                for (int i = 0; i < userNums.Length; i++) {
                    Console.WriteLine(MSG2, i);
                    userNums[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int j = 0; j < userNums.Length - 1; j++)
                {
                    for (int i = j + 1; i < userNums.Length; i++)
                    {
                        if (userNums[i] > userNums[j])
                        {
                            int canvi = userNums[j];
                            userNums[j] = userNums[i];
                            userNums[i] = canvi;
                        }
                    }
                }
                Console.WriteLine(MSG3);
                for (int i = 0; i < userNums.Length; i++)
                {
                    Console.WriteLine(userNums[i]);
                }
            }
            catch (FormatException) {
                Console.WriteLine(Error);
            } 
        }
    }
}
