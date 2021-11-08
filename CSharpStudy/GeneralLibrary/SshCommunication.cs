using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary
{
    public class SshCommunication
    {
        /// <summary>
        /// Ssh server IP.
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// Ssh server user name.
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Ssh server password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Ssh port.
        /// </summary>
        public const int Port = 22;

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        public SshCommunication(IPAddress ip, string user, string password)
        {
            Ip = ip.MapToIPv4().ToString();
            User = user;
            Password = password;
        }

        /// <summary>
        /// Connect to a remote device using ssh connection and execute a command in this device. Returns the device response.
        /// </summary>
        /// <param name="command"> The command to be executed.</param>        
        /// <param name="timeout"> Timeout to cancel the command execution.</param>    
        /// <param name="cmdReturn"> The device return.</param>        
        private bool ExecuteCommand(string command, int timeout, out string cmdReturn)
        {
            bool control = false;
            cmdReturn = "";
            try
            {
                using (var ssh = new SshClient(Ip, Port, User, Password))
                {
                    ssh.Connect();

                    using (var cmd = ssh.CreateCommand(command))
                    {
                        // Define timeout for the command execution.
                        cmd.CommandTimeout = TimeSpan.FromSeconds(timeout);

                        cmdReturn = cmd.Execute(command);
                    }
                    ssh.Disconnect();
                    control = true;
                }
            }
            catch (Exception ex)
            {
                control = false;
            }
            return control;
        }
    }
}
