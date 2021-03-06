

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
	public class GeckoHtmlElement : GeckoElement
	{
		nsIDOMHTMLHtmlElement DOMHTMLElement;
		internal GeckoHtmlElement(nsIDOMHTMLHtmlElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoHtmlElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLHtmlElement;
		}
		public string Version {
			get { return nsString.Get(DOMHTMLElement.GetVersionAttribute); }
			set { DOMHTMLElement.SetVersionAttribute(new nsAString(value)); }
		}

	}
}

