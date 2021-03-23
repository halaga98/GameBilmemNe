// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp2.Form1
// Assembly: WindowsFormsApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D991277-C4E9-46C5-9894-13C427645C33
// Assembly location: C:\Users\huso\source\repos\WindowsFormsApp2\WindowsFormsApp2\obj\Debug\WindowsFormsApp2.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Button btnStart;
    private Label labelQue;
    private TextBox txtAnswer;
    private Button btnChk;
    private Label labelTrue;
    private Label labelFalse;
    private GroupBox groupBox1;
    private Label wrongCount;
    private Label correctCount;
    private Label gameCount;

    public int number1 { get; set; }

    public int number2 { get; set; }

    public char op { get; set; }

    public int Game { get; set; }

    public int Correct { get; set; }

    public int Wrong { get; set; }

    public Form1() => this.InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Game = this.Correct = this.Wrong = 0;
      this.updateScore();
    }

    private void updateScore()
    {
      this.gameCount.Text = "Game" + this.Game.ToString();
      this.correctCount.Text = "Correct" + this.Correct.ToString();
      this.wrongCount.Text = "Wrong" + this.Wrong.ToString();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      Random random = new Random();
      this.number1 = random.Next(0, 101);
      this.number2 = random.Next(0, 101);
      switch (random.Next(4))
      {
        case 0:
          this.op = '+';
          break;
        case 1:
          this.op = '-';
          break;
        case 2:
          this.op = '*';
          break;
        case 3:
          this.op = '/';
          break;
      }
      this.labelQue.Text = string.Format("{0} {1} {2} = ", (object) this.number1, (object) this.op, (object) this.number2);
      this.labelQue.Visible = true;
      this.txtAnswer.Visible = true;
      this.btnChk.Visible = true;
      this.labelTrue.Visible = false;
      this.labelFalse.Visible = false;
      this.updateScore();
    }

    private void btnChk_Click(object sender, EventArgs e)
    {
      int num1 = 0;
      int result = 0;
      switch (this.op)
      {
        case '*':
          num1 = this.number1 * this.number2;
          break;
        case '+':
          num1 = this.number1 + this.number2;
          break;
        case '-':
          num1 = this.number1 - this.number2;
          break;
        case '/':
          num1 = this.number1 / this.number2;
          break;
      }
      if (!int.TryParse(this.txtAnswer.Text, out result))
      {
        int num2 = (int) MessageBox.Show("INVALID NUMBER");
        this.txtAnswer.Focus();
        this.txtAnswer.SelectAll();
      }
      else
      {
        if (num1 == result)
        {
          this.labelTrue.Visible = true;
          ++this.Correct;
        }
        else
        {
          this.labelFalse.Visible = true;
          ++this.Wrong;
        }
        ++this.Game;
        this.updateScore();
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.label2 = new Label();
      this.btnStart = new Button();
      this.labelQue = new Label();
      this.txtAnswer = new TextBox();
      this.btnChk = new Button();
      this.labelTrue = new Label();
      this.labelFalse = new Label();
      this.groupBox1 = new GroupBox();
      this.wrongCount = new Label();
      this.correctCount = new Label();
      this.gameCount = new Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 33);
      this.label1.Name = "label1";
      this.label1.Size = new Size(49, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Describe";
      this.label2.Location = new Point(26, 59);
      this.label2.Name = "label2";
      this.label2.Size = new Size(243, 77);
      this.label2.TabIndex = 1;
      this.label2.Text = "1-asdasdasdasd\r\n2-asdasdsad";
      this.btnStart.Location = new Point(29, 112);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new Size(75, 23);
      this.btnStart.TabIndex = 2;
      this.btnStart.Text = "StartGame";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new EventHandler(this.btnStart_Click);
      this.labelQue.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelQue.Location = new Point(29, 152);
      this.labelQue.Name = "labelQue";
      this.labelQue.Size = new Size(100, 23);
      this.labelQue.TabIndex = 3;
      this.labelQue.Text = "15  + 25  =";
      this.labelQue.Visible = false;
      this.txtAnswer.Location = new Point(135, 154);
      this.txtAnswer.Name = "txtAnswer";
      this.txtAnswer.Size = new Size(100, 20);
      this.txtAnswer.TabIndex = 4;
      this.txtAnswer.Visible = false;
      this.btnChk.Location = new Point(247, 152);
      this.btnChk.Name = "btnChk";
      this.btnChk.Size = new Size(75, 23);
      this.btnChk.TabIndex = 5;
      this.btnChk.Text = "Check";
      this.btnChk.UseVisualStyleBackColor = true;
      this.btnChk.Visible = false;
      this.btnChk.Click += new EventHandler(this.btnChk_Click);
      this.labelTrue.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelTrue.ForeColor = Color.Green;
      this.labelTrue.Location = new Point(26, 192);
      this.labelTrue.Name = "labelTrue";
      this.labelTrue.Size = new Size(109, 23);
      this.labelTrue.TabIndex = 6;
      this.labelTrue.Text = "Congratulations";
      this.labelTrue.Visible = false;
      this.labelFalse.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.labelFalse.ForeColor = Color.Red;
      this.labelFalse.Location = new Point(26, 226);
      this.labelFalse.Name = "labelFalse";
      this.labelFalse.Size = new Size(100, 23);
      this.labelFalse.TabIndex = 7;
      this.labelFalse.Text = "Wrong Answer";
      this.labelFalse.Visible = false;
      this.groupBox1.Controls.Add((Control) this.wrongCount);
      this.groupBox1.Controls.Add((Control) this.correctCount);
      this.groupBox1.Controls.Add((Control) this.gameCount);
      this.groupBox1.Location = new Point(222, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(136, 100);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Score";
      this.wrongCount.Location = new Point(12, 70);
      this.wrongCount.Name = "wrongCount";
      this.wrongCount.Size = new Size(100, 23);
      this.wrongCount.TabIndex = 2;
      this.wrongCount.Text = "Wrong : 3";
      this.correctCount.Location = new Point(12, 47);
      this.correctCount.Name = "correctCount";
      this.correctCount.Size = new Size(100, 23);
      this.correctCount.TabIndex = 1;
      this.correctCount.Text = "Correct : 2";
      this.gameCount.Location = new Point(12, 21);
      this.gameCount.Name = "gameCount";
      this.gameCount.Size = new Size(100, 23);
      this.gameCount.TabIndex = 0;
      this.gameCount.Text = "Game : 5";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(371, 258);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.labelFalse);
      this.Controls.Add((Control) this.labelTrue);
      this.Controls.Add((Control) this.btnChk);
      this.Controls.Add((Control) this.txtAnswer);
      this.Controls.Add((Control) this.labelQue);
      this.Controls.Add((Control) this.btnStart);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (Form1);
      this.Text = nameof (Form1);
      this.Load += new EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
