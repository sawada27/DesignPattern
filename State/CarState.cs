using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    /// <summary>
    /// 状态接口类
    /// </summary>
    public interface ICarState
    {
        /// <summary>
        /// 启动
        /// </summary>
        void Drive(Car car);

        /// <summary>
        /// 停车
        /// </summary>
        void Stop(Car car);

        /// <summary>
        /// 加速
        /// </summary>
        /// <param name="car"></param>
        void SpeedUp(Car car);

        /// <summary>
        /// 减速
        /// </summary>
        /// <param name="car"></param>
        void SpeedDown(Car car);
    }


    /// <summary>
    /// 运行状态
    /// </summary>
    public class RuningState : ICarState
    {
        public void Drive(Car car)
        {
            Console.WriteLine("车辆正在自动驾驶！");
        }

        public void Stop(Car car)
        {
            Console.WriteLine("车辆已停止！");
            car.CurrentCarState = Car.StopState;
        }

        public void SpeedUp(Car car)
        {
            Console.WriteLine("路况良好，开始加速行驶！");
            car.CurrentCarState = Car.SpeedUpState;
        }

        public void SpeedDown(Car car)
        {
            Console.WriteLine("路况一般，开始加速行驶！");
            car.CurrentCarState = Car.SpeedDownState;
        }
    }


    /// <summary>
    /// 停车状态
    /// </summary>
    public class StopState : ICarState
    {
        public void Drive(Car car)
        {
            Console.WriteLine($"{car.Name}已启动，开始自动驾驶！");
            car.CurrentCarState = Car.RunState;
        }

        public void Stop(Car car)
        {
            Console.WriteLine("车辆已停止！");
        }

        public void SpeedUp(Car car)
        {
            Console.WriteLine("车辆已停止！");
        }

        public void SpeedDown(Car car)
        {
            Console.WriteLine("车辆已停止！");
        }
    }


    /// <summary>
    /// 加速状态
    /// </summary>
    public class SpeedUpState : ICarState
    {
        public void Drive(Car car)
        {
            Console.WriteLine("车辆正在自动驾驶！");
        }

        public void Stop(Car car)
        {
            Console.WriteLine("车辆已停止！");
            car.CurrentCarState = Car.StopState;
        }

        public void SpeedUp(Car car)
        {
            Console.WriteLine("车辆正在加速行驶！");
        }

        public void SpeedDown(Car car)
        {
            Console.WriteLine("路况一般，减速行驶！");
            car.CurrentCarState = Car.SpeedDownState;
        }
    }

    /// <summary>
    /// 减速状态
    /// </summary>
    public class SpeedDownState : ICarState
    {
        public void Drive(Car car)
        {
            Console.WriteLine("车辆正在自动驾驶！");
        }

        public void Stop(Car car)
        {
            Console.WriteLine("车辆已停止！");
            car.CurrentCarState = Car.StopState;
        }

        public void SpeedUp(Car car)
        {
            Console.WriteLine("路况良好，加速行驶！");
            car.CurrentCarState = Car.SpeedUpState;
        }

        public void SpeedDown(Car car)
        {
            Console.WriteLine("车辆正在减速行驶！");
        }
    }

}
