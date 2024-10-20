namespace MarkdownTableConverter.Forms
{
    partial class MarkdownTableConverterForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.btnMarkdownToTable = new System.Windows.Forms.Button();
            this.txtMarkdown = new System.Windows.Forms.TextBox();
            this.btnMarkdownReset = new System.Windows.Forms.Button();
            this.lblMarkdownDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTableToMarkdown = new System.Windows.Forms.Button();
            this.btnTableAddColumn = new System.Windows.Forms.Button();
            this.btnTableReset = new System.Windows.Forms.Button();
            this.lblTableDescription = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.Col_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuColumnHeader = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDeleteColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.menuColumnHeader.SuspendLayout();
            this.menuCell.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.btnMarkdownToTable);
            this.mainContainer.Panel1.Controls.Add(this.txtMarkdown);
            this.mainContainer.Panel1.Controls.Add(this.btnMarkdownReset);
            this.mainContainer.Panel1.Controls.Add(this.lblMarkdownDescription);
            this.mainContainer.Panel1.Controls.Add(this.label3);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.btnTableToMarkdown);
            this.mainContainer.Panel2.Controls.Add(this.btnTableAddColumn);
            this.mainContainer.Panel2.Controls.Add(this.btnTableReset);
            this.mainContainer.Panel2.Controls.Add(this.lblTableDescription);
            this.mainContainer.Panel2.Controls.Add(this.lblTable);
            this.mainContainer.Panel2.Controls.Add(this.dgvTable);
            this.mainContainer.Size = new System.Drawing.Size(1064, 681);
            this.mainContainer.SplitterDistance = 274;
            this.mainContainer.TabIndex = 0;
            // 
            // btnMarkdownToTable
            // 
            this.btnMarkdownToTable.BackColor = System.Drawing.Color.PaleGreen;
            this.btnMarkdownToTable.Location = new System.Drawing.Point(462, 8);
            this.btnMarkdownToTable.Name = "btnMarkdownToTable";
            this.btnMarkdownToTable.Size = new System.Drawing.Size(92, 23);
            this.btnMarkdownToTable.TabIndex = 2;
            this.btnMarkdownToTable.Text = "MD => Table";
            this.btnMarkdownToTable.UseVisualStyleBackColor = false;
            this.btnMarkdownToTable.Click += new System.EventHandler(this.btnMarkdownToTable_Click);
            // 
            // txtMarkdown
            // 
            this.txtMarkdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarkdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarkdown.Location = new System.Drawing.Point(3, 34);
            this.txtMarkdown.Multiline = true;
            this.txtMarkdown.Name = "txtMarkdown";
            this.txtMarkdown.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMarkdown.Size = new System.Drawing.Size(1058, 237);
            this.txtMarkdown.TabIndex = 4;
            // 
            // btnMarkdownReset
            // 
            this.btnMarkdownReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkdownReset.Location = new System.Drawing.Point(986, 8);
            this.btnMarkdownReset.Name = "btnMarkdownReset";
            this.btnMarkdownReset.Size = new System.Drawing.Size(75, 23);
            this.btnMarkdownReset.TabIndex = 3;
            this.btnMarkdownReset.Text = "Reset";
            this.btnMarkdownReset.UseVisualStyleBackColor = true;
            this.btnMarkdownReset.Click += new System.EventHandler(this.btnMarkdownReset_Click);
            // 
            // lblMarkdownDescription
            // 
            this.lblMarkdownDescription.AutoSize = true;
            this.lblMarkdownDescription.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMarkdownDescription.Location = new System.Drawing.Point(92, 12);
            this.lblMarkdownDescription.Name = "lblMarkdownDescription";
            this.lblMarkdownDescription.Size = new System.Drawing.Size(364, 14);
            this.lblMarkdownDescription.TabIndex = 1;
            this.lblMarkdownDescription.Text = "// paste or type markdown, then press \"MD => Table\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Markdown";
            // 
            // btnTableToMarkdown
            // 
            this.btnTableToMarkdown.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTableToMarkdown.Location = new System.Drawing.Point(484, 8);
            this.btnTableToMarkdown.Name = "btnTableToMarkdown";
            this.btnTableToMarkdown.Size = new System.Drawing.Size(92, 23);
            this.btnTableToMarkdown.TabIndex = 3;
            this.btnTableToMarkdown.Text = "Table => MD";
            this.btnTableToMarkdown.UseVisualStyleBackColor = false;
            this.btnTableToMarkdown.Click += new System.EventHandler(this.btnTableToMarkdown_Click);
            // 
            // btnTableAddColumn
            // 
            this.btnTableAddColumn.Location = new System.Drawing.Point(393, 8);
            this.btnTableAddColumn.Name = "btnTableAddColumn";
            this.btnTableAddColumn.Size = new System.Drawing.Size(85, 23);
            this.btnTableAddColumn.TabIndex = 2;
            this.btnTableAddColumn.Text = "Add Column";
            this.btnTableAddColumn.UseVisualStyleBackColor = true;
            this.btnTableAddColumn.Click += new System.EventHandler(this.btnTableAddColumn_Click);
            // 
            // btnTableReset
            // 
            this.btnTableReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTableReset.Location = new System.Drawing.Point(986, 8);
            this.btnTableReset.Name = "btnTableReset";
            this.btnTableReset.Size = new System.Drawing.Size(75, 23);
            this.btnTableReset.TabIndex = 4;
            this.btnTableReset.Text = "Reset";
            this.btnTableReset.UseVisualStyleBackColor = true;
            this.btnTableReset.Click += new System.EventHandler(this.btnTableReset_Click);
            // 
            // lblTableDescription
            // 
            this.lblTableDescription.AutoSize = true;
            this.lblTableDescription.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTableDescription.Location = new System.Drawing.Point(65, 12);
            this.lblTableDescription.Name = "lblTableDescription";
            this.lblTableDescription.Size = new System.Drawing.Size(322, 14);
            this.lblTableDescription.TabIndex = 1;
            this.lblTableDescription.Text = "// fill the content, then press \"Table => MD\"";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(5, 8);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(54, 19);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "Table";
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToOrderColumns = true;
            this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_0,
            this.Col_1,
            this.Col_2,
            this.Col_3});
            this.dgvTable.ContextMenuStrip = this.menuColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTable.Location = new System.Drawing.Point(3, 33);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowTemplate.Height = 21;
            this.dgvTable.Size = new System.Drawing.Size(1058, 367);
            this.dgvTable.TabIndex = 5;
            this.dgvTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellMouseEnter);
            // 
            // Col_0
            // 
            this.Col_0.HeaderText = "列名0";
            this.Col_0.MinimumWidth = 65;
            this.Col_0.Name = "Col_0";
            this.Col_0.Width = 200;
            // 
            // Col_1
            // 
            this.Col_1.HeaderText = "列名1";
            this.Col_1.MinimumWidth = 100;
            this.Col_1.Name = "Col_1";
            this.Col_1.Width = 200;
            // 
            // Col_2
            // 
            this.Col_2.HeaderText = "列名2";
            this.Col_2.MinimumWidth = 100;
            this.Col_2.Name = "Col_2";
            this.Col_2.Width = 200;
            // 
            // Col_3
            // 
            this.Col_3.HeaderText = "列名3";
            this.Col_3.MinimumWidth = 100;
            this.Col_3.Name = "Col_3";
            this.Col_3.Width = 200;
            // 
            // menuColumnHeader
            // 
            this.menuColumnHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemRename,
            this.itemDeleteColumn});
            this.menuColumnHeader.Name = "menuColumnHeader";
            this.menuColumnHeader.Size = new System.Drawing.Size(123, 48);
            this.menuColumnHeader.Opening += new System.ComponentModel.CancelEventHandler(this.menuColumnHeader_Opening);
            // 
            // itemRename
            // 
            this.itemRename.Name = "itemRename";
            this.itemRename.ShortcutKeyDisplayString = "";
            this.itemRename.Size = new System.Drawing.Size(122, 22);
            this.itemRename.Text = "名称変更";
            this.itemRename.Click += new System.EventHandler(this.itemRename_Click);
            // 
            // itemDeleteColumn
            // 
            this.itemDeleteColumn.Name = "itemDeleteColumn";
            this.itemDeleteColumn.Size = new System.Drawing.Size(122, 22);
            this.itemDeleteColumn.Text = "削除";
            this.itemDeleteColumn.Click += new System.EventHandler(this.itemDeleteColumn_Click);
            // 
            // menuCell
            // 
            this.menuCell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDeleteRow});
            this.menuCell.Name = "menuCell";
            this.menuCell.Size = new System.Drawing.Size(99, 26);
            this.menuCell.Opening += new System.ComponentModel.CancelEventHandler(this.menuCell_Opening);
            // 
            // itemDeleteRow
            // 
            this.itemDeleteRow.Name = "itemDeleteRow";
            this.itemDeleteRow.Size = new System.Drawing.Size(98, 22);
            this.itemDeleteRow.Text = "削除";
            this.itemDeleteRow.Click += new System.EventHandler(this.itemDeleteRow_Click);
            // 
            // MarkdownTableConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "MarkdownTableConverterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Markdown Table Converter";
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            this.mainContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.menuColumnHeader.ResumeLayout(false);
            this.menuCell.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Label lblTableDescription;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btnTableToMarkdown;
        private System.Windows.Forms.Button btnTableAddColumn;
        private System.Windows.Forms.TextBox txtMarkdown;
        private System.Windows.Forms.Label lblMarkdownDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTableReset;
        private System.Windows.Forms.Button btnMarkdownToTable;
        private System.Windows.Forms.Button btnMarkdownReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_3;
        private System.Windows.Forms.ContextMenuStrip menuColumnHeader;
        private System.Windows.Forms.ToolStripMenuItem itemRename;
        private System.Windows.Forms.ToolStripMenuItem itemDeleteColumn;
        private System.Windows.Forms.ContextMenuStrip menuCell;
        private System.Windows.Forms.ToolStripMenuItem itemDeleteRow;
    }
}

