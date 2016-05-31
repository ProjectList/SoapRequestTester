using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SoapTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = address.Text;
            try
            {
                string sa = soapAction.Text;
                string sp = soap.Text;
                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                //webRequest.ServicePoint.Expect100Continue = false;
                webRequest.Method = "POST";
                webRequest.KeepAlive = false;
                webRequest.ContentType = "text/xml; charset=utf-8";
                webRequest.Headers.Add("SOAPAction", "\"" + sa + "\"");
                byte[] paramData = Encoding.UTF8.GetBytes(sp);
                webRequest.ContentLength = paramData.Length;
                 Stream streamWriter = webRequest.GetRequestStream();
                streamWriter.Write(paramData, 0, paramData.Length);
                streamWriter.Close();
                WebResponse webResponse = webRequest.GetResponse();
                StreamReader streamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);
                string xmlResult = streamReader.ReadToEnd();
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlResult);
                resultTextBox.Text = xmlDocument.OuterXml;
                streamReader.Close();
            }
            catch (WebException ex)
            {
                if (ex.Response == null)
                {
                    resultTextBox.Text = ex.Message;
                }
                else
                {
                    Stream responseStream = ex.Response.GetResponseStream();
                    if (responseStream == null) resultTextBox.Text = ex.Message;
                    using (StreamReader responseReader = new StreamReader(responseStream))
                    {
                        resultTextBox.Text = responseReader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                resultTextBox.Text = ex.Message;
            }
        }
    }
}
