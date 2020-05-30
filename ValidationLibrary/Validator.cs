/*
 * File: Validator.cs
 * Author: Niovan Martinez Vargas 845-11-4640
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/10/2018
 * Purpose: This class provides static methods for validating text boxes.
 */

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ValidationLibrary
{
    /// <summary>
    /// Provides static methods for validating text boxes.
    /// </summary>
    public static class Validator
    { 
        /// <summary>The title of the error message box with its default value.</summary> 
        public static string Title { get; set; } = "Entry Error";
        
        /// <summary>
        /// Determines whether the given text box contains data.
        /// </summary>
        /// <param name="control">The text box being validated.</param>
        /// <param name="name">The name associated to the text box.</param>
        /// <returns>true if the there is something in the text box; otherwise, false.</returns>
        public static bool IsPresent(Control control, string name)
        {
            if (control.Text == string.Empty)
            {
                MessageBox.Show(name + " is required.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                control.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given text box contains a string that matches the
        /// given pattern (a regurlar expression).
        /// </summary>
        /// <param name="textBox">The text box being validated.</param>
        /// <param name="name">The name associated to the text box.</param>
        /// <param name="pattern">The regular expression describing the pattern.</param>
        /// <returns>true if the text box contents match the pattern; otherwise, false.</returns>
        public static bool MatchesPattern(TextBox textBox, string name, string pattern)
        {
            if (!Regex.IsMatch(textBox.Text, pattern))
            {
                MessageBox.Show(name + " has an invalid format.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }
 
        /// <summary>
        /// Determines whether the given text box contains a valid integer.
        /// </summary>
        /// <param name="textBox">The text box being validated.</param>
        /// <param name="name">The name associated to the text box.</param>
        /// <returns>true if the text box contents an integer; otherwise, false.</returns>
        public static bool IsInt32(TextBox textBox, string name)
        {
            int value;
            if (!int.TryParse(textBox.Text, out value))
            {
                MessageBox.Show(name + " should be an integer.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given text box contains a valid decimal.
        /// </summary>
        /// <param name="textBox">The text box being validated.</param>
        /// <param name="name">The name associated to the text box.</param>
        /// <returns>true if the text box contents a decimal; otherwise, false.</returns>
        public static bool IsDecimal(TextBox textBox, string name)
        {
            decimal value;
            if (!decimal.TryParse(textBox.Text, out value))
            {
                MessageBox.Show(name + " should be a decimal.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given text box contains a valid decimal within the given range.
        /// </summary>
        /// <param name="textBox">The text box being validated.</param>
        /// <param name="name">The name associated to the text box.</param>
        /// <returns>
        /// true if the text box contents a decimal between the minimum and maximum allowed
        /// values; otherwise, false.
        /// </returns>
        public static bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal value = decimal.Parse(textBox.Text);
            if (value < min || value > max)
            {
                MessageBox.Show(name + " should be between " +
                    min + " and " + max + ".", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given textbox contains a valid date or time.
        /// </summary>
        /// <param name="textBox">The text box being validated.</param>
        /// <param name="name">The name associated to the text box.</param>
        /// <returns>true if the text box contents a date or time; otherwise, false.</returns>
        public static bool IsDateTime(TextBox textBox, string name)
        {
            DateTime value;
            if (!DateTime.TryParse(textBox.Text, out value))
            {
                MessageBox.Show(name + " should be a date or time.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given textbox contains a date or time within the given range.
        /// </summary>
        /// <param name="textBox">The text box being validated.</param>
        /// <param name="name">The name associated to the text box.</param>
        /// /// <returns>
        /// true if the text box contents a date or time between the minimum and maximum allowed
        /// values; otherwise, false.
        /// </returns>
        public static bool IsWithinRange(TextBox textBox, string name, DateTime min, DateTime max)
        {
            DateTime value = DateTime.Parse(textBox.Text);
            if (value < min || value > max)
            {
                MessageBox.Show(name + " should be between " +
                    min + " and " + max + ".", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
