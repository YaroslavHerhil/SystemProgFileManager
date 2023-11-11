using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemProgFileManager
{
    public partial class FileTreeView : TreeView
    {
        public FileTreeView()
        {
            InitializeComponent();
            Nodes.Clear();
            GetDrives();
        }
        public void GetDrives()
        {
            Nodes.Clear();
            TreeNode rootNode;
            foreach (var drive in Environment.GetLogicalDrives())
            {
                rootNode = new TreeNode(drive,0,0);
                rootNode.Tag = "dr";
                Nodes.Add(rootNode);
                AddNodes(drive, rootNode);
            }
        }
        public async Task AddNodes(string directoryPath, TreeNode parentNode)
        {
            try
            {
               
                var directories = Directory.GetDirectories(directoryPath);
                foreach (var directory in directories)
                {
                    var directoryNode = new TreeNode(Path.GetFileName(directory),1,1);
                    directoryNode.Nodes.Add(new TreeNode("DummyNode"));
                   
                    parentNode.Nodes.Add(directoryNode);
                }

                var files = Directory.GetFiles(directoryPath);
                foreach (var file in files)
                {
                    var fileNode = new TreeNode(Path.GetFileName(file), 2,2);
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                var errorNode = new TreeNode("Access Denied", 4, 4);
                parentNode.Nodes.Add(errorNode);
            }
            catch (Exception ex)
            {
                var errorNode = new TreeNode("$Error: {ex.Message}", 3, 3);
                parentNode.Nodes.Add(errorNode);
            }
        }
        public void Delete(string path)
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
        public void CopyFiles(string copyPath, string dest)
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
            catch (Exception ex)
            {
                MessageBox.Show($"An exception has occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MoveFiles(string movePath, string dest)
        {
            try
            {
                CopyFiles(movePath, dest);
                if (File.Exists(Path.Combine(dest, Path.GetFileName(movePath))))
                    Delete(movePath);
                else
                    throw new Exception("Failed to move the file(s)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An exception has occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
