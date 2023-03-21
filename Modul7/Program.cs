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
    public string FirstName;
    public string LastName;

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
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

    
    Person person = new Person("Иван", "Иванов");

}

