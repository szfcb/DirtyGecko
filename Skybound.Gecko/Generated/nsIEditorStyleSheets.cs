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
// Generated by IDLImporter from file nsIEditorStyleSheets.idl
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
	
	
	/// <summary>nsIEditorStyleSheets </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4805e682-49b9-11d3-9ce4-ed60bd6cb5bc")]
	public interface nsIEditorStyleSheets
	{
		
		/// <summary>
        ///Load and apply the style sheet, specified by aURL, to the
        /// editor's document, replacing the last style sheet added (if any).
        /// This is always asynchronous, and may cause network I/O.
        ///
        /// @param aURL The style sheet to be loaded and applied.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReplaceStyleSheet([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL);
		
		/// <summary>
        ///Add the given style sheet to the editor's document,
        /// on top of any that are already there.
        /// This is always asynchronous, and may cause network I/O.
        ///
        /// @param aURL The style sheet to be loaded and applied.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddStyleSheet([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL);
		
		/// <summary>
        ///Load and apply the override style sheet, specified by aURL, to the
        /// editor's document, replacing the last override style sheet added (if any).
        /// This is always synchronous, so aURL should be a local file with only
        /// local @imports. This action is not undoable. It is not intended for
        /// "user" style sheets, only for editor developers to add sheets to change
        /// display behavior for editing (like showing special cursors) that will
        /// not be affected by loading "document" style sheets with addStyleSheet or
        /// especially replaceStyleSheet.
        ///
        /// @param aURL The style sheet to be loaded and applied.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReplaceOverrideStyleSheet([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL);
		
		/// <summary>
        ///Load and apply an override style sheet, specified by aURL, to
        /// the editor's document, on top of any that are already there.
        /// This is always synchronous, so the same caveats about local files and no
        /// non-local @import as replaceOverrideStyleSheet apply here, too.
        ///
        /// @param aURL The style sheet to be loaded and applied.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddOverrideStyleSheet([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL);
		
		/// <summary>
        ///Remove the given style sheet from the editor's document
        /// This is always synchronous
        ///
        /// @param aURL The style sheet to be removed
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveStyleSheet([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL);
		
		/// <summary>
        ///Remove the given override style sheet from the editor's document
        /// This is always synchronous
        ///
        /// @param aURL The style sheet to be removed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveOverrideStyleSheet([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL);
		
		/// <summary>
        ///Enable or disable the given style sheet from the editor's document
        /// This is always synchronous
        ///
        /// @param aURL  The style sheet to be enabled or disabled
        /// @param aEnable true to enable, or false to disable the style sheet
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnableStyleSheet([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL, [MarshalAs(UnmanagedType.Bool)] bool aEnable);
		
		/// <summary>
        ///Get the nsCSSStyleSheet associated with the given URL.
        ///
        /// @param aURL         The style sheet's URL
        /// @return             the style sheet
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetStyleSheetForURL([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL);
		
		/// <summary>
        ///Get the URL associated with the given nsCSSStyleSheet.
        ///
        /// @param aStyleSheet  The style sheet
        /// @return             the style sheet's URL
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetURLForStyleSheet(System.IntPtr aStyleSheet, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
	}
}
