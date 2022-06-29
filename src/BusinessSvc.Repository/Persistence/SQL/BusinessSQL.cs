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
