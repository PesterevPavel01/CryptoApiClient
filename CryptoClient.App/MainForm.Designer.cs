
namespace CryptoClient.App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            BinanceTable = new DataGridView();
            symbol = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            toolStrip1 = new ToolStrip();
            SymbolComboBox = new ToolStripComboBox();
            splitContainer2 = new SplitContainer();
            BinanceToolStrip = new ToolStrip();
            BinanceLabel = new ToolStripLabel();
            splitContainer3 = new SplitContainer();
            BybitTable = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            BybitToolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            splitContainer4 = new SplitContainer();
            KucoinTable = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            KucoinToolStrip = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            BitgetTable = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            BitgetToolStrip = new ToolStrip();
            toolStripLabel3 = new ToolStripLabel();
            splitContainer5 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)BinanceTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            BinanceToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BybitTable).BeginInit();
            BybitToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KucoinTable).BeginInit();
            KucoinToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BitgetTable).BeginInit();
            BitgetToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.SuspendLayout();
            SuspendLayout();
            // 
            // BinanceTable
            // 
            BinanceTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BinanceTable.BackgroundColor = SystemColors.HighlightText;
            BinanceTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BinanceTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BinanceTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BinanceTable.Columns.AddRange(new DataGridViewColumn[] { symbol, price });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N4";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BinanceTable.DefaultCellStyle = dataGridViewCellStyle3;
            BinanceTable.Dock = DockStyle.Fill;
            BinanceTable.GridColor = SystemColors.ControlLight;
            BinanceTable.Location = new Point(0, 40);
            BinanceTable.Name = "BinanceTable";
            BinanceTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            BinanceTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            BinanceTable.RowHeadersVisible = false;
            BinanceTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            BinanceTable.Size = new Size(208, 352);
            BinanceTable.TabIndex = 0;
            // 
            // symbol
            // 
            symbol.DataPropertyName = "symbol";
            symbol.HeaderText = "Symbol";
            symbol.Name = "symbol";
            symbol.ReadOnly = true;
            // 
            // price
            // 
            price.DataPropertyName = "price";
            dataGridViewCellStyle2.Format = "N4";
            dataGridViewCellStyle2.NullValue = null;
            price.DefaultCellStyle = dataGridViewCellStyle2;
            price.HeaderText = "Price";
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(835, 438);
            splitContainer1.SplitterDistance = 45;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = SystemColors.ControlLight;
            toolStrip1.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { SymbolComboBox });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(835, 40);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // SymbolComboBox
            // 
            SymbolComboBox.BackColor = SystemColors.HighlightText;
            SymbolComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SymbolComboBox.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SymbolComboBox.Name = "SymbolComboBox";
            SymbolComboBox.Size = new Size(200, 40);
            SymbolComboBox.SelectedIndexChanged += SymbolComboBox_SelectedIndexChanged;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(BinanceTable);
            splitContainer2.Panel1.Controls.Add(BinanceToolStrip);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(835, 392);
            splitContainer2.SplitterDistance = 208;
            splitContainer2.TabIndex = 0;
            // 
            // BinanceToolStrip
            // 
            BinanceToolStrip.AutoSize = false;
            BinanceToolStrip.BackColor = SystemColors.Window;
            BinanceToolStrip.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BinanceToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            BinanceToolStrip.Items.AddRange(new ToolStripItem[] { BinanceLabel });
            BinanceToolStrip.Location = new Point(0, 0);
            BinanceToolStrip.Name = "BinanceToolStrip";
            BinanceToolStrip.Size = new Size(208, 40);
            BinanceToolStrip.TabIndex = 1;
            BinanceToolStrip.Text = "toolStrip1";
            // 
            // BinanceLabel
            // 
            BinanceLabel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BinanceLabel.Name = "BinanceLabel";
            BinanceLabel.Size = new Size(65, 37);
            BinanceLabel.Text = "Binance";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.FixedPanel = FixedPanel.Panel1;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.BackColor = SystemColors.HighlightText;
            splitContainer3.Panel1.Controls.Add(BybitTable);
            splitContainer3.Panel1.Controls.Add(BybitToolStrip);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new Size(623, 392);
            splitContainer3.SplitterDistance = 204;
            splitContainer3.TabIndex = 0;
            // 
            // BybitTable
            // 
            BybitTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BybitTable.BackgroundColor = SystemColors.HighlightText;
            BybitTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            BybitTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            BybitTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BybitTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            BybitTable.DefaultCellStyle = dataGridViewCellStyle7;
            BybitTable.Dock = DockStyle.Fill;
            BybitTable.GridColor = SystemColors.ControlLight;
            BybitTable.Location = new Point(0, 40);
            BybitTable.Name = "BybitTable";
            BybitTable.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle8.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            BybitTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            BybitTable.RowHeadersVisible = false;
            BybitTable.Size = new Size(204, 352);
            BybitTable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "symbol";
            dataGridViewTextBoxColumn1.HeaderText = "Symbol";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "price";
            dataGridViewCellStyle6.Format = "N4";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTextBoxColumn2.HeaderText = "Price";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // BybitToolStrip
            // 
            BybitToolStrip.AutoSize = false;
            BybitToolStrip.BackColor = SystemColors.Window;
            BybitToolStrip.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BybitToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            BybitToolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            BybitToolStrip.Location = new Point(0, 0);
            BybitToolStrip.Name = "BybitToolStrip";
            BybitToolStrip.Size = new Size(204, 40);
            BybitToolStrip.TabIndex = 2;
            BybitToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(46, 37);
            toolStripLabel1.Text = "Bybit";
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.FixedPanel = FixedPanel.Panel1;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.BackColor = SystemColors.HighlightText;
            splitContainer4.Panel1.Controls.Add(KucoinTable);
            splitContainer4.Panel1.Controls.Add(KucoinToolStrip);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.BackColor = SystemColors.HighlightText;
            splitContainer4.Panel2.Controls.Add(BitgetTable);
            splitContainer4.Panel2.Controls.Add(BitgetToolStrip);
            splitContainer4.Size = new Size(415, 392);
            splitContainer4.SplitterDistance = 204;
            splitContainer4.TabIndex = 0;
            // 
            // KucoinTable
            // 
            KucoinTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            KucoinTable.BackgroundColor = SystemColors.HighlightText;
            KucoinTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle9.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            KucoinTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            KucoinTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KucoinTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            KucoinTable.DefaultCellStyle = dataGridViewCellStyle11;
            KucoinTable.Dock = DockStyle.Fill;
            KucoinTable.GridColor = SystemColors.ControlLight;
            KucoinTable.Location = new Point(0, 40);
            KucoinTable.Name = "KucoinTable";
            KucoinTable.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle12.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.Padding = new Padding(2);
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            KucoinTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            KucoinTable.RowHeadersVisible = false;
            KucoinTable.Size = new Size(204, 352);
            KucoinTable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "symbol";
            dataGridViewTextBoxColumn3.HeaderText = "Symbol";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "price";
            dataGridViewCellStyle10.Format = "N4";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // KucoinToolStrip
            // 
            KucoinToolStrip.AutoSize = false;
            KucoinToolStrip.BackColor = SystemColors.Window;
            KucoinToolStrip.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KucoinToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            KucoinToolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel2 });
            KucoinToolStrip.Location = new Point(0, 0);
            KucoinToolStrip.Name = "KucoinToolStrip";
            KucoinToolStrip.Size = new Size(204, 40);
            KucoinToolStrip.TabIndex = 2;
            KucoinToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(59, 37);
            toolStripLabel2.Text = "Kucoin";
            // 
            // BitgetTable
            // 
            BitgetTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BitgetTable.BackgroundColor = SystemColors.HighlightText;
            BitgetTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle13.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.Padding = new Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            BitgetTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            BitgetTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BitgetTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.Padding = new Padding(2);
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            BitgetTable.DefaultCellStyle = dataGridViewCellStyle15;
            BitgetTable.Dock = DockStyle.Fill;
            BitgetTable.GridColor = SystemColors.ControlLight;
            BitgetTable.Location = new Point(0, 40);
            BitgetTable.Name = "BitgetTable";
            BitgetTable.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle16.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.Padding = new Padding(2);
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            BitgetTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            BitgetTable.RowHeadersVisible = false;
            BitgetTable.Size = new Size(207, 352);
            BitgetTable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "symbol";
            dataGridViewTextBoxColumn5.HeaderText = "Symbol";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "price";
            dataGridViewCellStyle14.Format = "N4";
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewTextBoxColumn6.HeaderText = "Price";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // BitgetToolStrip
            // 
            BitgetToolStrip.AutoSize = false;
            BitgetToolStrip.BackColor = SystemColors.Window;
            BitgetToolStrip.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BitgetToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            BitgetToolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel3 });
            BitgetToolStrip.Location = new Point(0, 0);
            BitgetToolStrip.Name = "BitgetToolStrip";
            BitgetToolStrip.Size = new Size(207, 40);
            BitgetToolStrip.TabIndex = 2;
            BitgetToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(53, 37);
            toolStripLabel3.Text = "Bitget";
            // 
            // splitContainer5
            // 
            splitContainer5.BorderStyle = BorderStyle.FixedSingle;
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.FixedPanel = FixedPanel.Panel1;
            splitContainer5.Location = new Point(5, 5);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(splitContainer1);
            splitContainer5.Size = new Size(1531, 440);
            splitContainer5.SplitterDistance = 837;
            splitContainer5.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1541, 450);
            Controls.Add(splitContainer5);
            Name = "MainForm";
            Padding = new Padding(5);
            Text = "Клиент";
            ((System.ComponentModel.ISupportInitialize)BinanceTable).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            BinanceToolStrip.ResumeLayout(false);
            BinanceToolStrip.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BybitTable).EndInit();
            BybitToolStrip.ResumeLayout(false);
            BybitToolStrip.PerformLayout();
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)KucoinTable).EndInit();
            KucoinToolStrip.ResumeLayout(false);
            KucoinToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BitgetTable).EndInit();
            BitgetToolStrip.ResumeLayout(false);
            BitgetToolStrip.PerformLayout();
            splitContainer5.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView BinanceTable;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private ToolStrip BinanceToolStrip;
        private DataGridView BybitTable;
        private DataGridView KucoinTable;
        private DataGridView BitgetTable;
        private ToolStripLabel BinanceLabel;
        private ToolStrip BybitToolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStrip KucoinToolStrip;
        private ToolStripLabel toolStripLabel2;
        private ToolStrip BitgetToolStrip;
        private ToolStripLabel toolStripLabel3;
        private SplitContainer splitContainer5;
        private ToolStrip toolStrip1;
        private ToolStripComboBox SymbolComboBox;
        private DataGridViewTextBoxColumn symbol;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
