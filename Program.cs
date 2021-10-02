using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hangman game");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 Play game");
            Console.WriteLine("2 Exit");
            Console.Write("Please Select Menu : ");
 
            int menuNumber = int.Parse(Console.ReadLine()); //กด 1 หรือ 2
            if (menuNumber == 1) //ถ้าเลือก 1 จะเข้ามาทำงานในนี้
            {
                int incorrectword = 0; //เริ่มต้นยังไม่มีคำผิด
                Console.WriteLine("Play game Hangman");
                Console.WriteLine("------------------");
                Console.WriteLine("Incorrect Score: {0} ", incorrectword);

                Console.Clear(); //เคลียร์หน้าจอให้เหลือแค่พิมพ์ตัวอักษรกับคะแนนที่ผิด

                string[] word = new string[3];
                //Array (เป็นคำศัพท์ที่เรากำหนด)
                word[0] = "tennis";
                word[1] = "football";
                word[2] = "badminton";
                Random random = new Random(); //Randomคำที่อยู่ในArray
                int resultRandom = random.Next(0, 2); //Randomค่าเริ่มต้นถึงค่าสุดท้าย
                string text = word[resultRandom];

                string word2 = word[resultRandom];

                StringBuilder displayToPlayer = new StringBuilder(word2.Length);
                
                List<char> correctAlphabet = new List<char>();
                List<char> incorrectAlphabet = new List<char>();

                int lives = 6; //มีชีวิต6ชีวิต
                bool win = false;
                int lettersRevealed = 0;

                string input;
                char guess;

                for (int i = 0; i < word2.Length; i++)
                    displayToPlayer.Append('_');

                while (!win && lives > 0)
                {
                    Console.Write("Input letter alphabet: "); //ใส่ตัวอักษร

                    input = Console.ReadLine();
                    guess = input[0];

                    if (correctAlphabet.Contains(guess))
                    {
                        Console.WriteLine(guess);
                        continue;
                    }
                    else if (incorrectAlphabet.Contains(guess))
                    {
                        Console.WriteLine(guess);
                        continue;
                    }

                    if (word2.Contains(guess))
                    {
                        correctAlphabet.Add(guess);

                        for (int i = 0; i < word2.Length; i++)
                        {
                            if (word2[i] == guess)
                            {
                                displayToPlayer[i] = word2[i];
                                lettersRevealed++;
                            }
                        }

                        if (lettersRevealed == word2.Length)
                            win = true;
                    }
                    else
                    {
                        lives--;
                        incorrectword++ ;
                        incorrectAlphabet.Add(guess);
                        Console.WriteLine("Incorrect Score: {0} ", incorrectword);
                        Console.WriteLine(guess);

                    }

                    Console.WriteLine(displayToPlayer.ToString());
                }

                if (win)
                {
                    Console.WriteLine("Your win!!"); //แสดงผลว่าชนะ
                }
                else
                {
                    Console.WriteLine("Your lost!!"); //แสดงผลว่าแพ้
                    Console.ReadLine();
                }
            }
            else if (menuNumber == 2) //เลือก2จะแสดงผลว่าexit และจบโปรแกรม
            {
                Console.WriteLine("Exit");
            }
        }
    }
} 