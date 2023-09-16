namespace FormProgramCamadas
{
    partial class frmCadastroCliente
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
            label1 = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtDataNasc = new TextBox();
            label4 = new Label();
            txtCPF = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 36);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(70, 33);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(41, 23);
            txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 62);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(317, 23);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 65);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(70, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(317, 23);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 94);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // txtDataNasc
            // 
            txtDataNasc.Location = new Point(70, 120);
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(79, 23);
            txtDataNasc.TabIndex = 7;
            txtDataNasc.Text = "00/00/0000";
            txtDataNasc.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 123);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Data Nasc:";
            label4.Click += label4_Click;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(208, 120);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(109, 23);
            txtCPF.TabIndex = 9;
            txtCPF.Text = "000.000.000-00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 126);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "CPF:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(292, 186);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 221);
            Controls.Add(btnGuardar);
            Controls.Add(txtCPF);
            Controls.Add(label5);
            Controls.Add(txtDataNasc);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "frmCadastroCliente";
            Text = "Form1";
            Load += frmCadastroCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtDataNasc;
        private Label label4;
        private TextBox txtCPF;
        private Label label5;
        private Button btnGuardar;
    }
}