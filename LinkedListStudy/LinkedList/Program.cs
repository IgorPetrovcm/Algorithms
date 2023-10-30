 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Node<T> 
    {
        public T value {get;set;}
        public Node<T> next {get;set;}
        public Node(T value) 
        {
            this.value = value;
        }

    }
    class LinkedList<T> 
    {
        public Node<T> head {get;set;} //точка входа
        public Node<T> tail {get;set;} //конечный элемент
        public int length {get;set;} //количество элементов

        //Метод добавления узла
        //Если не была установлена переменная head(то ессть список пуст), то устанавливаем head и tail, после добавления первого элемента они будут указывать на
        //один и тот же объект
        //
        //Если же в спике есть как минимум один элемент, то есть tail уже установлен, то устанавливаем для него свойство next - теперь tail хранит ссылку на новый узел
        //И устанавливаем сам tail теперь он ссылается на новый узел
        //
        //Сложность данног оалгоритма состовляет O(1)
        public void Add(T value) 
        {
            Node<T> node = new Node<T>(value);

            if (head == null){
                head = node;
            }
            else {
                tail!.next = node;
            }
            tail = node;

            length++;
        }
        //Метод удаления элемента из списка
        //Алгоритм имеет следующую последовательность шагов
        //  1. Поиск элемента в списке путем перебора всех элементов списка(только линейность, ведь отсортировать такой тип структуры данных очень сложно или невозможно)
        //      то есть сложность алгоритма O(n);
        //  2. Установка свойства next у предыдущего узла'previous'(по отношении к удаляемому узлу) на следующий узел по отношению к удаляемому
        //
        //Как вы поняли для отслеживания предыдущего узла применяется переменная 'previous'. Если елемент который должен быть удален найден, и переменная pervious
        //равна null(то есть она не менялась и перебор только осуществаляется), то удаление очевидно идет сначала, и в таком случае происходит переустановка переменной head
        //Если же pervious не равна null, то реализуется алгоритм действия которого описаны выше
        //
        //Сложность такого алгоритма состовляет O(n), что на самом деле не так плохо

        public bool Remove(T value) 
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null && current.value != null) 
            {
                if (current.value.Equals(value)) 
                {
                    if (previous != null) 
                    {
                        previous.next = current.next;

                        if (current.next == null)
                        {
                            tail = previous;
                        }
                    }
                    else 
                    {
                        head = head.next;

                        if (head == null) 
                        {
                            tail = null;
                        }
                    }
                    length--;
                    return true;
                }
                previous = current;
                current = current.next;
            }
            return false;
        }
    }
}
