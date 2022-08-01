Console.WriteLine("Программа котрая выдает таблицу кубов от 1 до N");

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица квадратов:");
for (int i=1; i < N; i++) {
    Console.WriteLine(i*i*i);
}
