


/*List<iEntity>catalogs=new List<iEntity> ();
catalogs.Add(new User());
public class TecnicUser : BasicUser
{
    public override iEntity CreateUser()
    {
        TecnicUser tecnicUser = new TecnicUser();
        return tecnicUser;
    }

    public override int Delete(string whereClouse)
    {
        throw new NotImplementedException();
    }

    public override iEntity Get(string whereClouse)
    {
        throw new NotImplementedException();
    }

    public override List<iEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override List<iEntity> GetAll(string whereClouse)
    {
        throw new NotImplementedException();
    }

    public override iEntity Insert(string values)
    {
        throw new NotImplementedException();
    }

    public override iEntity Update(string values, string whereClouse)
    {
        throw new NotImplementedException();
    }
}

public class User : BasicUser
{
    public override iEntity CreateUser()
    {
        User usuario = new User();
        return usuario;
    }

    public override int Delete(string whereClouse)
    {
        throw new NotImplementedException();
    }

    public override iEntity Get(string whereClouse)
    {
        throw new NotImplementedException();
    }

    public override List<iEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override List<iEntity> GetAll(string whereClouse)
    {
        throw new NotImplementedException();
    }

    public override iEntity Insert(string values)
    {
        throw new NotImplementedException();
    }

    public override iEntity Update(string values, string whereClouse)
    {
        throw new NotImplementedException();
    }
}

public abstract class BasicUser : iEntity
{
    public int id { get; set; }
    public string name { get; set; }
    public abstract int Delete(string whereClouse);
    public abstract iEntity Get(string whereClouse);
    public abstract List<iEntity> GetAll();
    public abstract List<iEntity> GetAll(string whereClouse);
    public abstract iEntity Insert(string values);
    public abstract iEntity Update(string values, string whereClouse);

    public abstract iEntity CreateUser();
}

public abstract class Entity : iEntity
{
    public abstract int Delete(string whereClouse);
    public abstract iEntity Get(string whereClouse);
    public abstract List<iEntity> GetAll();
    public abstract List<iEntity> GetAll(string whereClouse);
    public abstract iEntity Insert(string values);
    public abstract iEntity Update(string values, string whereClouse);
}

public interface iEntity
{
    public iEntity Insert(string values);
    public iEntity Update(string values, string whereClouse);
    public int Delete(string whereClouse);
    public iEntity Get(string whereClouse);
    public List<iEntity> GetAll();
    public List<iEntity> GetAll(string whereClouse);
}
*/

//using System.Numerics;
///PATRON OPEN/CLOSED
/*public class Order
{
    lineItem[]lineItems;
    Shipping shipping;

    public int getTotal()
    {
        return 10;
    }

    public double getTotalWeigth() {
        return 1.5;
    }

    public void setShippingType(Shipping shipping) { 

    }

    public string getShippingCost()
    {
        return shipping.getCost(this).ToString();
    }

    public string getShippingDate()
    {
        return shipping.getDate(this);
    }
}

public class Ground : Shipping
{
    public double getCost(Order order)
    {
        if (order.getTotal()>100)
        {
            return 0;
        }

        return Math.Max(10, order.getTotalWeigth() * 1.5);
    }

    public string getDate(Order order)
    {
        return new DateTime().ToLongDateString();
    }
}

public class Fly : Shipping
{
    public double getCost(Order order)
    {
        if (order.getTotal() > 100)
        {
            return 50;
        }

        return Math.Max(100, order.getTotalWeigth() * 1.5);
    }

    public string getDate(Order order)
    {
        return new DateTime().ToLongDateString();
    }
}

public interface Shipping
{
    public double getCost(Order order);
    public string getDate(Order order);
}

class lineItem
{
    
}*/


///PATRON ESTRATEGY
/*class Transport
{
    private Engine engine;
    private Driver driver;
    public string deliver(string destination, string cargo) { 
        return destination;
    }
}

class CombustionEngine : Engine
{
    public string Move()
    {
        return "CombustionEngine()";
    }
}

class ElectricEngine : Engine
{
    public string Move()
    {
        return "ElectricEngine";
    }
}

class Human : Driver
{
    public string navigate()
    {
        return "Human";
    }
}

class DriverSystem : Driver
{
    public string navigate()
    {
        return "Driver System";
    }
}

public interface Engine {
    string Move();
}

public interface Driver
{
    string navigate();
}
*/


////FactoryMethod
/*Employee[]employes = new Employee[] {
    new Designer(),
    new Programer(),
    new Tester()
};

foreach (Employee employee in employes){
   Console.WriteLine(employee.doWork());
}

abstract class Company
{
   public abstract Employee[] GetEmployees();
}

class GameDev : Company
{
    public override Employee[] GetEmployees()
    {
        return new Employee[] {
            new Designer(),
            new Artis()
        };
    }
}

class OutSourcing : Company
{
    public override Employee[] GetEmployees()
    {
        return new Employee[] {
            new Programer(),
            new Tester()
        };
    }
}

class Designer : Employee
{
    public string doWork()
    {
        return "Diseñar";
    }
}

class Programer : Employee
{
    public string doWork()
    {
        return "Codificar";
    }
}

class Tester : Employee
{
    public string doWork()
    {
        return "Probar apps";
    }
}

class Artis : Employee
{
    public string doWork()
    {
        return "Draw";
    }
}

public interface Employee
{
    string doWork();
}*/
