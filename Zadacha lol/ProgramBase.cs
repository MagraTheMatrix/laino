namespace Zadacha_lol
{
    internal class ProgramBase
    {
        static bool Main(int n)
        {

            n = int.Parse(Console.ReadLine());

            if (n <= 1)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;

                return true;

            }
        }
    }
}