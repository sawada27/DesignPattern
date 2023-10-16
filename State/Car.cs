using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Car
    {
        public string Name { get; set; }

        public Car()
        {
            this.CurrentCarState = StopState;//初始状态为停车状态
        }

        internal static ICarState StopState = new StopState();
        internal static ICarState RunState = new RuningState();
        internal static ICarState SpeedUpState = new SpeedUpState();
        internal static ICarState SpeedDownState = new SpeedDownState();

        public ICarState CurrentCarState { get; set; }

        public void Run()
        {
            
            //StopState =>RunState
            this.CurrentCarState.Drive(this);
        }

        public void Stop()
        {
            //        =>StopState
            this.CurrentCarState.Stop(this);
        }

        public void SpeedUp()
        {
             //  xxState    =>  SpeedUpState
            this.CurrentCarState.SpeedUp(this);
        }
        public void SpeedDown()
        {
            //  xxState    =>  SpeedDownState
            this.CurrentCarState.SpeedDown(this);
        }
    }
}
