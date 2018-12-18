/*
 * Created by SharpDevelop.
 * User: Office
 * Date: 12.12.2018
 * Time: 16:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Text;
using System.Collections;

namespace Passwort_Generator
{
	/// <summary>
	/// Description of RandomString.
	/// </summary>
	public class RandomString
	{
		Random _random = new Random();

		StringBuilder _str = new StringBuilder();
		
		public RandomString()
		{
		}
		public string GetRandomString(ArrayList allowed_chars, int charCount)
		{
			int tmp;
			
			for(int i = 0; i < charCount; i++)
			{
				tmp = _random.Next(33, 127);
				
				if(allowed_chars.Contains((char)tmp))
				   _str.Append((char)tmp);
				else
					i--;
			}
			return _str.ToString();
		}
	}
}
