namespace FolderMonitor.Monitees
{
    internal class MoniteeListEntry
    {
        public MoniteeListEntry(Monitee monitee)
        {
            this.Data = monitee;
            Next = null;
        }

        internal Monitee Data { get; set; }
        internal MoniteeListEntry Next { get; set; }
    }
}
