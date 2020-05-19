﻿using System;
using Scriban.Syntax;

namespace Kalk.Core.Modules
{
    public partial class VectorModule : KalkModule
    {
        public const string CategoryTypeConstructors = "Type Constructors";
        public const string CategoryVectorTypeConstructors = "Type Vector Constructors";
        public const string CategoryMathVectorMatrixFunctions = "Math Vector/Matrix Functions";
        private static readonly KalkVectorConstructor<int> Int2Constructor = new KalkVectorConstructor<int>(2);
        private static readonly KalkVectorConstructor<int> Int3Constructor = new KalkVectorConstructor<int>(3);
        private static readonly KalkVectorConstructor<int> Int4Constructor = new KalkVectorConstructor<int>(4);
        private static readonly KalkVectorConstructor<int> Int8Constructor = new KalkVectorConstructor<int>(8);
        private static readonly KalkVectorConstructor<int> Int16Constructor = new KalkVectorConstructor<int>(16);
        private static readonly KalkVectorConstructor<bool> Bool2Constructor = new KalkVectorConstructor<bool>(2);
        private static readonly KalkVectorConstructor<bool> Bool3Constructor = new KalkVectorConstructor<bool>(3);
        private static readonly KalkVectorConstructor<bool> Bool4Constructor = new KalkVectorConstructor<bool>(4);
        private static readonly KalkVectorConstructor<bool> Bool8Constructor = new KalkVectorConstructor<bool>(8);
        private static readonly KalkVectorConstructor<bool> Bool16Constructor = new KalkVectorConstructor<bool>(16);
        private static readonly KalkVectorConstructor<float> Float2Constructor = new KalkVectorConstructor<float>(2);
        private static readonly KalkVectorConstructor<float> Float3Constructor = new KalkVectorConstructor<float>(3);
        private static readonly KalkVectorConstructor<float> Float4Constructor = new KalkVectorConstructor<float>(4);
        private static readonly KalkVectorConstructor<float> Float8Constructor = new KalkVectorConstructor<float>(8);
        private static readonly KalkVectorConstructor<float> Float16Constructor = new KalkVectorConstructor<float>(16);
        private static readonly KalkVectorConstructor<double> Double2Constructor = new KalkVectorConstructor<double>(2);
        private static readonly KalkVectorConstructor<double> Double3Constructor = new KalkVectorConstructor<double>(3);
        private static readonly KalkVectorConstructor<double> Double4Constructor = new KalkVectorConstructor<double>(4);
        private static readonly KalkVectorConstructor<double> Double8Constructor = new KalkVectorConstructor<double>(8);
        private static readonly KalkColorRgbConstructor RgbConstructor = new KalkColorRgbConstructor();
        private static readonly KalkColorRgbaConstructor RgbaConstructor = new KalkColorRgbaConstructor();

        public VectorModule() : base("Vectors")
        {
            RegisterFunction("int", (Func<object, int>)CreateInt, CategoryTypeConstructors);
            RegisterFunction("int2", (Func<object[], object>)CreateInt2, CategoryVectorTypeConstructors);
            RegisterFunction("int3", (Func<object[], object>)CreateInt3, CategoryVectorTypeConstructors);
            RegisterFunction("int4", (Func<object[], object>)CreateInt4, CategoryVectorTypeConstructors);
            RegisterFunction("int8", (Func<object[], object>)CreateInt8, CategoryVectorTypeConstructors);
            RegisterFunction("int16", (Func<object[], object>)CreateInt16, CategoryVectorTypeConstructors);

            RegisterFunction("bool", (Func<object, bool>)CreateBool, CategoryTypeConstructors);
            RegisterFunction("bool2", (Func<object[], object>)CreateBool2, CategoryVectorTypeConstructors);
            RegisterFunction("bool3", (Func<object[], object>)CreateBool3, CategoryVectorTypeConstructors);
            RegisterFunction("bool4", (Func<object[], object>)CreateBool4, CategoryVectorTypeConstructors);
            RegisterFunction("bool8", (Func<object[], object>)CreateBool8, CategoryVectorTypeConstructors);
            RegisterFunction("bool16", (Func<object[], object>)CreateBool16, CategoryVectorTypeConstructors);

            RegisterFunction("float", (Func<object, float>)CreateFloat, CategoryTypeConstructors);
            RegisterFunction("float2", (Func<object[], object>)CreateFloat2, CategoryVectorTypeConstructors);
            RegisterFunction("float3", (Func<object[], object>)CreateFloat3, CategoryVectorTypeConstructors);
            RegisterFunction("float4", (Func<object[], object>)CreateFloat4, CategoryVectorTypeConstructors);
            RegisterFunction("float8", (Func<object[], object>)CreateFloat8, CategoryVectorTypeConstructors);
            RegisterFunction("float16", (Func<object[], object>)CreateFloat16, CategoryVectorTypeConstructors);

            RegisterFunction("double", (Func<object, double>)CreateDouble, CategoryTypeConstructors);
            RegisterFunction("double2", (Func<object[], object>)CreateDouble2, CategoryVectorTypeConstructors);
            RegisterFunction("double3", (Func<object[], object>)CreateDouble3, CategoryVectorTypeConstructors);
            RegisterFunction("double4", (Func<object[], object>)CreateDouble4, CategoryVectorTypeConstructors);
            RegisterFunction("double8", (Func<object[], object>)CreateDouble8, CategoryVectorTypeConstructors);

            RegisterFunction("rgb", (Func<object[], object>)CreateRgb, CategoryVectorTypeConstructors);
            RegisterFunction("rgba", (Func<object[], object>)CreateRgba, CategoryVectorTypeConstructors);

            RegisterFunction("vector", (Func<ScriptVariable, int, object[], object>)CreateVector, CategoryVectorTypeConstructors);

            RegisterFunction("dot", (Func<KalkVector, KalkVector, object>)KalkVector.Dot, CategoryMathVectorMatrixFunctions);
            RegisterFunction("cross", (Func<KalkVector, KalkVector, object>)KalkVector.Cross, CategoryMathVectorMatrixFunctions);
            RegisterFunction("length", (Func<object, object>)Length, CategoryMathVectorMatrixFunctions);

            RegisterMatrices();
        }

        [KalkDoc("length")]
        public object Length(object x)
        {
            throw new InvalidOperationException("Restore MathModule");
            //if (x == null) throw new ArgumentNullException(nameof(x));
            //if (x is KalkVector v)
            //{
            //    return Engine.Sqrt(new KalkDoubleValue(KalkVector.Dot(v, v)));
            //}
            //return Engine.Abs(new KalkCompositeValue(x));
        }

        [KalkDoc("int")]
        public int CreateInt(object value = null) => value == null ? 0 : Engine.ToObject<int>(0, value);

        [KalkDoc("bool")]
        public bool CreateBool(object value = null) => value != null && Engine.ToObject<bool>(0, value);

        [KalkDoc("float")]
        public float CreateFloat(object value = null) => value == null ? 0.0f : Engine.ToObject<float>(0, value);

        [KalkDoc("double")]
        public double CreateDouble(object value = null) => value == null ? 0.0 : Engine.ToObject<double>(0, value);

        [KalkDoc("int2")]
        public KalkVector<int> CreateInt2(params object[] arguments) => Int2Constructor.Invoke(Engine, arguments);

        [KalkDoc("int3")]
        public KalkVector<int> CreateInt3(params object[] arguments) => Int3Constructor.Invoke(Engine, arguments);

        [KalkDoc("int4")]
        public KalkVector<int> CreateInt4(params object[] arguments) => Int4Constructor.Invoke(Engine, arguments);

        [KalkDoc("int8")]
        public KalkVector<int> CreateInt8(params object[] arguments) => Int8Constructor.Invoke(Engine, arguments);

        [KalkDoc("int16")]
        public KalkVector<int> CreateInt16(params object[] arguments) => Int16Constructor.Invoke(Engine, arguments);

        [KalkDoc("bool2")]
        public KalkVector<bool> CreateBool2(params object[] arguments) => Bool2Constructor.Invoke(Engine, arguments);

        [KalkDoc("bool3")]
        public KalkVector<bool> CreateBool3(params object[] arguments) => Bool3Constructor.Invoke(Engine, arguments);

        [KalkDoc("bool4")]
        public KalkVector<bool> CreateBool4(params object[] arguments) => Bool4Constructor.Invoke(Engine, arguments);

        [KalkDoc("bool8")]
        public KalkVector<bool> CreateBool8(params object[] arguments) => Bool8Constructor.Invoke(Engine, arguments);

        [KalkDoc("bool16")]
        public KalkVector<bool> CreateBool16(params object[] arguments) => Bool16Constructor.Invoke(Engine, arguments);

        [KalkDoc("float2")]
        public KalkVector<float> CreateFloat2(params object[] arguments) => Float2Constructor.Invoke(Engine, arguments);

        [KalkDoc("float3")]
        public KalkVector<float> CreateFloat3(params object[] arguments) => Float3Constructor.Invoke(Engine, arguments);

        [KalkDoc("float4")]
        public KalkVector<float> CreateFloat4(params object[] arguments) => Float4Constructor.Invoke(Engine, arguments);

        [KalkDoc("float8")]
        public KalkVector<float> CreateFloat8(params object[] arguments) => Float8Constructor.Invoke(Engine, arguments);

        [KalkDoc("float16")]
        public KalkVector<float> CreateFloat16(params object[] arguments) => Float16Constructor.Invoke(Engine, arguments);

        [KalkDoc("double2")]
        public KalkVector<double> CreateDouble2(params object[] arguments) => Double2Constructor.Invoke(Engine, arguments);

        [KalkDoc("double3")]
        public KalkVector<double> CreateDouble3(params object[] arguments) => Double3Constructor.Invoke(Engine, arguments);

        [KalkDoc("double4")]
        public KalkVector<double> CreateDouble4(params object[] arguments) => Double4Constructor.Invoke(Engine, arguments);

        [KalkDoc("double8")]
        public KalkVector<double> CreateDouble8(params object[] arguments) => Double8Constructor.Invoke(Engine, arguments);

        [KalkDoc("vector")]
        public object CreateVector(ScriptVariable name, int dimension, params object[] arguments)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (dimension <= 1) throw new ArgumentOutOfRangeException(nameof(dimension), "Invalid dimension. Expecting a value > 1.");
            switch (name.Name)
            {
                case "int":
                    switch (dimension)
                    {
                        case 2: return CreateInt2(arguments);
                        case 3: return CreateInt3(arguments);
                        case 4: return CreateInt4(arguments);
                        case 8: return CreateInt8(arguments);
                        case 16: return CreateInt16(arguments);
                    }
                    return new KalkVectorConstructor<int>(dimension).Invoke(Engine, arguments);
                case "bool":
                    switch (dimension)
                    {
                        case 2: return CreateBool2(arguments);
                        case 3: return CreateBool3(arguments);
                        case 4: return CreateBool4(arguments);
                        case 8: return CreateBool8(arguments);
                        case 16: return CreateBool16(arguments);
                    }
                    return new KalkVectorConstructor<bool>(dimension).Invoke(Engine, arguments);

                case "float":
                    switch (dimension)
                    {
                        case 2: return CreateFloat2(arguments);
                        case 3: return CreateFloat3(arguments);
                        case 4: return CreateFloat4(arguments);
                        case 8: return CreateFloat8(arguments);
                        case 16: return CreateFloat16(arguments);
                    }
                    return new KalkVectorConstructor<float>(dimension).Invoke(Engine, arguments);

                case "double":
                    switch (dimension)
                    {
                        case 2: return CreateDouble2(arguments);
                        case 3: return CreateDouble3(arguments);
                        case 4: return CreateDouble4(arguments);
                        case 8: return CreateDouble8(arguments);
                    }
                    return new KalkVectorConstructor<double>(dimension).Invoke(Engine, arguments);
            }

            throw new ArgumentException($"Unsupported vector type {name.Name}. Only bool, int, float and double are supported", nameof(name));
        }


        [KalkDoc("rgb")]
        public KalkColorRgb CreateRgb(params object[] arguments) => (KalkColorRgb)RgbConstructor.Invoke(Engine, arguments);

        [KalkDoc("rgba")]
        public KalkColorRgba CreateRgba(params object[] arguments) => (KalkColorRgba)RgbaConstructor.Invoke(Engine, arguments);
    }
}