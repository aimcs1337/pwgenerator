/*
 * Created by SharpDevelop.
 * User: Office
 * Date: 12.12.2018
 * Time: 16:51
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Passwort_Generator
{
	partial class MainForm : System.Windows.Forms.Form
	{			
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.cH_LowerCaseLetters = new System.Windows.Forms.CheckBox();
            this.cH_Capitals = new System.Windows.Forms.CheckBox();
            this.gB_CharacterGroups = new System.Windows.Forms.GroupBox();
            this.tB_OwnCharacters = new System.Windows.Forms.TextBox();
            this.cH_OwnCharacters = new System.Windows.Forms.CheckBox();
            this.cH_Peculiar = new System.Windows.Forms.CheckBox();
            this.cH_Numbers = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_CharCount = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_CreatedPassword = new System.Windows.Forms.TextBox();
            this.gB_CharacterGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // cH_LowerCaseLetters
            // 
            this.cH_LowerCaseLetters.Location = new System.Drawing.Point(34, 20);
            this.cH_LowerCaseLetters.Name = "cH_LowerCaseLetters";
            this.cH_LowerCaseLetters.Size = new System.Drawing.Size(57, 24);
            this.cH_LowerCaseLetters.TabIndex = 0;
            this.cH_LowerCaseLetters.Text = "a-z";
            this.cH_LowerCaseLetters.UseVisualStyleBackColor = true;
            this.cH_LowerCaseLetters.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // cH_Capitals
            // 
            this.cH_Capitals.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cH_Capitals.Location = new System.Drawing.Point(155, 20);
            this.cH_Capitals.Name = "cH_Capitals";
            this.cH_Capitals.Size = new System.Drawing.Size(60, 24);
            this.cH_Capitals.TabIndex = 1;
            this.cH_Capitals.Text = "A-Z";
            this.cH_Capitals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cH_Capitals.UseVisualStyleBackColor = true;
            this.cH_Capitals.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // gB_CharacterGroups
            // 
            this.gB_CharacterGroups.Controls.Add(this.tB_OwnCharacters);
            this.gB_CharacterGroups.Controls.Add(this.cH_OwnCharacters);
            this.gB_CharacterGroups.Controls.Add(this.cH_Peculiar);
            this.gB_CharacterGroups.Controls.Add(this.cH_Numbers);
            this.gB_CharacterGroups.Controls.Add(this.cH_Capitals);
            this.gB_CharacterGroups.Controls.Add(this.cH_LowerCaseLetters);
            this.gB_CharacterGroups.Location = new System.Drawing.Point(12, 12);
            this.gB_CharacterGroups.Name = "gB_CharacterGroups";
            this.gB_CharacterGroups.Size = new System.Drawing.Size(265, 152);
            this.gB_CharacterGroups.TabIndex = 2;
            this.gB_CharacterGroups.TabStop = false;
            this.gB_CharacterGroups.Text = "Zeichengruppen:";
            // 
            // tB_OwnCharacters
            // 
            this.tB_OwnCharacters.Enabled = false;
            this.tB_OwnCharacters.Location = new System.Drawing.Point(145, 105);
            this.tB_OwnCharacters.Name = "tB_OwnCharacters";
            this.tB_OwnCharacters.Size = new System.Drawing.Size(100, 20);
            this.tB_OwnCharacters.TabIndex = 5;
            this.tB_OwnCharacters.TextChanged += new System.EventHandler(this.TB_TextChanged);
            // 
            // cH_OwnCharacters
            // 
            this.cH_OwnCharacters.Location = new System.Drawing.Point(34, 102);
            this.cH_OwnCharacters.Name = "cH_OwnCharacters";
            this.cH_OwnCharacters.Size = new System.Drawing.Size(108, 26);
            this.cH_OwnCharacters.TabIndex = 4;
            this.cH_OwnCharacters.Text = "Eigene Zeichen:";
            this.cH_OwnCharacters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cH_OwnCharacters.UseVisualStyleBackColor = true;
            this.cH_OwnCharacters.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // cH_Peculiar
            // 
            this.cH_Peculiar.Location = new System.Drawing.Point(155, 61);
            this.cH_Peculiar.Name = "cH_Peculiar";
            this.cH_Peculiar.Size = new System.Drawing.Size(75, 24);
            this.cH_Peculiar.TabIndex = 3;
            this.cH_Peculiar.Text = "!\"§$%&";
            this.cH_Peculiar.UseVisualStyleBackColor = true;
            this.cH_Peculiar.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // cH_Numbers
            // 
            this.cH_Numbers.Location = new System.Drawing.Point(34, 59);
            this.cH_Numbers.Name = "cH_Numbers";
            this.cH_Numbers.Size = new System.Drawing.Size(45, 28);
            this.cH_Numbers.TabIndex = 2;
            this.cH_Numbers.Text = "0-9";
            this.cH_Numbers.UseVisualStyleBackColor = true;
            this.cH_Numbers.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(87, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anzahl der Zeichen:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tB_CharCount
            // 
            this.tB_CharCount.Location = new System.Drawing.Point(105, 193);
            this.tB_CharCount.Name = "tB_CharCount";
            this.tB_CharCount.Size = new System.Drawing.Size(67, 20);
            this.tB_CharCount.TabIndex = 4;
            this.tB_CharCount.TextChanged += new System.EventHandler(this.TB_TextChanged);
            // 
            // btn_Create
            // 
            this.btn_Create.Enabled = false;
            this.btn_Create.Location = new System.Drawing.Point(341, 85);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(77, 25);
            this.btn_Create.TabIndex = 5;
            this.btn_Create.Text = "Generieren";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.Btn_CreateClick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(322, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Generiertes Passwort:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tB_CreatedPassword
            // 
            this.tB_CreatedPassword.Location = new System.Drawing.Point(306, 48);
            this.tB_CreatedPassword.Name = "tB_CreatedPassword";
            this.tB_CreatedPassword.ReadOnly = true;
            this.tB_CreatedPassword.Size = new System.Drawing.Size(155, 20);
            this.tB_CreatedPassword.TabIndex = 7;
            this.tB_CreatedPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 228);
            this.Controls.Add(this.tB_CreatedPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.tB_CharCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gB_CharacterGroups);
            this.Name = "MainForm";
            this.Text = "Passwort-Generator by aimcs1337";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gB_CharacterGroups.ResumeLayout(false);
            this.gB_CharacterGroups.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.TextBox tB_CreatedPassword;
		private System.Windows.Forms.Button btn_Create;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tB_CharCount;
		private System.Windows.Forms.CheckBox cH_LowerCaseLetters;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cH_Numbers;
		private System.Windows.Forms.CheckBox cH_Peculiar;
		private System.Windows.Forms.CheckBox cH_OwnCharacters;
		private System.Windows.Forms.TextBox tB_OwnCharacters;
		private System.Windows.Forms.GroupBox gB_CharacterGroups;
		private System.Windows.Forms.CheckBox cH_Capitals;
	}
}
