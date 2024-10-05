using System.Drawing;
using System.Windows.Forms;

namespace Helpers
{
    public class UIHelper
    {
        public static void LoadDefaultStyle(Form actualForm)
        {
            Color primary = Color.FromArgb(108, 99, 255);
            Color black = Color.FromArgb(37, 37, 37);
            Color white = Color.FromArgb(247, 247, 247);

            foreach (Control control in actualForm.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).BackColor = primary;
                    ((Button)control).FlatStyle = FlatStyle.Flat;
                }
                else if (control is CheckBox)
                {

                }
                else if (control is RadioButton)
                {

                }
                else if (control is TextBox)
                {
                    ((TextBox)control).BackColor = white;
                    ((TextBox)control).BorderStyle = BorderStyle.None;
                    ((TextBox)control).Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
                }
                else if (control is Label)
                {
                    ((Label)control).FlatStyle = FlatStyle.Flat;
                    ((Label)control).ForeColor = white;
                }
            }
        }
    }
}