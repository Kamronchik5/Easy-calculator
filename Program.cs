Console.WriteLine("Hi user !");
Console.WriteLine("Choose menu :");
Console.WriteLine("1. +, -, *, /, ^ does solve");
Console.WriteLine("2. log a(b)");

string input = Console.ReadLine();
switch(input)
{
    case "1" :
        {
            Console.Write("ENTER the expressions : ");
            string ifoda = Console.ReadLine();
            string amal = "";
            if(ifoda.Contains("+"))
            {
                amal = "+";
            }
            else if(ifoda.Contains("-"))
            {
                amal = "-";
            }
            else if(ifoda.Contains("*"))
            {
                amal = "*";
            }
            else if(ifoda.Contains("/"))
            {
                amal = "/";
            }
            else if(ifoda.Contains("^"))
            {
                amal = "^";
            }
            string strNum1 = ifoda.Substring(0, ifoda.IndexOf(amal));
            string strNum2 = ifoda.Substring(ifoda.IndexOf(amal) + 1);
            double firstNumber = Convert.ToDouble(strNum1);
            double secondNumber = Convert.ToDouble(strNum2);
            double natija = amal switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                "^" => Math.Pow(firstNumber, secondNumber),
            }; 
            Console.WriteLine($"{ifoda} = {natija}");
        }
        break;
        case "2" :
        {
            Console.Write("Ifodani kiriting : [log25(25)]");
            string ifoda = Console.ReadLine();
            int index1 = ifoda.IndexOf("(");
            int index2 = ifoda.IndexOf(")");
            string strNum1 = ifoda.Substring(3, index1 -3);
            string strNum2 = ifoda.Substring(index1 + 1, index2 - index1 -1);
            double Num1 = Convert.ToDouble(strNum1);
            double Num2 = Convert.ToDouble(strNum2);
            double natija = Math.Log(Num2) / Math.Log(Num1);
            Console.WriteLine($"{ifoda} = {natija}");
        }
        break; 
}
