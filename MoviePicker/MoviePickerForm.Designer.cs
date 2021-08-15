
namespace MoviePicker
{
    partial class MoviePickerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviePickerForm));
            this.timerRotation = new System.Windows.Forms.Timer(this.components);
            this.textBoxMovies = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelMovieName = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.circlePictureBox1 = new MoviePicker.CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPlot = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelActors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRotation
            // 
            this.timerRotation.Tick += new System.EventHandler(this.timerRotation_Tick);
            // 
            // textBoxMovies
            // 
            this.textBoxMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMovies.Location = new System.Drawing.Point(17, 41);
            this.textBoxMovies.Name = "textBoxMovies";
            this.textBoxMovies.Size = new System.Drawing.Size(300, 22);
            this.textBoxMovies.TabIndex = 2;
            this.toolTip.SetToolTip(this.textBoxMovies, "Multiple entries should be comma seperated");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Movie(s):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(122, 71);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(30, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "+";
            this.toolTip.SetToolTip(this.buttonAdd, "Add one or multiple movies");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(185, 71);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(30, 30);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "-";
            this.toolTip.SetToolTip(this.buttonRemove, "Remove one or multiple movies");
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelMovieName
            // 
            this.labelMovieName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMovieName.BackColor = System.Drawing.SystemColors.Window;
            this.labelMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovieName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMovieName.Location = new System.Drawing.Point(375, 38);
            this.labelMovieName.Name = "labelMovieName";
            this.labelMovieName.Size = new System.Drawing.Size(297, 25);
            this.labelMovieName.TabIndex = 4;
            this.labelMovieName.Tag = "result";
            this.labelMovieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circlePictureBox1
            // 
            this.circlePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.circlePictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.circlePictureBox1.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dc/Eight-colour-wheel-2D.p" +
    "ng/240px-Eight-colour-wheel-2D.png";
            this.circlePictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("circlePictureBox1.InitialImage")));
            this.circlePictureBox1.Location = new System.Drawing.Point(17, 107);
            this.circlePictureBox1.MinimumSize = new System.Drawing.Size(100, 100);
            this.circlePictureBox1.Name = "circlePictureBox1";
            this.circlePictureBox1.Size = new System.Drawing.Size(300, 300);
            this.circlePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circlePictureBox1.TabIndex = 0;
            this.circlePictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.circlePictureBox1, "Click to spin!");
            this.circlePictureBox1.Click += new System.EventHandler(this.buttonSpinner_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 3;
            this.label2.Tag = "result";
            this.label2.Text = "Result:";
            // 
            // labelYear
            // 
            this.labelYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelYear.BackColor = System.Drawing.SystemColors.Window;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelYear.Location = new System.Drawing.Point(370, 71);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(159, 25);
            this.labelYear.TabIndex = 4;
            this.labelYear.Tag = "result";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlot
            // 
            this.labelPlot.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPlot.BackColor = System.Drawing.SystemColors.Window;
            this.labelPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPlot.Location = new System.Drawing.Point(370, 107);
            this.labelPlot.Name = "labelPlot";
            this.labelPlot.Size = new System.Drawing.Size(302, 199);
            this.labelPlot.TabIndex = 4;
            this.labelPlot.Tag = "result";
            // 
            // labelRating
            // 
            this.labelRating.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRating.BackColor = System.Drawing.SystemColors.Window;
            this.labelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRating.Location = new System.Drawing.Point(535, 71);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(137, 25);
            this.labelRating.TabIndex = 5;
            this.labelRating.Tag = "result";
            this.labelRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActors
            // 
            this.labelActors.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelActors.BackColor = System.Drawing.SystemColors.Window;
            this.labelActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelActors.Location = new System.Drawing.Point(370, 321);
            this.labelActors.Name = "labelActors";
            this.labelActors.Size = new System.Drawing.Size(302, 86);
            this.labelActors.TabIndex = 6;
            this.labelActors.Tag = "result";
            // 
            // MoviePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 443);
            this.Controls.Add(this.labelActors);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelPlot);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMovieName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMovies);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.circlePictureBox1);
            this.MaximumSize = new System.Drawing.Size(700, 482);
            this.MinimumSize = new System.Drawing.Size(360, 482);
            this.Name = "MoviePickerForm";
            this.Text = "Movie Picker";
            this.Load += new System.EventHandler(this.MoviePickerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CirclePictureBox circlePictureBox1;
        private System.Windows.Forms.Timer timerRotation;
        private System.Windows.Forms.TextBox textBoxMovies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelMovieName;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPlot;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelActors;
    }
}

