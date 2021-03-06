

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
	public class GeckoHeadElement : GeckoElement
	{
		nsIDOMHTMLHeadElement DOMHTMLElement;
		internal GeckoHeadElement(nsIDOMHTMLHeadElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoHeadElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLHeadElement;
		}		
	}
}

