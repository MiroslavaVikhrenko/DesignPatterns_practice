namespace DesignPattern_State_Command2
{
    class Program
    {
        static void Main()
        {
            var tv = new Television();

            ICommand turnOn = new TurnOnCommand(tv);
            ICommand changeChannel = new ChangeChannelCommand(tv, 5);
            ICommand increaseVolume = new IncreaseVolumeCommand(tv);
            ICommand mute = new MuteCommand(tv);
            ICommand unmute = new UnmuteCommand(tv);
            ICommand turnOff = new TurnOffCommand(tv);

            turnOn.Execute();            // Включаем ТВ
            changeChannel.Execute();     // Смена канала
            increaseVolume.Execute();    // Громкость +
            mute.Execute();              // Звук выкл.
            increaseVolume.Execute();    // Громкость + без звука
            unmute.Execute();            // Включение звука
            turnOff.Execute();           // Выключение ТВ
        }
    }

    public interface ITvState
    {
        void TurnOn(Television tv);
        void TurnOff(Television tv);
        void ChangeChannel(Television tv, int channel);
        void IncreaseVolume(Television tv);
        void DecreaseVolume(Television tv);
        void Mute(Television tv);
        void Unmute(Television tv);
    }

    public class Television
    {
        private ITvState _state;

        public int Channel { get; set; } = 1;
        public int Volume { get; set; } = 10;

        public Television()
        {
            _state = new OffState();
        }

        public void SetState(ITvState newState) => _state = newState;

        public void TurnOn() => _state.TurnOn(this);
        public void TurnOff() => _state.TurnOff(this);
        public void ChangeChannel(int channel) => _state.ChangeChannel(this, channel);
        public void IncreaseVolume() => _state.IncreaseVolume(this);
        public void DecreaseVolume() => _state.DecreaseVolume(this);
        public void Mute() => _state.Mute(this);
        public void Unmute() => _state.Unmute(this);
    }

    public class OffState : ITvState
    {
        public void TurnOn(Television tv)
        {
            Console.WriteLine("The TV is on.");
            tv.SetState(new OnState());
        }

        public void TurnOff(Television tv) => Console.WriteLine("The TV is already turned off.");

        public void ChangeChannel(Television tv, int channel) => Console.WriteLine("Cannot change the channel. The TV is turned off.");

        public void IncreaseVolume(Television tv) => Console.WriteLine("The volume cannot be changed. The TV is turned off.");

        public void DecreaseVolume(Television tv) => Console.WriteLine("The volume cannot be changed. The TV is turned off.");

        public void Mute(Television tv) => Console.WriteLine("The sound cannot be turned off. The TV is turned off.");

        public void Unmute(Television tv) => Console.WriteLine("The sound cannot be turned on. The TV is turned off.");
    }
    public class OnState : ITvState
    {
        public void TurnOn(Television tv) => Console.WriteLine("The TV is already on.");

        public void TurnOff(Television tv)
        {
            Console.WriteLine("The TV is off.");
            tv.SetState(new OffState());
        }

        public void ChangeChannel(Television tv, int channel)
        {
            tv.Channel = channel;
            Console.WriteLine($"Channel changed to {channel}.");
        }

        public void IncreaseVolume(Television tv)
        {
            tv.Volume++;
            Console.WriteLine($"Volume increased to {tv.Volume}.");
        }

        public void DecreaseVolume(Television tv)
        {
            tv.Volume--;
            Console.WriteLine($"Volume reduced to {tv.Volume}.");
        }

        public void Mute(Television tv)
        {
            Console.WriteLine("Sound is off.");
            tv.SetState(new MutedState());
        }

        public void Unmute(Television tv) => Console.WriteLine("The sound is already on.");
    }
    public class MutedState : ITvState
    {
        public void TurnOn(Television tv) => Console.WriteLine("The TV is already on.");
        public void TurnOff(Television tv)
        {
            Console.WriteLine("The TV is off.");
            tv.SetState(new OffState());
        }
        public void ChangeChannel(Television tv, int channel)
        {
            tv.Channel = channel;
            Console.WriteLine($"Channel changed to {channel} (sound is muted).");
        }
        public void IncreaseVolume(Television tv)
        {
            tv.Volume++;
            Console.WriteLine($"Volume increased to {tv.Volume} (sound is muted).");
        }
        public void DecreaseVolume(Television tv)
        {
            tv.Volume--;
            Console.WriteLine($"Volume decreased to {tv.Volume} (sound is muted).");
        }
        public void Mute(Television tv) => Console.WriteLine("Sound is already muted.");
        public void Unmute(Television tv)
        {
            Console.WriteLine("Sound has been restored.");
            tv.SetState(new OnState());
        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public class TurnOnCommand : ICommand
    {
        private readonly Television _tv;

        public TurnOnCommand(Television tv) => _tv = tv;

        public void Execute() => _tv.TurnOn();
    }
    public class TurnOffCommand : ICommand
    {
        private readonly Television _tv;

        public TurnOffCommand(Television tv) => _tv = tv;

        public void Execute() => _tv.TurnOff();
    }
    public class ChangeChannelCommand : ICommand
    {
        private readonly Television _tv;
        private readonly int _channel;

        public ChangeChannelCommand(Television tv, int channel)
        {
            _tv = tv;
            _channel = channel;
        }

        public void Execute() => _tv.ChangeChannel(_channel);
    }
    public class IncreaseVolumeCommand : ICommand
    {
        private readonly Television _tv;
        public IncreaseVolumeCommand(Television tv) => _tv = tv;
        public void Execute() => _tv.IncreaseVolume();
    }
    public class DecreaseVolumeCommand : ICommand
    {
        private readonly Television _tv;
        public DecreaseVolumeCommand(Television tv) => _tv = tv;
        public void Execute() => _tv.DecreaseVolume();
    }
    public class MuteCommand : ICommand
    {
        private readonly Television _tv;
        public MuteCommand(Television tv) => _tv = tv;
        public void Execute() => _tv.Mute();
    }
    public class UnmuteCommand : ICommand
    {
        private readonly Television _tv;
        public UnmuteCommand(Television tv) => _tv = tv;
        public void Execute() => _tv.Unmute();
    }

}
