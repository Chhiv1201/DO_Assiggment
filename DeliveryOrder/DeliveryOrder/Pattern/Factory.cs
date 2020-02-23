using DeliveryOrder.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Pattern
{
    class Factory
    {/// <summary>
     /// The 'Product' interface
     /// </summary>
        public interface IDeriverFactory
        {
            void InsertDriver(string userID, string Name, string gender, DateTime bd, string drivinglicence, DateTime expiryDate); 
            void UpdateDriver (string ProductID, string TakerID);
            void DriverIsFree(string driverID);

            dynamic getAllDriver();
        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>
        public class CarDriver_ : IDeriverFactory
        {
            public void InsertDriver(string userID, string Name, string gender, DateTime bd, string drivinglicence, DateTime expiryDate)
            {
                using (DODataContext db_ = new DODataContext())
                {
                    operation op = new operation();
                    CarDriver driver = new CarDriver()
                    {
                        ID = op.NewID(),
                        BirthDate=bd,
                        drivingLicenceNumber=drivinglicence,
                        expiryDate=expiryDate,
                        Gender=gender,
                        StaffName=Name,
                        UserID=userID,
                        Working=false

                    };


                    db_.CarDrivers.InsertOnSubmit(driver);

                    db_.SubmitChanges();
                }



                //Console.WriteLine("Drive the Scooter : " + product.ToString() + "km");

            }
            public void UpdateDriver(string ProductID, string TakerID)
            {
                using (DODataContext db_ = new DODataContext())
                {
                    var products = db_.Products.Where(x => x.ID == ProductID).ToList();
                    var drivers = db_.CarDrivers.Where(x => x.ID == TakerID).ToList();
                    if (products.Count > 0 && drivers.Count>0) 
                    {
                        var product = products.FirstOrDefault();
                        var driver = drivers.FirstOrDefault();

                        product.Status = "Delivering";
                        product.TakeDate = DateTime.Now;
                        product.TakeBy = TakerID;



                        driver.Working = true;
                    }
                    db_.SubmitChanges();

                }



                //Console.WriteLine("Drive the Scooter : " + product.ToString() + "km");

            }
            public void DriverIsFree(string driverID)
            {
                using (DODataContext db_ = new DODataContext())
                {
                    var drivers = db_.CarDrivers.Where(x => x.ID == driverID).ToList();
                    if (drivers.Count > 0)
                    {
                        var driver = drivers.FirstOrDefault();
                        
                        driver.Working = false;
                    }
                    db_.SubmitChanges();

                }
            }
            public dynamic getAllDriver()
            {
                using (DODataContext db_ = new DODataContext())
                {



                    return db_.CarDrivers.ToList();

                }
            }

            
        }

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>
        public class MotoDriver_ : IDeriverFactory
        {
            public void InsertDriver(string userID, string Name, string gender, DateTime bd, string drivinglicence, DateTime expiryDate)
            {
                using (DODataContext db_ = new DODataContext())
                {
                    operation op = new operation();
                    MotoDriver driver = new MotoDriver()
                    {
                        ID = op.NewID(),
                        BirthDate = bd,
                        drivingLicenceNumber = drivinglicence,
                        expiryDate = expiryDate,
                        Gender = gender,
                        StaffName = Name,
                        UserID = userID,
                        Working = false
                    };
                    db_.MotoDrivers.InsertOnSubmit(driver);

                    db_.SubmitChanges();
                }



                //Console.WriteLine("Drive the Scooter : " + product.ToString() + "km");

            }
            public void UpdateDriver(string ProductID, string TakerID)
            {
                using (DODataContext db_ = new DODataContext())
                {
                    var products = db_.Products.Where(x => x.ID == ProductID).ToList();
                    var drivers = db_.MotoDrivers.Where(x => x.ID == TakerID).ToList();
                    if (products.Count > 0 && drivers.Count > 0)
                    {
                        var product = products.FirstOrDefault();
                        var driver = drivers.FirstOrDefault();

                        product.Status = "Delivering";
                        product.TakeDate = DateTime.Now;
                        product.TakeBy = TakerID;

                        
                        driver.Working = true;
                    }

                }

                //Console.WriteLine("Drive the Scooter : " + product.ToString() + "km");
            }
            public void DriverIsFree(string driverID)
            {
                using (DODataContext db_ = new DODataContext())
                {
                    var drivers = db_.MotoDrivers.Where(x => x.ID == driverID).ToList();
                    if (drivers.Count > 0)
                    {
                        var driver = drivers.FirstOrDefault();

                        driver.Working = false;
                    }
                    db_.SubmitChanges();

                }
            }

            public dynamic getAllDriver()
            {
                using (DODataContext db_ = new DODataContext())
                {
                    
                    return db_.MotoDrivers.ToList();

                }
            }
        }

        /// <summary>
        /// The Creator Abstract Class
        /// </summary>
        public abstract class DriverCreator
        {
            public abstract IDeriverFactory GetDriver(string Driver);

        }

        /// <summary>
        /// A 'ConcreteCreator' class
        /// </summary>
        public class CreateDriver : DriverCreator
        {
            public override IDeriverFactory GetDriver(string Driver)
            {
                switch (Driver)
                {
                    case "car driver":
                        return new CarDriver_();
                    case "moto driver":
                        return new MotoDriver_();
                    default:
                        throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Driver));
                }
            }
        }

        /// <summary>
        /// Factory Pattern Demo
        /// </summary>
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        VehicleFactory factory = new ConcreteVehicleFactory();

        //        IFactory scooter = factory.GetVehicle("Scooter");
        //        scooter.Drive(10);

        //        IFactory bike = factory.GetVehicle("Bike");
        //        bike.Drive(20);

        //        Console.ReadKey();

        //    }
        //}

    }
}
