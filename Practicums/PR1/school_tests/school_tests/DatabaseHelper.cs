using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace school_tests
{
    public static class DatabaseHelper
    {
        //private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True";
        private static string connectionString = @"Data Source=.\SQLEXPRESS02;Initial Catalog=TestDB;Integrated Security=True";

        /// <summary> Получить список всех вопросов </summary>
        public static DataTable GetQuestions()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, QuestionText, Option1, Option2, Option3, Option4, CorrectOption FROM Questions ORDER BY Id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        /// <summary> Добавить нового пользователя и вернуть его Id </summary>
        public static int AddUser(string firstName, string lastName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (FirstName, LastName) VALUES (@FirstName, @LastName); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        /// <summary> Сохранить ответ пользователя </summary>
        public static void SaveAnswer(int userId, int questionId, int? selectedOption, bool isCorrect)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UserAnswers (UserId, QuestionId, SelectedOption, IsCorrect) VALUES (@uid, @qid, @opt, @corr)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", userId);
                cmd.Parameters.AddWithValue("@qid", questionId);
                cmd.Parameters.AddWithValue("@opt", (object)selectedOption ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@corr", isCorrect);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary> Получить количество правильных ответов пользователя </summary>
        public static int GetCorrectAnswersCount(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM UserAnswers WHERE UserId = @uid AND IsCorrect = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", userId);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        /// <summary> Получить общее количество вопросов </summary>
        public static int GetTotalQuestionsCount()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Questions";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public static void UpdateUserDuration(int userId, int duration)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Duration = @duration WHERE Id = @userId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetUserHistory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                u.FirstName, 
                u.LastName, 
                u.TestDate, 
                COUNT(CASE WHEN ua.IsCorrect = 1 THEN 1 END) AS CorrectAnswers,
                (SELECT COUNT(*) FROM Questions) AS TotalQuestions,
                u.Duration
            FROM Users u
            LEFT JOIN UserAnswers ua ON u.Id = ua.UserId
            GROUP BY u.Id, u.FirstName, u.LastName, u.TestDate, u.Duration
            ORDER BY u.TestDate DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}