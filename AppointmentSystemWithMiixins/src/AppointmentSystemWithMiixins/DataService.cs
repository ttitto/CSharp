﻿namespace AppointmentSystemWithMiixins
{
    using System;

    public class DataService
    {
        public void RegisterUser(string name, string password)
        {
            Console.WriteLine($"INSERT INTO User (UserName, Password) \n" +
                $"VALUES ('{name}', '{password}') \n");
        }

        public void ChangePassword(string name, string password, string newPassword)
        {
            Console.WriteLine($"UPDATE User SET Password='{newPassword}'" +
                $"WHERE UserName='{name}' AND Password='{password}'");
        }
    }
}