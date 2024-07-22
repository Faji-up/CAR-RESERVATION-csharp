using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
namespace CarReservationSystem
{
    class Database
    {
       private MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=CarReservation");

        public MySqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }

        public void openConnection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }




        public bool addNewUser(string username, string password)
        {
      
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`username`, `password`, `user_ref`) VALUES (@username,@password,@user_ref)", getConnection);

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@user_ref", MySqlDbType.VarChar).Value = generateRef();


            openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return true;

            }
            else
            {
                closeConnection();
                return false;
            }
        }

        public static string generateRef()
        {
            string code = "";
            string chars = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";
            Random random = new Random();
            for (int i = 0; i < 40; i++)
            {
                code += chars[random.Next(0, chars.Length - 1)];
            }



            return code;
        }
        public List<User> getUsers(string commandText)
        {
            Database db = new Database();
            List<User> users = new List<User>();
            // "SELECT username,password,user_ref FROM `users`"
            MySqlCommand command = new MySqlCommand(commandText, getConnection);
            openConnection();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int _id = reader.GetInt32("id");
                    string username = reader.GetString("username");
                    string password = reader.GetString("password");
                    string user_ref = reader.GetString("user_ref");

                    User user = new User();
                    user.Id = _id;
                    user.Username = username;
                    user.Password = password;
                    user.User_ref = user_ref;

                    users.Add(user);

                }

            }
           closeConnection();
            return users;
        }





        public bool addNewCar(string car_name, int price, string description, MemoryStream image)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `cars`(`car_name`, `price`, `description`, `image`) VALUES (@car_name,@price,@description,@image)", getConnection);

            command.Parameters.Add("@car_name", MySqlDbType.VarChar).Value = car_name;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
            command.Parameters.Add("@image", MySqlDbType.Blob).Value = image.ToArray();

            openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return true;

            }
            else
            {
                closeConnection();
                return false;
            }

        }

        public List<Car> getCars(string commandText) {


            Database db = new Database();
            List<Car> cars = new List<Car>();
            // "SELECT username,password,user_ref FROM `users`"
            MySqlCommand command = new MySqlCommand(commandText, getConnection);
            openConnection();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int _id = reader.GetInt32("id");
                    string carName = reader.GetString("car_name");
                    string price = reader.GetString("price");
                    string description = reader.GetString("description");   
                    byte[] image = (byte[])reader["image"];
                    Car car = new Car();
                    car.Id = _id;
                    car.CarName = carName;
                    car.Price = price;
                    car.Description = description;
                    car.Image = image;

                    cars.Add(car);

                }

            }
            closeConnection();
            return cars;

        }

    }
    }
