using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSiparis
{
   public static class KontrolTemizle
    {
        public static void TemizlemeMakinesi(Control.ControlCollection control) {
            foreach (Control item in control)
            {
                if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if (item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
                else if (item is RadioButton)
                {
                    if (((RadioButton)item).Name== "rdbInceKenar")
                    {
                        ((RadioButton)item).Checked = true;
                    }
                    else
                    {
                        ((RadioButton)item).Checked = true;
                    }
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 1;
                }
                else if (item is GroupBox)
                {
                    TemizlemeMakinesi(((GroupBox)item).Controls);
                }
                else if (item is ListBox)
                {
                    if (((ListBox)item).Name=="lstSepet")
                    {
                        ((ListBox)item).Items.Clear();
                    }
                    else if (((ListBox)item).Name == "lstPizzalar")
                    {
                        ((ListBox)item).SelectedItem = null;
                    }                 
                }
                else if (item is Label)
                {
                    if (((Label)item).Name== "lblToplamTutar")
                    {
                        ((Label)item).Text = string.Empty;
                    }
                }
            }
        }
    }
}
