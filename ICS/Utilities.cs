using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ICS.Views
{
    public static class Utilities
    {
        public static void  ClearTextBoxes(Control parent)
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
                    
                }  
            }
        }
    }
}