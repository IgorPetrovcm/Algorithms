namespace Solution1;


public class Program 
{
    static void Main() 
    {
        int[] arr = TaskFunction(new int[] {1,2,3,4});
    }

    static int[] TaskFunction(int[] nums)
    {
    /*int n = nums.Length;
    int[] answer = new int[n];

    // Создаем промежуточные массивы для хранения произведений чисел слева и справа от текущего элемента
    int[] leftProduct = new int[n];
    int[] rightProduct = new int[n];

    // Вычисляем произведение чисел слева от текущего элемента
    leftProduct[0] = 1;
    for (int i = 1; i < n; i++) {
        leftProduct[i] = leftProduct[i - 1] * nums[i - 1];
    }

    // Вычисляем произведение чисел справа от текущего элемента
    rightProduct[n - 1] = 1;
    for (int i = n - 2; i >= 0; i--) {
        rightProduct[i] = rightProduct[i + 1] * nums[i + 1];
    }

    // Вычисляем ответ как произведение чисел слева и справа от текущего элемента
    for (int i = 0; i < n; i++) {
        answer[i] = leftProduct[i] * rightProduct[i];
    }

    return answer;*/

        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];

        left[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            left[i] = left[i-1] * nums[i-1];
        }

        right[nums.Length-1] = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            right[i] = right[i+1] * nums[i+1];
        }

        int[] res = new int[nums.Length];
        for (int i = 0; i < res.Length; i++)
        {
            res[i] = left[i] * right[i];
        }

        return res;
    }
}