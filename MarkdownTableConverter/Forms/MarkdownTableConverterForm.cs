using CommonLib.Converter;
using CommonLib.Exceptions;
using CommonLib.Forms.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace MarkdownTableConverter.Forms
{
    /// <summary>
    /// MarkdownTableConverterFormクラス
    /// </summary>
    public partial class MarkdownTableConverterForm : Form
    {
        /// <summary>
        /// 現在のマウス位置
        /// </summary>
        private DataGridViewCellEventArgs currentMousePosition;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MarkdownTableConverterForm()
        {
            InitializeComponent();
        }

#region Markdown

        /// <summary>
        /// Markdown から Table へ 変換
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarkdownToTable_Click(object sender, EventArgs e)
        {
            try
            {
                // 空文字の場合エラー
                if (txtMarkdown.Text.Equals(string.Empty))
                {
                    new ErrorDialog("Markdownを入力してください。").ShowDialog();
                    return;
                }

                // dgvTableが入力されていたら確認する
                if (dgvTable.Rows.Count > 1)
                {
                    DialogResult result = new ConfirmDialog("Tableが編集されています。\r\n上書きしますが、よろしいですか？").ShowDialog();
                    if (result != DialogResult.OK)
                    {
                        return;
                    }
                }

                // 変換実行
                ConvertMarkdownToTable();
            }
            catch (MarkdownConverterCommonException ex)
            {
                string exMessage = string.Empty;
                if (!ex.Message.StartsWith("種類"))
                {
                    exMessage = ex.Message;
                }
                else
                {
                    exMessage = "Markdownの文法が正しくありません。\r\nTable形式で入力されていることを確認し、\r\n再度変換してください。";
                }
                new ErrorDialog(exMessage).ShowDialog();
            }
            catch (MarkdownConverterInvalidColumnException ex)
            {
                string exMessage = string.Empty;
                if (!ex.Message.StartsWith("種類"))
                {
                    exMessage = ex.Message;
                }
                else
                {
                    exMessage = "列数が合わないため、変換に失敗しました。\r\n（成功したところは変換・表示しています）";
                }
                new ErrorDialog(exMessage).ShowDialog();
            }
        }

        /// <summary>
        /// Markdownのリセット
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarkdownReset_Click(object sender, EventArgs e)
        {
            // ダイアログ表示
            ConfirmDialog dialog = new ConfirmDialog("マークダウンをリセットします。\r\nよろしいですか？");
            DialogResult result = dialog.ShowDialog();

            // DialogResultを確認
            if (result == DialogResult.OK)
            {
                txtMarkdown.Text = string.Empty;
            }
        }

        /// <summary>
        /// MarkdownからTableへ変換
        /// </summary>
        private void ConvertMarkdownToTable()
        {
            // レイアウト更新をsuspendする
            this.SuspendLayout();

            // List作成
            var entityList = MarkdownConverter.MarkdownToList(txtMarkdown.Text);

            // 行数を定義(ヘッダーを考慮)
            var rowCount = entityList.Max(x => x.RowIndex);
            // 列数を定義
            var colCount = entityList.Max(x => x.ColIndex) + 1;

            // ヘッダー行の要素
            var headerEntityList = entityList.FindAll(x => x.RowIndex == 0).OrderBy(x => x.ColIndex).ToList();
            // ヘッダーより下の行
            var contentEntityList = entityList.FindAll(x => x.RowIndex > 0).OrderBy(x => x.RowIndex).ThenBy(x => x.ColIndex).ToList();
            // DataGridViewを初期化
            this.dgvTable.Rows.Clear();
            this.dgvTable.Columns.Clear();

            // ヘッダー行を定義
            try
            {
                for (int i = 0; i < colCount; i++)
                {
                    var temp = headerEntityList.Find(x => x.ColIndex == i);
                    this.dgvTable.Columns.Add(string.Format("Col_{0}", i), temp.Content);
                }

                // ヘッダーより下の行を定義する
                for (int row = 0; row < rowCount; row++)
                {
                    var arr = new List<string>();

                    for (int col = 0; col < colCount; col++)
                    {
                        var temp = contentEntityList[colCount * row + col];
                        arr.Add(temp.Content);
                    }

                    dgvTable.Rows.Add(arr.ToArray());
                }
            }
            catch
            {
                throw new MarkdownConverterInvalidColumnException();
            }

            // FIXME: Markdownの内容に合わせてDataGridViewの列幅を自動で設定できるようにしたい

            // レイアウト更新を再開する
            this.ResumeLayout(false);
        }

#endregion

#region Table

        /// <summary>
        /// Tableのカラム追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTableAddColumn_Click(object sender, EventArgs e)
        {
            // 何となく7列を超えるときは列追加をストップする(まじでなんとなく)
            if (dgvTable.Columns.Count > 6)
            {
                new ErrorDialog("これ以上列を増やすことはできません。\r\n（列の上限は7つまでです）").ShowDialog();
                return;
            }

            // レイアウト更新をsuspendする
            this.SuspendLayout();

            int count = this.dgvTable.Columns.Count;

            // Fillカラムを末尾に追加する
            this.dgvTable.Columns.Add(string.Format("Col_{0}", count), string.Format("列名{0}", count));
            this.dgvTable.Columns[count].MinimumWidth = 200;
            this.dgvTable.Columns[count].Resizable = DataGridViewTriState.True;

            // レイアウト更新を再開する
            this.ResumeLayout(false);
        }

        /// <summary>
        /// Table から Markdown へ 変換
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTableToMarkdown_Click(object sender, EventArgs e)
        {
            // Markdown入力済みの場合は確認
            if (!txtMarkdown.Text.Equals(string.Empty))
            {
                DialogResult result = new ConfirmDialog("Markdownが編集されています。\r\n上書きしますが、よろしいですか？").ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }
            }

            // 変換実行
            string markdownText = MarkdownConverter.DgvToMarkdown(this.dgvTable);
            txtMarkdown.Text = markdownText;
        }

        /// <summary>
        /// Tableのリセット
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTableReset_Click(object sender, EventArgs e)
        {
            // ダイアログ表示
            DialogResult result = new ConfirmDialog("テーブルをリセットします。よろしいですか？").ShowDialog();
            if (result == DialogResult.OK)
            {
                // DataGridViewをリセットする
                ResetDgvTable();
            }
        }

        /// <summary>
        /// DataGridViewをリセットする
        /// </summary>
        private void ResetDgvTable()
        {
            // レイアウト更新をsuspendする
            this.SuspendLayout();

            // 行削除
            this.dgvTable.Rows.Clear();

            // 列削除
            this.dgvTable.Columns.Clear();

            // 列をデフォルトの状態に戻す
            for (int i = 0; i < 4; i++)
            {
                // カラム作成
                this.dgvTable.Columns.Add(string.Format("Col_{0}", i), string.Format("列名{0}", i));

                // 幅調整
                this.dgvTable.Columns[i].Resizable = DataGridViewTriState.True;
                this.dgvTable.Columns[i].Width = 200;
            }

            // レイアウト更新を再開する
            this.ResumeLayout(false);
        }

        #endregion

#region コンテキストメニュー
        private void itemRename_Click(object sender, EventArgs e)
        {
            // 入力文字列を初期化
            string inputText = string.Empty;
            // ダイアログ表示
            DialogResult result = new TextboxDialog("新しい列名：").CustomShowDialog(out inputText);

            // キャンセルが押下された場合は処理終了
            if (result != DialogResult.OK)
            {
                return;
            }

            // 入力された文字列をヘッダーに反映する
            this.dgvTable.Columns[currentMousePosition.ColumnIndex].HeaderCell.Value = inputText;
        }

        private void itemDeleteColumn_Click(object sender, EventArgs e)
        {
            // 現在のカラムヘッダーの名称を保持する
            string columnHeaderText = (string)this.dgvTable.Columns[currentMousePosition.ColumnIndex].HeaderCell.Value;
            // ダイアログ表示
            DialogResult result = new ConfirmDialog(string.Format("列「{0}」を削除します。\r\nよろしいですか？", columnHeaderText)).ShowDialog();
            
            // キャンセルが押下された場合は処理終了
            if (result != DialogResult.OK)
            {
                return;
            }

            // カラムを削除する
            this.dgvTable.Columns.RemoveAt(currentMousePosition.ColumnIndex);
        }

        /// <summary>
        /// コンテキストメニュー表示制御(カラムヘッダー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuColumnHeader_Opening(object sender, CancelEventArgs e)
        {
            // ヘッダー以外の場合はセル用コンテキストメニューを表示する
            if (currentMousePosition.RowIndex != -1)
            {
                this.dgvTable.ContextMenuStrip = this.menuCell;
                e.Cancel = true;
                this.menuCell.Show(MousePosition);
            }
            else
            {
                this.dgvTable.ContextMenuStrip = this.menuColumnHeader;
                e.Cancel = false;
            }
        }
        
        /// <summary>
        /// コンテキストメニュー表示制御(セル)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuCell_Opening(object sender, CancelEventArgs e)
        {
            // ヘッダーの場合はヘッダー用コンテキストメニューを表示する
            if (currentMousePosition.RowIndex == -1)
            {
                this.dgvTable.ContextMenuStrip = this.menuColumnHeader;
                e.Cancel = true;
                this.menuColumnHeader.Show(MousePosition);
            }
            else
            {
                this.dgvTable.ContextMenuStrip = this.menuCell;
                e.Cancel = false;

                // 「削除」を押下できないようにする
                if (this.dgvTable.Rows.Count <= 1)
                {
                    itemDeleteRow.Enabled = false;
                }
                else
                {
                    itemDeleteRow.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 選択されたセルを含む行を削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemDeleteRow_Click(object sender, EventArgs e)
        {
            // ダイアログ表示
            DialogResult result = new ConfirmDialog("選択されたセルを含む行を削除します。\r\nよろしいですか？").ShowDialog();

            // キャンセルが押下された場合は処理終了
            if (result != DialogResult.OK)
            {
                return;
            }

            // 行を削除
            this.dgvTable.Rows.RemoveAt(currentMousePosition.RowIndex);
        }

        /// <summary>
        /// CellMouseEnterイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // 現在のマウス位置を保持しておく
            currentMousePosition = e;
        }

#endregion
    }
}
