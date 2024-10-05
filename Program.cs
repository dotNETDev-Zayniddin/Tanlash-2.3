/*

 O'rtacha ballni hisoblash:
Foydalanuvchidan uchta fan bo'yicha (0 dan 100 gacha) baholarni so'raydigan va 
ularning o'rtacha ballini hisoblaydigan dastur yozing. Keyin dastur natija haqida xabarni ko'rsatadi: 
"A'lo" (o'rtacha ball 80 dan 100 gacha), "Yaxshi" (o'rtacha ball 60 dan 79 gacha), 
"Qoniqarli" (o'rtacha ball 40 dan 59 gacha) yoki "Qoniqarsiz" ( o'rtacha ball 40 dan kam). 

Shartlarni tekshirish uchun ternary operatoridan foydalaning. 
*/
using System;
namespace Tanlash{
    class Program
    {
        static void Main(){
            System.Console.Write("Birinchi fan natijasini kiriting: ");
            int firstSubj = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Ikkinchi fan natijasini kiriting: ");
            int secondSubj = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Birinchi fan natijasini kiriting: ");
            int thirdtSubj = Convert.ToInt32(Console.ReadLine());

            int avarage = (firstSubj + secondSubj + thirdtSubj)/3;
            System.Console.WriteLine($"Sizning o'rtacha balingiz: {avarage}");
            string  result = avarage >= 80 && avarage <= 100   
            ? "A'lo" : avarage >= 60 && avarage <= 79
            ? "Yaxshi" : avarage >= 40 && avarage <= 59 
            ? "Qoniqarli": avarage >= 0 && avarage <= 39
            ? "Qoniqarsiz" : "Xato qiymat kiritilgan. Dastur yakunlandi.";

            System.Console.WriteLine(result);

        }
    }
}
