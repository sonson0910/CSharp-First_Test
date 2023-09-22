namespace QuanLyChungCu
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
            this.lstvCK = new System.Windows.Forms.ListView();
            this.clmnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnBedroom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnToilet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnDirection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBedroom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbToilet = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.Label();
            this.txbDirection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstvCK
            // 
            this.lstvCK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnAddress,
            this.clmnBedroom,
            this.clmnToilet,
            this.clmnDirection,
            this.clmnPrice,
            this.clmnDiscount,
            this.clmnStatus});
            this.lstvCK.FullRowSelect = true;
            this.lstvCK.GridLines = true;
            this.lstvCK.HideSelection = false;
            this.lstvCK.Location = new System.Drawing.Point(360, 8);
            this.lstvCK.Name = "lstvCK";
            this.lstvCK.Size = new System.Drawing.Size(1005, 426);
            this.lstvCK.TabIndex = 0;
            this.lstvCK.UseCompatibleStateImageBehavior = false;
            this.lstvCK.View = System.Windows.Forms.View.Details;
            this.lstvCK.SelectedIndexChanged += new System.EventHandler(this.lstvCK_SelectedIndexChanged);
            // 
            // clmnAddress
            // 
            this.clmnAddress.Text = "Address";
            this.clmnAddress.Width = 300;
            // 
            // clmnBedroom
            // 
            this.clmnBedroom.Text = "Bedroom";
            this.clmnBedroom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmnBedroom.Width = 75;
            // 
            // clmnToilet
            // 
            this.clmnToilet.Text = "Toilet";
            this.clmnToilet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clmnDirection
            // 
            this.clmnDirection.Text = "Direction";
            this.clmnDirection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmnDirection.Width = 85;
            // 
            // clmnPrice
            // 
            this.clmnPrice.Text = "Price";
            this.clmnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmnPrice.Width = 80;
            // 
            // clmnDiscount
            // 
            this.clmnDiscount.Text = "Discount";
            this.clmnDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmnDiscount.Width = 70;
            // 
            // clmnStatus
            // 
            this.clmnStatus.Text = "Status";
            this.clmnStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmnStatus.Width = 80;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(217, 309);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(83, 352);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(217, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(82, 19);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(256, 23);
            this.txbAddress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bedroom";
            // 
            // txbBedroom
            // 
            this.txbBedroom.Location = new System.Drawing.Point(82, 79);
            this.txbBedroom.Multiline = true;
            this.txbBedroom.Name = "txbBedroom";
            this.txbBedroom.Size = new System.Drawing.Size(81, 23);
            this.txbBedroom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Toilet";
            // 
            // txbToilet
            // 
            this.txbToilet.Location = new System.Drawing.Point(257, 82);
            this.txbToilet.Multiline = true;
            this.txbToilet.Name = "txbToilet";
            this.txbToilet.Size = new System.Drawing.Size(81, 23);
            this.txbToilet.TabIndex = 4;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(16, 142);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(60, 16);
            this.D.TabIndex = 3;
            this.D.Text = "Direction";
            // 
            // txbDirection
            // 
            this.txbDirection.Location = new System.Drawing.Point(82, 139);
            this.txbDirection.Multiline = true;
            this.txbDirection.Name = "txbDirection";
            this.txbDirection.Size = new System.Drawing.Size(256, 23);
            this.txbDirection.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price";
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(82, 197);
            this.txbPrice.Multiline = true;
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(256, 23);
            this.txbPrice.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Status";
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(83, 259);
            this.txbStatus.Multiline = true;
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(256, 23);
            this.txbStatus.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nguyen Hong Son - 211204228";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDirection);
            this.Controls.Add(this.D);
            this.Controls.Add(this.txbToilet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbBedroom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstvCK);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartment Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvCK;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader clmnAddress;
        private System.Windows.Forms.ColumnHeader clmnBedroom;
        private System.Windows.Forms.ColumnHeader clmnDirection;
        private System.Windows.Forms.ColumnHeader clmnPrice;
        private System.Windows.Forms.ColumnHeader clmnDiscount;
        private System.Windows.Forms.ColumnHeader clmnStatus;
        private System.Windows.Forms.ColumnHeader clmnToilet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBedroom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbToilet;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.TextBox txbDirection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label4;
    }
}

