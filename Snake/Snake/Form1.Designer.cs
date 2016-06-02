namespace Snake
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
            this.btn_StartSnake = new System.Windows.Forms.Button();
            this.lbl_NodesVisitedCount = new System.Windows.Forms.Label();
            this.lbl_CurrentNode = new System.Windows.Forms.Label();
            this.lbl_Path1 = new System.Windows.Forms.Label();
            this.lbl_Path2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_StartSnake
            // 
            this.btn_StartSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartSnake.Location = new System.Drawing.Point(114, 181);
            this.btn_StartSnake.Name = "btn_StartSnake";
            this.btn_StartSnake.Size = new System.Drawing.Size(231, 106);
            this.btn_StartSnake.TabIndex = 1;
            this.btn_StartSnake.Text = "Start Snake!";
            this.btn_StartSnake.UseVisualStyleBackColor = true;
            this.btn_StartSnake.Click += new System.EventHandler(this.btn_StartSnake_Click);
            // 
            // lbl_NodesVisitedCount
            // 
            this.lbl_NodesVisitedCount.AutoSize = true;
            this.lbl_NodesVisitedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NodesVisitedCount.Location = new System.Drawing.Point(123, 37);
            this.lbl_NodesVisitedCount.Name = "lbl_NodesVisitedCount";
            this.lbl_NodesVisitedCount.Size = new System.Drawing.Size(0, 37);
            this.lbl_NodesVisitedCount.TabIndex = 2;
            // 
            // lbl_CurrentNode
            // 
            this.lbl_CurrentNode.AutoSize = true;
            this.lbl_CurrentNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentNode.Location = new System.Drawing.Point(117, 74);
            this.lbl_CurrentNode.Name = "lbl_CurrentNode";
            this.lbl_CurrentNode.Size = new System.Drawing.Size(0, 37);
            this.lbl_CurrentNode.TabIndex = 3;
            // 
            // lbl_Path1
            // 
            this.lbl_Path1.AutoSize = true;
            this.lbl_Path1.Location = new System.Drawing.Point(136, 118);
            this.lbl_Path1.Name = "lbl_Path1";
            this.lbl_Path1.Size = new System.Drawing.Size(0, 20);
            this.lbl_Path1.TabIndex = 4;
            // 
            // lbl_Path2
            // 
            this.lbl_Path2.AutoSize = true;
            this.lbl_Path2.Location = new System.Drawing.Point(287, 108);
            this.lbl_Path2.Name = "lbl_Path2";
            this.lbl_Path2.Size = new System.Drawing.Size(0, 20);
            this.lbl_Path2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 312);
            this.Controls.Add(this.lbl_Path2);
            this.Controls.Add(this.lbl_Path1);
            this.Controls.Add(this.lbl_CurrentNode);
            this.Controls.Add(this.lbl_NodesVisitedCount);
            this.Controls.Add(this.btn_StartSnake);
            this.Name = "Form1";
            this.Text = "Snake it";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartSnake;
        private System.Windows.Forms.Label lbl_NodesVisitedCount;
        private System.Windows.Forms.Label lbl_CurrentNode;
        private System.Windows.Forms.Label lbl_Path1;
        private System.Windows.Forms.Label lbl_Path2;
    }
}

