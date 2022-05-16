using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ZDSPGC_Point_Of_Sale
{
    class FormUtilities
    {
        Form form;
        public FormUtilities(Form form) {
            this.form = form;
        }
        public void replaceControls(Panel panel, Form replacementForm) {
            panel.Controls.Clear();
            panel.Controls.Add(replacementForm);
            replacementForm.Show();
        }
    }
}
