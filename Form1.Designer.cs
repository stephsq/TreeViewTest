namespace TreeViewTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView = new TreeView();
            txtBox = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(12, 171);
            treeView.Name = "treeView";
            treeView.Size = new Size(678, 359);
            treeView.TabIndex = 0;
            treeView.MouseDown += treeView_MouseDown;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(30, 108);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(638, 35);
            txtBox.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(486, 29);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(182, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(263, 29);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(182, 40);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(23, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(182, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 563);
            Controls.Add(txtBox);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(treeView);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView;
        private TextBox txtBox;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}
