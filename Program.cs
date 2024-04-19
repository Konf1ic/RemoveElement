using System;

class RemoveElementDemo
{
    static void Main(string[] args)
    {
        int[] array = { 10, 4, 6, 7, 8, 6, 0, 0, 0, 0 };

        Console.Write("Enter the element to remove: ");
        int x = int.Parse(Console.ReadLine());

        // Tìm index của phần tử 
        int indexDel = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == x)
            {
                indexDel = i;
                break;
            }
        }

        // Xóa phần tử nếu tìm thấy
        if (indexDel != -1)
        {
            for (int i = indexDel; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            // - độ dài mảng đi 1
            Array.Resize(ref array, array.Length - 1);

            // Show mảng mới
            Console.WriteLine("Array after removing {0}:", x);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("Element not found in the array!");
        }
    }
}
