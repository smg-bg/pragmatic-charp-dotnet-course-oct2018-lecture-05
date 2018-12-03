using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            byte age = 0;

            bool validInput = false;
            //do
            //{
            //    Console.Write("Age: ");

            //    if (byte.TryParse(Console.ReadLine(), out age))
            //    {
            //        validInput = true;
            //    }

            //} while (!validInput);


            //while (!validInput)
            //{
            //    Console.Write("Second Age: ");

            //    if (byte.TryParse(Console.ReadLine(), out age))
            //    {
            //        validInput = true;
            //    }

            //}

            while (true)
            {
                Console.Write("Third Age: ");

                if (byte.TryParse(Console.ReadLine(), out age))
                {
                    if (age < 15)
                        continue;

                    break;
                }

            }



            //for (int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}



            //int[][] a = new int[10][];
            //a[0] = new int[10];
            //a[1] = new int[2];

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine($"Row: {i}");
            //    if (a[i] != null)
            //    {
            //        for (int j = 0; j < a[i].Length; j++)
            //        {
            //            Console.Write($"{j}, ");
            //        }

            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("<empty>");
            //    }

            //    ArrayList list = new ArrayList();
            //    list.Add(20);
            //    list.Add(30);
            //    list.Count


            //    int[] tst = new int[20];


            //    Stack st = new Stack();
            //    st.Push(1);
            //    st.Peek();
            //    st.Pop();
            //    var c = st.Count;


            //    Queue q = new Queue();
            //    q.Enqueue(1);
            //    q.Dequeue();
            //    q.Peek();


            //    Hashtable h = new Hashtable();
            //    h.Add(1, "dsadas");
            //    h.Values.To

            //}

            Console.Write("Press any key...");
            Console.ReadKey();
        }
    }
}
