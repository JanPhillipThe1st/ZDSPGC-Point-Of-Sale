using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace ZDSPGC_Point_Of_Sale
{
    class Database
    {
            public String connectionString;
            public MySqlConnection connection;
            public bool isLoggedIn;
            public bool isAdmin;
        public Dictionary<String, String> cashier;
        public String cashierName,cashierID;
        public Dictionary<String, String> admin;
            public Database()
            {
            cashier = new Dictionary<String, String>();
            admin = new Dictionary<String, String>();
            connectionString = ConfigurationManager.ConnectionStrings["zdspgc"].ConnectionString;
                isLoggedIn = false;
                isAdmin = false;
                connection = new MySqlConnection(connectionString);
            }
            public void cashierLogin(String username, String password)
            {

                using (MySqlCommand command = new MySqlCommand())
                {
                    this.connection.Open();
                    command.Connection = this.connection;
                    command.CommandText = "SELECT * FROM cashier WHERE username = @usernameText AND password = @passwordText;";
                    command.Parameters.AddWithValue("@usernameText", username);
                    command.Parameters.AddWithValue("@passwordText", password);
                    MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    try
                    {
                        cashier.Add(reader.GetString("ID"), reader.GetString("name"));
                    }
                    catch (Exception ex)
                    {
                        if (ex is ArgumentException)
                        {

                        }
                    }
                    
                    cashierName = reader.GetString("name");
                    cashierID = reader.GetString("ID");
                }
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAdmin = false;
                    isLoggedIn = true;
                        command.Dispose();
                        this.connection.Close();
                    }
                    else
                    {
                        adminLogin(username, password);
                        command.Dispose();
                        this.connection.Close();
                    }
                    command.Dispose();
                    this.connection.Close();
                }
            }
            public void adminLogin(String username, String password)
            {
                this.connection.Close();

                using (MySqlCommand command = new MySqlCommand())
                {
                    this.connection.Open();
                    command.Connection = this.connection;
                    command.CommandText = "SELECT * FROM admin WHERE username = @usernameText AND password = @passwordText;";
                    command.Parameters.AddWithValue("@usernameText", username);
                    command.Parameters.AddWithValue("@passwordText", password);
                    MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        admin.Add(reader.GetString("ID"), reader.GetString("name"));
                    }
                    catch (Exception ex)
                    {
                        if (ex is ArgumentException)
                        {

                        }
                    }
                    
                }
                if (reader.HasRows)
                    {
                        MessageBox.Show("Logged in as Administrator.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isAdmin = true;
                        isLoggedIn = true;
                    }
                    else
                    {
                        MessageBox.Show("Login Failed! \n No username found.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isLoggedIn = false;

                    }
                    command.Dispose();
                    this.connection.Close();
                }
            }
        public void fillDailySalesTable(DataGridView dataGridView)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Barcode,  Item_Name, Quantity, FORMAT(Price,2) AS 'Item Price', FORMAT(Total,2) AS 'Total', Date, cashier AS 'Cashier' FROM sales WHERE date = @date";
                command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public void fillPriceArchive(DataGridView dataGridView, String item)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT item AS 'Item',previous_price AS 'Previous Price',new_price AS 'New Price', date_changed AS 'Date Changed'  FROM price_archive WHERE item = @item";
                command.Parameters.AddWithValue("@item", item);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public void fillPriceArchive(DataGridView dataGridView)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT item AS 'Item',previous_price AS 'Previous Price',new_price AS 'New Price', date_changed AS 'Date Changed'  FROM price_archive;";
                command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }

        public void fillCreditItemsTable(DataGridView dataGridView)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Barcode,  Item_Name, Quantity, FORMAT(Price,2) AS 'Item Price', FORMAT(Total,2) AS 'Total', Date, cashier AS 'Cashier' FROM credit_items";
                command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }

        public void fillCreditsTable(DataGridView dataGridView)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT name AS 'Customer', FORMAT(total_credits,2) AS 'All time Credits', FORMAT(remaining_credits,2) AS 'Remaining Balance' FROM customer WHERE remaining_credits  >=1";
                command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public void fillPaymentsTable(DataGridView dataGridView)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT customer AS 'Customer', FORMAT(amount,2) AS 'Amount paid', FORMAT(remaining_balance,2) AS 'Remaining Balance', date AS 'Date Paid' FROM payments ";
                command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public void addPayment(String customer, Double amount, Double remaining_balance)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO payments(customer, amount, remaining_balance) VALUES(@customer, @amount, @remaining_balance)";
                command.Parameters.AddWithValue("@customer",customer);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@remaining_balance", remaining_balance);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void addPriceArchive(String item, Double previous_price,Double new_price, DateTime date_changed)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO price_archive(item,previous_price,new_price,date_changed) VALUES(@item,@previous_price,@new_price,@date_changed)";
                command.Parameters.AddWithValue("@item", item);
                command.Parameters.AddWithValue("@previous_price", previous_price);
                command.Parameters.AddWithValue("@new_price", new_price);
                command.Parameters.AddWithValue("@date_changed", date_changed);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void fillCashierTable(DataGridView dataGridView)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM cashier";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public void fillAdminTable(DataGridView dataGridView)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM admin";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public void fillPettyCashTable(DataGridView dataGridView,String cashier)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT cashier AS 'Cashier', FORMAT(amount,2) AS 'Amount', date_added AS 'Date Added' FROM petty_cash WHERE cashier=@cashier";
                command.Parameters.AddWithValue("@cashier", cashier);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public String getLastOR()
        {
            String orNo = "";
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID FROM sales";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    orNo = reader.GetString(0);
                }
                command.Dispose();
                this.connection.Close();
                return orNo;
            }

        }
        public String getLastBarcode()
        {
            String orNo = "";
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID FROM barcodes";
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    orNo = "0";
                }
                else
                {
                    while (reader.Read())
                    {
                        orNo = reader.GetString(0);
                    }
                }
                command.Dispose();
                this.connection.Close();
                return orNo;
            }

        }
        public void fillDailySalesTableCashier(DataGridView dataGridView,String cashierName)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Barcode,  Item_Name, Quantity, FORMAT(Price,2) AS 'Item Price', FORMAT(Total,2) AS 'Total', Date, cashier FROM sales WHERE date = @date AND cashier = @cashier";
                command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                command.Parameters.AddWithValue("@cashier", cashierName);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public Double getProductPrice(String barcode)
        {
            Double price = 0;
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT  unit_price FROM products WHERE ID = @ID UNION SELECT  unit_price FROM consignment_item WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", barcode);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    price = Convert.ToDouble(reader.GetString(0));
                }
                command.Dispose();
                this.connection.Close();
                return price;
            }

        }
        public void fillSalesTableCashierByDate(DataGridView dataGridView, DateTime from, DateTime to, String cashier)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Barcode, cashier, Item_Name, Quantity, FORMAT(Price,2) AS 'Item Price', FORMAT(Total,2) AS 'Total' FROM sales WHERE date > @from AND date < @to AND cashier = @cashier";
                command.Parameters.AddWithValue("@from", from);
                command.Parameters.AddWithValue("@to", to);
                command.Parameters.AddWithValue("@cashier", cashier);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }
        }
            public void fillInventoryTable(DataGridView dataGridView)
            {
                this.connection.Close();
                using (MySqlCommand command = new MySqlCommand())
                {
                    this.connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT item_description AS 'Item Description', unit AS 'Unit', FORMAT(original_price,2) AS 'Original Price', FORMAT(unit_price,2) AS 'Unit Price', date_added AS 'Date Added', quantity AS 'Quantity', remaining_quantity AS 'Remaining Quantity', sold_quantity AS 'Sold Quantity'  FROM products";
                    MySqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView.DataSource = dataTable;
                    command.Dispose();
                    this.connection.Close();

                }

            }
        public void fillSalesTableAdminByDate(DataGridView dataGridView, DateTime from, DateTime to)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Barcode, cashier, Item_Name, Quantity, FORMAT(Price,2) AS 'Item Price', FORMAT(Total,2) AS 'Total' FROM sales WHERE date > @from AND date < @to";
                command.Parameters.AddWithValue("@from", from);
                command.Parameters.AddWithValue("@to", to);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public void fillLowStockProductsTable(DataGridView dataGridView)
            {
                this.connection.Close();
                using (MySqlCommand command = new MySqlCommand())
                {
                    this.connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT item_description AS 'Item Description' , remaining_quantity AS 'Remaining Quantity' FROM products  WHERE remaining_quantity <  5;";
                    MySqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView.DataSource = dataTable;
                    command.Dispose();
                    this.connection.Close();

                }

            }
        public void  fillConsignmentTable(DataGridView dataGridView)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT item_description AS 'Item Description'" +
                    ", unit AS 'Unit', original_price AS 'Original Price', unit_price AS 'Unit Price'" +
                    ", date_added AS 'Date Added', quantity AS 'Quantity', supplier AS 'Supplier', sold_quantity AS 'Sold Quantity', sold_quantity * original_price AS 'Supplier Sales', sold_quantity * unit_price AS 'Profit'  FROM products WHERE classification='consignment';";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();
                
            }
        }

        public void fillBarcodesTable(DataGridView dataGridView)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID AS 'Barcode', path AS 'Image Path' FROM barcodes";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public void fillCustomersTable(DataGridView dataGridView)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT  name AS 'Customer name', contact AS 'Contact', address AS 'Address'   FROM customer";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public void fillSuppliersTable(DataGridView dataGridView)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT  name AS 'Supplier name', contact AS 'Contact', address AS 'Address'   FROM supplier";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public void fillUnitsTable(DataGridView dataGridView)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT  unit AS 'Unit'   FROM unit";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                command.Dispose();
                this.connection.Close();

            }

        }
        public String getCustomerIDByName(String name)
        {
            String result = "";
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT  ID   FROM customer WHERE name = @name;";
                command.Parameters.AddWithValue("@name",name);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetString("ID");
                }
                command.Dispose();
                this.connection.Close();
                return result;
            }

        }
        public String getSupplierIDByName(String name)
        {
            String result = "";
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT  ID   FROM supplier WHERE name = @name;";
                command.Parameters.AddWithValue("@name", name);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetString("ID");
                }
                command.Dispose();
                this.connection.Close();
                return result;
            }

        }
        public String getUnitIDByName(String name)
        {
            String result = "";
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT  ID   FROM unit WHERE unit = @name;";
                command.Parameters.AddWithValue("@name", name);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetString("ID");
                }
                command.Dispose();
                this.connection.Close();
                return result;
            }

        }
        public Dictionary<String,String> getConsignmentsAsDictionary()
        {
            Dictionary<String, String> result = new Dictionary<String, String>();
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID,item_description FROM consignment_item;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString(1),reader.GetString(0));
                }
                command.Dispose();
                this.connection.Close();
                return result;
            }

        }
        public void deleteConsignment(String ID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE  FROM products WHERE ID = @ID AND classification = 'consignment';";
                command.Parameters.AddWithValue("@ID",ID);
                MySqlDataReader reader = command.ExecuteReader();
                command.Dispose();
                this.connection.Close();
            }

        }
        public Dictionary<String, String> getItemsAsDictionary()
        {
            Dictionary<String, String> result = new Dictionary<String, String>();
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID,item_description FROM products UNION SELECT ID,item_description FROM consignment_item;";
                MySqlDataReader reader = command.ExecuteReader();
                if (result.Count >= 1)
                {
                    result.Clear();
                }
                else
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(1), reader.GetString(0));
                    }
                }
                
                command.Dispose();
                this.connection.Close();
                return result;
            }

        }
        public Dictionary<String, String> getProductsAsDictionary()
        {
            Dictionary<String, String> result = new Dictionary<String, String>();
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID,item_description FROM products;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString(1), reader.GetString(0));
                }
                command.Dispose();
                this.connection.Close();
                return result;
            }

        }
        public Dictionary<String, String> getCustomers()
        {
            Dictionary<String, String> result = new Dictionary<String, String>();
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID, name FROM customer;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString(1), reader.GetString(0));
                }
                command.Dispose();
                this.connection.Close();
                return result;
            }

        }
        public void autoFillItemFromBarcode(TextBox item, TextBox price,String barcode)
        {
            Dictionary<String, String> result = new Dictionary<String, String>();
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID,item_description,FORMAT(unit_price,2) FROM products WHERE ID = @barcode AND remaining_quantity >= 1  UNION SELECT ID,item_description,FORMAT(unit_price,2) FROM consignment_item WHERE ID = @barcode AND remaining_quantity >= 1 ;";
                command.Parameters.AddWithValue("@barcode", barcode);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    item.Text = reader.GetString(1);
                    price.Text = reader.GetString(2);
                }
                command.Dispose();
                this.connection.Close();
            }

        }
        public void autoFillItemFromName(TextBox price,TextBox barcode, String name)
        {
            Dictionary<String, String> result = new Dictionary<String, String>();
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID,item_description,unit_price FROM products WHERE item_description = @name AND remaining_quantity >= 1  UNION SELECT ID,item_description,unit_price FROM consignment_item WHERE item_description = @name AND remaining_quantity >= 1 ;";
                command.Parameters.AddWithValue("@name", name);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    barcode.Text = reader.GetString(0);
                    price.Text = reader.GetString(2);
                }
                command.Dispose();
                this.connection.Close();
            }

        }
        public void addconsignment(String barcode,String itemDescription, String unit, Double original_price, Double unit_price, int quantity, String supplier, DateTime dateAdded)
            {
            try
            {
                this.connection.Close();
                using (MySqlCommand command = new MySqlCommand())
                {
                    this.connection.Open();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO products(ID,item_description,unit,original_price,unit_price, quantity,remaining_quantity,supplier,date_added,classification)" +
                        " VALUES(@barcode,@item, @unit,@original_price,@unit_price,@quantity,@quantity,@supplier,@date_added,'consignment');";
                    command.Parameters.AddWithValue("@item", itemDescription);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@unit", unit);
                    command.Parameters.AddWithValue("@barcode", barcode);
                    command.Parameters.AddWithValue("@original_price", original_price);
                    command.Parameters.AddWithValue("@unit_price", unit_price);
                    command.Parameters.AddWithValue("@supplier", supplier);
                    command.Parameters.AddWithValue("@date_added", dateAdded);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    this.connection.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                

            }
        public void addBarcode(String ID,  String path)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO barcodes (ID,path) VALUES(@ID,@path)";
                command.Parameters.AddWithValue("@path", path);
                command.Parameters.AddWithValue("@ID", ID);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void addCustomer(String name, String address, String contact)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO customer (name, address, contact) VALUES(@name,@address,@contact)";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@contact", contact);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void updateCustomer(String name, String address, String contact,String updateID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE customer SET name = @name, address = @address, contact = @contact WHERE ID = @ID";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@contact", contact);
                command.Parameters.AddWithValue("@ID", updateID);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void deleteCustomer(String updateID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM customer WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", updateID);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void addSupplier(String name, String address, String contact)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO supplier (name, address, contact) VALUES(@name,@address,@contact)";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@contact", contact);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void updateSupplier(String name, String address, String contact, String updateID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE supplier SET name = @name, address = @address, contact = @contact WHERE ID = @ID";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@contact", contact);
                command.Parameters.AddWithValue("@ID", updateID);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void deleteSupplier(String updateID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM supplier WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", updateID);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void addUnit(String unit)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO unit (unit) VALUES(@unit)";
                command.Parameters.AddWithValue("@unit", unit);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void updateUnit(String unit, String updateID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE unit SET unit = @unit WHERE ID = @ID";
                command.Parameters.AddWithValue("@unit", unit);
                command.Parameters.AddWithValue("@ID", updateID);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void deleteUnit(String updateID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM unit WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", updateID);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }

        public Dictionary<String, String> getCustomersAsDictionary(String updateID)
        {
            this.connection.Close();
            Dictionary<String, String> result = new Dictionary<String, String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID, name FROM customer;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString("name"), reader.GetString("ID"));
                }
                command.Dispose();
                this.connection.Close();
                return result;
            }

        }
        public Dictionary<String, String> getSuppliersAsDictionary(String updateID)
        {
            this.connection.Close();
            Dictionary<String, String> result = new Dictionary<String, String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID, name FROM supplier;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString("name"), reader.GetString("ID"));
                }
                command.Dispose();
                this.connection.Close();
                return result;
            }

        }
        public Dictionary<String, String> getUnitsAsDictionary()
        {
            this.connection.Close();
            Dictionary<String, String> result = new Dictionary<String, String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID, unit FROM unit;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString("unit"), reader.GetString("ID"));
                }
                command.Dispose();
                this.connection.Close();
                return result;
            }

        }

        public void addPettyCash(String cashier,Double amount)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO petty_cash (cashier,amount) VALUES(@cashier,@amount)";
                command.Parameters.AddWithValue("@cashier", cashier);
                command.Parameters.AddWithValue("@amount", amount);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }

        public void addItem(String barcode,String itemDescription, String unit, Double original_price, Double unit_price, int quantity,DateTime dateAdded)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO products(ID,item_description,unit,original_price,unit_price, quantity,remaining_quantity,date_added)" +
                    " VALUES(@ID,@item, @unit,@original_price,@unit_price,@quantity,@remaining_quantity,@date_added);";
                command.Parameters.AddWithValue("@ID", barcode);
                command.Parameters.AddWithValue("@item", itemDescription);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@remaining_quantity", quantity);
                command.Parameters.AddWithValue("@unit", unit);
                command.Parameters.AddWithValue("@original_price", original_price);
                command.Parameters.AddWithValue("@unit_price", unit_price);
                command.Parameters.AddWithValue("@date_added", dateAdded);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void updateItem(String barcode, String itemDescription, String unit, Double original_price, Double unit_price, int quantity,int remainingQuantity,int addedQuantity, String updateID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE products SET ID = @ID, item_description = @item, unit = @unit,original_price = @original_price,unit_price = @unit_price,quantity = @quantity+@remaining_quantity, remaining_quantity = @remaining_quantity + @addedQuantity WHERE ID = @updateID;";
                command.Parameters.AddWithValue("@ID", barcode);
                command.Parameters.AddWithValue("@updateID", updateID);
                command.Parameters.AddWithValue("@item", itemDescription);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@remaining_quantity", remainingQuantity);
                command.Parameters.AddWithValue("@unit", unit);
                command.Parameters.AddWithValue("@original_price", original_price);
                command.Parameters.AddWithValue("@addedQuantity", addedQuantity);
                command.Parameters.AddWithValue("@unit_price", unit_price);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void updateItem( int returnedQuantity, String updateID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE products SET remaining_quantity = remaining_quantity + @returnedQuantity WHERE ID = @updateID;";
                command.Parameters.AddWithValue("@updateID", updateID);
                command.Parameters.AddWithValue("@returnedQuantity", returnedQuantity);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public Double getSalesLogout(String cashier)
        {
            Double salesTotal = 0;
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT total FROM sales WHERE cashier = @cashier AND date = @date;";
                command.Parameters.AddWithValue("@cashier", cashier);
                command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                MySqlDataReader reader  = command.ExecuteReader();
                while (reader.Read())
                {
                    salesTotal += Convert.ToDouble(reader.GetValue(0));
                }
                command.Dispose();
                this.connection.Close();
                return salesTotal;
            }

        }
        public Double getPettyCashLogout(String cashier)
        {
            Double pettyCash = 0;
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT amount FROM petty_cash WHERE cashier = @cashier AND date_added = @date;";
                command.Parameters.AddWithValue("@cashier", cashier);
                command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pettyCash += Convert.ToDouble(reader.GetValue(0));
                }
                command.Dispose();
                this.connection.Close();
                return pettyCash;
            }

        }
        public void updateCashier(String name, String username, String password, String updateID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE cashier SET name = @name, username = @username,password = @password WHERE ID = @updateID;";
                command.Parameters.AddWithValue("@updateID", updateID);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void deleteCashier(String updateID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM cashier WHERE ID = @updateID;";
                command.Parameters.AddWithValue("@updateID", updateID);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void addCashier(String name, String username, String password)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO cashier(name,username,password)   VALUES(@name,@username, @password);";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }

        public void updateAdmin(String name, String username, String password,String updateID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE admin SET name = @name, username = @username,password = @password WHERE ID = @updateID;";
                command.Parameters.AddWithValue("@updateID", updateID);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void deleteAdmin(String updateID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM admin WHERE ID = @updateID;";
                command.Parameters.AddWithValue("@updateID", updateID);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void addAdmin(String name, String username, String password)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO admin(name,username,password)   VALUES(@name,@username, @password);";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public bool getItemClassification(String name, String ID)
        {
            bool result = false;
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT classification FROM products WHERE ID = @ID";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@ID", ID);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString("classification").Contains("consignment") || reader.GetString("classification") == "consignment")
                    {
                        result = true;
                    }
                    else {
                        result = false;
                    }
                }
                command.Dispose();
                this.connection.Close();

            }
            return result;

        }
        public void deleteItem(String barcode)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM products WHERE ID = @ID;";
                command.Parameters.AddWithValue("@ID", barcode);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void updateConsignment(String itemDescription, String unit, Double original_price, Double unit_price, int quantity, String supplier, String ID)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE consignment_item SET item_description = @item, unit = @unit," +
                    " original_price=@original_price, unit_price = @unit_price, quantity = @quantity, supplier = @supplier WHERE ID = @ID  ";
                command.Parameters.AddWithValue("@item", itemDescription);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@unit", unit);
                command.Parameters.AddWithValue("@original_price", original_price);
                command.Parameters.AddWithValue("@unit_price", unit_price);
                command.Parameters.AddWithValue("@supplier", supplier);
                command.Parameters.AddWithValue("@ID", ID);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void addSale(String barcode,String cashier,String itemName, int quantity ,Double price,Double total,bool isConsignment)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO sales(Barcode,cashier, Item_Name, Quantity, Price,Total,classification) VALUES(@Barcode, @cashier, @Item_Name, @Quantity, @Price,@Total,@classification)";
                command.Parameters.AddWithValue("@cashier", cashier);
                command.Parameters.AddWithValue("@Barcode", barcode);
                command.Parameters.AddWithValue("@Item_Name", itemName);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Total", total);
                if (isConsignment)
                {
                    command.Parameters.AddWithValue("@classification", "consignment");
                }
                else
                {
                    command.Parameters.AddWithValue("@classification", "--");
                }
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void updateSoldQuantity(int quantity, String barcode){
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE products SET sold_quantity = sold_quantity + @quantity WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", barcode);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }
        }
        public void addCredit(String barcode, String cashier, String itemName, int quantity, Double price, Double total)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO credit_items(Barcode,cashier, Item_Name, Quantity, Price,Total) VALUES(@Barcode, @cashier, @Item_Name, @Quantity, @Price,@Total)";
                command.Parameters.AddWithValue("@cashier", cashier);
                command.Parameters.AddWithValue("@Barcode", barcode);
                command.Parameters.AddWithValue("@Item_Name", itemName);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Total", total);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void addCredit(String customer,Double amount)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE customer SET total_credits = total_credits + @amount, remaining_credits = remaining_credits + @amount WHERE name = @customer";
                command.Parameters.AddWithValue("@customer", customer);
                command.Parameters.AddWithValue("@amount", amount);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }

        public void payCredit(String customer,Double amount)
        {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE customer SET  remaining_credits = remaining_credits - @amount WHERE name = @customer";
                command.Parameters.AddWithValue("@customer", customer);
                command.Parameters.AddWithValue("@amount", amount);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }

        }
        public void updateQuantity(int quantity,String ID) {
            this.connection.Close();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE products SET remaining_quantity= remaining_quantity - @quantity WHERE ID = @ID";
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@ID", ID);
                command.ExecuteNonQuery();
                command.Dispose();
                this.connection.Close();

            }
        }
            public int getCurrentItemQuantity(String itemID)
            {
                this.connection.Close();
                int value = 0;
                using (MySqlCommand command = new MySqlCommand())
                {
                    this.connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT remaining_quantity FROM products WHERE ID = @itemID UNION SELECT remaining_quantity FROM consignment_item WHERE ID = @itemID";
                    command.Parameters.AddWithValue("@itemID", itemID);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        value = reader.GetInt32(0);
                    }
                    command.Dispose();
                    this.connection.Close();

                }
                return value;
            }
        
        }
}
