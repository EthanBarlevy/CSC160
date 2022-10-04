namespace fdt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.WriteLine("whats your name uwu");
            string strname = Console.ReadLine();
            Console.WriteLine("hi " + strname + ". whats up");
            Console.WriteLine("hello {0}, you cool", strname); // this is gross but sure
            //Console.WriteLine("hoi ${} uwu");
        }
    }
}