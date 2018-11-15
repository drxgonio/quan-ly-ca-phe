using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;

using QLYQUANCAFE.Form;
using MongoDB.Bson;
//tham chiếu thư viện này:
using MongoDB.Driver;
namespace QLYQUANCAFE.Connect
{
    class ConnectDB
    {

      
        public void ConectIP(string user,string pass,string ip,string xxx)
        {
            userName = user;
            password = pass;
            hostname = ip;
            QLCF = xxx;
        }

        public static string userName ="";
        public static string password="";
        public static string hostname= "";
        public static string QLCF = "";
        public  bool isCorrect;

        // MongoClient client;//= new MongoClient("mongodb://localhost:27017");;
        // MongoClient client = new MongoClient("mongodb://" + userName + ":" + password + "@" + hostname + ":27017/QuanLyQuanCaPhe");
        //  MongoClient client = new MongoClient("mongodb://admin:123@192.168.0.221/admin");
        //MongoClient client = new MongoClient("mongodb://NhanVien:123@127.0.0.1/QuanLyQuanCaPhe");
       
        public IMongoDatabase database;
        public void Connect()
        {
           

            try
            {
                 MongoClient client = new MongoClient("mongodb://" + userName + ":" + password + "@" +hostname+ ":27017/"+ QLCF + "");
                database = client.GetDatabase("QuanLyQuanCaPhe");
                bool isMongo = database.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);
                if (isMongo)
                { isCorrect= true; }
                else
                {
                    isCorrect = false;
                    
                }
              
              
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới Cơ Sở Dữ Liệu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public void KetNoi(string a)
        {
            if (isCorrect == true)
            {
                try
                {

                                BsonDocument init = new BsonDocument {
                            {"eval",a }
                        };

                    database.RunCommand<BsonDocument>(init);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Không thể kết nối tới Cơ Sở Dữ Liệu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
