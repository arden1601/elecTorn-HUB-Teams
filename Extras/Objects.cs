using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elecTorn_HUB_Teams.Objects
{
    internal class ObjLabel
    {
        public string text;
        public System.Drawing.Font font;
        public string color;

        public ObjLabel(string _text, System.Drawing.Font _font, string _color)
        {
            text = _text;
            font = _font;
            color = _color;
        }
    }
}
