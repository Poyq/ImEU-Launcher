using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Message;



namespace ImEU_Injector
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            Initialize();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public DiscordRpcClient client;



        void Initialize()
        {
            client = new DiscordRpcClient("811681540848615535");

            client.Initialize();



            client.SetPresence(new RichPresence()
            {
                Details = "",
                State = "Not Cheating ;)",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {

                    LargeImageKey = "imeu",
                    LargeImageText = "ImEU Client OP",
                    SmallImageKey = "image_small"
                }
            }); ;
        }

       
        private void discordBtn_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void githubBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void injectBtn_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();

            Client.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/784772364936020020/811372616220409876/ClientBase.dll"), "ClientBase.dll");

            Memory.applyAppPackages("ClientBase.dll");

            Memory.InjectDLL(Directory.GetCurrentDirectory().ToString() + "/ClientBase.dll");

            MessageBox.Show("Injected Start Hacking ;)");
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void atomLabel_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = "abc---def";
            //
            Console.WriteLine("Index: 012345678");
            Console.WriteLine("1)     {0}", s);
            Console.WriteLine("2)     {0}", s.Remove(3));
            Console.WriteLine("3)     {0}", s.Remove(3, 3));
            DialogResult dr = MessageBox.Show("Do you want to clear the strings", "ImEU Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Strings Cleared");
            }
            else
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://client.imeu.gq/");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/QbUnDbHwZU");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Owner - Owas\nDevs - Jack - Ferret");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            client.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }
