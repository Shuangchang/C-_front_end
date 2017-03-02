using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProgrammingProject3.Shuang
{
    public static class ListButtonExtensions
    {
        public static void CreateListButtons(this ListView listView, List<string> items)
        {
            var dataGridView = new DataGridView();
            foreach (var item in items)
            {
               if (!string.IsNullOrEmpty(item))
                {
                   var button = new Button();
                   button.Text = item;
                    
                } 
            }
            
        }

    }
}
