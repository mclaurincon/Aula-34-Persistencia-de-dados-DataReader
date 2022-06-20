namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnmysql = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectionsqlserver = new System.Windows.Forms.Button();
            this.btnListarsqlServer = new System.Windows.Forms.Button();
            this.btnListarMysql = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConnmysql
            // 
            this.btnConnmysql.Location = new System.Drawing.Point(51, 76);
            this.btnConnmysql.Name = "btnConnmysql";
            this.btnConnmysql.Size = new System.Drawing.Size(204, 29);
            this.btnConnmysql.TabIndex = 0;
            this.btnConnmysql.Text = "conexao mysql";
            this.btnConnmysql.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ado.net";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConnectionsqlserver
            // 
            this.btnConnectionsqlserver.Location = new System.Drawing.Point(293, 76);
            this.btnConnectionsqlserver.Name = "btnConnectionsqlserver";
            this.btnConnectionsqlserver.Size = new System.Drawing.Size(204, 29);
            this.btnConnectionsqlserver.TabIndex = 2;
            this.btnConnectionsqlserver.Text = "conexao sql";
            this.btnConnectionsqlserver.UseVisualStyleBackColor = true;
            // 
            // btnListarsqlServer
            // 
            this.btnListarsqlServer.Location = new System.Drawing.Point(293, 122);
            this.btnListarsqlServer.Name = "btnListarsqlServer";
            this.btnListarsqlServer.Size = new System.Drawing.Size(204, 48);
            this.btnListarsqlServer.TabIndex = 4;
            this.btnListarsqlServer.Text = "Listar Sql Server";
            this.btnListarsqlServer.UseVisualStyleBackColor = true;
            this.btnListarsqlServer.Click += new System.EventHandler(this.btnListarsqlServer_Click);
            // 
            // btnListarMysql
            // 
            this.btnListarMysql.Location = new System.Drawing.Point(51, 122);
            this.btnListarMysql.Name = "btnListarMysql";
            this.btnListarMysql.Size = new System.Drawing.Size(204, 48);
            this.btnListarMysql.TabIndex = 3;
            this.btnListarMysql.Text = "Listar no MySql";
            this.btnListarMysql.UseVisualStyleBackColor = true;
            this.btnListarMysql.Click += new System.EventHandler(this.btnListarMysql_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(51, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 104);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(293, 201);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(204, 104);
            this.listBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnListarsqlServer);
            this.Controls.Add(this.btnListarMysql);
            this.Controls.Add(this.btnConnectionsqlserver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnmysql);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnConnmysql;
        private Label label1;
        private Button btnConnectionsqlserver;
        private Button btnListarsqlServer;
        private Button btnListarMysql;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}