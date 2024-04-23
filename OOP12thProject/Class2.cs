
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Employee : CLient
{
    List<string> Flights = new List<string>();


    public Employee()
    {

    }
    public void AddFlights(string b)
    {
        Flights.Add(b);

    }
    public void RemoveFlights(string b)
    {
        Flights.Remove(b);
    }
    public void ShowFlights()
    {
        foreach (var f in Flights)
        {
            Console.WriteLine(f);
        }
    }
}

