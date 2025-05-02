using System;

class ProgArgsDemo {
    // Тест работы передачи аргументов

    public static void Main() {
        int A = 100;
        Console.WriteLine("До вызова метода Alpha(): A = {0}", A);
        Alpha(A);
        Console.WriteLine("После вызова метода Alpha(): A = {0}", A);

        int [] B = {1, 3, 5,};
        Console.WriteLine("До вызова метода Bravo(): B = {0}", ArrayToText(B));
        Bravo(B);
        Console.WriteLine("После вызова метода Bravo(): B = {0}", ArrayToText(B));

        int [] C = {2, 4, 6,};
        Console.WriteLine("До вызова метода Charlie(): C = {0}", ArrayToText(C));
        Charlie(B);
        Console.WriteLine("После вызова метода Charlie(): C = {0}", ArrayToText(C));
    }

    static string ArrayToText(int[] n) {
        string res = "[" + n[0];
        for (int k = 1; k < n.Length; k++) res += ", " + n[k];
        res += "]";
        return res;
    }

    static void Alpha(int n) {
        // Измение аргумента
        Console.WriteLine("В методе Alpha(). На входе:" + n);
        n++;
        Console.WriteLine("В методе Alpha(). На выходе:" + n);
    }

    static void Bravo(int[] n) {
        // Изменение массива
        Console.WriteLine("В методе Bravo(). На входе:" + ArrayToText(n));
        for (int k = 0; k < n.Length; k++) n[k]++;
        Console.WriteLine("В методе Bravo(). На выходе:" + ArrayToText(n));
    }

    static void Charlie(int[] n) {
        // Подмена ссылки другим массивом
        Console.WriteLine("В методе Charlie(). На входе:" + ArrayToText(n));
        int[] m = new int[n.Length];
        for (int k = 0; k < n.Length; k++) m[k] = n[k] + 1;
        n = m;
        Console.WriteLine("В методе Charlie(). На выходе:" + ArrayToText(n));
    }
}
