using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarmaraKargo.Models;

namespace MarmaraKargo
{
    public class Context
    {
        private static ModelMarmara conn;
        public static ModelMarmara Conn
        {
            get
            {
                if (conn == null)
                    conn = new ModelMarmara();
                return conn;
            }
            set { conn = value; }
        }

        private static int userID = 0;
        public static int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private static int userType = 0;
        public static int UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        private static string name = "";
        public static string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static float CalculatePrice(float weight)
        {
            float price;
            if (weight < 1000)
            {
                price = 5;
            }
            else if (weight >= 1000 && weight < 10000)
            {
                price = (weight / 1000) * 5;
            }
            else if (weight >= 10000 )
            {
                price = (weight / 1000) * 7;
            }
            else
            {
                price = 0;
            }

            return price;
        }
    }
}
