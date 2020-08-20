using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ICS.Views
{
    public static class Utilities
    {
        public static void  ClearControl(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                if (child is TextBox)
                {
                    TextBox textBox = child as TextBox;
                    child.Text = string.Empty;
                }else if(child is ComboBox){
                    ComboBox combobox = child as ComboBox;
                    if (combobox.Items.Count>0)
                    {
                        combobox.SelectedIndex = 0;
                    }                    
                }else if(child is Label) {
                    Label label = child as Label;
                    if (label.Name.StartsWith("lblErr"))
                    {
                        label.Text = string.Empty;
                    }

                }
            }
        }
    }
}