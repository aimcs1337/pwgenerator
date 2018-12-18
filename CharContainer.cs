/*
 * Created by SharpDevelop.
 * User: Office
 * Date: 12.12.2018
 * Time: 16:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;

namespace Passwort_Generator
{
	/// <summary>
	/// Description of CharContainer.
	/// </summary>
	public class CharContainer
	{
		ArrayList charContainer;
		
		public CharContainer()
		{
			charContainer = new ArrayList();
		}
		public ArrayList CreateNewCharContainer(bool lowerCaseLetters, bool capitals, bool peculiar, bool numbers, bool ownCharacters, string myCharacters)
		{
			if(lowerCaseLetters)
			{								
				for(int i = 97; i < 123; i++)
				{
					charContainer.Add((char)i);
				}
			}
			if(capitals)
			{
				for(int i = 65; i < 91; i++)
				{
					charContainer.Add((char)i);
				}
			}
			if(peculiar)
			{
				for(int i = 32; i < 48; i++)
				{
					charContainer.Add((char)i);
				}
				for(int i = 58; i < 65; i++)
				{
					charContainer.Add((char)i);
				}
				for(int i = 91; i < 97; i++)
				{
					charContainer.Add((char)i);
				}
				charContainer.Add((char)123);
				charContainer.Add((char)124);
				charContainer.Add((char)125);
				charContainer.Add((char)126);
			}
			if(numbers)
			{
				for(int i = 48; i < 58; i++)
				{
					charContainer.Add((char)i);
				}
			}
			
			if(ownCharacters)
			{
				System.Text.UnicodeEncoding unicode = new System.Text.UnicodeEncoding();
				char[] characters = unicode.GetChars(unicode.GetBytes(myCharacters));
				for(int i = 0; i < characters.Length; i++)
				{
					if(!charContainer.Contains(characters[i]))
						charContainer.Add(characters[i]);
				}
			}
			return charContainer;
		}
	}
}
