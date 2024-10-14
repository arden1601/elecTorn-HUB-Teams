namespace elecTorn_HUB_Teams.Forms;
using elecTorn_HUB_Teams.Variables;
using elecTorn_HUB_Teams.Functions;
using elecTorn_HUB_Teams.Components;
using elecTorn_HUB_Teams.Objects;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    // Login on Click
    private void LoginButton_Click(object sender, EventArgs e)
    {
        // Popup a message box
        MessageBox.Show("Login Button Clicked");
    }

    private void Login_Load(object sender, EventArgs e)
    {
        // Values
        int FontSize = Variables.FontSizeSM;
        int Margin = 20 * 2;

        // Create a box group in the center
        Panel loginBox = new Panel();
        loginBox.Text = "";
        loginBox.Font = new Font(Variables.SecondaryFont, FontSize, FontStyle.Regular);
        loginBox.ForeColor = ColorTranslator.FromHtml(Variables.ColorOffWhite);
        loginBox.Width = Variables.ScreenWidth / 3;
        loginBox.Height = Variables.ScreenHeight / 2;

        // Contents
        Panel titleLabel = Components.Labels([
            new ObjLabel(
                "elec",
                new Font(Variables.PrimaryFont, FontSize, FontStyle.Bold),
                Variables.ColorDarkGray
            ),
            new ObjLabel(
                "Torn",
                new Font(Variables.PrimaryFont, FontSize, FontStyle.Bold),
                Variables.ColorAccentOrange
            ),
            new ObjLabel(
                "Hub",
                new Font(Variables.PrimaryFont, FontSize, FontStyle.Bold),
                Variables.ColorDarkGray
            ),
            new ObjLabel(
                "Login",
                new Font(Variables.SecondaryFont, FontSize, FontStyle.Bold),
                Variables.ColorAccentOrange
            )
            ],
            165,
            true);

        Panel titleBox = new Panel();
        titleBox.Width = loginBox.Width;
        titleBox.Height = titleLabel.Height;
        titleBox.Location = new Point(0, 0);

        // Center the titleLabel
        int titleBoxX = (loginBox.Width - titleBox.Width) / 2;
        int titleBoxY = (loginBox.Height - titleBox.Height) / 2;
        int[] CenterTitle = Functions.CenterFrame(titleBox.Width, titleBox.Height, titleLabel.Width, titleLabel.Height, 1, 1, 1, 1);
        titleLabel.Location = new Point(CenterTitle[0], CenterTitle[1]);

        loginBox.Controls.Add(titleBox);
        titleBox.Controls.Add(titleLabel);

        Label usernameLabel = Components.Label(new ObjLabel(
            "Username",
            new Font(Variables.SecondaryFont, Variables.FontSizeSM, FontStyle.Bold),
            Variables.ColorDarkGray
            ),
            loginBox.Width - Margin);
        TextBox usernameTextBox = Components.TextBox(new Font(
            Variables.SecondaryFont, Variables.FontSizeSM, FontStyle.Regular),
            loginBox.Width - Margin
            );
        Label passwordLabel = Components.Label(new ObjLabel(
            "Password",
            new Font(Variables.SecondaryFont, Variables.FontSizeSM, FontStyle.Bold),
            Variables.ColorDarkGray
            ), loginBox.Width - Margin);
        TextBox passwordTextBox = Components.TextBox(
            new Font(Variables.SecondaryFont, Variables.FontSizeSM, FontStyle.Regular),
            loginBox.Width - Margin,
            true
            );

        // Arrange them in the center
        int[] Center = Functions.CenterFrame(Variables.ScreenWidth, Variables.ScreenHeight, loginBox.Width, loginBox.Height);
        loginBox.Location = new Point(Center[0], Center[1]);

        // Empty Panel for Gap
        Panel gap = new Panel();
        gap.Width = loginBox.Width;
        gap.Height = Variables.FontSizeSM * 2;
        gap.Location = new Point(0, titleLabel.Height + Margin);

        // Button
        Button loginButton = Components.Button(
            LoginButton_Click,
            "Login",
            new Font(Variables.SecondaryFont, Variables.FontSizeSM, FontStyle.Bold),
            Variables.ColorAccentOrange,
            loginBox.Width - Margin,
            Variables.FontSizeSM * 4,
            Variables.ColorDarkGray,
            true
            );

        // Put contents in an array of contents
        Control[] contents = new Control[] { titleBox, usernameLabel, usernameTextBox, passwordLabel, passwordTextBox, gap, loginButton };

        // Loop through the contents and set the location
        for (int i = 0; i < contents.Length; i++)
        {
            int[] CenterContent = Functions.CenterFrame(loginBox.Width, loginBox.Height, contents[i].Width, contents[i].Height, contents.Length, 1, i + 1, 1, loginBox.Location.Y);
            contents[i].Location = new Point(CenterContent[0], CenterContent[1]);
            loginBox.Controls.Add(contents[i]);
        }

        // Show all the controls
        Controls.Add(loginBox);
    }
}
