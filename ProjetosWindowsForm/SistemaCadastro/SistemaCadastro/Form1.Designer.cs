namespace SistemaCadastro
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
            this.txtName = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.comboState = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxDate = new System.Windows.Forms.DateTimePicker();
            this.boxMaritalStatus = new System.Windows.Forms.ComboBox();
            this.boxPhone = new System.Windows.Forms.MaskedTextBox();
            this.checkHouse = new System.Windows.Forms.CheckBox();
            this.checkCar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.radioW = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(19, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(53, 21);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Nome";
            this.txtName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDate.Location = new System.Drawing.Point(19, 55);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(150, 21);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "Data de Nascimento";
            this.txtDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboState
            // 
            this.comboState.AutoSize = true;
            this.comboState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboState.Location = new System.Drawing.Point(19, 91);
            this.comboState.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(90, 21);
            this.comboState.TabIndex = 2;
            this.comboState.Text = "Estado Civil";
            this.comboState.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(19, 130);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(67, 21);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Text = "Telefone";
            this.txtPhone.Click += new System.EventHandler(this.label4_Click);
            // 
            // boxName
            // 
            this.boxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxName.Location = new System.Drawing.Point(269, 10);
            this.boxName.Margin = new System.Windows.Forms.Padding(5);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(675, 29);
            this.boxName.TabIndex = 4;
            // 
            // boxDate
            // 
            this.boxDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxDate.Location = new System.Drawing.Point(269, 49);
            this.boxDate.Margin = new System.Windows.Forms.Padding(5);
            this.boxDate.Name = "boxDate";
            this.boxDate.Size = new System.Drawing.Size(342, 29);
            this.boxDate.TabIndex = 5;
            // 
            // boxMaritalStatus
            // 
            this.boxMaritalStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxMaritalStatus.FormattingEnabled = true;
            this.boxMaritalStatus.Location = new System.Drawing.Point(269, 88);
            this.boxMaritalStatus.Margin = new System.Windows.Forms.Padding(5);
            this.boxMaritalStatus.Name = "boxMaritalStatus";
            this.boxMaritalStatus.Size = new System.Drawing.Size(342, 29);
            this.boxMaritalStatus.TabIndex = 6;
            // 
            // boxPhone
            // 
            this.boxPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxPhone.Location = new System.Drawing.Point(269, 127);
            this.boxPhone.Margin = new System.Windows.Forms.Padding(5);
            this.boxPhone.Mask = "(00) 00000-0000";
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(342, 29);
            this.boxPhone.TabIndex = 7;
            // 
            // checkHouse
            // 
            this.checkHouse.AutoSize = true;
            this.checkHouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkHouse.Location = new System.Drawing.Point(269, 164);
            this.checkHouse.Name = "checkHouse";
            this.checkHouse.Size = new System.Drawing.Size(165, 25);
            this.checkHouse.TabIndex = 8;
            this.checkHouse.Text = "Possui Casa própria";
            this.checkHouse.UseVisualStyleBackColor = true;
            // 
            // checkCar
            // 
            this.checkCar.AutoSize = true;
            this.checkCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkCar.Location = new System.Drawing.Point(269, 195);
            this.checkCar.Name = "checkCar";
            this.checkCar.Size = new System.Drawing.Size(182, 25);
            this.checkCar.TabIndex = 9;
            this.checkCar.Text = "Possui veiculo proprio";
            this.checkCar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioO);
            this.groupBox1.Controls.Add(this.radioW);
            this.groupBox1.Controls.Add(this.radioM);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(269, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 148);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.Location = new System.Drawing.Point(19, 104);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(76, 25);
            this.radioO.TabIndex = 2;
            this.radioO.Text = "Outros";
            this.radioO.UseVisualStyleBackColor = true;
            // 
            // radioW
            // 
            this.radioW.AutoSize = true;
            this.radioW.Location = new System.Drawing.Point(19, 67);
            this.radioW.Name = "radioW";
            this.radioW.Size = new System.Drawing.Size(93, 25);
            this.radioW.TabIndex = 1;
            this.radioW.Text = "Feminino";
            this.radioW.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Checked = true;
            this.radioM.Location = new System.Drawing.Point(19, 32);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(99, 25);
            this.radioM.TabIndex = 0;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 21;
            this.lista.Location = new System.Drawing.Point(19, 488);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(925, 130);
            this.lista.TabIndex = 11;
            this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(19, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 53);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Cadastrar / Alterar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(218, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 53);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(775, 421);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 57);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 630);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkCar);
            this.Controls.Add(this.checkHouse);
            this.Controls.Add(this.boxPhone);
            this.Controls.Add(this.boxMaritalStatus);
            this.Controls.Add(this.boxDate);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.comboState);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtName;
        private Label txtDate;
        private Label comboState;
        private Label txtPhone;
        private TextBox boxName;
        private DateTimePicker boxDate;
        private ComboBox boxMaritalStatus;
        private MaskedTextBox boxPhone;
        private CheckBox checkHouse;
        private CheckBox checkCar;
        private GroupBox groupBox1;
        private RadioButton radioO;
        private RadioButton radioW;
        private RadioButton radioM;
        private ListBox lista;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}