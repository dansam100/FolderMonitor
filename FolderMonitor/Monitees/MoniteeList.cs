using System;
using System.Collections.Generic;
using System.Text;

namespace FolderMonitor.Monitees
{
    public static class MoniteeList
    {
        private static MoniteeListEntry head;
        private static MoniteeListEntry tail;
        public static Int32 length = 0;
        public static Boolean AddedExtra = false;

        static MoniteeList()
        {
        }

        internal static MoniteeListEntry Head
        {
            get { return head; }
        }

        /// <summary>
        /// Searches through monitee lists to find monitee with specified name.
        /// </summary>
        /// <param name="moniteeName">the name of monitee to be found</param>
        /// <returns>the monitee</returns>
        public static Monitee FindMonitee(string moniteeName)
        {
            MoniteeListEntry current = Head;
            while (current != null)
            {
                if (current.Data.Name == moniteeName)
                {
                    return current.Data;
                }
                current = current.Next;
            }
            return null;
        }

        /// <summary>
        /// Inserts a monitee to monitor.
        /// </summary>
        /// <param name="monitee">The monitee</param>
        /// <returns></returns>
        internal static bool InsertMonitee(Monitee monitee)
        {
            if (monitee.Name != "" || monitee.Destinations[0] != "")
            {
                MoniteeListEntry mon = new MoniteeListEntry(monitee);

                MoniteeListEntry current = head;
                while (current != null)
                {
                    if (current.Data.Name == monitee.Name)
                    {
                        for (int i = 0; i < current.Data.Index; i++)
                        {
                            if (current.Data.Destinations[i] == monitee.Destinations[0])
                            {
                                return false;
                            }
                        }
                        current.Data.Destinations = monitee.Destinations;
                        AddedExtra = true;
                        Console.WriteLine("added extra destination");
                        return AddedExtra;
                    }
                    current = current.Next;
                }
                Console.WriteLine("adding items");
                if (head == null)
                {
                    head = mon;
                    tail = mon;
                }
                else
                {
                    tail.Next = mon;
                    tail = mon;
                }
                length++;
                return true;
            }
            return false;
        }

        internal static bool RemoveMonitee(string monitee)
        {
            MoniteeListEntry current = head;
            MoniteeListEntry previous = null;

            if (monitee == "")
            {
                return false;
            }

            while (current != null && (current.Data.Name != monitee))
            {
                previous = current;
                current = current.Next;
            }

            if (current == null)
            {
                return false;
            }
            if (current == head)
            {
                head = current.Next;
            }
            else if (current == tail)
            {
                tail = null;
            }
            else
            {
                if (previous != null)
                    previous.Next = current.Next;
            }
            return true;
        }

        internal static bool RemoveDestination(Monitee monitee, string destination)
        {
            MoniteeListEntry current = head;

            if (monitee == null || monitee.Destinations == null || monitee.Destinations.Length == 0)
            {
                return false;
            }
            while (current != null && (current.Data.Name != monitee.Name))
            {
                current = current.Next;
            }

            if (current == null)
            {
                return false;
            }
            current.Data.RemoveDestination(destination);
            return true;
        }
    }
}
