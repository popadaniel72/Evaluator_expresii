
namespace Evaluator_expresii
{
    partial class Form1
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
            this.expr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.ListBox();
            this.pentruDesen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // expr
            // 
            this.expr.Location = new System.Drawing.Point(18, 18);
            this.expr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expr.Name = "expr";
            this.expr.Size = new System.Drawing.Size(478, 26);
            this.expr.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Arbore";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 20;
            this.lb.Location = new System.Drawing.Point(1038, 68);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(178, 624);
            this.lb.TabIndex = 2;
            // 
            // pentruDesen
            // 
            this.pentruDesen.Location = new System.Drawing.Point(18, 52);
            this.pentruDesen.Name = "pentruDesen";
            this.pentruDesen.Size = new System.Drawing.Size(1013, 459);
            this.pentruDesen.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 774);
            this.Controls.Add(this.pentruDesen);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.expr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox expr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Panel pentruDesen;
    }
}

