﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Stride Shader Mixin Code Generator.
// To generate it yourself, please install Stride.VisualStudio.Package .vsix
// and re-save the associated .sdfx.
// </auto-generated>

using System;
using Stride.Core;
using Stride.Rendering;
using Stride.Graphics;
using Stride.Shaders;
using Stride.Core.Mathematics;
using Buffer = Stride.Graphics.Buffer;

namespace Stride.Rendering
{
    public static partial class Scale_TextureFXKeys
    {
        public static readonly ValueParameterKey<Matrix> Transform = ParameterKeys.NewValue<Matrix>();
        public static readonly ObjectParameterKey<SamplerState> CustomSampler = ParameterKeys.NewObject<SamplerState>();
        public static readonly ValueParameterKey<uint> InterpolationMode = ParameterKeys.NewValue<uint>(0);
    }
}
