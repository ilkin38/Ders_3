using System.Linq.Expressions;


void dersizahi()
{
    //implicit at auto conversion
    Console.WriteLine("implicit at auto conversion");
    byte number1 = 15;
    //we can convert byte to short at use auto conversion
    short number2 = number1;



    Console.WriteLine(number1);
    Console.WriteLine(number2);

    //explicit or manual conversion
    Console.WriteLine("explicit or manual conversion");

    short number3 = 56;
    short Num4 = 555;

    byte number4 = (byte)number3;
    byte Num5 = (byte)Num4;
    var aaa = int.Parse(Console.ReadLine());

    metodum(aaa);

    Console.WriteLine(number4);
    Console.WriteLine(Num5);

    //pars() and tryPars()

    string numberStr = "32414";

    int numInt, numberInt = int.Parse(numberStr);

    Console.WriteLine(numberInt);

    string numStr = Console.ReadLine();
    bool numBool = int.TryParse(numStr, out int result);
    if (numBool)
    {
        Console.WriteLine(numStr);

    }
    else
    {
        Console.WriteLine("Your result " + numStr.GetTypeCode() + " can not convert System.int");
    }

    //sizeof(). typeof()

    string var1 = "Hello World";
    string var2 = sizeof(int).ToString();
    Console.WriteLine(var2);

    bool result1 = var1.GetType() != typeof(int);
    if (result1)
    {
        Console.WriteLine("This is true");

    }
    else
    {
        Console.WriteLine("This is false");
    }

    bool result3 = var1 is string;

    long b = 12;

    int? c = b as int?;

    //null

    Type Var1 = null;
    int? Var2 = null;

    /// <summary>
    /// Bu metodun icinde 90-a vurma emeliyyati icra olunur
    /// </summary>
    /// <param name = "a">Daxil etdiyiniz parametr 900000000 ededine vurulacaq</param>
    /// <returns>Reqem daxil edin</returns>
    static int metodum(int a)
    {
        int b = 0;
        try
        {
            checked
            {
                b = 900000000 * a;
            }
            Console.WriteLine(b);
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Yazdiginiz tam eded int limitini kecir");
        }

        return b;
    }
}

static void tapsiriq1()
{
    static void Tick(object stateInfo)
    {
        Console.Clear();
    }
yeniden_yaz:
    Console.ReadLine();
    Console.Write("1-ci ededi daxil edin -- ");
    bool num1Bool = int.TryParse(Console.ReadLine(), out int num1);
    Console.Write("2-ci ededi daxil edin -- ");
    bool num2Bool = int.TryParse(Console.ReadLine(), out int num2);
    if (num1Bool && num2Bool)
    {
        if (num1 % 2 == 1)
        {
            bool cavab = num1 % 2 == 1;
            Console.WriteLine("Daxil Etdiyiniz 1-ci eded tek ededdir. Cavabiniz " + cavab);
        }
        else
        {
            bool cavab = num1 % 2 == 1;
            Console.WriteLine("Daxil etdiyiniz 2-ci eded cut ededdir. Cavabiniz " + cavab);
        }
        if (num2 % 2 == 1)
        {
            bool cavab = num2 % 2 == 1;
            Console.WriteLine("Daxil etdiyiniz 2-ci eded tek ededdir. Cavabiniz " + cavab);
        }
        else
        {
            bool cavab = num2 % 2 == 1;
            Console.WriteLine("Daxil etdiyiniz 2-ci eded cut ededdir. Cavabiniz " + cavab);
        }
    }
    else if (num1Bool == false || num2Bool == false)
    {
        if (num1.Equals(default) || num2.Equals(default))
        {
            Console.WriteLine("Siz int limitini asirsiz.");
            TimerCallback callback = new TimerCallback(Tick);
            Timer timer = new Timer(callback, null, 4000, 0);


        }
        goto yeniden_yaz;
    }

}

static void tapsiriq2()
{
    string str1 = Console.ReadLine();
    string str2 = Console.ReadLine();
    bool cavab = str1.Contains(str2);
    if (cavab) { Console.WriteLine("Daxil edilen 2-ci soz 1-ci sozun icinde var"); }
    else { Console.WriteLine("Daxil etdiyiniz 2-ci soz 1-ci sozun icinde yoxdu"); }
}

static void tapsiriq3()
{
    int num1, num2;
    Console.Write("Boluneni daxil edin -- ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Boleni daxil edin -- ");
    num2 = int.Parse(Console.ReadLine());
    float cavab = (float)num1 / num2;
    Console.WriteLine("Cavabiniz -- {0}", cavab);

}


