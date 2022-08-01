Console.WriteLine("Программа котрая определяет является ли число палиндромом.");

Console.WriteLine("Введите пятизначное число");
string N = Console.ReadLine();

if (N[0] == N[4] && N[1] == N[3]) {
    Console.WriteLine("Число является палиндромом");
}
else {
    Console.WriteLine("Число не является палиндромом");
}

