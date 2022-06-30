/*bool IsEven(int value)
{
 return value % 2 == 0;
}*/
// Это можно записать так
// bool IsEven(int value) => value % 2 == 0;
// или так
// var IsEven = (int v) => v % 2 == 0;

Random r = new Random();

Console.CursorVisible = false;
while(true)
{
    Console.SetCursorPosition(
        left: r.Next(Console.WindowWidth),
        top: r.Next(Console.WindowHeight)
    );
    Console.Write(r.Next(10));
    Thread.Sleep(1000);
}