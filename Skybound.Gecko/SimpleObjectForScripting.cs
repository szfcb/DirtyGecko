using System;
using System.Collections.Generic;
using System.Text;

namespace Skybound.Gecko
{
    //From a thread on the GeckoFX forums:
    //http://geckofx.org/viewtopic.php?id=743
    public class SimpleObjectForScripting
    {
        private nsIDOMWindow oDomWindow;

        private static string CLIENT_SIDE_JAVASCRIPT_ID = "invokescript";

        private Dictionary<int, RouteEventHandler> oEventListeners = new Dictionary<int, RouteEventHandler>();
        private Dictionary<int, nsAString> oEventTypes = new Dictionary<int, nsAString>();

        internal SimpleObjectForScripting(ref nsIDOMWindow DomWindow)
        {
            oDomWindow = DomWindow;
        }

        #region EventHandlers - Recive event FROM javascript
        /// <summary>
        /// Add a C# listner to the xpcom listner. This is done by wrappinig the xpcom event.
        /// </summary>
        /// <param name="Type">The name of the eventtype, for e.g 'MyCustomEvent'. This must be the same as the EventName in the JavaScript.</param>
        /// <param name="Handler">The handler for this event</param>
        public void AddEventListener(string Type, EventHandler<DOMJSONStringEventArgs> Handler)
        {
            RouteEventHandler Listener = new RouteEventHandler(Handler);
            if (oEventListeners.ContainsKey(Handler.Method.GetHashCode()) == true && oEventTypes.ContainsKey(Handler.Method.GetHashCode()))
            {
                oEventListeners.Remove(Handler.Method.GetHashCode());
                oEventTypes.Remove(Handler.Method.GetHashCode());
            }

            oEventListeners.Add(Handler.Method.GetHashCode(), Listener);

            nsAString nsType = new nsAString(Type);
            oEventTypes.Add(Handler.Method.GetHashCode(), nsType);

            (oDomWindow as nsIDOMEventTarget).AddEventListener(nsType, Listener, false, false, 0);

        }
        /// <summary>
        /// Remove  C# listner from the xpcom listner.
        /// </summary>
        /// <param name="Type">The name of the eventtype, for e.g 'MyCustomEvent'. This must be the same as the EventName in the JavaScript.</param>
        /// <param name="Handler">The handler for this event</param>
        public void RemoveEventListener(string Type, EventHandler<DOMJSONStringEventArgs> Handler)
        {

            nsIDOMEventTarget target = oDomWindow as nsIDOMEventTarget;
            nsAString strType = oEventTypes[Handler.Method.GetHashCode()] as nsAString;

            RouteEventHandler route = oEventListeners[Handler.Method.GetHashCode()] as RouteEventHandler;

            target.RemoveEventListener(strType, route, false);

            oEventListeners.Remove(Handler.Method.GetHashCode());
            oEventTypes.Remove(Handler.Method.GetHashCode());

        }
        #endregion

        #region JavaScript helper Methods - Execute Javascript
        /// <summary>
        /// This will run arbitraty javascript on the client. It creates a script block in the DOM tree and the javascript gets executed. 
        /// The script block is not permanent. It will be removed on the next call to this method, and replaced by new arbitarty code.
        /// </summary>
        /// <param name="strSourceJavaScript">The JavaScript Code</param>
        /// <param name="wrapTryCatch">If true it will att a javascript try/catch block for the incomming code.</param>
        public void RunRawJavaScriptOnClient(string strSourceJavaScript, bool wrapTryCatch)
        {
            if (strSourceJavaScript.Length > 0)
            {
                if (wrapTryCatch == false)
                {
                    ScriptBuilder(strSourceJavaScript);
                }
                else
                {
                    ScriptBuilder("try {" + strSourceJavaScript + "}catch(anError){ dump(anError); alert(anError); }");
                }
            }
        }

        /// <summary>
        /// Appends a script block with the id of CLIENT_SIDE_JAVASCRIPT_ID, adds it to the dom tree
        /// </summary>
        /// <param name="strSourceJavaScript">Javascript code.</param>
        private void ScriptBuilder(string strSourceJavaScript)
        {
            GeckoDocument doc = GeckoDocument.Create((nsIDOMHTMLDocument)oDomWindow.GetDocumentAttribute());
            GeckoElement ge = doc.GetElementById(CLIENT_SIDE_JAVASCRIPT_ID);

            if (ge != null)
                doc.Body.RemoveChild(ge);

            ge = doc.CreateElement("script");
            ge.SetAttribute("type", "text/javascript");
            ge.SetAttribute("id", CLIENT_SIDE_JAVASCRIPT_ID);

            StringBuilder textContent = new StringBuilder();

            textContent.Append(strSourceJavaScript);

            ge.TextContent = textContent.ToString();
            doc.Body.AppendChild(ge);

        }

        #endregion
    }
}
