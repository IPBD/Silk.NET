// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public enum EnableCap
    {
        PointSmooth = 0xB10,
        LineSmooth = 0xB20,
        LineStipple = 0xB24,
        PolygonSmooth = 0xB41,
        PolygonStipple = 0xB42,
        CullFace = 0xB44,
        Lighting = 0xB50,
        ColorMaterial = 0xB57,
        Fog = 0xB60,
        DepthTest = 0xB71,
        StencilTest = 0xB90,
        Normalize = 0xBA1,
        AlphaTest = 0xBC0,
        Dither = 0xBD0,
        Blend = 0xBE2,
        IndexLogicOp = 0xBF1,
        ColorLogicOp = 0xBF2,
        ScissorTest = 0xC11,
        TextureGenS = 0xC60,
        TextureGenT = 0xC61,
        TextureGenR = 0xC62,
        TextureGenQ = 0xC63,
        AutoNormal = 0xD80,
        Map1Color4 = 0xD90,
        Map1Index = 0xD91,
        Map1Normal = 0xD92,
        Map1TextureCoord1 = 0xD93,
        Map1TextureCoord2 = 0xD94,
        Map1TextureCoord3 = 0xD95,
        Map1TextureCoord4 = 0xD96,
        Map1Vertex3 = 0xD97,
        Map1Vertex4 = 0xD98,
        Map2Color4 = 0xDB0,
        Map2Index = 0xDB1,
        Map2Normal = 0xDB2,
        Map2TextureCoord1 = 0xDB3,
        Map2TextureCoord2 = 0xDB4,
        Map2TextureCoord3 = 0xDB5,
        Map2TextureCoord4 = 0xDB6,
        Map2Vertex3 = 0xDB7,
        Map2Vertex4 = 0xDB8,
        Texture1D = 0xDE0,
        Texture2D = 0xDE1,
        PolygonOffsetPoint = 0x2A01,
        PolygonOffsetLine = 0x2A02,
        ClipPlane0 = 0x3000,
        ClipDistance0 = 0x3000,
        ClipPlane1 = 0x3001,
        ClipDistance1 = 0x3001,
        ClipPlane2 = 0x3002,
        ClipDistance2 = 0x3002,
        ClipPlane3 = 0x3003,
        ClipDistance3 = 0x3003,
        ClipPlane4 = 0x3004,
        ClipDistance4 = 0x3004,
        ClipPlane5 = 0x3005,
        ClipDistance5 = 0x3005,
        ClipDistance6 = 0x3006,
        ClipDistance7 = 0x3007,
        Light0 = 0x4000,
        Light1 = 0x4001,
        Light2 = 0x4002,
        Light3 = 0x4003,
        Light4 = 0x4004,
        Light5 = 0x4005,
        Light6 = 0x4006,
        Light7 = 0x4007,
        Convolution1DExt = 0x8010,
        Convolution2DExt = 0x8011,
        Separable2DExt = 0x8012,
        HistogramExt = 0x8024,
        MinmaxExt = 0x802E,
        PolygonOffsetFill = 0x8037,
        RescaleNormalExt = 0x803A,
        Texture3DExt = 0x806F,
        VertexArray = 0x8074,
        NormalArray = 0x8075,
        ColorArray = 0x8076,
        IndexArray = 0x8077,
        TextureCoordArray = 0x8078,
        EdgeFlagArray = 0x8079,
        InterlaceSgix = 0x8094,
        Multisample = 0x809D,
        MultisampleSgis = 0x809D,
        SampleAlphaToCoverage = 0x809E,
        SampleAlphaToMaskSgis = 0x809E,
        SampleAlphaToOne = 0x809F,
        SampleAlphaToOneSgis = 0x809F,
        SampleCoverage = 0x80A0,
        SampleMaskSgis = 0x80A0,
        TextureColorTableSgi = 0x80BC,
        ColorTableSgi = 0x80D0,
        PostConvolutionColorTableSgi = 0x80D1,
        PostColorMatrixColorTableSgi = 0x80D2,
        Texture4DSgis = 0x8134,
        PixelTexGenSgix = 0x8139,
        SpriteSgix = 0x8148,
        ReferencePlaneSgix = 0x817D,
        IRInstrument1Sgix = 0x817F,
        CalligraphicFragmentSgix = 0x8183,
        FramezoomSgix = 0x818B,
        FogOffsetSgix = 0x8198,
        SharedTexturePaletteExt = 0x81FB,
        DebugOutputSynchronous = 0x8242,
        AsyncHistogramSgix = 0x832C,
        PixelTextureSgis = 0x8353,
        AsyncTexImageSgix = 0x835C,
        AsyncDrawPixelsSgix = 0x835D,
        AsyncReadPixelsSgix = 0x835E,
        FragmentLightingSgix = 0x8400,
        FragmentColorMaterialSgix = 0x8401,
        FragmentLight0Sgix = 0x840C,
        FragmentLight1Sgix = 0x840D,
        FragmentLight2Sgix = 0x840E,
        FragmentLight3Sgix = 0x840F,
        FragmentLight4Sgix = 0x8410,
        FragmentLight5Sgix = 0x8411,
        FragmentLight6Sgix = 0x8412,
        FragmentLight7Sgix = 0x8413,
        ProgramPointSize = 0x8642,
        DepthClamp = 0x864F,
        TextureCubeMapSeamless = 0x884F,
        SampleShading = 0x8C36,
        RasterizerDiscard = 0x8C89,
        PrimitiveRestartFixedIndex = 0x8D69,
        FramebufferSrgb = 0x8DB9,
        SampleMask = 0x8E51,
        PrimitiveRestart = 0x8F9D,
        DebugOutput = 0x92E0,
    }
}
