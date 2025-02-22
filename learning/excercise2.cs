int num1 = 132;
int num2 = 20;

int remainder = num1 % num2; //Finding first remainder
Console.WriteLine(remainder);

num1 += 122; //Changing value of num1
remainder = num1 % num2; //Finding new remainder
//Print statements
Console.Write("The new remainder is: ");
Console.Write(remainder);