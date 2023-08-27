namespace ImageClassification
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
            SelectYourImage = new Button();
            ClassifyImage = new Button();
            ShowImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ShowImage).BeginInit();
            SuspendLayout();
            // 
            // SelectYourImage
            // 
            SelectYourImage.Location = new Point(202, 12);
            SelectYourImage.Name = "SelectYourImage";
            SelectYourImage.Size = new Size(137, 35);
            SelectYourImage.TabIndex = 0;
            SelectYourImage.Text = "Select your image";
            SelectYourImage.UseVisualStyleBackColor = true;
            SelectYourImage.Click += SelectYourImage_Click;
            // 
            // ClassifyImage
            // 
            ClassifyImage.Enabled = false;
            ClassifyImage.Location = new Point(448, 12);
            ClassifyImage.Name = "ClassifyImage";
            ClassifyImage.Size = new Size(137, 35);
            ClassifyImage.TabIndex = 1;
            ClassifyImage.Text = "Classify the image";
            ClassifyImage.UseVisualStyleBackColor = true;
            ClassifyImage.Click += ClassifyImage_Click;
            // 
            // ShowImage
            // 
            ShowImage.Location = new Point(12, 68);
            ShowImage.Name = "ShowImage";
            ShowImage.Size = new Size(776, 370);
            ShowImage.SizeMode = PictureBoxSizeMode.Zoom;
            ShowImage.TabIndex = 2;
            ShowImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowImage);
            Controls.Add(ClassifyImage);
            Controls.Add(SelectYourImage);
            Name = "Form1";
            Text = "Classify the image";
            ((System.ComponentModel.ISupportInitialize)ShowImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SelectYourImage;
        private Button ClassifyImage;
        private PictureBox ShowImage;
    }
}