
namespace Receipt
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
            this.pencilLabel = new System.Windows.Forms.Label();
            this.eraserLabel = new System.Windows.Forms.Label();
            this.penLabel = new System.Windows.Forms.Label();
            this.pencilBox = new System.Windows.Forms.TextBox();
            this.eraserBox = new System.Windows.Forms.TextBox();
            this.penBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subLabel = new System.Windows.Forms.Label();
            this.pricesLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.black = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.productLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pencilLabel
            // 
            this.pencilLabel.AutoSize = true;
            this.pencilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencilLabel.Location = new System.Drawing.Point(66, 82);
            this.pencilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pencilLabel.Name = "pencilLabel";
            this.pencilLabel.Size = new System.Drawing.Size(176, 25);
            this.pencilLabel.TabIndex = 0;
            this.pencilLabel.Text = "Number of Pencils:\r\n";
            // 
            // eraserLabel
            // 
            this.eraserLabel.AutoSize = true;
            this.eraserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraserLabel.Location = new System.Drawing.Point(66, 138);
            this.eraserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eraserLabel.Name = "eraserLabel";
            this.eraserLabel.Size = new System.Drawing.Size(180, 25);
            this.eraserLabel.TabIndex = 1;
            this.eraserLabel.Text = "Number of Erasers:\r\n";
            // 
            // penLabel
            // 
            this.penLabel.AutoSize = true;
            this.penLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penLabel.Location = new System.Drawing.Point(66, 193);
            this.penLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.penLabel.Name = "penLabel";
            this.penLabel.Size = new System.Drawing.Size(158, 50);
            this.penLabel.TabIndex = 2;
            this.penLabel.Text = "Number of Pens:\r\n\r\n";
            this.penLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // pencilBox
            // 
            this.pencilBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencilBox.Location = new System.Drawing.Point(288, 77);
            this.pencilBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pencilBox.Name = "pencilBox";
            this.pencilBox.Size = new System.Drawing.Size(54, 30);
            this.pencilBox.TabIndex = 3;
            // 
            // eraserBox
            // 
            this.eraserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraserBox.Location = new System.Drawing.Point(288, 133);
            this.eraserBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eraserBox.Name = "eraserBox";
            this.eraserBox.Size = new System.Drawing.Size(54, 30);
            this.eraserBox.TabIndex = 4;
            this.eraserBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // penBox
            // 
            this.penBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penBox.Location = new System.Drawing.Point(288, 190);
            this.penBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.penBox.Name = "penBox";
            this.penBox.Size = new System.Drawing.Size(54, 30);
            this.penBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calculateButton.FlatAppearance.BorderSize = 10;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(71, 265);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(271, 32);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // subLabel
            // 
            this.subLabel.Location = new System.Drawing.Point(66, 324);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(124, 160);
            this.subLabel.TabIndex = 7;
            this.subLabel.Text = "SubTotal:\r\n\r\nTax:\r\n\r\nTotal:\r\n\r\n\r\n";
            this.subLabel.Click += new System.EventHandler(this.subLabel_Click);
            // 
            // pricesLabel
            // 
            this.pricesLabel.Location = new System.Drawing.Point(237, 324);
            this.pricesLabel.Name = "pricesLabel";
            this.pricesLabel.Size = new System.Drawing.Size(105, 128);
            this.pricesLabel.TabIndex = 8;
            this.pricesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Location = new System.Drawing.Point(66, 235);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(276, 25);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(71, 484);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(271, 17);
            this.black.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tendered:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // moneyBox
            // 
            this.moneyBox.Location = new System.Drawing.Point(288, 525);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(54, 30);
            this.moneyBox.TabIndex = 12;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(71, 579);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(271, 34);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Get Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Location = new System.Drawing.Point(71, 625);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(98, 29);
            this.changeLabel.TabIndex = 14;
            this.changeLabel.Text = "Change:";
            // 
            // amountLabel
            // 
            this.amountLabel.Location = new System.Drawing.Point(237, 625);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(105, 52);
            this.amountLabel.TabIndex = 15;
            this.amountLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Goldenrod;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-2, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(909, 55);
            this.label3.TabIndex = 16;
            this.label3.Text = "School Supplies Store";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // getButton
            // 
            this.getButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.getButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getButton.Location = new System.Drawing.Point(71, 691);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(271, 32);
            this.getButton.TabIndex = 17;
            this.getButton.Text = "Get Receipt";
            this.getButton.UseVisualStyleBackColor = false;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptLabel.Location = new System.Drawing.Point(452, 117);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(350, 367);
            this.receiptLabel.TabIndex = 18;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(488, 531);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(271, 27);
            this.newButton.TabIndex = 19;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // productLabel
            // 
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(483, 195);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(138, 270);
            this.productLabel.TabIndex = 20;
            // 
            // numberLabel
            // 
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(627, 195);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(148, 270);
            this.numberLabel.TabIndex = 21;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(513, 124);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(224, 46);
            this.nameLabel.TabIndex = 22;
            this.nameLabel.Text = "School Supplies Store";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameLabel.Visible = false;
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(500, 433);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(259, 42);
            this.messageLabel.TabIndex = 23;
            this.messageLabel.Text = "Have a nice day! :)";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(904, 793);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.black);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.pricesLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.penBox);
            this.Controls.Add(this.eraserBox);
            this.Controls.Add(this.pencilBox);
            this.Controls.Add(this.penLabel);
            this.Controls.Add(this.eraserLabel);
            this.Controls.Add(this.pencilLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pencilLabel;
        private System.Windows.Forms.Label eraserLabel;
        private System.Windows.Forms.Label penLabel;
        private System.Windows.Forms.TextBox pencilBox;
        private System.Windows.Forms.TextBox eraserBox;
        private System.Windows.Forms.TextBox penBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label pricesLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label black;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label messageLabel;
    }
}

