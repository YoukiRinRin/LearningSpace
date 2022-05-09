namespace 拡張子変換アプリ
{
    partial class 拡張子変換アプリ
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
            this.button1 = new System.Windows.Forms.Button();
            this.dGV_Object = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dGV_except = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tx_af_ex = new System.Windows.Forms.TextBox();
            this.tx_bf_ex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_child = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_all = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Object)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_except)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "実行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGV_Object
            // 
            this.dGV_Object.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Object.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dGV_Object.Location = new System.Drawing.Point(12, 42);
            this.dGV_Object.Name = "dGV_Object";
            this.dGV_Object.RowTemplate.Height = 21;
            this.dGV_Object.Size = new System.Drawing.Size(243, 396);
            this.dGV_Object.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "複数フォルダを入力してください";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "除くフォルダ・ファイル";
            // 
            // dGV_except
            // 
            this.dGV_except.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_except.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dGV_except.Location = new System.Drawing.Point(437, 42);
            this.dGV_except.Name = "dGV_except";
            this.dGV_except.RowTemplate.Height = 21;
            this.dGV_except.Size = new System.Drawing.Size(243, 396);
            this.dGV_except.TabIndex = 12;
            this.dGV_except.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // tx_af_ex
            // 
            this.tx_af_ex.Location = new System.Drawing.Point(261, 100);
            this.tx_af_ex.Name = "tx_af_ex";
            this.tx_af_ex.Size = new System.Drawing.Size(156, 19);
            this.tx_af_ex.TabIndex = 14;
            // 
            // tx_bf_ex
            // 
            this.tx_bf_ex.Location = new System.Drawing.Point(261, 57);
            this.tx_bf_ex.Name = "tx_bf_ex";
            this.tx_bf_ex.Size = new System.Drawing.Size(156, 19);
            this.tx_bf_ex.TabIndex = 15;
            this.tx_bf_ex.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "対象の拡張子";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "変換後の拡張子";
            // 
            // cb_child
            // 
            this.cb_child.AutoSize = true;
            this.cb_child.Location = new System.Drawing.Point(263, 137);
            this.cb_child.Name = "cb_child";
            this.cb_child.Size = new System.Drawing.Size(133, 16);
            this.cb_child.TabIndex = 7;
            this.cb_child.Text = "子フォルダまで変換する";
            this.cb_child.UseVisualStyleBackColor = true;
            this.cb_child.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "オプション";
            // 
            // cb_all
            // 
            this.cb_all.AutoSize = true;
            this.cb_all.Location = new System.Drawing.Point(342, 40);
            this.cb_all.Name = "cb_all";
            this.cb_all.Size = new System.Drawing.Size(89, 16);
            this.cb_all.TabIndex = 8;
            this.cb_all.Text = "全てのファイル";
            this.cb_all.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "リセット";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 拡張子変換アプリ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_bf_ex);
            this.Controls.Add(this.tx_af_ex);
            this.Controls.Add(this.dGV_except);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_all);
            this.Controls.Add(this.cb_child);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_Object);
            this.Controls.Add(this.button1);
            this.Name = "拡張子変換アプリ";
            this.Text = "aq4";
            this.Load += new System.EventHandler(this.拡張子変換アプリ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Object)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_except)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dGV_Object;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGV_except;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox tx_af_ex;
        private System.Windows.Forms.TextBox tx_bf_ex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_child;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_all;
        private System.Windows.Forms.Button button2;
    }
}

