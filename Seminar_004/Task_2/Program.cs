void getNumber(int A){
    string number = A.ToString();
    int result = number.Length;
    Console.WriteLine($"В числе {A} {result} цифры");
}

int EnterData(string text) {
    Console.WriteLine(text);
    int A = int.Parse(Console.ReadLine());
    return A;
}

int A = EnterData("Введите число: ");
getNumber(A);