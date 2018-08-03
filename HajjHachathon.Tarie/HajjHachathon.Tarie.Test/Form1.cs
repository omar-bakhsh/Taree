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
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HajjHachathon.Tarie.Test
{
    public partial class Emergency : Form
    {
        public Emergency()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            New();
            ////while (true)
            //{
            //    while (true) { 
            //    DateTime date = DateTime.Now;
            //    var day = date.ToShortDateString();
            //    var time = date.ToLongTimeString();
            //    var json = JsonConvert.SerializeObject(new
            //    {

            //    }
            //        );
            //    PushJson(json);
            //    }
            //}
        }

        private void PullJson(string IMEI)
        {
            var request = WebRequest.CreateHttp(string.Format("https://tarie-c7a5d.firebaseio.com/Cases/{0}.json", IMEI));
            request.Method ="Get";
            //request.ContentType ="application/json";
            //request.GetRequestStream();
            var response = request.GetResponse();
            var Object = (new StreamReader(response.GetResponseStream())).ReadToEnd();
            Fill(Object);
        }

        private void Fill(string json)
        {
            JObject jObject = JObject.Parse(json);
            TxtLong.Text = (string)jObject["Long"];
            TxtLat.Text = (string)jObject["Lat"];
            TxtPicturePath.Text = (string)jObject["Path"];
            IsEmergency.Checked = (bool)jObject["Emergency"];
            IsConfirmed.Checked = (bool)jObject["Confirmed"];
            IsCaseAssigned.Checked = (bool)jObject["PickedUp"];
            WillRetrieve.Checked = false;
        }

        private void PatchJson(string IMEI,string Object)
        {
            var request = WebRequest.CreateHttp(string.Format("https://tarie-c7a5d.firebaseio.com/Cases/{0}.json",IMEI));
            request.Method = "PATCH";
            request.ContentType = "application/json";
            var buffer = Encoding.UTF8.GetBytes(Object);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            var response = request.GetResponse();
            Object = (new StreamReader(response.GetResponseStream())).ReadToEnd();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void New()
        {
            Random rnd = new Random();
            TxtId.Text = String.Format("IMEI-{0}", rnd.Next(1000000, 2999999));
            TxtLat.Text = TxtLong.Text = TxtPicturePath.Text = String.Empty;
            IsCaseAssigned.Checked = IsConfirmed.Checked = IsEmergency.Checked = false;
        }

        private void Sync()
        {
            var json = JsonConvert.SerializeObject(new
            {
                IMEI=TxtId.Text,
                Long = TxtLong.Text,
                Lat = TxtLat.Text,
                Emergency = IsEmergency.Checked,
                Confirmed = IsConfirmed.Checked,
                PickedUp = IsCaseAssigned.Checked,
                Path=TxtPicturePath.Text
            });
            PatchJson(TxtId.Text,json);
        }

        private void IsConfirmed_CheckedChanged(object sender, EventArgs e)
        {
            Sync();
        }

        private void IsCaseAssigned_CheckedChanged(object sender, EventArgs e)
        {
            Sync();
        }

        private void TxtPicturePath_Leave(object sender, EventArgs e)
        {
            Sync();
        }

        private void TxtLong_Leave(object sender, EventArgs e)
        {
            Sync();
        }

        private void TxtLat_Leave(object sender, EventArgs e)
        {
            Sync();
        }

        private void IsEmergency_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TxtId.Enabled = WillRetrieve.Checked;
            if(WillRetrieve.Checked)TxtId.Text = String.Empty;
        }

        private void TxtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) && TxtId.Text.Length > 0)
            {
                PullJson(TxtId.Text);
            }
        }
    }
}
