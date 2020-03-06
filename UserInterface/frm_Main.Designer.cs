namespace UserInterface
{
    partial class frm_Main
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
            this.pb_ImageDisplay = new System.Windows.Forms.PictureBox();
            this.btn_LoadImage = new System.Windows.Forms.Button();
            this.btn_NextImage = new System.Windows.Forms.Button();
            this.btn_PreviousImage = new System.Windows.Forms.Button();
            this.FD_ImagePathSelector = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_ImageDisplay
            // 
            this.pb_ImageDisplay.Location = new System.Drawing.Point(1, 2);
            this.pb_ImageDisplay.Name = "pb_ImageDisplay";
            this.pb_ImageDisplay.Size = new System.Drawing.Size(432, 363);
            this.pb_ImageDisplay.TabIndex = 11;
            this.pb_ImageDisplay.TabStop = false;
            // 
            // btn_LoadImage
            // 
            this.btn_LoadImage.Location = new System.Drawing.Point(151, 371);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(133, 77);
            this.btn_LoadImage.TabIndex = 10;
            this.btn_LoadImage.Text = "Load Image";
            this.btn_LoadImage.UseVisualStyleBackColor = true;
            this.btn_LoadImage.Click += new System.EventHandler(this.btn_LoadImage_Click);
            // 
            // btn_NextImage
            // 
            this.btn_NextImage.Location = new System.Drawing.Point(300, 371);
            this.btn_NextImage.Name = "btn_NextImage";
            this.btn_NextImage.Size = new System.Drawing.Size(133, 77);
            this.btn_NextImage.TabIndex = 9;
            this.btn_NextImage.Text = ">";
            this.btn_NextImage.UseVisualStyleBackColor = true;
            this.btn_NextImage.Click += new System.EventHandler(this.btn_NextImage_Click);
            // 
            // btn_PreviousImage
            // 
            this.btn_PreviousImage.Location = new System.Drawing.Point(1, 371);
            this.btn_PreviousImage.Name = "btn_PreviousImage";
            this.btn_PreviousImage.Size = new System.Drawing.Size(133, 77);
            this.btn_PreviousImage.TabIndex = 8;
            this.btn_PreviousImage.Text = "<";
            this.btn_PreviousImage.UseVisualStyleBackColor = true;
            this.btn_PreviousImage.Click += new System.EventHandler(this.btn_PreviousImage_Click);
            // 
            // FD_ImagePathSelector
            // 
            this.FD_ImagePathSelector.FileName = "Image";
            this.FD_ImagePathSelector.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            this.FD_ImagePathSelector.Multiselect = true;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.pb_ImageDisplay);
            this.Controls.Add(this.btn_LoadImage);
            this.Controls.Add(this.btn_NextImage);
            this.Controls.Add(this.btn_PreviousImage);
            this.Name = "frm_Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImageDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ImageDisplay;
        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.Button btn_NextImage;
        private System.Windows.Forms.Button btn_PreviousImage;
        private System.Windows.Forms.OpenFileDialog FD_ImagePathSelector;
    }
}