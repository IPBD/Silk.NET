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
    [Extension("EXT_direct_state_access")]
    public abstract unsafe partial class ExtDirectStateAccess : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindMultiTextureEXT")]
        public abstract void BindMultiTexture([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatusEXT")]
        public abstract EXT CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT")]
        public abstract unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT")]
        public abstract void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT")]
        public abstract unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT")]
        public abstract void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClientAttribDefaultEXT")]
        public abstract void ClientAttribDefault([Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT")]
        public abstract unsafe void CompressedMultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT")]
        public abstract void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT")]
        public abstract unsafe void CompressedMultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT")]
        public abstract void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT")]
        public abstract unsafe void CompressedMultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT")]
        public abstract void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT")]
        public abstract unsafe void CompressedMultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT")]
        public abstract void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT")]
        public abstract unsafe void CompressedMultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT")]
        public abstract void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT")]
        public abstract unsafe void CompressedMultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT")]
        public abstract void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT")]
        public abstract unsafe void CompressedTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT")]
        public abstract void CompressedTextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT")]
        public abstract unsafe void CompressedTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT")]
        public abstract void CompressedTextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT")]
        public abstract unsafe void CompressedTextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT")]
        public abstract void CompressedTextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT")]
        public abstract unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT")]
        public abstract void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT")]
        public abstract unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT")]
        public abstract void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT")]
        public abstract unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT")]
        public abstract void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT")]
        public abstract void CopyMultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT")]
        public abstract void CopyMultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyMultiTexSubImage1DEXT")]
        public abstract void CopyMultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyMultiTexSubImage2DEXT")]
        public abstract void CopyMultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyMultiTexSubImage3DEXT")]
        public abstract void CopyMultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureImage1DEXT")]
        public abstract void CopyTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureImage2DEXT")]
        public abstract void CopyTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureSubImage1DEXT")]
        public abstract void CopyTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureSubImage2DEXT")]
        public abstract void CopyTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureSubImage3DEXT")]
        public abstract void CopyTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableClientStateiEXT")]
        public abstract void DisableClientState([Flow(FlowDirection.In)] EXT array, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableClientStateIndexedEXT")]
        public abstract void DisableClientStateIndexed([Flow(FlowDirection.In)] EXT array, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableIndexedEXT")]
        public abstract void DisableIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableVertexArrayEXT")]
        public abstract void DisableVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT array);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableVertexArrayAttribEXT")]
        public abstract void DisableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableClientStateiEXT")]
        public abstract void EnableClientState([Flow(FlowDirection.In)] EXT array, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableClientStateIndexedEXT")]
        public abstract void EnableClientStateIndexed([Flow(FlowDirection.In)] EXT array, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableIndexedEXT")]
        public abstract void EnableIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableVertexArrayEXT")]
        public abstract void EnableVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT array);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableVertexArrayAttribEXT")]
        public abstract void EnableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFlushMappedNamedBufferRangeEXT")]
        public abstract void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferDrawBufferEXT")]
        public abstract void FramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT")]
        public abstract unsafe void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] EXT* bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT")]
        public abstract void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<EXT> bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferReadBufferEXT")]
        public abstract void FramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenerateMultiTexMipmapEXT")]
        public abstract void GenerateMultiTexMipmap([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenerateTextureMipmapEXT")]
        public abstract void GenerateTextureMipmap([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public abstract unsafe void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public abstract void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT")]
        public abstract unsafe void GetCompressedMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT")]
        public abstract void GetCompressedMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT")]
        public abstract unsafe void GetCompressedTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT")]
        public abstract void GetCompressedTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDoublei_vEXT")]
        public abstract unsafe void GetDouble([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDoublei_vEXT")]
        public abstract void GetDouble([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDoubleIndexedvEXT")]
        public abstract unsafe void GetDoubleIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] double* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDoubleIndexedvEXT")]
        public abstract void GetDoubleIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out double data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFloati_vEXT")]
        public abstract unsafe void GetFloat([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFloati_vEXT")]
        public abstract void GetFloat([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFloatIndexedvEXT")]
        public abstract unsafe void GetFloatIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFloatIndexedvEXT")]
        public abstract void GetFloatIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT")]
        public abstract unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT")]
        public abstract void GetFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT")]
        public abstract unsafe void GetIntegerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT")]
        public abstract void GetIntegerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT")]
        public abstract unsafe void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT")]
        public abstract void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT")]
        public abstract unsafe void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT")]
        public abstract void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT")]
        public abstract unsafe void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT")]
        public abstract void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT")]
        public abstract unsafe void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT")]
        public abstract void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT")]
        public abstract unsafe void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT")]
        public abstract void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexImageEXT")]
        public abstract unsafe void GetMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexImageEXT")]
        public abstract void GetMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT")]
        public abstract unsafe void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT")]
        public abstract void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT")]
        public abstract unsafe void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT")]
        public abstract void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT")]
        public abstract unsafe void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT")]
        public abstract void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT")]
        public abstract unsafe void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT")]
        public abstract void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT")]
        public abstract unsafe void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT")]
        public abstract void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT")]
        public abstract unsafe void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT")]
        public abstract void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT")]
        public abstract unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT")]
        public abstract unsafe void GetNamedBufferPointer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferSubDataEXT")]
        public abstract unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.Out)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferSubDataEXT")]
        public abstract void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT")]
        public abstract unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT")]
        public abstract void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT")]
        public abstract unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT")]
        public abstract void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramivEXT")]
        public abstract unsafe void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramivEXT")]
        public abstract void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT")]
        public abstract unsafe void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT")]
        public abstract void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT")]
        public abstract unsafe void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT")]
        public abstract void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT")]
        public abstract unsafe void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT")]
        public abstract void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT")]
        public abstract unsafe void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT")]
        public abstract void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT")]
        public abstract unsafe void GetNamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] void* @string);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT")]
        public abstract void GetNamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] out T0 @string) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT")]
        public abstract unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT")]
        public abstract void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPointeri_vEXT")]
        public abstract unsafe void GetPointer([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPointeri_vEXT")]
        public abstract unsafe void GetPointer<T0>([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPointerIndexedvEXT")]
        public abstract unsafe void GetPointerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] void** data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPointerIndexedvEXT")]
        public abstract unsafe void GetPointerIndexed<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureImageEXT")]
        public abstract unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureImageEXT")]
        public abstract void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterivEXT")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterivEXT")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT")]
        public abstract unsafe void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT")]
        public abstract void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT")]
        public abstract unsafe void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT")]
        public abstract void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT")]
        public abstract unsafe void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT")]
        public abstract unsafe void GetVertexArrayPointer<T0>([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* param) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayPointeri_vEXT")]
        public abstract unsafe void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] void** param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT")]
        public abstract bool IsEnabledIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapNamedBufferEXT")]
        public abstract unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapNamedBufferRangeEXT")]
        public abstract unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixFrustumEXT")]
        public abstract void MatrixFrustum([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        public abstract unsafe void MatrixLoad([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        public abstract void MatrixLoad([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        public abstract unsafe void MatrixLoad([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        public abstract void MatrixLoad([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT")]
        public abstract void MatrixLoadIdentity([Flow(FlowDirection.In)] EXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        public abstract unsafe void MatrixLoadTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        public abstract void MatrixLoadTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        public abstract unsafe void MatrixLoadTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        public abstract void MatrixLoadTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        public abstract unsafe void MatrixMult([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        public abstract void MatrixMult([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        public abstract unsafe void MatrixMult([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        public abstract void MatrixMult([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        public abstract unsafe void MatrixMultTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        public abstract void MatrixMultTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        public abstract unsafe void MatrixMultTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        public abstract void MatrixMultTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixOrthoEXT")]
        public abstract void MatrixOrtho([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixPopEXT")]
        public abstract void MatrixPop([Flow(FlowDirection.In)] EXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixPushEXT")]
        public abstract void MatrixPush([Flow(FlowDirection.In)] EXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixRotatefEXT")]
        public abstract void MatrixRotate([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixRotatedEXT")]
        public abstract void MatrixRotate([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixScalefEXT")]
        public abstract void MatrixScale([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixScaledEXT")]
        public abstract void MatrixScale([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixTranslatefEXT")]
        public abstract void MatrixTranslate([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixTranslatedEXT")]
        public abstract void MatrixTranslate([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexBufferEXT")]
        public abstract void MultiTexBuffer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT")]
        public abstract unsafe void MultiTexCoordPointer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT")]
        public abstract void MultiTexCoordPointer<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexEnvfEXT")]
        public abstract void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT")]
        public abstract unsafe void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT")]
        public abstract void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexEnviEXT")]
        public abstract void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexEnvivEXT")]
        public abstract unsafe void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexEnvivEXT")]
        public abstract void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGendvEXT")]
        public abstract unsafe void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGendvEXT")]
        public abstract void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref double @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGenfEXT")]
        public abstract void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGenfvEXT")]
        public abstract unsafe void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGenfvEXT")]
        public abstract void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGeniEXT")]
        public abstract void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGenivEXT")]
        public abstract unsafe void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGenivEXT")]
        public abstract void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGendEXT")]
        public abstract void MultiTexGend([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] double param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexImage1DEXT")]
        public abstract unsafe void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexImage1DEXT")]
        public abstract void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexImage2DEXT")]
        public abstract unsafe void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexImage2DEXT")]
        public abstract void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexImage3DEXT")]
        public abstract unsafe void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexImage3DEXT")]
        public abstract void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameteriEXT")]
        public abstract void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterivEXT")]
        public abstract unsafe void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterivEXT")]
        public abstract void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterfEXT")]
        public abstract void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT")]
        public abstract unsafe void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT")]
        public abstract void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT")]
        public abstract unsafe void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT")]
        public abstract void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT")]
        public abstract unsafe void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT")]
        public abstract void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexRenderbufferEXT")]
        public abstract void MultiTexRenderbuffer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT")]
        public abstract unsafe void MultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT")]
        public abstract void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT")]
        public abstract unsafe void MultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT")]
        public abstract void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT")]
        public abstract unsafe void MultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT")]
        public abstract void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferDataEXT")]
        public abstract unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] EXT usage);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferDataEXT")]
        public abstract void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data, [Flow(FlowDirection.In)] EXT usage) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferStorageEXT")]
        public abstract unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferStorageEXT")]
        public abstract void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferSubDataEXT")]
        public abstract unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferSubDataEXT")]
        public abstract void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedCopyBufferSubDataEXT")]
        public abstract void NamedCopyBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferParameteriEXT")]
        public abstract void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferRenderbufferEXT")]
        public abstract void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTextureEXT")]
        public abstract void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTexture1DEXT")]
        public abstract void NamedFramebufferTexture1D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTexture2DEXT")]
        public abstract void NamedFramebufferTexture2D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTexture3DEXT")]
        public abstract void NamedFramebufferTexture3D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTextureFaceEXT")]
        public abstract void NamedFramebufferTextureFace([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT face);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayerEXT")]
        public abstract void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dEXT")]
        public abstract void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT")]
        public abstract unsafe void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT")]
        public abstract void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fEXT")]
        public abstract void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT")]
        public abstract unsafe void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT")]
        public abstract void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4iEXT")]
        public abstract void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT")]
        public abstract unsafe void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT")]
        public abstract void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uiEXT")]
        public abstract void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT")]
        public abstract unsafe void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT")]
        public abstract void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT")]
        public abstract unsafe void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT")]
        public abstract void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT")]
        public abstract unsafe void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT")]
        public abstract void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT")]
        public abstract unsafe void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT")]
        public abstract void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramStringEXT")]
        public abstract unsafe void NamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramStringEXT")]
        public abstract void NamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] Span<T0> @string) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageEXT")]
        public abstract void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleEXT")]
        public abstract void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleCoverageEXT")]
        public abstract void NamedRenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1fEXT")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1iEXT")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1fvEXT")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1fvEXT")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1ivEXT")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1ivEXT")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1uiEXT")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1uivEXT")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1uivEXT")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1dEXT")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1dvEXT")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1dvEXT")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2fEXT")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2iEXT")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2fvEXT")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2fvEXT")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2ivEXT")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2ivEXT")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2uiEXT")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2uivEXT")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2uivEXT")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2dEXT")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2dvEXT")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2dvEXT")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3fEXT")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3iEXT")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3fvEXT")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3fvEXT")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3ivEXT")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3ivEXT")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3uiEXT")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3uivEXT")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3uivEXT")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3dEXT")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3dvEXT")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3dvEXT")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4fEXT")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4iEXT")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4fvEXT")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4fvEXT")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4ivEXT")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4ivEXT")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4uiEXT")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4uivEXT")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4uivEXT")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4dEXT")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4dvEXT")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4dvEXT")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2fvEXT")]
        public abstract unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2fvEXT")]
        public abstract void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2dvEXT")]
        public abstract unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2dvEXT")]
        public abstract void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fvEXT")]
        public abstract unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fvEXT")]
        public abstract void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dvEXT")]
        public abstract unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dvEXT")]
        public abstract void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fvEXT")]
        public abstract unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fvEXT")]
        public abstract void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dvEXT")]
        public abstract unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dvEXT")]
        public abstract void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3fvEXT")]
        public abstract unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3fvEXT")]
        public abstract void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3dvEXT")]
        public abstract unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3dvEXT")]
        public abstract void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fvEXT")]
        public abstract unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fvEXT")]
        public abstract void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dvEXT")]
        public abstract unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dvEXT")]
        public abstract void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fvEXT")]
        public abstract unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fvEXT")]
        public abstract void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dvEXT")]
        public abstract unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dvEXT")]
        public abstract void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4fvEXT")]
        public abstract unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4fvEXT")]
        public abstract void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4dvEXT")]
        public abstract unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4dvEXT")]
        public abstract void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fvEXT")]
        public abstract unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fvEXT")]
        public abstract void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dvEXT")]
        public abstract unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dvEXT")]
        public abstract void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fvEXT")]
        public abstract unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fvEXT")]
        public abstract void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dvEXT")]
        public abstract unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dvEXT")]
        public abstract void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPushClientAttribDefaultEXT")]
        public abstract void PushClientAttribDefault([Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBufferEXT")]
        public abstract void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBufferRangeEXT")]
        public abstract void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage1DEXT")]
        public abstract unsafe void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage1DEXT")]
        public abstract void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage2DEXT")]
        public abstract unsafe void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage2DEXT")]
        public abstract void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage3DEXT")]
        public abstract unsafe void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage3DEXT")]
        public abstract void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexturePageCommitmentEXT")]
        public abstract void TexturePageCommitment([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool commit);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfEXT")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfvEXT")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfvEXT")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteriEXT")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterivEXT")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterivEXT")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIivEXT")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIivEXT")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIuivEXT")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIuivEXT")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureRenderbufferEXT")]
        public abstract void TextureRenderbuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage1DEXT")]
        public abstract void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2DEXT")]
        public abstract void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT")]
        public abstract void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3DEXT")]
        public abstract void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3DMultisampleEXT")]
        public abstract void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage1DEXT")]
        public abstract unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage1DEXT")]
        public abstract void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage2DEXT")]
        public abstract unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage2DEXT")]
        public abstract void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage3DEXT")]
        public abstract unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage3DEXT")]
        public abstract void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUnmapNamedBufferEXT")]
        public abstract bool UnmapNamedBuffer([Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayBindVertexBufferEXT")]
        public abstract void VertexArrayBindVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayColorOffsetEXT")]
        public abstract void VertexArrayColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayEdgeFlagOffsetEXT")]
        public abstract void VertexArrayEdgeFlagOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayFogCoordOffsetEXT")]
        public abstract void VertexArrayFogCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayIndexOffsetEXT")]
        public abstract void VertexArrayIndexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayMultiTexCoordOffsetEXT")]
        public abstract void VertexArrayMultiTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayNormalOffsetEXT")]
        public abstract void VertexArrayNormalOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArraySecondaryColorOffsetEXT")]
        public abstract void VertexArraySecondaryColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayTexCoordOffsetEXT")]
        public abstract void VertexArrayTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribBindingEXT")]
        public abstract void VertexArrayVertexAttribBinding([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribDivisorEXT")]
        public abstract void VertexArrayVertexAttribDivisor([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribFormatEXT")]
        public abstract void VertexArrayVertexAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIFormatEXT")]
        public abstract void VertexArrayVertexAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIOffsetEXT")]
        public abstract void VertexArrayVertexAttribIOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLFormatEXT")]
        public abstract void VertexArrayVertexAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLOffsetEXT")]
        public abstract void VertexArrayVertexAttribLOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribOffsetEXT")]
        public abstract void VertexArrayVertexAttribOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexBindingDivisorEXT")]
        public abstract void VertexArrayVertexBindingDivisor([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexOffsetEXT")]
        public abstract void VertexArrayVertexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindMultiTextureEXT")]
        public abstract void BindMultiTexture([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatusEXT")]
        public abstract EXT CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferTarget target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT")]
        public abstract unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT")]
        public abstract void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT")]
        public abstract unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT")]
        public abstract void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] UIntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT")]
        public abstract unsafe void CompressedMultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT")]
        public abstract void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT")]
        public abstract unsafe void CompressedMultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT")]
        public abstract void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT")]
        public abstract unsafe void CompressedMultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT")]
        public abstract void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT")]
        public abstract unsafe void CompressedMultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT")]
        public abstract void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT")]
        public abstract unsafe void CompressedMultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT")]
        public abstract void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT")]
        public abstract unsafe void CompressedMultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT")]
        public abstract void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT")]
        public abstract unsafe void CompressedTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT")]
        public abstract void CompressedTextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT")]
        public abstract unsafe void CompressedTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT")]
        public abstract void CompressedTextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT")]
        public abstract unsafe void CompressedTextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT")]
        public abstract void CompressedTextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT")]
        public abstract unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT")]
        public abstract void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT")]
        public abstract unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT")]
        public abstract void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT")]
        public abstract unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT")]
        public abstract void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> bits) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT")]
        public abstract void CopyMultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT")]
        public abstract void CopyMultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyMultiTexSubImage1DEXT")]
        public abstract void CopyMultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyMultiTexSubImage2DEXT")]
        public abstract void CopyMultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyMultiTexSubImage3DEXT")]
        public abstract void CopyMultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureImage1DEXT")]
        public abstract void CopyTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureImage2DEXT")]
        public abstract void CopyTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureSubImage1DEXT")]
        public abstract void CopyTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureSubImage2DEXT")]
        public abstract void CopyTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureSubImage3DEXT")]
        public abstract void CopyTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableClientStateiEXT")]
        public abstract void DisableClientState([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableClientStateIndexedEXT")]
        public abstract void DisableClientStateIndexed([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableIndexedEXT")]
        public abstract void DisableIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableVertexArrayEXT")]
        public abstract void DisableVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EnableCap array);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableClientStateiEXT")]
        public abstract void EnableClientState([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableClientStateIndexedEXT")]
        public abstract void EnableClientStateIndexed([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableIndexedEXT")]
        public abstract void EnableIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableVertexArrayEXT")]
        public abstract void EnableVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EnableCap array);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferDrawBufferEXT")]
        public abstract void FramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] DrawBufferMode mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT")]
        public abstract unsafe void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] DrawBufferMode* bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT")]
        public abstract void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<DrawBufferMode> bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferReadBufferEXT")]
        public abstract void FramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ReadBufferMode mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenerateMultiTexMipmapEXT")]
        public abstract void GenerateMultiTexMipmap([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenerateTextureMipmapEXT")]
        public abstract void GenerateTextureMipmap([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public abstract unsafe void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public abstract void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT")]
        public abstract unsafe void GetCompressedMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT")]
        public abstract void GetCompressedMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT")]
        public abstract unsafe void GetCompressedTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT")]
        public abstract void GetCompressedTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT")]
        public abstract unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT")]
        public abstract void GetFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT")]
        public abstract unsafe void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT")]
        public abstract void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT")]
        public abstract unsafe void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT")]
        public abstract void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT")]
        public abstract unsafe void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT")]
        public abstract void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT")]
        public abstract unsafe void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT")]
        public abstract void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT")]
        public abstract unsafe void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT")]
        public abstract void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexImageEXT")]
        public abstract unsafe void GetMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexImageEXT")]
        public abstract void GetMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT")]
        public abstract unsafe void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT")]
        public abstract void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT")]
        public abstract unsafe void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT")]
        public abstract void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT")]
        public abstract unsafe void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT")]
        public abstract void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT")]
        public abstract unsafe void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT")]
        public abstract void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT")]
        public abstract unsafe void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT")]
        public abstract void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT")]
        public abstract unsafe void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT")]
        public abstract void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT")]
        public abstract unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT")]
        public abstract unsafe void GetNamedBufferPointer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT")]
        public abstract unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT")]
        public abstract void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT")]
        public abstract unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT")]
        public abstract void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramivEXT")]
        public abstract unsafe void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramivEXT")]
        public abstract void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT")]
        public abstract unsafe void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT")]
        public abstract void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT")]
        public abstract unsafe void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT")]
        public abstract void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT")]
        public abstract unsafe void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT")]
        public abstract void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT")]
        public abstract unsafe void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT")]
        public abstract void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT")]
        public abstract unsafe void GetNamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] void* @string);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT")]
        public abstract void GetNamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] out T0 @string) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT")]
        public abstract unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT")]
        public abstract void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureImageEXT")]
        public abstract unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureImageEXT")]
        public abstract void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterivEXT")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterivEXT")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT")]
        public abstract unsafe void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT")]
        public abstract void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT")]
        public abstract unsafe void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT")]
        public abstract void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT")]
        public abstract unsafe void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT")]
        public abstract unsafe void GetVertexArrayPointer<T0>([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* param) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayPointeri_vEXT")]
        public abstract unsafe void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] void** param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT")]
        public abstract bool IsEnabledIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapNamedBufferEXT")]
        public abstract unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferAccessARB access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixFrustumEXT")]
        public abstract void MatrixFrustum([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        public abstract unsafe void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        public abstract void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        public abstract unsafe void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        public abstract void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT")]
        public abstract void MatrixLoadIdentity([Flow(FlowDirection.In)] MatrixMode mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        public abstract unsafe void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        public abstract void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        public abstract unsafe void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        public abstract void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        public abstract unsafe void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        public abstract void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        public abstract unsafe void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        public abstract void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        public abstract unsafe void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        public abstract void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        public abstract unsafe void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        public abstract void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixOrthoEXT")]
        public abstract void MatrixOrtho([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixPopEXT")]
        public abstract void MatrixPop([Flow(FlowDirection.In)] MatrixMode mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixPushEXT")]
        public abstract void MatrixPush([Flow(FlowDirection.In)] MatrixMode mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixRotatefEXT")]
        public abstract void MatrixRotate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixRotatedEXT")]
        public abstract void MatrixRotate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixScalefEXT")]
        public abstract void MatrixScale([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixScaledEXT")]
        public abstract void MatrixScale([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixTranslatefEXT")]
        public abstract void MatrixTranslate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMatrixTranslatedEXT")]
        public abstract void MatrixTranslate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexBufferEXT")]
        public abstract void MultiTexBuffer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT")]
        public abstract unsafe void MultiTexCoordPointer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT")]
        public abstract void MultiTexCoordPointer<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexEnvfEXT")]
        public abstract void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT")]
        public abstract unsafe void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT")]
        public abstract void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexEnviEXT")]
        public abstract void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexEnvivEXT")]
        public abstract unsafe void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexEnvivEXT")]
        public abstract void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGendvEXT")]
        public abstract unsafe void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGendvEXT")]
        public abstract void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref double @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGenfEXT")]
        public abstract void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGenfvEXT")]
        public abstract unsafe void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGenfvEXT")]
        public abstract void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGeniEXT")]
        public abstract void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGenivEXT")]
        public abstract unsafe void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGenivEXT")]
        public abstract void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexGendEXT")]
        public abstract void MultiTexGend([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] double param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexImage1DEXT")]
        public abstract unsafe void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexImage1DEXT")]
        public abstract void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexImage2DEXT")]
        public abstract unsafe void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexImage2DEXT")]
        public abstract void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexImage3DEXT")]
        public abstract unsafe void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexImage3DEXT")]
        public abstract void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameteriEXT")]
        public abstract void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterivEXT")]
        public abstract unsafe void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterivEXT")]
        public abstract void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterfEXT")]
        public abstract void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT")]
        public abstract unsafe void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT")]
        public abstract void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT")]
        public abstract unsafe void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT")]
        public abstract void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT")]
        public abstract unsafe void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT")]
        public abstract void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexRenderbufferEXT")]
        public abstract void MultiTexRenderbuffer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT")]
        public abstract unsafe void MultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT")]
        public abstract void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT")]
        public abstract unsafe void MultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT")]
        public abstract void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT")]
        public abstract unsafe void MultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT")]
        public abstract void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferDataEXT")]
        public abstract unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferDataEXT")]
        public abstract void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferParameteriEXT")]
        public abstract void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferRenderbufferEXT")]
        public abstract void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTextureEXT")]
        public abstract void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTexture1DEXT")]
        public abstract void NamedFramebufferTexture1D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTexture2DEXT")]
        public abstract void NamedFramebufferTexture2D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTexture3DEXT")]
        public abstract void NamedFramebufferTexture3D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTextureFaceEXT")]
        public abstract void NamedFramebufferTextureFace([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] TextureTarget face);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayerEXT")]
        public abstract void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dEXT")]
        public abstract void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT")]
        public abstract unsafe void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT")]
        public abstract void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fEXT")]
        public abstract void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT")]
        public abstract unsafe void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT")]
        public abstract void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4iEXT")]
        public abstract void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT")]
        public abstract unsafe void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT")]
        public abstract void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uiEXT")]
        public abstract void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT")]
        public abstract unsafe void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT")]
        public abstract void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT")]
        public abstract unsafe void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT")]
        public abstract void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT")]
        public abstract unsafe void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT")]
        public abstract void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT")]
        public abstract unsafe void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT")]
        public abstract void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramStringEXT")]
        public abstract unsafe void NamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedProgramStringEXT")]
        public abstract void NamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] Span<T0> @string) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageEXT")]
        public abstract void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleEXT")]
        public abstract void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleCoverageEXT")]
        public abstract void NamedRenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBufferEXT")]
        public abstract void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBufferRangeEXT")]
        public abstract void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage1DEXT")]
        public abstract unsafe void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage1DEXT")]
        public abstract void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage2DEXT")]
        public abstract unsafe void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage2DEXT")]
        public abstract void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage3DEXT")]
        public abstract unsafe void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureImage3DEXT")]
        public abstract void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfEXT")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfvEXT")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfvEXT")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteriEXT")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterivEXT")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterivEXT")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIivEXT")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIivEXT")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIuivEXT")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIuivEXT")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureRenderbufferEXT")]
        public abstract void TextureRenderbuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage1DEXT")]
        public abstract void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2DEXT")]
        public abstract void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT")]
        public abstract void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3DEXT")]
        public abstract void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3DMultisampleEXT")]
        public abstract void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage1DEXT")]
        public abstract unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage1DEXT")]
        public abstract void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage2DEXT")]
        public abstract unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage2DEXT")]
        public abstract void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage3DEXT")]
        public abstract unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage3DEXT")]
        public abstract void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayColorOffsetEXT")]
        public abstract void VertexArrayColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayFogCoordOffsetEXT")]
        public abstract void VertexArrayFogCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] FogCoordinatePointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayIndexOffsetEXT")]
        public abstract void VertexArrayIndexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayMultiTexCoordOffsetEXT")]
        public abstract void VertexArrayMultiTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayNormalOffsetEXT")]
        public abstract void VertexArrayNormalOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArraySecondaryColorOffsetEXT")]
        public abstract void VertexArraySecondaryColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayTexCoordOffsetEXT")]
        public abstract void VertexArrayTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribFormatEXT")]
        public abstract void VertexArrayVertexAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIFormatEXT")]
        public abstract void VertexArrayVertexAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIOffsetEXT")]
        public abstract void VertexArrayVertexAttribIOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLFormatEXT")]
        public abstract void VertexArrayVertexAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLOffsetEXT")]
        public abstract void VertexArrayVertexAttribLOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexAttribOffsetEXT")]
        public abstract void VertexArrayVertexAttribOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexOffsetEXT")]
        public abstract void VertexArrayVertexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] IntPtr offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from format and type.
        /// </param>
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new UIntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from format and type.
        /// </param>
        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new UIntPtr(offset), new UIntPtr(size), format, type, ref data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        public unsafe void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        public unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        public unsafe void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), out data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        public unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length), access);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] EXT usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data, [Flow(FlowDirection.In)] EXT usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), ref data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        public unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        public unsafe void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), ref data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readBuffer">
        /// To be added.
        /// </param>
        /// <param name="writeBuffer">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void NamedCopyBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            NamedCopyBufferSubData(readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayBindVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            VertexArrayBindVertexBuffer(vaobj, bindingindex, buffer, new IntPtr(offset), stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayColorOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayEdgeFlagOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayEdgeFlagOffset(vaobj, buffer, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayFogCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayFogCoordOffset(vaobj, buffer, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayIndexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayIndexOffset(vaobj, buffer, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayMultiTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayMultiTexCoordOffset(vaobj, buffer, texunit, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayNormalOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayNormalOffset(vaobj, buffer, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArraySecondaryColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArraySecondaryColorOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayTexCoordOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayVertexAttribIOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexAttribIOffset(vaobj, buffer, index, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayVertexAttribLOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexAttribLOffset(vaobj, buffer, index, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayVertexAttribOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexAttribOffset(vaobj, buffer, index, size, type, normalized, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayVertexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from format and type.
        /// </param>
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new UIntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from format and type.
        /// </param>
        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new UIntPtr(offset), new UIntPtr(size), format, type, ref data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), ref data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayColorOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayFogCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] FogCoordinatePointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayFogCoordOffset(vaobj, buffer, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayIndexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayIndexOffset(vaobj, buffer, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="texunit">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayMultiTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayMultiTexCoordOffset(vaobj, buffer, texunit, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayNormalOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayNormalOffset(vaobj, buffer, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArraySecondaryColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArraySecondaryColorOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayTexCoordOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayVertexAttribIOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexAttribIOffset(vaobj, buffer, index, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayVertexAttribLOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexAttribLOffset(vaobj, buffer, index, size, type, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayVertexAttribOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexAttribOffset(vaobj, buffer, index, size, type, normalized, stride, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayVertexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            VertexArrayVertexOffset(vaobj, buffer, size, type, stride, new IntPtr(offset));
        }

        public ExtDirectStateAccess(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

