﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Xenko.Core;
using Xenko.Rendering.Materials;
using Xenko.Rendering.Materials.ComputeColors;
using Xenko.Shaders;
using DataMemberAttribute = Xenko.Core.DataMemberAttribute;

namespace VL.Xenko.Shaders
{
    public interface IComputeVoid : IComputeNode
    {

    }

    public class ComputeOrder : ComputeNode, IComputeVoid
    {
        /// <summary>
        /// The left (background) child node.
        /// </summary>
        /// <userdoc>
        /// The map used for the left (background) node.
        /// </userdoc>
        [DataMember(20)]
        [Display("Computes")]
        public IEnumerable<IComputeVoid> Computes { get; set; }

        public override ShaderSource GenerateShaderSource(ShaderGeneratorContext context, MaterialComputeColorKeys baseKeys)
        {
            var shaderSources = new ShaderArraySource();

            foreach (var compute in Computes)
                shaderSources.Add(compute.GenerateShaderSource(context, baseKeys));

            var shaderSource = new ShaderClassSource("ComputeOrder");
            var mixin = new ShaderMixinSource();
            mixin.Mixins.Add(shaderSource);

            if (shaderSources != null)
                mixin.AddComposition("Computes", shaderSources);

            return mixin;
        }
    }
}
