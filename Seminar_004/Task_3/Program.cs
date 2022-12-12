void getResult(int N){
    int result = 1;
    for(int i = 1; i <= N; i++)
    {
        result *= i;
    }
    Console.WriteLine(result);
}

int EnterData(string text) {
    Console.WriteLine(text);
    int N = int.Parse(Console.ReadLine());
    return N;
}

int N = EnterData("Введите число: ");
getResult(N);