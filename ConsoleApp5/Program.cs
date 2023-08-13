using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /// <summary>
    /// интерфес выстрел
    /// </summary>
    public  interface Shooting
    {
       void Shoting();
    }
    //класс реализует выстрел из пистолета 
    internal class Shoting_PIstolet : Shooting
    {
        public void Shoting()
        {
            Console.WriteLine("Выстрел из пистолета");
        }
    }
    //класс реализует интерфейс выстрел из автомата 
    public class Shoting_machineGun : Shooting
    {

        public void Shoting()
        {
            Console.WriteLine("Выстрел из автомата ");
        }

    }

    //интерфейс медицина
    public interface Medecine
    {
        void  Medicine();
    }
    //данный класс описывает оказание медицинских услуг персонажем 
    class MedicalServices:Medecine
    {
        public void Medicine()
        {
              Console.WriteLine("Может оказывать медицинские услуги");
        }
    }
    //данный класс описывает что данный передает сообщение что не может оказать услугуи 
    class NoMedicalSevices : Medecine
    {
        public void Medicine()
        {
            Console.WriteLine("Не может оказать медицинские услуги");
        }
    }
    /// <summary>
    ///  интерфейс описывает создание конструкций
    /// </summary>
    public interface Maker
    {
        void Maker();
    }

    /// <summary>
    /// данный класс реализует интерфейс создание конструкций 
    /// </summary>
    class СreatingStructures : Maker
    {
        public void Maker()
        {
            Console.WriteLine("Может создавать укрепления");
        } 
    }
    /// <summary>
    /// данный класс реализует интерфейс создания конструкций 
    /// </summary>
    class NoCreatingStructures : Maker
    {
        public void Maker()
        {
            Console.WriteLine("Не может создавать укрепления");
        }
    }

   public abstract class Persone
    {
        public Shooting shooting;
        public Maker maker;
        public Medecine medecine;

        public  Persone(){}

        public abstract void Display();

        public void Shoting()
        {
            shooting.Shoting();
        } 
        public void Maker()
        {
            maker.Maker();
        }
        public void Medicne()
        {
            medecine.Medicine();
        }


    }


    public class Medic : Persone
    {
        public Medic()
        {
            shooting = new Shoting_PIstolet();
            maker = new NoCreatingStructures();
            medecine = new MedicalServices();
        }
        
        public override void Display()
        {
            Console.Write("Я медик ");
        }
    }
    public class Solder : Persone
    {

        public Solder()
        {
            shooting = new Shoting_machineGun();
            maker = new NoCreatingStructures();
            medecine = new NoMedicalSevices();
        }



        public override void Display()
        {
            Console.WriteLine("Я солдат");
        }


    }

    public class Engineer:Persone
    {
        public Engineer()
        {
            shooting = new Shoting_PIstolet();
            maker = new СreatingStructures();
            medecine = new NoMedicalSevices();
        }


        public override void Display()
        {
            Console.WriteLine("Я инженер");
        }
    }











    internal class Program
    {
        static void Main(string[] args)
        {
            Persone persone = new Medic();
            persone.Maker();
            persone.Medicne();
            persone.Shoting();
            Console.ReadKey();

            Persone persone1 = new Solder();
            persone1.Maker();
            persone1.Medicne();
            persone1.Shoting();
            Console.ReadKey();

            var persone2 = new Engineer();
            persone2.Maker();
            persone2.Medicne();
            persone2.Shoting();
            Console.ReadLine();
            
        }
    }
}
