public class FizzBuzz{
    public static void Main(){
        for (int i = 1; i <= 100; i++) {

            var str = "";

            // ここから記述
            
            if (i % 3 == 0 && i % 5 == 0) System.Console.WriteLine("FizzBuzz"); // 3と5の倍数判定
            else if (i % 3 == 0) System.Console.WriteLine("Fizz"); // 3の倍数判定
            else if (i % 5 == 0) System.Console.WriteLine("Buzz"); // 5の倍数判定
            else System.Console.WriteLine(i); // そのほか
            
            // ここまで記述

            System.Console.WriteLine(str);
        }
    }
}
