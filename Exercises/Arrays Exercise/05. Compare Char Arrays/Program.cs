using System;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    public class Program
    {
        public static void Main()
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(s => char.Parse(s)).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(s => char.Parse(s)).ToArray();
            if (firstArray.Length>secondArray.Length)
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (firstArray[i]!=secondArray[i])
                    {
                        if (firstArray[i]<secondArray[i])
                        {
                            for (int j = 0; j <firstArray.Length; j++)
                            {
                                Console.Write(firstArray[j]);
                               
                            }
                            Console.WriteLine("");
                            for (int j = 0; j < secondArray.Length; j++)
                            {
                                Console.Write(secondArray[j]);
                            }
                            break;
                            
                        }
                        else
                        {
                            for (int j = 0; j < secondArray.Length; j++)
                            {
                                Console.Write(secondArray[j]);
                                
                            }
                            Console.WriteLine("");
                            for (int j = 0; j < firstArray.Length; j++)
                            {
                                Console.Write(firstArray[j]);

                            }
                            break;
                            
                        }
                    }
                    else
                    {
                        for (int j = 0; j < secondArray.Length; j++)
                        {
                            Console.Write(secondArray[j]);

                        }
                        Console.WriteLine("");
                        for (int j = 0; j < firstArray.Length; j++)
                        {
                            Console.Write(firstArray[j]);

                        }
                        break;
                    }
                }
            }
            if (firstArray.Length < secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        if (firstArray[i] < secondArray[i])
                        {
                            for (int j = 0; j < firstArray.Length; j++)
                            {
                                Console.Write(firstArray[j]);
                              
                            }
                            Console.WriteLine("");
                            for (int j = 0; j <secondArray.Length; j++)
                            {
                                Console.Write(secondArray[j]);
                            }
                            break;
                        }
                        else
                        {
                            for (int j = 0; j < secondArray.Length; j++)
                            {
                                Console.Write(secondArray[j]);
                                
                            }
                            Console.WriteLine("");
                            for (int j = 0; j < firstArray.Length; j++)
                            {
                                Console.Write(firstArray[j]);

                            }
                            break;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < firstArray.Length; j++)
                        {
                            Console.Write(firstArray[j]);

                        }
                        Console.WriteLine("");
                        for (int j = 0; j < secondArray.Length; j++)
                        {
                            Console.Write(secondArray[j]);
                        }
                        break;
                    }
                }
            }
           if(firstArray.Length==secondArray.Length)
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        if (firstArray[i] < secondArray[i])
                        {
                            for (int j = 0; j < firstArray.Length; j++)
                            {
                                Console.Write(firstArray[j]);
                                
                            }
                            Console.WriteLine("");
                            for (int j = 0; j < secondArray.Length; j++)
                            {
                                Console.Write(secondArray[j]);
                            }
                            break;
                        }
                        else
                        {
                            for (int j = 0; j < secondArray.Length; j++)
                            {
                                Console.Write(secondArray[j]);
                               
                            }
                            Console.WriteLine("");
                            for (int j = 0; j < firstArray.Length; j++)
                            {
                                Console.Write(firstArray[j]);

                            }
                            break;
                            
                        }
                    }
                    else
                    {
                        for (int j = 0; j < firstArray.Length; j++)
                        {
                            Console.Write(firstArray[j]);

                        }
                        Console.WriteLine("");
                        for (int j = 0; j < secondArray.Length; j++)
                        {
                            Console.Write(secondArray[j]);
                        }
                        break;
                    }
                }
            }
        }
    }
}
