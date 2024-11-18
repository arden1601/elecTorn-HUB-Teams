using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using elecTornHub_WPFBased.Classes;
using elecTornHub_WPFBased.Extras;
using Newtonsoft.Json;


namespace elecTornHub_WPFBased.ViewModels
{
    public class ContentViewModel : INotifyPropertyChanged
    {
        private const string uri = "https://api-junpro.vercel.app/post";
        private Post _post;
        private Products _product;

        // Constructor for Post
        public ContentViewModel(Post post)
        {
            _post = post;
            _product = null; // Explicitly set _product to null
        }

        // Constructor for Products
        public ContentViewModel(Products product)
        {
            _product = product;
            _post = null; // Explicitly set _post to null
        }

        // Constructor for Post with individual parameters
        public ContentViewModel(string postId, User author, string title, string content, string postDate, string imgSrc, string lastEdit, CommentViewModel[] comments)
        {
            _post = new Post(
                postId: postId,
                authorId: author,
                content: content,
                title: title,
                postDate: postDate,
                lastEdit: lastEdit,
                imgSrc: imgSrc,
                comments: comments
            );
            _product = null; // Explicitly set _product to null
        }

        // Constructor for Product with individual parameters
        public ContentViewModel(User seller, string name, int quantity, int price, string imgSrc, string description, string productId)
        {
            _product = new Products(
                productId: productId,
                name: name,
                quantity: quantity,
                price: price,
                imgSrc: imgSrc,
                description: description,
                seller: seller
            );
            _post = null; // Explicitly set _post to null
        }

        public static async Task<List<dynamic>> getData()
        {
            var data = new List<dynamic>();
            using (HttpClient httpClient = new HttpClient()) 
            { 
                HttpResponseMessage response = await httpClient.GetAsync(uri);

                var jsonData = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<dynamic>>(jsonData);
                Console.WriteLine(data);
                return data;
            }
        }

        // Getter for Post and Product
        public Post Post => _post;
        public Products Product => _product;

        // Property checks if _post is null to avoid exceptions
        public string Post_Title
        {
            get => _post?.Title ?? string.Empty; // Return empty string if _post is null
            set
            {
                if (_post != null && _post.Title != value)
                {
                    _post.Title = value;
                    OnPropertyChanged(nameof(Post_Title));
                }
            }
        }

        public string Post_Content
        {
            get => _post?.Content ?? string.Empty;
            set
            {
                if (_post != null && _post.Content != value)
                {
                    _post.Content = value;
                    OnPropertyChanged(nameof(Post_Content));
                }
            }
        }

        public string Post_ContentBrief
        {
            get => _post != null ? Functions.CutFromStart(_post.Content, 300) : string.Empty;
        }

        public string Post_PostDate
        {
            get => _post?.PostDate ?? string.Empty;
            set
            {
                if (_post != null && _post.PostDate != value)
                {
                    _post.PostDate = value;
                    OnPropertyChanged(nameof(Post_PostDate));
                }
            }
        }

        public string Post_LastEdit
        {
            get => _post?.LastEdit ?? string.Empty;
            set
            {
                if (_post != null && _post.LastEdit != value)
                {
                    _post.LastEdit = value;
                    OnPropertyChanged(nameof(Post_LastEdit));
                }
            }
        }

        public string Post_AuthorName
        {
            get => _post?.AuthorId?.Username ?? string.Empty;
            set
            {
                if (_post != null && _post.AuthorId != null && _post.AuthorId.Username != value)
                {
                    _post.AuthorId.Username = value;
                    OnPropertyChanged(nameof(Post_AuthorName));
                }
            }
        }

        public string Post_ImgSrc
        {
            get => _post?.ImgSrc ?? "https://example.com/default-image.png"; // Default image URL if _post or ImgSrc is null
            set
            {
                if (_post != null && _post.ImgSrc != value)
                {
                    _post.ImgSrc = value;
                    OnPropertyChanged(nameof(Post_ImgSrc));
                }
            }
        }

        public CommentViewModel[] Post_Comments
        {
            get => _post?.Comments ?? new CommentViewModel[0]; // Return an empty array if _post or Comments is null
            set
            {
                if (_post != null && _post.Comments != value)
                {
                    _post.Comments = value;
                    OnPropertyChanged(nameof(Post_Comments));
                }
            }
        }

        // Property checks if _product is null to avoid exceptions
        public string ProductCard_SellerName_Selling
        {
            get => _product?.Seller?.Username != null ? $"dijual oleh {_product.Seller.Username}" : "Seller Unknown";
        }

        public string ProductCard_Name
        {
            get => _product?.Name ?? string.Empty;
            set
            {
                if (_product != null && _product.Name != value)
                {
                    _product.Name = value;
                    OnPropertyChanged(nameof(ProductCard_Name));
                }
            }
        }

        public string ProductCard_Description
        {
            get => _product?.Description ?? string.Empty;
            set
            {
                if (_product != null && _product.Description != value)
                {
                    _product.Description = value;
                    OnPropertyChanged(nameof(ProductCard_Description));
                }
            }
        }

        public int ProductCard_Quantity
        {
            get => _product?.Quantity ?? 0;
            set
            {
                if (_product != null && _product.Quantity != value)
                {
                    _product.Quantity = value;
                    OnPropertyChanged(nameof(ProductCard_Quantity));
                }
            }
        }

        public string ProductCard_QuantityLeft
        {
            get => _product != null ? $"(stok tersedia {_product.Quantity} buah)" : "(stok tidak tersedia)";
        }

        public string ProductCard_PriceOriginal
        {
            get => _product?.Price.ToString() ?? "0";
            set
            {
                if (_product != null && _product.Price.ToString() != value)
                {
                    _product.Price = int.Parse(value);
                    OnPropertyChanged(nameof(ProductCard_PriceOriginal));
                }
            }
        }

        public string ProductCard_Price
        {
            get => _product != null ? Functions.FormatToRupiah(_product.Price) : "Rp 0";
        }

        public string ProductCard_ImgSrc
        {
            get => _product?.ImgSrc ?? "https://example.com/default-image.png"; // Default image URL if _product or ImgSrc is null
            set
            {
                if (_product != null && _product.ImgSrc != value)
                {
                    _product.ImgSrc = value;
                    OnPropertyChanged(nameof(ProductCard_ImgSrc));
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
