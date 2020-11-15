﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Date: 11/08/2020 16:43:38
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Scriban.Helpers;
using Scriban.Syntax;

namespace Kalk.Core.Modules
{
    public partial class VectorModule
    {
        private const string CategoryMatrixConstructors = "Type Matrix Constructors";

        private static readonly KalkMatrixConstructor<KalkBool> Bool2x2Constructor = new KalkMatrixConstructor<KalkBool>(2, 2);
        private static readonly KalkMatrixConstructor<KalkBool> Bool2x3Constructor = new KalkMatrixConstructor<KalkBool>(2, 3);
        private static readonly KalkMatrixConstructor<KalkBool> Bool2x4Constructor = new KalkMatrixConstructor<KalkBool>(2, 4);
        private static readonly KalkMatrixConstructor<KalkBool> Bool3x2Constructor = new KalkMatrixConstructor<KalkBool>(3, 2);
        private static readonly KalkMatrixConstructor<KalkBool> Bool3x3Constructor = new KalkMatrixConstructor<KalkBool>(3, 3);
        private static readonly KalkMatrixConstructor<KalkBool> Bool3x4Constructor = new KalkMatrixConstructor<KalkBool>(3, 4);
        private static readonly KalkMatrixConstructor<KalkBool> Bool4x2Constructor = new KalkMatrixConstructor<KalkBool>(4, 2);
        private static readonly KalkMatrixConstructor<KalkBool> Bool4x3Constructor = new KalkMatrixConstructor<KalkBool>(4, 3);
        private static readonly KalkMatrixConstructor<KalkBool> Bool4x4Constructor = new KalkMatrixConstructor<KalkBool>(4, 4);
        private static readonly KalkMatrixConstructor<int> Int2x2Constructor = new KalkMatrixConstructor<int>(2, 2);
        private static readonly KalkMatrixConstructor<int> Int2x3Constructor = new KalkMatrixConstructor<int>(2, 3);
        private static readonly KalkMatrixConstructor<int> Int2x4Constructor = new KalkMatrixConstructor<int>(2, 4);
        private static readonly KalkMatrixConstructor<int> Int3x2Constructor = new KalkMatrixConstructor<int>(3, 2);
        private static readonly KalkMatrixConstructor<int> Int3x3Constructor = new KalkMatrixConstructor<int>(3, 3);
        private static readonly KalkMatrixConstructor<int> Int3x4Constructor = new KalkMatrixConstructor<int>(3, 4);
        private static readonly KalkMatrixConstructor<int> Int4x2Constructor = new KalkMatrixConstructor<int>(4, 2);
        private static readonly KalkMatrixConstructor<int> Int4x3Constructor = new KalkMatrixConstructor<int>(4, 3);
        private static readonly KalkMatrixConstructor<int> Int4x4Constructor = new KalkMatrixConstructor<int>(4, 4);
        private static readonly KalkMatrixConstructor<float> Float2x2Constructor = new KalkMatrixConstructor<float>(2, 2);
        private static readonly KalkMatrixConstructor<float> Float2x3Constructor = new KalkMatrixConstructor<float>(2, 3);
        private static readonly KalkMatrixConstructor<float> Float2x4Constructor = new KalkMatrixConstructor<float>(2, 4);
        private static readonly KalkMatrixConstructor<float> Float3x2Constructor = new KalkMatrixConstructor<float>(3, 2);
        private static readonly KalkMatrixConstructor<float> Float3x3Constructor = new KalkMatrixConstructor<float>(3, 3);
        private static readonly KalkMatrixConstructor<float> Float3x4Constructor = new KalkMatrixConstructor<float>(3, 4);
        private static readonly KalkMatrixConstructor<float> Float4x2Constructor = new KalkMatrixConstructor<float>(4, 2);
        private static readonly KalkMatrixConstructor<float> Float4x3Constructor = new KalkMatrixConstructor<float>(4, 3);
        private static readonly KalkMatrixConstructor<float> Float4x4Constructor = new KalkMatrixConstructor<float>(4, 4);
        private static readonly KalkMatrixConstructor<double> Double2x2Constructor = new KalkMatrixConstructor<double>(2, 2);
        private static readonly KalkMatrixConstructor<double> Double2x3Constructor = new KalkMatrixConstructor<double>(2, 3);
        private static readonly KalkMatrixConstructor<double> Double2x4Constructor = new KalkMatrixConstructor<double>(2, 4);
        private static readonly KalkMatrixConstructor<double> Double3x2Constructor = new KalkMatrixConstructor<double>(3, 2);
        private static readonly KalkMatrixConstructor<double> Double3x3Constructor = new KalkMatrixConstructor<double>(3, 3);
        private static readonly KalkMatrixConstructor<double> Double3x4Constructor = new KalkMatrixConstructor<double>(3, 4);
        private static readonly KalkMatrixConstructor<double> Double4x2Constructor = new KalkMatrixConstructor<double>(4, 2);
        private static readonly KalkMatrixConstructor<double> Double4x3Constructor = new KalkMatrixConstructor<double>(4, 3);
        private static readonly KalkMatrixConstructor<double> Double4x4Constructor = new KalkMatrixConstructor<double>(4, 4);

        /// <summary>Creates a 2 (rows) x 2 (columns) matrix of bool.</summary>
        [KalkExport("bool2x2", CategoryMatrixConstructors)]
        public KalkMatrix<KalkBool> CreateBool2x2(params object[] arguments) => Bool2x2Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 2 (rows) x 3 (columns) matrix of bool.</summary>
        [KalkExport("bool2x3", CategoryMatrixConstructors)]
        public KalkMatrix<KalkBool> CreateBool2x3(params object[] arguments) => Bool2x3Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 2 (rows) x 4 (columns) matrix of bool.</summary>
        [KalkExport("bool2x4", CategoryMatrixConstructors)]
        public KalkMatrix<KalkBool> CreateBool2x4(params object[] arguments) => Bool2x4Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 3 (rows) x 2 (columns) matrix of bool.</summary>
        [KalkExport("bool3x2", CategoryMatrixConstructors)]
        public KalkMatrix<KalkBool> CreateBool3x2(params object[] arguments) => Bool3x2Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 3 (rows) x 3 (columns) matrix of bool.</summary>
        [KalkExport("bool3x3", CategoryMatrixConstructors)]
        public KalkMatrix<KalkBool> CreateBool3x3(params object[] arguments) => Bool3x3Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 3 (rows) x 4 (columns) matrix of bool.</summary>
        [KalkExport("bool3x4", CategoryMatrixConstructors)]
        public KalkMatrix<KalkBool> CreateBool3x4(params object[] arguments) => Bool3x4Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 4 (rows) x 2 (columns) matrix of bool.</summary>
        [KalkExport("bool4x2", CategoryMatrixConstructors)]
        public KalkMatrix<KalkBool> CreateBool4x2(params object[] arguments) => Bool4x2Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 4 (rows) x 3 (columns) matrix of bool.</summary>
        [KalkExport("bool4x3", CategoryMatrixConstructors)]
        public KalkMatrix<KalkBool> CreateBool4x3(params object[] arguments) => Bool4x3Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 4 (rows) x 4 (columns) matrix of bool.</summary>
        [KalkExport("bool4x4", CategoryMatrixConstructors)]
        public KalkMatrix<KalkBool> CreateBool4x4(params object[] arguments) => Bool4x4Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 2 (rows) x 2 (columns) matrix of int.</summary>
        [KalkExport("int2x2", CategoryMatrixConstructors)]
        public KalkMatrix<int> CreateInt2x2(params object[] arguments) => Int2x2Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 2 (rows) x 3 (columns) matrix of int.</summary>
        [KalkExport("int2x3", CategoryMatrixConstructors)]
        public KalkMatrix<int> CreateInt2x3(params object[] arguments) => Int2x3Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 2 (rows) x 4 (columns) matrix of int.</summary>
        [KalkExport("int2x4", CategoryMatrixConstructors)]
        public KalkMatrix<int> CreateInt2x4(params object[] arguments) => Int2x4Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 3 (rows) x 2 (columns) matrix of int.</summary>
        [KalkExport("int3x2", CategoryMatrixConstructors)]
        public KalkMatrix<int> CreateInt3x2(params object[] arguments) => Int3x2Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 3 (rows) x 3 (columns) matrix of int.</summary>
        [KalkExport("int3x3", CategoryMatrixConstructors)]
        public KalkMatrix<int> CreateInt3x3(params object[] arguments) => Int3x3Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 3 (rows) x 4 (columns) matrix of int.</summary>
        [KalkExport("int3x4", CategoryMatrixConstructors)]
        public KalkMatrix<int> CreateInt3x4(params object[] arguments) => Int3x4Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 4 (rows) x 2 (columns) matrix of int.</summary>
        [KalkExport("int4x2", CategoryMatrixConstructors)]
        public KalkMatrix<int> CreateInt4x2(params object[] arguments) => Int4x2Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 4 (rows) x 3 (columns) matrix of int.</summary>
        [KalkExport("int4x3", CategoryMatrixConstructors)]
        public KalkMatrix<int> CreateInt4x3(params object[] arguments) => Int4x3Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 4 (rows) x 4 (columns) matrix of int.</summary>
        [KalkExport("int4x4", CategoryMatrixConstructors)]
        public KalkMatrix<int> CreateInt4x4(params object[] arguments) => Int4x4Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 2 (rows) x 2 (columns) matrix of float.</summary>
        [KalkExport("float2x2", CategoryMatrixConstructors)]
        public KalkMatrix<float> CreateFloat2x2(params object[] arguments) => Float2x2Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 2 (rows) x 3 (columns) matrix of float.</summary>
        [KalkExport("float2x3", CategoryMatrixConstructors)]
        public KalkMatrix<float> CreateFloat2x3(params object[] arguments) => Float2x3Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 2 (rows) x 4 (columns) matrix of float.</summary>
        [KalkExport("float2x4", CategoryMatrixConstructors)]
        public KalkMatrix<float> CreateFloat2x4(params object[] arguments) => Float2x4Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 3 (rows) x 2 (columns) matrix of float.</summary>
        [KalkExport("float3x2", CategoryMatrixConstructors)]
        public KalkMatrix<float> CreateFloat3x2(params object[] arguments) => Float3x2Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 3 (rows) x 3 (columns) matrix of float.</summary>
        [KalkExport("float3x3", CategoryMatrixConstructors)]
        public KalkMatrix<float> CreateFloat3x3(params object[] arguments) => Float3x3Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 3 (rows) x 4 (columns) matrix of float.</summary>
        [KalkExport("float3x4", CategoryMatrixConstructors)]
        public KalkMatrix<float> CreateFloat3x4(params object[] arguments) => Float3x4Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 4 (rows) x 2 (columns) matrix of float.</summary>
        [KalkExport("float4x2", CategoryMatrixConstructors)]
        public KalkMatrix<float> CreateFloat4x2(params object[] arguments) => Float4x2Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 4 (rows) x 3 (columns) matrix of float.</summary>
        [KalkExport("float4x3", CategoryMatrixConstructors)]
        public KalkMatrix<float> CreateFloat4x3(params object[] arguments) => Float4x3Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 4 (rows) x 4 (columns) matrix of float.</summary>
        [KalkExport("float4x4", CategoryMatrixConstructors)]
        public KalkMatrix<float> CreateFloat4x4(params object[] arguments) => Float4x4Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 2 (rows) x 2 (columns) matrix of double.</summary>
        [KalkExport("double2x2", CategoryMatrixConstructors)]
        public KalkMatrix<double> CreateDouble2x2(params object[] arguments) => Double2x2Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 2 (rows) x 3 (columns) matrix of double.</summary>
        [KalkExport("double2x3", CategoryMatrixConstructors)]
        public KalkMatrix<double> CreateDouble2x3(params object[] arguments) => Double2x3Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 2 (rows) x 4 (columns) matrix of double.</summary>
        [KalkExport("double2x4", CategoryMatrixConstructors)]
        public KalkMatrix<double> CreateDouble2x4(params object[] arguments) => Double2x4Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 3 (rows) x 2 (columns) matrix of double.</summary>
        [KalkExport("double3x2", CategoryMatrixConstructors)]
        public KalkMatrix<double> CreateDouble3x2(params object[] arguments) => Double3x2Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 3 (rows) x 3 (columns) matrix of double.</summary>
        [KalkExport("double3x3", CategoryMatrixConstructors)]
        public KalkMatrix<double> CreateDouble3x3(params object[] arguments) => Double3x3Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 3 (rows) x 4 (columns) matrix of double.</summary>
        [KalkExport("double3x4", CategoryMatrixConstructors)]
        public KalkMatrix<double> CreateDouble3x4(params object[] arguments) => Double3x4Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 4 (rows) x 2 (columns) matrix of double.</summary>
        [KalkExport("double4x2", CategoryMatrixConstructors)]
        public KalkMatrix<double> CreateDouble4x2(params object[] arguments) => Double4x2Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 4 (rows) x 3 (columns) matrix of double.</summary>
        [KalkExport("double4x3", CategoryMatrixConstructors)]
        public KalkMatrix<double> CreateDouble4x3(params object[] arguments) => Double4x3Constructor.Invoke(Engine, arguments);
        /// <summary>Creates a 4 (rows) x 4 (columns) matrix of double.</summary>
        [KalkExport("double4x4", CategoryMatrixConstructors)]
        public KalkMatrix<double> CreateDouble4x4(params object[] arguments) => Double4x4Constructor.Invoke(Engine, arguments);
    }
}
