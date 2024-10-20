using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Converter
{
    /// <summary>
    /// MarkdownTableEntityクラス
    /// </summary>
    public class MarkdownTableEntity
    {
        /// <summary>
        /// 列Index
        /// </summary>
        public int ColIndex { get; set; }

        /// <summary>
        /// 行Index
        /// </summary>
        public int RowIndex { get; set; }

        /// <summary>
        /// 記載内容
        /// </summary>
        public string Content { get; set; }
    }
}
