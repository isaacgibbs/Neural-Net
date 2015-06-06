namespace Neural_Net
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.logicTimer = new System.Windows.Forms.Timer(this.components);
            this.trainingLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.trainingCount = new System.Windows.Forms.Label();
            this.errorCount = new System.Windows.Forms.Label();
            this.neuronSlider = new System.Windows.Forms.HScrollBar();
            this.neuronLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noiseSlider = new System.Windows.Forms.HScrollBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedSlider = new System.Windows.Forms.HScrollBar();
            this.learningText = new System.Windows.Forms.TextBox();
            this.netType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.functionType = new System.Windows.Forms.ComboBox();
            this.resumeButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.learnRateCount = new System.Windows.Forms.Label();
            this.lrateLable = new System.Windows.Forms.Label();
            this.annealCount = new System.Windows.Forms.Label();
            this.annealLabel = new System.Windows.Forms.Label();
            this.annealingBox = new System.Windows.Forms.CheckBox();
            this.neuronBox = new System.Windows.Forms.TextBox();
            this.finalError = new System.Windows.Forms.Label();
            this.markTrainings = new System.Windows.Forms.Label();
            this.finalErrorLabel = new System.Windows.Forms.Label();
            this.markTrainingLabel = new System.Windows.Forms.Label();
            this.errorGoal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(520, 340);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(71, 26);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // displayTimer
            // 
            this.displayTimer.Tick += new System.EventHandler(this.displayTimer_Tick);
            // 
            // logicTimer
            // 
            this.logicTimer.Interval = 50;
            this.logicTimer.Tick += new System.EventHandler(this.logicTimer_Tick);
            // 
            // trainingLabel
            // 
            this.trainingLabel.AutoSize = true;
            this.trainingLabel.Location = new System.Drawing.Point(518, 12);
            this.trainingLabel.Name = "trainingLabel";
            this.trainingLabel.Size = new System.Drawing.Size(53, 13);
            this.trainingLabel.TabIndex = 2;
            this.trainingLabel.Text = "Trainings:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(518, 34);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(32, 13);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "Error:";
            // 
            // trainingCount
            // 
            this.trainingCount.AutoSize = true;
            this.trainingCount.Location = new System.Drawing.Point(577, 12);
            this.trainingCount.Name = "trainingCount";
            this.trainingCount.Size = new System.Drawing.Size(13, 13);
            this.trainingCount.TabIndex = 4;
            this.trainingCount.Text = "0";
            // 
            // errorCount
            // 
            this.errorCount.AutoSize = true;
            this.errorCount.Location = new System.Drawing.Point(556, 34);
            this.errorCount.Name = "errorCount";
            this.errorCount.Size = new System.Drawing.Size(13, 13);
            this.errorCount.TabIndex = 5;
            this.errorCount.Text = "0";
            // 
            // neuronSlider
            // 
            this.neuronSlider.Location = new System.Drawing.Point(523, 280);
            this.neuronSlider.Minimum = 10;
            this.neuronSlider.Name = "neuronSlider";
            this.neuronSlider.Size = new System.Drawing.Size(152, 17);
            this.neuronSlider.TabIndex = 6;
            this.neuronSlider.Value = 20;
            this.neuronSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.neuronSlider_Scroll);
            // 
            // neuronLabel
            // 
            this.neuronLabel.AutoSize = true;
            this.neuronLabel.Location = new System.Drawing.Point(678, 284);
            this.neuronLabel.Name = "neuronLabel";
            this.neuronLabel.Size = new System.Drawing.Size(47, 13);
            this.neuronLabel.TabIndex = 7;
            this.neuronLabel.Text = "Neurons";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Learning Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Initial Noise";
            // 
            // noiseSlider
            // 
            this.noiseSlider.LargeChange = 1;
            this.noiseSlider.Location = new System.Drawing.Point(523, 310);
            this.noiseSlider.Maximum = 5;
            this.noiseSlider.Minimum = 1;
            this.noiseSlider.Name = "noiseSlider";
            this.noiseSlider.Size = new System.Drawing.Size(152, 17);
            this.noiseSlider.TabIndex = 10;
            this.noiseSlider.Value = 1;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(678, 221);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(38, 13);
            this.speedLabel.TabIndex = 13;
            this.speedLabel.Text = "Speed";
            // 
            // speedSlider
            // 
            this.speedSlider.LargeChange = 100;
            this.speedSlider.Location = new System.Drawing.Point(523, 217);
            this.speedSlider.Maximum = 5000;
            this.speedSlider.Minimum = 100;
            this.speedSlider.Name = "speedSlider";
            this.speedSlider.Size = new System.Drawing.Size(152, 17);
            this.speedSlider.TabIndex = 12;
            this.speedSlider.Value = 100;
            this.speedSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speedSlider_Scroll);
            // 
            // learningText
            // 
            this.learningText.Location = new System.Drawing.Point(523, 249);
            this.learningText.Name = "learningText";
            this.learningText.Size = new System.Drawing.Size(152, 20);
            this.learningText.TabIndex = 14;
            this.learningText.Text = "0.01";
            this.learningText.TextChanged += new System.EventHandler(this.learningText_TextChanged);
            // 
            // netType
            // 
            this.netType.FormattingEnabled = true;
            this.netType.Items.AddRange(new object[] {
            "One to One",
            "Two to One"});
            this.netType.Location = new System.Drawing.Point(580, 121);
            this.netType.Name = "netType";
            this.netType.Size = new System.Drawing.Size(167, 21);
            this.netType.TabIndex = 15;
            this.netType.SelectedIndexChanged += new System.EventHandler(this.netType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Net Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Net Function:";
            // 
            // functionType
            // 
            this.functionType.FormattingEnabled = true;
            this.functionType.Location = new System.Drawing.Point(597, 160);
            this.functionType.Name = "functionType";
            this.functionType.Size = new System.Drawing.Size(167, 21);
            this.functionType.TabIndex = 17;
            this.functionType.SelectedIndexChanged += new System.EventHandler(this.functionType_SelectedIndexChanged);
            // 
            // resumeButton
            // 
            this.resumeButton.Location = new System.Drawing.Point(520, 372);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(71, 26);
            this.resumeButton.TabIndex = 19;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(520, 404);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(71, 26);
            this.pauseButton.TabIndex = 20;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // learnRateCount
            // 
            this.learnRateCount.AutoSize = true;
            this.learnRateCount.Location = new System.Drawing.Point(601, 56);
            this.learnRateCount.Name = "learnRateCount";
            this.learnRateCount.Size = new System.Drawing.Size(13, 13);
            this.learnRateCount.TabIndex = 22;
            this.learnRateCount.Text = "0";
            // 
            // lrateLable
            // 
            this.lrateLable.AutoSize = true;
            this.lrateLable.Location = new System.Drawing.Point(518, 56);
            this.lrateLable.Name = "lrateLable";
            this.lrateLable.Size = new System.Drawing.Size(77, 13);
            this.lrateLable.TabIndex = 21;
            this.lrateLable.Text = "Learning Rate:";
            // 
            // annealCount
            // 
            this.annealCount.AutoSize = true;
            this.annealCount.Location = new System.Drawing.Point(600, 81);
            this.annealCount.Name = "annealCount";
            this.annealCount.Size = new System.Drawing.Size(13, 13);
            this.annealCount.TabIndex = 24;
            this.annealCount.Text = "0";
            // 
            // annealLabel
            // 
            this.annealLabel.AutoSize = true;
            this.annealLabel.Location = new System.Drawing.Point(517, 81);
            this.annealLabel.Name = "annealLabel";
            this.annealLabel.Size = new System.Drawing.Size(82, 13);
            this.annealLabel.TabIndex = 23;
            this.annealLabel.Text = "Annealing Num:";
            // 
            // annealingBox
            // 
            this.annealingBox.AutoSize = true;
            this.annealingBox.Location = new System.Drawing.Point(519, 437);
            this.annealingBox.Name = "annealingBox";
            this.annealingBox.Size = new System.Drawing.Size(73, 17);
            this.annealingBox.TabIndex = 25;
            this.annealingBox.Text = "Annealing";
            this.annealingBox.UseVisualStyleBackColor = true;
            // 
            // neuronBox
            // 
            this.neuronBox.Location = new System.Drawing.Point(731, 281);
            this.neuronBox.Name = "neuronBox";
            this.neuronBox.Size = new System.Drawing.Size(48, 20);
            this.neuronBox.TabIndex = 26;
            this.neuronBox.Text = "20";
            // 
            // finalError
            // 
            this.finalError.AutoSize = true;
            this.finalError.Location = new System.Drawing.Point(741, 441);
            this.finalError.Name = "finalError";
            this.finalError.Size = new System.Drawing.Size(13, 13);
            this.finalError.TabIndex = 30;
            this.finalError.Text = "0";
            // 
            // markTrainings
            // 
            this.markTrainings.AutoSize = true;
            this.markTrainings.Location = new System.Drawing.Point(764, 417);
            this.markTrainings.Name = "markTrainings";
            this.markTrainings.Size = new System.Drawing.Size(13, 13);
            this.markTrainings.TabIndex = 29;
            this.markTrainings.Text = "0";
            // 
            // finalErrorLabel
            // 
            this.finalErrorLabel.AutoSize = true;
            this.finalErrorLabel.Location = new System.Drawing.Point(678, 439);
            this.finalErrorLabel.Name = "finalErrorLabel";
            this.finalErrorLabel.Size = new System.Drawing.Size(57, 13);
            this.finalErrorLabel.TabIndex = 28;
            this.finalErrorLabel.Text = "Final Error:";
            // 
            // markTrainingLabel
            // 
            this.markTrainingLabel.AutoSize = true;
            this.markTrainingLabel.Location = new System.Drawing.Point(678, 417);
            this.markTrainingLabel.Name = "markTrainingLabel";
            this.markTrainingLabel.Size = new System.Drawing.Size(80, 13);
            this.markTrainingLabel.TabIndex = 27;
            this.markTrainingLabel.Text = "Mark Trainings:";
            // 
            // errorGoal
            // 
            this.errorGoal.Location = new System.Drawing.Point(729, 394);
            this.errorGoal.Name = "errorGoal";
            this.errorGoal.Size = new System.Drawing.Size(48, 20);
            this.errorGoal.TabIndex = 31;
            this.errorGoal.Text = "0.01";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Error Goal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 611);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.errorGoal);
            this.Controls.Add(this.finalError);
            this.Controls.Add(this.markTrainings);
            this.Controls.Add(this.finalErrorLabel);
            this.Controls.Add(this.markTrainingLabel);
            this.Controls.Add(this.neuronBox);
            this.Controls.Add(this.annealingBox);
            this.Controls.Add(this.annealCount);
            this.Controls.Add(this.annealLabel);
            this.Controls.Add(this.learnRateCount);
            this.Controls.Add(this.lrateLable);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.functionType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.netType);
            this.Controls.Add(this.learningText);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.speedSlider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noiseSlider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.neuronLabel);
            this.Controls.Add(this.neuronSlider);
            this.Controls.Add(this.errorCount);
            this.Controls.Add(this.trainingCount);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.trainingLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer displayTimer;
        private System.Windows.Forms.Timer logicTimer;
        private System.Windows.Forms.Label trainingLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label trainingCount;
        private System.Windows.Forms.Label errorCount;
        private System.Windows.Forms.HScrollBar neuronSlider;
        private System.Windows.Forms.Label neuronLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar noiseSlider;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.HScrollBar speedSlider;
        private System.Windows.Forms.TextBox learningText;
        private System.Windows.Forms.ComboBox netType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox functionType;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label learnRateCount;
        private System.Windows.Forms.Label lrateLable;
        private System.Windows.Forms.Label annealCount;
        private System.Windows.Forms.Label annealLabel;
        private System.Windows.Forms.CheckBox annealingBox;
        private System.Windows.Forms.TextBox neuronBox;
        private System.Windows.Forms.Label finalError;
        private System.Windows.Forms.Label markTrainings;
        private System.Windows.Forms.Label finalErrorLabel;
        private System.Windows.Forms.Label markTrainingLabel;
        private System.Windows.Forms.TextBox errorGoal;
        private System.Windows.Forms.Label label5;
    }
}

