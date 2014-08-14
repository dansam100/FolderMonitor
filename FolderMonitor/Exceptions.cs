using System.Windows.Forms;

namespace FolderMonitor
{
    class Exceptions
    {
        public static void Exception(params string[] exception)
        {
            switch (exception[0])
            {
                case "srcisdest":
                    MessageBox.Show("Source cannot be the same as destination",
                                                         "Error",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Warning);
                    break;
                case "duplicate":
                    MessageBox.Show("The chosen destination already exists the monitored item.\nSelect another destination!",
                                                         "Error!",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Warning);
                    break;
                case "emptymoniteebox":
                    MessageBox.Show("Select a folder to Monitor first!!",
                                                         "Error!",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Warning);
                    break;
                case "selectmonitee":
                    MessageBox.Show("Please select an item from the list to view destinations for", "Select Item..",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Warning);
                    break;
                case "unselectedremove":
                    MessageBox.Show("Select an item to remove first!", "Warning");
                    break;
                case "cyclicdependency":
                    MessageBox.Show("This addition will create a cylic dependency:\n" +
                                    exception[1] + "Please select a different folder.", "Cyclic Dependency",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default: 
                    break;
            }
        }

    }
}