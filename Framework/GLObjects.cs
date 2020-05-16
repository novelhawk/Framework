using System;
using OpenToolkit.Graphics.OpenGL4;

namespace Framework
{
    public class GLObjects
    {
        private int _vertexBuffer = -1;
        private int _elementBuffer = -1;
        private int _colorBuffer = -1;
        private int _textureBuffer = -1;
        private int _vertexArray = -1;

        public GLObjects()
        {
        }
        
        public GLObjects(GLObject glObject)
        {
            if ((glObject & GLObject.VertexBuffer) != 0)
                CreateVertexBuffer();
            if ((glObject & GLObject.ElementBuffer) != 0)
                CreateElementBuffer();
            if ((glObject & GLObject.ColorBuffer) != 0)
                CreateColorBuffer();
            if ((glObject & GLObject.TextureBuffer) != 0)
                CreateTextureBuffer();
            if ((glObject & GLObject.VertexArray) != 0)
                CreateVertexArray();
        }

        public int VertexBuffer
        {
            get
            {
                if (_vertexBuffer == -1)
                    throw new Exception("Accessing nonexistent buffer");
                return _vertexBuffer;
            }
        }

        public int ColorBuffer
        {
            get
            {
                if (_colorBuffer == -1)
                    throw new Exception("Accessing nonexistent buffer");
                return _colorBuffer;
            }
        }

        public int ElementBuffer
        {
            get
            {
                if (_elementBuffer == -1)
                    throw new Exception("Accessing nonexistent buffer");
                return _elementBuffer;
            }
        }

        public int TextureBuffer
        {
            get
            {
                if (_textureBuffer == -1)
                    throw new Exception("Accessing nonexistent buffer");
                return _textureBuffer;
            }
        }

        public int VertexArray
        {
            get
            {
                if (_vertexArray == -1)
                    throw new Exception("Accessing nonexistent buffer");
                return _vertexArray;
            }
        }

        public void CreateVertexBuffer()
        {
            _vertexBuffer = GL.GenBuffer();
        }

        public void CreateElementBuffer()
        {
            _elementBuffer = GL.GenBuffer();
        }

        public void CreateColorBuffer()
        {
            _colorBuffer = GL.GenBuffer();
        }

        public void CreateTextureBuffer()
        {
            _textureBuffer = GL.GenBuffer();
        }

        public void CreateVertexArray()
        {
            _vertexArray = GL.GenVertexArray();
        }
    }

    [Flags]
    public enum GLObject
    {
        VertexBuffer = 1 << 1,
        ElementBuffer = 1 << 2,
        ColorBuffer = 1 << 3,
        TextureBuffer = 1 << 4,
        VertexArray = 1 << 5,

        VBO = VertexBuffer,
        EBO = ElementBuffer,
        CBO = ColorBuffer,
        TBO = TextureBuffer,
        VAO = VertexArray,

        VertexElement = VBO | EBO,
        VertElementsCol = VBO | EBO | CBO
}
}
