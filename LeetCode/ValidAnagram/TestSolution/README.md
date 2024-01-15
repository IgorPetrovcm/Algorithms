### Чтобы узнать размер объекта 

Подключит библиотеку `using System.Runtime.InteropServices;`,

И используем статический метод класса `Marshal`, `SizeOf()`
```csharp
object c = 'd';

Console.WriteLine(Marshal.SizeOf(c));
```