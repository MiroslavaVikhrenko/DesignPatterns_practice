using DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat;
using DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Chat.Mediator;
using DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Game;
using DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator.Models;

namespace DesignPattern_TM_State_Iterator_Interpretor_COR_Mediator
{
    /*
     1. Создайте текстовую игру, где игрок перемещается по локациям (Room). Каждая локация:

1) Реализует Шаблонный метод, определяющий общий алгоритм взаимодействия с локацией: вход, описание, возможные действия.
2) Содержит Состояние (IRoomState), влияющее на поведение (например: "спокойная", "опасная", "заблокированная").
3) Используйте Итератор для обхода списка комнат, чтобы игрок мог "путешествовать" по квесту.

2. Вы разрабатываете текстового чат-бота для фэнтезийной игры, в которой игроки вводят команды 
    на естественном языке (в стиле cast fireball at goblin или defend against orc). 
    Система должна интерпретировать команды, обрабатывать их через цепочку логики, 
    и рассылать последствия другим участникам боя.

Реализуйте систему чат-команд, где игрок может вводить текст, и система:

1) Интерпретирует команды (например, cast fireball at goblin).
2) Обрабатывает их через Цепочку обязанностей (например, проверка маны, зоны действия, cooldown).
3) Уведомляет других участников боя (NPC или союзников) через Посредника.

Используемые паттерны:

1) Интерпретатор - определяет, какую команду ввел пользователь (cast, attack, defend), 
    а также парсит дополнительные параметры — цель, тип заклинания, и т.д.

2) Цепочка обязанностей - после интерпретации команда проходит через цепочку проверок: 
    достаточно ли у игрока маны, есть ли цель в зоне действия, не находится ли заклинание на кулдауне?
Каждая проверка может либо пропустить команду дальше, либо остановить выполнение с сообщением об ошибке.

3) Посредник - после успешного выполнения команды, бот уведомляет всех участников боя (других игроков, NPC), 
    используя паттерн посредника. Например, если игрок использовал fireball, все участники получают сообщение 
    о его действии.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ROOM EXPLORATION =====");
            var game = new GameEngine();
            game.Start();

            Console.WriteLine("\n===== BATTLE CHAT BOT =====");

            var mediator = new BattleMediator();
            mediator.Register("Player1");
            mediator.Register("Ally1");
            mediator.Register("NPC Goblin");

            var player = new Player("Player1");
            var bot = new ChatBot(mediator);

            while (true)
            {
                Console.Write("\nCommand: "); // cast fireball at goblin
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;

                bot.ProcessInput(input, player);
            }

        }
    }
}
