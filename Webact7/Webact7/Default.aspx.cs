using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webact7
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                mathTrivia();
            }
        }
        protected void UpdatePanel1_Load(object sender, EventArgs e)
        {
            thisday();
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            thisday();
        }
        void thisday()
        {
            try
            {
                HttpWebRequest serviceRequest = (HttpWebRequest)WebRequest.Create("https://numbersapi.p.mashape.com/3/1/date?fragment=true&json=true");
                serviceRequest.Method = "GET";
                serviceRequest.ContentLength = 0;
                serviceRequest.ContentType = "text/plain; charset=utf-8";
                serviceRequest.Accept = "text/plain";
                serviceRequest.Headers.Add("X-Mashape-Key", "WpWNTQDtlSmshAjiVtLymV1curwkp12GEdTjsn6XcyIMBQT6g6");
                HttpWebResponse serviceResponse = (HttpWebResponse)serviceRequest.GetResponse();
                Stream receiveStream = serviceResponse.GetResponseStream();
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader readStream = new StreamReader(receiveStream, encode, true);
                string responseFromServer = readStream.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                var obj = js.Deserialize<dynamic>(responseFromServer);
                year1.Text = obj["year"].ToString();
                text1.Text = obj["text"];
            }
            catch(Exception)
            {
                year1.Text = "reload the page again";
            }
        }
        void mathTrivia()
        {
            HttpWebRequest serviceRequest = (HttpWebRequest)WebRequest.Create("https://numbersapi.p.mashape.com/1234/trivia?fragment=true&json=true&max=20&min=10");
            serviceRequest.Method = "GET";
            serviceRequest.ContentLength = 0;
            serviceRequest.ContentType = "text/plain; charset=utf-8";
            serviceRequest.Accept = "text/plain";
            serviceRequest.Headers.Add("X-Mashape-Key", "WpWNTQDtlSmshAjiVtLymV1curwkp12GEdTjsn6XcyIMBQT6g6");
            HttpWebResponse serviceResponse = (HttpWebResponse)serviceRequest.GetResponse();
            Stream receiveStream = serviceResponse.GetResponseStream();
            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader readStream = new StreamReader(receiveStream, encode, true);
            string responseFromServer = readStream.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            var obj = js.Deserialize<dynamic>(responseFromServer);
            trivia_canswer.Text = obj["number"].ToString();
            trivia_question.Text = obj["text"];
        }

        protected void trivia_submit_Click(object sender, EventArgs e)
        {
            if (trivia_answer.Text == trivia_canswer.Text)
                trivia_checkanswer.Text = "You answer is correct!";
            else
            {
                trivia_checkanswer.Text = "Oops! You answer is incorrect :0(  Correct answer is: " + trivia_canswer.Text;
                trivia_submit.Enabled = false;
            }
        }

        protected void sentiment_submit_Click(object sender, EventArgs e)
        {
            var postData = "txt=" + sentiment_text.Text.ToString();
            postData += "&thing2=world";
            var data = Encoding.ASCII.GetBytes(postData);
            HttpWebRequest serviceRequest = (HttpWebRequest)WebRequest.Create("https://community-sentiment.p.mashape.com/text/");
            serviceRequest.Method = "POST";
            serviceRequest.Headers.Add("X-Mashape-Key", "WpWNTQDtlSmshAjiVtLymV1curwkp12GEdTjsn6XcyIMBQT6g6");
            serviceRequest.ContentType = "application/x-www-form-urlencoded";
            serviceRequest.Accept = "application/json";
            using (var stream = serviceRequest.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            HttpWebResponse serviceResponse = (HttpWebResponse)serviceRequest.GetResponse();
            Stream receiveStream = serviceResponse.GetResponseStream();
            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader readStream = new StreamReader(receiveStream, encode, true);
            string responseFromServer = readStream.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            var obj = js.Deserialize<dynamic>(responseFromServer);
            sentiment_answer.Text = "Confidence level: " +
                                 obj["result"]["confidence"].ToString() +
                                 " and sentiment is " +
                                 obj["result"]["sentiment"].ToString();
        }

        protected void convert_submit_Click(object sender, EventArgs e)
        {
            HttpWebRequest serviceRequest = (HttpWebRequest)WebRequest.Create("https://currency-exchange.p.mashape.com/exchange?from=" + convert_from.Text.Trim() + "&q=1.0&to=" + convert_to.Text.Trim());
            serviceRequest.Method = "GET";
            serviceRequest.Headers.Add("X-Mashape-Key", "WpWNTQDtlSmshAjiVtLymV1curwkp12GEdTjsn6XcyIMBQT6g6");
            serviceRequest.Accept = "text/plain";
            HttpWebResponse serviceResponse = (HttpWebResponse)serviceRequest.GetResponse();
            Stream receiveStream = serviceResponse.GetResponseStream();
            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader readStream = new StreamReader(receiveStream, encode, true);
            var responseFromServer = readStream.ReadToEnd();
            convert_rate.Text = responseFromServer;
        }
    }

    }