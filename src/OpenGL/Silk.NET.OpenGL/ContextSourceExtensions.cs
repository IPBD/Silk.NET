// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Contexts;

namespace Silk.NET.OpenGL
{
    public static class ContextSourceExtensions
    {
        public static GL CreateOpenGL(this IGLContextSource src) => GL.GetApi(src);
    }
}
