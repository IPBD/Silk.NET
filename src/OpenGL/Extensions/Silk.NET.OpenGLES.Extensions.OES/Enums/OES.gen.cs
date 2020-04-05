// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGLES.Extensions.OES
{
    public enum OES
    {
        Etc1Rgb8Oes = 0x8D64,
        Palette4Rgb8Oes = 0x8B90,
        Palette4Rgba8Oes = 0x8B91,
        Palette4R5G6B5Oes = 0x8B92,
        Palette4Rgba4Oes = 0x8B93,
        Palette4Rgb5A1Oes = 0x8B94,
        Palette8Rgb8Oes = 0x8B95,
        Palette8Rgba8Oes = 0x8B96,
        Palette8R5G6B5Oes = 0x8B97,
        Palette8Rgba4Oes = 0x8B98,
        Palette8Rgb5A1Oes = 0x8B99,
        DepthComponent24Oes = 0x81A6,
        DepthComponent32Oes = 0x81A7,
        DepthComponent = 0x1902,
        UnsignedShort = 0x1403,
        UnsignedInt = 0x1405,
        BlendEquationRgb = 0x8009,
        BlendEquationAlpha = 0x883D,
        BlendSrcRgb = 0x80C9,
        BlendSrcAlpha = 0x80CB,
        BlendDstRgb = 0x80C8,
        BlendDstAlpha = 0x80CA,
        ColorWritemask = 0xC23,
        Blend = 0xBE2,
        FuncAdd = 0x8006,
        FuncSubtract = 0x800A,
        FuncReverseSubtract = 0x800B,
        Min = 0x8007,
        Max = 0x8008,
        Zero = 0x0,
        One = 0x1,
        SrcColor = 0x300,
        OneMinusSrcColor = 0x301,
        DstColor = 0x306,
        OneMinusDstColor = 0x307,
        SrcAlpha = 0x302,
        OneMinusSrcAlpha = 0x303,
        DstAlpha = 0x304,
        OneMinusDstAlpha = 0x305,
        ConstantColor = 0x8001,
        OneMinusConstantColor = 0x8002,
        ConstantAlpha = 0x8003,
        OneMinusConstantAlpha = 0x8004,
        SrcAlphaSaturate = 0x308,
        TextureExternalOes = 0x8D65,
        TextureBindingExternalOes = 0x8D67,
        RequiredTextureImageUnitsOes = 0x8D68,
        SamplerExternalOes = 0x8D66,
        GeometryShaderOes = 0x8DD9,
        GeometryShaderBitOes = 0x4,
        GeometryLinkedVerticesOutOes = 0x8916,
        GeometryLinkedInputTypeOes = 0x8917,
        GeometryLinkedOutputTypeOes = 0x8918,
        GeometryShaderInvocationsOes = 0x887F,
        LayerProvokingVertexOes = 0x825E,
        LinesAdjacencyOes = 0xA,
        LineStripAdjacencyOes = 0xB,
        TrianglesAdjacencyOes = 0xC,
        TriangleStripAdjacencyOes = 0xD,
        MaxGeometryUniformComponentsOes = 0x8DDF,
        MaxGeometryUniformBlocksOes = 0x8A2C,
        MaxCombinedGeometryUniformComponentsOes = 0x8A32,
        MaxGeometryInputComponentsOes = 0x9123,
        MaxGeometryOutputComponentsOes = 0x9124,
        MaxGeometryOutputVerticesOes = 0x8DE0,
        MaxGeometryTotalOutputComponentsOes = 0x8DE1,
        MaxGeometryShaderInvocationsOes = 0x8E5A,
        MaxGeometryTextureImageUnitsOes = 0x8C29,
        MaxGeometryAtomicCounterBuffersOes = 0x92CF,
        MaxGeometryAtomicCountersOes = 0x92D5,
        MaxGeometryImageUniformsOes = 0x90CD,
        MaxGeometryShaderStorageBlocksOes = 0x90D7,
        FirstVertexConventionOes = 0x8E4D,
        LastVertexConventionOes = 0x8E4E,
        UndefinedVertexOes = 0x8260,
        PrimitivesGeneratedOes = 0x8C87,
        FramebufferDefaultLayersOes = 0x9312,
        MaxFramebufferLayersOes = 0x9317,
        FramebufferIncompleteLayerTargetsOes = 0x8DA8,
        FramebufferAttachmentLayeredOes = 0x8DA7,
        ReferencedByGeometryShaderOes = 0x9309,
        ProgramBinaryLengthOes = 0x8741,
        NumProgramBinaryFormatsOes = 0x87FE,
        ProgramBinaryFormatsOes = 0x87FF,
        WriteOnlyOes = 0x88B9,
        BufferAccessOes = 0x88BB,
        BufferMappedOes = 0x88BC,
        BufferMapPointerOes = 0x88BD,
        DepthStencilOes = 0x84F9,
        UnsignedInt248Oes = 0x84FA,
        Depth24Stencil8Oes = 0x88F0,
        PrimitiveBoundingBoxOes = 0x92BE,
        Alpha8Oes = 0x803C,
        DepthComponent16Oes = 0x81A5,
        Luminance4Alpha4Oes = 0x8043,
        Luminance8Alpha8Oes = 0x8045,
        Luminance8Oes = 0x8040,
        Rgba4Oes = 0x8056,
        Rgb5A1Oes = 0x8057,
        Rgb565Oes = 0x8D62,
        Rgb8Oes = 0x8051,
        Rgba8Oes = 0x8058,
        Rgb10Ext = 0x8052,
        Rgb10A2Ext = 0x8059,
        SampleShadingOes = 0x8C36,
        MinSampleShadingValueOes = 0x8C37,
        MinFragmentInterpolationOffsetOes = 0x8E5B,
        MaxFragmentInterpolationOffsetOes = 0x8E5C,
        FragmentInterpolationOffsetBitsOes = 0x8E5D,
        FragmentShaderDerivativeHintOes = 0x8B8B,
        StencilIndex1Oes = 0x8D46,
        StencilIndex4Oes = 0x8D47,
        FramebufferUndefinedOes = 0x8219,
        PatchesOes = 0xE,
        PatchVerticesOes = 0x8E72,
        TessControlOutputVerticesOes = 0x8E75,
        TessGenModeOes = 0x8E76,
        TessGenSpacingOes = 0x8E77,
        TessGenVertexOrderOes = 0x8E78,
        TessGenPointModeOes = 0x8E79,
        Triangles = 0x4,
        IsolinesOes = 0x8E7A,
        QuadsOes = 0x7,
        Equal = 0x202,
        FractionalOddOes = 0x8E7B,
        FractionalEvenOes = 0x8E7C,
        Ccw = 0x901,
        CW = 0x900,
        MaxPatchVerticesOes = 0x8E7D,
        MaxTessGenLevelOes = 0x8E7E,
        MaxTessControlUniformComponentsOes = 0x8E7F,
        MaxTessEvaluationUniformComponentsOes = 0x8E80,
        MaxTessControlTextureImageUnitsOes = 0x8E81,
        MaxTessEvaluationTextureImageUnitsOes = 0x8E82,
        MaxTessControlOutputComponentsOes = 0x8E83,
        MaxTessPatchComponentsOes = 0x8E84,
        MaxTessControlTotalOutputComponentsOes = 0x8E85,
        MaxTessEvaluationOutputComponentsOes = 0x8E86,
        MaxTessControlUniformBlocksOes = 0x8E89,
        MaxTessEvaluationUniformBlocksOes = 0x8E8A,
        MaxTessControlInputComponentsOes = 0x886C,
        MaxTessEvaluationInputComponentsOes = 0x886D,
        MaxCombinedTessControlUniformComponentsOes = 0x8E1E,
        MaxCombinedTessEvaluationUniformComponentsOes = 0x8E1F,
        MaxTessControlAtomicCounterBuffersOes = 0x92CD,
        MaxTessEvaluationAtomicCounterBuffersOes = 0x92CE,
        MaxTessControlAtomicCountersOes = 0x92D3,
        MaxTessEvaluationAtomicCountersOes = 0x92D4,
        MaxTessControlImageUniformsOes = 0x90CB,
        MaxTessEvaluationImageUniformsOes = 0x90CC,
        MaxTessControlShaderStorageBlocksOes = 0x90D8,
        MaxTessEvaluationShaderStorageBlocksOes = 0x90D9,
        PrimitiveRestartForPatchesSupportedOes = 0x8221,
        IsPerPatchOes = 0x92E7,
        ReferencedByTessControlShaderOes = 0x9307,
        ReferencedByTessEvaluationShaderOes = 0x9308,
        TessControlShaderOes = 0x8E88,
        TessEvaluationShaderOes = 0x8E87,
        TessControlShaderBitOes = 0x8,
        TessEvaluationShaderBitOes = 0x10,
        TextureWrapROes = 0x8072,
        Texture3DOes = 0x806F,
        TextureBinding3DOes = 0x806A,
        Max3DTextureSizeOes = 0x8073,
        Sampler3DOes = 0x8B5F,
        FramebufferAttachmentTexture3DZoffsetOes = 0x8CD4,
        TextureBorderColorOes = 0x1004,
        ClampToBorderOes = 0x812D,
        TextureBufferOes = 0x8C2A,
        TextureBufferBindingOes = 0x8C2A,
        MaxTextureBufferSizeOes = 0x8C2B,
        TextureBindingBufferOes = 0x8C2C,
        TextureBufferDataStoreBindingOes = 0x8C2D,
        TextureBufferOffsetAlignmentOes = 0x919F,
        SamplerBufferOes = 0x8DC2,
        IntSamplerBufferOes = 0x8DD0,
        UnsignedIntSamplerBufferOes = 0x8DD8,
        ImageBufferOes = 0x9051,
        IntImageBufferOes = 0x905C,
        UnsignedIntImageBufferOes = 0x9067,
        TextureBufferOffsetOes = 0x919D,
        TextureBufferSizeOes = 0x919E,
        CompressedRgbaAstc4x4Khr = 0x93B0,
        CompressedRgbaAstc5x4Khr = 0x93B1,
        CompressedRgbaAstc5x5Khr = 0x93B2,
        CompressedRgbaAstc6x5Khr = 0x93B3,
        CompressedRgbaAstc6x6Khr = 0x93B4,
        CompressedRgbaAstc8x5Khr = 0x93B5,
        CompressedRgbaAstc8x6Khr = 0x93B6,
        CompressedRgbaAstc8x8Khr = 0x93B7,
        CompressedRgbaAstc10x5Khr = 0x93B8,
        CompressedRgbaAstc10x6Khr = 0x93B9,
        CompressedRgbaAstc10x8Khr = 0x93BA,
        CompressedRgbaAstc10x10Khr = 0x93BB,
        CompressedRgbaAstc12x10Khr = 0x93BC,
        CompressedRgbaAstc12x12Khr = 0x93BD,
        CompressedSrgb8Alpha8Astc4x4Khr = 0x93D0,
        CompressedSrgb8Alpha8Astc5x4Khr = 0x93D1,
        CompressedSrgb8Alpha8Astc5x5Khr = 0x93D2,
        CompressedSrgb8Alpha8Astc6x5Khr = 0x93D3,
        CompressedSrgb8Alpha8Astc6x6Khr = 0x93D4,
        CompressedSrgb8Alpha8Astc8x5Khr = 0x93D5,
        CompressedSrgb8Alpha8Astc8x6Khr = 0x93D6,
        CompressedSrgb8Alpha8Astc8x8Khr = 0x93D7,
        CompressedSrgb8Alpha8Astc10x5Khr = 0x93D8,
        CompressedSrgb8Alpha8Astc10x6Khr = 0x93D9,
        CompressedSrgb8Alpha8Astc10x8Khr = 0x93DA,
        CompressedSrgb8Alpha8Astc10x10Khr = 0x93DB,
        CompressedSrgb8Alpha8Astc12x10Khr = 0x93DC,
        CompressedSrgb8Alpha8Astc12x12Khr = 0x93DD,
        CompressedRgbaAstc3x3x3Oes = 0x93C0,
        CompressedRgbaAstc4x3x3Oes = 0x93C1,
        CompressedRgbaAstc4x4x3Oes = 0x93C2,
        CompressedRgbaAstc4x4x4Oes = 0x93C3,
        CompressedRgbaAstc5x4x4Oes = 0x93C4,
        CompressedRgbaAstc5x5x4Oes = 0x93C5,
        CompressedRgbaAstc5x5x5Oes = 0x93C6,
        CompressedRgbaAstc6x5x5Oes = 0x93C7,
        CompressedRgbaAstc6x6x5Oes = 0x93C8,
        CompressedRgbaAstc6x6x6Oes = 0x93C9,
        CompressedSrgb8Alpha8Astc3x3x3Oes = 0x93E0,
        CompressedSrgb8Alpha8Astc4x3x3Oes = 0x93E1,
        CompressedSrgb8Alpha8Astc4x4x3Oes = 0x93E2,
        CompressedSrgb8Alpha8Astc4x4x4Oes = 0x93E3,
        CompressedSrgb8Alpha8Astc5x4x4Oes = 0x93E4,
        CompressedSrgb8Alpha8Astc5x5x4Oes = 0x93E5,
        CompressedSrgb8Alpha8Astc5x5x5Oes = 0x93E6,
        CompressedSrgb8Alpha8Astc6x5x5Oes = 0x93E7,
        CompressedSrgb8Alpha8Astc6x6x5Oes = 0x93E8,
        CompressedSrgb8Alpha8Astc6x6x6Oes = 0x93E9,
        TextureCubeMapArrayOes = 0x9009,
        TextureBindingCubeMapArrayOes = 0x900A,
        SamplerCubeMapArrayOes = 0x900C,
        SamplerCubeMapArrayShadowOes = 0x900D,
        IntSamplerCubeMapArrayOes = 0x900E,
        UnsignedIntSamplerCubeMapArrayOes = 0x900F,
        ImageCubeMapArrayOes = 0x9054,
        IntImageCubeMapArrayOes = 0x905F,
        UnsignedIntImageCubeMapArrayOes = 0x906A,
        Float = 0x1406,
        HalfFloatOes = 0x8D61,
        StencilIndexOes = 0x1901,
        StencilIndex8Oes = 0x8D48,
        Texture2DMultisampleArrayOes = 0x9102,
        TextureBinding2DMultisampleArrayOes = 0x9105,
        Sampler2DMultisampleArrayOes = 0x910B,
        IntSampler2DMultisampleArrayOes = 0x910C,
        UnsignedIntSampler2DMultisampleArrayOes = 0x910D,
        TextureViewMinLevelOes = 0x82DB,
        TextureViewNumLevelsOes = 0x82DC,
        TextureViewMinLayerOes = 0x82DD,
        TextureViewNumLayersOes = 0x82DE,
        TextureImmutableLevels = 0x82DF,
        VertexArrayBindingOes = 0x85B5,
        UnsignedInt1010102Oes = 0x8DF6,
        Int1010102Oes = 0x8DF7,
        ScissorBox = 0xC10,
        Viewport = 0xBA2,
        DepthRange = 0xB70,
        ScissorTest = 0xC11,
        MaxViewportsOes = 0x825B,
        ViewportSubpixelBitsOes = 0x825C,
        ViewportBoundsRangeOes = 0x825D,
        ViewportIndexProvokingVertexOes = 0x825F,
    }
}
