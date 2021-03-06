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
// Generated by IDLImporter from file nsIStartupCache.idl
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
	
	
	/// <summary>nsIStartupCache </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("de798fab-af49-4a61-8144-81550986e1da")]
	public interface nsIStartupCache
	{
		
		/// <summary>
        ///This interface is provided for testing purposes only, basically
        /// just to solve link vagaries. See docs in StartupCache.h
        /// GetBuffer, PutBuffer, and InvalidateCache act as described
        /// in that file. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetBuffer([MarshalAs(UnmanagedType.LPStr)] string aID, ref System.IntPtr aBuffer);
		
		/// <summary>Member PutBuffer </summary>
		/// <param name='aID'> </param>
		/// <param name='aBuffer'> </param>
		/// <param name='aLength'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PutBuffer([MarshalAs(UnmanagedType.LPStr)] string aID, System.IntPtr aBuffer, uint aLength);
		
		/// <summary>Member InvalidateCache </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvalidateCache();
		
		/// <summary>
        ///In debug builds, wraps this object output stream with a stream that will
        /// detect and prevent the write of a multiply-referenced non-singleton object
        /// during serialization. In non-debug, returns an add-ref'd pointer to
        /// original stream, unwrapped. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIObjectOutputStream GetDebugObjectOutputStream([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aStream);
		
		/// <summary>
        ///Allows clients to check whether the one-time writeout after startup
        /// has finished yet, and also to set this variable as needed (so test
        /// code can fire mulitple startup writes if needed).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool StartupWriteComplete();
		
		/// <summary>Member ResetStartupWriteTimer </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetStartupWriteTimer();
		
		/// <summary>
        ///Allows clients to simulate the behavior of ObserverService. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIObserver GetObserverAttribute();
	}
}
