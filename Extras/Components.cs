using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using elecTorn_HUB_Teams.Objects;

namespace elecTorn_HUB_Teams.Components
{
    internal class Components
    {
        // Label Class
        public static Label Label(ObjLabel _label, int width, bool center = false)
        {
            Label label = new Label();
            label.Text = _label.text;
            label.Font = _label.font;
            label.ForeColor = ColorTranslator.FromHtml(_label.color);
            label.Width = width;
            label.Height = (int)_label.font.Size + (int)_label.font.Size / 3 * 2;
            if (center)
            {
                label.TextAlign = ContentAlignment.MiddleCenter;
            }
            return label;
        }

        // Combine labels into one group
        public static Panel Labels(ObjLabel[] _label, int width, bool center = false)
        {
            Panel groupBox = new Panel();
            groupBox.Width = width;

            int height = 0;
            int usedWidth = 0;
            foreach (ObjLabel label in _label)
            {
                int selfWidth = (int)(label.text.Length * label.font.Size);

                Label newLabel = Label(label, selfWidth);

                // Set properties to remove padding and margin
                newLabel.AutoSize = true;
                newLabel.Margin = new Padding(0);
                newLabel.Padding = new Padding(0);

                // check the highest height
                int checkHeight = newLabel.Height * 2;
                if (checkHeight > height)
                {
                    height = checkHeight;
                }

                // Set the label's location, reducing extra gap
                newLabel.Location = new System.Drawing.Point(usedWidth, newLabel.Height / 2);
                groupBox.Controls.Add(newLabel);

                // Get the exact width of the text
                SizeF textSize = newLabel.CreateGraphics().MeasureString(label.text, newLabel.Font);
                int textWidth = (int)textSize.Width;
                // Use textWidth instead of selfWidth
                usedWidth += textWidth;
            }


            groupBox.Height = height;
            return groupBox;
        }

        public static TextBox TextBox(Font font, int width, bool password = false, int height = -1)
        {
            TextBox textBox = new TextBox();
            textBox.Font = font;
            textBox.Width = width;
            if (height == -1)
            {
                textBox.Height = (int)font.Size + (int)font.Size / 2;
            }
            else
            {
                textBox.Height = height;
            }
            if (password)
            {
                textBox.PasswordChar = '*';
            }
            return textBox;
        }
    }
}
