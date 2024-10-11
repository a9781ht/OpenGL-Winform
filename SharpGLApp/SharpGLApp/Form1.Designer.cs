namespace SharpGLApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.trackBar_x = new System.Windows.Forms.TrackBar();
            this.trackBar_y = new System.Windows.Forms.TrackBar();
            this.trackBar_z = new System.Windows.Forms.TrackBar();
            this.radioButton_line = new System.Windows.Forms.RadioButton();
            this.radioButton_plane = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_z = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_z)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(27, 32);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(391, 427);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            // 
            // trackBar_x
            // 
            this.trackBar_x.Location = new System.Drawing.Point(463, 68);
            this.trackBar_x.Maximum = 180;
            this.trackBar_x.Minimum = -180;
            this.trackBar_x.Name = "trackBar_x";
            this.trackBar_x.Size = new System.Drawing.Size(280, 45);
            this.trackBar_x.TabIndex = 1;
            this.trackBar_x.TickFrequency = 0;
            this.trackBar_x.Scroll += new System.EventHandler(this.trackBar_x_Scroll);
            // 
            // trackBar_y
            // 
            this.trackBar_y.Location = new System.Drawing.Point(463, 176);
            this.trackBar_y.Maximum = 180;
            this.trackBar_y.Minimum = -180;
            this.trackBar_y.Name = "trackBar_y";
            this.trackBar_y.Size = new System.Drawing.Size(280, 45);
            this.trackBar_y.TabIndex = 2;
            this.trackBar_y.TickFrequency = 0;
            this.trackBar_y.Scroll += new System.EventHandler(this.trackBar_y_Scroll);
            // 
            // trackBar_z
            // 
            this.trackBar_z.Location = new System.Drawing.Point(463, 284);
            this.trackBar_z.Maximum = 180;
            this.trackBar_z.Minimum = -180;
            this.trackBar_z.Name = "trackBar_z";
            this.trackBar_z.Size = new System.Drawing.Size(280, 45);
            this.trackBar_z.TabIndex = 3;
            this.trackBar_z.TickFrequency = 0;
            this.trackBar_z.Scroll += new System.EventHandler(this.trackBar_z_Scroll);
            // 
            // radioButton_line
            // 
            this.radioButton_line.AutoSize = true;
            this.radioButton_line.Location = new System.Drawing.Point(463, 374);
            this.radioButton_line.Name = "radioButton_line";
            this.radioButton_line.Size = new System.Drawing.Size(35, 16);
            this.radioButton_line.TabIndex = 4;
            this.radioButton_line.TabStop = true;
            this.radioButton_line.Text = "線";
            this.radioButton_line.UseVisualStyleBackColor = true;
            this.radioButton_line.CheckedChanged += new System.EventHandler(this.radioButton_line_CheckedChanged);
            // 
            // radioButton_plane
            // 
            this.radioButton_plane.AutoSize = true;
            this.radioButton_plane.Location = new System.Drawing.Point(463, 425);
            this.radioButton_plane.Name = "radioButton_plane";
            this.radioButton_plane.Size = new System.Drawing.Size(35, 16);
            this.radioButton_plane.TabIndex = 5;
            this.radioButton_plane.TabStop = true;
            this.radioButton_plane.Text = "面";
            this.radioButton_plane.UseVisualStyleBackColor = true;
            this.radioButton_plane.CheckedChanged += new System.EventHandler(this.radioButton_plane_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "座標復原";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(461, 44);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(23, 12);
            this.label_x.TabIndex = 7;
            this.label_x.Text = "x軸";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(461, 152);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(23, 12);
            this.label_y.TabIndex = 8;
            this.label_y.Text = "y軸";
            // 
            // label_z
            // 
            this.label_z.AutoSize = true;
            this.label_z.Location = new System.Drawing.Point(463, 260);
            this.label_z.Name = "label_z";
            this.label_z.Size = new System.Drawing.Size(22, 12);
            this.label_z.TabIndex = 9;
            this.label_z.Text = "z軸";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 499);
            this.Controls.Add(this.label_z);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton_plane);
            this.Controls.Add(this.radioButton_line);
            this.Controls.Add(this.trackBar_z);
            this.Controls.Add(this.trackBar_y);
            this.Controls.Add(this.trackBar_x);
            this.Controls.Add(this.openGLControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_z)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.TrackBar trackBar_x;
        private System.Windows.Forms.TrackBar trackBar_y;
        private System.Windows.Forms.TrackBar trackBar_z;
        private System.Windows.Forms.RadioButton radioButton_line;
        private System.Windows.Forms.RadioButton radioButton_plane;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_z;
    }
}

