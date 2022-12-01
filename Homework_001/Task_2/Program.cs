/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();
Console.WriteLine("Введите три числа: ");
int[] array = new int[3];
for(int i=0;i<3;i++) {
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(String.Join(", ", array));
int max = array[0];
for(int i = 1; i<3;i++) {
    if(array[i]>max) {
        max = array[i];
    };
}
Console.WriteLine($"Максимальное числое - {max}");