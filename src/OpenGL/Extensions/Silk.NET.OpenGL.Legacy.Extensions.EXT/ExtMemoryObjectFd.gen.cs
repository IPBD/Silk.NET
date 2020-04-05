// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_memory_object_fd")]
    public abstract unsafe partial class ExtMemoryObjectFd : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glImportMemoryFdEXT")]
        public abstract void ImportMemoryF([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] int fd);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glImportMemoryFdEXT")]
        public abstract void ImportMemoryF([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] int fd);

        public ExtMemoryObjectFd(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

