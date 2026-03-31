using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicPlayer
{
    public class DatabaseHelper
    {
        private string connectionString =
            @"Server=.\SQLEXPRESS02;Database=MusicPlayerDB;Trusted_Connection=True;";

        public bool TestConnection()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                return conn.State == System.Data.ConnectionState.Open;
            }
        }

        public List<MusicTrack> GetAllTracks()
        {
            var list = new List<MusicTrack>();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM MusicTracks", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new MusicTrack
                    {
                        Id = (int)reader["Id"],
                        Title = reader["Title"].ToString(),
                        Artist = reader["Artist"].ToString(),
                        Album = reader["Album"].ToString(),
                        Duration = TimeSpan.FromSeconds((int)reader["Duration"]),
                        PlayCount = (int)reader["PlayCount"],
                        DateAdded = (DateTime)reader["DateAdded"]
                    });
                }
            }
            return list;
        }

        public int AddTrack(MusicTrack track, byte[] fileData)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand(@"
                    INSERT INTO MusicTracks
                    (Title, Artist, Album, Duration, FileData)
                    OUTPUT INSERTED.Id
                    VALUES (@t, @a, @al, @d, @f)", conn);

                cmd.Parameters.AddWithValue("@t", track.Title);
                cmd.Parameters.AddWithValue("@a", track.Artist);
                cmd.Parameters.AddWithValue("@al", track.Album);
                cmd.Parameters.AddWithValue("@d", track.Duration.Value.TotalSeconds);
                cmd.Parameters.AddWithValue("@f", fileData);

                return (int)cmd.ExecuteScalar();
            }
        }

        public bool DeleteTrack(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM MusicTracks WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<MusicTrack> Search(string query)
        {
            var list = new List<MusicTrack>();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand(@"
                    SELECT * FROM MusicTracks
                    WHERE Title LIKE @q OR Artist LIKE @q", conn);

                cmd.Parameters.AddWithValue("@q", "%" + query + "%");

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new MusicTrack
                    {
                        Id = (int)reader["Id"],
                        Title = reader["Title"].ToString(),
                        Artist = reader["Artist"].ToString(),
                        Duration = TimeSpan.FromSeconds((int)reader["Duration"]),
                        PlayCount = (int)reader["PlayCount"]
                    });
                }
            }
            return list;
        }

        public void IncrementPlayCount(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand(@"
                    UPDATE MusicTracks
                    SET PlayCount = PlayCount + 1
                    WHERE Id=@id", conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public byte[] GetFileData(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand("SELECT FileData FROM MusicTracks WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                return (byte[])cmd.ExecuteScalar();
            }
        }
    }
}