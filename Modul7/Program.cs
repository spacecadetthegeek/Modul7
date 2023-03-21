using System;
abstract class Delivery
{
    public string Address;
    protected string Track;

}

public class Insurance
{
    public void Add()
    {
        Console.WriteLine("Insurance Add.");
    }

    public void Disable()
    {
        Console.WriteLine("Insurance Disable.");
    }
}

class HomeDelivery : Delivery
{
        private string CourierCompany;

        public string Couriercompany
        {
            get { return CourierCompany; }
            set { CourierCompany = value; }
        }

    private Insurance insurance = new Insurance();

    public void Add()
    {
        insurance.Add();
    }

    public void Disable()
    {
        insurance.Disable();
    }
}

class PickPointDelivery : Delivery
{
    private Insurance insurance = new Insurance();

    public void Add()
    {
        insurance.Add();
    }

    public void Disable()
    {
        insurance.Disable();
    }
}

class ShopDelivery : Delivery
{
    private Insurance insurance = new Insurance();

    public void Add()
    {
        insurance.Add();
    }

    public void Disable()
    {
        insurance.Disable();
    }
}

public class Product
{

    public virtual void TypeProduct()
    {
        Console.WriteLine("Тип вашего продукта пока не выбран");
    }
}

class Clothing : Product
{
    public override void TypeProduct()
    {
        Console.WriteLine("Тип ващего товара: Одежда");
    }

}
public class Person
{
    private static int count = 0;

    public static int Count
    {
        get { return count; }
    }

    private string firstName;
    private string lastName;

    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        count++;
    }

    public static void PrintInfo()
    {
        Console.WriteLine("Total number of Person instances created: " + count);
    }
}




class Order<TDelivery,
TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

    Person p1 = new Person("John", "Doe");
    Person p2 = new Person("Jane", "Doe");
   

}

