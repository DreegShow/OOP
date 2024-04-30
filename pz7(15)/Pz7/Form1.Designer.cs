namespace Pz7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtTrnslation = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDictionary = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(271, 126);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 20);
            this.txtWord.TabIndex = 9;
            this.txtWord.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            // 
            // txtTrnslation
            // 
            this.txtTrnslation.Location = new System.Drawing.Point(406, 126);
            this.txtTrnslation.Name = "txtTrnslation";
            this.txtTrnslation.Size = new System.Drawing.Size(100, 20);
            this.txtTrnslation.TabIndex = 8;
            this.txtTrnslation.TextChanged += new System.EventHandler(this.txtTrnslation_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(271, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(235, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Додати нове слово - переклад";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstDictionary
            // 
            this.lstDictionary.HideSelection = false;
            this.lstDictionary.Location = new System.Drawing.Point(213, 228);
            this.lstDictionary.Name = "lstDictionary";
            this.lstDictionary.Size = new System.Drawing.Size(350, 116);
            this.lstDictionary.TabIndex = 7;
            this.lstDictionary.UseCompatibleStateImageBehavior = false;
            this.lstDictionary.SelectedIndexChanged += new System.EventHandler(this.lstDictionary_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Слово";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(449, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Переклад";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDictionary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTrnslation);
            this.Controls.Add(this.txtWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtTrnslation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstDictionary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

