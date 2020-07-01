using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace XboxEepromEditor.Controls
{
    public class ValidatedTextBox : TextBox
    {
        /// <summary>
        /// Returns true if the text passes validation.
        /// </summary>
        public bool IsValid => Regex.IsMatch(Text, TextRegex) && 
            (ExactLengthRequired == 0 || Text.Length == ExactLengthRequired);

        /// <summary>
        /// The regular expression used to validate the text as a whole.
        /// </summary>
        public string TextRegex { get; set; } = ".*";   // default to any

        /// <summary>
        /// The regular expression used to validate individual characters.
        /// </summary>
        public string CharacterRegex { get; set; } = ".";   // default to any

        /// <summary>
        /// Converts input to upper-case if true.
        /// </summary>
        public bool ForceUpperCase { get; set; }

        /// <summary>
        /// The exact length required to pass validation.
        /// </summary>
        public int ExactLengthRequired { get; set; }

        /// <summary>
        /// The background color when valid.
        /// </summary>
        public Color ValidColor { get; set; } = SystemColors.Window;

        /// <summary>
        /// The background color when invalid.
        /// </summary>
        public Color InvalidColor { get; set; } = Color.Yellow;

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // convert to upper-case if forced
            if (ForceUpperCase)
            {
                e.KeyChar = char.ToUpperInvariant(e.KeyChar);
            }

            // must match the character regex, backspace/delete, or CTRL + A/X/C/Y/Z
            e.Handled = !(Regex.IsMatch(e.KeyChar.ToString(), CharacterRegex) ||
                "\b\u0001\u0003\u0016\u0018\u001a".Contains(e.KeyChar.ToString()));

            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            // prune characters that don't match the character regex
            StringBuilder sanitized = new StringBuilder();
            foreach (var c in Text)
            {
                if (Regex.IsMatch(c.ToString(), CharacterRegex))
                {
                    sanitized.Append(ForceUpperCase ? c.ToString().ToUpperInvariant() : c.ToString());
                }
            }

            // this should only occur during a paste that needs sanitizing
            // other invalid chars would get blocked via the upstream OnKeyPress event handler
            if (!sanitized.ToString().Equals(Text))
            {
                Text = sanitized.ToString();
                SelectionStart = Text.Length;
            }

            // update background color based on text validation result
            BackColor = IsValid ? ValidColor : InvalidColor;

            base.OnTextChanged(e);
        }

        // TODO: CustomValidate event for things more advanced than regex
    }
}
