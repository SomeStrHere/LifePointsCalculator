namespace WinForms_LifePointsCalculator
{
    partial class mainForm
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
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.RichTextBox();
            this.player2Score = new System.Windows.Forms.RichTextBox();
            this.player1Input = new System.Windows.Forms.TextBox();
            this.player2Input = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.CausesValidation = false;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.Location = new System.Drawing.Point(12, 9);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(100, 29);
            this.player1Label.TabIndex = 0;
            this.player1Label.Text = "Player 1";
            // 
            // player2Label
            // 
            this.player2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Label.AutoSize = true;
            this.player2Label.CausesValidation = false;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(236, 9);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(100, 29);
            this.player2Label.TabIndex = 1;
            this.player2Label.Text = "Player 2";
            // 
            // player1Score
            // 
            this.player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Score.Location = new System.Drawing.Point(17, 73);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(139, 49);
            this.player1Score.TabIndex = 2;
            this.player1Score.Text = "8000";
            this.player1Score.TextChanged += new System.EventHandler(this.player1Score_TextChanged);
            // 
            // player2Score
            // 
            this.player2Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Score.Location = new System.Drawing.Point(197, 73);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(139, 49);
            this.player2Score.TabIndex = 3;
            this.player2Score.Text = "8000";
            this.player2Score.TextChanged += new System.EventHandler(this.player2Score_TextChanged);
            // 
            // player1Input
            // 
            this.player1Input.ForeColor = System.Drawing.Color.Gray;
            this.player1Input.Location = new System.Drawing.Point(17, 135);
            this.player1Input.Name = "player1Input";
            this.player1Input.Size = new System.Drawing.Size(139, 20);
            this.player1Input.TabIndex = 4;
            this.player1Input.Text = "Enter value here";
            this.player1Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player2Input
            // 
            this.player2Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Input.ForeColor = System.Drawing.Color.Gray;
            this.player2Input.Location = new System.Drawing.Point(197, 135);
            this.player2Input.Name = "player2Input";
            this.player2Input.Size = new System.Drawing.Size(139, 20);
            this.player2Input.TabIndex = 5;
            this.player2Input.Text = "Enter value here";
            this.player2Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(12, 172);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(61, 27);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(95, 201);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(61, 27);
            this.subtractButton.TabIndex = 7;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(17, 224);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(61, 27);
            this.divideButton.TabIndex = 8;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enterButton.Location = new System.Drawing.Point(197, 195);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(139, 38);
            this.enterButton.TabIndex = 9;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 277);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.player2Input);
            this.Controls.Add(this.player1Input);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.MaximumSize = new System.Drawing.Size(750, 632);
            this.MinimumSize = new System.Drawing.Size(375, 316);
            this.Name = "mainForm";
            this.Text = "Life Point Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.RichTextBox player1Score;
        private System.Windows.Forms.RichTextBox player2Score;
        private System.Windows.Forms.TextBox player1Input;
        private System.Windows.Forms.TextBox player2Input;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button enterButton;
    }
}

