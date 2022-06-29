namespace BusinessSvc.Repository.Persistence.SQL
{
    internal static class BusinessSQL
    {
        internal const string INSERT_CUSTOMER =
        @"
            INSERT INTO Customers(name, email) values(:name, :email)
        ";

        internal const string INSERT_ORDER =
        @"
            INSERT INTO Orders(customerId, price, createdAt, status) values (:customerId, :price, :createdAt, :status)
        ";

        internal const string GET_ALL_CUSTOMERS =
        @"
            SELECT * FROM Customers
        ";

        internal const string GET_CUSTOMER_BY_NAME =
        @"
            SELECT * FROM Customers WHERE name = :name
        ";

        internal const string GET_CUSTOMER_BY_ID =
        @"
            SELECT * FROM Customers WHERE customerId = :customerId
        ";

        internal const string GET_ORDERS_BY_CUSTOMER_ID =
        @"
            SELECT * FROM Orders WHERE customerId = :customerId
        ";

        internal const string UPDATE_ORDER_STATUS_BY_ID =
        @"
            UPDATE Orders SET status = :status
            WHERE orderId = :orderId
        ";
    }
}
