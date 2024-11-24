using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Windows;
using elecTornHub_WPFBased.Classes;
using elecTornHub_WPFBased.Extras;
using Newtonsoft.Json;


namespace elecTornHub_WPFBased.ViewModels
{
    public class ContentViewModel : INotifyPropertyChanged
    {
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

        // Getter for Post and Product
        public Post Post => _post;
        public Products Product => _product;

        public string Post_Id
        {
            get => _post?.PostId ?? string.Empty; // Return empty string if _post is null
            set
            {
                if (_post != null && _post.PostId != value)
                {
                    _post.PostId = value;
                    OnPropertyChanged(nameof(Post_Id));
                }
            }
        }

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

        public string ProductCard_Id
        {
            get => _product?.ProductId ?? string.Empty; // Return empty string if _product is null
            set
            {
                if (_product != null && _product.ProductId != value)
                {
                    _product.ProductId = value;
                    OnPropertyChanged(nameof(ProductCard_Id));
                }
            }
        }

        public string ProductCard_SellerName_Selling
        {
            get => _product?.Seller?.Username != null ? $"dijual oleh {_product.Seller.Username}" : "Seller Unknown";
            set
            {
                if (_product != null && _product.Seller.Username != value)
                {
                    _product.Seller.Username = value;
                    OnPropertyChanged(nameof(ProductCard_SellerName_Selling));
                }
            }
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
            set
            {
                if (_product != null && _product.Quantity.ToString() != value)
                {
                    _product.Quantity = int.Parse(value);
                    OnPropertyChanged(nameof(ProductCard_QuantityLeft));
                }
            }
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

        private static ContentViewModel[] TemporaryPosts = new ContentViewModel[]
        {
            new ContentViewModel(
                postId: "1",
                author: new Classes.User(
                username: "Cornelius Joko",
                password: "johnjohnson123",
                uuid: "5"
            ),
                title: "Adakah kamu di situ?",
                content: "Lorem ipsum odor amet, consectetuer adipiscing elit. Sapien scelerisque per conubia volutpat viverra tempus! Inceptos curae mi fusce proin senectus, condimentum volutpat dictum? Et risus rutrum habitasse cursus curae, accumsan integer aliquet. Suspendisse velit vel luctus id iaculis nisi. Duis platea ac consequat; blandit luctus elit. Sem maecenas primis himenaeos class fusce congue mauris nisi. Inceptos dui mollis ultricies donec congue laoreet sagittis purus.",
                postDate: "16 September 2024",
                lastEdit: "13 September 2024",
                imgSrc: "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo",
                comments: new CommentViewModel[]
                {
                    new CommentViewModel(
                        author: new Classes.User(
                            username: "John Doe",
                            password: "johndoe123",
                            uuid: "1"
                        ),
                        postId: "1",
                        content: "Berjuanglah meski sulit.",
                        postDate: "22 September 2024"
                    ),
                    new CommentViewModel(
                        author: new Classes.User(
                            username: "Jane Doe",
                            password: "janedoe123",
                            uuid: "2"
                        ),
                        postId: "2",
                        content: "Langkah pertama adalah yang paling sulit.",
                        postDate: "29 September 2024"
                    ),
                    new CommentViewModel(
                        author: new Classes.User(
                            username: "John Smith",
                            password: "johnsmith123",
                            uuid: "3"
                        ),
                        postId: "3",
                        content: "Semua kenangan akan tetap abadi.",
                        postDate: "5 October 2024"
                    )
                }
            ),
            new ContentViewModel(
                postId: "2",
                title: "Mimpi Semu",
                content: "Nulla accumsan, metus ultrices eleifend gravida, nulla nunc varius lectus, nec rutrum justo nibh eu lectus.",
                postDate: "22 September 2024",
                lastEdit: "20 September 2024",
                imgSrc: "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo",
                author: new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                    ),
                comments: new CommentViewModel[]
                {
                    new CommentViewModel(
                        author:
                        new Classes.User(
                            username: "John Doe",
                            password: "johndoe123",
                            uuid: "1"
                        ),
                        postId: "4",
                        content: "Langkah pertama adalah yang paling sulit.",
                        postDate: "29 September 2024"
                    ),
                    new CommentViewModel(
                        author:
                        new Classes.User(
                            username: "Jane Doe",
                            password: "janedoe123",
                            uuid: "2"
                        ),
                        postId: "5",
                        content: "Semua kenangan akan tetap abadi.",
                        postDate: "5 October 2024"
                    )
                }
            ),
            new ContentViewModel(
                postId: "3",
                author:
                new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                ),
                title: "Perjalanan Tak Berujung",
                content: "Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus.",
                postDate: "29 September 2024",
                lastEdit: "25 September 2024",
                imgSrc: "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo",
                comments: new CommentViewModel[]
                {
                    new CommentViewModel(
                        author:
                        new Classes.User(
                            username: "Jane Doe",
                            password: "janedoe123",
                            uuid: "2"
                        ),
                        postId: "6",
                        content: "Berjuanglah meski sulit.",
                        postDate: "22 September 2024"
                    )
                }
            ),
            new ContentViewModel(
                postId: "4",
                author:
                new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                ),
                title: "Kenangan yang Tersisa",
                content: "Curabitur non nulla sit amet nisl tempus convallis quis ac lectus.",
                postDate: "5 October 2024",
                lastEdit: "2 October 2024",
                imgSrc: "https://lh3.googleusercontent.com/ogw/AF2bZyiQSDYdpGWlSrg8eJ1yYHSRxQ73eJvhC8K4A-htZ1bAfYA=s32-c-mo",
                comments: []
            )
        };

        private static ContentViewModel[] TemporaryProducts = new ContentViewModel[]
        {
            new ContentViewModel(
                price: 1000000,
                quantity: 10,
                productId: "1",
                seller: new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                    ),
                name: "Laptop Asus ROG Strix G531GT",
                description: "Laptop gaming terbaik dengan spesifikasi tinggi. Dijual dengan harga terjangkau, jangan lewatkan kesempatan ini!",
                imgSrc: "https://drive.google.com/uc?export=download&id=1rTyCsI0Byp9Mf0y_lLo120Oo57y5AWhn"
            ),
            new ContentViewModel(
                price: 265765,
                quantity: 5,
                productId: "2",
                seller: new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                    ),
                name: "Smartphone Samsung Galaxy S20",
                description: "Ponsel flagship dengan spesifikasi terbaik. Dijual dengan harga terjangkau, jangan lewatkan kesempatan ini!",
                imgSrc: "https://drive.google.com/uc?export=download&id=1rTyCsI0Byp9Mf0y_lLo120Oo57y5AWhn"
            ),
            new ContentViewModel(
                price: 1000000,
                quantity: 1,
                productId: "3",
                seller: new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                    ),
                name: "Smartwatch Apple Watch Series 6",
                description: "Smartwatch terbaik dari Apple, dengan fitur terbaru dan desain yang elegan. Dijual dengan harga terjangkau!",
                imgSrc: "https://drive.google.com/uc?export=download&id=1rTyCsI0Byp9Mf0y_lLo120Oo57y5AWhn"
            )

        };

        private static ContentViewModel[] TemporarySellingProducts = new ContentViewModel[]
        {
            new ContentViewModel(
                price: 1000000,
                quantity: 10,
                productId: "1",
                seller: new Classes.User(
                    username: "Cornelius Joko",
                    password: "johnjohnson123",
                    uuid: "5"
                    ),
                name: "Laptop Asus ROG Strix G531GT",
                description: "Laptop gaming terbaik dengan spesifikasi tinggi. Dijual dengan harga terjangkau, jangan lewatkan kesempatan ini!",
                imgSrc: "https://drive.google.com/uc?export=download&id=1rTyCsI0Byp9Mf0y_lLo120Oo57y5AWhn"
            )
        };

        // Getter Setter for TemporaryPosts, TemporaryProducts, TemporarySellingProducts
        public static ContentViewModel[] TemporaryPostsMod
        {
            get { return TemporaryPosts; }
            set { TemporaryPosts = value; }
        }

        public static ContentViewModel[] TemporaryProductsMod
        {
            get { return TemporaryProducts; }
            set { TemporaryProducts = value; }
        }

        public static ContentViewModel[] TemporarySellingProductsMod
        {
            get { return TemporarySellingProducts; }
            set { TemporarySellingProducts = value; }
        }

        // CRUD Functions
        // Push One for TemporaryPosts, TemporaryProducts, TemporarySellingProducts

        public static async Task<ContentViewModel[]> GetAllContent()
        {
            List<ContentViewModel> newData = new List<ContentViewModel>();

            var data = await Post.getPosting();

            for (int i = 0; i < data.Count; i++)
            {
                var selectedObj = data[i];

                // Create new ContentViewModel objects
                User newUser = new User
                    (
                         username: selectedObj.author.username.ToString(),
                         password: "",
                         uuid: selectedObj.author.uuid.ToString()
                    );

                List<CommentViewModel> newComments = new List<CommentViewModel>();

                int commentSize = selectedObj.comments.Count;
                for (int j = 0; j < commentSize; j++)
                {
                    var selectedComm = selectedObj.comments[j];

                    User newCommentor = new User
                    (
                        username: selectedComm.author.username.ToString(),
                        password: "",
                        uuid: selectedComm.author.uuid.ToString()
                    );

                    CommentViewModel newComment = new CommentViewModel
                    (
                        postId: selectedComm.postId.ToString(),
                        author: newCommentor,
                        content: selectedComm.content.ToString(),
                        postDate: selectedComm.postDate.ToString()
                    );

                    newComments.Add(newComment);
                };

                CommentViewModel[] commentsArray = newComments.ToArray();

                Post newPost = new Post
                (
                    postId: selectedObj.postId.ToString(),
                    authorId: newUser,
                    content: selectedObj.content.ToString(),
                    title: selectedObj.title.ToString(),
                    postDate: selectedObj.postDate.ToString(),
                    imgSrc: selectedObj.imgSrc.ToString(),
                    lastEdit: selectedObj.lastEdit.ToString(),
                    comments: commentsArray
                );

                ContentViewModel newItem = new ContentViewModel(
                    post: newPost
                );

                // Add items to the list
                newData.Add(newItem);
            }

            // If you still need an array, you can convert the list back to an array
            ContentViewModel[] newArray = newData.ToArray();

            return newArray;
        }

        //public static async Task<ContentViewModel[]> getAllProduct()
        //{
        //    var products = await Products.getAllProduct(); // Assuming this fetches a list of products
        //    List<ContentViewModel> newData = new List<ContentViewModel>();

        //    foreach (var product in products)
        //    {
        //        var contentViewModel = new ContentViewModel
        //        (
        //            price = product.price,
        //            quantity = product.quantity,
        //            productId = product.productId,
        //            name = product.name,
        //            description = product.description,
        //            imgSrc = product.image.Trim(), // Ensure no leading/trailing spaces
        //            seller = new User
        //            {
        //                username = product.user_table.username,
        //                uuid = product.user_table.userId
        //                // Password is not provided, can be left empty or handled differently
        //            }
        //        );

        //        // Add the created ContentViewModel to the list
        //        newData.Add(contentViewModel);
        //    }

        //    // Convert the List<ContentViewModel> to an array and return it
        //    return newData.ToArray();
        //}

        public static ContentViewModel[] PushOne(ContentViewModel[] arrIn, ContentViewModel item)
        {
            var arr = arrIn;

            ContentViewModel[] newArr = new ContentViewModel[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[arr.Length] = item;
            return newArr;
        }

        // Delete by id for TemporaryPosts, TemporaryProducts, TemporarySellingProducts
        public static ContentViewModel[] DeleteById(ContentViewModel[] arrIn, string id)
        {
            var arr = arrIn;

            ContentViewModel[] newArr = new ContentViewModel[arr.Length - 1];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Post != null && arr[i].Post.PostId != id)
                {
                    newArr[j] = arr[i];
                    j++;
                }
                else if (arr[i].Product != null && arr[i].Product.ProductId != id)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            return newArr;
        }

        // Update by id for TemporaryPosts, TemporaryProducts, TemporarySellingProducts
        public static ContentViewModel[] UpdateById(ContentViewModel[] arrIn, string id, ContentViewModel item)
        {
            var arr = arrIn;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Post != null && arr[i].Post.PostId == id)
                {
                    arr[i] = item;
                }
                else if (arr[i].Product != null && arr[i].Product.ProductId == id)
                {
                    arr[i] = item;
                }
            }

            return arr;
        }

        // Get by id for TemporaryPosts, TemporaryProducts, TemporarySellingProducts
        public static ContentViewModel GetById(ContentViewModel[] arr, string id)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Post != null && arr[i].Post.PostId == id)
                {
                    return arr[i];
                }
                else if (arr[i].Product != null && arr[i].Product.ProductId == id)
                {
                    return arr[i];
                }
            }
            return null;
        }
    }
}
