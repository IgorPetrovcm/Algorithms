namespace Program 
{
    class MinStack 
    {
        int[] values;
        int count;
        const int size = 10;
        public MinStack() {
            values = new int[size];
        }
        public void Push(int val) 
        {
            values[count++] = val;
        }
        public int Pop() 
        {
            int val = values[--count];
            values[count] = 0;
            return val;
        }
        public int Peek() 
        {
            return values[count-1];
        }
        public int GetMin() 
        {
            int[] valuesSorted = values;
            Array.Sort(valuesSorted);
            return valuesSorted[0];
        }
    }
}