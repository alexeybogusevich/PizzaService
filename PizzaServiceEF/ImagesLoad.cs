using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaServiceEF
{
    public static class ImagesLoad
    {
        public static void SaveFileToDatabase(string filename, string title)
        {
            string connectionString = @"Data Source=IDEA-PC;Initial Catalog=PizzaService;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Images VALUES (@FileName, @Title, @ImageData)";
                command.Parameters.Add("@FileName", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Title", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@ImageData", SqlDbType.Image, 1000000);

                // путь к файлу для загрузки
                //string filename = @"C:\Users\Eugene\Pictures\cats.jpg";
                // заголовок файла
                //string title = "Коты";
                // получаем короткое имя файла для сохранения в бд
                string shortFileName = filename.Substring(filename.LastIndexOf('\\') + 1); // cats.jpg
                                                                                           // массив для хранения бинарных данных файла
                byte[] imageData;
                using (System.IO.FileStream fs = new System.IO.FileStream(filename, FileMode.Open))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                }
                // передаем данные в команду через параметры
                command.Parameters["@FileName"].Value = shortFileName;
                command.Parameters["@Title"].Value = title;
                command.Parameters["@ImageData"].Value = imageData;

                command.ExecuteNonQuery();
            }
        }

        private static List<ImageView> ReadFileFromDatabase(int im_id)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
            List<ImageView> images = new List<ImageView>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //string sql = "SELECT * FROM Images WHERE IMG_id=@id";
                string sql = "SELECT * FROM Images";
                SqlCommand command = new SqlCommand(sql, connection);
                //SqlParameter param = new SqlParameter();
                //param.ParameterName = "@id";
                //param.Value = im_id.ToString();
                //command.Parameters.Add(param);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string filename = reader.GetString(1);
                    string title = reader.GetString(2);
                    byte[] data = (byte[])reader.GetValue(3);

                    ImageView image = new ImageView(id, filename, title, data);
                    images.Add(image);
                }
            }

            return images;
        }
    }
}
