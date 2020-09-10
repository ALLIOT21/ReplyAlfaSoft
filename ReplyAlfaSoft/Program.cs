using System;
using System.Collections.Generic;

namespace ReplyAlfaSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            var yellowNode = new ColorNode("Желтый");
            var orangeNode = new ColorNode("Оранжевый");
            var blueNode = new ColorNode("Голубой");
            var darkBlueNode = new ColorNode("Синий", new List<ColorNode> { orangeNode, yellowNode});
            var redNode = new ColorNode("Красный");
            var purpleNode = new ColorNode("Фиолетовый", new List<ColorNode> { blueNode });
            var greenNode = new ColorNode("Зеленый", new List<ColorNode> { darkBlueNode, redNode, purpleNode });

            var A = greenNode;            

            Console.WriteLine(A);
            Console.ReadKey();
        }
    }
}
