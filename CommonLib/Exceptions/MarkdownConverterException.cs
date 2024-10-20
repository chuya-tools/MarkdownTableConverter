using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Exceptions
{
    /// <summary>
    /// MarkdownConverter汎用例外クラス
    /// </summary>
    public class MarkdownConverterCommonException : Exception
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="errorMessage"></param>
        public MarkdownConverterCommonException() : base() { }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="errorMessage"></param>
        public MarkdownConverterCommonException(string errorMessage) : base(errorMessage) { }
    }

    /// <summary>
    /// MarkdownConverterカラム異常例外クラス
    /// </summary>
    public class MarkdownConverterInvalidColumnException : Exception
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MarkdownConverterInvalidColumnException() : base() { }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="errorMessage"></param>
        public MarkdownConverterInvalidColumnException(string errorMessage) : base(errorMessage) { }
    }
}
