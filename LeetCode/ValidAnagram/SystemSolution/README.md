### Сравнить последовательность массивов
Предположим есть два массива:
```csharp
int[] arr1 = {1,2,3,4};
int[] arr2 = {1,2,3,4};
```

Для сравнения их последовательностей исполуем метод `SequenceEqual`, класса `Enumerable`:

```csharp
Enumerable.SequenceEqual(arr1,arr2);
```
В данном случае метод `SequenceEqual()` вернет **true**