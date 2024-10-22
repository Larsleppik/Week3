Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

int result = userNum % 2;

if (result != 0)
{
    Console.WriteLine("User number is odd.");
} else
{ 
    Console.WriteLine("User number is even.");
}
