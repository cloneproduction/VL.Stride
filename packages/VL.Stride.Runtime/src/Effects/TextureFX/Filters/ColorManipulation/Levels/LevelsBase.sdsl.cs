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
    public static partial class LevelsBaseKeys
    {
        public static readonly ValueParameterKey<Color4> fromBlack = ParameterKeys.NewValue<Color4>(new Color4(0,0,0,1));
        public static readonly ValueParameterKey<Color4> fromWhite = ParameterKeys.NewValue<Color4>(new Color4(1,1,1,1));
        public static readonly ValueParameterKey<Color4> toBlack = ParameterKeys.NewValue<Color4>(new Color4(0,0,0,1));
        public static readonly ValueParameterKey<Color4> toWhite = ParameterKeys.NewValue<Color4>(new Color4(1,1,1,1));
        public static readonly ValueParameterKey<float> Gamma = ParameterKeys.NewValue<float>(1.0f);
    }
}
