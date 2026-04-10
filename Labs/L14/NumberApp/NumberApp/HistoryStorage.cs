using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NumberApp
{
    class HistoryStorage
    {
        private string dbConnectionString;

        public HistoryStorage()
        {
            dbConnectionString = @"Data Source=.\SQLEXPRESS02;Initial Catalog=NumberSystemsDB;Integrated Security=True;";
        }

        public bool SaveConversion(string sourceNumber, int sourceBase, string targetNumber, int targetBase)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO ConversionHistory (InputNumber, InputBase, OutputNumber, OutputBase, ConversionDate)
                                     VALUES (@InputNumber, @InputBase, @OutputNumber, @OutputBase, @ConversionDate)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@InputNumber", sourceNumber);
                        cmd.Parameters.AddWithValue("@InputBase", sourceBase);
                        cmd.Parameters.AddWithValue("@OutputNumber", targetNumber);
                        cmd.Parameters.AddWithValue("@OutputBase", targetBase);
                        cmd.Parameters.AddWithValue("@ConversionDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении в базу данных: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable LoadAllConversions()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT InputNumber AS 'Исходное число', 
                                            InputBase AS 'Из системы', 
                                            OutputNumber AS 'Результат', 
                                            OutputBase AS 'В систему', 
                                            ConversionDate AS 'Дата конвертации'
                                     FROM ConversionHistory
                                     ORDER BY ConversionDate DESC";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке истории: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }
    }
}