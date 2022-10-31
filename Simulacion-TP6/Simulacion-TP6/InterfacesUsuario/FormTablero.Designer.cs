
namespace Simulacion_TP6.InterfacesUsuario
{
    partial class FormTablero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTablero));
            this.lblCantidadSimulaciones = new System.Windows.Forms.Label();
            this.lblMostrarDesde = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPedidosPorHoraProbabilidad = new System.Windows.Forms.Label();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.inputCantidadMostrar = new System.Windows.Forms.NumericUpDown();
            this.inputMostrarDesde = new System.Windows.Forms.NumericUpDown();
            this.inputPedidosPorHoraProbabilidad = new System.Windows.Forms.NumericUpDown();
            this.inputCantidadSimulaciones = new System.Windows.Forms.NumericUpDown();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.dataGridViewSimulaciones = new System.Windows.Forms.DataGridView();
            this.gbParametrosMetodosNumericosSimulacion = new System.Windows.Forms.GroupBox();
            this.lblCoeficienteX0Simulacion = new System.Windows.Forms.Label();
            this.inputCoeficienteX0Simulacion = new System.Windows.Forms.NumericUpDown();
            this.lblCoeficienteXPrima0Simulacion = new System.Windows.Forms.Label();
            this.inputCoeficienteXPrima0Simulacion = new System.Windows.Forms.NumericUpDown();
            this.lblCoeficienteHSimulacion = new System.Windows.Forms.Label();
            this.inputCoeficienteHSimulacion = new System.Windows.Forms.NumericUpDown();
            this.lblCoeficienteCSimulacion = new System.Windows.Forms.Label();
            this.inputCoeficienteAHastaSimulacion = new System.Windows.Forms.NumericUpDown();
            this.lblCoeficienteAHastaSimulacion = new System.Windows.Forms.Label();
            this.inputCoeficienteBSimulacion = new System.Windows.Forms.NumericUpDown();
            this.inputCoeficienteCSimulacion = new System.Windows.Forms.NumericUpDown();
            this.inputCoeficienteADesdeSimulacion = new System.Windows.Forms.NumericUpDown();
            this.lblCoeficienteADesdeSimulacion = new System.Windows.Forms.Label();
            this.lblCoeficienteBSimulacion = new System.Windows.Forms.Label();
            this.inputMetodoNumerico = new System.Windows.Forms.ComboBox();
            this.lblMetodoNumerico = new System.Windows.Forms.Label();
            this.Simulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnsamblesFinalizados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnsamblesPorHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromedioEnsamblesPorHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabiliadadPedidosPorHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoPromedioEnsamblesFinalizados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromedioPedidosSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProporcionFinalizadosSolicitados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LlegadaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola1Maxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola1PromedioPermanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola1PromedioPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoServidor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoEnServidor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoServidor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalizacionServidor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor1PorcentajeOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor1PorcentajeBloqueo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola2Maxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola2PromedioPermanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola2PromedioPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoServidor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoEnServidor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoServidor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalizacionServidor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor2PorcentajeOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor2PorcentajeBloqueo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola3Maxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola3PromedioPermanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola3PromedioPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoServidor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoEnServidor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoServidor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalizacionServidor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor3PorcentajeOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor3PorcentajeBloqueo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola4Maxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola4PromedioPermanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola4PromedioPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoServidor4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoEnServidor4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoServidor4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalizacionServidor4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor4PorcentajeOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor4PorcentajeBloqueo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola5a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola5aMaxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola5aPromedioPermanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola5aPromedioPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola5b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola5bMaxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola5bPromedioPermanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola5bPromedioPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoServidor5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoEnServidor5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoServidor5a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalizacionServidor5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor5PorcentajeOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor5PorcentajeBloqueo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor5ProporcionBloqueoRespectoOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaFinalizados3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaFinalizados3Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaFinalizados3PromedioPermanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaFinalizados3PromedioPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaFinalizados5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaFinalizados5Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaFinalizados5PromedioPermanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaFinalizados5PromedioPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoServidorFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoEnServidorFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoServidorFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalizacionServidorFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServidorFinalizacionPorcentajeOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServidorFinalizacionPorcentajeBloqueo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaFinalizadosFinalizacionPromedioPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServidorCuelloBotella = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputCantidadMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMostrarDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPedidosPorHoraProbabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCantidadSimulaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulaciones)).BeginInit();
            this.gbParametrosMetodosNumericosSimulacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteX0Simulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteXPrima0Simulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteHSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteAHastaSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteBSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteCSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteADesdeSimulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadSimulaciones
            // 
            this.lblCantidadSimulaciones.AutoSize = true;
            this.lblCantidadSimulaciones.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadSimulaciones.Location = new System.Drawing.Point(6, 26);
            this.lblCantidadSimulaciones.Name = "lblCantidadSimulaciones";
            this.lblCantidadSimulaciones.Size = new System.Drawing.Size(133, 17);
            this.lblCantidadSimulaciones.TabIndex = 9;
            this.lblCantidadSimulaciones.Text = "Cantidad Simulaciones";
            // 
            // lblMostrarDesde
            // 
            this.lblMostrarDesde.AutoSize = true;
            this.lblMostrarDesde.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDesde.Location = new System.Drawing.Point(47, 52);
            this.lblMostrarDesde.Name = "lblMostrarDesde";
            this.lblMostrarDesde.Size = new System.Drawing.Size(92, 17);
            this.lblMostrarDesde.TabIndex = 12;
            this.lblMostrarDesde.Text = "Mostrar Desde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad Mostrar";
            // 
            // lblPedidosPorHoraProbabilidad
            // 
            this.lblPedidosPorHoraProbabilidad.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidosPorHoraProbabilidad.Location = new System.Drawing.Point(32, 104);
            this.lblPedidosPorHoraProbabilidad.Name = "lblPedidosPorHoraProbabilidad";
            this.lblPedidosPorHoraProbabilidad.Size = new System.Drawing.Size(104, 39);
            this.lblPedidosPorHoraProbabilidad.TabIndex = 16;
            this.lblPedidosPorHoraProbabilidad.Text = "Pedidos por Hora Probabilidad";
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.inputCantidadMostrar);
            this.gbParametros.Controls.Add(this.inputMostrarDesde);
            this.gbParametros.Controls.Add(this.inputPedidosPorHoraProbabilidad);
            this.gbParametros.Controls.Add(this.lblPedidosPorHoraProbabilidad);
            this.gbParametros.Controls.Add(this.inputCantidadSimulaciones);
            this.gbParametros.Controls.Add(this.lblCantidadSimulaciones);
            this.gbParametros.Controls.Add(this.label6);
            this.gbParametros.Controls.Add(this.lblMostrarDesde);
            this.gbParametros.Location = new System.Drawing.Point(12, 12);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(224, 160);
            this.gbParametros.TabIndex = 18;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros";
            // 
            // inputCantidadMostrar
            // 
            this.inputCantidadMostrar.Location = new System.Drawing.Point(145, 78);
            this.inputCantidadMostrar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputCantidadMostrar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputCantidadMostrar.Name = "inputCantidadMostrar";
            this.inputCantidadMostrar.Size = new System.Drawing.Size(66, 20);
            this.inputCantidadMostrar.TabIndex = 20;
            this.inputCantidadMostrar.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // inputMostrarDesde
            // 
            this.inputMostrarDesde.Location = new System.Drawing.Point(145, 52);
            this.inputMostrarDesde.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputMostrarDesde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputMostrarDesde.Name = "inputMostrarDesde";
            this.inputMostrarDesde.Size = new System.Drawing.Size(66, 20);
            this.inputMostrarDesde.TabIndex = 19;
            this.inputMostrarDesde.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // inputPedidosPorHoraProbabilidad
            // 
            this.inputPedidosPorHoraProbabilidad.Location = new System.Drawing.Point(145, 104);
            this.inputPedidosPorHoraProbabilidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputPedidosPorHoraProbabilidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputPedidosPorHoraProbabilidad.Name = "inputPedidosPorHoraProbabilidad";
            this.inputPedidosPorHoraProbabilidad.Size = new System.Drawing.Size(66, 20);
            this.inputPedidosPorHoraProbabilidad.TabIndex = 18;
            this.inputPedidosPorHoraProbabilidad.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // inputCantidadSimulaciones
            // 
            this.inputCantidadSimulaciones.Location = new System.Drawing.Point(145, 26);
            this.inputCantidadSimulaciones.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputCantidadSimulaciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputCantidadSimulaciones.Name = "inputCantidadSimulaciones";
            this.inputCantidadSimulaciones.Size = new System.Drawing.Size(66, 20);
            this.inputCantidadSimulaciones.TabIndex = 17;
            this.inputCantidadSimulaciones.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.Location = new System.Drawing.Point(62, 426);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnIniciar.Size = new System.Drawing.Size(103, 44);
            this.btnIniciar.TabIndex = 19;
            this.btnIniciar.Text = "Simular!!!";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // dataGridViewSimulaciones
            // 
            this.dataGridViewSimulaciones.AllowUserToAddRows = false;
            this.dataGridViewSimulaciones.AllowUserToDeleteRows = false;
            this.dataGridViewSimulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSimulaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Simulacion,
            this.Reloj,
            this.Evento,
            this.NumeroPedido,
            this.EnsamblesFinalizados,
            this.Hora,
            this.EnsamblesPorHora,
            this.PromedioEnsamblesPorHora,
            this.ProbabiliadadPedidosPorHora,
            this.TiempoPromedioEnsamblesFinalizados,
            this.PromedioPedidosSistema,
            this.ProporcionFinalizadosSolicitados,
            this.TiempoPedido,
            this.LlegadaPedido,
            this.Cola1,
            this.Cola1Maxima,
            this.Cola1PromedioPermanencia,
            this.Cola1PromedioPedidos,
            this.EstadoServidor1,
            this.PedidoEnServidor1,
            this.TiempoServidor1,
            this.FinalizacionServidor1,
            this.Servidor1PorcentajeOcupacion,
            this.Servidor1PorcentajeBloqueo,
            this.Cola2,
            this.Cola2Maxima,
            this.Cola2PromedioPermanencia,
            this.Cola2PromedioPedidos,
            this.EstadoServidor2,
            this.PedidoEnServidor2,
            this.TiempoServidor2,
            this.FinalizacionServidor2,
            this.Servidor2PorcentajeOcupacion,
            this.Servidor2PorcentajeBloqueo,
            this.Cola3,
            this.Cola3Maxima,
            this.Cola3PromedioPermanencia,
            this.Cola3PromedioPedidos,
            this.EstadoServidor3,
            this.PedidoEnServidor3,
            this.TiempoServidor3,
            this.FinalizacionServidor3,
            this.Servidor3PorcentajeOcupacion,
            this.Servidor3PorcentajeBloqueo,
            this.Cola4,
            this.Cola4Maxima,
            this.Cola4PromedioPermanencia,
            this.Cola4PromedioPedidos,
            this.EstadoServidor4,
            this.PedidoEnServidor4,
            this.TiempoServidor4,
            this.FinalizacionServidor4,
            this.Servidor4PorcentajeOcupacion,
            this.Servidor4PorcentajeBloqueo,
            this.Cola5a,
            this.Cola5aMaxima,
            this.Cola5aPromedioPermanencia,
            this.Cola5aPromedioPedidos,
            this.Cola5b,
            this.Cola5bMaxima,
            this.Cola5bPromedioPermanencia,
            this.Cola5bPromedioPedidos,
            this.EstadoServidor5,
            this.PedidoEnServidor5,
            this.TiempoServidor5a,
            this.FinalizacionServidor5,
            this.Servidor5PorcentajeOcupacion,
            this.Servidor5PorcentajeBloqueo,
            this.Servidor5ProporcionBloqueoRespectoOcupacion,
            this.ColaFinalizados3,
            this.ColaFinalizados3Maximo,
            this.ColaFinalizados3PromedioPermanencia,
            this.ColaFinalizados3PromedioPedidos,
            this.ColaFinalizados5,
            this.ColaFinalizados5Maximo,
            this.ColaFinalizados5PromedioPermanencia,
            this.ColaFinalizados5PromedioPedidos,
            this.EstadoServidorFinalizacion,
            this.PedidoEnServidorFinalizacion,
            this.TiempoServidorFinalizacion,
            this.FinalizacionServidorFinalizacion,
            this.ServidorFinalizacionPorcentajeOcupacion,
            this.ServidorFinalizacionPorcentajeBloqueo,
            this.ColaFinalizadosFinalizacionPromedioPedidos,
            this.ServidorCuelloBotella});
            this.dataGridViewSimulaciones.Location = new System.Drawing.Point(242, 12);
            this.dataGridViewSimulaciones.Name = "dataGridViewSimulaciones";
            this.dataGridViewSimulaciones.ReadOnly = true;
            this.dataGridViewSimulaciones.Size = new System.Drawing.Size(1025, 590);
            this.dataGridViewSimulaciones.TabIndex = 20;
            // 
            // gbParametrosMetodosNumericosSimulacion
            // 
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.lblMetodoNumerico);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.inputMetodoNumerico);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.lblCoeficienteX0Simulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.inputCoeficienteX0Simulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.lblCoeficienteXPrima0Simulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.inputCoeficienteXPrima0Simulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.lblCoeficienteHSimulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.inputCoeficienteHSimulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.lblCoeficienteCSimulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.inputCoeficienteAHastaSimulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.lblCoeficienteAHastaSimulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.inputCoeficienteBSimulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.inputCoeficienteCSimulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.inputCoeficienteADesdeSimulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.lblCoeficienteADesdeSimulacion);
            this.gbParametrosMetodosNumericosSimulacion.Controls.Add(this.lblCoeficienteBSimulacion);
            this.gbParametrosMetodosNumericosSimulacion.Location = new System.Drawing.Point(12, 178);
            this.gbParametrosMetodosNumericosSimulacion.Name = "gbParametrosMetodosNumericosSimulacion";
            this.gbParametrosMetodosNumericosSimulacion.Size = new System.Drawing.Size(224, 242);
            this.gbParametrosMetodosNumericosSimulacion.TabIndex = 21;
            this.gbParametrosMetodosNumericosSimulacion.TabStop = false;
            this.gbParametrosMetodosNumericosSimulacion.Text = "Parámetros Métodos Numéricos";
            // 
            // lblCoeficienteX0Simulacion
            // 
            this.lblCoeficienteX0Simulacion.AutoSize = true;
            this.lblCoeficienteX0Simulacion.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoeficienteX0Simulacion.Location = new System.Drawing.Point(104, 156);
            this.lblCoeficienteX0Simulacion.Name = "lblCoeficienteX0Simulacion";
            this.lblCoeficienteX0Simulacion.Size = new System.Drawing.Size(29, 17);
            this.lblCoeficienteX0Simulacion.TabIndex = 29;
            this.lblCoeficienteX0Simulacion.Text = "x(0)";
            // 
            // inputCoeficienteX0Simulacion
            // 
            this.inputCoeficienteX0Simulacion.DecimalPlaces = 2;
            this.inputCoeficienteX0Simulacion.Location = new System.Drawing.Point(145, 156);
            this.inputCoeficienteX0Simulacion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputCoeficienteX0Simulacion.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.inputCoeficienteX0Simulacion.Name = "inputCoeficienteX0Simulacion";
            this.inputCoeficienteX0Simulacion.Size = new System.Drawing.Size(66, 20);
            this.inputCoeficienteX0Simulacion.TabIndex = 28;
            // 
            // lblCoeficienteXPrima0Simulacion
            // 
            this.lblCoeficienteXPrima0Simulacion.AutoSize = true;
            this.lblCoeficienteXPrima0Simulacion.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoeficienteXPrima0Simulacion.Location = new System.Drawing.Point(101, 185);
            this.lblCoeficienteXPrima0Simulacion.Name = "lblCoeficienteXPrima0Simulacion";
            this.lblCoeficienteXPrima0Simulacion.Size = new System.Drawing.Size(32, 17);
            this.lblCoeficienteXPrima0Simulacion.TabIndex = 27;
            this.lblCoeficienteXPrima0Simulacion.Text = "x\'(0)";
            // 
            // inputCoeficienteXPrima0Simulacion
            // 
            this.inputCoeficienteXPrima0Simulacion.DecimalPlaces = 2;
            this.inputCoeficienteXPrima0Simulacion.Location = new System.Drawing.Point(145, 182);
            this.inputCoeficienteXPrima0Simulacion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputCoeficienteXPrima0Simulacion.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.inputCoeficienteXPrima0Simulacion.Name = "inputCoeficienteXPrima0Simulacion";
            this.inputCoeficienteXPrima0Simulacion.Size = new System.Drawing.Size(66, 20);
            this.inputCoeficienteXPrima0Simulacion.TabIndex = 26;
            // 
            // lblCoeficienteHSimulacion
            // 
            this.lblCoeficienteHSimulacion.AutoSize = true;
            this.lblCoeficienteHSimulacion.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoeficienteHSimulacion.Location = new System.Drawing.Point(118, 130);
            this.lblCoeficienteHSimulacion.Name = "lblCoeficienteHSimulacion";
            this.lblCoeficienteHSimulacion.Size = new System.Drawing.Size(15, 17);
            this.lblCoeficienteHSimulacion.TabIndex = 25;
            this.lblCoeficienteHSimulacion.Text = "h";
            // 
            // inputCoeficienteHSimulacion
            // 
            this.inputCoeficienteHSimulacion.DecimalPlaces = 2;
            this.inputCoeficienteHSimulacion.Location = new System.Drawing.Point(145, 130);
            this.inputCoeficienteHSimulacion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputCoeficienteHSimulacion.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.inputCoeficienteHSimulacion.Name = "inputCoeficienteHSimulacion";
            this.inputCoeficienteHSimulacion.Size = new System.Drawing.Size(66, 20);
            this.inputCoeficienteHSimulacion.TabIndex = 24;
            this.inputCoeficienteHSimulacion.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // lblCoeficienteCSimulacion
            // 
            this.lblCoeficienteCSimulacion.AutoSize = true;
            this.lblCoeficienteCSimulacion.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoeficienteCSimulacion.Location = new System.Drawing.Point(47, 104);
            this.lblCoeficienteCSimulacion.Name = "lblCoeficienteCSimulacion";
            this.lblCoeficienteCSimulacion.Size = new System.Drawing.Size(86, 17);
            this.lblCoeficienteCSimulacion.TabIndex = 23;
            this.lblCoeficienteCSimulacion.Text = "Coeficiente \'c\'";
            // 
            // inputCoeficienteAHastaSimulacion
            // 
            this.inputCoeficienteAHastaSimulacion.DecimalPlaces = 2;
            this.inputCoeficienteAHastaSimulacion.Location = new System.Drawing.Point(145, 52);
            this.inputCoeficienteAHastaSimulacion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputCoeficienteAHastaSimulacion.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.inputCoeficienteAHastaSimulacion.Name = "inputCoeficienteAHastaSimulacion";
            this.inputCoeficienteAHastaSimulacion.Size = new System.Drawing.Size(66, 20);
            this.inputCoeficienteAHastaSimulacion.TabIndex = 22;
            this.inputCoeficienteAHastaSimulacion.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblCoeficienteAHastaSimulacion
            // 
            this.lblCoeficienteAHastaSimulacion.AutoSize = true;
            this.lblCoeficienteAHastaSimulacion.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoeficienteAHastaSimulacion.Location = new System.Drawing.Point(16, 52);
            this.lblCoeficienteAHastaSimulacion.Name = "lblCoeficienteAHastaSimulacion";
            this.lblCoeficienteAHastaSimulacion.Size = new System.Drawing.Size(123, 17);
            this.lblCoeficienteAHastaSimulacion.TabIndex = 21;
            this.lblCoeficienteAHastaSimulacion.Text = "Coeficiente \'a\' Hasta";
            // 
            // inputCoeficienteBSimulacion
            // 
            this.inputCoeficienteBSimulacion.DecimalPlaces = 2;
            this.inputCoeficienteBSimulacion.Location = new System.Drawing.Point(145, 78);
            this.inputCoeficienteBSimulacion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputCoeficienteBSimulacion.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.inputCoeficienteBSimulacion.Name = "inputCoeficienteBSimulacion";
            this.inputCoeficienteBSimulacion.Size = new System.Drawing.Size(66, 20);
            this.inputCoeficienteBSimulacion.TabIndex = 20;
            this.inputCoeficienteBSimulacion.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // inputCoeficienteCSimulacion
            // 
            this.inputCoeficienteCSimulacion.DecimalPlaces = 2;
            this.inputCoeficienteCSimulacion.Location = new System.Drawing.Point(145, 104);
            this.inputCoeficienteCSimulacion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputCoeficienteCSimulacion.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.inputCoeficienteCSimulacion.Name = "inputCoeficienteCSimulacion";
            this.inputCoeficienteCSimulacion.Size = new System.Drawing.Size(66, 20);
            this.inputCoeficienteCSimulacion.TabIndex = 18;
            this.inputCoeficienteCSimulacion.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // inputCoeficienteADesdeSimulacion
            // 
            this.inputCoeficienteADesdeSimulacion.DecimalPlaces = 2;
            this.inputCoeficienteADesdeSimulacion.Location = new System.Drawing.Point(145, 26);
            this.inputCoeficienteADesdeSimulacion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputCoeficienteADesdeSimulacion.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.inputCoeficienteADesdeSimulacion.Name = "inputCoeficienteADesdeSimulacion";
            this.inputCoeficienteADesdeSimulacion.Size = new System.Drawing.Size(66, 20);
            this.inputCoeficienteADesdeSimulacion.TabIndex = 17;
            this.inputCoeficienteADesdeSimulacion.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // lblCoeficienteADesdeSimulacion
            // 
            this.lblCoeficienteADesdeSimulacion.AutoSize = true;
            this.lblCoeficienteADesdeSimulacion.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoeficienteADesdeSimulacion.Location = new System.Drawing.Point(14, 29);
            this.lblCoeficienteADesdeSimulacion.Name = "lblCoeficienteADesdeSimulacion";
            this.lblCoeficienteADesdeSimulacion.Size = new System.Drawing.Size(125, 17);
            this.lblCoeficienteADesdeSimulacion.TabIndex = 9;
            this.lblCoeficienteADesdeSimulacion.Text = "Coeficiente \'a\' Desde";
            // 
            // lblCoeficienteBSimulacion
            // 
            this.lblCoeficienteBSimulacion.AutoSize = true;
            this.lblCoeficienteBSimulacion.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoeficienteBSimulacion.Location = new System.Drawing.Point(47, 78);
            this.lblCoeficienteBSimulacion.Name = "lblCoeficienteBSimulacion";
            this.lblCoeficienteBSimulacion.Size = new System.Drawing.Size(87, 17);
            this.lblCoeficienteBSimulacion.TabIndex = 13;
            this.lblCoeficienteBSimulacion.Text = "Coeficiente \'b\'";
            // 
            // inputMetodoNumerico
            // 
            this.inputMetodoNumerico.DisplayMember = "EULER";
            this.inputMetodoNumerico.FormattingEnabled = true;
            this.inputMetodoNumerico.Items.AddRange(new object[] {
            "EULER",
            "RK"});
            this.inputMetodoNumerico.Location = new System.Drawing.Point(121, 208);
            this.inputMetodoNumerico.Name = "inputMetodoNumerico";
            this.inputMetodoNumerico.Size = new System.Drawing.Size(90, 21);
            this.inputMetodoNumerico.TabIndex = 30;
            this.inputMetodoNumerico.ValueMember = "EULER";
            // 
            // lblMetodoNumerico
            // 
            this.lblMetodoNumerico.AutoSize = true;
            this.lblMetodoNumerico.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoNumerico.Location = new System.Drawing.Point(6, 209);
            this.lblMetodoNumerico.Name = "lblMetodoNumerico";
            this.lblMetodoNumerico.Size = new System.Drawing.Size(111, 17);
            this.lblMetodoNumerico.TabIndex = 31;
            this.lblMetodoNumerico.Text = "Método Numérico";
            // 
            // Simulacion
            // 
            this.Simulacion.Frozen = true;
            this.Simulacion.HeaderText = "Simulacion";
            this.Simulacion.Name = "Simulacion";
            this.Simulacion.ReadOnly = true;
            // 
            // Reloj
            // 
            this.Reloj.Frozen = true;
            this.Reloj.HeaderText = "Reloj";
            this.Reloj.Name = "Reloj";
            this.Reloj.ReadOnly = true;
            // 
            // Evento
            // 
            this.Evento.Frozen = true;
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            // 
            // NumeroPedido
            // 
            this.NumeroPedido.Frozen = true;
            this.NumeroPedido.HeaderText = "Numero Pedido";
            this.NumeroPedido.Name = "NumeroPedido";
            this.NumeroPedido.ReadOnly = true;
            // 
            // EnsamblesFinalizados
            // 
            this.EnsamblesFinalizados.HeaderText = "Ensambles Finalizados";
            this.EnsamblesFinalizados.Name = "EnsamblesFinalizados";
            this.EnsamblesFinalizados.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // EnsamblesPorHora
            // 
            this.EnsamblesPorHora.HeaderText = "Ensambles Por Hora";
            this.EnsamblesPorHora.Name = "EnsamblesPorHora";
            this.EnsamblesPorHora.ReadOnly = true;
            // 
            // PromedioEnsamblesPorHora
            // 
            this.PromedioEnsamblesPorHora.HeaderText = "Promedio Ensambles Por Hora";
            this.PromedioEnsamblesPorHora.Name = "PromedioEnsamblesPorHora";
            this.PromedioEnsamblesPorHora.ReadOnly = true;
            // 
            // ProbabiliadadPedidosPorHora
            // 
            this.ProbabiliadadPedidosPorHora.HeaderText = "Probabiliadad Pedidos Por Hora";
            this.ProbabiliadadPedidosPorHora.Name = "ProbabiliadadPedidosPorHora";
            this.ProbabiliadadPedidosPorHora.ReadOnly = true;
            // 
            // TiempoPromedioEnsamblesFinalizados
            // 
            this.TiempoPromedioEnsamblesFinalizados.HeaderText = "Tiempo Promedio";
            this.TiempoPromedioEnsamblesFinalizados.Name = "TiempoPromedioEnsamblesFinalizados";
            this.TiempoPromedioEnsamblesFinalizados.ReadOnly = true;
            // 
            // PromedioPedidosSistema
            // 
            this.PromedioPedidosSistema.HeaderText = "Promedio Pedidos Sistema";
            this.PromedioPedidosSistema.Name = "PromedioPedidosSistema";
            this.PromedioPedidosSistema.ReadOnly = true;
            // 
            // ProporcionFinalizadosSolicitados
            // 
            this.ProporcionFinalizadosSolicitados.HeaderText = "Proporcion Finalizados Solicitados";
            this.ProporcionFinalizadosSolicitados.Name = "ProporcionFinalizadosSolicitados";
            this.ProporcionFinalizadosSolicitados.ReadOnly = true;
            // 
            // TiempoPedido
            // 
            this.TiempoPedido.HeaderText = "Tiempo Pedido";
            this.TiempoPedido.Name = "TiempoPedido";
            this.TiempoPedido.ReadOnly = true;
            // 
            // LlegadaPedido
            // 
            this.LlegadaPedido.HeaderText = "Llegada Pedido";
            this.LlegadaPedido.Name = "LlegadaPedido";
            this.LlegadaPedido.ReadOnly = true;
            // 
            // Cola1
            // 
            this.Cola1.HeaderText = "Cola 1";
            this.Cola1.Name = "Cola1";
            this.Cola1.ReadOnly = true;
            // 
            // Cola1Maxima
            // 
            this.Cola1Maxima.HeaderText = "Cola 1 Maximo";
            this.Cola1Maxima.Name = "Cola1Maxima";
            this.Cola1Maxima.ReadOnly = true;
            // 
            // Cola1PromedioPermanencia
            // 
            this.Cola1PromedioPermanencia.HeaderText = "Cola 1 Promedio Permanencia";
            this.Cola1PromedioPermanencia.Name = "Cola1PromedioPermanencia";
            this.Cola1PromedioPermanencia.ReadOnly = true;
            // 
            // Cola1PromedioPedidos
            // 
            this.Cola1PromedioPedidos.HeaderText = "Cola 1 Promedio Pedidos";
            this.Cola1PromedioPedidos.Name = "Cola1PromedioPedidos";
            this.Cola1PromedioPedidos.ReadOnly = true;
            // 
            // EstadoServidor1
            // 
            this.EstadoServidor1.HeaderText = "Estado Servidor 1";
            this.EstadoServidor1.Name = "EstadoServidor1";
            this.EstadoServidor1.ReadOnly = true;
            // 
            // PedidoEnServidor1
            // 
            this.PedidoEnServidor1.HeaderText = "Pedido en Servidor 1";
            this.PedidoEnServidor1.Name = "PedidoEnServidor1";
            this.PedidoEnServidor1.ReadOnly = true;
            // 
            // TiempoServidor1
            // 
            this.TiempoServidor1.HeaderText = "Tiempo Servidor 1";
            this.TiempoServidor1.Name = "TiempoServidor1";
            this.TiempoServidor1.ReadOnly = true;
            // 
            // FinalizacionServidor1
            // 
            this.FinalizacionServidor1.HeaderText = "Finalizacion Servidor 1";
            this.FinalizacionServidor1.Name = "FinalizacionServidor1";
            this.FinalizacionServidor1.ReadOnly = true;
            // 
            // Servidor1PorcentajeOcupacion
            // 
            this.Servidor1PorcentajeOcupacion.HeaderText = "Servidor 1 Porcentaje Ocupacion";
            this.Servidor1PorcentajeOcupacion.Name = "Servidor1PorcentajeOcupacion";
            this.Servidor1PorcentajeOcupacion.ReadOnly = true;
            // 
            // Servidor1PorcentajeBloqueo
            // 
            this.Servidor1PorcentajeBloqueo.HeaderText = "Servidor 1 Porcentaje Bloqueo";
            this.Servidor1PorcentajeBloqueo.Name = "Servidor1PorcentajeBloqueo";
            this.Servidor1PorcentajeBloqueo.ReadOnly = true;
            // 
            // Cola2
            // 
            this.Cola2.HeaderText = "Cola 2";
            this.Cola2.Name = "Cola2";
            this.Cola2.ReadOnly = true;
            // 
            // Cola2Maxima
            // 
            this.Cola2Maxima.HeaderText = "Cola 2 Maximo";
            this.Cola2Maxima.Name = "Cola2Maxima";
            this.Cola2Maxima.ReadOnly = true;
            // 
            // Cola2PromedioPermanencia
            // 
            this.Cola2PromedioPermanencia.HeaderText = "Cola 2 Promedio Permanencia";
            this.Cola2PromedioPermanencia.Name = "Cola2PromedioPermanencia";
            this.Cola2PromedioPermanencia.ReadOnly = true;
            // 
            // Cola2PromedioPedidos
            // 
            this.Cola2PromedioPedidos.HeaderText = "Cola 2 Promedio Pedidos";
            this.Cola2PromedioPedidos.Name = "Cola2PromedioPedidos";
            this.Cola2PromedioPedidos.ReadOnly = true;
            // 
            // EstadoServidor2
            // 
            this.EstadoServidor2.HeaderText = "Estado Servidor 2";
            this.EstadoServidor2.Name = "EstadoServidor2";
            this.EstadoServidor2.ReadOnly = true;
            // 
            // PedidoEnServidor2
            // 
            this.PedidoEnServidor2.HeaderText = "Pedido en Servidor 2";
            this.PedidoEnServidor2.Name = "PedidoEnServidor2";
            this.PedidoEnServidor2.ReadOnly = true;
            // 
            // TiempoServidor2
            // 
            this.TiempoServidor2.HeaderText = "Tiempo Servidor 2";
            this.TiempoServidor2.Name = "TiempoServidor2";
            this.TiempoServidor2.ReadOnly = true;
            // 
            // FinalizacionServidor2
            // 
            this.FinalizacionServidor2.HeaderText = "Finalizacion Servidor 2";
            this.FinalizacionServidor2.Name = "FinalizacionServidor2";
            this.FinalizacionServidor2.ReadOnly = true;
            // 
            // Servidor2PorcentajeOcupacion
            // 
            this.Servidor2PorcentajeOcupacion.HeaderText = "Servidor 2 Porcentaje Ocupacion";
            this.Servidor2PorcentajeOcupacion.Name = "Servidor2PorcentajeOcupacion";
            this.Servidor2PorcentajeOcupacion.ReadOnly = true;
            // 
            // Servidor2PorcentajeBloqueo
            // 
            this.Servidor2PorcentajeBloqueo.HeaderText = "Servidor 2 Porcentaje Bloqueo";
            this.Servidor2PorcentajeBloqueo.Name = "Servidor2PorcentajeBloqueo";
            this.Servidor2PorcentajeBloqueo.ReadOnly = true;
            // 
            // Cola3
            // 
            this.Cola3.HeaderText = "Cola 3";
            this.Cola3.Name = "Cola3";
            this.Cola3.ReadOnly = true;
            // 
            // Cola3Maxima
            // 
            this.Cola3Maxima.HeaderText = "Cola 3 Maximo";
            this.Cola3Maxima.Name = "Cola3Maxima";
            this.Cola3Maxima.ReadOnly = true;
            // 
            // Cola3PromedioPermanencia
            // 
            this.Cola3PromedioPermanencia.HeaderText = "Cola 3 Promedio Permanencia";
            this.Cola3PromedioPermanencia.Name = "Cola3PromedioPermanencia";
            this.Cola3PromedioPermanencia.ReadOnly = true;
            // 
            // Cola3PromedioPedidos
            // 
            this.Cola3PromedioPedidos.HeaderText = "Cola 3 Promedio Pedidos";
            this.Cola3PromedioPedidos.Name = "Cola3PromedioPedidos";
            this.Cola3PromedioPedidos.ReadOnly = true;
            // 
            // EstadoServidor3
            // 
            this.EstadoServidor3.HeaderText = "Estado Servidor 3";
            this.EstadoServidor3.Name = "EstadoServidor3";
            this.EstadoServidor3.ReadOnly = true;
            // 
            // PedidoEnServidor3
            // 
            this.PedidoEnServidor3.HeaderText = "Pedido en Servidor 3";
            this.PedidoEnServidor3.Name = "PedidoEnServidor3";
            this.PedidoEnServidor3.ReadOnly = true;
            // 
            // TiempoServidor3
            // 
            this.TiempoServidor3.HeaderText = "Tiempo Servidor 3";
            this.TiempoServidor3.Name = "TiempoServidor3";
            this.TiempoServidor3.ReadOnly = true;
            // 
            // FinalizacionServidor3
            // 
            this.FinalizacionServidor3.HeaderText = "Finalizacion Servidor 3";
            this.FinalizacionServidor3.Name = "FinalizacionServidor3";
            this.FinalizacionServidor3.ReadOnly = true;
            // 
            // Servidor3PorcentajeOcupacion
            // 
            this.Servidor3PorcentajeOcupacion.HeaderText = "Servidor 3 Porcentaje Ocupacion";
            this.Servidor3PorcentajeOcupacion.Name = "Servidor3PorcentajeOcupacion";
            this.Servidor3PorcentajeOcupacion.ReadOnly = true;
            // 
            // Servidor3PorcentajeBloqueo
            // 
            this.Servidor3PorcentajeBloqueo.HeaderText = "Servidor 3 Porcentaje Bloqueo";
            this.Servidor3PorcentajeBloqueo.Name = "Servidor3PorcentajeBloqueo";
            this.Servidor3PorcentajeBloqueo.ReadOnly = true;
            // 
            // Cola4
            // 
            this.Cola4.HeaderText = "Cola 4";
            this.Cola4.Name = "Cola4";
            this.Cola4.ReadOnly = true;
            // 
            // Cola4Maxima
            // 
            this.Cola4Maxima.HeaderText = "Cola 4 Maximo";
            this.Cola4Maxima.Name = "Cola4Maxima";
            this.Cola4Maxima.ReadOnly = true;
            // 
            // Cola4PromedioPermanencia
            // 
            this.Cola4PromedioPermanencia.HeaderText = "Cola 4 Promedio Permanencia";
            this.Cola4PromedioPermanencia.Name = "Cola4PromedioPermanencia";
            this.Cola4PromedioPermanencia.ReadOnly = true;
            // 
            // Cola4PromedioPedidos
            // 
            this.Cola4PromedioPedidos.HeaderText = "Cola 4 Promedio Pedidos";
            this.Cola4PromedioPedidos.Name = "Cola4PromedioPedidos";
            this.Cola4PromedioPedidos.ReadOnly = true;
            // 
            // EstadoServidor4
            // 
            this.EstadoServidor4.HeaderText = "Estado Servidor 4";
            this.EstadoServidor4.Name = "EstadoServidor4";
            this.EstadoServidor4.ReadOnly = true;
            // 
            // PedidoEnServidor4
            // 
            this.PedidoEnServidor4.HeaderText = "Pedido en Servidor 4";
            this.PedidoEnServidor4.Name = "PedidoEnServidor4";
            this.PedidoEnServidor4.ReadOnly = true;
            // 
            // TiempoServidor4
            // 
            this.TiempoServidor4.HeaderText = "Tiempo Servidor 4";
            this.TiempoServidor4.Name = "TiempoServidor4";
            this.TiempoServidor4.ReadOnly = true;
            // 
            // FinalizacionServidor4
            // 
            this.FinalizacionServidor4.HeaderText = "Finalizacion Servidor 4";
            this.FinalizacionServidor4.Name = "FinalizacionServidor4";
            this.FinalizacionServidor4.ReadOnly = true;
            // 
            // Servidor4PorcentajeOcupacion
            // 
            this.Servidor4PorcentajeOcupacion.HeaderText = "Servidor 4 Porcentaje Ocupacion";
            this.Servidor4PorcentajeOcupacion.Name = "Servidor4PorcentajeOcupacion";
            this.Servidor4PorcentajeOcupacion.ReadOnly = true;
            // 
            // Servidor4PorcentajeBloqueo
            // 
            this.Servidor4PorcentajeBloqueo.HeaderText = "Servidor 4 Porcentaje Bloqueo";
            this.Servidor4PorcentajeBloqueo.Name = "Servidor4PorcentajeBloqueo";
            this.Servidor4PorcentajeBloqueo.ReadOnly = true;
            // 
            // Cola5a
            // 
            this.Cola5a.HeaderText = "Cola 5a";
            this.Cola5a.Name = "Cola5a";
            this.Cola5a.ReadOnly = true;
            // 
            // Cola5aMaxima
            // 
            this.Cola5aMaxima.HeaderText = "Cola 5a Maximo";
            this.Cola5aMaxima.Name = "Cola5aMaxima";
            this.Cola5aMaxima.ReadOnly = true;
            // 
            // Cola5aPromedioPermanencia
            // 
            this.Cola5aPromedioPermanencia.HeaderText = "Cola 5a Promedio Permanencia";
            this.Cola5aPromedioPermanencia.Name = "Cola5aPromedioPermanencia";
            this.Cola5aPromedioPermanencia.ReadOnly = true;
            // 
            // Cola5aPromedioPedidos
            // 
            this.Cola5aPromedioPedidos.HeaderText = "Cola 5a Promedio Pedidos";
            this.Cola5aPromedioPedidos.Name = "Cola5aPromedioPedidos";
            this.Cola5aPromedioPedidos.ReadOnly = true;
            // 
            // Cola5b
            // 
            this.Cola5b.HeaderText = "Cola 5b";
            this.Cola5b.Name = "Cola5b";
            this.Cola5b.ReadOnly = true;
            // 
            // Cola5bMaxima
            // 
            this.Cola5bMaxima.HeaderText = "Cola 5b Maximo";
            this.Cola5bMaxima.Name = "Cola5bMaxima";
            this.Cola5bMaxima.ReadOnly = true;
            // 
            // Cola5bPromedioPermanencia
            // 
            this.Cola5bPromedioPermanencia.HeaderText = "Cola 5b Promedio Permanencia";
            this.Cola5bPromedioPermanencia.Name = "Cola5bPromedioPermanencia";
            this.Cola5bPromedioPermanencia.ReadOnly = true;
            // 
            // Cola5bPromedioPedidos
            // 
            this.Cola5bPromedioPedidos.HeaderText = "Cola 5b Promedio Pedidos";
            this.Cola5bPromedioPedidos.Name = "Cola5bPromedioPedidos";
            this.Cola5bPromedioPedidos.ReadOnly = true;
            // 
            // EstadoServidor5
            // 
            this.EstadoServidor5.HeaderText = "Estado Servidor 5";
            this.EstadoServidor5.Name = "EstadoServidor5";
            this.EstadoServidor5.ReadOnly = true;
            // 
            // PedidoEnServidor5
            // 
            this.PedidoEnServidor5.HeaderText = "Pedido en Servidor 5";
            this.PedidoEnServidor5.Name = "PedidoEnServidor5";
            this.PedidoEnServidor5.ReadOnly = true;
            // 
            // TiempoServidor5a
            // 
            this.TiempoServidor5a.HeaderText = "Tiempo Servidor 5";
            this.TiempoServidor5a.Name = "TiempoServidor5a";
            this.TiempoServidor5a.ReadOnly = true;
            // 
            // FinalizacionServidor5
            // 
            this.FinalizacionServidor5.HeaderText = "Finalizacion Servidor 5";
            this.FinalizacionServidor5.Name = "FinalizacionServidor5";
            this.FinalizacionServidor5.ReadOnly = true;
            // 
            // Servidor5PorcentajeOcupacion
            // 
            this.Servidor5PorcentajeOcupacion.HeaderText = "Servidor 5 Porcentaje Ocupacion";
            this.Servidor5PorcentajeOcupacion.Name = "Servidor5PorcentajeOcupacion";
            this.Servidor5PorcentajeOcupacion.ReadOnly = true;
            // 
            // Servidor5PorcentajeBloqueo
            // 
            this.Servidor5PorcentajeBloqueo.HeaderText = "Servidor 5 Porcentaje Bloqueo";
            this.Servidor5PorcentajeBloqueo.Name = "Servidor5PorcentajeBloqueo";
            this.Servidor5PorcentajeBloqueo.ReadOnly = true;
            // 
            // Servidor5ProporcionBloqueoRespectoOcupacion
            // 
            this.Servidor5ProporcionBloqueoRespectoOcupacion.HeaderText = "Servidor 5 Proporcion Bloqueo/Ocupacion";
            this.Servidor5ProporcionBloqueoRespectoOcupacion.Name = "Servidor5ProporcionBloqueoRespectoOcupacion";
            this.Servidor5ProporcionBloqueoRespectoOcupacion.ReadOnly = true;
            // 
            // ColaFinalizados3
            // 
            this.ColaFinalizados3.HeaderText = "Cola Finalizados 3";
            this.ColaFinalizados3.Name = "ColaFinalizados3";
            this.ColaFinalizados3.ReadOnly = true;
            // 
            // ColaFinalizados3Maximo
            // 
            this.ColaFinalizados3Maximo.HeaderText = "Cola Finalizados 3 Maximo";
            this.ColaFinalizados3Maximo.Name = "ColaFinalizados3Maximo";
            this.ColaFinalizados3Maximo.ReadOnly = true;
            // 
            // ColaFinalizados3PromedioPermanencia
            // 
            this.ColaFinalizados3PromedioPermanencia.HeaderText = "Cola Finalizados 3 Promedio Permanencia";
            this.ColaFinalizados3PromedioPermanencia.Name = "ColaFinalizados3PromedioPermanencia";
            this.ColaFinalizados3PromedioPermanencia.ReadOnly = true;
            // 
            // ColaFinalizados3PromedioPedidos
            // 
            this.ColaFinalizados3PromedioPedidos.HeaderText = "Cola Finalizados 3 Promedio Pedidos";
            this.ColaFinalizados3PromedioPedidos.Name = "ColaFinalizados3PromedioPedidos";
            this.ColaFinalizados3PromedioPedidos.ReadOnly = true;
            // 
            // ColaFinalizados5
            // 
            this.ColaFinalizados5.HeaderText = "Cola Finalizados 5";
            this.ColaFinalizados5.Name = "ColaFinalizados5";
            this.ColaFinalizados5.ReadOnly = true;
            // 
            // ColaFinalizados5Maximo
            // 
            this.ColaFinalizados5Maximo.HeaderText = "Cola Finalizados 5 Maximo";
            this.ColaFinalizados5Maximo.Name = "ColaFinalizados5Maximo";
            this.ColaFinalizados5Maximo.ReadOnly = true;
            // 
            // ColaFinalizados5PromedioPermanencia
            // 
            this.ColaFinalizados5PromedioPermanencia.HeaderText = "Cola Finalizados 5 Promedio Permanencia";
            this.ColaFinalizados5PromedioPermanencia.Name = "ColaFinalizados5PromedioPermanencia";
            this.ColaFinalizados5PromedioPermanencia.ReadOnly = true;
            // 
            // ColaFinalizados5PromedioPedidos
            // 
            this.ColaFinalizados5PromedioPedidos.HeaderText = "Cola Finalizados 5 Promedio Pedidos";
            this.ColaFinalizados5PromedioPedidos.Name = "ColaFinalizados5PromedioPedidos";
            this.ColaFinalizados5PromedioPedidos.ReadOnly = true;
            // 
            // EstadoServidorFinalizacion
            // 
            this.EstadoServidorFinalizacion.HeaderText = "Estado Servidor Finalizacion";
            this.EstadoServidorFinalizacion.Name = "EstadoServidorFinalizacion";
            this.EstadoServidorFinalizacion.ReadOnly = true;
            // 
            // PedidoEnServidorFinalizacion
            // 
            this.PedidoEnServidorFinalizacion.HeaderText = "Pedido En Servidor Finalizacion";
            this.PedidoEnServidorFinalizacion.Name = "PedidoEnServidorFinalizacion";
            this.PedidoEnServidorFinalizacion.ReadOnly = true;
            // 
            // TiempoServidorFinalizacion
            // 
            this.TiempoServidorFinalizacion.HeaderText = "Tiempo Servidor Finalizacion";
            this.TiempoServidorFinalizacion.Name = "TiempoServidorFinalizacion";
            this.TiempoServidorFinalizacion.ReadOnly = true;
            // 
            // FinalizacionServidorFinalizacion
            // 
            this.FinalizacionServidorFinalizacion.HeaderText = "Finalizacion Servidor Finalizacion";
            this.FinalizacionServidorFinalizacion.Name = "FinalizacionServidorFinalizacion";
            this.FinalizacionServidorFinalizacion.ReadOnly = true;
            // 
            // ServidorFinalizacionPorcentajeOcupacion
            // 
            this.ServidorFinalizacionPorcentajeOcupacion.HeaderText = "Servidor Finalizacion Porcentaje Ocupacion";
            this.ServidorFinalizacionPorcentajeOcupacion.Name = "ServidorFinalizacionPorcentajeOcupacion";
            this.ServidorFinalizacionPorcentajeOcupacion.ReadOnly = true;
            // 
            // ServidorFinalizacionPorcentajeBloqueo
            // 
            this.ServidorFinalizacionPorcentajeBloqueo.HeaderText = "Servidor Finalizacion Porcentaje Bloqueo";
            this.ServidorFinalizacionPorcentajeBloqueo.Name = "ServidorFinalizacionPorcentajeBloqueo";
            this.ServidorFinalizacionPorcentajeBloqueo.ReadOnly = true;
            // 
            // ColaFinalizadosFinalizacionPromedioPedidos
            // 
            this.ColaFinalizadosFinalizacionPromedioPedidos.HeaderText = "Cola Finalizados Finalizacion Promedio Pedidos";
            this.ColaFinalizadosFinalizacionPromedioPedidos.Name = "ColaFinalizadosFinalizacionPromedioPedidos";
            this.ColaFinalizadosFinalizacionPromedioPedidos.ReadOnly = true;
            // 
            // ServidorCuelloBotella
            // 
            this.ServidorCuelloBotella.HeaderText = "Servidor Cuello de Botella";
            this.ServidorCuelloBotella.Name = "ServidorCuelloBotella";
            this.ServidorCuelloBotella.ReadOnly = true;
            // 
            // FormTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 614);
            this.Controls.Add(this.gbParametrosMetodosNumericosSimulacion);
            this.Controls.Add(this.dataGridViewSimulaciones);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.gbParametros);
            this.Name = "FormTablero";
            this.Text = "Simulacion";
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputCantidadMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMostrarDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPedidosPorHoraProbabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCantidadSimulaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulaciones)).EndInit();
            this.gbParametrosMetodosNumericosSimulacion.ResumeLayout(false);
            this.gbParametrosMetodosNumericosSimulacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteX0Simulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteXPrima0Simulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteHSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteAHastaSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteBSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteCSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCoeficienteADesdeSimulacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadSimulaciones;
        private System.Windows.Forms.Label lblMostrarDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPedidosPorHoraProbabilidad;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.NumericUpDown inputCantidadMostrar;
        private System.Windows.Forms.NumericUpDown inputMostrarDesde;
        private System.Windows.Forms.NumericUpDown inputPedidosPorHoraProbabilidad;
        private System.Windows.Forms.NumericUpDown inputCantidadSimulaciones;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.DataGridView dataGridViewSimulaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoServidor5;
        private System.Windows.Forms.GroupBox gbParametrosMetodosNumericosSimulacion;
        private System.Windows.Forms.Label lblCoeficienteX0Simulacion;
        private System.Windows.Forms.NumericUpDown inputCoeficienteX0Simulacion;
        private System.Windows.Forms.Label lblCoeficienteXPrima0Simulacion;
        private System.Windows.Forms.NumericUpDown inputCoeficienteXPrima0Simulacion;
        private System.Windows.Forms.Label lblCoeficienteHSimulacion;
        private System.Windows.Forms.NumericUpDown inputCoeficienteHSimulacion;
        private System.Windows.Forms.Label lblCoeficienteCSimulacion;
        private System.Windows.Forms.NumericUpDown inputCoeficienteAHastaSimulacion;
        private System.Windows.Forms.Label lblCoeficienteAHastaSimulacion;
        private System.Windows.Forms.NumericUpDown inputCoeficienteBSimulacion;
        private System.Windows.Forms.NumericUpDown inputCoeficienteCSimulacion;
        private System.Windows.Forms.NumericUpDown inputCoeficienteADesdeSimulacion;
        private System.Windows.Forms.Label lblCoeficienteADesdeSimulacion;
        private System.Windows.Forms.Label lblCoeficienteBSimulacion;
        private System.Windows.Forms.Label lblMetodoNumerico;
        private System.Windows.Forms.ComboBox inputMetodoNumerico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Simulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnsamblesFinalizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnsamblesPorHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioEnsamblesPorHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabiliadadPedidosPorHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoPromedioEnsamblesFinalizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioPedidosSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProporcionFinalizadosSolicitados;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlegadaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola1Maxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola1PromedioPermanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola1PromedioPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoServidor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoEnServidor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoServidor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalizacionServidor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor1PorcentajeOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor1PorcentajeBloqueo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola2Maxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola2PromedioPermanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola2PromedioPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoServidor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoEnServidor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoServidor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalizacionServidor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor2PorcentajeOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor2PorcentajeBloqueo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola3Maxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola3PromedioPermanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola3PromedioPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoServidor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoEnServidor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoServidor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalizacionServidor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor3PorcentajeOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor3PorcentajeBloqueo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola4Maxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola4PromedioPermanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola4PromedioPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoServidor4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoEnServidor4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoServidor4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalizacionServidor4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor4PorcentajeOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor4PorcentajeBloqueo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola5a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola5aMaxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola5aPromedioPermanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola5aPromedioPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola5b;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola5bMaxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola5bPromedioPermanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola5bPromedioPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoServidor5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoEnServidor5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoServidor5a;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalizacionServidor5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor5PorcentajeOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor5PorcentajeBloqueo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor5ProporcionBloqueoRespectoOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaFinalizados3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaFinalizados3Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaFinalizados3PromedioPermanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaFinalizados3PromedioPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaFinalizados5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaFinalizados5Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaFinalizados5PromedioPermanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaFinalizados5PromedioPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoServidorFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoEnServidorFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoServidorFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalizacionServidorFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServidorFinalizacionPorcentajeOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServidorFinalizacionPorcentajeBloqueo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaFinalizadosFinalizacionPromedioPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServidorCuelloBotella;
    }
}