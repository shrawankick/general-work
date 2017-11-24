using BookManager.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BookManager.Storage
{
    public class Xml
    {
        public List<User> Xmluser { get; set; }
        public List<Book> Xmlbooks { get; set; }
        public Xml()
        {
            Xmluser = new List<User>();
            string Xid = "";
            string Xname = "";
            string xmlData =
                           @"<?xml version='1.0' encoding='UTF-8'?>
                            <dataset>
                                <record>
                                <name >Samuel</name >
                                <id>368-49-7037</id>
                                </record>
                                <record>
                                 <name >shrawan</name >
                                <id>368-43-7037</id>
                                </record>
                            </dataset>
                            ";
            XmlDocument myXmlDocument = new XmlDocument();
            myXmlDocument.LoadXml(xmlData);
            XmlNodeList list = myXmlDocument.SelectNodes("/dataset/record");
            //myXmlDocument.GetElementsByTagName(Xname)add
            foreach (XmlNode stats in list)
            {

                Xid = stats["id"].InnerText;
                Xname = stats["name"].InnerText;
                User user = new User(Xid, Xname);
                Xmluser.Add(user);
            }



            ///xml books 

            Xmlbooks = new List<Book>();
            string Xtitle = "";
            string Xauthor = "";
            string Xisbn = "";
            string xmlBookData =
                @"<?xml version='1.0' encoding='UTF-8'?>
                                <dataset>
                                  <record>
                                    <Title>Keylex</Title>
                                    <Author>Deborah Fuller</Author>
                                    <Isbn>521-71-8342</Isbn>
                                  </record>
                                  <record>
                                    <Title>Home Ing</Title>
                                    <Author>Richard Jacobs</Author>
                                    <Isbn>140-84-8050</Isbn>
                                  </record>
                                </dataset>
                                ";
            XmlDocument myXmlBookDocument = new XmlDocument();
            myXmlDocument.LoadXml(xmlBookData);
            XmlNodeList listofbooks = myXmlDocument.SelectNodes("/dataset/record");
            foreach (XmlNode stats in listofbooks)
            {
                Xtitle = stats["Title"].InnerText;
                Xauthor = stats["Author"].InnerText;
                Xisbn = stats["Isbn"].InnerText;
                Book xbook = new Book(Xtitle,Xauthor, Xisbn);
                Xmlbooks.Add(xbook);
                {

                }
                //Xmluser = new User(Xid, Xname);

            }
        }
    }
}
