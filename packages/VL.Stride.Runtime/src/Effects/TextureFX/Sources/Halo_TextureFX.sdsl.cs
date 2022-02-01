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
    public static partial class Halo_TextureFXKeys
    {
        public static readonly ValueParameterKey<float> InnerRadius = ParameterKeys.NewValue<float>(0.0f);
        public static readonly ValueParameterKey<float> OuterRadius = ParameterKeys.NewValue<float>(0.5f);
        public static readonly ValueParameterKey<int> Type = ParameterKeys.NewValue<int>(0);
        public static readonly ValueParameterKey<Color4> BackgroundColor = ParameterKeys.NewValue<Color4>(new Color4(0.0f,0.0f,0.0f,0.0f));
        public static readonly ValueParameterKey<Color4> HaloColor = ParameterKeys.NewValue<Color4>(new Color4(1.0f,1.0f,1.0f,1.0f));
        public static readonly ValueParameterKey<float> Gamma = ParameterKeys.NewValue<float>(0.5f);
    }
}
