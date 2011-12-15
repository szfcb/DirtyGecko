using System;

namespace Skybound.Gecko
{
    //From a thread on the GeckoFX forums:
    //http://geckofx.org/viewtopic.php?id=743

    /// <summary>
    /// These event args will contain the javascript event that was raised along with its JSONString.
    /// </summary>
    public class DOMJSONStringEventArgs : System.EventArgs
    {
        private string strJSEventName = "";

        public string JSEventName
        {
            get { return strJSEventName; }
        }
        private string strJSONString = "";

        public string JSONString
        {
            get { return strJSONString; }
        }

        public DOMJSONStringEventArgs(nsAString JSEventName, nsAString strJSONString)
        {
            this.strJSEventName = JSEventName.ToString();
            this.strJSONString = strJSONString.ToString();

        }

    }

    /// <summary>
    /// This class is a wrapper to the underlying IDOMEventListner.
    /// It re-raises a C# event with apropriate event args.
    /// </summary>
    public class RouteEventHandler : nsIDOMEventListener
    {
        private EventHandler<DOMJSONStringEventArgs> handler;
        public const string JS_ELEMENT_NAME = "JSONString";

        public RouteEventHandler(EventHandler<DOMJSONStringEventArgs> oHandler)
        {
            this.handler = oHandler;
        }

        #region nsIDOMEventListener Members

        void nsIDOMEventListener.HandleEvent(nsIDOMEvent e)
        {
            nsAString jsEventName = new nsAString();
            nsAString attribute = new nsAString(JS_ELEMENT_NAME);
            nsAString value = new nsAString();

            nsIDOMElement target = e.GetTargetAttribute() as nsIDOMElement;

            target.GetAttribute(attribute, value);
            e.GetTypeAttribute(jsEventName);


            DOMJSONStringEventArgs eArgs = new DOMJSONStringEventArgs(jsEventName, value);
            if (this.handler != null)
                this.handler(target, eArgs);

            jsEventName.Dispose();
            attribute.Dispose();
            value.Dispose();

        }

        #endregion
    }
}