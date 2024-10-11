using System;
using System.Collections.Generic;
using System.IO; // 新增StreamReader
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL; // 新增GL

namespace OpenTKApp
{
    internal class Shader
    {
        public int Handle; // 定義著色器程式
        private bool disposedValue = false;

        public Shader(string vertexPath, string fragmentPath)
        {
            int VertexShader; // 定義頂點著色器
            int FragmentShader; // 定義片段著色器

            string VertexShaderSource; // 定義頂點著色器程式碼
            string FragmentShaderSource; // 定義片段著色器程式碼

            // 讀取程式碼
            using (StreamReader reader = new StreamReader(vertexPath, Encoding.UTF8))
            {
                VertexShaderSource = reader.ReadToEnd();
            }
            using (StreamReader reader = new StreamReader(fragmentPath, Encoding.UTF8))
            {
                FragmentShaderSource = reader.ReadToEnd();
            }

            // 建立頂點著色器
            VertexShader = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(VertexShader, VertexShaderSource);

            // 編譯頂點著色器
            GL.CompileShader(VertexShader);
            string infoLogVert = GL.GetShaderInfoLog(VertexShader);
            if (infoLogVert != System.String.Empty) { System.Console.WriteLine(infoLogVert); }

            // 建立片段著色器
            FragmentShader = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(FragmentShader, FragmentShaderSource);

            // 編譯片段著色器
            GL.CompileShader(FragmentShader);
            string infoLogFrag = GL.GetShaderInfoLog(FragmentShader);
            if (infoLogFrag != System.String.Empty) { System.Console.WriteLine(infoLogFrag); }

            // 建立著色器程式
            Handle = GL.CreateProgram();
            GL.AttachShader(Handle, VertexShader);
            GL.AttachShader(Handle, FragmentShader);
            
            // 連結著色器程式
            GL.LinkProgram(Handle);

            // 分離著色器
            GL.DetachShader(Handle, VertexShader);
            GL.DetachShader(Handle, FragmentShader);

            // 刪除著色器
            GL.DeleteShader(VertexShader);
            GL.DeleteShader(FragmentShader);
        }

        ~Shader()
        {
            GL.DeleteProgram(Handle);
        }

        public void Use()
        {
            GL.UseProgram(Handle);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                GL.DeleteProgram(Handle);
                disposedValue = true;
            }
        }
    }
}
