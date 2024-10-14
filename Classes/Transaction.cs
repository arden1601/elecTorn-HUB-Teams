namespace elecTorn_HUB_Teams.Classes;

class Transaction {
    private string _transactionId;
    private Products _productId;
    private User _buyerId;
    private User _sellerId;

    public Transaction(string transactionId, Products productId, User buyerId, User sellerId) {
        _transactionId = transactionId;
        _productId = productId;
        _buyerId = buyerId;
        _sellerId = sellerId;
    }

    public string TransactionId {
        get { return _transactionId; }
        set { _transactionId = value; }
    }

    public Products ProductId {
        get { return _productId; }
        set { _productId = value; }
    }

    public User BuyerId {
        get { return _buyerId; }
        set { _buyerId = value; }
    }

    public User SellerId {
        get { return _sellerId; }
        set { _sellerId = value; }
    }

    public void UpdateTransaction(string transactionId, Products productId, User buyerId, User sellerId) {
        _transactionId = transactionId;
        _productId = productId;
        _buyerId = buyerId;
        _sellerId = sellerId;
    }
}