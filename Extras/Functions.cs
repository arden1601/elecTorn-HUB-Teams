using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elecTorn_HUB_Teams.Functions
{
    using elecTorn_HUB_Teams.Variables;
    internal class Functions
    {
        public static int[] CenterFrame (int ParentWidth, int ParentHeight, int ChildWidth, int ChildHeight, int RowCount = 1, int ColCount = 1, int RowIdx = 1, int ColIdx = 1, int ParentYLoc = 0, int ParentXLoc = 0)
        {
            int[] Center = new int[2];
            Center[0] = (ParentWidth / ColCount * ColIdx - ChildWidth) / 2 + ParentXLoc;
            Center[1] = (ParentHeight / RowCount * RowIdx - ChildHeight) / 2 + ParentYLoc / 3;
            return Center;
        }

        public static void InitPage (Form form, string Title, EventHandler LoadEvent)
        {
            form.AutoScaleDimensions = new SizeF(7F, 15F);
            form.AutoScaleMode = AutoScaleMode.Font;
            form.ClientSize = new Size(Variables.ScreenWidth, Variables.ScreenHeight);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Name = Title;
            form.Text = Title;
            form.Load += LoadEvent;
        }
    }
}
