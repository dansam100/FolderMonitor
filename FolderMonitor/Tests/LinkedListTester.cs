using FolderMonitor.FileGymnastics;
using FolderMonitor.Monitees;
using NUnit.Framework;

namespace FolderMonitor.Tests
{
  [TestFixture]
  public class LinkedListTester
  {
    private int length = 5;
    private string text = string.Empty;
    
    [Test]
    public void BuildXMLList()
    {
      XMLDataList.Clear();
      XMLDataList.Load(text);
      int size = XMLDataList.Length;
      Assert.AreEqual(length, size);
      XMLDataListEntry current = XMLDataList.Head;
      while(current != null)
      {
        Assert.IsNotNull(MoniteeList.FindMonitee(current.Data.MoniteePath));
        current = current.Next;
      }
    }

    [Test]
    public void BuildMoniteeList()
    {
      XMLDataList.Clear();
      XMLDataList.Load(text);
      int size = XMLDataList.Length;
      Assert.AreEqual(length, size);
      XMLDataListEntry current = XMLDataList.Head;
      while (current != null)
      {
        Assert.IsNotNull(MoniteeList.FindMonitee(current.Data.MoniteePath));
        current = current.Next;
      }

      MoniteeListEntry current2 = MoniteeList.Head;
      while(current2 != null)
      {
        Assert.IsNotNull(current2.Data.Destinations);
        Assert.IsNotNull(current2.Data.Name);
        Assert.IsNotNull(current2.Data.Type);
        current2 = current2.Next;
      }
    }


    [TestFixtureSetUp]
    public void SetUp()
    {
      string declaration = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";

      string content = declaration + @"<FolderMonitor><Monitee><Source>c:\Program Files</Source><Type>Folder</Type><Destination>c:\newdoc</Destination></Monitee><Monitee><Source>c:\documents and settings\samuel\binreader.cs</Source><Type>Unknown</Type><Destination>c:\newfol</Destination></Monitee><Monitee><Source>C:\Documents and Settings\samuel.martey\Desktop\Junk</Source><Type>Folder</Type><Destination>C:\Documents and Settings\samuel.martey\Desktop\Toworkon</Destination></Monitee><Monitee><Source>C:\Documents and Settings\samuel.martey\Desktop\cc-config.log</Source><Type>File</Type><Destination>C:\Documents and Settings\samuel.martey\Desktop\Toworkon</Destination></Monitee><Monitee><Source>C:\Documents and Settings\samuel.martey\Desktop\cc-config.log</Source><Type>File</Type><Destination>C:\Documents and Settings\samuel.martey\Desktop\Unused Desktop Shortcuts</Destination></Monitee></FolderMonitor>";
      text = content;
      }

    [TestFixtureTearDown]
    public void TearDown()
    {
      text = string.Empty;
    }
  }
}
