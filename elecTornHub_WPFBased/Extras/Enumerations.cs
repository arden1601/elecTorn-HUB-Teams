using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elecTornHub_WPFBased.Extras
{
    public class Enumerations
    {
        public class Comment
        {
            public enum CommentType
            {
                Default,
                Poster,
                Viewer
            }
        }

        public class OpenContent
        {
            public enum OpenContentBodyType
            {
                Default,
                Buyer,
                Seller,
                Reported,
                Banned
            }

            public enum OpenContentBodyMode
            {
                Default,
                Product,
                Post
            }
        }

        public class PostContent
        {
            public enum PostContentType
            {
                Default,
                Poster,
                Reported,
                Takedown
            }
        }

        public class Navbar
        {
            public enum NavbarType
            {
                Default,
                User,
                Admin
            }

            public enum NavbarChosen
            {
                Default,
                Beli,
                Jual,
                Post,
                Item
            }
        }
        
        public class ChoiceCard
        {
            public enum ChoiceCardType
            {
                Default,
                Post,
                Product
            }
        }

        public class Popup
        {
            public enum ConfirmPopupType
            {
                Default,
                Terbeli,
                Kontak,
                HapusJualan,
                HapusPost,
                HapusAkun,
                Lapor,
                Takedown,
                AkunNotFound
            }

            public enum LogPopupType
            {
                Default,
                Login,
                Register
            }
        }

        public class CustomGrid
        {
            public enum CustomGridMode
            {
                Default,
                Beli,
                Jual,
                Admin
            }
        }
    }
}
