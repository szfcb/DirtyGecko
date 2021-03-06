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
// Generated by IDLImporter from file nsIPrefLocalizedString.idl
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
    /// The nsIPrefLocalizedString interface is simply a wrapper interface for
    /// nsISupportsString so the preferences service can have a unique identifier
    /// to distinguish between requests for normal wide strings (nsISupportsString)
    /// and "localized" wide strings, which get their default values from properites
    /// files.
    ///
    /// @see nsIPrefBranch
    /// @see nsISupportsString
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ae419e24-1dd1-11b2-b39a-d3e5e7073802")]
	public interface nsIPrefLocalizedString
	{
		
		/// <summary>
        /// Provides access to string data stored in this property.
        ///
        /// @return NS_OK The operation succeeded.
        /// @return Other An error occurred.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDataAttribute();
		
		/// <summary>
        /// Provides access to string data stored in this property.
        ///
        /// @return NS_OK The operation succeeded.
        /// @return Other An error occurred.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string aData);
		
		/// <summary>
        /// Used to retrieve the contents of this object into a wide string.
        ///
        /// @return wstring The string containing the data stored within this object.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
		
		/// <summary>
        /// Used to set the contents of this object.
        ///
        /// @param length The length of the string. This value should not include
        /// space for the null terminator, nor should it account for the
        /// size of a character. It should  only be the number of
        /// characters for which there is space in the string.
        /// @param data   The string data to be stored.
        ///
        /// @note
        /// This makes a copy of the string argument passed in.
        ///
        /// @return NS_OK The data was successfully stored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataWithLength(uint length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler", SizeParamIndex=0)] string data);
	}
}
