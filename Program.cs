/*
 * Created by SharpDevelop.
 * User: 20-8-15
 * Date: 02/19/2018
 * Time: 11:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Temp_Delete
{
	class Program
	{public static String output;
		public static void Main(string[] args)
		{	String temp=Environment.GetEnvironmentVariable("TEMP");
			IEnumerable<String> a=Directory.EnumerateDirectories(temp);
			foreach(String b in a)
			{
				try
				{
					Directory.Delete(b,true);
					output+=b+ "  Deleted \n";
				}
				catch {
					Console.Out.WriteLine("  Pass");
				}
			}
			
			
			IEnumerable<String> c=Directory.EnumerateFiles(temp);
			foreach(String d in c)
			{
				try
				{
					File.Delete(d);
					output+=d+"  Deleted \n";
				}
				catch{
				
					Console.Out.WriteLine(d+"  Pass");
				}
		
				Console.Out.WriteLine(output);
				new MainForm(output);
				Application.Exit();
			}
		}
		
	}
}