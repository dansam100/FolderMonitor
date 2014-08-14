using System;
using System.Collections.Generic;
using System.Text;
using FolderMonitor.Monitees;

namespace FolderMonitor.FileGymnastics
{
    public static partial class XMLDataList
    {
        private static System.Int32 length;
        private static XMLDataListEntry head;
        private static XMLDataListEntry tail;

        private static System.Xml.XmlDocument xmlDoc;
        
        //private System.String srcFileName = "..\\..\\MonitoredFolders.xml";
        private static System.String srcFileName = "MonitoredFolders.xml";
        private const System.String srcBackupName = "MonitoredFolders.bkup";
      private static string fileContent = string.Empty;

        /// <summary>
        /// types of data that can be monitored.
        /// </summary>
        public enum ItemType { File, Folder, Unknown };

      internal static XMLDataListEntry Head
      {
        get { return head; } 
        set{ head = value;}
      }
        

        static XMLDataList()
        {
            length = 0;
        }

        public static int Length
        {
            get { return length; }
        }

        public static void Clear()
        {
            head = null;
            tail = null;
            length = 0;
        }

        public static bool InsertFile(XMLData xmlData)
        {
            Console.WriteLine("Inserting...");
            if (xmlData.DestinationPath == "" || xmlData.MoniteePath == "")
            {
                return false;
            }
            XMLDataListEntry tmp = new XMLDataListEntry(xmlData);
            //XMLDataListEntry current = head;

            /*while (current != null)
            {
                if (tmp.Data.MoniteePath == current.Data.MoniteePath)
                {
                    return false;
                }
                else
                {
                    current = current.Next;
                }
            }*/

            if (head == null)
            {
                head = tmp;
                tail = tmp;
                length = 1;
            }
            else
            {
                tail.Next = tmp;
                tail = tmp;
                length++;
            }
            return true;
        }

        public static bool RemoveFile(String monitee)
        {
            if (monitee == "")
            {
                return false;
            }

            XMLDataListEntry current = head;
            XMLDataListEntry previous = null;

            for( int i = 0; i < MoniteeList.length; i++ )
            {
                while (current != null && (current.Data.MoniteePath != monitee))
                {
                    previous = current;
                    current = current.Next;
                }
                Console.WriteLine("found {0}", i);
                if (current == null)
                {
                    return false;
                }
                else if (current == head)
                {
                    head = current.Next;
                    current = head;
                    length--;
                }
                else if (current == tail)
                {
                    tail = null;
                    length--;
                }
                else
                {
                    previous.Next = current.Next;
                    current = previous;
                    length--;
                }
                Console.WriteLine(length);
            }
            return true;
        }

        public static void RemoveFileDestination(string destination)
        {
            if (destination == "")
            {
                return;
            }

            XMLDataListEntry current = head;
            XMLDataListEntry previous = null;

            while (current != null && (current.Data.DestinationPath != destination))
            {
                previous = current;
                current = current.Next;
            }
            if (current == null || previous == null)
            {
                return;
            }
            else if (current == head)
            {
                head = current.Next;
                current = head;
                length--;
            }
            else if (current == tail)
            {
                tail = null;
                length--;
            }
            else
            {
                previous.Next = current.Next;
                current = previous;
                length--;
            }
            
            Console.WriteLine(length);
            
        }
    }

    /// <summary>
    /// File list.
    /// </summary>
    public class XMLDataListEntry
    {
        private XMLData data;
        private XMLDataListEntry next;

        /// <summary>
        /// list entry class.
        /// </summary>
        /// <param name="xData">item to be stored in list</param>
        public XMLDataListEntry(XMLData xData)
        {
            data = xData;
            next = null;
        }

        public XMLData Data
        {
            get { return data; }
            set { data = value; }
        }

        public XMLDataListEntry Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
