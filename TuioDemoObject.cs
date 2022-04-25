using System;
using System.Collections.Generic;
using System.Drawing;
using TUIO;

	public class TuioDemoObject : TuioObject
	{
	public static int flag = 0;

		SolidBrush black = new SolidBrush(Color.Black);
		SolidBrush white = new SolidBrush(Color.White);
	    Bitmap image = new Bitmap("Attack__002.PNG");

		public TuioDemoObject (long s_id, int f_id, float xpos, float ypos, float angle) : base(s_id,f_id,xpos,ypos,angle) {
		}

		public TuioDemoObject (TuioObject o) : base(o) {
		}

		public void paint(Graphics g) {

			int Xpos = (int)(xpos*TuioDemo.width);
			int Ypos = (int)(ypos*TuioDemo.height);
			int size = TuioDemo.height/10;

			g.TranslateTransform(Xpos,Ypos);
			g.RotateTransform((float)(angle/Math.PI*180.0f));
			g.TranslateTransform(-1*Xpos,-1*Ypos);
		if(symbol_id==0)
        {
			g.DrawImage(image, Xpos - size / 2, Ypos - size / 2, 100, 100);
			flag = 1;
		}
			g.TranslateTransform(Xpos,Ypos);
			g.RotateTransform(-1*(float)(angle/Math.PI*180.0f));
			g.TranslateTransform(-1*Xpos,-1*Ypos);

			Font font = new Font("Arial", 10.0f);
			g.DrawString(symbol_id+"",font, white, new PointF(Xpos-10,Ypos-10));
		}

	}
