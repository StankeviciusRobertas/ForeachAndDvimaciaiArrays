namespace ForeachAndDvimaciaiArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string[] autos = new string[] { "BMW", "Audi", "Toyota" };

            //Console.WriteLine("Printing cars using for loop: ");

            //for (int i = 0; i < autos.Length; i++)
            //{
            //    Console.WriteLine(autos[i]);
            //}

            //Console.WriteLine("Printing cars using Foreach loop; ");

            //foreach (string auto in autos)
            //{
            //    Console.WriteLine(auto);
            //}

            //double[] array = { -2, -3, -4, -3 };
            //double result = calculateAverage(array);
            //Console.WriteLine(result);

            //////////////////////////////////////////////////////////////

            //int[] ints = { 2, -7, 4, -3, 5 };
            //int[] result = returnPositiveNumber(ints);
            ////int positiveNumber = 0;

            //foreach (int i in result)
            //{                
            //    Console.WriteLine(i);                
            //}

            /////////////////////////////////////////////////////////////////

            //int[] payments = { 200, 500, -1000, -400, 300 };
            //int total = calculateGPM(payments);

            //Console.WriteLine($"Grazintina suma {total}");

            ////////////////////////////////////////////////////////////////

            //string sentence = "Mes visi kartu eisim ir rinksim grybus";
            //string[] LongerWords = GetLongerWord(sentence);

            //foreach (string word in LongerWords)
            //{
            //    Console.WriteLine(word);
            //}

            ////////////////////////////////////////////////////////////////

            string[] types = { "Bugnu", "Vynu", "Kryziu", "Sirdziu" };
            string[] cards = { "Vienetas", "Dvejetas", "Trejetas", "Ketvertas", "Penketas", "Sesetas", "Septynetas", "Astuonetas", "Devynetas", "Desimt", "Valetas", "Dama", "Karalius", "Tuzas" };

            string[] cardsDeck = ConstructDeck(types, cards);
            ConstrucktedCardPrint(cardsDeck);
         }

        public static void ConstrucktedCardPrint(string[] cardsDeck)
        {
            foreach (string type in cardsDeck)
            {
                Console.WriteLine(type);
            }
        }
        public static string[] ConstructDeck(string[] types, string[] cards)
        {
            string[] ConcatinatedType = new string[cards.Length * types.Length];
            int index = 0;
            foreach (string type in types)
            {
                foreach (string card in cards)
                {
                    ConcatinatedType[index++] = type + " " + card;
                }
            }
            return ConcatinatedType;
        }
        public static string[] GetLongerWord(string sentence)
        {
            string[] words = sentence.Split(" ");
            string[] result = new string[words.Length];
            int index = 0;

            foreach (string word in words)
            {
                if (word.Length >= 5)
                {
                    result[index++] = word;
                }
            }
            return result;
        }
        public static int calculateGPM(int[] payments)
        {
            int sumOfPayments = 0;
            int percentComplete = 0;
            foreach (int pays in payments)
            {

                sumOfPayments += pays;
                //return sumOfPayments;
                percentComplete = (sumOfPayments * 15) / 100;
            }
            return percentComplete;
        }
        public static int[] returnPositiveNumber(int[] ints)
        {
            int[] positiveNumber = new int[5];
            int resultInt = 0;
            foreach (int number in ints)
            {

                if (number > 0)
                {
                    positiveNumber[resultInt] = number;
                    resultInt++;
                }
            }
            return positiveNumber;
        }
        public static double calculateAverage(double[] array)
        {
            double sum = 0;
            foreach (double item in array)
            {
                sum += item;
            }
            return sum / array.Length;
        }
    }
} 