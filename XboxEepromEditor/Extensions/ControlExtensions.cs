using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XboxEepromEditor.Extensions
{
    public static class ControlExtensions
    {
        /// <summary>
        /// Provides additional info to the ListViewItem.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public static ListViewItem AddInfo(this ListViewItem item, object tag = null, string tooltip = null)
        {
            item.Tag = tag;
            item.ToolTipText = tooltip;
            return item;
        }

        /// <summary>
        /// Recursively finds all child controls of specified type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        /// <returns></returns>
        public static IEnumerable<T> FindAllChildrenByType<T>(this Control control)
        {
            IEnumerable<Control> controls = control.Controls.Cast<Control>();
            return controls
                .OfType<T>()
                .Concat<T>(controls.SelectMany<Control, T>(ctrl => FindAllChildrenByType<T>(ctrl)));
        }
    }
}
