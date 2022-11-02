#region ozumcun
//int[] arr = { 12, 13, 1, 10, 34, 1 };
//int n = arr.Length;
//int smallest = Int32.MaxValue;
//// traversing the array to find
//// smallest element.
//for (int i = 0; i < n; i++)
//{
//    if (arr[i] < smallest)
//    {
//        smallest = arr[i];
//    }
//}
//Console.WriteLine("smallest element is: " + smallest);
#endregion



#region task1
//int[] arr = { 25, 11, 7, 75, 56 };
//int min = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < min)
//    {
//        min = arr[i];
//    }
//}
//Console.WriteLine("en kiçik element: " + min);
#endregion

#region task2

int[] num = { 25, 11, 7, 75, 5656, -5 };
int min = num[0];
int count = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] < 10 && num[i]>=0)
    {
        min = num[i];
        count++;
    }

}




Console.WriteLine(count);
#endregion




