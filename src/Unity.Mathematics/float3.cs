using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661
namespace Unity.Mathematics
{
    public partial struct float3 : IFormattable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(float val) { x = y = z = val; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(int val) { x = y = z = val; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(int3 val)
        {
            x = val.x;
            y = val.y;
            z = val.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(float d) { return new float3(d); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(int3 d) { return new float3(d.x, d.y, d.z); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(bool3 d) { return new float3(d.x ? 1.0f : 0.0f, d.y ? 1.0f : 0.0f, d.z ? 1.0f : 0.0f); }

        public static readonly float3 zero = new float3(0.0f, 0.0f, 0.0f);
    }
}

