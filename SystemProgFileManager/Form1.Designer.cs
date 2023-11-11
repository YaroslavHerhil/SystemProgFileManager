namespace SystemProgFileManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConfirmCopy = new System.Windows.Forms.Button();
            this.copyTxtBox = new System.Windows.Forms.TextBox();
            this.copyDestTxtBox = new System.Windows.Forms.TextBox();
            this.copyPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelCopy = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.permissionsButton = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.movePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelMove = new System.Windows.Forms.Button();
            this.btnConfirmMove = new System.Windows.Forms.Button();
            this.moveDestTxtBox = new System.Windows.Forms.TextBox();
            this.moveTxtBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.infoPanel = new System.Windows.Forms.Panel();
            this.infoLabelSize = new System.Windows.Forms.Label();
            this.inforLabelPerm = new System.Windows.Forms.Label();
            this.infoLabelName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.infoTextBoxPath = new System.Windows.Forms.TextBox();
            this.fileTreeView = new SystemProgFileManager.FileTreeView();
            this.copyPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.movePanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmCopy
            // 
            this.btnConfirmCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmCopy.Location = new System.Drawing.Point(3, 3);
            this.btnConfirmCopy.Name = "btnConfirmCopy";
            this.btnConfirmCopy.Size = new System.Drawing.Size(229, 44);
            this.btnConfirmCopy.TabIndex = 1;
            this.btnConfirmCopy.Text = "Copy";
            this.btnConfirmCopy.UseVisualStyleBackColor = true;
            this.btnConfirmCopy.Click += new System.EventHandler(this.btnConfirmCopy_Click);
            // 
            // copyTxtBox
            // 
            this.copyTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyTxtBox.Location = new System.Drawing.Point(3, 78);
            this.copyTxtBox.Name = "copyTxtBox";
            this.copyTxtBox.ReadOnly = true;
            this.copyTxtBox.Size = new System.Drawing.Size(229, 26);
            this.copyTxtBox.TabIndex = 2;
            // 
            // copyDestTxtBox
            // 
            this.copyDestTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyDestTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyDestTxtBox.Location = new System.Drawing.Point(3, 149);
            this.copyDestTxtBox.Name = "copyDestTxtBox";
            this.copyDestTxtBox.ReadOnly = true;
            this.copyDestTxtBox.Size = new System.Drawing.Size(229, 26);
            this.copyDestTxtBox.TabIndex = 3;
            // 
            // copyPanel
            // 
            this.copyPanel.BackColor = System.Drawing.Color.Black;
            this.copyPanel.Controls.Add(this.label2);
            this.copyPanel.Controls.Add(this.label1);
            this.copyPanel.Controls.Add(this.btnCancelCopy);
            this.copyPanel.Controls.Add(this.btnConfirmCopy);
            this.copyPanel.Controls.Add(this.copyDestTxtBox);
            this.copyPanel.Controls.Add(this.copyTxtBox);
            this.copyPanel.Location = new System.Drawing.Point(815, 15);
            this.copyPanel.Name = "copyPanel";
            this.copyPanel.Size = new System.Drawing.Size(235, 320);
            this.copyPanel.TabIndex = 4;
            this.copyPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination directory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "File or directory to copy:";
            // 
            // btnCancelCopy
            // 
            this.btnCancelCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelCopy.Location = new System.Drawing.Point(3, 273);
            this.btnCancelCopy.Name = "btnCancelCopy";
            this.btnCancelCopy.Size = new System.Drawing.Size(229, 44);
            this.btnCancelCopy.TabIndex = 4;
            this.btnCancelCopy.Text = "Cancel";
            this.btnCancelCopy.UseVisualStyleBackColor = true;
            this.btnCancelCopy.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Black;
            this.menuPanel.Controls.Add(this.permissionsButton);
            this.menuPanel.Controls.Add(this.btnDelete);
            this.menuPanel.Controls.Add(this.btnMove);
            this.menuPanel.Controls.Add(this.btnCopy);
            this.menuPanel.Location = new System.Drawing.Point(558, 15);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(251, 320);
            this.menuPanel.TabIndex = 5;
            // 
            // permissionsButton
            // 
            this.permissionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.permissionsButton.Location = new System.Drawing.Point(3, 153);
            this.permissionsButton.Name = "permissionsButton";
            this.permissionsButton.Size = new System.Drawing.Size(245, 44);
            this.permissionsButton.TabIndex = 6;
            this.permissionsButton.Text = "Set Permissions";
            this.permissionsButton.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(3, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 44);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMove.Location = new System.Drawing.Point(3, 53);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(245, 44);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(3, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(245, 44);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // movePanel
            // 
            this.movePanel.BackColor = System.Drawing.Color.Black;
            this.movePanel.Controls.Add(this.label3);
            this.movePanel.Controls.Add(this.label4);
            this.movePanel.Controls.Add(this.btnCancelMove);
            this.movePanel.Controls.Add(this.btnConfirmMove);
            this.movePanel.Controls.Add(this.moveDestTxtBox);
            this.movePanel.Controls.Add(this.moveTxtBox);
            this.movePanel.Location = new System.Drawing.Point(558, 338);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(251, 320);
            this.movePanel.TabIndex = 7;
            this.movePanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destination directory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "File or directory to move:";
            // 
            // btnCancelMove
            // 
            this.btnCancelMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelMove.Location = new System.Drawing.Point(3, 273);
            this.btnCancelMove.Name = "btnCancelMove";
            this.btnCancelMove.Size = new System.Drawing.Size(245, 44);
            this.btnCancelMove.TabIndex = 4;
            this.btnCancelMove.Text = "Cancel";
            this.btnCancelMove.UseVisualStyleBackColor = true;
            this.btnCancelMove.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmMove
            // 
            this.btnConfirmMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmMove.Location = new System.Drawing.Point(3, 3);
            this.btnConfirmMove.Name = "btnConfirmMove";
            this.btnConfirmMove.Size = new System.Drawing.Size(245, 44);
            this.btnConfirmMove.TabIndex = 1;
            this.btnConfirmMove.Text = "Move";
            this.btnConfirmMove.UseVisualStyleBackColor = true;
            this.btnConfirmMove.Click += new System.EventHandler(this.btnConfirmMove_Click);
            // 
            // moveDestTxtBox
            // 
            this.moveDestTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveDestTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveDestTxtBox.Location = new System.Drawing.Point(3, 149);
            this.moveDestTxtBox.Name = "moveDestTxtBox";
            this.moveDestTxtBox.ReadOnly = true;
            this.moveDestTxtBox.Size = new System.Drawing.Size(245, 26);
            this.moveDestTxtBox.TabIndex = 3;
            // 
            // moveTxtBox
            // 
            this.moveTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveTxtBox.Location = new System.Drawing.Point(3, 78);
            this.moveTxtBox.Name = "moveTxtBox";
            this.moveTxtBox.ReadOnly = true;
            this.moveTxtBox.Size = new System.Drawing.Size(245, 26);
            this.moveTxtBox.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DriveIcon.png");
            this.imageList1.Images.SetKeyName(1, "folderIcon.png");
            this.imageList1.Images.SetKeyName(2, "FileIcon.png");
            this.imageList1.Images.SetKeyName(3, "ErrorIcon.png");
            this.imageList1.Images.SetKeyName(4, "LockIcon.png");
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.infoPanel.Controls.Add(this.infoLabelSize);
            this.infoPanel.Controls.Add(this.inforLabelPerm);
            this.infoPanel.Controls.Add(this.infoLabelName);
            this.infoPanel.Controls.Add(this.button1);
            this.infoPanel.Controls.Add(this.infoTextBoxPath);
            this.infoPanel.Location = new System.Drawing.Point(815, 341);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(484, 320);
            this.infoPanel.TabIndex = 7;
            this.infoPanel.Visible = false;
            // 
            // infoLabelSize
            // 
            this.infoLabelSize.AutoSize = true;
            this.infoLabelSize.ForeColor = System.Drawing.Color.Silver;
            this.infoLabelSize.Location = new System.Drawing.Point(3, 70);
            this.infoLabelSize.Name = "infoLabelSize";
            this.infoLabelSize.Size = new System.Drawing.Size(44, 20);
            this.infoLabelSize.TabIndex = 9;
            this.infoLabelSize.Text = "Size:";
            // 
            // inforLabelPerm
            // 
            this.inforLabelPerm.AutoSize = true;
            this.inforLabelPerm.ForeColor = System.Drawing.Color.Silver;
            this.inforLabelPerm.Location = new System.Drawing.Point(3, 98);
            this.inforLabelPerm.Name = "inforLabelPerm";
            this.inforLabelPerm.Size = new System.Drawing.Size(98, 20);
            this.inforLabelPerm.TabIndex = 8;
            this.inforLabelPerm.Text = "Permissions:";
            // 
            // infoLabelName
            // 
            this.infoLabelName.AutoSize = true;
            this.infoLabelName.BackColor = System.Drawing.SystemColors.ControlText;
            this.infoLabelName.ForeColor = System.Drawing.Color.Silver;
            this.infoLabelName.Location = new System.Drawing.Point(3, 12);
            this.infoLabelName.Name = "infoLabelName";
            this.infoLabelName.Size = new System.Drawing.Size(82, 20);
            this.infoLabelName.TabIndex = 5;
            this.infoLabelName.Text = "File name:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(478, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // infoTextBoxPath
            // 
            this.infoTextBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoTextBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTextBoxPath.Location = new System.Drawing.Point(3, 35);
            this.infoTextBoxPath.Name = "infoTextBoxPath";
            this.infoTextBoxPath.ReadOnly = true;
            this.infoTextBoxPath.Size = new System.Drawing.Size(478, 26);
            this.infoTextBoxPath.TabIndex = 2;
            // 
            // fileTreeView
            // 
            this.fileTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fileTreeView.BackColor = System.Drawing.Color.Silver;
            this.fileTreeView.ForeColor = System.Drawing.Color.Black;
            this.fileTreeView.ImageIndex = 1;
            this.fileTreeView.ImageList = this.imageList1;
            this.fileTreeView.LineColor = System.Drawing.Color.LightGray;
            this.fileTreeView.Location = new System.Drawing.Point(12, 15);
            this.fileTreeView.Name = "fileTreeView";
            this.fileTreeView.SelectedImageIndex = 0;
            this.fileTreeView.Size = new System.Drawing.Size(540, 1007);
            this.fileTreeView.TabIndex = 8;
            this.fileTreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.fileTreeView_AfterExpand);
            this.fileTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fileTreeView_NodeMouseClick);
            this.fileTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fileTreeView_NodeMouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1162, 1034);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.fileTreeView);
            this.Controls.Add(this.movePanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.copyPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.copyPanel.ResumeLayout(false);
            this.copyPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.movePanel.ResumeLayout(false);
            this.movePanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmCopy;
        private System.Windows.Forms.TextBox copyTxtBox;
        private System.Windows.Forms.TextBox copyDestTxtBox;
        private System.Windows.Forms.Panel copyPanel;
        private System.Windows.Forms.Button btnCancelCopy;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel movePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelMove;
        private System.Windows.Forms.Button btnConfirmMove;
        private System.Windows.Forms.TextBox moveDestTxtBox;
        private System.Windows.Forms.TextBox moveTxtBox;
        private FileTreeView fileTreeView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button permissionsButton;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label infoLabelName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox infoTextBoxPath;
        private System.Windows.Forms.Label infoLabelSize;
        private System.Windows.Forms.Label inforLabelPerm;
    }
}

