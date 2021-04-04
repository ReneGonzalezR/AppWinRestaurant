
namespace AppWinRestaurant
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
            this.dtvIngredientes = new System.Windows.Forms.DataGridView();
            this.Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSoda = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblPepinillo = new System.Windows.Forms.Label();
            this.lblChampiñon = new System.Windows.Forms.Label();
            this.lbllechuga = new System.Windows.Forms.Label();
            this.lblPapas = new System.Windows.Forms.Label();
            this.lbltomate = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbHotDog = new System.Windows.Forms.RadioButton();
            this.rbHamburgesa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvIngredientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvIngredientes
            // 
            this.dtvIngredientes.AllowUserToAddRows = false;
            this.dtvIngredientes.AllowUserToDeleteRows = false;
            this.dtvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingrediente,
            this.Costo});
            this.dtvIngredientes.Location = new System.Drawing.Point(56, 103);
            this.dtvIngredientes.Name = "dtvIngredientes";
            this.dtvIngredientes.ReadOnly = true;
            this.dtvIngredientes.RowHeadersWidth = 102;
            this.dtvIngredientes.RowTemplate.Height = 49;
            this.dtvIngredientes.Size = new System.Drawing.Size(605, 430);
            this.dtvIngredientes.TabIndex = 0;
            // 
            // Ingrediente
            // 
            this.Ingrediente.HeaderText = "Ingrediente";
            this.Ingrediente.MinimumWidth = 12;
            this.Ingrediente.Name = "Ingrediente";
            this.Ingrediente.ReadOnly = true;
            this.Ingrediente.Width = 250;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 12;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 250;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(605, 255);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 58);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar +";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSoda);
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.lblPepinillo);
            this.groupBox1.Controls.Add(this.lblChampiñon);
            this.groupBox1.Controls.Add(this.lbllechuga);
            this.groupBox1.Controls.Add(this.lblPapas);
            this.groupBox1.Controls.Add(this.lbltomate);
            this.groupBox1.Controls.Add(this.lblIngredientes);
            this.groupBox1.Controls.Add(this.txtIngrediente);
            this.groupBox1.Controls.Add(this.rbOtro);
            this.groupBox1.Controls.Add(this.rbHotDog);
            this.groupBox1.Controls.Add(this.rbHamburgesa);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(55, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 874);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paltillos";
            // 
            // lblSoda
            // 
            this.lblSoda.AutoSize = true;
            this.lblSoda.Location = new System.Drawing.Point(374, 696);
            this.lblSoda.Name = "lblSoda";
            this.lblSoda.Size = new System.Drawing.Size(141, 41);
            this.lblSoda.TabIndex = 15;
            this.lblSoda.Text = "$15 Soda";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(605, 358);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(188, 58);
            this.btnQuitar.TabIndex = 14;
            this.btnQuitar.Text = "Quitar -";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblPepinillo
            // 
            this.lblPepinillo.AutoSize = true;
            this.lblPepinillo.Location = new System.Drawing.Point(374, 631);
            this.lblPepinillo.Name = "lblPepinillo";
            this.lblPepinillo.Size = new System.Drawing.Size(194, 41);
            this.lblPepinillo.TabIndex = 13;
            this.lblPepinillo.Text = "$2.5 Pepinillo";
            // 
            // lblChampiñon
            // 
            this.lblChampiñon.AutoSize = true;
            this.lblChampiñon.Location = new System.Drawing.Point(54, 696);
            this.lblChampiñon.Name = "lblChampiñon";
            this.lblChampiñon.Size = new System.Drawing.Size(241, 41);
            this.lblChampiñon.TabIndex = 11;
            this.lblChampiñon.Text = "$3 Champiñones";
            // 
            // lbllechuga
            // 
            this.lbllechuga.AutoSize = true;
            this.lbllechuga.Location = new System.Drawing.Point(54, 631);
            this.lbllechuga.Name = "lbllechuga";
            this.lbllechuga.Size = new System.Drawing.Size(169, 41);
            this.lbllechuga.TabIndex = 10;
            this.lbllechuga.Text = "$1 Lechuga";
            // 
            // lblPapas
            // 
            this.lblPapas.AutoSize = true;
            this.lblPapas.Location = new System.Drawing.Point(374, 570);
            this.lblPapas.Name = "lblPapas";
            this.lblPapas.Size = new System.Drawing.Size(252, 41);
            this.lblPapas.TabIndex = 9;
            this.lblPapas.Text = "$10 Papas Crunsh";
            // 
            // lbltomate
            // 
            this.lbltomate.AutoSize = true;
            this.lbltomate.Location = new System.Drawing.Point(54, 570);
            this.lbltomate.Name = "lbltomate";
            this.lbltomate.Size = new System.Drawing.Size(156, 41);
            this.lbltomate.TabIndex = 8;
            this.lbltomate.Text = "$2 Tomate";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new System.Drawing.Point(22, 480);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(178, 41);
            this.lblIngredientes.TabIndex = 7;
            this.lblIngredientes.Text = "Ingrediente:";
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.Location = new System.Drawing.Point(206, 480);
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.Size = new System.Drawing.Size(250, 47);
            this.txtIngrediente.TabIndex = 6;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(11, 387);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(260, 45);
            this.rbOtro.TabIndex = 5;
            this.rbOtro.Text = "Otras Opciones";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // rbHotDog
            // 
            this.rbHotDog.AutoSize = true;
            this.rbHotDog.Location = new System.Drawing.Point(11, 224);
            this.rbHotDog.Name = "rbHotDog";
            this.rbHotDog.Size = new System.Drawing.Size(453, 45);
            this.rbHotDog.TabIndex = 4;
            this.rbHotDog.Text = "$60 HotDog, Papas y Refresco";
            this.rbHotDog.UseVisualStyleBackColor = true;
            this.rbHotDog.CheckedChanged += new System.EventHandler(this.rbHotDog_CheckedChanged);
            // 
            // rbHamburgesa
            // 
            this.rbHamburgesa.AutoSize = true;
            this.rbHamburgesa.Checked = true;
            this.rbHamburgesa.Location = new System.Drawing.Point(11, 68);
            this.rbHamburgesa.Name = "rbHamburgesa";
            this.rbHamburgesa.Size = new System.Drawing.Size(516, 45);
            this.rbHamburgesa.TabIndex = 3;
            this.rbHamburgesa.TabStop = true;
            this.rbHamburgesa.Text = "$80 Hamburgesa, Papas y Refresco";
            this.rbHamburgesa.UseVisualStyleBackColor = true;
            this.rbHamburgesa.CheckedChanged += new System.EventHandler(this.rbHamburgesa_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblIva);
            this.groupBox2.Controls.Add(this.lblPedido);
            this.groupBox2.Controls.Add(this.btnPagar);
            this.groupBox2.Controls.Add(this.txtPago);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtvIngredientes);
            this.groupBox2.Location = new System.Drawing.Point(921, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 874);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orden:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(335, 658);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 41);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 658);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 41);
            this.label5.TabIndex = 19;
            this.label5.Text = "Total:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(335, 601);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(34, 41);
            this.lblIva.TabIndex = 18;
            this.lblIva.Text = "0";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(335, 548);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(34, 41);
            this.lblPedido.TabIndex = 17;
            this.lblPedido.Text = "0";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(245, 776);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(188, 58);
            this.btnPagar.TabIndex = 16;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(313, 713);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(199, 47);
            this.txtPago.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 713);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tu Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "IVA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedido:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 912);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "René a la Gourmet";
            ((System.ComponentModel.ISupportInitialize)(this.dtvIngredientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvIngredientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPepinillo;
        private System.Windows.Forms.Label lblChampiñon;
        private System.Windows.Forms.Label lbllechuga;
        private System.Windows.Forms.Label lblPapas;
        private System.Windows.Forms.Label lbltomate;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.TextBox txtIngrediente;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbHotDog;
        private System.Windows.Forms.RadioButton rbHamburgesa;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblSoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
    }
}

