﻿using Xenko.Rendering.Materials;

namespace VL.Xenko.Shaders.ShaderFX
{
    public class ShaderInput
    {
        public IComputeNode Shader;
        public string CompositionName;

        public ShaderInput(IComputeNode shader, string compositionName)
        {
            Shader = shader;
            CompositionName = compositionName;
        }
    }
}
