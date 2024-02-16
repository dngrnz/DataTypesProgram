namespace DataTypesApp
{
    internal class DataTypesProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Pieces of Apple: ");
            int Applepcs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the total price of " + Applepcs + "apple(s): ");
            double TotalPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Total price of " + Applepcs + "apple(s) " + TotalPrice);
            Console.WriteLine("The value of original price is " + TotalPrice);
            int c_totalprice = (int)TotalPrice;
            Console.WriteLine("The value of converted price is " + c_totalprice);


        }
    }
}