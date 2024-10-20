    using CommonLib.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonLib.Converter
{
    /// <summary>
    /// マークダウンコンバータクラス
    /// </summary>
    public class MarkdownConverter
    {
        /// <summary>
        /// MarkdownTable → Listへ変換
        /// </summary>
        /// <param name="rawText"></param>
        /// <returns></returns>
        public static List<MarkdownTableEntity> MarkdownToList(string rawText)
        {
            // rawTextからListを抽出
            List<string> rows = rawText.Replace("\r\n", "\n").Replace("\r", "\n").Split(new char[] { '\r', '\n' }).ToList();

            // セル内改行が行われている場合は直前のアイテムに付け足す
            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    int tempIndex = i;
                    while(true)
                    {
                        if (tempIndex != 0 && !rows[tempIndex].StartsWith("|"))
                        {
                            rows[tempIndex - 1] = string.Format("{0}\n{1}", rows[tempIndex - 1], rows[tempIndex]);
                            rows.RemoveAt(tempIndex);

                            tempIndex--;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            rows.RemoveAll(x => x.Equals(string.Empty));

            // 戻り値初期化
            List<MarkdownTableEntity> ret = new List<MarkdownTableEntity>();

            // rowsに対して処理
            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++) 
                {
                    // "|"から始まっていなかったら例外をスローする
                    if (!rows[i].StartsWith("|"))
                    {
                        throw new MarkdownConverterCommonException();
                    }

                    List<string> itemList = rows[i].Split('|').ToList();
                    itemList.RemoveAt(itemList.Count - 1);
                    itemList.RemoveAt(0);

                    for (int j = 0; j < itemList.Count; j++)
                    {
                        MarkdownTableEntity temp = new MarkdownTableEntity();
                        temp.RowIndex = i;
                        temp.ColIndex = j;
                        temp.Content = itemList[j];
                        ret.Add(temp);
                    }
                }
            }

            // 戻り値返却
            return ret;
        }

        /// <summary>
        /// DataGridView → マークダウンへ変換
        /// </summary>
        /// <param name="dgvTable"></param>
        /// <returns></returns>
        public static string DgvToMarkdown(DataGridView dgvTable)
        {
            // 列数・行数を取得
            int colCount = dgvTable.Columns.Count;
            int rowCount = dgvTable.Rows.Count - 1;

            List<string> markdownList = new List<string>();

            // カラムヘッダーを取得する
            string colHeaderText = "|";
            for (int col = 0; col < colCount; col++)
            {
                var colHeader = dgvTable.Columns[col].HeaderText;
                colHeaderText = string.Format("{0}{1}|", colHeaderText, colHeader);
            }
            markdownList.Add(colHeaderText);

            // ヘッダー行以外を取得しMarkdownに変換
            for (int row = 0; row < rowCount; row++)
            {
                string rowStr = "|";

                for (int col = 0; col < colCount; col++)
                {
                    // \n を \r\n に変換する
                    var tempValue = (string)dgvTable[col, row].Value;
                    if (!string.IsNullOrEmpty(tempValue))
                    {
                        // \r\n がもしあれば、\nに一度変換する
                        tempValue = tempValue.Replace("\r\n", "\n").Replace("\n", "\r\n");
                    }

                    rowStr = string.Format("{0}{1}|", rowStr, tempValue);
                }

                markdownList.Add(rowStr);
            }

            string markdownText = string.Empty;

            for (int i = 0; i < markdownList.Count; i++)
            {
                markdownText = string.Format("{0}{1}", markdownText, markdownList[i]);

                if (i != markdownList.Count - 1)
                {
                    markdownText = string.Format("{0}{1}", markdownText, "\r\n");
                }
            }

            return markdownText;
        }
    }
}
