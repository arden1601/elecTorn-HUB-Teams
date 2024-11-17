using elecTornHub_WPFBased.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elecTornHub_WPFBased.Extras
{
    public class Interfaces
    {
        public interface INavbarParent
        {
            Enumerations.Navbar.NavbarType NavbarType { get; }
            Enumerations.Navbar.NavbarChosen NavbarChosen { get; }
        }

        public interface IPostContent
        {
            Enumerations.PostContent.PostContentType PostType { get; }
        }

        public interface IOpenContent
        {
            Enumerations.OpenContent.OpenContentBodyMode ContentMode { get; }
            Enumerations.OpenContent.OpenContentBodyType ContentType { get; }
        }

        public interface IContentCard
        {
            Enumerations.CustomGrid.CustomGridMode ContentMode { get; }
            Enumerations.ChoiceCard.ChoiceCardType ContentType { get; }
        }

        public interface IContent: IPostContent, IOpenContent
        {
            
        }

        public interface IComment
        {
            Enumerations.Comment.CommentType CommentType { get; }
            string Comment_Poster { get; }
            string Comment_Content { get; }
            string Comment_PostDate { get; }
        }

        public interface ILogPopup
        {
            Enumerations.Popup.LogPopupType LogPopupType { get; }
        }

        public interface IConfirmPopup
        {
            Enumerations.Popup.ConfirmPopupType ConfirmPopupType { get; }
        }
    }
}
