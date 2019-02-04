namespace WindowsFormsApp7
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button_load = new System.Windows.Forms.Button();
            this.button_spin = new System.Windows.Forms.Button();
            this.button_shoot = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonshot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button_load.Location = new System.Drawing.Point(695, 61);
            this.button_load.Name = "button1";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 0;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.buttonload_Click);
            // 
            // button2
            // 
            this.button_spin.Location = new System.Drawing.Point(695, 144);
            this.button_spin.Name = "button2";
            this.button_spin.Size = new System.Drawing.Size(75, 23);
            this.button_spin.TabIndex = 1;
            this.button_spin.Text = "Spin";
            this.button_spin.UseVisualStyleBackColor = true;
            this.button_spin.Click += new System.EventHandler(this.buttonspin_Click);
            // 
            // button4
            // 
            this.button_shoot.Location = new System.Drawing.Point(695, 318);
            this.button_shoot.Name = "button4";
            this.button_shoot.Size = new System.Drawing.Size(75, 23);
            this.button_shoot.TabIndex = 3;
            this.button_shoot.Text = "Play Again";
            this.button_shoot.UseVisualStyleBackColor = true;
            this.button_shoot.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Russian-roulette-game pic.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(279, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 140);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.buttonshot.Location = new System.Drawing.Point(695, 236);
            this.buttonshot.Name = "button3";
            this.buttonshot.Size = new System.Drawing.Size(75, 23);
            this.buttonshot.TabIndex = 11;
            this.buttonshot.Text = "Fire";
            this.buttonshot.UseVisualStyleBackColor = true;
            this.buttonshot.Click += new System.EventHandler(this.buttonshoot_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.buttonshot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_shoot);
            this.Controls.Add(this.button_spin);
            this.Controls.Add(this.button_load);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_spin;
        private System.Windows.Forms.Button button_shoot;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonshot;
    }
}