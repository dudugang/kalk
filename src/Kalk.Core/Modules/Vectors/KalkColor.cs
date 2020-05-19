﻿using System;
using System.Collections.Generic;
using System.Text;
using Consolus;
using Scriban;
using Scriban.Syntax;

namespace Kalk.Core
{

    // https://github.com/google/palette.js/tree/master

    [ScriptTypeName("color")]
    public abstract class KalkColor : KalkVector<int>
    {
        protected KalkColor(int dimension) : base(dimension)
        {
        }

        protected KalkColor(IList<int> list) : base(list)
        {
        }

        protected KalkColor(KalkVector<int> values) : base(values)
        {
        }
        
        public override IEnumerable<string> GetMembers()
        {
            for (int i = 0; i < Math.Min(4, Length); i++)
            {
                switch (i)
                {
                    case 0:
                        yield return "r";
                        break;
                    case 1:
                        yield return "g";
                        break;
                    case 2:
                        yield return "b";
                        break;
                    case 3:
                        yield return "a";
                        break;
                }
            }
        }

        private static float Clamp01(float value) => Math.Clamp(value, 0.0f, 1.0f);

        protected override KalkVector NewVector(ComponentUsed components, IList<int> list)
        {
            if (components == ComponentUsed.xyzw)
            {
                if (list.Count == 4)
                {
                    return new KalkVector<float>(Clamp01(list[0] / 255.0f), Clamp01(list[1] / 255.0f), Clamp01(list[2] / 255.0f), Clamp01(list[3] / 255.0f));
                }

                if (list.Count == 3)
                {
                    return new KalkVector<float>(Clamp01(list[0] / 255.0f), Clamp01(list[1] / 255.0f), Clamp01(list[2] / 255.0f));
                }

                if (list.Count == 2)
                {
                    return new KalkVector<float>(Clamp01(list[0] / 255.0f), Clamp01(list[1] / 255.0f));
                }

                throw new InvalidOperationException("Cannot create a float vector type from this rgba components");
            }
            else
            {
                return list.Count == 4 ? new KalkColorRgba(list[0], list[1], list[2], list[3]) : list.Count == 3 ? new KalkColorRgb(list[0], list[1], list[2]) : base.NewVector(components, list);
            }
        }

        protected abstract override KalkVector<int> NewVector(int length);

        protected override void SetComponent(int index, int value)
        {
            value = value < 0 ? 0 : value > 255 ? 255 : value;
            base.SetComponent(index, value);
        }

        public abstract override string TypeName { get; }

        public override string ToString(string format, IFormatProvider formatProvider)
        {
            var engine = formatProvider as KalkEngine;
            var builder = new StringBuilder();
            builder.Append(TypeName);
            builder.Append('(');
            for (int i = 0; i < Length; i++)
            {
                if (i > 0) builder.Append(", ");
                builder.Append(engine != null ? engine.ObjectToString(this[i]) : this[i].ToString(null, formatProvider));
            }
            builder.Append(')');

            builder.Append(" ## ");
            for (int i = 0; i < Length; i++)
            {
                builder.Append($"{this[i]:X2}");
            }
            if (engine != null && engine.AllowEscapeSequences)
            {
                builder.Append(" ");
                builder.Append(ConsoleStyle.BackgroundRgb(this[0], this[1], this[2]));
                builder.Append("    ");
                builder.Append(ConsoleStyle.Reset);
            }
            builder.Append(" ##");
            return builder.ToString();
        }
    }
}