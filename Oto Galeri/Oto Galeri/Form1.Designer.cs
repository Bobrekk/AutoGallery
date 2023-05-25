
namespace Oto_Galeri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cBox_yakıttipi = new System.Windows.Forms.ComboBox();
            this.cBox_model = new System.Windows.Forms.ComboBox();
            this.cBox_marka = new System.Windows.Forms.ComboBox();
            this.tBox_ruhsat = new System.Windows.Forms.TextBox();
            this.tBox_fiyat = new System.Windows.Forms.TextBox();
            this.tBox_km = new System.Windows.Forms.TextBox();
            this.cBox_kasatipi = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruhsat No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yakıt Tipi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(263, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kasa Tipi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(263, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kilometre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(263, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fiyat:";
            // 
            // cBox_yakıttipi
            // 
            this.cBox_yakıttipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_yakıttipi.FormattingEnabled = true;
            this.cBox_yakıttipi.Items.AddRange(new object[] {
            "Benzinli",
            "Dizel",
            "Lpg"});
            this.cBox_yakıttipi.Location = new System.Drawing.Point(125, 149);
            this.cBox_yakıttipi.Name = "cBox_yakıttipi";
            this.cBox_yakıttipi.Size = new System.Drawing.Size(121, 24);
            this.cBox_yakıttipi.TabIndex = 7;
            // 
            // cBox_model
            // 
            this.cBox_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_model.FormattingEnabled = true;
            this.cBox_model.Location = new System.Drawing.Point(125, 105);
            this.cBox_model.Name = "cBox_model";
            this.cBox_model.Size = new System.Drawing.Size(121, 24);
            this.cBox_model.TabIndex = 8;
            // 
            // cBox_marka
            // 
            this.cBox_marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_marka.FormattingEnabled = true;
            this.cBox_marka.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "Opel"});
            this.cBox_marka.Location = new System.Drawing.Point(125, 62);
            this.cBox_marka.Name = "cBox_marka";
            this.cBox_marka.Size = new System.Drawing.Size(121, 24);
            this.cBox_marka.TabIndex = 9;
            this.cBox_marka.SelectedIndexChanged += new System.EventHandler(this.cBox_marka_SelectedIndexChanged);
            // 
            // tBox_ruhsat
            // 
            this.tBox_ruhsat.Location = new System.Drawing.Point(125, 22);
            this.tBox_ruhsat.Name = "tBox_ruhsat";
            this.tBox_ruhsat.Size = new System.Drawing.Size(121, 22);
            this.tBox_ruhsat.TabIndex = 10;
            // 
            // tBox_fiyat
            // 
            this.tBox_fiyat.Location = new System.Drawing.Point(356, 147);
            this.tBox_fiyat.Name = "tBox_fiyat";
            this.tBox_fiyat.Size = new System.Drawing.Size(121, 22);
            this.tBox_fiyat.TabIndex = 11;
            // 
            // tBox_km
            // 
            this.tBox_km.Location = new System.Drawing.Point(356, 103);
            this.tBox_km.Name = "tBox_km";
            this.tBox_km.Size = new System.Drawing.Size(121, 22);
            this.tBox_km.TabIndex = 12;
            // 
            // cBox_kasatipi
            // 
            this.cBox_kasatipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_kasatipi.FormattingEnabled = true;
            this.cBox_kasatipi.Items.AddRange(new object[] {
            "Sedan",
            "Hatchback"});
            this.cBox_kasatipi.Location = new System.Drawing.Point(356, 62);
            this.cBox_kasatipi.Name = "cBox_kasatipi";
            this.cBox_kasatipi.Size = new System.Drawing.Size(121, 24);
            this.cBox_kasatipi.TabIndex = 13;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_search.Location = new System.Drawing.Point(266, 18);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 32);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "ARA";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_save.Location = new System.Drawing.Point(56, 197);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(92, 35);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "KAYDET";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.Location = new System.Drawing.Point(319, 197);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(120, 35);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete.Location = new System.Drawing.Point(188, 197);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(92, 35);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(28, 271);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(999, 167);
            this.data.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cBox_kasatipi);
            this.Controls.Add(this.tBox_km);
            this.Controls.Add(this.tBox_fiyat);
            this.Controls.Add(this.tBox_ruhsat);
            this.Controls.Add(this.cBox_marka);
            this.Controls.Add(this.cBox_model);
            this.Controls.Add(this.cBox_yakıttipi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Oto Galeri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBox_yakıttipi;
        private System.Windows.Forms.ComboBox cBox_model;
        private System.Windows.Forms.ComboBox cBox_marka;
        private System.Windows.Forms.TextBox tBox_ruhsat;
        private System.Windows.Forms.TextBox tBox_fiyat;
        private System.Windows.Forms.TextBox tBox_km;
        private System.Windows.Forms.ComboBox cBox_kasatipi;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView data;
    }
}

