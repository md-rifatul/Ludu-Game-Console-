using Task;

bool GB1 = false;
bool GB2 = false;
bool GB3 = false;
bool GB4 = false;

bool GR1 = false;
bool GR2 = false;
bool GR3 = false;
bool GR4 = false;

bool r1 = false;
bool r2 = false;
bool r3 = false;
bool r4 = false;

bool rr1 = true;
bool rr2 = true;
bool rr3 = true;
bool rr4 = true;

string finalBoard = MainBoard.PrintBoard();



Print();
char first = '{';
char last = '}';

Player1 B1 = new Player1("B1");
Player1 B2 = new Player1("B2");
Player1 B3 = new Player1("B3");
Player1 B4 = new Player1("B4");

Computer R1 = new Computer("R1");
Computer R2 = new Computer("R1");
Computer R3 = new Computer("R1");
Computer R4 = new Computer("R1");

R1.Value = 27;
R2.Value = 27;
R3.Value = 27;
R4.Value = 27;


while ((B1.Value < 56 || B2.Value < 56 || B3.Value < 56 || B4.Value < 56) || (R1.Value < 61 && GR1 == true) || (R2.Value < 61 && GR2 == true) || (R3.Value < 61 && GR3 == true) || (R4.Value < 61 && GR4 == true))
{
    int Toss_1 = new Player1(string.Empty).Toss();
    string Message1 = @"
                For Player Blue

                If Move B1 Press 1
                If Move B2 Press 2
                If Move B3 Press 3
                If Move B4 Press 4";
    Console.WriteLine($"Your Point is {Toss_1}");
    Console.WriteLine(Message1);

    int key1 = int.Parse(Console.ReadLine());
    bool flag=false;

    if (Toss_1 == 6)
    {
        if (key1 == 1 && GB1==false)
        {
            B1.Value = 1;
            GB1 = true;
            flag= true;
        }
        if (key1 == 2 && GB2==false)
        {
            B2.Value = 1;
            GB2 = true;
            flag = true;
        }
        if (key1 == 3 && GB3==false)
        {
            B3.Value = 1;
            GB3 = true;
            flag=true;
        }
        if (key1 == 4 && GB4==false)
        {
            B4.Value = 1;
            GB4 = true;
            flag = true;
        }
    }


    if (key1 == 1 && GB1 == true && B1.Value < 57 && flag==false)
    {

        string temp = $"{first}{B1.Value}{last}";
        finalBoard = finalBoard.Replace("B1", temp);

        B1.PlayerMove(Toss_1);
        if (B1.Value == R1.Value)
        {
            R1.Defould();
            GR1 = false;
        }
        if (B1.Value == R2.Value)
        {
            R2.Defould();
            GR2 = false;
        }
        if (B1.Value == R3.Value)
        {
            R3.Defould();
            GR3 = false;
        }
        if (B1.Value == R4.Value)
        {
            R4.Defould();
            GR4 = false;
        }
        if (B1.Value > 56) B1.Value = 2000;

        temp = $"{first}{B1.Value}{last}";
        finalBoard = finalBoard.Replace(temp, "B1");
        Print();

    }

    else if (key1 == 2 && GB2 == true && B2.Value < 57 && flag==false)
    {
        string temp = $"{first}{B1.Value}{last}";
        finalBoard = finalBoard.Replace("B2", temp);

        B2.PlayerMove(Toss_1);
        if (B2.Value == R1.Value)
        {
            R1.Defould();
            GR1 = false;
        }
        if (B2.Value == R2.Value)
        {
            R2.Defould();
            GR2 = false;
        }
        if (B3.Value == R3.Value)
        {
            R3.Defould();
            GR3 = false;
        }
        if (B4.Value == R4.Value)
        {
            R4.Defould();
            GR4 = false;
        }
        if (B2.Value > 56) B2.Value = 2000;

        temp = $"{first}{B2.Value}{last}";
        finalBoard = finalBoard.Replace(temp, "B2");
        Print();
    }

    else if (key1 == 3 && GB3 == true && B3.Value < 57 && flag==false)
    {
        string temp = $"{first}{B1.Value}{last}";
        finalBoard = finalBoard.Replace("B3", temp);

        B3.PlayerMove(Toss_1);
        if (B3.Value == R1.Value)
        {
            R1.Defould();
            GR1 = false;
        }
        if (B3.Value == R2.Value)
        {
            R2.Defould();
            GR2 = false;
        }
        if (B3.Value == R3.Value)
        {
            R3.Defould();
            GR3 = false;
        }
        if (B3.Value == R4.Value)
        {
            R4.Defould();
            GR4 = false;
        }
        if (B3.Value > 56) B3.Value = 2000;

        temp = $"{first}{B3.Value}{last}";
        finalBoard = finalBoard.Replace(temp, "B3");
        Print();
    }

    else if (key1 == 4 && GB4 == true && B4.Value < 57 && flag == false)
    {
        string temp = $"{first}{B1.Value}{last}";
        finalBoard = finalBoard.Replace("B4", temp);

        B4.PlayerMove(Toss_1);
        if (B4.Value == R1.Value)
        {
            R1.Defould();
            GR1 = false;
        }
        if (B4.Value == R2.Value)
        {
            R2.Defould();
            GR2 = false;
        }
        if (B4.Value == R3.Value)
        {
            R3.Defould();
            GR3 = false;
        }
        if (B4.Value == R4.Value)
        {
            R4.Defould();
            GR4 = false;
        }
        if (B4.Value > 56) B4.Value = 2000;

        temp = $"{first}{B4.Value}{last}";
        finalBoard = finalBoard.Replace(temp, "B4");
        Print();
    }






    int Toss_2 = new Computer(string.Empty).Toss();

    Console.WriteLine();
    Console.WriteLine($"Computer Point is {Toss_2}");
    Console.WriteLine("Computers Movement is Done");
    Console.WriteLine();

    int key2 = new RandomNumberForPlayerMove().Generate();


    Console.WriteLine();
    bool flag2 = false;

    if (Toss_2 == 6)
    {
        if (key2 == 1 && GR1 == false)
        {
            R1.Value = 27;
            GR1 = true;
            flag2=true;
        }
        if (key2 == 2 && GR2 == false)
        {
            R2.Value = 27;
            GR2 = true;
            flag2=true;
        }
        if (key2 == 3 && GR3 == false)
        {
            R3.Value = 27;
            GR3 = true;
            flag2=true;
        }
        if (key2 == 4 && GR4 == false)
        {
            R4.Value = 27;
            GR4 = true;
            flag2=true;
        }

    }

    if ( GR1 == true && R1.Value < 62 && flag2==false && rr1==true)
    {
        string temp = $"{first}{R1.Value}{last}";
        finalBoard = finalBoard.Replace("R1", temp);

        R1.PlayerMove(Toss_2);
        if (R1.Value == B1.Value)
        {
            B1.Defould();
            GB1 = false;
        }
        if (R1.Value == B2.Value)
        {
            B2.Defould();
            GB2 = false;
        }
        if (R1.Value == B3.Value)
        {
            B3.Defould();
            GB3 = false;
        }
        if (R1.Value == B4.Value)
        {
            B4.Defould();
            GB4 = false;
        }
        if (R1.Value > 51)
        {
            R1.PlayerMinus();
            r1 = true;
        }

       
        if (R1.Value > 25 && r1 == true) R1.PlayerPlus();
        if (R1.Value > 61) rr1=false;



        temp = $"{first}{R1.Value}{last}";
        finalBoard = finalBoard.Replace(temp, "R1");
        Print();
        Console.WriteLine();
        Console.WriteLine($"Computer Point is {Toss_2}");
        Console.WriteLine("Computers Movement is Done");
    }

    else if ( GR2 == true && R2.Value < 62 && flag2==false && rr2==true)
    {
        string temp = $"{first}{R2.Value}{last}";
        finalBoard = finalBoard.Replace("R2", temp);

        R2.PlayerMove(Toss_2);
        if (R2.Value == B1.Value)
        {
            B1.Defould();
            GB1 = false;
        }
        if (R2.Value == B2.Value)
        {
            B2.Defould();
            GB2 = false;
        }
        if (R2.Value == B3.Value)
        {
            B3.Defould();
            GB3 = false;
        }
        if (R2.Value == B4.Value)
        {
            B4.Defould();
            GB4 = false;
        }
        if (R2.Value > 51)
        {
            R2.PlayerMinus();

            r2 = true;
        }
        
        if (R2.Value > 25 && r2 == true) R2.PlayerPlus();
        if (R2.Value > 61) rr2=false;


        temp = $"{first}{R2.Value}{last}";
        finalBoard = finalBoard.Replace(temp, "R2");
        Print();
        Console.WriteLine();
        Console.WriteLine($"Computer Point is {Toss_2}");
        Console.WriteLine("Computers Movement is Done");
    }

    else if ( GR3 == true && R3.Value < 62 && flag2 == false && rr3==true)
    {
        string temp = $"{first}{R3.Value}{last}";
        finalBoard = finalBoard.Replace("R3", temp);

        R3.PlayerMove(Toss_2);
        if (R3.Value == B1.Value)
        {
            B1.Defould();
            GB1 = false;
        }
        if (R3.Value == B2.Value)
        {
            B2.Defould();
            GB2 = false;
        }
        if (R3.Value == B3.Value)
        {
            B3.Defould();
            GB3 = false;
        }
        if (R3.Value == B4.Value)
        {
            B4.Defould();
            GB4 = false;
        }
        if (R3.Value > 51)
        {
            R3.PlayerMinus();
            r3 = true;
        }
        
        if (R3.Value > 25 && r3 == true) R3.PlayerPlus();
        if (R3.Value > 61) rr3=false;


        temp = $"{first}{R3.Value}{last}";
        finalBoard = finalBoard.Replace(temp, "R3");
        Print();
        Console.WriteLine();
        Console.WriteLine($"Computer Point is {Toss_2}");
        Console.WriteLine("Computers Movement is Done");
    }

   else if ( GR4 == true && R4.Value < 62 && flag2 == false && rr4 == true)
    {
        string temp = $"{first}{R4.Value}{last}";
        finalBoard = finalBoard.Replace("R4", temp);

        R4.PlayerMove(Toss_2);
        if (R4.Value == B1.Value)
        {
            B1.Defould();
            GB1 = false;
        }
        if (R4.Value == B2.Value)
        {
            B2.Defould();
            GB2 = false;
        }
        if (R4.Value == B3.Value)
        {
            B3.Defould();
            GB3 = false;
        }
        if (R4.Value == B4.Value)
        {
            B4.Defould();
            GB4 = false;
        }
        if (R4.Value > 51)
        {
            R4.PlayerMinus();
            r4 = true;
        }
      
        if (R4.Value > 25 && r4 == true) R4.PlayerPlus();
        if (R4.Value > 61) rr4=false;


        temp = $"{first}{R4.Value}{last}";
        finalBoard = finalBoard.Replace(temp, "R4");
        Print();
        Console.WriteLine();
        Console.WriteLine($"Computer Point is {Toss_2}");
        Console.WriteLine("Computers Movement is Done");
    }


}

void Print()
{
    char[] chars = finalBoard.ToCharArray();
    for (int i = 0; i < chars.Length; i++)
    {
        if (chars[i] >= 'A' && chars[i] <= 'Z')
        {

            Console.Write(chars[i]);
            Console.Write(chars[i + 1]);
            i++;
            continue;
        }
        else if (chars[i] >= '0' && chars[i] <= '9' || (chars[i] == '{' || chars[i] == '}'))
        {
            Console.Write(' ');
        }
        else
        {
            Console.Write(chars[i]);
        }

    }
    Console.WriteLine();

}

if (B1.Value > 56 || B2.Value > 56 || B3.Value > 56 || B4.Value > 56)
{
    Console.WriteLine("Bule Player is win");
}
else if (R1.Value > 61 || R2.Value > 61 || R3.Value > 61 || R4.Value > 61)
{
    Console.WriteLine("Red Player is win");
}