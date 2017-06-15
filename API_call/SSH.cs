using System;
using System.Text.RegularExpressions;
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
            public int Fan_percent;
            public int Temp;
            public int Power_consumtion;
            public int Power_Limit;
            public int Mem_Usage;
            public int Mem_Limit;
            public int GPU_Util;
            public Nvidia_Info(int fan_percent, int temp, int power_cons, int power_lim,
                               int mem_usage, int mem_lim, int gpu_util)
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

                string re1 = ".*?"; // Non-greedy match on filler
                string re2 = "(\\d+)";  // Integer Number 1
                string re3 = ".*?"; // Non-greedy match on filler
                string re4 = "(\\d+)";  // Integer Number 2
                string re5 = ".*?"; // Non-greedy match on filler
                string re6 = "\\d+";    // Uninteresting: int
                string re7 = ".*?"; // Non-greedy match on filler
                string re8 = "(\\d+)";  // Integer Number 3
                string re9 = ".*?"; // Non-greedy match on filler
                string re10 = "(\\d+)"; // Integer Number 4
                string re11 = ".*?";    // Non-greedy match on filler
                string re12 = "(\\d+)"; // Integer Number 5
                string re13 = ".*?";    // Non-greedy match on filler
                string re14 = "(\\d+)"; // Integer Number 6
                string re15 = ".*?";    // Non-greedy match on filler
                string re16 = "(\\d+)"; // Integer Number 7

                Regex r = new Regex(re1 + re2 + re3 + re4 + re5 + re6 + re7 + re8 + re9 + re10 + re11 + re12 + re13 + re14 + re15 + re16, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                Match m = r.Match(str);
                int int1 = Convert.ToInt32(m.Groups[1].ToString());
                int int2 = Convert.ToInt32(m.Groups[2].ToString());
                int int3 = Convert.ToInt32(m.Groups[3].ToString());
                int int4 = Convert.ToInt32(m.Groups[4].ToString());
                int int5 = Convert.ToInt32(m.Groups[5].ToString());
                int int6 = Convert.ToInt32(m.Groups[6].ToString());
                int int7 = Convert.ToInt32(m.Groups[7].ToString());
                Nvidia_Info nv = new Nvidia_Info(int1, int2, int3, int4, int5, int6, int7);
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
