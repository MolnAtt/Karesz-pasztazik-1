using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{

	public partial class Form1 : Form
	{
		static Random r = new Random();
		string betöltendő_pálya = "palya26.txt";
		void TANÁR_ROBOTJAI()
		{

			List<Vektor> mezők = new List<Vektor>(40*30);

			for (int x = 0; x <= 40; x++)
			{
				for (int y = 0; y <= 30; y++)
				{
					mezők.Add(new Vektor(x, y));
				}
			}


			Robot karesz = new Robot("Karesz", 0, 0, 0, 0, 0, r.Next(1,30), r.Next(1,40), 0, false, false);
			Betölt(betöltendő_pálya);
			Frissít();

			//Robot lilesz = new Robot("Lilesz", 1000, 1000, 1000, 1000, 0, 10, 22, 0);
			//lilesz.Feladat = delegate()
			//{
			//	lilesz.Lépj();
			//  lilesz.Lépj();
			//};
		}
	}
}