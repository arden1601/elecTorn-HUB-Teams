using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elecTorn_HUB_Teams.Forms
{
    using elecTorn_HUB_Teams.Components;
    using elecTorn_HUB_Teams.Functions;
    using elecTorn_HUB_Teams.Variables;
    public partial class OpenPost : Form
    {
        public OpenPost()
        {
            InitializeComponent();
        }

        private void OpenPost_Load(object sender, EventArgs e)
        {
            int[] CenterBox = Functions.CenterFrame(Variables.ScreenWidth, Variables.ScreenHeight, (int)(Variables.ScreenWidth * .9), (int)(Variables.ScreenHeight * .9), 1, 1, 1, 1, 0, 0);
            Panel postBox = Components.PostBox((int)(Variables.ScreenWidth * .9), (int)(Variables.ScreenHeight * .9 / 1.5), CenterBox);

            Controls.Add(postBox);
        }
    }
}
