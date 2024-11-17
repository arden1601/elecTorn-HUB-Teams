using System.ComponentModel;
using System.Diagnostics;
using elecTornHub_WPFBased.Classes;
using elecTornHub_WPFBased.Extras;

namespace elecTornHub_WPFBased.ViewModels
{
    public class ContentViewModel : INotifyPropertyChanged
    {
        private Post _post = null;
        private Products _product = null;

        public ContentViewModel(Post post)
        {
            _post = post;
        }

        public ContentViewModel(Products product)
        {
            _product = product;
        }

        // Temporary constructor to accept value directly
        public ContentViewModel(string title, string content, string postDate, string imgSrc, string lastEdit, Comment[] comments)
        {
            // fill the values
            _post = new Post(
                postId: "lol",
                authorId: new User(
                    username: "lol",
                    password: "lol",
                    uuid: "lalala"
                ),
                content: content,
                title: title,
                postDate: postDate,
                lastEdit: lastEdit,
                imgSrc: imgSrc,
                comments: comments
                );
        }

        public ContentViewModel(string title, int quantity, int price, string imgSrc, string description)
        {
            // fill the values
            _product = new Products(
                name: title,
                quantity: quantity,
                price: price,
                imgSrc: imgSrc,
                description: description,
                seller: new User(
                    username: "Cornelius Joko",
                    password: "lol",
                    uuid: "lalala"
                )
                );
        }

        public string ProductCard_SellerName_Selling
        {
            get => "dijual oleh " + _product.Seller.Username;
        }

        public string ProductCard_Name
            {
            get => _product.Name;
            set
            {
                if (_product.Name != value)
                {
                    _product.Name = value;
                    OnPropertyChanged(nameof(ProductCard_Name));
                }
            }
        }

        public string ProductCard_Description
        {
            get => _product.Description;
            set
            {
                if (_product.Description != value)
                {
                    _product.Description = value;
                    OnPropertyChanged(nameof(ProductCard_Description));
                }
            }
        }

        public int ProductCard_Quantity
        {
            get => _product.Quantity;
            set
            {
                if (_product.Quantity != value)
                {
                    _product.Quantity = value;
                    OnPropertyChanged(nameof(ProductCard_Quantity));
                }
            }
        }

        public string ProductCard_QuantityLeft
        {
            get => "(stok tersedia " + _product.Quantity.ToString() + " buah)";
        }

        public string ProductCard_PriceOriginal
            {
            get => _product.Price.ToString();
            set
            {
                if (_product.Price.ToString() != value)
                {
                    _product.Price = int.Parse(value);
                    OnPropertyChanged(nameof(ProductCard_PriceOriginal));
                }
            }
        }

        public string ProductCard_Price
        {
            get => Functions.FormatToRupiah(_product.Price);
        }

        public string ProductCard_ImgSrc
        {
            get => _product.ImgSrc;
            set
            {
                if (_product.ImgSrc != value)
                {
                    _product.ImgSrc = value;
                    OnPropertyChanged(nameof(ProductCard_ImgSrc));
                }
            }
        }

        public string Post_Title
        {
            get => _post.Title;
            set
            {
                if (_post.Title != value)
                {
                    _post.Title = value;
                    OnPropertyChanged(nameof(Post_Title));
                }
            }
        }

        public string Post_Content
        {
            get => _post.Content;
            set
            {
                if (_post.Content != value)
                {
                    _post.Content = value;
                    OnPropertyChanged(nameof(Post_Content));
                }
            }
        }

        public string Post_ContentBrief
        {
            get => Functions.CutFromStart(_post.Content, 300);
        }

        public string Post_PostDate
        {
            get => _post.PostDate;
            set
            {
                if (_post.PostDate != value)
                {
                    _post.PostDate = value;
                    OnPropertyChanged(nameof(Post_PostDate));
                }
            }
        }

        public string Post_LastEdit
        {
            get => _post.LastEdit;
            set
            {
                if (_post.LastEdit != value)
                {
                    _post.LastEdit = value;
                    OnPropertyChanged(nameof(Post_LastEdit));
                }
            }
        }

        public string Post_AuthorName
        {
            get => _post.AuthorId.Username;
            set
            {
                if (_post.AuthorId.Username != value)
                {
                    _post.AuthorId.Username = value;
                    OnPropertyChanged(nameof(Post_AuthorName));
                };
            }
        }

        public string Post_ImgSrc
        {
            get => _post.ImgSrc;
            set
            {
                if (_post.ImgSrc != value)
                {
                    _post.ImgSrc = value;
                    OnPropertyChanged(nameof(Post_ImgSrc));
                };
            }
        }

        public Comment[] Post_Comments
        {
            get => _post.Comments;
            set
            {
                if (_post.Comments != value)
                {
                    _post.Comments = value;
                    OnPropertyChanged(nameof(Post_Comments));
                }
            }
        }

        // Implement INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
