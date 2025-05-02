using System;

class ProgArgsDemo {
    // Тест работы передачи аргументов

    static int GetMin(int[] nums, out int index) {
        index = 0;
        for (int k = 1; k < nums.Length; k++) {
            if (nums[k] < nums[index]) {
                index = k;
            }
        }
        return nums[index];
    }

    static void Main() {
        int[] A = {12, 7, 8, 3, 8, 4, 1, 3, 4, 1, 7, 15,};
        foreach (int v in A) {
            Console.Write("| {0}" , v);
        }
        Console.WriteLine("|");
        int val;
        val = GetMin(A, out int k);
        Console.WriteLine("Найменьшее значение: {0}", val);
        Console.WriteLine("Индекс элемента: {0}", k);
        Console.WriteLine("Проверка A[{0}] = {1}", k, A[k]);
        }
    }
