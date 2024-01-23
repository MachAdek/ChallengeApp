//// ========================= jeden sposób =============

//List<string> daysOfWeeks = new List<string>();

//daysOfWeeks.Add("poniedziałek");
//daysOfWeeks.Add("wtorek");
//daysOfWeeks.Add("sroda");
//daysOfWeeks.Add("czwartek");
//daysOfWeeks.Add("piatek");
//daysOfWeeks.Add("sobota");
//daysOfWeeks.Add("niedziela");
//// pierwsza wersja for / foreach
//for (int i = 0; i < daysOfWeeks.Count; i++)
//{
//    Console.WriteLine(daysOfWeeks[i]);
//}

//// =+++==Drugi sposób ===++++

////string[] daysofweeks2 = { "pon", "wt", "śr", "czw", "pt", "sb", "nd" };
////console.writeline(daysofweeks2[3]);


//// druga wersja foreach / for
//foreach (var day in daysOfWeeks)
//{
//    Console.WriteLine(day);
//}



// Zadanie domowe

int number = 45606;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}


Console.WriteLine("00==" + counter0);
Console.WriteLine("01==" + counter1);
Console.WriteLine("02==" + counter2);
Console.WriteLine("03==" + counter3);
Console.WriteLine("04==" + counter4);
Console.WriteLine("05==" + counter5);
Console.WriteLine("06==" + counter6);
Console.WriteLine("07==" + counter7);
Console.WriteLine("08==" + counter8);
Console.WriteLine("09==" + counter9);
