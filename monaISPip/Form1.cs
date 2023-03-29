using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;


namespace monaISPip {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,int Msg,int wParam,int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender,System.Windows.Forms.MouseEventArgs e) {
            if(e.Button==MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle,WM_NCLBUTTONDOWN,HT_CAPTION,0);
            }
        }

        private void Form1_Load(object sender,EventArgs e) {
            BackColor=Color.Lime;
            TransparencyKey=Color.Lime;
            this.Icon=Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            timer1_Tick(sender,e); 
            this.TopMost=true;
            this.Show();
        }

        private void Form1_MouseClick(object sender,MouseEventArgs e) {

        }

        private async void timer1_Tick(object sender,EventArgs e) {
            try {

                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("http://ip-api.com/json/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                dynamic api_data_js = JsonConvert.DeserializeObject(responseBody);

                curip.Text=api_data_js.query;
                curreg.Text=api_data_js.city+", "+api_data_js.country;
                curisp.Text=api_data_js["as"] +" ("+ api_data_js.isp +")";

            } catch (Exception err){
                return;
            }
        }
    }
}
