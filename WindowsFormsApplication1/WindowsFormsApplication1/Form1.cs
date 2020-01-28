using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        bool alive = false; // будет ли работать поток для приема
        UdpClient client;
        const int LOCALPORT = 8001; // порт для приема сообщений
        const int REMOTEPORT = 8001; // порт для отправки сообщений
        const int TTL = 20;
        const string HOST = "235.5.5.1"; // хост для групповой рассылки
        IPAddress groupAddress; // адрес для групповой рассылки

        string userName; // имя пользователя в чате

        public Form1()
        {
            InitializeComponent();

            btn_LogIn.Enabled = true; // кнопка входа
            btn_LogOut.Enabled = false; // кнопка выхода
            btn_Enter.Enabled = false; // кнопка отправки
            tB_Chat.ReadOnly = true; // поле для сообщений

            groupAddress = IPAddress.Parse(HOST);
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            userName = tB_Username.Text;
            tB_Username.ReadOnly = true;

            try
            {
                client = new UdpClient(LOCALPORT);
                // присоединяемся к групповой рассылке
                client.JoinMulticastGroup(groupAddress, TTL);

                // запускаем задачу на прием сообщений
                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();

                MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=psevdochat");
                conn.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT `DataTime`, `User`, `Text` FROM `messaging` WHERE 1", conn);
                MySqlDataReader reader1 = cmd2.ExecuteReader();
                while (reader1.Read())
                {
                    byte[] data = Encoding.Unicode.GetBytes(reader1[0].ToString());
                    client.Send(data, data.Length, HOST, REMOTEPORT);
                    //tB_Chat.Text = (reader1[0].ToString());
                    reader1.Close();
                }
                conn.Close();
                // отправляем первое сообщение о входе нового пользователя
                string message = userName + " вошел в чат";
                byte[] data1 = Encoding.Unicode.GetBytes(message);
                client.Send(data1, data1.Length, HOST, REMOTEPORT);

                btn_LogIn.Enabled = false;
                btn_LogOut.Enabled = true;
                btn_Enter.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // метод приема сообщений
        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);

                    // добавляем полученное сообщение в текстовое поле
                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToShortTimeString();
                        tB_Chat.Text = time + " " + message + "\r\n" + tB_Chat.Text;
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // обработчик нажатия кнопки sendButton
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("{0}: {1}", userName, tB_Message.Text);
                string time = String.Format("{0}:{1}");
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=psevdochat");
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO `messaging`(`ID`, `DataTime`, `User`, `Text`) VALUES ('','"+time+"','" + userName + "','" + tB_Message.Text + "')", conn);
                cmd1.ExecuteScalar();
                conn.Close();
                tB_Message.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // обработчик нажатия кнопки logoutButton
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            ExitChat();
        }
        // выход из чата
        private void ExitChat()
        {
            string message = userName + " покидает чат";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, REMOTEPORT);
            client.DropMulticastGroup(groupAddress);

            alive = false;
            client.Close();

            btn_LogIn.Enabled = true;
            btn_LogOut.Enabled = false;
            btn_Enter.Enabled = false;
        }
        // обработчик события закрытия формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }
    }
}
