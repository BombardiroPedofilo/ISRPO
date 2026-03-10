using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using PublishingApp.Models;
using System.Windows.Forms;

namespace PublishingApp
{
    public class DatabaseHelper : IDisposable
    {
        private string connectionString = @"Data Source=060JI0Hb\SQLEXPRESS02;Initial Catalog=publishing;Integrated Security=True;Connect Timeout=30";//для ноута
        //private string connectionString = @"Data Source=TTEKAPH9I\SQLEXPRESS;Initial Catalog=publishing;Integrated Security=True;Connect Timeout=30";//для компа
        public List<Book> GetBooks()
        {
            var books = new List<Book>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT p.id_Publication, p.Name, p.Author,
                               a.Surname + ' ' + a.Name as AuthorName,
                               p.ReleaseYear, p.VolumeOfSheets, p.Circulation
                        FROM Publications p
                        LEFT JOIN Authors a ON p.Author = a.id_Author
                        ORDER BY p.Name";

                    using (var command = new SqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                Id = (int)reader["id_Publication"],
                                Title = reader["Name"].ToString(),
                                AuthorId = reader["Author"] != DBNull.Value ? (int)reader["Author"] : 0,
                                AuthorName = reader["AuthorName"].ToString(),
                                ReleaseYear = (int)reader["ReleaseYear"],
                                Pages = (int)reader["VolumeOfSheets"],
                                Circulation = (int)reader["Circulation"]
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Общая ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return books;
        }

        public List<Office> GetOffices()
        {
            var offices = new List<Office>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_Office, Office, Address, Phone FROM Offices ORDER BY Office";

                    using (var command = new SqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            offices.Add(new Office
                            {
                                Id = (int)reader["id_Office"],
                                Name = reader["Office"].ToString(),
                                Address = reader["Address"].ToString(),
                                Phone = reader["Phone"].ToString()
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Общая ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return offices;
        }

        public int CreateOrder(Order order)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // УБРАЛИ Name из запроса!
                    string query = @"
                INSERT INTO Orders (Type, Publication, Office, Customer, DateOfAdmission, DateOfCompletion, Price)
                VALUES (1, @Publication, @Office, @Customer, @DateOfAdmission, @DateOfCompletion, @Price);
                SELECT SCOPE_IDENTITY();";

                    using (var command = new SqlCommand(query, connection))
                    {
                        // УБРАЛИ эту строку: command.Parameters.AddWithValue("@Name", order.OrderName);
                        command.Parameters.AddWithValue("@Publication", order.BookId);
                        command.Parameters.AddWithValue("@Office", order.OfficeId);
                        command.Parameters.AddWithValue("@Customer", order.CustomerId);
                        command.Parameters.AddWithValue("@DateOfAdmission", order.OrderDate);

                        if (order.CompletionDate.HasValue)
                            command.Parameters.AddWithValue("@DateOfCompletion", order.CompletionDate.Value);
                        else
                            command.Parameters.AddWithValue("@DateOfCompletion", DBNull.Value);

                        command.Parameters.AddWithValue("@Price", order.Price);

                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка при создании заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Общая ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public int CreateCustomer(Customer customer)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                INSERT INTO Customers (Name, Type, Address, Phone)
                VALUES (@Name, 1, @Address, @Phone);
                SELECT SCOPE_IDENTITY();";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", customer.Name);
                        command.Parameters.AddWithValue("@Address",
                            string.IsNullOrEmpty(customer.Address) ? (object)DBNull.Value : customer.Address);
                        command.Parameters.AddWithValue("@Phone",
                            string.IsNullOrEmpty(customer.Phone) ? (object)DBNull.Value : customer.Phone);

                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка при создании клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Общая ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public Order GetOrderDetails(int orderId)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // УБРАЛИ o.Name as OrderName из SELECT
                    string query = @"
                SELECT o.id_Order, o.DateOfAdmission, o.Price, 
                       p.Name as BookTitle, c.Name as CustomerName,
                       ofc.Office as OfficeName
                FROM Orders o
                LEFT JOIN Publications p ON o.Publication = p.id_Publication
                LEFT JOIN Customers c ON o.Customer = c.id_Customer
                LEFT JOIN Offices ofc ON o.Office = ofc.id_Office
                WHERE o.id_Order = @OrderId";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderId", orderId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Order
                                {
                                    Id = (int)reader["id_Order"],
                                    // УБРАЛИ эту строку: OrderName = reader["OrderName"].ToString(),
                                    BookTitle = reader["BookTitle"].ToString(),
                                    CustomerName = reader["CustomerName"].ToString(),
                                    OfficeName = reader["OfficeName"].ToString(),
                                    OrderDate = (DateTime)reader["DateOfAdmission"],
                                    Price = (decimal)reader["Price"]
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка при получении данных заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Общая ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return connection.State == System.Data.ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Тест подключения не пройден: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void Dispose()
        {
            
        }
    }
}