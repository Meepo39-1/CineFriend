using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.StrategyDesignPattern
{
    public class AudioPlayerStrategy: IApreciationStrategy
    {
       
       public void Play(AudioInfo sound)
        {
            Console.WriteLine(sound + "is being played...");
        }

        public void SendApreciation(AudioInfo info )
        {
               Play.(info);
        }
    }
}
