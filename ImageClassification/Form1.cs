namespace ImageClassification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectYourImage_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to allow only image files
            openFileDialog.Filter = "Image Files (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp|All Files (*.*)|*.*";

            // Show the dialog and get the result
            DialogResult result = openFileDialog.ShowDialog();

            // Check if the user selected a file
            if (result == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedImagePath = openFileDialog.FileName;

                // Display the selected image in the PictureBox control
                ShowImage.Image = System.Drawing.Image.FromFile(selectedImagePath);

                // Enable the classify button since an image is selected
                ClassifyImage.Enabled = true;
            }
        }

        private void ClassifyImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"This is haha");
        }
    }
}