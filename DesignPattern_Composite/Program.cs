using DesignPattern_Composite.Basic;
using DesignPattern_Composite.Composite;

namespace DesignPattern_Composite
{
    /*
     Создайте приложение, моделирующее графическую сцену. 
    Есть простые фигуры (Circle, Rectangle, Line) и группы фигур (например, "дом", "человек", "лес").

Используйте паттерн Компоновщик, чтобы:

1) Простые фигуры, и группы фигур можно было добавлять в сцену одинаково.
2) Можно было вызывать Draw() у всей сцены, и она отрисовывала все элементы.
3) Поддержать возможность перемещать группы вместе.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var scene = new Group("Scene");
            var house = BuildHouse();
            scene.Add(house);
            var person = BuildPerson();
            scene.Add(person);
            var forest = BuildForest(3);
            scene.Add(forest);

            scene.Draw();
        }

        private static Group BuildHouse()
        {
            var house = new Group("House");
            var wall = new Rectangle("Wall", 0, 0, 100, 50);
            var door = new Rectangle("Door", 40, 50, 20, 30);
            var window = new Rectangle("Window", 10, 10, 20, 20);
            house.Add(wall);
            house.Add(door);
            house.Add(window);
            return house;
        }

        private static Group BuildPerson()
        {
            var person = new Group("Person");
            var head = new Circle("Head", 0, 0, 10);
            var body = new Rectangle("Body", -5, -20, 10, 20);
            var leftArm = new Line("Left Arm", -15, -10, 10);
            var rightArm = new Line("Right Arm", 5, -10, 10);
            var leftLeg = new Line("Left Leg", -5, 0, 10);
            var rightLeg = new Line("Right Leg", 5, 0, 10);
            person.Add(head);
            person.Add(body);
            person.Add(leftArm);
            person.Add(rightArm);
            person.Add(leftLeg);
            person.Add(rightLeg);
            return person;
        }

        private static Group BuildForest(int count)
        {
            var forest = new Group("Forest");
            for (int i = 0; i < count; i++)
            {
                var tree = new Group($"Tree {i + 1}");
                var trunk = new Rectangle("Trunk", 0, 0, 5, 20);
                var leaves = new Circle("Leaves", -10, 20, 15);
                tree.Add(trunk);
                tree.Add(leaves);
                forest.Add(tree);
            }
            return forest;
        }
    }
}
