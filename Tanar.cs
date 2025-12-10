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
			List<Vektor> mezők = Vektor.Rács(new Vektor(0, 0), new Vektor(40,30));
			foreach (Vektor mező in mezők)
				pálya[mező] = üres;

			mezők.Shuffle();

			int kövek_száma = r.Next(20, 40*30-500);

			for (int i = 0; i < kövek_száma; i++)
				pálya[mezők[i]] = fekete;

			Robot karesz = new Robot("Karesz", 0, 0, 0, 0, 0, r.Next(1,30), r.Next(1,40), r.Next(4), false, false);
			//Betölt(betöltendő_pálya);
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