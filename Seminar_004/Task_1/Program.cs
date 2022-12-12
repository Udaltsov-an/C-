int EnterData(string text) {
    Console.WriteLine(text);
    int A = int.Parse(Console.ReadLine());
    return A;
}

int A = EnterData("Введите число: ");

void Sum(int A) {
    int result = 0;
    for(int i = 1; i <= A; i++) {
        result += i;
    }
    Console.WriteLine(result);
}
Sum(A);