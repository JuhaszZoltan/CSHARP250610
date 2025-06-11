partial class JobGUIForm
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        dgvJobs = new DataGridView();
        colMunkakor = new DataGridViewTextBoxColumn();
        colIparag = new DataGridViewTextBoxColumn();
        colAiAlkalmazas = new DataGridViewTextBoxColumn();
        colAutomatizalas = new DataGridViewTextBoxColumn();
        colSkill = new DataGridViewTextBoxColumn();
        cbxMunkakorok = new ComboBox();
        lblUI01 = new Label();
        chxProgNyelv = new CheckBox();
        btnSzuresEsSzamitas = new Button();
        txtArfolyam = new TextBox();
        label2 = new Label();
        btnEredetiAllapot = new Button();
        lblAvgHuf = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
        SuspendLayout();
        // 
        // dgvJobs
        // 
        dgvJobs.AllowUserToAddRows = false;
        dgvJobs.AllowUserToDeleteRows = false;
        dgvJobs.AllowUserToResizeColumns = false;
        dgvJobs.AllowUserToResizeRows = false;
        dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvJobs.Columns.AddRange(new DataGridViewColumn[] { colMunkakor, colIparag, colAiAlkalmazas, colAutomatizalas, colSkill });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvJobs.DefaultCellStyle = dataGridViewCellStyle2;
        dgvJobs.Location = new Point(12, 12);
        dgvJobs.Name = "dgvJobs";
        dgvJobs.RowHeadersVisible = false;
        dgvJobs.RowHeadersWidth = 62;
        dgvJobs.Size = new Size(1154, 602);
        dgvJobs.TabIndex = 0;
        // 
        // colMunkakor
        // 
        colMunkakor.FillWeight = 3F;
        colMunkakor.HeaderText = "Munkakör";
        colMunkakor.MinimumWidth = 8;
        colMunkakor.Name = "colMunkakor";
        // 
        // colIparag
        // 
        colIparag.FillWeight = 3F;
        colIparag.HeaderText = "Iparág";
        colIparag.MinimumWidth = 8;
        colIparag.Name = "colIparag";
        // 
        // colAiAlkalmazas
        // 
        colAiAlkalmazas.FillWeight = 2F;
        colAiAlkalmazas.HeaderText = "AI alkalmazás";
        colAiAlkalmazas.MinimumWidth = 8;
        colAiAlkalmazas.Name = "colAiAlkalmazas";
        // 
        // colAutomatizalas
        // 
        colAutomatizalas.FillWeight = 2F;
        colAutomatizalas.HeaderText = "Automatizálás";
        colAutomatizalas.MinimumWidth = 8;
        colAutomatizalas.Name = "colAutomatizalas";
        // 
        // colSkill
        // 
        colSkill.FillWeight = 3F;
        colSkill.HeaderText = "Skill";
        colSkill.MinimumWidth = 8;
        colSkill.Name = "colSkill";
        // 
        // cbxMunkakorok
        // 
        cbxMunkakorok.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxMunkakorok.FormattingEnabled = true;
        cbxMunkakorok.Location = new Point(12, 655);
        cbxMunkakorok.Name = "cbxMunkakorok";
        cbxMunkakorok.Size = new Size(307, 40);
        cbxMunkakorok.TabIndex = 1;
        // 
        // lblUI01
        // 
        lblUI01.AutoSize = true;
        lblUI01.Location = new Point(12, 620);
        lblUI01.Name = "lblUI01";
        lblUI01.Size = new Size(126, 32);
        lblUI01.TabIndex = 2;
        lblUI01.Text = "munkakör:";
        // 
        // chxProgNyelv
        // 
        chxProgNyelv.AutoSize = true;
        chxProgNyelv.Location = new Point(350, 659);
        chxProgNyelv.Name = "chxProgNyelv";
        chxProgNyelv.Size = new Size(312, 36);
        chxProgNyelv.TabIndex = 3;
        chxProgNyelv.Text = "csak programnyelvek skill";
        chxProgNyelv.UseVisualStyleBackColor = true;
        // 
        // btnSzuresEsSzamitas
        // 
        btnSzuresEsSzamitas.Location = new Point(697, 655);
        btnSzuresEsSzamitas.Name = "btnSzuresEsSzamitas";
        btnSzuresEsSzamitas.Size = new Size(219, 86);
        btnSzuresEsSzamitas.TabIndex = 4;
        btnSzuresEsSzamitas.Text = "szűrés és számítás";
        btnSzuresEsSzamitas.UseVisualStyleBackColor = true;
        // 
        // txtArfolyam
        // 
        txtArfolyam.Location = new Point(200, 718);
        txtArfolyam.Name = "txtArfolyam";
        txtArfolyam.Size = new Size(119, 39);
        txtArfolyam.TabIndex = 5;
        txtArfolyam.Text = "380,85";
        txtArfolyam.TextAlign = HorizontalAlignment.Right;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 721);
        label2.Name = "label2";
        label2.Size = new Size(165, 32);
        label2.TabIndex = 2;
        label2.Text = "USD árfolyam:";
        // 
        // btnEredetiAllapot
        // 
        btnEredetiAllapot.Enabled = false;
        btnEredetiAllapot.Location = new Point(947, 655);
        btnEredetiAllapot.Name = "btnEredetiAllapot";
        btnEredetiAllapot.Size = new Size(219, 86);
        btnEredetiAllapot.TabIndex = 4;
        btnEredetiAllapot.Text = "eredeti állapot";
        btnEredetiAllapot.UseVisualStyleBackColor = true;
        // 
        // lblAvgHuf
        // 
        lblAvgHuf.AutoSize = true;
        lblAvgHuf.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblAvgHuf.Location = new Point(350, 721);
        lblAvgHuf.Name = "lblAvgHuf";
        lblAvgHuf.Size = new Size(0, 32);
        lblAvgHuf.TabIndex = 6;
        lblAvgHuf.Visible = false;
        // 
        // JobGUIForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1178, 769);
        Controls.Add(lblAvgHuf);
        Controls.Add(txtArfolyam);
        Controls.Add(btnEredetiAllapot);
        Controls.Add(btnSzuresEsSzamitas);
        Controls.Add(chxProgNyelv);
        Controls.Add(label2);
        Controls.Add(lblUI01);
        Controls.Add(cbxMunkakorok);
        Controls.Add(dgvJobs);
        Font = new Font("Segoe UI", 12F);
        Margin = new Padding(4, 5, 4, 5);
        Name = "JobGUIForm";
        Text = "AI-alapú munkaerőpiac";
        ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dgvJobs;
    private ComboBox cbxMunkakorok;
    private Label lblUI01;
    private CheckBox chxProgNyelv;
    private Button btnSzuresEsSzamitas;
    private TextBox txtArfolyam;
    private DataGridViewTextBoxColumn colMunkakor;
    private DataGridViewTextBoxColumn colIparag;
    private DataGridViewTextBoxColumn colAiAlkalmazas;
    private DataGridViewTextBoxColumn colAutomatizalas;
    private DataGridViewTextBoxColumn colSkill;
    private Label label2;
    private Button btnEredetiAllapot;
    private Label lblAvgHuf;
}
