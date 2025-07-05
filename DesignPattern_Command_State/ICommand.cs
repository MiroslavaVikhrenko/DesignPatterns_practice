using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Команды:
1) Turn On Command: Команда для включения телевизора. 
2) Turn Off Command: Команда для выключения телевизора. 
3) Change Channel Command: Команда для смены канала. 
4) Increase Volume Command: Команда для увеличения громкости. 
5) Decrease Volume Command: Команда для уменьшения громкости. 
6) Mute Command: Команда для выключения звука (без изменения громкости). 
7) Unmute Command: Команда для восстановления звука.
 */

namespace DesignPattern_Command_State
{
    public interface ICommand
    {
        void Execute();
    }

    public class TurnOnCommand : ICommand
    {
        private readonly Tv _tv;
        public TurnOnCommand(Tv tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.TurnOn();
        }
    }

    public class TurnOffCommand : ICommand
    {
        private readonly Tv _tv;
        public TurnOffCommand(Tv tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.TurnOff();
        }
    }

    public class ChangeChannelCommand : ICommand
    {
        private readonly Tv _tv;
        private readonly int _channel;
        public ChangeChannelCommand(Tv tv, int channel)
        {
            _tv = tv;
            _channel = channel;
        }
        public void Execute()
        {
            _tv.Channel = _channel;
            Console.WriteLine($"Changing channel to {_channel}");
        }
    }

    public class IncreaseVolumeCommand : ICommand
    {
        private readonly Tv _tv;
        public IncreaseVolumeCommand(Tv tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.Volume++;
            Console.WriteLine($"Volume increased to {_tv.Volume}");
        }
    }

    public class DecreaseVolumeCommand : ICommand
    {
        private readonly Tv _tv;
        public DecreaseVolumeCommand(Tv tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.Volume--;
            Console.WriteLine($"Volume decreased to {_tv.Volume}");
        }
    }

    public class MuteCommand : ICommand
    {
        private readonly Tv _tv;
        public MuteCommand(Tv tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.IsMuted = true;
            Console.WriteLine("TV is muted");
        }
    }

    public class UnmuteCommand : ICommand
    {
        private readonly Tv _tv;
        public UnmuteCommand(Tv tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.IsMuted = false;
            Console.WriteLine("TV is unmuted");
        }
    }
}
