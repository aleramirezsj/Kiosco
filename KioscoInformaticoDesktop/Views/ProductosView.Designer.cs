namespace KioscoInformaticoDesktop.Views
{
    partial class ProductosView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            tabControl = new TabControl();
            tabPageLista = new TabPage();
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtFiltro = new TextBox();
            iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            iconButtonEditar = new FontAwesome.Sharp.IconButton();
            iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            dataGridProductosView = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            numericPrecio = new NumericUpDown();
            txtPrecio = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductosView).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1296, 86);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 50);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(0, 96);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1284, 736);
            tabControl.TabIndex = 2;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(iconButtonSalir);
            tabPageLista.Controls.Add(BtnBuscar);
            tabPageLista.Controls.Add(label3);
            tabPageLista.Controls.Add(txtFiltro);
            tabPageLista.Controls.Add(iconButtonEliminar);
            tabPageLista.Controls.Add(iconButtonEditar);
            tabPageLista.Controls.Add(iconButtonAgregar);
            tabPageLista.Controls.Add(dataGridProductosView);
            tabPageLista.Location = new Point(4, 34);
            tabPageLista.Margin = new Padding(4, 5, 4, 5);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(4, 5, 4, 5);
            tabPageLista.Size = new Size(1276, 698);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // iconButtonSalir
            // 
            iconButtonSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonSalir.BackColor = Color.OrangeRed;
            iconButtonSalir.ForeColor = Color.White;
            iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButtonSalir.IconColor = Color.White;
            iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSalir.IconSize = 44;
            iconButtonSalir.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonSalir.Location = new Point(1086, 481);
            iconButtonSalir.Margin = new Padding(4, 5, 4, 5);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Size = new Size(154, 94);
            iconButtonSalir.TabIndex = 10;
            iconButtonSalir.Text = "&Salir";
            iconButtonSalir.TextAlign = ContentAlignment.MiddleRight;
            iconButtonSalir.UseVisualStyleBackColor = false;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.OrangeRed;
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.White;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(1086, 18);
            BtnBuscar.Margin = new Padding(4, 5, 4, 5);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(154, 94);
            BtnBuscar.TabIndex = 9;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 19);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 8;
            label3.Text = "Buscar producto:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(202, 19);
            txtFiltro.Margin = new Padding(4, 4, 4, 4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(852, 31);
            txtFiltro.TabIndex = 7;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // iconButtonEliminar
            // 
            iconButtonEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonEliminar.BackColor = Color.OrangeRed;
            iconButtonEliminar.ForeColor = Color.White;
            iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.ToiletPortable;
            iconButtonEliminar.IconColor = Color.White;
            iconButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEliminar.IconSize = 44;
            iconButtonEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonEliminar.Location = new Point(1086, 366);
            iconButtonEliminar.Margin = new Padding(4, 5, 4, 5);
            iconButtonEliminar.Name = "iconButtonEliminar";
            iconButtonEliminar.Size = new Size(154, 94);
            iconButtonEliminar.TabIndex = 6;
            iconButtonEliminar.Text = "Eli&minar";
            iconButtonEliminar.TextAlign = ContentAlignment.MiddleRight;
            iconButtonEliminar.UseVisualStyleBackColor = false;
            iconButtonEliminar.Click += iconButtonEliminar_Click;
            // 
            // iconButtonEditar
            // 
            iconButtonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonEditar.BackColor = Color.OrangeRed;
            iconButtonEditar.ForeColor = Color.White;
            iconButtonEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButtonEditar.IconColor = Color.White;
            iconButtonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEditar.IconSize = 45;
            iconButtonEditar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonEditar.Location = new Point(1086, 244);
            iconButtonEditar.Margin = new Padding(4, 5, 4, 5);
            iconButtonEditar.Name = "iconButtonEditar";
            iconButtonEditar.Size = new Size(154, 94);
            iconButtonEditar.TabIndex = 5;
            iconButtonEditar.Text = "&Editar";
            iconButtonEditar.TextAlign = ContentAlignment.MiddleRight;
            iconButtonEditar.UseVisualStyleBackColor = false;
            iconButtonEditar.Click += iconButtonEditar_Click;
            // 
            // iconButtonAgregar
            // 
            iconButtonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonAgregar.BackColor = Color.OrangeRed;
            iconButtonAgregar.ForeColor = Color.White;
            iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButtonAgregar.IconColor = Color.White;
            iconButtonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonAgregar.Location = new Point(1086, 121);
            iconButtonAgregar.Margin = new Padding(4, 5, 4, 5);
            iconButtonAgregar.Name = "iconButtonAgregar";
            iconButtonAgregar.Size = new Size(154, 94);
            iconButtonAgregar.TabIndex = 4;
            iconButtonAgregar.Text = "&Agregar";
            iconButtonAgregar.TextAlign = ContentAlignment.MiddleRight;
            iconButtonAgregar.UseVisualStyleBackColor = false;
            iconButtonAgregar.Click += iconButtonAgregar_Click;
            // 
            // dataGridProductosView
            // 
            dataGridProductosView.AllowUserToAddRows = false;
            dataGridProductosView.AllowUserToDeleteRows = false;
            dataGridProductosView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProductosView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridProductosView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridProductosView.Location = new Point(4, 74);
            dataGridProductosView.Margin = new Padding(4, 5, 4, 5);
            dataGridProductosView.Name = "dataGridProductosView";
            dataGridProductosView.ReadOnly = true;
            dataGridProductosView.RowHeadersWidth = 51;
            dataGridProductosView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProductosView.Size = new Size(1051, 611);
            dataGridProductosView.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(numericPrecio);
            tabPageAgregarEditar.Controls.Add(txtPrecio);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 34);
            tabPageAgregarEditar.Margin = new Padding(4, 5, 4, 5);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(4, 5, 4, 5);
            tabPageAgregarEditar.Size = new Size(1276, 698);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // numericPrecio
            // 
            numericPrecio.DecimalPlaces = 2;
            numericPrecio.Location = new Point(556, 259);
            numericPrecio.Margin = new Padding(4, 5, 4, 5);
            numericPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(281, 31);
            numericPrecio.TabIndex = 13;
            numericPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            txtPrecio.AutoSize = true;
            txtPrecio.Location = new Point(428, 261);
            txtPrecio.Margin = new Padding(4, 0, 4, 0);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(64, 25);
            txtPrecio.TabIndex = 12;
            txtPrecio.Text = "Precio:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(734, 459);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 100);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(396, 459);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 100);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(556, 76);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 31);
            txtNombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // ProductosView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 836);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProductosView";
            Text = "ProductosView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductosView).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabPageLista;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView dataGridProductosView;
        private TabPage tabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private FontAwesome.Sharp.IconButton iconButtonEditar;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
        private NumericUpDown numericPrecio;
        private Label txtPrecio;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private TextBox txtFiltro;
    }
}