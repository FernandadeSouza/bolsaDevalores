
namespace Aula1
{
    partial class Formquiz
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
        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnQuiz1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbCQuiz1 = new System.Windows.Forms.RadioButton();
            this.rbBQuiz1 = new System.Windows.Forms.RadioButton();
            this.rbAQuiz1 = new System.Windows.Forms.RadioButton();
            this.lbQuiz = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbCQuiz2 = new System.Windows.Forms.RadioButton();
            this.rbBQuiz2 = new System.Windows.Forms.RadioButton();
            this.rbAQuiz2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbCQuiz3 = new System.Windows.Forms.RadioButton();
            this.rbBQuiz3 = new System.Windows.Forms.RadioButton();
            this.rbAQuiz3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbCQuiz4 = new System.Windows.Forms.RadioButton();
            this.rbBQuiz4 = new System.Windows.Forms.RadioButton();
            this.rbAQuiz4 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbCQuiz5 = new System.Windows.Forms.RadioButton();
            this.rbBQuiz5 = new System.Windows.Forms.RadioButton();
            this.rbAQuiz5 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 421);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.btnQuiz1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lbQuiz);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "quiz1";
            // 
            // btnQuiz1
            // 
            this.btnQuiz1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuiz1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuiz1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz1.Location = new System.Drawing.Point(140, 260);
            this.btnQuiz1.Name = "btnQuiz1";
            this.btnQuiz1.Size = new System.Drawing.Size(211, 66);
            this.btnQuiz1.TabIndex = 8;
            this.btnQuiz1.Text = "Confirmar";
            this.btnQuiz1.UseVisualStyleBackColor = false;
            this.btnQuiz1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.rbCQuiz1);
            this.panel1.Controls.Add(this.rbBQuiz1);
            this.panel1.Controls.Add(this.rbAQuiz1);
            this.panel1.Location = new System.Drawing.Point(136, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 165);
            this.panel1.TabIndex = 7;
            // 
            // rbCQuiz1
            // 
            this.rbCQuiz1.AutoSize = true;
            this.rbCQuiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCQuiz1.Location = new System.Drawing.Point(4, 122);
            this.rbCQuiz1.Name = "rbCQuiz1";
            this.rbCQuiz1.Size = new System.Drawing.Size(525, 24);
            this.rbCQuiz1.TabIndex = 2;
            this.rbCQuiz1.TabStop = true;
            this.rbCQuiz1.Text = "Estou disposto a assumir riscos mais altos em busca de altos retornos.";
            this.rbCQuiz1.UseVisualStyleBackColor = true;
            // 
            // rbBQuiz1
            // 
            this.rbBQuiz1.AutoSize = true;
            this.rbBQuiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBQuiz1.Location = new System.Drawing.Point(4, 70);
            this.rbBQuiz1.Name = "rbBQuiz1";
            this.rbBQuiz1.Size = new System.Drawing.Size(387, 24);
            this.rbBQuiz1.TabIndex = 1;
            this.rbBQuiz1.TabStop = true;
            this.rbBQuiz1.Text = "Aceito algum risco em busca de melhores retornos.";
            this.rbBQuiz1.UseVisualStyleBackColor = true;
            // 
            // rbAQuiz1
            // 
            this.rbAQuiz1.AutoSize = true;
            this.rbAQuiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAQuiz1.Location = new System.Drawing.Point(4, 13);
            this.rbAQuiz1.Name = "rbAQuiz1";
            this.rbAQuiz1.Size = new System.Drawing.Size(316, 24);
            this.rbAQuiz1.TabIndex = 0;
            this.rbAQuiz1.TabStop = true;
            this.rbAQuiz1.Text = "Procuro evitar qualquer risco significativo.";
            this.rbAQuiz1.UseVisualStyleBackColor = true;
            // 
            // lbQuiz
            // 
            this.lbQuiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbQuiz.AutoSize = true;
            this.lbQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuiz.Location = new System.Drawing.Point(135, 40);
            this.lbQuiz.Name = "lbQuiz";
            this.lbQuiz.Size = new System.Drawing.Size(545, 25);
            this.lbQuiz.TabIndex = 6;
            this.lbQuiz.Text = "1: Qual é a sua abordagem ao risco nos investimentos?";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(944, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "quiz2";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(140, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 66);
            this.button1.TabIndex = 10;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.rbCQuiz2);
            this.panel2.Controls.Add(this.rbBQuiz2);
            this.panel2.Controls.Add(this.rbAQuiz2);
            this.panel2.Location = new System.Drawing.Point(136, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 165);
            this.panel2.TabIndex = 9;
            // 
            // rbCQuiz2
            // 
            this.rbCQuiz2.AutoSize = true;
            this.rbCQuiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbCQuiz2.Location = new System.Drawing.Point(4, 122);
            this.rbCQuiz2.Name = "rbCQuiz2";
            this.rbCQuiz2.Size = new System.Drawing.Size(540, 24);
            this.rbCQuiz2.TabIndex = 2;
            this.rbCQuiz2.TabStop = true;
            this.rbCQuiz2.Text = "Maximize o crescimento do patrimônio, mesmo que haja maior risco.";
            this.rbCQuiz2.UseVisualStyleBackColor = true;
            // 
            // rbBQuiz2
            // 
            this.rbBQuiz2.AutoSize = true;
            this.rbBQuiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBQuiz2.Location = new System.Drawing.Point(4, 70);
            this.rbBQuiz2.Name = "rbBQuiz2";
            this.rbBQuiz2.Size = new System.Drawing.Size(421, 24);
            this.rbBQuiz2.TabIndex = 1;
            this.rbBQuiz2.TabStop = true;
            this.rbBQuiz2.Text = "Obter retornos moderados e crescimento do patrimônio.";
            this.rbBQuiz2.UseVisualStyleBackColor = true;
            // 
            // rbAQuiz2
            // 
            this.rbAQuiz2.AutoSize = true;
            this.rbAQuiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAQuiz2.Location = new System.Drawing.Point(4, 13);
            this.rbAQuiz2.Name = "rbAQuiz2";
            this.rbAQuiz2.Size = new System.Drawing.Size(392, 24);
            this.rbAQuiz2.TabIndex = 0;
            this.rbAQuiz2.TabStop = true;
            this.rbAQuiz2.Text = "Preservação do capital e proteção contra a inflação.";
            this.rbAQuiz2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "2:Qual é o seu objetivo de investimento de longo prazo?";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(944, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "quiz3";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(140, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 66);
            this.button2.TabIndex = 10;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.rbCQuiz3);
            this.panel3.Controls.Add(this.rbBQuiz3);
            this.panel3.Controls.Add(this.rbAQuiz3);
            this.panel3.Location = new System.Drawing.Point(136, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 165);
            this.panel3.TabIndex = 9;
            // 
            // rbCQuiz3
            // 
            this.rbCQuiz3.AutoSize = true;
            this.rbCQuiz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCQuiz3.Location = new System.Drawing.Point(4, 122);
            this.rbCQuiz3.Name = "rbCQuiz3";
            this.rbCQuiz3.Size = new System.Drawing.Size(502, 24);
            this.rbCQuiz3.TabIndex = 2;
            this.rbCQuiz3.TabStop = true;
            this.rbCQuiz3.Text = "Vejo oportunidades para comprar mais ações a preços mais baixos.";
            this.rbCQuiz3.UseVisualStyleBackColor = true;
            // 
            // rbBQuiz3
            // 
            this.rbBQuiz3.AutoSize = true;
            this.rbBQuiz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBQuiz3.Location = new System.Drawing.Point(4, 70);
            this.rbBQuiz3.Name = "rbBQuiz3";
            this.rbBQuiz3.Size = new System.Drawing.Size(456, 24);
            this.rbBQuiz3.TabIndex = 1;
            this.rbBQuiz3.TabStop = true;
            this.rbBQuiz3.Text = "Fico atento, mas mantenho minha estratégia de longo prazo.";
            this.rbBQuiz3.UseVisualStyleBackColor = true;
            // 
            // rbAQuiz3
            // 
            this.rbAQuiz3.AutoSize = true;
            this.rbAQuiz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAQuiz3.Location = new System.Drawing.Point(4, 13);
            this.rbAQuiz3.Name = "rbAQuiz3";
            this.rbAQuiz3.Size = new System.Drawing.Size(432, 24);
            this.rbAQuiz3.TabIndex = 0;
            this.rbAQuiz3.TabStop = true;
            this.rbAQuiz3.Text = "Fico preocupado e considero vender meus investimentos.";
            this.rbAQuiz3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(603, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "3: Como você reage a flutuações de curto prazo no mercado?";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(944, 395);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "quiz4";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(140, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 66);
            this.button3.TabIndex = 10;
            this.button3.Text = "Confirmar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.rbCQuiz4);
            this.panel4.Controls.Add(this.rbBQuiz4);
            this.panel4.Controls.Add(this.rbAQuiz4);
            this.panel4.Location = new System.Drawing.Point(136, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(662, 165);
            this.panel4.TabIndex = 9;
            // 
            // rbCQuiz4
            // 
            this.rbCQuiz4.AutoSize = true;
            this.rbCQuiz4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbCQuiz4.Location = new System.Drawing.Point(4, 122);
            this.rbCQuiz4.Name = "rbCQuiz4";
            this.rbCQuiz4.Size = new System.Drawing.Size(253, 24);
            this.rbCQuiz4.TabIndex = 2;
            this.rbCQuiz4.TabStop = true;
            this.rbCQuiz4.Text = "Mais de 50% do meu portfólio.";
            this.rbCQuiz4.UseVisualStyleBackColor = true;
            // 
            // rbBQuiz4
            // 
            this.rbBQuiz4.AutoSize = true;
            this.rbBQuiz4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbBQuiz4.Location = new System.Drawing.Point(4, 70);
            this.rbBQuiz4.Name = "rbBQuiz4";
            this.rbBQuiz4.Size = new System.Drawing.Size(286, 24);
            this.rbBQuiz4.TabIndex = 1;
            this.rbBQuiz4.TabStop = true;
            this.rbBQuiz4.Text = "Entre 25% e 50% do meu portfólio.";
            this.rbBQuiz4.UseVisualStyleBackColor = true;
            // 
            // rbAQuiz4
            // 
            this.rbAQuiz4.AutoSize = true;
            this.rbAQuiz4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAQuiz4.Location = new System.Drawing.Point(4, 13);
            this.rbAQuiz4.Name = "rbAQuiz4";
            this.rbAQuiz4.Size = new System.Drawing.Size(255, 24);
            this.rbAQuiz4.TabIndex = 0;
            this.rbAQuiz4.TabStop = true;
            this.rbAQuiz4.Text = "Menos de 25% do meu portfólio.";
            this.rbAQuiz4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(746, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "4: Qual é a proporção de investimentos em ações que você tem atualmente?";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(944, 395);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "quiz5";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(140, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 66);
            this.button4.TabIndex = 10;
            this.button4.Text = "Confirmar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.rbCQuiz5);
            this.panel5.Controls.Add(this.rbBQuiz5);
            this.panel5.Controls.Add(this.rbAQuiz5);
            this.panel5.Location = new System.Drawing.Point(136, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(662, 165);
            this.panel5.TabIndex = 9;
            // 
            // rbCQuiz5
            // 
            this.rbCQuiz5.AutoSize = true;
            this.rbCQuiz5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbCQuiz5.Location = new System.Drawing.Point(4, 122);
            this.rbCQuiz5.Name = "rbCQuiz5";
            this.rbCQuiz5.Size = new System.Drawing.Size(481, 24);
            this.rbCQuiz5.TabIndex = 2;
            this.rbCQuiz5.TabStop = true;
            this.rbCQuiz5.Text = "Vejo oportunidades significativas em mercados estrangeiros.";
            this.rbCQuiz5.UseVisualStyleBackColor = true;
            // 
            // rbBQuiz5
            // 
            this.rbBQuiz5.AutoSize = true;
            this.rbBQuiz5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBQuiz5.Location = new System.Drawing.Point(4, 70);
            this.rbBQuiz5.Name = "rbBQuiz5";
            this.rbBQuiz5.Size = new System.Drawing.Size(432, 24);
            this.rbBQuiz5.TabIndex = 1;
            this.rbBQuiz5.TabStop = true;
            this.rbBQuiz5.Text = "Estou aberto a investir em alguns mercados estrangeiros.";
            this.rbBQuiz5.UseVisualStyleBackColor = true;
            // 
            // rbAQuiz5
            // 
            this.rbAQuiz5.AutoSize = true;
            this.rbAQuiz5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAQuiz5.Location = new System.Drawing.Point(4, 13);
            this.rbAQuiz5.Name = "rbAQuiz5";
            this.rbAQuiz5.Size = new System.Drawing.Size(364, 24);
            this.rbAQuiz5.TabIndex = 0;
            this.rbAQuiz5.TabStop = true;
            this.rbAQuiz5.Text = "Prefiro evitar investir em mercados estrangeiros.";
            this.rbAQuiz5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(772, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "5: Como você se sente em relação a investimentos em mercados estrangeiros?";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage6.Controls.Add(this.btnReset);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(944, 395);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "resultado";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.Location = new System.Drawing.Point(399, 267);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 42);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "l";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(16, -3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(944, 29);
            this.panel6.TabIndex = 2;
            // 
            // Formquiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(988, 470);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.tabControl1);
            this.Name = "Formquiz";
            this.Text = "FormQuiz";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbCQuiz1;
        private System.Windows.Forms.RadioButton rbBQuiz1;
        private System.Windows.Forms.RadioButton rbAQuiz1;
        private System.Windows.Forms.Label lbQuiz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbCQuiz2;
        private System.Windows.Forms.RadioButton rbBQuiz2;
        private System.Windows.Forms.RadioButton rbAQuiz2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbCQuiz3;
        private System.Windows.Forms.RadioButton rbBQuiz3;
        private System.Windows.Forms.RadioButton rbAQuiz3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbCQuiz4;
        private System.Windows.Forms.RadioButton rbBQuiz4;
        private System.Windows.Forms.RadioButton rbAQuiz4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbCQuiz5;
        private System.Windows.Forms.RadioButton rbBQuiz5;
        private System.Windows.Forms.RadioButton rbAQuiz5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnQuiz1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
    }

}