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
    public static partial class RampColor_TextureFXKeys
    {
        public static readonly ValueParameterKey<int> Type = ParameterKeys.NewValue<int>();
        public static readonly ValueParameterKey<Vector2> FromXY = ParameterKeys.NewValue<Vector2>(new Vector2(0,0));
        public static readonly ValueParameterKey<Vector2> ToXY = ParameterKeys.NewValue<Vector2>(new Vector2(1,1));
    }
}
