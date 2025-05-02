using System;

class ProgArgsDemo {
    // Тест работы передачи аргументов

    static string ArrayToText(int[] n) {
        string res = "[" + n[0];
        for (int k = 1; k < n.Length; k++) {
            res += ", " + n[k];
        }
        res += "]";
        return res;
    }

    static void Alpha(int n) {
        Console.WriteLine("В методе Alpha(). На входе:" + n);
        n++;
        Console.WriteLine("В методе Alpha(). На выходе:" + n);
    }

    static void Bravo(int[] n) {
        Console.WriteLine("В методе Bravo(). На входе:" + ArrayToText(n));
        for (int k = 0; k < n.Length; k++) {
            n[k]++;
        }
        Console.WriteLine("В методе Bravo(). На выходе:" + ArrayToText(n));
    }

    static void Charlie(int[] n) {
        Console.WriteLine("В методе Charlie(). На входе:" + ArrayToText(n));
    }
}
