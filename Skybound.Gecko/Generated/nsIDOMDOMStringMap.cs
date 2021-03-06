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
// Generated by IDLImporter from file nsIDOMDOMStringMap.idl
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
	
	
	/// <summary>nsIDOMDOMStringMap </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("47c9ab4f-1ca3-4551-95d1-c02a93a0e74f")]
	public interface nsIDOMDOMStringMap
	{
		
		/// <summary>Member HasDataAttr </summary>
		/// <param name='prop'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasDataAttr([MarshalAs(UnmanagedType.LPStruct)] nsAString prop);
		
		/// <summary>Member GetDataAttr </summary>
		/// <param name='prop'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDataAttr([MarshalAs(UnmanagedType.LPStruct)] nsAString prop, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>Member SetDataAttr </summary>
		/// <param name='prop'> </param>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttr([MarshalAs(UnmanagedType.LPStruct)] nsAString prop, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>Member RemoveDataAttr </summary>
		/// <param name='prop'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveDataAttr([MarshalAs(UnmanagedType.LPStruct)] nsAString prop);
		
		/// <summary>
        /// Removes the property from the dataset object. Used to update the
        /// dataset object when data-* attribute has been removed from the
        /// element.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveProp([MarshalAs(UnmanagedType.Interface)] nsIAtom attr);
	}
}
