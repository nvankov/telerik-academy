using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequenceInArray
{
    class SequenceInArray
    {
        enum direction
        { 
            Right,
            Down,
            Diagonal
        };

        static void Main(string[] args)
        {
            //string[,] array = {
            //                    {"ha", "fifi", "ho", "hi"},
            //                    {"fo", "ha", "hi", "xx"},
            //                    {"xxx", "ho", "ha", "xx"}
            //                  };

            string[,] array = { 
                                {"s", "qq", "s"},
                                {"pp", "pp", "s"},
                                {"pp", "qq", "s"}
                              };
            int maxOccurances = 0;
            int occurances = 0;
            int startingRowIndex = 0;
            int startingColIndex = 0;
            string occuringElement = "";
            direction Direction = direction.Right;
            int tempRowIndex;
            int tempColIndex;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    tempRowIndex = row;
                    tempColIndex = col;

                    //Проверява надясно от елемента за съвпадения
                    while (tempRowIndex < array.GetLength(0))
                    {
                        //Първият път винаги елемента ще съвпадне със себе си. 
                        //Дори и да няма други съвпадения occurances ще бъде със стойност 1
                        if (array[row, col] == array[tempRowIndex, col])
                        {
                            occurances++;
                            tempRowIndex++;

                            if (occurances > maxOccurances)
                            {
                                maxOccurances = occurances;
                                startingRowIndex = row;
                                startingColIndex = col;
                                occuringElement = array[row, col];
                                Direction = direction.Right;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    occurances = 0;
                    tempRowIndex = row;
                    tempColIndex = col;
                    //Проверява надолу от елемента за съвпадения
                    while (tempColIndex < array.GetLength(1))
                    {
                        if (array[row, col] == array[row, tempColIndex])
                        {
                            occurances++;
                            tempColIndex++;

                            if (occurances > maxOccurances)
                            {
                                maxOccurances = occurances;
                                startingRowIndex = row;
                                startingColIndex = col;
                                occuringElement = array[row, col];
                                Direction = direction.Down;
                            }
                        }
                        else
                        { 
                            break;
                        }
                    }

                    occurances = 0;
                    tempRowIndex = row;
                    tempColIndex = col;
                    //Проверява по диагонал за съвпадения
                    while (tempRowIndex < array.GetLength(0) && tempColIndex < array.GetLength(1))
                    {
                        if (array[row, col] == array[tempRowIndex, tempColIndex])
                        {
                            occurances++;
                            tempColIndex++;
                            tempRowIndex++;

                            if (occurances > maxOccurances)
                            {
                                maxOccurances = occurances;
                                startingRowIndex = row;
                                startingColIndex = col;
                                occuringElement = array[row, col];
                                Direction = direction.Diagonal;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    occurances = 0;
                }

                occurances = 0;
            }

            Console.WriteLine("Number of occurances: {0}", maxOccurances);
            Console.WriteLine("Of the element: {0}", occuringElement);

            tempRowIndex = startingRowIndex;
            tempColIndex = startingColIndex;

            for (int index = 0; index < maxOccurances; index++)
            {
                Console.Write("{0} ", array[tempRowIndex, tempColIndex]);

                if (Direction == direction.Right)
                {
                    tempRowIndex++;
                }

                if (Direction == direction.Down)
                {
                    tempColIndex++;
                }

                if (Direction == direction.Diagonal)
                {
                    tempRowIndex++;
                    tempColIndex++;
                }
            }

            Console.WriteLine();

        }
    }
}
