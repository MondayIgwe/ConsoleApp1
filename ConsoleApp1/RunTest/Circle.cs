namespace ConsoleApp1.RunTest
{
    public class Circle
    {
        private DateTime start;
        private int x;
        string str;

        public Circle? MyProperty { get; set; }

        public void Area(object obj = null)
        {
            x = 2 * 1;
            str = "assignedValue";
            str.ToLower();
            start = DateTime.Now;
            var str2 = String.Join(',', obj);
            Console.WriteLine(x + " " + str2);
        }
    }
}
