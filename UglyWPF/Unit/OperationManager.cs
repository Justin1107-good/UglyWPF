using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UglyWPF.Unit
{
    public class OperationManager
    {
        /// <summary>
     /// 获取用户操作返回结果
     /// </summary>
     /// <param name="eventString">操作事件</param>
     /// <param name="content">操作内容</param>
     /// <returns></returns>
        public static string GetUserStatusTxt(string eventString, string content)
        {
            return $"{eventString}  {content} Operation {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} Record IP：{GetSocketIp()}";
        }
        public static string GetSocketIp()
        {
            string ipsTR = string.Empty;
            string hostName = Dns.GetHostName();
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);

            // 获取第一个IPv4地址
            IPAddress ipv4Address = hostEntry.AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

            if (ipv4Address != null)
            {
                ipsTR = $"IPv4 Address: {ipv4Address}";
            }
            else
            {
                ipsTR = "not found IPv4 .";

            }
            return ipsTR;
        }
    }
}
