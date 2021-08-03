using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace WindowsFormsAppLab1
{
    public partial class HesapForm : Form
    {
        public HesapForm(ManagementForm form)
        {
            InitializeComponent();
            hesapadlabel.Text = form.adLabel.Text;

            //this.elementHost1.Child =

        }

        private void HesapForm_Load(object sender, EventArgs e)
        {
            

        }

        private void xmlbutton_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Users\Muge Selen\source\repos\WindowsFormsAppLab1\WindowsFormsAppLab1\aidatXML.xml");
            xmltextBox.Text = System.Xml.Linq.XDocument.Parse(document.InnerXml).ToString();
        }
        /*private string FormatText(XmlNode node, string text, string indent)
        {
            if(node is XmlText)
            {
                text += node.Value;
                return text;
            }
            if (string.IsNullOrEmpty(indent))
                indent = "";
            else
            {
                text += "\r\n" + indent;
            }
            if(node is XmlComment)
            {
                text += node.OuterXml;
                return text;
            }
            text += "<" + node.Name;
            if(node.Attributes.Count > 0)
            {
                AddAttributes(node, ref text);
            }
            if (node.HasChildNodes)
            {
                text += ">";
                foreach (XmlNode child in node.ChildNodes)
                {
                    text = FormatText(child, text, indent + "");
                }
                if (node.ChildNodes.Count == 1 && (node.FirstChild is XmlText
                    || node.FirstChild is XmlComment))
                    text += "</" + node.Name + ">";
                else
                    text += "\r\n" + indent + "</" + node.Name + ">";

            }
            else
                text += "/>";
            return text;
        }

        private void AddAttributes(XmlNode node, ref string text)
        {
            foreach(XmlAttribute xa in node.Attributes)
            {
                text += " " + xa.Name + "='" + xa.Value + "'";
            }
        
        }
        */
    }
}
