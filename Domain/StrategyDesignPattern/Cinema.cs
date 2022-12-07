using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.StrategyDesignPattern
{
    public class Cinema
    {

        ApreciationContext ApreciationContext { get; set; }
        AudioPlayerStrategy AudioPlayerStrategy { get; set; }
        CinemaViewStrategy CinemaViewStrategy { get; set; }
        ChatStrategy chatStrategy { get; set; }
        public void ShowVideoApreciation()
        {
            ApreciationContext.SetStrategy(AudioPlayerStrategy);

        }
        public void ShowAudioApreciation()
        {
            ApreciationContext.SetStrategy(AudioPlayerStrategy);
        }
        public void ShowWrittenApreciation()
        {
            ApreciationContext.SetStrategy(AudioPlayerStrategy);
        }

        public void Main()
        {
          
        }
    }
}
