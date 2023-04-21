// See https://aka.ms/new-console-template for more information


using System.Collections.Generic;
using Yield;

// PrintName(1_000_000);

var five = Get5();

foreach (var item in five)
{
    Console.WriteLine(item);
}

static IEnumerable<int> Get5()
{
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
    yield return 5;
}
static void PrintName(int n)
{
    var peps = MyGuys(n);
    foreach (Person person in peps)
    {
        if (person.Id < 1000)
        {
            Console.WriteLine(person.Name);
        }
        else
        {
            break;
        }
    }
}
static IEnumerable<Person> MyGuys(int n)
{
	for (int i = 0; i < n; i++)
	{
		yield return new Person { Id = i, Name = "name-" + i.ToString() }; 
	}
}



Console.Read();