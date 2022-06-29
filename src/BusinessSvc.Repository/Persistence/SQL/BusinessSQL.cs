namespace BusinessSvc.Repository.Persistence.SQL
{
    internal static class BusinessSQL
    {
        internal const string CREATE_CUSTOMERS =
        @"
            CREATE TABLE Customers (
              customerId INTEGER PRIMARY KEY AUTOINCREMENT,
              name TEXT UNIQUE,
              email TEXT
            )
        ";

        internal const string CREATE_ORDERS =
        @"
            CREATE TABLE Orders (
              customerId INTEGER,
              price DECIMAL,
              createdAt TEXT,
              status INTEGER,
              FOREIGN KEY(customerId) REFERENCES Customers(customerId)
            )
        ";

        internal const string INSERT_CUSTOMER =
        @"
            INSERT INTO Customers(name, email) values(:name, :email)
        ";

        internal const string INSERT_ORDER =
        @"
            INSERT INTO Orders values (:customerId, :price, :createdAt, :status)
        ";

        internal const string GET_ALL_CUSTOMERS =
        @"
            SELECT * FROM Customers
        ";

        internal const string GET_CUSTOMER =
        @"
            SELECT * FROM Customers WHERE name = :name
        ";

        internal const string GET_CUSTOMER_ORDERS =
        @"
            SELECT * FROM Orders WHERE customerId = :customerId
        ";

        internal const string UPDATE_ORDER_STATUS =
        @"
            UPDATE Orders SET status = :status
            WHERE customerId = :customerId
        ";
    }
}
