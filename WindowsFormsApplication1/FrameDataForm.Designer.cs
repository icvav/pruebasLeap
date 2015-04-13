namespace WindowsFormsApplication1
{
    partial class FrameDataForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.displayID = new System.Windows.Forms.Label();
            this.displayTimestamp = new System.Windows.Forms.Label();
            this.displayFPS = new System.Windows.Forms.Label();
            this.displayIsValid = new System.Windows.Forms.Label();
            this.displayGestureCount = new System.Windows.Forms.Label();
            this.displayImageCount = new System.Windows.Forms.Label();
            this.aux = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prueba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // displayID
            // 
            this.displayID.AutoSize = true;
            this.displayID.Location = new System.Drawing.Point(86, 13);
            this.displayID.Name = "displayID";
            this.displayID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayID.Size = new System.Drawing.Size(50, 13);
            this.displayID.TabIndex = 2;
            this.displayID.Text = "displayID";
            // 
            // displayTimestamp
            // 
            this.displayTimestamp.AutoSize = true;
            this.displayTimestamp.Location = new System.Drawing.Point(86, 26);
            this.displayTimestamp.Name = "displayTimestamp";
            this.displayTimestamp.Size = new System.Drawing.Size(35, 13);
            this.displayTimestamp.TabIndex = 3;
            this.displayTimestamp.Text = "label1";
            // 
            // displayFPS
            // 
            this.displayFPS.AutoSize = true;
            this.displayFPS.Location = new System.Drawing.Point(86, 43);
            this.displayFPS.Name = "displayFPS";
            this.displayFPS.Size = new System.Drawing.Size(35, 13);
            this.displayFPS.TabIndex = 4;
            this.displayFPS.Text = "label2";
            // 
            // displayIsValid
            // 
            this.displayIsValid.AutoSize = true;
            this.displayIsValid.Location = new System.Drawing.Point(86, 56);
            this.displayIsValid.Name = "displayIsValid";
            this.displayIsValid.Size = new System.Drawing.Size(35, 13);
            this.displayIsValid.TabIndex = 5;
            this.displayIsValid.Text = "label3";
            // 
            // displayGestureCount
            // 
            this.displayGestureCount.AutoSize = true;
            this.displayGestureCount.Location = new System.Drawing.Point(86, 73);
            this.displayGestureCount.Name = "displayGestureCount";
            this.displayGestureCount.Size = new System.Drawing.Size(35, 13);
            this.displayGestureCount.TabIndex = 6;
            this.displayGestureCount.Text = "label4";
            // 
            // displayImageCount
            // 
            this.displayImageCount.AutoSize = true;
            this.displayImageCount.Location = new System.Drawing.Point(86, 90);
            this.displayImageCount.Name = "displayImageCount";
            this.displayImageCount.Size = new System.Drawing.Size(35, 13);
            this.displayImageCount.TabIndex = 7;
            this.displayImageCount.Text = "label1";
            // 
            // aux
            // 
            this.aux.AutoSize = true;
            this.aux.Location = new System.Drawing.Point(86, 238);
            this.aux.Name = "aux";
            this.aux.Size = new System.Drawing.Size(35, 13);
            this.aux.TabIndex = 8;
            this.aux.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Frame ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Timestamp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "FPS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Is valid:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "GestureCount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ImageCount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Aux:";
            // 
            // prueba
            // 
            this.prueba.AutoSize = true;
            this.prueba.Location = new System.Drawing.Point(292, 90);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(35, 13);
            this.prueba.TabIndex = 16;
            this.prueba.Text = "label8";
            // 
            // FrameDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 550);
            this.Controls.Add(this.prueba);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aux);
            this.Controls.Add(this.displayImageCount);
            this.Controls.Add(this.displayGestureCount);
            this.Controls.Add(this.displayIsValid);
            this.Controls.Add(this.displayFPS);
            this.Controls.Add(this.displayTimestamp);
            this.Controls.Add(this.displayID);
            this.Controls.Add(this.button1);
            this.Name = "FrameDataForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label displayID;
        private System.Windows.Forms.Label displayTimestamp;
        private System.Windows.Forms.Label displayFPS;
        private System.Windows.Forms.Label displayIsValid;
        private System.Windows.Forms.Label displayGestureCount;
        private System.Windows.Forms.Label displayImageCount;
        private System.Windows.Forms.Label aux;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label prueba;
    }
}

