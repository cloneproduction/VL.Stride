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

namespace VL.Stride.Rendering
{
    [DataContract]public partial class GameParameters : ShaderMixinParameters
    {
        public static readonly PermutationParameterKey<bool> EnableFog = ParameterKeys.NewPermutation<bool>(true);
        public static readonly PermutationParameterKey<bool> EnableBend = ParameterKeys.NewPermutation<bool>(true);
        public static readonly PermutationParameterKey<bool> EnableExtension = ParameterKeys.NewPermutation<bool>(false);
        public static readonly PermutationParameterKey<string> MaterialExtensionName = ParameterKeys.NewPermutation<string>();
        public static readonly PermutationParameterKey<bool> EnableExtensionShader = ParameterKeys.NewPermutation<bool>(false);
        public static readonly PermutationParameterKey<ShaderSource> MaterialExtensionShader = ParameterKeys.NewPermutation<ShaderSource>();
    };
    internal static partial class ShaderMixins
    {
        internal partial class VLEffectMain  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "StrideForwardShadingEffect");
                if (context.GetParam(GameParameters.EnableExtension))
                {
                    context.Mixin(mixin, context.GetParam(GameParameters.MaterialExtensionName));
                    if (context.GetParam(GameParameters.EnableExtensionShader))
                    {

                        {
                            var __mixinToCompose__ = context.GetParam(GameParameters.MaterialExtensionShader);
                            var __subMixin = new ShaderMixinSource();
                            context.PushComposition(mixin, "ExtensionShader", __subMixin);
                            context.Mixin(__subMixin, __mixinToCompose__);
                            context.PopComposition();
                        }
                    }
                }
                if (context.GetParam(GameParameters.EnableBend))
                    context.Mixin(mixin, "TransformationBendWorld");
                if (context.GetParam(GameParameters.EnableFog))
                    context.Mixin(mixin, "FogEffect");
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("VLEffectMain", new VLEffectMain());
            }
        }
    }
}
