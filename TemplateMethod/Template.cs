using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class CoffeeTemplate
    {
        public void MakeCoffee()
        {
            BoilWater();
            GrindCoffee();
            PourInCup();
            AddCondiments();
        }

        protected void BoilWater()
        {
            Console.WriteLine("烧水");
        }

        protected void PourInCup()
        {
            Console.WriteLine("倒杯");
        }
        
        protected abstract void GrindCoffee();

        protected abstract void AddCondiments();

    }


    class AmericanoCoffee : CoffeeTemplate
    {
        protected override void GrindCoffee()
        {
            Console.WriteLine("加入美式咖啡豆，研磨");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("加水");
        }
    }

    class LatteCoffee : CoffeeTemplate
    {
        protected override void GrindCoffee()
        {
            Console.WriteLine("加入拿铁咖啡豆研磨");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("加牛奶");
        }
    }

}
