using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Pattern
{
    public class Builder
    {
        // The Builder interface specifies methods for creating the different parts
        // of the Product objects.
        public interface IBuilder
        {
            void BuildUserFirstStep(dynamic user);

            void BuildUserSecondStep(dynamic user);

            UserBuilder GetBuilder();
        }

        // The Concrete Builder classes follow the Builder interface and provide
        // specific implementations of the building steps. Your program may have
        // several variations of Builders, implemented differently.
        public class SubBuilder : IBuilder
        {
            private UserBuilder user_ = new UserBuilder();

            // A fresh builder instance should contain a blank product object, which
            // is used in further assembly.
            public SubBuilder()
            {
                this.Reset();
            }

            public void Reset()
            {
                this.user_ = new UserBuilder();
            }

            // All production steps work with the same product instance.
            public void BuildUserFirstStep(dynamic user)
            {
                this.user_.Add(Step.FirstStep.ToString(), user);
            }

            public void BuildUserSecondStep(dynamic user)
            {
                this.user_.Add(Step.SecondStep.ToString(), user);
            }

            // Concrete Builders are supposed to provide their own methods for
            // retrieving results. That's because various types of builders may
            // create entirely different products that don't follow the same
            // interface. Therefore, such methods cannot be declared in the base
            // Builder interface (at least in a statically typed programming
            // language).
            //
            // Usually, after returning the end result to the client, a builder
            // instance is expected to be ready to start producing another product.
            // That's why it's a usual practice to call the reset method at the end
            // of the `GetProduct` method body. However, this behavior is not
            // mandatory, and you can make your builders wait for an explicit reset
            // call from the client code before disposing of the previous result.
            public UserBuilder GetBuilder()
            {
                UserBuilder result = this.user_;

                //this.Reset();

                return result;
            }
        }

        // It makes sense to use the Builder pattern only when your products are
        // quite complex and require extensive configuration.
        //
        // Unlike in other creational patterns, different concrete builders can
        // produce unrelated products. In other words, results of various builders
        // may not always follow the same interface.
        public class UserBuilder
        {
            private Dictionary<string, dynamic> user_ = new Dictionary<string, dynamic>();
            private Step step_= Step.Initialize;


            Step checkKey(string key)
            {
                try
                {
                    Step step = (Step)(Enum.Parse(typeof(Step), (key), true));
                    return step;
                }
                catch (Exception)
                {
                    throw new Exception("key not allow");
                }
            }
            public void Add(string key,dynamic data)
            {
                Step step=0;
                if (!user_.ContainsKey(key))
                {
                    step= checkKey(key);
                    this.user_.Add(key, data);
                    step_ = step;
                }
                else
                {
                    throw new Exception("key exist");
                }
                
            }
            public void Update(string key, dynamic data)
            {
                if (user_.ContainsKey(key))
                {
                    this.user_[key]=data;
                }
                else
                {
                    throw new Exception("key not found");
                }

            }

            public void Remove(string key, dynamic data)
            {
                if (user_.ContainsKey(key))
                {
                    this.user_.Remove(key);
                }
                else
                {
                    throw new Exception("key not found");
                }

            }
            public List<dynamic> ContainsObject()
            {
                return user_.Values.ToList();
            }
            //public dynamic GetUserInfo(string key)
            //{
            //    if (user_.ContainsKey(key))
            //    {
            //        return user_[key];
            //    }
            //    else
            //    {
            //        throw new Exception("key not found");
            //    }
            //}
            public dynamic GetUserFirstStep()
            {
                if (user_.ContainsKey(Step.FirstStep.ToString()))
                {
                    return user_[Step.FirstStep.ToString()];
                }
                else
                {
                    throw new Exception("key not found");
                }
            }
            public dynamic GetUserSecondStep()
            {
                if (user_.ContainsKey(Step.SecondStep.ToString()))
                {
                    return user_[Step.SecondStep.ToString()];
                }
                else
                {
                    throw new Exception("key not found");
                }
            }
        }
        public enum Step
        {
            Initialize = 0,
            FirstStep = 1,
            SecondStep = 2
        }

        // The Director is only responsible for executing the building steps in a
        // particular sequence. It is helpful when producing products according to a
        // specific order or configuration. Strictly speaking, the Director class is
        // optional, since the client can control builders directly.
        public class Director
        {
            private IBuilder _builder;

            public IBuilder Builder
            {
                set { _builder = value; }
            }

            // The Director can construct several product variations using the same
            // building steps.

            public void CreateUserFirstStep(dynamic user)
            {
                _builder.BuildUserFirstStep(user);
            }
            public void CreateUserSecondStep(dynamic user)
            {
                _builder.BuildUserSecondStep(user);
            }


            public UserBuilder GetUserBuilder()
            {
                return _builder.GetBuilder();
            }

        }

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        // The client code creates a builder object, passes it to the
        //        // director and then initiates the construction process. The end
        //        // result is retrieved from the builder object.
        //        var director = new Director();
        //        var builder = new ConcreteBuilder();
        //        director.Builder = builder;

        //        Console.WriteLine("Standard basic product:");
        //        director.buildMinimalViableProduct();
        //        Console.WriteLine(builder.GetProduct().ListParts());

        //        Console.WriteLine("Standard full featured product:");
        //        director.buildFullFeaturedProduct();
        //        Console.WriteLine(builder.GetProduct().ListParts());

        //        // Remember, the Builder pattern can be used without a Director
        //        // class.
        //        Console.WriteLine("Custom product:");
        //        builder.BuildPartA();
        //        builder.BuildPartC();
        //        Console.Write(builder.GetProduct().ListParts());
        //    }
        //}
    }
}
