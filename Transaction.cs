namespace elecTorn_HUB_Teams;

class Transaction {
    private string _transactionId;
    private string _productId;
    private string _buyerId;
    private string _sellerId;

    public Transaction(string transactionId, string productId, string buyerId, string sellerId) {
        _transactionId = transactionId;
        _productId = productId;
        _buyerId = buyerId;
        _sellerId = sellerId;
    }

    public string TransactionId {
        get { return _transactionId; }
        set { _transactionId = value; }
    }

    public string ProductId {
        get { return _productId; }
        set { _productId = value; }
    }

    public string BuyerId {
        get { return _buyerId; }
        set { _buyerId = value; }
    }

    public string SellerId {
        get { return _sellerId; }
        set { _sellerId = value; }
    }
}