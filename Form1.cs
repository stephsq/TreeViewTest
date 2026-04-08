namespace TreeViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Handle clicks in the empty space
        private void treeView_MouseDown(object sender, MouseEventArgs e)
        {
            //Get the node at the current mouse pointer coordinates
            TreeNode clickedNode = treeView.GetNodeAt(e.X, e.Y);

            //If there is no node under the mouse, clear the selection
            if (clickedNode == null)
            {
                treeView.SelectedNode = null;
            }
        }

        //Add a new node to the TreeView based on the text in the TextBox
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode(txtBox.Text);
            try
            {
                if (treeView.SelectedNode != null)
                {
                    treeView.SelectedNode.Nodes.Add(node);
                    treeView.SelectedNode.Expand();
                }
                else
                {
                    treeView.Nodes.Add(node);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding node: " + ex.Message);
            }
        }

        //Edit the selected node's text in the TreeView
        private void btnEdit_Click(object sender, EventArgs e)
        {
            treeView.SelectedNode.Text = txtBox.Text;
        }

        //Delete the selected node from the TreeView
        private void btnDelete_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Remove(treeView.SelectedNode);
        }
    }
}
