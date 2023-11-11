using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Security;
using System.Security.Permissions;
using System.Security.AccessControl;
using System.Security.Principal;

namespace SystemProgFileManager
{
    public partial class Form1 : Form
    {
        string selectedPath1, selectedPath2;

        string[] directories;
        public Form1()
        {
            
            InitializeComponent();
           
        }

        
        
       
        

        private void btnCopy_Click(object sender, EventArgs e)
        {
            TreeNode selectedDirEntry = fileTreeView.SelectedNode;
            if (selectedDirEntry == null)
                MessageBox.Show("No directory entry selected, Please select a directory entry to copy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                selectedPath1 = Path.GetFullPath(selectedDirEntry.FullPath);
                copyTxtBox.Text = selectedPath1;
                copyPanel.Visible = true;
                menuPanel.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            selectedPath1 = "";
            selectedPath2 = "";
            menuPanel.Visible = true;
            copyPanel.Visible = false;
            infoPanel.Visible = false;
            movePanel.Visible = false;
        }

        private void fileTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            fileTreeView.SelectedNode = e.Node;
            try
            {
                if (File.GetAttributes(Path.Combine(e.Node.FullPath, e.Node.Name)).HasFlag(FileAttributes.Directory))
                {
                    selectedPath2 = Path.GetFullPath(e.Node.FullPath);
                }
                else
                {
                    selectedPath2 = Path.GetFullPath(e.Node.FullPath.Substring(0, e.Node.FullPath.LastIndexOf(@"\")));
                }

                
            }
            catch 
            {
                selectedPath2 = Path.GetFullPath(e.Node.FullPath.Substring(0, e.Node.FullPath.LastIndexOf(@"\")));
            }

            if (copyPanel.Visible == true)
            {
                copyDestTxtBox.Text = selectedPath2;
            }
            if (movePanel.Visible == true)
            {
                moveDestTxtBox.Text = selectedPath2;
            }
        }

        private void btnConfirmCopy_Click(object sender, EventArgs e)
        {
            Thread copyThread = new Thread(() => fileTreeView.CopyFiles(selectedPath1, selectedPath2));
            copyThread.Start();
            copyPanel.Visible = false;
            menuPanel.Visible = true;
            fileTreeView.CollapseAll();
        }

        

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TreeNode deadNode = fileTreeView.SelectedNode;
            if(deadNode == null)
                MessageBox.Show("No directory entry selected, Please select a directory entry to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("Are you sure you want to delete selected file(s)?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Thread deleteDirEntry = new Thread(() => fileTreeView.Delete(Path.GetFullPath(deadNode.FullPath)));
                    fileTreeView.CollapseAll();
                    deleteDirEntry.Start();
                }
                
            }
        }

        

        private void btnMove_Click(object sender, EventArgs e)
        {
            TreeNode selectedDirEntry = fileTreeView.SelectedNode;
            if (selectedDirEntry == null)
                MessageBox.Show("No directory entry selected, Please select a directory entry to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                selectedPath1 = Path.GetFullPath(selectedDirEntry.FullPath);
                moveTxtBox.Text = selectedPath1;
                movePanel.Visible = true;
                menuPanel.Visible = false;
            }
        }

        private void btnConfirmMove_Click(object sender, EventArgs e)
        {
            Thread moveThread = new Thread(() => fileTreeView.MoveFiles(selectedPath1, selectedPath2));
            moveThread.Start();
            movePanel.Visible = false;
            menuPanel.Visible = true;
            fileTreeView.SelectedNode.Collapse();
        }

        private void fileTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            menuPanel.Visible = false;
            copyPanel.Visible = false;
            movePanel.Visible = false;
            infoPanel.Visible = true;

            TreeNode selectedNode = fileTreeView.SelectedNode;
            string selectedNodePath = Path.GetFullPath(selectedNode.FullPath);

            infoLabelName.Text = selectedNode.Name;
            infoTextBoxPath.Text = selectedNodePath;
            try
            {

                if (File.GetAttributes(selectedNodePath).HasFlag(FileAttributes.Directory))
                {
                    inforLabelPerm.Text = "Permissions: ";
                    DirectoryInfo dInfo = new DirectoryInfo(selectedNodePath);
                    DirectorySecurity dSecurity = dInfo.GetAccessControl();


                    infoLabelSize.Text = $"Size: {DirSize(dInfo)} Bytes";
                    var accessRules = dSecurity.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
                    inforLabelPerm.Text += accessRules != null ? "\n\tReadable" : "\n\tNot Readable";



                }
                else
                {
                    inforLabelPerm.Text = "Permissions: ";
                    infoLabelSize.Text = "Size: " + new FileInfo(selectedNodePath).Length.ToString() + " Bytes";
                    using (var fs = new FileStream(selectedNodePath, FileMode.Open))
                    {
                        inforLabelPerm.Text += fs.CanRead ? "\n\tReadable" : "\n\tNot Readable";
                        inforLabelPerm.Text += fs.CanWrite ? "\n\tWritable" : "\n\tNot Writable";
                    }
                }
            }
            catch(UnauthorizedAccessException ex)
            {
                inforLabelPerm.Text = "Permissions:\n\t Not Readable\n\t Not Writable";
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An exception has occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }

        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            string folderName = folderNameTextBox.Text == "" ?  "New Folder" : folderNameTextBox.Text;
            try
            {
                fileTreeView.SelectedNode.Collapse();
                Directory.CreateDirectory(Path.Combine(selectedPath2, folderName));
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An exception has occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileTreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Nodes.Clear();
            fileTreeView.AddNodes(e.Node.FullPath, e.Node);
        }


    }

}
