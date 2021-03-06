﻿using System;
using System.ComponentModel;

namespace dotnetCampus.OpenXMLUnitConverter
{
    [EditorBrowsable(EditorBrowsableState.Never), Obsolete("请使用 dotnetCampus.OpenXmlUnitConverter 命名空间下的同名类型。")]
    public class Cm : LegacyUnit<dotnetCampus.OpenXmlUnitConverter.Cm, Cm>
    {
        public Cm(double value)
        {
            Value = value;
        }

        public double Value { get; }

        public static implicit operator Cm(dotnetCampus.OpenXmlUnitConverter.Cm newUnit)
        {
            return new Cm(newUnit.Value);
        }
    }
}
