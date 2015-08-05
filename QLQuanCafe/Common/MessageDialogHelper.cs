using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace QLQuanCafe.Common
{
    public class MessageDialogHelper
    {
        public static DialogResult CreateErrorMessage(string content)
        {

            return MessageBox.Show(content, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult CreateInformationMessage(string content)
        {
            return MessageBox.Show(content, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult CreateQuestionMessage(string content)
        {
            return MessageBox.Show(content, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
