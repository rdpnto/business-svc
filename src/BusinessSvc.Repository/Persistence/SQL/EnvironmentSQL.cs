namespace BusinessSvc.Repository.Persistence.SQL
{
    public static class EnvironmentSQL
    {
        public const string CREATE_CUSTOMERS =
        @"
            CREATE TABLE Customers (
              customerId INTEGER PRIMARY KEY AUTOINCREMENT,
              name TEXT UNIQUE,
              email TEXT
            )
        ";

        public const string CREATE_ORDERS =
        @"
            CREATE TABLE Orders (
              customerId INTEGER,
              price DECIMAL,
              createdAt TEXT,
              status INTEGER,
              FOREIGN KEY(customerId) REFERENCES Customers(customerId)
            )
        ";
    }
}
