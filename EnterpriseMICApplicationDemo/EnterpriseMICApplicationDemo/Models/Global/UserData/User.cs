using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using EnterpriseMICApplicationDemo.Models.Global.Infrastructure;

namespace EnterpriseMICApplicationDemo.Models.Global.UserData
{
    /// <summary>
    /// Application User class
    /// </summary>
    public class User : Member
    {
        /// <summary>
        /// User Attributes
        /// </summary>
        public string Login;
        public string Password;

        /// <summary>
        /// User Functions
        /// </summary>
        public bool[] Functions;

        /// <summary>
        /// User Level
        /// </summary>
        protected Permissions.Level userLevel;

        public User() { }

        private string getValue(string filepath, int index)
        {
            string[] lines = null;
            Log.HandleExpception(
                Log.Try(() =>
                {
                    lines = File.ReadAllLines(@filepath, System.Text.Encoding.Default);
                }));
            if (index >= lines.Length)
            {
                return null;
            }
            return lines[index];
        }

        private void getUserByIndex(int index)
        {
            Id = index;             
            string[] lines = null;
            Log.HandleExpception(
                Log.Try(() =>
                {
                    lines = File.ReadAllLines("password.txt", System.Text.Encoding.Default);
                })
            );
            if (index >= lines.Length)
            {
                return;
            }
            Login = Password = lines[index];
        }
    }

}
