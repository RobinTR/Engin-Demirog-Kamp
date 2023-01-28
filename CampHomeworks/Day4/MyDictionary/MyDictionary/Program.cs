namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDct = new MyDictionary<string, int>();
            myDct.Add("Robin", 1);
            myDct.Add("Robin", 1);//Aynı key değeri öncesinde eklendiği için burası eklenmez.
            myDct.Add("robin", 1);
            myDct.Add("RobiN", 1);

            myDct.ListAll();
        }
    }
}