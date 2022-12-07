using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.StrategyDesignPattern
{
    public class CinemaViewStrategy : IApreciationStrategy
    {
        public void Render(AnimationInfo message)
        {
            Console.WriteLine("Rendering" + message + "...");
        }

        public void SendApreciation(Info animationInfo)
        {
            Render.(info);
        }

      \
    }
}
