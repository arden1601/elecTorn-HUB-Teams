using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elecTorn_HUB_Teams.Components
{
    using elecTorn_HUB_Teams.Objects;
    using elecTorn_HUB_Teams.Variables;
    using elecTorn_HUB_Teams.Functions;
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
            label.Height = (int)_label.font.Size + (int)_label.font.Size / 5 * 2;
            // new line if the text is too long
            label.MaximumSize = new System.Drawing.Size(width, 0);
            label.AutoSize = true;

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
                int checkHeight = newLabel.Height / 3 * 7;
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

        public static Button Button(
            EventHandler clickEvent,
            string text,
            Font font,
            string color,
            int width,
            int height,
            string colorBorder,
            bool center = false
            )
        {
            Button button = new Button();
            button.Cursor = System.Windows.Forms.Cursors.Hand;
            button.Text = text;
            button.Font = font;
            button.ForeColor = ColorTranslator.FromHtml(color);
            button.Width = width;
            button.Height = height;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = ColorTranslator.FromHtml(colorBorder);
            button.Click += clickEvent;
            if (center)
            {
                button.TextAlign = ContentAlignment.MiddleCenter;
            }
            return button;
        }

        public static Panel PostBox(int width, int height, int[] location)
        {
            Panel postBox = new Panel();
            postBox.Text = "";
            postBox.Font = new Font(Variables.SecondaryFont, Variables.FontSizeSM, FontStyle.Regular);
            postBox.Width = width;
            postBox.Height = height;
            postBox.Location = new System.Drawing.Point(location[0], location[1]);
            postBox.BackColor = ColorTranslator.FromHtml(Variables.ColorDarkGray);

            // 1/3 width for picture
            Panel pictureBox = new Panel();
            pictureBox.Width = postBox.Width / 3;
            pictureBox.Height = postBox.Height;
            pictureBox.Location = new System.Drawing.Point(0, 0);
            pictureBox.BackColor = ColorTranslator.FromHtml(Variables.ColorDarkGray);
            
            PictureBox picture = new PictureBox();
            picture.Width = pictureBox.Width;
            picture.Height = pictureBox.Height;
            picture.Location = new System.Drawing.Point(0, 0);

            // stretch the image
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Load("https://images.unsplash.com/photo-1617299516258-eb06985065ff?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");

            pictureBox.Controls.Add(picture);

            postBox.Controls.Add(pictureBox);

            // 2/3 for contentBox
            Panel contentBox = new Panel();
            contentBox.Width = postBox.Width / 3 * 2;
            contentBox.Height = postBox.Height;
            contentBox.Location = new System.Drawing.Point(pictureBox.Width, 0);
            contentBox.BackColor = ColorTranslator.FromHtml(Variables.ColorOffWhite);

            postBox.Controls.Add(contentBox);

            // Vertically fill content box with title, poster, description, price, stock, and horizontally two buttons: beli sekarang adn hubungi pembeli
            // Title
            Label titleLabel = Label(new ObjLabel("Laptop ACER Intel Core Nitro 5 NVIDIA GeForce RTX", new Font(Variables.PrimaryFont, Variables.FontSizeMD, FontStyle.Bold), Variables.ColorDarkGray), contentBox.Width);
            titleLabel.Location = new System.Drawing.Point(0, 0);
            contentBox.Controls.Add(titleLabel);

            // Poster
            Label posterLabel = Label(new ObjLabel("dijual oleh Cornelius Arden", new Font(Variables.SecondaryFont, Variables.FontSizeSM, FontStyle.Regular), Variables.ColorDarkGray), contentBox.Width);
            posterLabel.Location = new System.Drawing.Point(0, titleLabel.Height);
            contentBox.Controls.Add(posterLabel);

            // Description
            Label descriptionLabel = Label(new ObjLabel("Laptop ini merupakan laptop kesayangan saya, tapi laptop ini terlalu bagus untuk saya sehingga saya memutuskan untuk menjualnya. Spesifikasi masih bagus, dijual murah karena kebetulan lagi butuh uang untuk memenuhi kebutuhan anak dan istri. Bagi siapapun yang berniat membantu saya, mohon beli produk ini. Jika Anda tidak mau membeli padahal sudah membaca sampai sini, saya akan gunakan IP Address Anda untuk melacak posisi Anda dan mengejar Anda sampai ke pelaminan. Sekian terima kasih, terima lah lagu ini dari orang biasa. Mohon maaf jika ada salah kata, akhir kata saya.", new Font(Variables.SecondaryFont, Variables.FontSizeSM, FontStyle.Regular), Variables.ColorDarkGray), contentBox.Width);
            descriptionLabel.Location = new System.Drawing.Point(0, titleLabel.Height + posterLabel.Height);
            contentBox.Controls.Add(descriptionLabel);

            // Price
            Label priceLabel = Label(new ObjLabel("Rp. 694.646,-", new Font(Variables.SecondaryFont, Variables.FontSizeSM, FontStyle.Regular), Variables.ColorDarkGray), contentBox.Width);
            priceLabel.Location = new System.Drawing.Point(0, titleLabel.Height + posterLabel.Height + descriptionLabel.Height);
            contentBox.Controls.Add(priceLabel);

            // Stock
            Label stockLabel = Label(new ObjLabel("(stok tersedia 1 buah)", new Font(Variables.SecondaryFont, Variables.FontSizeSM, FontStyle.Regular), Variables.ColorDarkGray), contentBox.Width);
            stockLabel.Location = new System.Drawing.Point(0, titleLabel.Height + posterLabel.Height + descriptionLabel.Height + priceLabel.Height);
            contentBox.Controls.Add(stockLabel);

            // Buttons
            Button buyButton = Button(null, "Beli Sekarang", new Font(Variables.SecondaryFont, Variables.FontSizeSM, FontStyle.Bold), Variables.ColorAccentOrange, contentBox.Width / 2, 30, Variables.ColorAccentOrange);
            Button contactButton = Button(null, "Hubungi Pembeli", new Font(Variables.SecondaryFont, Variables.FontSizeSM, FontStyle.Bold), Variables.ColorAccentOrange, contentBox.Width / 2, 30, Variables.ColorAccentOrange);

            // Make panel for buttons
            Panel buttonBox = new Panel();
            buttonBox.Width = contentBox.Width;
            buttonBox.Height = 30;
            buttonBox.Location = new System.Drawing.Point(0, titleLabel.Height + posterLabel.Height + descriptionLabel.Height + priceLabel.Height + stockLabel.Height);
            buttonBox.Controls.Add(buyButton);
            buttonBox.Controls.Add(contactButton);

            contentBox.Controls.Add(buttonBox);

            postBox.Controls.Add(contentBox);

            return postBox;
        }
    }
}
