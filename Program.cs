using System;
class Program {
    static void Main ()
    {
        Console.Write("numberOfcities: ");
        int numberOfCities = int.Parse(Console.ReadLine());

        City[] cities = new City[numberOfCities];

        for (int i = 0; i < numberOfCities; i++)
        {
            Console.WriteLine("CityNumber {i}");
            Console.Write("Cityname: ");
            string Cityname = Console.ReadLine();

            Console.Write("PopuInCity: ");
            int population = int.Parse(Console.ReadLine());

            cities[i] = new City(i, Cityname, population);
        }

        Console.WriteLine("AllInfoOfCity: ");
        foreach (City city in cities)
        {
            Console.WriteLine(city.GetCityInfo());
        }
    }
}
class City
{
    private int cityID;
    private string cityName;
    private int population;
    
    public City(int id, string name, int pop)
    {
        cityID = id;
        cityName = name;
        population = pop;
    }
    public string GetCityInfo()
    {
        return "CityNumber {cityID}: {cityName}, PopuInCity {population}:";
    }
}