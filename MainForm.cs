/*
 * Created by SharpDevelop.
 * User: Office
 * Date: 12.12.2018
 * Time: 16:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace Passwort_Generator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		bool CharacterGroupChoosed()
		{
			if(cH_Capitals.Checked || cH_LowerCaseLetters.Checked || cH_Peculiar.Checked || cH_Numbers.Checked || cH_OwnCharacters.Checked)
				return true;
			
			return false;
		}
		
		void TB_TextChanged(object sender, System.EventArgs e)
		{
			EnDisableButton();
		}
		void EnDisableButton()
		{
			int result;
			
			if(CharacterGroupChoosed())
			{
				if(tB_OwnCharacters.Enabled)
				{
					if(tB_OwnCharacters.Text == string.Empty)
					{
						btn_Create.Enabled = false;
						return;
					}
				}
				
				if(int.TryParse(tB_CharCount.Text, out result))
					btn_Create.Enabled = true;
				else
					btn_Create.Enabled = false;
			}
			else
				btn_Create.Enabled = false;
		}
		void Btn_CreateClick(object sender, System.EventArgs e)
		{
			RandomString randomString = new RandomString();
			CharContainer charContainer = new CharContainer();
			
			ArrayList container = charContainer.CreateNewCharContainer(
			                                       cH_LowerCaseLetters.Checked, cH_Capitals.Checked, cH_Peculiar.Checked, cH_Numbers.Checked,
			                                       cH_OwnCharacters.Checked, tB_OwnCharacters.Text);
			
			tB_CreatedPassword.Text = randomString.GetRandomString(container, int.Parse(tB_CharCount.Text.Replace(" ", "")));
		}
		
		void CheckBoxes_CheckedChanged(object sender, System.EventArgs e)
		{
			if((CheckBox)sender == cH_OwnCharacters)
				tB_OwnCharacters.Enabled = cH_OwnCharacters.Checked;
			
			EnDisableButton();	
		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
