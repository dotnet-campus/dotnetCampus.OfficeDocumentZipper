﻿using System;
using System.ComponentModel;

namespace dotnetCampus.OpenXMLUnitConverter
{
    [EditorBrowsable(EditorBrowsableState.Never), Obsolete("请使用 dotnetCampus.OpenXmlUnitConverter 命名空间下的同名类型。")]
    public class HalfPoint : LegacyUnit<dotnetCampus.OpenXmlUnitConverter.HalfPoint, HalfPoint>
    {
        public HalfPoint(double value)
        {
            Value = value;
        }

        public double Value { get; }

        public static implicit operator HalfPoint(dotnetCampus.OpenXmlUnitConverter.HalfPoint newUnit)
        {
            return new HalfPoint(newUnit.Value);
        }
    }
}