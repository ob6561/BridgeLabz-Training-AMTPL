using Microsoft.Data.SqlClient;


namespace Billing_APP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=ADIYOGI;Database=BillingDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Connected to SQL Server successfully!");
                using SqlTransaction transaction = connection.BeginTransaction();
                try
                {

                    string insertBillQuery = "INSERT INTO Bills (TotalAmount) VALUES (1000); SELECT SCOPE_IDENTITY();";
                    int billId;

                    using (SqlCommand cmd = new SqlCommand(insertBillQuery, connection, transaction))
                    {
                        billId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    Console.WriteLine("Generated BillId: " + billId);

                    transaction.Commit();
                    Console.WriteLine("Transaction committed. Bill inserted.");

                    //int ProductId = 3;
                    //int Quantity = 10;

                    //string checkStock = "Select StockQty FROM Inventory WHERE ProductId = @pid";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction rolled back.");
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}