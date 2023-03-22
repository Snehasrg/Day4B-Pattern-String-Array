using Pattern;

namespace Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your choice form below:");
            Console.WriteLine("\n1.DuplicateElementinArray\n2.UniqueElement\n3.FrequencyofElement\n4.MaxMinElement\n5.ReverseStar\n6.HollowSquarePattern\n7.ReverseLetterofString\n8.SumofAllDigit\n9.SumofEachRowofMatrix\n");
            int ch=Convert.ToInt32(Console.ReadLine());

             switch (ch)
             {
                    case 1:
                    DuplicateElementinArray.CheckDuplicate();
                    break;
                    case 2:
                    UniqueElement.UniqueIntElement();
                    break;
                    case 3:            
                    //FrequencyofElement.Checkfrequency();
                    break; 
                    case 4:
                    MaxMinElement.FindMaxMin();
                    break;
                    case 5:
                    ReverseStar.DisplayStar();
                    break;
                    case 6:
                    HollowSquarePattern.PrintPattern();
                    break;
                    case 7:
                    HollowSquarePattern.PrintPattern();
                    break;
                    case 8:
                    SumofAllDigit.CalculateSum();
                    break;
                    case 9:
                    SumofEachRowofMatrix.DisplayMatrix();
                    break;
             }
        }
    }
}