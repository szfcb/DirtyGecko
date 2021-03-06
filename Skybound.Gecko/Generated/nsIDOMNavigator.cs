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
// Generated by IDLImporter from file nsIDOMNavigator.idl
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
	
	
	/// <summary>nsIDOMNavigator </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d7758ece-f088-4701-9ae4-1450192dca38")]
	public interface nsIDOMNavigator
	{
		
		/// <summary>Member GetAppCodeNameAttribute </summary>
		/// <param name='aAppCodeName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppCodeNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAppCodeName);
		
		/// <summary>Member GetAppNameAttribute </summary>
		/// <param name='aAppName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAppName);
		
		/// <summary>Member GetAppVersionAttribute </summary>
		/// <param name='aAppVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAppVersion);
		
		/// <summary>Member GetLanguageAttribute </summary>
		/// <param name='aLanguage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLanguageAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLanguage);
		
		/// <summary>Member GetMimeTypesAttribute </summary>
		/// <returns>A nsIDOMMimeTypeArray</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMimeTypeArray GetMimeTypesAttribute();
		
		/// <summary>Member GetPlatformAttribute </summary>
		/// <param name='aPlatform'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPlatformAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPlatform);
		
		/// <summary>Member GetOscpuAttribute </summary>
		/// <param name='aOscpu'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOscpuAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOscpu);
		
		/// <summary>Member GetVendorAttribute </summary>
		/// <param name='aVendor'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVendorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aVendor);
		
		/// <summary>Member GetVendorSubAttribute </summary>
		/// <param name='aVendorSub'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVendorSubAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aVendorSub);
		
		/// <summary>Member GetProductAttribute </summary>
		/// <param name='aProduct'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProductAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aProduct);
		
		/// <summary>Member GetProductSubAttribute </summary>
		/// <param name='aProductSub'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProductSubAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aProductSub);
		
		/// <summary>Member GetPluginsAttribute </summary>
		/// <returns>A nsIDOMPluginArray</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMPluginArray GetPluginsAttribute();
		
		/// <summary>Member GetUserAgentAttribute </summary>
		/// <param name='aUserAgent'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUserAgentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aUserAgent);
		
		/// <summary>Member GetCookieEnabledAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCookieEnabledAttribute();
		
		/// <summary>Member GetOnLineAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetOnLineAttribute();
		
		/// <summary>Member GetBuildIDAttribute </summary>
		/// <param name='aBuildID'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBuildIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aBuildID);
		
		/// <summary>Member JavaEnabled </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool JavaEnabled();
		
		/// <summary>Member TaintEnabled </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool TaintEnabled();
	}
}
