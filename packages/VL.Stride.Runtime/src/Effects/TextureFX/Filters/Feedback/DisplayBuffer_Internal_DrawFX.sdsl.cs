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
    public static partial class DisplayBuffer_Internal_DrawFXKeys
    {
        public static readonly ValueParameterKey<Vector2> Reso = ParameterKeys.NewValue<Vector2>();
        public static readonly ValueParameterKey<int> pixSize = ParameterKeys.NewValue<int>(8);
        public static readonly ObjectParameterKey<Buffer> sbInput = ParameterKeys.NewObject<Buffer>();
    }
}
