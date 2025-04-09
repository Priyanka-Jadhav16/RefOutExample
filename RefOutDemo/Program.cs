internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Two number");
        int num1 = int.Parse(Console.ReadLine()) ;
         int num2 = int.Parse(Console.ReadLine()) ;
        int sub, add;

        Result(ref num1,ref num2,out sub ,out add);
        Console.WriteLine($"Addition is {add} and Sunstaction is {sub} of {num1} and {num2}");

    }
    static void Result( ref int num1,  ref int  num2, out int sub,out int add){
        sub= num1-num2;
        add=num1+num2 ;

    }

}