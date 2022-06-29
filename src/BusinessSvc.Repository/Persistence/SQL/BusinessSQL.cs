namespace BusinessSvc.Repository.Persistence.SQL
{
    internal static class BusinessSQL
    {
        internal const string SETUP_CONTEXT =
        @"
            CREATE TABLE ""Order"" (
              price DECIMAL,
              createdAt TEXT,
              status INTEGER
            )

            CREATE TABLE Customer (
              name TEXT,
              email TEXT
            )

            INSERT INTO ""Order"" values(13.2, 13-03-2022, 1)
            INSERT INTO Customer values(name, email)
        ";

        internal const string GET_ALL_CUSTOMERS =
        @"
            SELECT * FROM Customer
        ";
    }
}
