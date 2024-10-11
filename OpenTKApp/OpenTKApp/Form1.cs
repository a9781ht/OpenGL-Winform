using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL; // 新增

namespace OpenTKApp
{
    public partial class Form1 : Form
    {
        private int _vertexBufferObject; // VBO
        private int _vertexArrayObject; // VAO
        private Shader _shader;

        public Form1()
        {
            InitializeComponent();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            glControl1.MakeCurrent();

            // Vertices for a triangle
            float[] Vertices = {
                -0.5f, -0.5f, 0.0f, // Bottom-left vertex
                0.5f, -0.5f, 0.0f,  // Bottom-right vertex
                0.0f,  0.5f, 0.0f   // Top vertex
            };

            // Create the vertex buffer object (VBO) for the vertex data
            _vertexBufferObject = GL.GenBuffer();
            // Bind the VBO and copy the vertex data into it
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);
            GL.BufferData(BufferTarget.ArrayBuffer, Vertices.Length * sizeof(float), Vertices, BufferUsageHint.StaticDraw);

            // Create the vertex array object (VAO) for the vertex data
            _vertexArrayObject = GL.GenVertexArray();
            // Bind the VAO and set the vertex attributes
            GL.BindVertexArray(_vertexArrayObject);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);

            // Create the shader program
            _shader = new Shader("..\\..\\shader\\shader.vert", "..\\..\\shader\\shader.frag");
            _shader.Use();
        }
        private void glControl1_Resize(object sender, EventArgs e)
        {
            glControl1.MakeCurrent();

            // Resize the viewport to match the window size.
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            glControl1.MakeCurrent();

            // Clear the color buffer
            GL.Clear(ClearBufferMask.ColorBufferBit);

            // Bind the VBO
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);

            // Bind the VAO
            GL.BindVertexArray(_vertexArrayObject);

            // Use/Bind the program
            _shader.Use();

            // This draws the triangle
            GL.DrawArrays(PrimitiveType.Triangles, 0, 3);

            // Swap the front/back buffers so what we just rendered to the back buffer is displayed in the window
            glControl1.SwapBuffers();
        }
    }
}
