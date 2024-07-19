using FluentFTP;
using System.Net;
using static System.Net.WebRequestMethods;

namespace MyFTP
{
    internal class Program
    {
        //https://filezilla.ru/download/FileZillaPortable_3.63.2.paf.exe
        static string url = "ftp://ftp.dlptest.com/";
        static string user = "dlpuser";
        static string password = "rNrKYTX9g7z3RgJRmxWuGHbeu";

        static void FTP_test()
        {
            FtpClient client = new FtpClient();
            client.Host = url;
            client.Credentials = new NetworkCredential(user, password);
            client.Connect();
            var status = client.UploadFile("123.txt", "/07/19/123kdadkadakdaskdjasklj.txt");
            ;
        }
        static void Main(string[] args)
        {
            FTP_test();
        }
    }
}