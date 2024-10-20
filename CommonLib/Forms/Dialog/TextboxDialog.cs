using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonLib.Forms.Dialog
{
    /// <summary>
    /// 汎用エラーダイアログFormクラス
    /// </summary>
    /// <remarks>
    /// OK<br></br>
    /// ... return DialogResult.OK
    /// </remarks>
    public partial class TextboxDialog : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="message">確認メッセージ</param>
        public TextboxDialog(string message)
        {
            InitializeComponent();

            // ラベルにメッセージを記載する
            lblMessage.Text = message;
        }

        public DialogResult CustomShowDialog(out string inputText)
        {
            var result = this.ShowDialog();

            inputText = txtInput.Text;

            return result;
        }

        /// <summary>
        /// OKボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #pragma warning disable
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
