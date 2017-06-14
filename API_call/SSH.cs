using System;
using Renci.SshNet;

namespace API_call
{
    public static class SSH
    {
        public class Connection_Info
        {
            public string Username { get; private set; }
            public string Password { get; private set; }
            public string Address { get; private set; }
            public int Port { get; private set; }
            public Connection_Info(string username, string password, string address, int port)
            {
                Username = username;
                Password = password;
                Address = address;
                Port = port;
            }
        }
        public class Nvidia_Info
        {
            public string Fan_percent;
            public string Temp;
            public string Power_consumtion;
            public string Power_Limit;
            public string Mem_Usage;
            public string Mem_Limit;
            public string GPU_Util;
            public Nvidia_Info(string fan_percent, string temp, string power_cons, string power_lim,
                               string mem_usage, string mem_lim, string gpu_util)
            {
                Fan_percent = fan_percent;
                Temp = temp;
                Power_consumtion = power_cons;
                Power_Limit = power_lim;
                Mem_Usage = mem_usage;
                Mem_Limit = mem_lim;
                GPU_Util = gpu_util;
            }
        }
        public class AMD_Info
        {
            public string Fan_rpm;
            public string Temp;
            public AMD_Info(string fan_rpm, string temp)
            {
                Fan_rpm = fan_rpm;
                Temp = temp;
            }
        }
        public static class SSH_calls
        {
            static string Run_command(Connection_Info connection_info, string command)
            {
                var pass_auth = new PasswordAuthenticationMethod(connection_info.Username, connection_info.Password);
                var con_info = new ConnectionInfo(connection_info.Address, connection_info.Username, pass_auth);
                var ssh = new SshClient(con_info);
                ssh.Connect();
                var com = ssh.CreateCommand(command);
                var result = com.Execute();
                ssh.Disconnect();
                return result;
            }
            public static Nvidia_Info Get_Nvidia_Info(Connection_Info connection_info)
            {
                string str = Run_command(connection_info, "nvidia-smi");
                str = str.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)[8];
                string[] split = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Nvidia_Info nv = new Nvidia_Info(split[1], split[2], split[4], split[6], split[8], split[10],
                                                 split[12]);
                return nv;
            }
            public static string Get_AMD_Info(Connection_Info connection_info) //To Do
            {
                string output = Run_command(connection_info, "sensors");
                return output;
            }
        }
    }
}
