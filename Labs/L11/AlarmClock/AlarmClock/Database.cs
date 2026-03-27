using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AlarmClock
{
    public class Database
    {
        private string connectionString =
            @"Data Source=.\SQLEXPRESS02;Initial Catalog=AlarmClockDB;Integrated Security=True";
            //@"Data Source=.\SQLEXPRESS;Initial Catalog=AlarmClockDB;Integrated Security=True";

        public List<Alarm> GetAlarms()
        {
            var list = new List<Alarm>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand("SELECT * FROM Alarms", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Alarm
                    {
                        Id = (int)reader["Id"],
                        Time = (TimeSpan)reader["AlarmTime"],
                        IsActive = (bool)reader["IsActive"],
                        RepeatDaily = (bool)reader["RepeatDaily"],
                        Label = reader["Label"]?.ToString(),
                        CreatedDate = (DateTime)reader["CreatedDate"]
                    });
                }
            }

            return list;
        }

        public void AddAlarm(Alarm alarm)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand(
                    @"INSERT INTO Alarms (AlarmTime, IsActive, RepeatDaily, Label)
                      VALUES (@t,@a,@r,@l)", conn);

                cmd.Parameters.AddWithValue("@t", alarm.Time);
                cmd.Parameters.AddWithValue("@a", alarm.IsActive);
                cmd.Parameters.AddWithValue("@r", alarm.RepeatDaily);
                cmd.Parameters.AddWithValue("@l", (object)alarm.Label ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAlarm(Alarm alarm)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand(
                    @"UPDATE Alarms 
                      SET AlarmTime=@t, IsActive=@a, RepeatDaily=@r, Label=@l
                      WHERE Id=@id", conn);

                cmd.Parameters.AddWithValue("@t", alarm.Time);
                cmd.Parameters.AddWithValue("@a", alarm.IsActive);
                cmd.Parameters.AddWithValue("@r", alarm.RepeatDaily);
                cmd.Parameters.AddWithValue("@l", (object)alarm.Label ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id", alarm.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAlarm(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand("DELETE FROM Alarms WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}