
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FolderMonitor.Monitees;

namespace FolderMonitor.FileGymnastics
{
    public static partial class XMLDataList
    {

        static System.Xml.XmlDocument xDoc = null;
        
      internal static void Load(string content)
      {
        fileContent = content;
        LoadAllMonitees();
      }

        internal static void LoadAllMonitees()
        {
            try
            {
                try
                {
                    Console.WriteLine("Loading Monitees...");
                    xmlDoc = new System.Xml.XmlDocument();
                    if (File.Exists(srcFileName))
                    {
                        xmlDoc.Load(srcFileName);
                    }
                    else if(File.Exists(srcBackupName))
                    {
                        xmlDoc.Load(srcBackupName);
                    }
                    else
                    {
                      //do something.
                    }
                  if(!string.IsNullOrEmpty(fileContent))
                    xmlDoc.LoadXml(fileContent);

                    System.Xml.XmlNodeList nodes = xmlDoc.GetElementsByTagName("Monitee");

                    for (int i = 0; i < nodes.Count; i++)
                    {

                        string folder = nodes[i].FirstChild.InnerText;
                        ItemType type = Type(nodes[i].FirstChild.InnerText);
                        string destination = nodes[i].LastChild.InnerText;

                        Console.WriteLine("Going through the loops..");
                        if (folder != null || destination != null)
                        {
                            XMLData xmlData = new XMLData(folder, destination, type);

                            Console.WriteLine(String.Format("{0};{1};{2}",
                                                            xmlData.MoniteePath,
                                                            xmlData.DestinationPath,
                                                            xmlData.Type));

                            InsertFile(xmlData);
                        }
                    }

                    Console.WriteLine("done exporting");
                    
                }
                catch (System.IO.FileNotFoundException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            catch(Exception e)
            {
                //error
            }
            ImportItems();
        }

        /// <summary>
        /// imports monitored items and stores them in arraylist
        /// for program to insert into list view.
        /// </summary>
        internal static void ImportItems()
        {
            XMLDataListEntry current = head;

            while (current != null)
            {
                Console.WriteLine("exporting");
                Monitee monitee = new Monitee(current.Data);
                MoniteeList.InsertMonitee(monitee);
                current = current.Next;
            }
        }


        internal static void BackUpData()
        {
           
            CreateFileBackup();
            CreateXMLFile();
            MonitorListView.HasChanged = false;
        }


        private static void CreateFileBackup()
        {
            if(System.IO.File.Exists( srcFileName ) )
            {
                FileInfo fileHandle = new FileInfo(srcFileName);
                fileHandle.CopyTo(srcBackupName, true);
            }
        }

        internal static void CreateXMLFile()
        {
            xDoc = new System.Xml.XmlDocument();

            xDoc.AppendChild(xDoc.CreateXmlDeclaration("1.0", "UTF-8", null));
            System.Xml.XmlElement root = xDoc.CreateElement("FolderMonitor");
            Console.WriteLine("creating file");
            try
            {
                XMLDataListEntry current = head;
                while (current != null)
                {
                    root.AppendChild(CreateXMLNodes(current.Data));
                    current = current.Next;
                }
                xDoc.AppendChild(root);
                xDoc.Save(srcFileName);
            }
            catch(System.Exception e )
            {
                System.Console.WriteLine(e.ToString());
            }
        }

        internal static System.Xml.XmlNode CreateXMLNodes( XMLData data )
        {
            System.Xml.XmlNode xNode = xDoc.CreateNode(System.Xml.XmlNodeType.Element,
                                            "Monitee", null);

            System.Xml.XmlElement name = xDoc.CreateElement("Source");
            System.Xml.XmlElement type = xDoc.CreateElement("Type");
            System.Xml.XmlElement destPath = xDoc.CreateElement("Destination");
            name.InnerText = data.MoniteePath;
            type.InnerText = data.Type.ToString();
            destPath.InnerText = data.DestinationPath;

            xNode.AppendChild(name);
            xNode.AppendChild(type);
            xNode.AppendChild(destPath);

            return xNode;
        }

        internal static void DumpAll()
        {
            try{
                StreamWriter sWriter = new StreamWriter("monitoredfolder.dump");
                for(XMLDataListEntry current = head; current != null; current = current.Next)
                {
                    sWriter.WriteLine(
                        String.Format("{0},{1},{2}",current.Data.MoniteePath,
                                                    current.Data.DestinationPath,
                                                    current.Data.Type));
                }
                sWriter.Close();
            }
            catch
            {
                //handle dump failure here.
            }
        }

        /// <summary>
        /// Checks if a specific path is an existing folder name.
        /// </summary>
        /// <param name="path">path to be checked</param>
        /// <returns>The type of the item.
        ///             File: if path points to a file
        ///             Folder: if path points to a directory
        ///             Unknown: if path cannot be resolved.
        /// </returns>
        public static ItemType Type(String path)
        {
            path = _AddExtraSlash(path);
            
            try
            {
                if (System.IO.File.Exists(path))
                {
                    return ItemType.File;
                }
                else if (System.IO.Directory.Exists(path))
                {
                    return ItemType.Folder;
                }
                else
                {
                    return ItemType.Unknown;
                }
            }
            catch
            {
                return ItemType.Unknown;
            }
        }

        /// <summary>
        /// adds extra slash to full pathnames to make stuff easier.
        /// </summary>
        /// <param name="path">path to be editted.</param>
        /// <returns>the editted full pathname</returns>
        private static String _AddExtraSlash(IEnumerable<char> path)
        {
            string result = "";
            foreach (char c in path)
            {
                if (c == '\\') { result += "\\\\"; }
                else { result += c; }
            }
            return result;
        }
    }

    
}