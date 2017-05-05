namespace PinBall
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bat1 = new PinBall.Bat();
            this.ball1 = new PinBall.Ball();
            this.brick21 = new PinBall.Brick();
            this.brick22 = new PinBall.Brick();
            this.brick23 = new PinBall.Brick();
            this.brick24 = new PinBall.Brick();
            this.brick25 = new PinBall.Brick();
            this.brick16 = new PinBall.Brick();
            this.brick17 = new PinBall.Brick();
            this.brick18 = new PinBall.Brick();
            this.brick19 = new PinBall.Brick();
            this.brick20 = new PinBall.Brick();
            this.brick11 = new PinBall.Brick();
            this.brick12 = new PinBall.Brick();
            this.brick13 = new PinBall.Brick();
            this.brick14 = new PinBall.Brick();
            this.brick15 = new PinBall.Brick();
            this.brick5 = new PinBall.Brick();
            this.brick7 = new PinBall.Brick();
            this.brick8 = new PinBall.Brick();
            this.brick9 = new PinBall.Brick();
            this.brick10 = new PinBall.Brick();
            this.brick6 = new PinBall.Brick();
            this.brick3 = new PinBall.Brick();
            this.brick4 = new PinBall.Brick();
            this.brick2 = new PinBall.Brick();
            this.brick1 = new PinBall.Brick();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bat1
            // 
            this.bat1.Location = new System.Drawing.Point(97, 491);
            this.bat1.Name = "bat1";
            this.bat1.Size = new System.Drawing.Size(218, 20);
            this.bat1.TabIndex = 26;
            this.bat1.UseVisualStyleBackColor = true;
            // 
            // ball1
            // 
            this.ball1.AutoSize = true;
            this.ball1.Checked = true;
            this.ball1.Location = new System.Drawing.Point(41, 420);
            this.ball1.Name = "ball1";
            this.ball1.Size = new System.Drawing.Size(14, 13);
            this.ball1.TabIndex = 25;
            this.ball1.TabStop = true;
            this.ball1.UseVisualStyleBackColor = true;
            // 
            // brick21
            // 
            this.brick21.Location = new System.Drawing.Point(319, 120);
            this.brick21.Name = "brick21";
            this.brick21.Size = new System.Drawing.Size(75, 23);
            this.brick21.Status = PinBall.BrickStatus.Normal;
            this.brick21.TabIndex = 24;
            this.brick21.UseVisualStyleBackColor = true;
            // 
            // brick22
            // 
            this.brick22.Location = new System.Drawing.Point(240, 120);
            this.brick22.Name = "brick22";
            this.brick22.Size = new System.Drawing.Size(75, 23);
            this.brick22.Status = PinBall.BrickStatus.Normal;
            this.brick22.TabIndex = 23;
            this.brick22.UseVisualStyleBackColor = true;
            // 
            // brick23
            // 
            this.brick23.Location = new System.Drawing.Point(161, 120);
            this.brick23.Name = "brick23";
            this.brick23.Size = new System.Drawing.Size(75, 23);
            this.brick23.Status = PinBall.BrickStatus.Normal;
            this.brick23.TabIndex = 22;
            this.brick23.UseVisualStyleBackColor = true;
            // 
            // brick24
            // 
            this.brick24.Location = new System.Drawing.Point(82, 120);
            this.brick24.Name = "brick24";
            this.brick24.Size = new System.Drawing.Size(75, 23);
            this.brick24.Status = PinBall.BrickStatus.Normal;
            this.brick24.TabIndex = 21;
            this.brick24.UseVisualStyleBackColor = true;
            // 
            // brick25
            // 
            this.brick25.Location = new System.Drawing.Point(3, 120);
            this.brick25.Name = "brick25";
            this.brick25.Size = new System.Drawing.Size(75, 23);
            this.brick25.Status = PinBall.BrickStatus.Falling;
            this.brick25.TabIndex = 20;
            this.brick25.UseVisualStyleBackColor = true;
            // 
            // brick16
            // 
            this.brick16.Location = new System.Drawing.Point(319, 91);
            this.brick16.Name = "brick16";
            this.brick16.Size = new System.Drawing.Size(75, 23);
            this.brick16.Status = PinBall.BrickStatus.Normal;
            this.brick16.TabIndex = 19;
            this.brick16.UseVisualStyleBackColor = true;
            // 
            // brick17
            // 
            this.brick17.Location = new System.Drawing.Point(240, 91);
            this.brick17.Name = "brick17";
            this.brick17.Size = new System.Drawing.Size(75, 23);
            this.brick17.Status = PinBall.BrickStatus.Normal;
            this.brick17.TabIndex = 18;
            this.brick17.UseVisualStyleBackColor = true;
            // 
            // brick18
            // 
            this.brick18.Location = new System.Drawing.Point(161, 91);
            this.brick18.Name = "brick18";
            this.brick18.Size = new System.Drawing.Size(75, 23);
            this.brick18.Status = PinBall.BrickStatus.Normal;
            this.brick18.TabIndex = 17;
            this.brick18.UseVisualStyleBackColor = true;
            // 
            // brick19
            // 
            this.brick19.Location = new System.Drawing.Point(82, 91);
            this.brick19.Name = "brick19";
            this.brick19.Size = new System.Drawing.Size(75, 23);
            this.brick19.Status = PinBall.BrickStatus.Normal;
            this.brick19.TabIndex = 16;
            this.brick19.UseVisualStyleBackColor = true;
            // 
            // brick20
            // 
            this.brick20.Location = new System.Drawing.Point(3, 91);
            this.brick20.Name = "brick20";
            this.brick20.Size = new System.Drawing.Size(75, 23);
            this.brick20.Status = PinBall.BrickStatus.Normal;
            this.brick20.TabIndex = 15;
            this.brick20.UseVisualStyleBackColor = true;
            // 
            // brick11
            // 
            this.brick11.Location = new System.Drawing.Point(319, 62);
            this.brick11.Name = "brick11";
            this.brick11.Size = new System.Drawing.Size(75, 23);
            this.brick11.Status = PinBall.BrickStatus.Normal;
            this.brick11.TabIndex = 14;
            this.brick11.UseVisualStyleBackColor = true;
            // 
            // brick12
            // 
            this.brick12.Location = new System.Drawing.Point(240, 62);
            this.brick12.Name = "brick12";
            this.brick12.Size = new System.Drawing.Size(75, 23);
            this.brick12.Status = PinBall.BrickStatus.Normal;
            this.brick12.TabIndex = 13;
            this.brick12.UseVisualStyleBackColor = true;
            // 
            // brick13
            // 
            this.brick13.Location = new System.Drawing.Point(161, 62);
            this.brick13.Name = "brick13";
            this.brick13.Size = new System.Drawing.Size(75, 23);
            this.brick13.Status = PinBall.BrickStatus.Normal;
            this.brick13.TabIndex = 12;
            this.brick13.UseVisualStyleBackColor = true;
            // 
            // brick14
            // 
            this.brick14.Location = new System.Drawing.Point(82, 62);
            this.brick14.Name = "brick14";
            this.brick14.Size = new System.Drawing.Size(75, 23);
            this.brick14.Status = PinBall.BrickStatus.Normal;
            this.brick14.TabIndex = 11;
            this.brick14.UseVisualStyleBackColor = true;
            // 
            // brick15
            // 
            this.brick15.Location = new System.Drawing.Point(3, 62);
            this.brick15.Name = "brick15";
            this.brick15.Size = new System.Drawing.Size(75, 23);
            this.brick15.Status = PinBall.BrickStatus.Normal;
            this.brick15.TabIndex = 10;
            this.brick15.UseVisualStyleBackColor = true;
            // 
            // brick5
            // 
            this.brick5.Location = new System.Drawing.Point(319, 33);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(75, 23);
            this.brick5.Status = PinBall.BrickStatus.Normal;
            this.brick5.TabIndex = 9;
            this.brick5.UseVisualStyleBackColor = true;
            // 
            // brick7
            // 
            this.brick7.Location = new System.Drawing.Point(240, 33);
            this.brick7.Name = "brick7";
            this.brick7.Size = new System.Drawing.Size(75, 23);
            this.brick7.Status = PinBall.BrickStatus.Normal;
            this.brick7.TabIndex = 8;
            this.brick7.UseVisualStyleBackColor = true;
            // 
            // brick8
            // 
            this.brick8.Location = new System.Drawing.Point(161, 33);
            this.brick8.Name = "brick8";
            this.brick8.Size = new System.Drawing.Size(75, 23);
            this.brick8.Status = PinBall.BrickStatus.Normal;
            this.brick8.TabIndex = 7;
            this.brick8.UseVisualStyleBackColor = true;
            // 
            // brick9
            // 
            this.brick9.Location = new System.Drawing.Point(82, 33);
            this.brick9.Name = "brick9";
            this.brick9.Size = new System.Drawing.Size(75, 23);
            this.brick9.Status = PinBall.BrickStatus.Normal;
            this.brick9.TabIndex = 6;
            this.brick9.UseVisualStyleBackColor = true;
            // 
            // brick10
            // 
            this.brick10.Location = new System.Drawing.Point(3, 33);
            this.brick10.Name = "brick10";
            this.brick10.Size = new System.Drawing.Size(75, 23);
            this.brick10.Status = PinBall.BrickStatus.Normal;
            this.brick10.TabIndex = 5;
            this.brick10.UseVisualStyleBackColor = true;
            // 
            // brick6
            // 
            this.brick6.Location = new System.Drawing.Point(319, 4);
            this.brick6.Name = "brick6";
            this.brick6.Size = new System.Drawing.Size(75, 23);
            this.brick6.Status = PinBall.BrickStatus.Normal;
            this.brick6.TabIndex = 4;
            this.brick6.UseVisualStyleBackColor = true;
            // 
            // brick3
            // 
            this.brick3.Location = new System.Drawing.Point(240, 4);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(75, 23);
            this.brick3.Status = PinBall.BrickStatus.Normal;
            this.brick3.TabIndex = 3;
            this.brick3.UseVisualStyleBackColor = true;
            // 
            // brick4
            // 
            this.brick4.Location = new System.Drawing.Point(161, 4);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(75, 23);
            this.brick4.Status = PinBall.BrickStatus.Normal;
            this.brick4.TabIndex = 2;
            this.brick4.UseVisualStyleBackColor = true;
            // 
            // brick2
            // 
            this.brick2.Location = new System.Drawing.Point(82, 4);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(75, 23);
            this.brick2.Status = PinBall.BrickStatus.Normal;
            this.brick2.TabIndex = 1;
            this.brick2.UseVisualStyleBackColor = true;
            // 
            // brick1
            // 
            this.brick1.Location = new System.Drawing.Point(3, 4);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(75, 23);
            this.brick1.Status = PinBall.BrickStatus.Normal;
            this.brick1.TabIndex = 0;
            this.brick1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 578);
            this.Controls.Add(this.bat1);
            this.Controls.Add(this.ball1);
            this.Controls.Add(this.brick21);
            this.Controls.Add(this.brick22);
            this.Controls.Add(this.brick23);
            this.Controls.Add(this.brick24);
            this.Controls.Add(this.brick25);
            this.Controls.Add(this.brick16);
            this.Controls.Add(this.brick17);
            this.Controls.Add(this.brick18);
            this.Controls.Add(this.brick19);
            this.Controls.Add(this.brick20);
            this.Controls.Add(this.brick11);
            this.Controls.Add(this.brick12);
            this.Controls.Add(this.brick13);
            this.Controls.Add(this.brick14);
            this.Controls.Add(this.brick15);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick7);
            this.Controls.Add(this.brick8);
            this.Controls.Add(this.brick9);
            this.Controls.Add(this.brick10);
            this.Controls.Add(this.brick6);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PinBall V1.0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Brick brick1;
        private Brick brick2;
        private Brick brick3;
        private Brick brick4;
        private Brick brick6;
        private Brick brick5;
        private Brick brick7;
        private Brick brick8;
        private Brick brick9;
        private Brick brick10;
        private Brick brick11;
        private Brick brick12;
        private Brick brick13;
        private Brick brick14;
        private Brick brick15;
        private Brick brick16;
        private Brick brick17;
        private Brick brick18;
        private Brick brick19;
        private Brick brick20;
        private Brick brick21;
        private Brick brick22;
        private Brick brick23;
        private Brick brick24;
        private Brick brick25;
        private Ball ball1;
        private Bat bat1;
        private System.Windows.Forms.Timer timer1;
    }
}

