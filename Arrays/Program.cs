using System;

namespace Arrays
{
    class Program
    {
        public struct AddressInfo
        {
            public string[] Address;
            public string City;

        }

        public enum ChessFigure
        {
            None = 0,
            Pawn = 10,
            Queen = 20, 
            King = 30
        }

        static void Main(string[] args)
        {
            AddressInfo addressInfo = new AddressInfo()
            {
                Address = new string[] { "Mladost-2 77", "SMG Bulgaria" },
                City = "Sofia"
            };

            //for (int line = 0; line < addressInfo.Address.Length; line++)
            //{
            //    Console.WriteLine(addressInfo.Address[line]);
            //}

            //foreach(string line in addressInfo.Address)
            //{
            //    Console.WriteLine(line);
            //}

            //int line = 0;
            //while (line < addressInfo.Address.Length)
            //{
            //    Console.WriteLine(addressInfo.Address[line++]);
            //}

            //int line = 0;
            //do
            //{
            //    if (addressInfo.Address.Length == 0)
            //        break;

            //    Console.WriteLine(addressInfo.Address[line++]);

            //} while (line < addressInfo.Address.Length);

            //ChessFigure[,] chessBoard = new ChessFigure[8, 8];

            //for (int row = 1, col = 0; col < chessBoard.GetLength(1); col++)
            //{
            //    chessBoard[row, col] = ChessFigure.Pawn;
            //}

            //chessBoard[0, 3] = ChessFigure.Queen;
            //chessBoard[0, 4] = ChessFigure.King;


            //for (int row = 0; row < chessBoard.GetLength(0); row++)
            //{
            //    for (int col = 0; col < chessBoard.GetLength(1); col++)
            //    {
            //        if (chessBoard[row, col] == ChessFigure.None)
            //        {
            //            Console.Write("  ");
            //        }
            //        else
            //        {
            //            Console.Write($"{chessBoard[row, col].ToString().Substring(0, 1)} ");
            //        }
            //    }

            //    Console.WriteLine();
            //}

            //int[] array = new int[] { 1, 2, 3, 4 };


            //int[] clonedArray = (int[])array.Clone();

            //foreach(var el in clonedArray)
            //    Console.WriteLine(el);

            string[][] chart = new string[100][];

            chart[0] = new string[] { "Levski" };
            chart[1] = new string[] { "Ludogoretz", "Beroe" };

            chart[6] = new string[] { "Cherno More" };

            for (int position = 0; position < chart.Length; position++)
            {
                if (chart[position] == null)
                    continue;

                Console.Write($"{position + 1}. ");

                Console.WriteLine(string.Join(", ", chart[position]));
            }
            

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
