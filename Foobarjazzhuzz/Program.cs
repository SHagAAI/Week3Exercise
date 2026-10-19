// dotnet new sln --format sln -n Week2Exercise
// dotnet new console -n Foobarjazz 
// dotnet sln Week2Exercise.sln add Foobarjazz/Foobarjazz.csproj

int maxNum = 150;

var numbers = Enumerable.Range(1, maxNum);
string foobarjazz = string.Empty;

foreach (int num in numbers)
{

    if (num % 3 == 0)
    {
        foobarjazz += "foo";
    }

    if (num % 4 == 0)
    {
        foobarjazz += "baz";
    }

    if (num % 5 == 0)
    {
        foobarjazz += "bar";
    }

    if (num % 7 == 0)
    {
        foobarjazz += "jazz";
    }

    if (num % 9 == 0)
    {
        foobarjazz += "huzz";
    }


    
    if (foobarjazz != string.Empty)
    {
        Console.WriteLine($"{num} : {foobarjazz}");
    }
    foobarjazz = string.Empty;

}