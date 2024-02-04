using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Car
    {   //private 
        private string _name;//storing data
        private int _hp;
        private string _color;
       public Car(string name, int hp = 0,string color = "black")
        {
            
            _name = name;
            Console.WriteLine(name+ "Car was created");
            _hp = hp;
            _color = color;
        }
        public void Drive()
        {
            Console.WriteLine(_name + " is driving");
        }
        public void Stopped()
        {
            Console.WriteLine(_name + " stopped");
        }
        public void Deatils()
        {
            Console.WriteLine("Car " +_name+ " has " +_hp+" and its "+_color);
        }
    }
}

