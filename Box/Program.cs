using System;
using System.Diagnostics;

class ProgArgsDemo {
    // Тест работы передачи аргументов

    static int Sum(params int[] a) {
        int res = 0;
        for (int k = 0; k < a.Length; k++) {
            res += a[k];
        }
        return res;
    }

    /// <summary>
    /// Выбирает <c>слово</c> из списка индексов в параметрах.
    /// (<paramref name="a"/>,<paramref name="t"/>).
    /// </summary>
    /// <param name="t">Строка для поиска</param>
    /// <param name="a">Индексы для составления нового слова</param>
    /// <returns>
    /// Новое слово исходя из индексов
    /// </returns>
    static string GetText(string t, params int[] a) {
        string res = "";
        for (int k = 0; k < a.Length; k++) {
            res += t[a[k]];
        }
        return res;
    }

    static void Show(int[] a, params char[] b) {
        Console.Write("Чисел {0}: ", a.Length);
        for (int k = 0; k < a.Length - 1; k++) {
            Console.Write(a[k] + " ");
        }
        Console.WriteLine("и " + a[a.Length - 1]);

        Console.Write("Чисел {0}: ", b.Length);
        for (int k = 0; k < b.Length - 1; k++) {
            Console.Write(b[k] + " ");
        }
        Console.WriteLine("и " + b[b.Length - 1]);
    }

    static void Main() {
        Console.WriteLine("Сумма чисел: {0}", Sum(1, 6, 9, 2, 4));
        Console.WriteLine("Сумма чисел: {0}", Sum(5, 1, 2));
        Console.WriteLine(GetText("Раз два три", 0, 10, 8, 1));
        Console.WriteLine(GetText("Бревно", 3, 5, 1, 5, 4));
        Show(new int[]{1, 3, 5}, 'A', 'B', 'C', 'D', 'E');
        Show(new int[]{1, 3, 5, 7, 9}, 'A', 'B', 'C', 'D');
    }
}
