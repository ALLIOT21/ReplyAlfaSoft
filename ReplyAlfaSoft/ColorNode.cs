using System.Collections.Generic;

namespace ReplyAlfaSoft
{
    class ColorNode
    {
        public string Color { get; private set; }

        public List<ColorNode> ColorNodeChilds { get; private set; }

        public ColorNode(string color, List<ColorNode> colorNodeChilds = null)
        {
            Color = color;
            ColorNodeChilds = colorNodeChilds;
        }
    }
}
