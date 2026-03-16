// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Input your name");
String userName = Console.ReadLine();
Console.WriteLine("Hello "+userName+"!");
Console.WriteLine("Choose a number");
int userNum = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < userNum; i++)
{
    Console.WriteLine(i+1);
}
Console.WriteLine("Have some more, "+userName);
userNum = userNum * userNum;
for (int i = 0;i < userNum; i++)
{
    Console.WriteLine(i+1);
}