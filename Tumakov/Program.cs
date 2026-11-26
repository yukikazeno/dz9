namespace Tumakov
{
    internal class Program
    {
        static void Task1()
        {
            string exampleText = "Wonderful, isn't it?";
            ACipher aCipher = new ACipher();
            string encodedText = aCipher.Encode(exampleText, 0);
            string decodedText = aCipher.Decode(encodedText, 0);
            Console.WriteLine($"Original: {exampleText}");
            Console.WriteLine($"Encoded: {encodedText}");
            Console.WriteLine($"Decoded: {decodedText}\n");

            BCipher bCipher = new BCipher();
            string bEncodedText = bCipher.Encode(exampleText, 0);
            string bDecodedText = bCipher.Decode(bEncodedText, 0);
            Console.WriteLine($"Original: {exampleText}");
            Console.WriteLine($"Encoded: {bEncodedText}");
            Console.WriteLine($"Decoded: {bDecodedText}");
        }

        static void Task2()
        {
            Rectangle rect = new Rectangle(5.0, 3.0);
            rect.PrintInfo();
            rect.MoveHorizontal(-2.0);
            rect.MoveVertical(4.0);
            rect.ChangeColor("Red");
            rect.PrintInfo();
        }

        static void Main(string[] args)
        {
            byte isRunning = 1;
            while (isRunning == 1)
            {
                Console.WriteLine("Выберите задачу (1 или 2) или введите 0 для выхода:");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "0":
                        isRunning = 0;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод. Пожалуйста, введите 1, 2 или 0.");
                        break;
                }
            }
        }
    }
}