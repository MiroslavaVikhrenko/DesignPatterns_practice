using DesignPattern_Command_State.Commands;
using DesignPattern_Command_State.Interfaces;

namespace DesignPattern_Command_State
{
    /*
     Реализовать систему управления телевизором, которая будет использовать два паттерна: 
Command: для инкапсуляции команд, таких как включение телевизора, выключение и смена канала. 
State: для представления различных состояний телевизора, таких как включен или выключен.

Команды:
1) Turn On Command: Команда для включения телевизора. 
2) Turn Off Command: Команда для выключения телевизора. 
3) Change Channel Command: Команда для смены канала. 
4) Increase Volume Command: Команда для увеличения громкости. 
5) Decrease Volume Command: Команда для уменьшения громкости. 
6) Mute Command: Команда для выключения звука (без изменения громкости). 
7) Unmute Command: Команда для восстановления звука.

Состояния:
1) OffState (выключен): Телевизор выключен, все действия с ним невозможны, за исключением команды включения. 
2) OnState (включен): Телевизор включен, можно менять канал, увеличивать/уменьшать громкость, включать/выключать звук. 
3) MutedState (без звука): Телевизор включен, но звук выключен. В этом состоянии можно восстанавливать звук или менять 
    громкость (при этом звука не будет, пока не будет восстановлен звук).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var tv = new Television();

            var commands = new ICommand[]
            {
                new TurnOnCommand(tv),
                new ChangeChannelCommand(tv, 5),
                new IncreaseVolumeCommand(tv),
                new MuteCommand(tv),
                new IncreaseVolumeCommand(tv),
                new UnmuteCommand(tv),
                new DecreaseVolumeCommand(tv),
                new TurnOffCommand(tv)
            };

            foreach (var command in commands)
            {
                command.Execute();
                Console.WriteLine();
            }
        }
    }
}
