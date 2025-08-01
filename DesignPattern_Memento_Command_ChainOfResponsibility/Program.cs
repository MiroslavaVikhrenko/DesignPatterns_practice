using DesignPattern_Memento_Command_ChainOfResponsibility.Commands;
using DesignPattern_Memento_Command_ChainOfResponsibility.Core;
using DesignPattern_Memento_Command_ChainOfResponsibility.Models;
using DesignPattern_Memento_Command_ChainOfResponsibility.Users;

namespace DesignPattern_Memento_Command_ChainOfResponsibility
{
    internal class Program
    {
        /*
         У вас есть система редактирования текстового документа. Разные типы пользователей (например, 
        обычный пользователь, модератор и администратор) могут отправлять запросы на изменение документа: 
        вставить текст, удалить часть текста, заменить фрагмент.

У каждого типа пользователя свои права:
1) Обычный пользователь может только предлагать изменения (не применяются сразу).
2) Модератор может применить изменения, если они не затрагивают «запрещённые зоны».
3) Администратор может применять любые изменения.

Требования:

Chain of Responsibility — обработка изменений через цепочку ролей.
Command — каждая операция (Insert, Delete, Replace) — отдельная команда, которую можно выполнить/отменить.
Memento — сохранение состояния документа для отката изменений.

Реализовать:

1) Команды и их выполнение.
2) Обработчиков пользователей с разным уровнем доступа.
3) Возможность отката команд (Undo).
4) Историю состояния документа (через Memento).
         */
        static void Main(string[] args)
        {
            var document = new Document("This is a sample text.");
            var history = new History();

            // Setup Chain of Responsibility: User → Moderator → Admin
            var userHandler = new UserHandler();
            var modHandler = new ModeratorHandler();
            var adminHandler = new AdminHandler();

            userHandler.SetNext(modHandler);
            modHandler.SetNext(adminHandler);

            Console.WriteLine("=== TEXT EDITOR ===");
            document.Display();

            while (true)
            {
                Console.WriteLine("\nEnter command (insert/delete/replace/undo/exit):");
                var operation = Console.ReadLine()?.Trim().ToLower();

                if (operation == "exit") break;

                if (operation == "undo")
                {
                    if (history.CanUndo)
                    {
                        var memento = history.Undo();
                        document.Restore(memento);
                        Console.WriteLine("Undo performed.");
                    }
                    else Console.WriteLine("Nothing to undo.");

                    document.Display();
                    continue;
                }

                Console.Write("Role (user/moderator/admin): ");
                var role = Console.ReadLine()?.Trim().ToLower();

                Console.Write("Index: ");
                int index = int.Parse(Console.ReadLine() ?? "0");

                int length = 0;
                string text = "";

                if (operation == "delete" || operation == "replace")
                {
                    Console.Write("Length: ");
                    length = int.Parse(Console.ReadLine() ?? "0");
                }

                if (operation == "insert" || operation == "replace")
                {
                    Console.Write("Text: ");
                    text = Console.ReadLine() ?? "";
                }

                var request = new EditRequest
                {
                    Operation = operation,
                    Index = index,
                    Length = length,
                    Text = text,
                    Role = role
                };

                bool result = userHandler.Handle(request, document, history);

                if (!result) Console.WriteLine("Operation failed.");

                document.Display();
            }
        }
    }
}
