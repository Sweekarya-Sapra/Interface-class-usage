using System;
namespace bas
{
    public interface ICar
    {
        void name();
        void model();
        void airBags();
        void topSpeed();
    }
    public class Thar : ICar
    {
        public void name()
        {
            Console.WriteLine("Name of car: Thar\n");
        }
        public void model()
        {
            Console.WriteLine("Model Year: 2000\n");
        }
        public void airBags()
        {
            Console.WriteLine("Number of tyres: 2\n");
        }
        public void topSpeed()
        {
            Console.WriteLine("Top speed: 120km/h\n");
        }
    }
    public class MGHector : ICar
    {
        public void name()
        {
            Console.WriteLine("Name of car: MGHector\n");
        }
        public void model()
        {
            Console.WriteLine("Model Year: 2000\n");
        }
        public void airBags()
        {
            Console.WriteLine("Number of tyres: 4\n");
        }
        public void topSpeed()
        {
            Console.WriteLine("Top speed: 180km/h\n");
        }
    }
    public class Cars
    {
        public static void Main(string[]args)
        {
            ICar i;
            i=new Thar();
            i.name();
            i.model();
            i.airBags();
            i.topSpeed();
            i= new MGHector();
            i.name();
        }
    }
}