﻿using BarCodeScanner.Extensions;
using BarCodeScanner.Resources;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace BarCodeScanner.Converters
{
    /// <summary>
    /// Converts/Extracts the incoming value from <see cref="SelectedItemChangedEventArgs"/> object and returns the value of <see cref="SelectedItemChangedEventArgs.SelectedItem"/> property from it.
    /// </summary>
    public class ItemSelectedEventArgsConverter : ValueConverterExtension, IValueConverter
    {
        /// <summary>
        /// Converts/Extracts the incoming value from <see cref="SelectedItemChangedEventArgs"/> object and returns the value of <see cref="SelectedItemChangedEventArgs.SelectedItem"/> property from it.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="targetType">The type of the binding target property. This is not implemented.</param>
        /// <param name="parameter">Additional parameter for the converter to handle. This is not implemented.</param>
        /// <param name="culture">The culture to use in the converter. This is not implemented.</param>
        /// <returns>A <see cref="SelectedItemChangedEventArgs.SelectedItem"/> object from object of type <see cref="SelectedItemChangedEventArgs"/>.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            return value is SelectedItemChangedEventArgs selectedItemChangedEventArgs
               ? selectedItemChangedEventArgs.SelectedItem
               : throw new ArgumentException(AppResources.ExpectedValueOfTypeSelectedItemChangedEventArgs, nameof(value));
        }

        /// <summary>
        /// This method is not implemented and will throw a <see cref="NotImplementedException"/>.
        /// </summary>
        /// <param name="value">N/A</param>
        /// <param name="targetType">N/A</param>
        /// <param name="parameter">N/A</param>
        /// <param name="culture">N/A</param>
        /// <returns>N/A</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}
