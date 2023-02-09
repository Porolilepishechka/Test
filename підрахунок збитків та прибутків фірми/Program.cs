using System;

namespace Program
{
    class program
    {
        static void Main() {
            short summa = 0;
            short[] total = {200, -120, 50, 300, 70, 250};
            
                for (byte i = 0; i < total.Length; i++) {
                    summa += total[i];
                    switch (i)
                    {
                    case 5:
                        Console.WriteLine("весь прибуток разом: " + summa);
                        break;
                    }
                }
                //Додаваня всіх елементів через цикл for. і для записування суми в змінну summa.
            int summamid = 0;
            summamid = summa / 6;
            //Визначення середнього прибутку фірми.
            Console.WriteLine("середнiй прибуток: " + summamid);
            byte summayear = 0;
                for (byte i = 0; i < total.Length; i++) {
                    if (total[i] >= summamid)
                    Console.WriteLine("у " + i + " року було перевищено середнiй прибуток зi значенням " + total[i]);
                    //визначення в яких роках дохід перевищив середнє значення

                    if (total[i] >= 0) 
                    summayear++;
                    //підрахунок скільки років фірма мала прибутки

                }
            Console.WriteLine("фiрма мала прибутки: " + summayear + " рокiв");
            }
        }
    }
