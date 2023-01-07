namespace PaintApplication
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.button_color = new System.Windows.Forms.Button();
            this.button_fill = new System.Windows.Forms.Button();
            this.button_pencil = new System.Windows.Forms.Button();
            this.button_eraser = new System.Windows.Forms.Button();
            this.button_ellipse = new System.Windows.Forms.Button();
            this.button_rect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 100);
            this.panel1.TabIndex = 0;
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::PaintApplication.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(0, 3);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(217, 94);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 3;
            this.color_picker.TabStop = false;
            this.color_picker.Click += new System.EventHandler(this.color_picker_Click);
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.button_save);
            this.panel3.Controls.Add(this.button_clear);
            this.panel3.Controls.Add(this.button_line);
            this.panel3.Controls.Add(this.pic_color);
            this.panel3.Controls.Add(this.button_color);
            this.panel3.Controls.Add(this.button_fill);
            this.panel3.Controls.Add(this.button_pencil);
            this.panel3.Controls.Add(this.button_eraser);
            this.panel3.Controls.Add(this.button_ellipse);
            this.panel3.Controls.Add(this.button_rect);
            this.panel3.Location = new System.Drawing.Point(168, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(703, 82);
            this.panel3.TabIndex = 3;
            // 
            // button_save
            // 
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_save.Location = new System.Drawing.Point(630, 16);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(70, 28);
            this.button_save.TabIndex = 9;
            this.button_save.Text = "Save";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_clear
            // 
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_clear.Location = new System.Drawing.Point(630, 50);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(70, 26);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Clear";
            this.button_clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_line
            // 
            this.button_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_line.ForeColor = System.Drawing.Color.White;
            this.button_line.Image = global::PaintApplication.Properties.Resources.line;
            this.button_line.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_line.Location = new System.Drawing.Point(555, 21);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(69, 52);
            this.button_line.TabIndex = 7;
            this.button_line.Text = "line";
            this.button_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_line.UseVisualStyleBackColor = true;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(55, 30);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(31, 28);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // button_color
            // 
            this.button_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color.ForeColor = System.Drawing.Color.White;
            this.button_color.Image = global::PaintApplication.Properties.Resources.color1;
            this.button_color.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_color.Location = new System.Drawing.Point(101, 21);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(66, 52);
            this.button_color.TabIndex = 1;
            this.button_color.Text = "color";
            this.button_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // button_fill
            // 
            this.button_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fill.ForeColor = System.Drawing.Color.White;
            this.button_fill.Image = global::PaintApplication.Properties.Resources.bucket;
            this.button_fill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_fill.Location = new System.Drawing.Point(173, 21);
            this.button_fill.Name = "button_fill";
            this.button_fill.Size = new System.Drawing.Size(76, 52);
            this.button_fill.TabIndex = 2;
            this.button_fill.Text = "fill";
            this.button_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_fill.UseVisualStyleBackColor = true;
            this.button_fill.Click += new System.EventHandler(this.button_fill_Click);
            // 
            // button_pencil
            // 
            this.button_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pencil.ForeColor = System.Drawing.Color.White;
            this.button_pencil.Image = global::PaintApplication.Properties.Resources.pencil;
            this.button_pencil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_pencil.Location = new System.Drawing.Point(255, 21);
            this.button_pencil.Name = "button_pencil";
            this.button_pencil.Size = new System.Drawing.Size(69, 52);
            this.button_pencil.TabIndex = 3;
            this.button_pencil.Text = "pencil";
            this.button_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_pencil.UseVisualStyleBackColor = true;
            this.button_pencil.Click += new System.EventHandler(this.button_pencil_Click);
            // 
            // button_eraser
            // 
            this.button_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eraser.ForeColor = System.Drawing.Color.White;
            this.button_eraser.Image = global::PaintApplication.Properties.Resources.eraser;
            this.button_eraser.Location = new System.Drawing.Point(330, 21);
            this.button_eraser.Name = "button_eraser";
            this.button_eraser.Size = new System.Drawing.Size(69, 52);
            this.button_eraser.TabIndex = 4;
            this.button_eraser.Text = "eraser";
            this.button_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_eraser.UseVisualStyleBackColor = true;
            this.button_eraser.Click += new System.EventHandler(this.button_eraser_Click);
            // 
            // button_ellipse
            // 
            this.button_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ellipse.ForeColor = System.Drawing.Color.White;
            this.button_ellipse.Image = global::PaintApplication.Properties.Resources.circle;
            this.button_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ellipse.Location = new System.Drawing.Point(405, 21);
            this.button_ellipse.Name = "button_ellipse";
            this.button_ellipse.Size = new System.Drawing.Size(69, 52);
            this.button_ellipse.TabIndex = 5;
            this.button_ellipse.Text = "ellipse";
            this.button_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ellipse.UseVisualStyleBackColor = true;
            this.button_ellipse.Click += new System.EventHandler(this.button_ellipse_Click);
            // 
            // button_rect
            // 
            this.button_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rect.ForeColor = System.Drawing.Color.White;
            this.button_rect.Image = global::PaintApplication.Properties.Resources.rectangle;
            this.button_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_rect.Location = new System.Drawing.Point(480, 21);
            this.button_rect.Name = "button_rect";
            this.button_rect.Size = new System.Drawing.Size(69, 52);
            this.button_rect.TabIndex = 6;
            this.button_rect.Text = "rectangle";
            this.button_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_rect.UseVisualStyleBackColor = true;
            this.button_rect.Click += new System.EventHandler(this.button_rect_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 24);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 100);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(883, 338);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 462);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button button_line;
        private System.Windows.Forms.Button button_rect;
        private System.Windows.Forms.Button button_ellipse;
        private System.Windows.Forms.Button button_eraser;
        private System.Windows.Forms.Button button_pencil;
        private System.Windows.Forms.Button button_fill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_clear;
    }
}

