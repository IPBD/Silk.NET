// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_transform_feedback2")]
    public abstract unsafe partial class ArbTransformFeedback2 : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        public abstract void BindTransformFeedback([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public abstract unsafe void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public abstract void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawTransformFeedback")]
        public abstract void DrawTransformFeedback([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public abstract unsafe void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public abstract void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsTransformFeedback")]
        public abstract bool IsTransformFeedback([Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPauseTransformFeedback")]
        public abstract void PauseTransformFeedback();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glResumeTransformFeedback")]
        public abstract void ResumeTransformFeedback();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        public abstract void BindTransformFeedback([Flow(FlowDirection.In)] BindTransformFeedbackTarget target, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawTransformFeedback")]
        public abstract void DrawTransformFeedback([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteTransformFeedback([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteTransformFeedbacks(1, &ids);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTransformFeedbacks(n, &ret);
            return ret;
        }

        public ArbTransformFeedback2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

