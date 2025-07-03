namespace CapitalManipulator;

partial class CapitalManipulatorForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        title = new System.Windows.Forms.Label();
        prompt = new System.Windows.Forms.Label();
        manipulateButton = new System.Windows.Forms.Button();
        author = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // title
        // 
        title.Location = new System.Drawing.Point(150, 48);
        title.Margin = new System.Windows.Forms.Padding(0);
        title.Name = "title";
        title.Size = new System.Drawing.Size(475, 130);
        title.TabIndex = 0;
        title.Text = "资本做局器\r\nCapital Manipulator";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // prompt
        // 
        prompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
        prompt.Location = new System.Drawing.Point(150, 218);
        prompt.Name = "prompt";
        prompt.Size = new System.Drawing.Size(475, 59);
        prompt.TabIndex = 1;
        prompt.Text = "点击此按钮来动资本的蛋糕\r\nClick this button to touch the capital\'s cake";
        prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        prompt.Click += prompt_Click;
        // 
        // manipulateButton
        // 
        manipulateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        manipulateButton.Location = new System.Drawing.Point(283, 320);
        manipulateButton.Name = "manipulateButton";
        manipulateButton.Size = new System.Drawing.Size(206, 70);
        manipulateButton.TabIndex = 2;
        manipulateButton.Text = ":)";
        manipulateButton.UseVisualStyleBackColor = true;
        manipulateButton.Click += manipulateButton_Click;
        // 
        // author
        // 
        author.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
        author.Location = new System.Drawing.Point(150, 393);
        author.Name = "author";
        author.Size = new System.Drawing.Size(475, 127);
        author.TabIndex = 3;
        author.Text = "唉，资本\r\nAlas, capital\r\n\r\n\r\n\r\nBy WaterCoFire";
        author.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        author.Click += author_Click;
        // 
        // CapitalManipulatorForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(778, 544);
        Controls.Add(author);
        Controls.Add(manipulateButton);
        Controls.Add(prompt);
        Controls.Add(title);
        Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
        Location = new System.Drawing.Point(100, 100);
        Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
        Text = "资本做局器 Capital Manipulator";
        Load += CapitalManipulatorForm_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label author;

    private System.Windows.Forms.Button manipulateButton;

    private System.Windows.Forms.Label prompt;

    private System.Windows.Forms.Label title;

    #endregion
}