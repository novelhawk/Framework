using System;
using OpenToolkit.Graphics.OpenGL4;

namespace Framework
{
    public class GLObjects
    {
        private GLHandle _vertexBuffer = GLHandle.MinusOne;
        private GLHandle _elementBuffer = GLHandle.MinusOne;
        private GLHandle _colorBuffer = GLHandle.MinusOne;
        private GLHandle _textureBuffer = GLHandle.MinusOne;
        private GLHandle _vertexArray = GLHandle.MinusOne;

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
                if (_vertexBuffer == GLHandle.MinusOne)
                    throw new Exception("Accessing nonexistent buffer");
                return _vertexBuffer;
            }
        }

        public int ColorBuffer
        {
            get
            {
                if (_colorBuffer == GLHandle.MinusOne)
                    throw new Exception("Accessing nonexistent buffer");
                return _colorBuffer;
            }
        }

        public int ElementBuffer
        {
            get
            {
                if (_elementBuffer == GLHandle.MinusOne)
                    throw new Exception("Accessing nonexistent buffer");
                return _elementBuffer;
            }
        }

        public int TextureBuffer
        {
            get
            {
                if (_textureBuffer == GLHandle.MinusOne)
                    throw new Exception("Accessing nonexistent buffer");
                return _textureBuffer;
            }
        }

        public int VertexArray
        {
            get
            {
                if (_vertexArray == GLHandle.MinusOne)
                    throw new Exception("Accessing nonexistent buffer");
                return _vertexArray;
            }
        }

        public void CreateVertexBuffer()
        {
            _vertexBuffer = (GLHandle) GL.GenBuffer();
        }

        public void CreateElementBuffer()
        {
            _elementBuffer = (GLHandle) GL.GenBuffer();
        }

        public void CreateColorBuffer()
        {
            _colorBuffer = (GLHandle) GL.GenBuffer();
        }

        public void CreateTextureBuffer()
        {
            _textureBuffer = (GLHandle) GL.GenBuffer();
        }

        public void CreateVertexArray()
        {
            _vertexArray = (GLHandle) GL.GenVertexArray();
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
