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

namespace Temp_Delete
{
	class Program
	{
		public static void Main(string[] args)
		{	String temp=Environment.GetEnvironmentVariable("TEMP");
			IEnumerable<String> a=Directory.EnumerateDirectories(temp);
			foreach(String b in a)
			{
				try
				{
					Directory.Delete(b,true);
					Console.Out.WriteLine(b+ "  Deleted");
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
					Console.Out.WriteLine(d+"  Deleted");
				}
				catch{
				
					Console.Out.WriteLine(d+"  Pass");
				}
			
			
			}
		}
		
	}
}