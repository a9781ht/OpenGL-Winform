using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL; // 新增

namespace SharpGLApp
{
    public partial class Form1 : Form
    {
        private float _x = 0.0f;
        private float _y = 0.0f;
        private float _z = 0.0f;
        private uint _mode = OpenGL.GL_LINE_LOOP; // 預設繪製模式為線條

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _x = _y = _z = 0.0f;
            trackBar_x.Value = trackBar_y.Value = trackBar_z.Value = 0;
            label_x.Text = "x軸";
            label_y.Text = "y軸";
            label_z.Text = "z軸";
        }

        private void trackBar_x_Scroll(object sender, EventArgs e)
        {
            int x = trackBar_x.Value;
            _x = (float)x;
            label_x.Text = "X: " + x.ToString();
        }

        private void trackBar_y_Scroll(object sender, EventArgs e)
        {
            int y = trackBar_y.Value;
            _y = (float)y;
            label_y.Text = "Y: " + y.ToString();
        }

        private void trackBar_z_Scroll(object sender, EventArgs e)
        {
            int z = trackBar_z.Value;
            _z = (float)z;
            label_z.Text = "Z: " + z.ToString();
        }

        private void radioButton_line_CheckedChanged(object sender, EventArgs e)
        {
            _mode = OpenGL.GL_LINE_LOOP;
        }

        private void radioButton_plane_CheckedChanged(object sender, EventArgs e)
        {
            _mode = OpenGL.GL_QUADS;
        }

        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            SharpGL.OpenGL gl = openGLControl1.OpenGL; // 創建OpenGL物件

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT); // 清空畫面
            gl.LoadIdentity(); // 重置
            gl.Translate(0.0f, 0.0f, -6.0f); // 設置座標，距離螢幕6.0單位

            gl.Rotate(_x, 1.0f, 0.0f, 0.0f); // 繞x軸旋轉
            gl.Rotate(_y, 0.0f, 1.0f, 0.0f); // 繞y軸旋轉
            gl.Rotate(_z, 0.0f, 0.0f, 1.0f); // 繞z軸旋轉

            gl.Begin(_mode); // 開始繪製立方體

            // 繪製y軸正面(y=1)
            gl.Color(0.0f, 1.0f, 0.0f); // 設置顏色(RGB) : 綠色
            gl.Vertex(1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(1.0f, 1.0f, 1.0f);

            // 繪製y軸背面(y=-1)
            gl.Color(0.0f, 0.5f, 0.0f); // 設置顏色(RGB) : 深綠色
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);

            // 繪製z軸正面(z=1)
            gl.Color(1.0f, 0.0f, 0.0f); // 設置顏色(RGB) : 紅色
            gl.Vertex(1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);

            // 繪製z軸背面(z=-1)
            gl.Color(1.0f, 1.0f, 0.0f); // 設置顏色(RGB) : 黃色
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(1.0f, 1.0f, -1.0f);

            // 繪製x軸背面(x=-1)
            gl.Color(0.0f, 0.0f, 1.0f); // 設置顏色(RGB) : 藍色
            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);

            // 繪製x軸正面(x=1)
            gl.Color(1.0f, 0.0f, 1.0f); // 設置顏色(RGB) : 紫色
            gl.Vertex(1.0f, 1.0f, -1.0f);
            gl.Vertex(1.0f, 1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);

            gl.End();
        }
    }
}
