namespace WindowsFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button DrawKochButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.DrawKochButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 300);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.DrawKochButton.Location = new System.Drawing.Point(250, 330);
            this.DrawKochButton.Name = "DrawKochButton";
            this.DrawKochButton.Size = new System.Drawing.Size(120, 30);
            this.DrawKochButton.TabIndex = 1;
            this.DrawKochButton.Text = "Кривая Коха";
            this.DrawKochButton.UseVisualStyleBackColor = true;
            this.DrawKochButton.Click += new System.EventHandler(this.DrawKochButton_Click);
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.DrawKochButton);
            this.Controls.Add(this.pictureBox);
            this.Text = "Кривая Коха";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}