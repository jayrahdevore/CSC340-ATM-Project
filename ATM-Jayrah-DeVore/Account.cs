using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ATM_Jayrah_DeVore
{
    internal class Account
    {
        string account_id;
        decimal balance;
        private static String connStr = "server=172.18.0.3;user=root;database=test_atm;port=3306;password=example;";
        decimal MAX_DAILY_TRANSACTION_AMOUNT = (decimal) 3000.00;

        public string getName()
        {
            return this.account_id;
        }

        public decimal getBalance()
        {
            return this.balance;
        }



        override public string ToString()
        {
            return this.account_id;
        }

        public Account(string account_id, decimal balance)
        {
            this.account_id = account_id;
            this.balance = balance;
        }

        public void Update(decimal diff)
        {
            // update database with current balance.  warning: no input validation is performed

            decimal daily_transaction_amount = Math.Round(GetCurrentDailyTransactionAmount() + Math.Abs(diff), 2);
            this.balance = Math.Round(this.balance + diff, 2);

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE accounts SET balance=@bal, day_of_last_transaction = now(), daily_transaction_amount=@dtval WHERE account_id=@uid";
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", this.account_id);
                cmd.Parameters.AddWithValue("@bal", this.balance.ToString());
                cmd.Parameters.AddWithValue("@dtval", daily_transaction_amount.ToString());
                MySqlDataReader myReader = cmd.ExecuteReader();
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");

        }

        public bool ExceedsDailyTransactionAmount(decimal newvalue)
        {
            return GetCurrentDailyTransactionAmount() + Math.Abs(newvalue) > MAX_DAILY_TRANSACTION_AMOUNT;
        }

        public decimal GetCurrentDailyTransactionAmount()
        {
            decimal transaction_amount = (decimal) 0.0;

            // get balance
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT daily_transaction_amount, day_of_last_transaction = CAST(now() as DATE) AS 'is_today' FROM accounts WHERE account_id=@uid";
                MySql.Data.MySqlClient.
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", account_id);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    // if transaction occured today
                    if (int.Parse(myReader["is_today"].ToString()) == 1)
                    {
                        transaction_amount = decimal.Parse(myReader["daily_transaction_amount"].ToString());
                    }
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return transaction_amount;
        }

        public static bool IsValidAccount(string userID, string password)
        {
            bool isValidAccount = false;


            // get balance
            
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT customer_id FROM customers WHERE customer_id=@uid AND pin=@pin";
                MySql.Data.MySqlClient.
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", userID);
                cmd.Parameters.AddWithValue("@pin", password);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    isValidAccount = myReader.HasRows;
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return isValidAccount;
        }

        public static List<Account> getAccounts(string userID)
        {
            // horribly insecure
            List<Account> accounts = new List<Account>();

            // get balance
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT account_id, balance FROM accounts WHERE customer_id=@uid";
                MySql.Data.MySqlClient.
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", userID);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    decimal balance = decimal.Parse(myReader["balance"].ToString());
                    string name = myReader["account_id"].ToString();
                    accounts.Add(new Account(name, balance));
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return accounts;
        }

        /*
        public Account(string account_id)
        {
            this.account_id = account_id;
            this.balance = 0.0;

            // get balance
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT balance FROM accounts WHERE account_id=@uid";
                MySql.Data.MySqlClient.
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", name);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    this.balance = decimal.Parse(myReader["balance"].ToString());
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
        */
    }
}
