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
            this.dirTree = new System.Windows.Forms.TreeView();
            this.btnConfirmCopy = new System.Windows.Forms.Button();
            this.copyTxtBox = new System.Windows.Forms.TextBox();
            this.copyDestTxtBox = new System.Windows.Forms.TextBox();
            this.copyPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelCopy = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
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
            this.copyPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.movePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dirTree
            // 
            this.dirTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dirTree.Location = new System.Drawing.Point(12, 12);
            this.dirTree.Name = "dirTree";
            this.dirTree.Size = new System.Drawing.Size(537, 323);
            this.dirTree.TabIndex = 0;
            this.dirTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.dirTree_AfterExpand);
            this.dirTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dirTree_NodeMouseClick);
            // 
            // btnConfirmCopy
            // 
            this.btnConfirmCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmCopy.Location = new System.Drawing.Point(3, 3);
            this.btnConfirmCopy.Name = "btnConfirmCopy";
            this.btnConfirmCopy.Size = new System.Drawing.Size(252, 44);
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
            this.copyTxtBox.Size = new System.Drawing.Size(252, 26);
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
            this.copyDestTxtBox.Size = new System.Drawing.Size(252, 26);
            this.copyDestTxtBox.TabIndex = 3;
            // 
            // copyPanel
            // 
            this.copyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyPanel.Controls.Add(this.label2);
            this.copyPanel.Controls.Add(this.label1);
            this.copyPanel.Controls.Add(this.btnCancelCopy);
            this.copyPanel.Controls.Add(this.btnConfirmCopy);
            this.copyPanel.Controls.Add(this.copyDestTxtBox);
            this.copyPanel.Controls.Add(this.copyTxtBox);
            this.copyPanel.Location = new System.Drawing.Point(558, 15);
            this.copyPanel.Name = "copyPanel";
            this.copyPanel.Size = new System.Drawing.Size(258, 320);
            this.copyPanel.TabIndex = 4;
            this.copyPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination directory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
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
            this.btnCancelCopy.Size = new System.Drawing.Size(252, 44);
            this.btnCancelCopy.TabIndex = 4;
            this.btnCancelCopy.Text = "Cancel";
            this.btnCancelCopy.UseVisualStyleBackColor = true;
            this.btnCancelCopy.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.Controls.Add(this.btnDelete);
            this.menuPanel.Controls.Add(this.btnMove);
            this.menuPanel.Controls.Add(this.btnCopy);
            this.menuPanel.Location = new System.Drawing.Point(558, 15);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(258, 320);
            this.menuPanel.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(3, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(252, 44);
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
            this.btnMove.Size = new System.Drawing.Size(252, 44);
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
            this.btnCopy.Size = new System.Drawing.Size(252, 44);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // movePanel
            // 
            this.movePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movePanel.Controls.Add(this.label3);
            this.movePanel.Controls.Add(this.label4);
            this.movePanel.Controls.Add(this.btnCancelMove);
            this.movePanel.Controls.Add(this.btnConfirmMove);
            this.movePanel.Controls.Add(this.moveDestTxtBox);
            this.movePanel.Controls.Add(this.moveTxtBox);
            this.movePanel.Location = new System.Drawing.Point(558, 15);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(258, 320);
            this.movePanel.TabIndex = 7;
            this.movePanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destination directory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
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
            this.btnCancelMove.Size = new System.Drawing.Size(252, 44);
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
            this.btnConfirmMove.Size = new System.Drawing.Size(252, 44);
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
            this.moveDestTxtBox.Size = new System.Drawing.Size(252, 26);
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
            this.moveTxtBox.Size = new System.Drawing.Size(252, 26);
            this.moveTxtBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 348);
            this.Controls.Add(this.movePanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.copyPanel);
            this.Controls.Add(this.dirTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.copyPanel.ResumeLayout(false);
            this.copyPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.movePanel.ResumeLayout(false);
            this.movePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView dirTree;
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
    }
}

