
namespace lab1_T5
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
            this.BtnTransparency = new System.Windows.Forms.Button();
            this.BtnBgColor = new System.Windows.Forms.Button();
            this.BtnHelloWorld = new System.Windows.Forms.Button();
            this.BtnSuperMegaButton = new System.Windows.Forms.Button();
            this.CheckboxTransparency = new System.Windows.Forms.CheckBox();
            this.CheckboxBgColor = new System.Windows.Forms.CheckBox();
            this.CheckboxHelloWorld = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnTransparency
            // 
            this.BtnTransparency.Location = new System.Drawing.Point(12, 12);
            this.BtnTransparency.Name = "BtnTransparency";
            this.BtnTransparency.Size = new System.Drawing.Size(107, 24);
            this.BtnTransparency.TabIndex = 0;
            this.BtnTransparency.Text = "Прозорість";
            this.BtnTransparency.UseVisualStyleBackColor = true;
            this.BtnTransparency.Click += new System.EventHandler(this.BtnTransparency_Click);
            // 
            // BtnBgColor
            // 
            this.BtnBgColor.Location = new System.Drawing.Point(135, 12);
            this.BtnBgColor.Name = "BtnBgColor";
            this.BtnBgColor.Size = new System.Drawing.Size(107, 24);
            this.BtnBgColor.TabIndex = 1;
            this.BtnBgColor.Text = "Колір тіла";
            this.BtnBgColor.UseVisualStyleBackColor = true;
            this.BtnBgColor.Click += new System.EventHandler(this.BtnBgColor_Click);
            // 
            // BtnHelloWorld
            // 
            this.BtnHelloWorld.Location = new System.Drawing.Point(259, 12);
            this.BtnHelloWorld.Name = "BtnHelloWorld";
            this.BtnHelloWorld.Size = new System.Drawing.Size(107, 24);
            this.BtnHelloWorld.TabIndex = 2;
            this.BtnHelloWorld.Text = "Hello World!";
            this.BtnHelloWorld.UseVisualStyleBackColor = true;
            this.BtnHelloWorld.Click += new System.EventHandler(this.BtnHelloWorld_Click);
            // 
            // BtnSuperMegaButton
            // 
            this.BtnSuperMegaButton.Location = new System.Drawing.Point(12, 53);
            this.BtnSuperMegaButton.Name = "BtnSuperMegaButton";
            this.BtnSuperMegaButton.Size = new System.Drawing.Size(353, 20);
            this.BtnSuperMegaButton.TabIndex = 3;
            this.BtnSuperMegaButton.Text = "СуперМегаКнопка";
            this.BtnSuperMegaButton.UseVisualStyleBackColor = true;
            this.BtnSuperMegaButton.Click += new System.EventHandler(this.BtnSuperMegaButton_Click);
            // 
            // CheckboxTransparency
            // 
            this.CheckboxTransparency.AutoSize = true;
            this.CheckboxTransparency.Location = new System.Drawing.Point(12, 94);
            this.CheckboxTransparency.Name = "CheckboxTransparency";
            this.CheckboxTransparency.Size = new System.Drawing.Size(237, 17);
            this.CheckboxTransparency.TabIndex = 4;
            this.CheckboxTransparency.Text = "\"СуперМегаКнопка\" поглинає прозорість";
            this.CheckboxTransparency.UseVisualStyleBackColor = true;
            this.CheckboxTransparency.CheckedChanged += new System.EventHandler(this.CheckboxTransparency_CheckedChanged);
            // 
            // CheckboxBgColor
            // 
            this.CheckboxBgColor.AutoSize = true;
            this.CheckboxBgColor.Location = new System.Drawing.Point(12, 117);
            this.CheckboxBgColor.Name = "CheckboxBgColor";
            this.CheckboxBgColor.Size = new System.Drawing.Size(230, 17);
            this.CheckboxBgColor.TabIndex = 5;
            this.CheckboxBgColor.Text = "\"СуперМегаКнопка\" поглинає колір тіла";
            this.CheckboxBgColor.UseVisualStyleBackColor = true;
            this.CheckboxBgColor.CheckedChanged += new System.EventHandler(this.CheckboxBgColor_CheckedChanged);
            // 
            // CheckboxHelloWorld
            // 
            this.CheckboxHelloWorld.AutoSize = true;
            this.CheckboxHelloWorld.Location = new System.Drawing.Point(12, 140);
            this.CheckboxHelloWorld.Name = "CheckboxHelloWorld";
            this.CheckboxHelloWorld.Size = new System.Drawing.Size(243, 17);
            this.CheckboxHelloWorld.TabIndex = 6;
            this.CheckboxHelloWorld.Text = "\"СуперМегаКнопка\" поглинає хелоу ворлд";
            this.CheckboxHelloWorld.UseVisualStyleBackColor = true;
            this.CheckboxHelloWorld.CheckedChanged += new System.EventHandler(this.CheckboxHelloWorld_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 218);
            this.Controls.Add(this.CheckboxHelloWorld);
            this.Controls.Add(this.CheckboxBgColor);
            this.Controls.Add(this.CheckboxTransparency);
            this.Controls.Add(this.BtnSuperMegaButton);
            this.Controls.Add(this.BtnHelloWorld);
            this.Controls.Add(this.BtnBgColor);
            this.Controls.Add(this.BtnTransparency);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTransparency;
        private System.Windows.Forms.Button BtnBgColor;
        private System.Windows.Forms.Button BtnHelloWorld;
        private System.Windows.Forms.Button BtnSuperMegaButton;
        private System.Windows.Forms.CheckBox CheckboxTransparency;
        private System.Windows.Forms.CheckBox CheckboxBgColor;
        private System.Windows.Forms.CheckBox CheckboxHelloWorld;
    }
}

