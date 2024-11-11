namespace ArrayAssignment_solutions
{
    class Assignments
    {
        public void ArrayOccur()
        {
            int[] a = new int[5];
            Console.WriteLine("Enter 5 Elements of Array:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            //write your logic
        }
        public void InsertIntoArray()
        {
            int[] a = new int[5];
            Console.WriteLine("Enter 5 Elements of Array:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            //write your logic
        }
        public void SortArray()
        {
            int[] a = new int[5];
            Console.WriteLine("Enter 5 Elements of Array:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }  

            for (int i = 0;i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Array is:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]);
            }
            Array.Resize(ref a, 10);
            Console.WriteLine("Array New Size :"+a.Length);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignments aObj = new Assignments();
            aObj.SortArray();
        }
    }
}
