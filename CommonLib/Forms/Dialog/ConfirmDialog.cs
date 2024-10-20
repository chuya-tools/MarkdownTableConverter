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
    /// 汎用確認ダイアログFormクラス
    /// </summary>
    /// <remarks>
    /// OK<br></br>
    /// ... return DialogResult.OK<br></br>
    /// NG<br></br>
    /// ... return DialogResult.Cancel
    /// </remarks>
    public partial class ConfirmDialog : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="message">確認メッセージ</param>
        public ConfirmDialog(string message)
        {
            InitializeComponent();

            // ラベルにメッセージを記載する
            lblMessage.Text = message;
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

        /// <summary>
        /// キャンセルボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #pragma warning disable
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
