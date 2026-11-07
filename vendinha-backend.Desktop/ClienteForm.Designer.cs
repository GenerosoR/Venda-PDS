#nullable disable

namespace vendinha_backend.Desktop;

partial class ClienteForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel tabela = null!;
    private TextBox txtCpf = null!;
    private TextBox txtNome = null!;
    private TextBox txtEmail = null!;
    private DateTimePicker pickerNascimento = null!;
    private Label lblCpf = null!;
    private Label lblNome = null!;
    private Label lblEmail = null!;
    private Label lblNascimento = null!;
    private Button btnCancelar = null!;
    private Button btnSalvar = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        tabela = new TableLayoutPanel();
        botoes = new FlowLayoutPanel();
        btnCancelar = new Button();
        btnSalvar = new Button();
        lblCpf = new Label();
        txtCpf = new TextBox();
        lblNome = new Label();
        txtNome = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblNascimento = new Label();
        pickerNascimento = new DateTimePicker();
        tabela.SuspendLayout();
        botoes.SuspendLayout();
        SuspendLayout();
        // 
        // tabela
        // 
        tabela.ColumnCount = 2;
        tabela.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
        tabela.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tabela.Controls.Add(botoes, 0, 4);
        tabela.Controls.Add(lblCpf, 0, 0);
        tabela.Controls.Add(txtCpf, 1, 0);
        tabela.Controls.Add(lblNome, 0, 1);
        tabela.Controls.Add(txtNome, 1, 1);
        tabela.Controls.Add(lblEmail, 0, 2);
        tabela.Controls.Add(txtEmail, 1, 2);
        tabela.Controls.Add(lblNascimento, 0, 3);
        tabela.Controls.Add(pickerNascimento, 1, 3);
        tabela.Dock = DockStyle.Fill;
        tabela.Location = new Point(0, 0);
        tabela.Name = "tabela";
        tabela.Padding = new Padding(12);
        tabela.RowCount = 5;
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        tabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        tabela.Size = new Size(430, 300);
        tabela.TabIndex = 0;
        // 
        // botoes
        // 
        tabela.SetColumnSpan(botoes, 2);
        botoes.Controls.Add(btnCancelar);
        botoes.Controls.Add(btnSalvar);
        botoes.Location = new Point(15, 167);
        botoes.Name = "botoes";
        botoes.Size = new Size(200, 100);
        botoes.TabIndex = 0;
        // 
        // btnCancelar
        // 
        btnCancelar.AutoSize = true;
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Location = new Point(3, 3);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(75, 25);
        btnCancelar.TabIndex = 0;
        btnCancelar.Text = "Cancelar";
        // 
        // btnSalvar
        // 
        btnSalvar.AutoSize = true;
        btnSalvar.Location = new Point(84, 3);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(81, 25);
        btnSalvar.TabIndex = 1;
        btnSalvar.Text = "Salvar";
        btnSalvar.Click += btnSalvar_Click;
        // 
        // lblCpf
        // 
        lblCpf.Anchor = AnchorStyles.Left;
        lblCpf.AutoSize = true;
        lblCpf.Location = new Point(15, 26);
        lblCpf.Margin = new Padding(3, 9, 3, 3);
        lblCpf.Name = "lblCpf";
        lblCpf.Size = new Size(31, 15);
        lblCpf.TabIndex = 1;
        lblCpf.Text = "CPF:";
        // 
        // txtCpf
        // 
        txtCpf.Dock = DockStyle.Fill;
        txtCpf.Location = new Point(150, 15);
        txtCpf.Name = "txtCpf";
        txtCpf.Size = new Size(265, 23);
        txtCpf.TabIndex = 0;
        // 
        // lblNome
        // 
        lblNome.Anchor = AnchorStyles.Left;
        lblNome.AutoSize = true;
        lblNome.Location = new Point(15, 64);
        lblNome.Margin = new Padding(3, 9, 3, 3);
        lblNome.Name = "lblNome";
        lblNome.Size = new Size(97, 15);
        lblNome.TabIndex = 2;
        lblNome.Text = "Nome completo:";
        // 
        // txtNome
        // 
        txtNome.Dock = DockStyle.Fill;
        txtNome.Location = new Point(150, 53);
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(265, 23);
        txtNome.TabIndex = 0;
        // 
        // lblEmail
        // 
        lblEmail.Anchor = AnchorStyles.Left;
        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(15, 102);
        lblEmail.Margin = new Padding(3, 9, 3, 3);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(44, 15);
        lblEmail.TabIndex = 3;
        lblEmail.Text = "E-mail:";
        // 
        // txtEmail
        // 
        txtEmail.Dock = DockStyle.Fill;
        txtEmail.Location = new Point(150, 91);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(265, 23);
        txtEmail.TabIndex = 0;
        // 
        // lblNascimento
        // 
        lblNascimento.Anchor = AnchorStyles.Left;
        lblNascimento.AutoSize = true;
        lblNascimento.Location = new Point(15, 140);
        lblNascimento.Margin = new Padding(3, 9, 3, 3);
        lblNascimento.Name = "lblNascimento";
        lblNascimento.Size = new Size(74, 15);
        lblNascimento.TabIndex = 4;
        lblNascimento.Text = "Nascimento:";
        // 
        // pickerNascimento
        // 
        pickerNascimento.Dock = DockStyle.Fill;
        pickerNascimento.Format = DateTimePickerFormat.Short;
        pickerNascimento.Location = new Point(150, 129);
        pickerNascimento.MaxDate = new DateTime(2026, 11, 7, 0, 0, 0, 0);
        pickerNascimento.Name = "pickerNascimento";
        pickerNascimento.Size = new Size(265, 23);
        pickerNascimento.TabIndex = 0;
        pickerNascimento.Value = new DateTime(2026, 11, 7, 0, 0, 0, 0);
        // 
        // ClienteForm
        // 
        AcceptButton = btnSalvar;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnCancelar;
        ClientSize = new Size(430, 300);
        Controls.Add(tabela);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ClienteForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cliente";
        tabela.ResumeLayout(false);
        tabela.PerformLayout();
        botoes.ResumeLayout(false);
        botoes.PerformLayout();
        ResumeLayout(false);
    }

    private void AdicionarCampo(string texto, Control controle, int linha)
    {
        tabela.Controls.Add(new Label { Text = texto, AutoSize = true, Anchor = AnchorStyles.Left, Margin = new Padding(3, 9, 3, 3) }, 0, linha);
        controle.Dock = DockStyle.Fill;
        tabela.Controls.Add(controle, 1, linha);
    }

    private FlowLayoutPanel botoes;
}
