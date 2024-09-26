CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    MerchantID INT,
    Amount DECIMAL(10, 2) NOT NULL,
    TransactionDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (MerchantID) REFERENCES Merchants(MerchantID)
);