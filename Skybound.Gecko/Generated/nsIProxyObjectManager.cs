// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIProxyObjectManager.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// An interface for the proxy object manager.
    ///
    /// See http://www.mozilla.org/projects/xpcom/Proxies.html
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ee8ce1e3-0319-4bd9-8f70-7258b21c7733")]
	public interface nsIProxyObjectManager
	{
		
		/// <summary>
        /// Create a proxy for the given object.  The proxy implements the specified
        /// interface, but when its methods are invoked, it causes the corresponding
        /// method on the actual object to be called via the designated event
        /// target.  Typically, the event target identifies a thread where the
        /// method call should occur.
        ///
        /// @param target
        /// If target is null, then the current thread is used as the target.
        /// Otherwise, target identifies the nsIEventTarget from which proxy
        /// method calls should be executed.
        /// @param iid
        /// Identifies the interface being proxied.  The given object must QI to
        /// this type.
        /// @param object
        /// The object being proxied.
        /// @param proxyType
        /// Specifies the type of proxy to construct.  Either INVOKE_SYNC or
        /// INVOKE_ASYNC must be specified.  FORCE_PROXY_CREATION may be bit-wise
        /// OR'd with either of those flags.
        /// @param result
        /// This param holds the resulting proxy object upon successful return.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetProxyForObject([MarshalAs(UnmanagedType.Interface)] nsIEventTarget target, ref System.Guid iid, [MarshalAs(UnmanagedType.Interface)] nsISupports @object, int proxyType);
	}
}
