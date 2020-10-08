namespace PAIN_YoMusic_Forms
{
    partial class SongManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongManagerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.errorPrompt = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.categoryChooserControl = new PAIN_YoMusic_Forms.CategoryChooserControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrompt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryChooserControl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of release";
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(12, 97);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(185, 20);
            this.authorBox.TabIndex = 2;
            this.authorBox.Validating += new System.ComponentModel.CancelEventHandler(this.authorBox_Validating);
            this.authorBox.Validated += new System.EventHandler(this.authorBox_Validated);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 54);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(185, 20);
            this.titleBox.TabIndex = 1;
            this.titleBox.Validating += new System.ComponentModel.CancelEventHandler(this.titleBox_Validating);
            this.titleBox.Validated += new System.EventHandler(this.titleBox_Validated);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAccept.Location = new System.Drawing.Point(161, 185);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.Location = new System.Drawing.Point(246, 12);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.ReadOnly = true;
            this.categoryBox.Size = new System.Drawing.Size(100, 20);
            this.categoryBox.TabIndex = 5;
            this.categoryBox.Text = "Pop";
            this.categoryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorPrompt
            // 
            this.errorPrompt.ContainerControl = this;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(12, 140);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(185, 20);
            this.dateBox.TabIndex = 7;
            // 
            // categoryChooserControl
            // 
            this.categoryChooserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryChooserControl.CategoryChosen = PAIN_YoMusic_Forms.CategoryChooserControl.Categories.Pop;
            this.categoryChooserControl.Image = ((System.Drawing.Image)(resources.GetObject("categoryChooserControl.Image")));
            this.categoryChooserControl.Location = new System.Drawing.Point(231, 38);
            this.categoryChooserControl.MinimumSize = new System.Drawing.Size(64, 64);
            this.categoryChooserControl.Name = "categoryChooserControl";
            this.categoryChooserControl.Size = new System.Drawing.Size(128, 128);
            this.categoryChooserControl.TabIndex = 6;
            this.categoryChooserControl.TabStop = false;
            this.categoryChooserControl.Click += new System.EventHandler(this.categoryChooserControl_Click);
            // 
            // SongManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 220);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.categoryChooserControl);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SongManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Song";
            this.Load += new System.EventHandler(this.SongManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorPrompt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryChooserControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox categoryBox;
        private CategoryChooserControl categoryChooserControl;
        private System.Windows.Forms.ErrorProvider errorPrompt;
        private System.Windows.Forms.DateTimePicker dateBox;
    }
}