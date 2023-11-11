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

namespace SystemProgFileManager
{
    public partial class Form1 : Form
    {
        string selectedPath1, selectedPath2;

        string[] directories;
        public Form1()
        {
            InitializeComponent();
            GetDrives();
        }

        
        private void GetDrives()
        {
            TreeNode rootNode;
            foreach (var drive in Environment.GetLogicalDrives())
            {
                rootNode = new TreeNode(drive);
                dirTree.Nodes.Add(rootNode);
                AddNodes(drive, rootNode);
            }
        }
        
       
        private async Task AddNodes(string directoryPath, TreeNode parentNode)
        {
            try
            {
                var directories = Directory.GetDirectories(directoryPath);
                foreach (var directory in directories)
                {
                    var directoryNode = new TreeNode(Path.GetFileName(directory));
                    directoryNode.Nodes.Add(new TreeNode("DummyNode")); 
                    parentNode.Nodes.Add(directoryNode);
                }

                var files = Directory.GetFiles(directoryPath);
                foreach (var file in files)
                {
                    parentNode.Nodes.Add(new TreeNode(Path.GetFileName(file)));
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                parentNode.Nodes.Add("Access Denied");
            }
            catch (Exception ex)
            {
                parentNode.Nodes.Add($"Error: {ex.Message}");
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            TreeNode selectedDirEntry = dirTree.SelectedNode;
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
            menuPanel.Visible = false;
        }

        private void dirTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            dirTree.SelectedNode = e.Node;
            if (File.GetAttributes(Path.Combine(e.Node.FullPath, e.Node.Name)).HasFlag(FileAttributes.Directory))
            {
                selectedPath2 = Path.GetFullPath(e.Node.FullPath);
            }
            else
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
            Thread copyThread = new Thread(() => CopyFiles(selectedPath1, selectedPath2));
            copyThread.Start();
            copyPanel.Visible = false;
            menuPanel.Visible = true;
            dirTree.CollapseAll();

        }

        private void CopyFiles(string copyPath, string dest)
        {
            try

            {
                if (File.GetAttributes(copyPath).HasFlag(FileAttributes.Directory))
                {
                    var allDirectories = Directory.GetDirectories(copyPath, "*", SearchOption.AllDirectories);

                    foreach (var dir in allDirectories)
                    {
                        Directory.CreateDirectory(dir.Replace(copyPath, dest));
                    }

                    var allFiles = Directory.GetFiles(copyPath, "*.*", SearchOption.AllDirectories);
                    foreach (var file in allFiles)
                    {
                        File.Copy(file, file.Replace(copyPath, dest), true);
                    }
                }
                else
                {
                    File.Copy(copyPath, Path.Combine(dest, Path.GetFileName(copyPath)));
                }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show($"An exception has occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MoveFiles(string movePath,  string dest)
        {
            try
            {
                CopyFiles(movePath, dest);
                if (File.Exists(Path.Combine(dest, Path.GetFileName(movePath))))
                    Delete(movePath);
                else
                    throw new Exception("Failed to move the file(s)");
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"An exception has occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TreeNode deadNode = dirTree.SelectedNode;
            if(deadNode == null)
                MessageBox.Show("No directory entry selected, Please select a directory entry to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("Are you sure you want to delete selected file(s)?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Thread deleteDirEntry = new Thread(() => Delete(Path.GetFullPath(deadNode.FullPath)));
                    dirTree.CollapseAll();
                    deleteDirEntry.Start();
                }
                
            }
        }

        private void Delete(string path)
        {
            
                try
                {
                    if (File.GetAttributes(path).HasFlag(FileAttributes.Directory))
                    {
                        Directory.Delete(path, true);
                    }
                    else
                    {
                        File.Delete(path);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An exception has occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            TreeNode selectedDirEntry = dirTree.SelectedNode;
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
            Thread moveThread = new Thread(() => MoveFiles(selectedPath1, selectedPath2));
            moveThread.Start();
            movePanel.Visible = false;
            menuPanel.Visible = true;
            dirTree.CollapseAll();

        }

        private void dirTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Nodes.Clear(); 
            AddNodes(e.Node.FullPath, e.Node);
        }
    }

    public class FileTreeView : TreeView
    {
        public FileTreeView() {
            
        
        }
    }
}
