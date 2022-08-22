namespace lettergame
{
    partial class frmLetterGame
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
            this.lblChar = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblCombo = new System.Windows.Forms.Label();
            this.btnInfinite = new System.Windows.Forms.Button();
            this.btnClassic = new System.Windows.Forms.Button();
            this.btnSuddenDeath = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnLives = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.btnHideTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChar
            // 
            this.lblChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChar.Location = new System.Drawing.Point(302, 141);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(150, 150);
            this.lblChar.TabIndex = 0;
            this.lblChar.Text = "Z";
            this.lblChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.SystemColors.Control;
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.ForeColor = System.Drawing.SystemColors.Control;
            this.txtText.Location = new System.Drawing.Point(458, 315);
            this.txtText.MaxLength = 1;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(150, 13);
            this.txtText.TabIndex = 1;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(302, 295);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 33);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(458, 141);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(84, 25);
            this.lblPoints.TabIndex = 3;
            this.lblPoints.Text = "Points: ";
            // 
            // lblCombo
            // 
            this.lblCombo.AutoSize = true;
            this.lblCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo.Location = new System.Drawing.Point(458, 176);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(86, 25);
            this.lblCombo.TabIndex = 4;
            this.lblCombo.Text = "Combo:";
            // 
            // btnInfinite
            // 
            this.btnInfinite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfinite.Location = new System.Drawing.Point(302, 373);
            this.btnInfinite.Name = "btnInfinite";
            this.btnInfinite.Size = new System.Drawing.Size(150, 33);
            this.btnInfinite.TabIndex = 5;
            this.btnInfinite.Text = "INFINITE";
            this.btnInfinite.UseVisualStyleBackColor = true;
            this.btnInfinite.Click += new System.EventHandler(this.btnInfinite_Click);
            // 
            // btnClassic
            // 
            this.btnClassic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassic.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnClassic.Location = new System.Drawing.Point(302, 334);
            this.btnClassic.Name = "btnClassic";
            this.btnClassic.Size = new System.Drawing.Size(150, 33);
            this.btnClassic.TabIndex = 6;
            this.btnClassic.Text = "CLASSIC";
            this.btnClassic.UseVisualStyleBackColor = true;
            this.btnClassic.Click += new System.EventHandler(this.btnClassic_Click);
            // 
            // btnSuddenDeath
            // 
            this.btnSuddenDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuddenDeath.Location = new System.Drawing.Point(302, 412);
            this.btnSuddenDeath.Name = "btnSuddenDeath";
            this.btnSuddenDeath.Size = new System.Drawing.Size(150, 33);
            this.btnSuddenDeath.TabIndex = 7;
            this.btnSuddenDeath.Text = "SUDDEN DEATH";
            this.btnSuddenDeath.UseVisualStyleBackColor = true;
            this.btnSuddenDeath.Click += new System.EventHandler(this.btnSuddenDeath_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(458, 295);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(215, 75);
            this.lblSettings.TabIndex = 8;
            this.lblSettings.Text = "Settings\r\nGame Mode: Classic\r\nGame Modifier: None";
            // 
            // btnLives
            // 
            this.btnLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLives.Location = new System.Drawing.Point(302, 451);
            this.btnLives.Name = "btnLives";
            this.btnLives.Size = new System.Drawing.Size(150, 33);
            this.btnLives.TabIndex = 9;
            this.btnLives.Text = "3 LIVES";
            this.btnLives.UseVisualStyleBackColor = true;
            this.btnLives.Click += new System.EventHandler(this.btnLives_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(458, 246);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(71, 25);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time: ";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(458, 211);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(69, 25);
            this.lblLives.TabIndex = 11;
            this.lblLives.Text = "Lives:";
            // 
            // gameTime
            // 
            this.gameTime.Interval = 1;
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // btnHideTimer
            // 
            this.btnHideTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideTimer.Location = new System.Drawing.Point(302, 490);
            this.btnHideTimer.Name = "btnHideTimer";
            this.btnHideTimer.Size = new System.Drawing.Size(150, 33);
            this.btnHideTimer.TabIndex = 12;
            this.btnHideTimer.Text = "HIDE TIMER";
            this.btnHideTimer.UseVisualStyleBackColor = true;
            this.btnHideTimer.Click += new System.EventHandler(this.btnHideTimer_Click);
            // 
            // frmLetterGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnHideTimer);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnLives);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.btnSuddenDeath);
            this.Controls.Add(this.btnClassic);
            this.Controls.Add(this.btnInfinite);
            this.Controls.Add(this.lblCombo);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblChar);
            this.Name = "frmLetterGame";
            this.Text = "Letter Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblCombo;
        private System.Windows.Forms.Button btnInfinite;
        private System.Windows.Forms.Button btnClassic;
        private System.Windows.Forms.Button btnSuddenDeath;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnLives;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Button btnHideTimer;
    }
}

