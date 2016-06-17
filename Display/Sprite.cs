﻿using Poncho.Geom;
using Poncho.Interfaces;

namespace Poncho.Display
{
	public class Sprite : DisplayObject
	{
		public string name;
		public Transforms transforms { get; private set; }
		public float x { get { return transforms.x; } set { transforms.x = value; } }
		public float y { get { return transforms.y; } set { transforms.y = value; } }
		public float scaleX { get { return transforms.scaleX; } set { transforms.scaleX = value; } }
		public float scaleY { get { return transforms.scaleY; } set { transforms.scaleY = value; } }
		public float rotation { get { return transforms.rotation; } set { transforms.rotation = value; } }
		public ITextureImage image;
		public DisplayObject parent { get; internal set; }
		
		// --------------------------------------------------------------
		public Sprite() : base()
		{
			transforms = new Transforms();
		}
		
		// --------------------------------------------------------------
		public void RemoveFromDisplay()
		{
			if(parent != null)
			{
				parent.RemoveChild(this);
				parent = null;
			}
		}
	}
}