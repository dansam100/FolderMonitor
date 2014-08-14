using System;
using System.Collections.Generic;
using System.Text;

namespace FolderMonitor.FileGymnastics
{

    public class XMLData
    {
        System.String moniteePath,
                      DestPath     = System.String.Empty;
        XMLDataList.ItemType type = XMLDataList.ItemType.Unknown;

        public XMLData(System.String src,
                        System.String dest, XMLDataList.ItemType type)
        {
            this.moniteePath = src;
            this.DestPath = dest;
            this.type = type;
        }

        public System.String MoniteePath
        {
            get { return moniteePath; }
            set { moniteePath = value; }
        }

        public System.String DestinationPath
        {
            get { return DestPath; }
            set { DestPath = value; }
        }

        public XMLDataList.ItemType Type
        {
            get { return type; }
            set { type = value; }
        }

    }
    
}
