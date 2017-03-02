using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClientProgrammingProject3.Shuang
{
    public static class ListViewExtensions
    {
        public static bool TryAddItem(this ListView listView, string item)
        {
            var ifAdded = false;

            if (!string.IsNullOrEmpty(item))
            {
                listView.Items.Add(NormalizeItem(item));
                ifAdded = true;
            }

            return ifAdded;
        }

        public static bool TryAddItem(this ListView listView, ListViewItem item)
        {
            var ifAdded = false;

            if (item != null)
            {
                listView.Items.Add(item);
                ifAdded = true;
            }

            return ifAdded;
        }

        public static bool TryAddItems(this ListView listView, List<string> items)
        {
            var result = false;
            if (items != null && items.Count > 0)
            {
                foreach (var item in items)
                {
                    result = TryAddItem(listView, item);
                }
            }

            return result;
        }

        private static string NormalizeItem(string input)
        {
            return (input.First().ToString().ToUpper() + input.Substring(1)).TrimStart().TrimEnd();
        }
    }
}
