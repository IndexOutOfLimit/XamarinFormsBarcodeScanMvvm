﻿using BarCodeScanner.Extensions;
using BarCodeScanner.Resources;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace BarCodeScanner.Converters
{
    /// <summary>
    /// Converts true to false and false to true. Simple as that!
    /// </summary>
    public class InvertedBoolConverter : ValueConverterExtension, IValueConverter
    {
        /// <summary>
        /// Converts a <see cref="bool"/> to its inverse value.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="targetType">The type of the binding target property. This is not implemented.</param>
        /// <param name="parameter">Additional parameter for the converter to handle. This is not implemented.</param>
        /// <param name="culture">The culture to use in the converter. This is not implemented.</param>
        /// <returns>An inverted <see cref="bool"/> from the one coming in.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return InverseBool(value);
        }

        /// <summary>
        /// Converts a <see cref="bool"/> to its inverse value.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="targetType">The type of the binding target property. This is not implemented.</param>
        /// <param name="parameter">Additional parameter for the converter to handle. This is not implemented.</param>
        /// <param name="culture">The culture to use in the converter. This is not implemented.</param>
        /// <returns>An inverted <see cref="bool"/> from the one coming in.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return InverseBool(value);
        }

        /// <summary>
        /// Inverses an incoming <see cref="bool"/>.
        /// </summary>
        /// <param name="value">The value to inverse.</param>
        /// <returns>The inverted value of the incoming <see cref="bool"/>.</returns>
        private bool InverseBool(object value)
        {
            if (value is bool result)
                return !result;

            throw new ArgumentException(AppResources.ValueNotValidBoolean, nameof(value));
        }
    }
}
