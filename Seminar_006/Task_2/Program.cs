// **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// <aside>
// ❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.

// </aside>

void BuildTriangle(int a, int b, int c) {
    if(a+b>c && b+c>a && a+c>b) {
        Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} может существовать.");
    }
    else Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} не существует.");
}

int EnterData(string text) {
    Console.WriteLine(text);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int a = EnterData("Введите 1 сторону треугольника: ");
int b = EnterData("Введите 2 сторону треугольника: ");
int c = EnterData("Введите 3 сторону треугольника: ");

BuildTriangle(a,b,c);