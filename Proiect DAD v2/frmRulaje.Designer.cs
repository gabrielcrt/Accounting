
namespace Proiect_DAD_v2
{
    partial class frmRulaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label dataDocLabel;
            System.Windows.Forms.Label docLabel;
            System.Windows.Forms.Label explicatieLabel;
            System.Windows.Forms.Label numarLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRulaje));
            this.operatieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.operatieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataDocDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.docTextBox = new System.Windows.Forms.TextBox();
            this.explicatieTextBox = new System.Windows.Forms.TextBox();
            this.numarTextBox = new System.Windows.Forms.TextBox();
            this.rulajesDataGridView = new System.Windows.Forms.DataGridView();
            this.rulajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.idContDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sumaDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dataLabel = new System.Windows.Forms.Label();
            dataDocLabel = new System.Windows.Forms.Label();
            docLabel = new System.Windows.Forms.Label();
            explicatieLabel = new System.Windows.Forms.Label();
            numarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.operatieBindingNavigator)).BeginInit();
            this.operatieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulajesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataLabel.Location = new System.Drawing.Point(18, 119);
            dataLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(59, 25);
            dataLabel.TabIndex = 1;
            dataLabel.Text = "Data:";
            // 
            // dataDocLabel
            // 
            dataDocLabel.AutoSize = true;
            dataDocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataDocLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataDocLabel.Location = new System.Drawing.Point(443, 119);
            dataDocLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataDocLabel.Name = "dataDocLabel";
            dataDocLabel.Size = new System.Drawing.Size(99, 25);
            dataDocLabel.TabIndex = 3;
            dataDocLabel.Text = "Data Doc:";
            // 
            // docLabel
            // 
            docLabel.AutoSize = true;
            docLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            docLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            docLabel.Location = new System.Drawing.Point(443, 78);
            docLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            docLabel.Name = "docLabel";
            docLabel.Size = new System.Drawing.Size(53, 25);
            docLabel.TabIndex = 5;
            docLabel.Text = "Doc:";
            // 
            // explicatieLabel
            // 
            explicatieLabel.AutoSize = true;
            explicatieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            explicatieLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            explicatieLabel.Location = new System.Drawing.Point(17, 160);
            explicatieLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            explicatieLabel.Name = "explicatieLabel";
            explicatieLabel.Size = new System.Drawing.Size(101, 25);
            explicatieLabel.TabIndex = 7;
            explicatieLabel.Text = "Explicatie:";
            // 
            // numarLabel
            // 
            numarLabel.AutoSize = true;
            numarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numarLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            numarLabel.Location = new System.Drawing.Point(18, 78);
            numarLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            numarLabel.Name = "numarLabel";
            numarLabel.Size = new System.Drawing.Size(76, 25);
            numarLabel.TabIndex = 11;
            numarLabel.Text = "Numar:";
            // 
            // operatieBindingNavigator
            // 
            this.operatieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.operatieBindingNavigator.BindingSource = this.operatieBindingSource;
            this.operatieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.operatieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.operatieBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.operatieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.operatieBindingNavigatorSaveItem});
            this.operatieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.operatieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.operatieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.operatieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.operatieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.operatieBindingNavigator.Name = "operatieBindingNavigator";
            this.operatieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.operatieBindingNavigator.Size = new System.Drawing.Size(859, 27);
            this.operatieBindingNavigator.TabIndex = 0;
            this.operatieBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(74, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // operatieBindingNavigatorSaveItem
            // 
            this.operatieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.operatieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("operatieBindingNavigatorSaveItem.Image")));
            this.operatieBindingNavigatorSaveItem.Name = "operatieBindingNavigatorSaveItem";
            this.operatieBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.operatieBindingNavigatorSaveItem.Text = "Save Data";
            this.operatieBindingNavigatorSaveItem.Click += new System.EventHandler(this.operatieBindingNavigatorSaveItem_Click);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.operatieBindingSource, "Data", true));
            this.dataDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateTimePicker.Location = new System.Drawing.Point(117, 115);
            this.dataDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(298, 30);
            this.dataDateTimePicker.TabIndex = 2;
            // 
            // dataDocDateTimePicker
            // 
            this.dataDocDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.operatieBindingSource, "DataDoc", true));
            this.dataDocDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDocDateTimePicker.Location = new System.Drawing.Point(542, 114);
            this.dataDocDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataDocDateTimePicker.Name = "dataDocDateTimePicker";
            this.dataDocDateTimePicker.Size = new System.Drawing.Size(298, 30);
            this.dataDocDateTimePicker.TabIndex = 4;
            // 
            // docTextBox
            // 
            this.docTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operatieBindingSource, "Doc", true));
            this.docTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docTextBox.Location = new System.Drawing.Point(542, 77);
            this.docTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.docTextBox.Name = "docTextBox";
            this.docTextBox.Size = new System.Drawing.Size(298, 30);
            this.docTextBox.TabIndex = 6;
            // 
            // explicatieTextBox
            // 
            this.explicatieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operatieBindingSource, "Explicatie", true));
            this.explicatieTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explicatieTextBox.Location = new System.Drawing.Point(117, 156);
            this.explicatieTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.explicatieTextBox.Multiline = true;
            this.explicatieTextBox.Name = "explicatieTextBox";
            this.explicatieTextBox.Size = new System.Drawing.Size(723, 70);
            this.explicatieTextBox.TabIndex = 8;
            // 
            // numarTextBox
            // 
            this.numarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operatieBindingSource, "Numar", true));
            this.numarTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numarTextBox.Location = new System.Drawing.Point(117, 77);
            this.numarTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numarTextBox.Name = "numarTextBox";
            this.numarTextBox.Size = new System.Drawing.Size(298, 30);
            this.numarTextBox.TabIndex = 12;
            // 
            // rulajesDataGridView
            // 
            this.rulajesDataGridView.AutoGenerateColumns = false;
            this.rulajesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rulajesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContDataGridViewTextBoxColumn,
            this.sumaDDataGridViewTextBoxColumn,
            this.sumaCDataGridViewTextBoxColumn});
            this.rulajesDataGridView.DataSource = this.rulajesBindingSource;
            this.rulajesDataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.rulajesDataGridView.Location = new System.Drawing.Point(23, 235);
            this.rulajesDataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rulajesDataGridView.Name = "rulajesDataGridView";
            this.rulajesDataGridView.RowHeadersWidth = 51;
            this.rulajesDataGridView.RowTemplate.Height = 24;
            this.rulajesDataGridView.Size = new System.Drawing.Size(817, 354);
            this.rulajesDataGridView.TabIndex = 12;
            // 
            // rulajesBindingSource
            // 
            this.rulajesBindingSource.DataMember = "Rulajes";
            this.rulajesBindingSource.DataSource = this.operatieBindingSource;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(24, 598);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 71);
            this.button1.TabIndex = 13;
            this.button1.Text = "Revenire la meniu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idContDataGridViewTextBoxColumn
            // 
            this.idContDataGridViewTextBoxColumn.DataPropertyName = "idCont";
            this.idContDataGridViewTextBoxColumn.DataSource = this.contBindingSource;
            this.idContDataGridViewTextBoxColumn.DisplayMember = "Simbol";
            this.idContDataGridViewTextBoxColumn.HeaderText = "Simbol Cont";
            this.idContDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idContDataGridViewTextBoxColumn.Name = "idContDataGridViewTextBoxColumn";
            this.idContDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idContDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idContDataGridViewTextBoxColumn.ValueMember = "id";
            this.idContDataGridViewTextBoxColumn.Width = 125;
            // 
            // contBindingSource
            // 
            this.contBindingSource.DataSource = typeof(Proiect_DAD_v2.Cont);
            // 
            // sumaDDataGridViewTextBoxColumn
            // 
            this.sumaDDataGridViewTextBoxColumn.DataPropertyName = "SumaD";
            this.sumaDDataGridViewTextBoxColumn.HeaderText = "SumaD";
            this.sumaDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sumaDDataGridViewTextBoxColumn.Name = "sumaDDataGridViewTextBoxColumn";
            this.sumaDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sumaCDataGridViewTextBoxColumn
            // 
            this.sumaCDataGridViewTextBoxColumn.DataPropertyName = "SumaC";
            this.sumaCDataGridViewTextBoxColumn.HeaderText = "SumaC";
            this.sumaCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sumaCDataGridViewTextBoxColumn.Name = "sumaCDataGridViewTextBoxColumn";
            this.sumaCDataGridViewTextBoxColumn.Width = 125;
            // 
            // operatieBindingSource
            // 
            this.operatieBindingSource.DataSource = typeof(Proiect_DAD_v2.Operatie);
            // 
            // frmRulaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(859, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rulajesDataGridView);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(dataDocLabel);
            this.Controls.Add(this.dataDocDateTimePicker);
            this.Controls.Add(docLabel);
            this.Controls.Add(this.docTextBox);
            this.Controls.Add(explicatieLabel);
            this.Controls.Add(this.explicatieTextBox);
            this.Controls.Add(numarLabel);
            this.Controls.Add(this.numarTextBox);
            this.Controls.Add(this.operatieBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmRulaje";
            this.Text = "frmRulaje";
            this.Load += new System.EventHandler(this.frmRulaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.operatieBindingNavigator)).EndInit();
            this.operatieBindingNavigator.ResumeLayout(false);
            this.operatieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulajesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource operatieBindingSource;
        private System.Windows.Forms.BindingNavigator operatieBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton operatieBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataDocDateTimePicker;
        private System.Windows.Forms.TextBox docTextBox;
        private System.Windows.Forms.TextBox explicatieTextBox;
        private System.Windows.Forms.TextBox numarTextBox;
        private System.Windows.Forms.DataGridView rulajesDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource contBindingSource;
        private System.Windows.Forms.BindingSource rulajesBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn idContDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaCDataGridViewTextBoxColumn;
    }
}