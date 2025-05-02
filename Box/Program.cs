using System;

class ProgArgsDemo {

    static void Show(string txt) {
        Console.WriteLine(txt);
    }

    static int Factorial(int n) {
        int s = 1;
        for (int k = 0; k <= n; k++) {
            s *= k;
        }
        return s;
    }

    static double Power(double x, int n) {
        double s = 1;
        for (int k = 1; k <= n; k++) {
            s *= x;
        }
        return s;
    }

    static void Main() {
        Show("Начинаем вычисления:");
        int m = 5;
        double z = 3, num;
        Show(m + "! = " + Factorial(m));
        num = Power(z, m);
        Show(z + " в степени " + m + ": " + num);
    }
}
