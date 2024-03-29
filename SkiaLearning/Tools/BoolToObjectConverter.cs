﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace SkiaLearning.Tools
{
    public class BoolToObjectConverter<T> : IValueConverter
    {
        public T TrueObject { get; set; }

        public T FalseObject { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? TrueObject : FalseObject;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
    }
}
