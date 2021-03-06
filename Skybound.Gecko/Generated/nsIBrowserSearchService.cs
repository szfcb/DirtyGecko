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
// Generated by IDLImporter from file nsIBrowserSearchService.idl
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
	
	
	/// <summary>nsISearchSubmission </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("58e4f602-a7c8-4cd1-9dca-716705e826ef")]
	public interface nsISearchSubmission
	{
		
		/// <summary>
        /// The POST data associated with a search submission, wrapped in a MIME
        /// input stream. May be null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream GetPostDataAttribute();
		
		/// <summary>
        /// The URI to submit a search to.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetUriAttribute();
	}
	
	/// <summary>nsISearchEngine </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("803e510b-4b27-4ba2-a16d-bb5fa953c166")]
	public interface nsISearchEngine
	{
		
		/// <summary>
        /// Gets a nsISearchSubmission object that contains information about what to
        /// send to the search engine, including the URI and postData, if applicable.
        ///
        /// @param  data
        /// Data to add to the submission object.
        /// i.e. the search terms.
        ///
        /// @param  responseType [optional]
        /// The MIME type that we'd like to receive in response
        /// to this submission.  If null, will default to "text/html".
        ///
        /// @returns A nsISearchSubmission object that contains information about what
        /// to send to the search engine.  If no submission can be
        /// obtained for the given responseType, returns null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISearchSubmission GetSubmission([MarshalAs(UnmanagedType.LPStruct)] nsAString data, [MarshalAs(UnmanagedType.LPStruct)] nsAString responseType);
		
		/// <summary>
        /// Adds a parameter to the search engine's submission data. This should only
        /// be called on engines created via addEngineWithDetails.
        ///
        /// @param name
        /// The parameter's name. Must not be null.
        ///
        /// @param value
        /// The value to pass. If value is "{searchTerms}", it will be
        /// substituted with the user-entered data when retrieving the
        /// submission. Must not be null.
        ///
        /// @param responseType
        /// Since an engine can have several different request URLs,
        /// differentiated by response types, this parameter selects
        /// a request to add parameters to.  If null, will default
        /// to "text/html"
        ///
        /// @throws NS_ERROR_FAILURE if the search engine is read-only.
        /// @throws NS_ERROR_INVALID_ARG if name or value are null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddParam([MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.LPStruct)] nsAString value, [MarshalAs(UnmanagedType.LPStruct)] nsAString responseType);
		
		/// <summary>
        /// Determines whether the engine can return responses in the given
        /// MIME type.  Returns true if the engine spec has a URL with the
        /// given responseType, false otherwise.
        ///
        /// @param responseType
        /// The MIME type to check for
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SupportsResponseType([MarshalAs(UnmanagedType.LPStruct)] nsAString responseType);
		
		/// <summary>
        /// An optional shortcut alias for the engine.
        /// When non-null, this is a unique identifier.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAliasAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAlias);
		
		/// <summary>
        /// An optional shortcut alias for the engine.
        /// When non-null, this is a unique identifier.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAliasAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAlias);
		
		/// <summary>
        /// A text description describing the engine.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDescription);
		
		/// <summary>
        /// Whether the engine should be hidden from the user.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHiddenAttribute();
		
		/// <summary>
        /// Whether the engine should be hidden from the user.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHiddenAttribute([MarshalAs(UnmanagedType.Bool)] bool aHidden);
		
		/// <summary>
        /// A nsIURI corresponding to the engine's icon, stored locally. May be null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetIconURIAttribute();
		
		/// <summary>
        /// The display name of the search engine. This is a unique identifier.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>
        /// A URL string pointing to the engine's search form.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSearchFormAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSearchForm);
		
		/// <summary>
        /// The search engine type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTypeAttribute();
	}
	
	/// <summary>nsIBrowserSearchService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8307b8f2-08ea-45b8-96bf-b1dc7688fe3b")]
	public interface nsIBrowserSearchService
	{
		
		/// <summary>
        /// Adds a new search engine from the file at the supplied URI, optionally
        /// asking the user for confirmation first.  If a confirmation dialog is
        /// shown, it will offer the option to begin using the newly added engine
        /// right away; if no confirmation dialog is shown, the new engine will be
        /// used right away automatically.
        ///
        /// @param engineURL
        /// The URL to the search engine's description file.
        ///
        /// @param dataType
        /// An integer representing the plugin file format. Must be one
        /// of the supported search engine data types defined above.
        ///
        /// @param iconURL
        /// A URL string to an icon file to be used as the search engine's
        /// icon. This value may be overridden by an icon specified in the
        /// engine description file.
        ///
        /// @param confirm
        /// A boolean value indicating whether the user should be asked for
        /// confirmation before this engine is added to the list.  If this
        /// value is false, the engine will be added to the list upon successful
        /// load, but it will not be selected as the current engine.
        ///
        /// @throws NS_ERROR_FAILURE if the type is invalid, or if the description
        /// file cannot be successfully loaded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEngine([MarshalAs(UnmanagedType.LPStruct)] nsAString engineURL, int dataType, [MarshalAs(UnmanagedType.LPStruct)] nsAString iconURL, [MarshalAs(UnmanagedType.Bool)] bool confirm);
		
		/// <summary>
        /// Adds a new search engine, without asking the user for confirmation and
        /// without starting to use it right away.
        ///
        /// @param name
        /// The search engine's name. Must be unique. Must not be null.
        ///
        /// @param iconURL
        /// Optional: A URL string pointing to the icon to be used to represent
        /// the engine.
        ///
        /// @param alias
        /// Optional: A unique shortcut that can be used to retrieve the
        /// search engine.
        ///
        /// @param description
        /// Optional: a description of the search engine.
        ///
        /// @param method
        /// The HTTP request method used when submitting a search query.
        /// Must be a case insensitive value of either "get" or "post".
        ///
        /// @param url
        /// The URL to which search queries should be sent.
        /// Must not be null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEngineWithDetails([MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.LPStruct)] nsAString iconURL, [MarshalAs(UnmanagedType.LPStruct)] nsAString alias, [MarshalAs(UnmanagedType.LPStruct)] nsAString description, [MarshalAs(UnmanagedType.LPStruct)] nsAString method, [MarshalAs(UnmanagedType.LPStruct)] nsAString url);
		
		/// <summary>
        /// Un-hides all engines installed in the directory corresponding to
        /// the directory service's NS_APP_SEARCH_DIR key. (i.e. the set of
        /// engines returned by getDefaultEngines)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RestoreDefaultEngines();
		
		/// <summary>
        /// Returns an engine with the specified alias.
        ///
        /// @param   alias
        /// The search engine's alias.
        /// @returns The corresponding nsISearchEngine object, or null if it doesn't
        /// exist.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISearchEngine GetEngineByAlias([MarshalAs(UnmanagedType.LPStruct)] nsAString alias);
		
		/// <summary>
        /// Returns an engine with the specified name.
        ///
        /// @param   aEngineName
        /// The name of the engine.
        /// @returns The corresponding nsISearchEngine object, or null if it doesn't
        /// exist.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISearchEngine GetEngineByName([MarshalAs(UnmanagedType.LPStruct)] nsAString aEngineName);
		
		/// <summary>
        /// Returns an array of all installed search engines.
        ///
        /// @returns an array of nsISearchEngine objects.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEngines(ref uint engineCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref nsISearchEngine[] engines);
		
		/// <summary>
        /// Returns an array of all installed search engines whose hidden attribute is
        /// false.
        ///
        /// @returns an array of nsISearchEngine objects.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVisibleEngines(ref uint engineCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref nsISearchEngine[] engines);
		
		/// <summary>
        /// Returns an array of all default search engines. This includes all loaded
        /// engines that aren't in the user's profile directory
        /// (NS_APP_USER_SEARCH_DIR).
        ///
        /// @returns an array of nsISearchEngine objects.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDefaultEngines(ref uint engineCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref nsISearchEngine[] engines);
		
		/// <summary>
        /// Moves a visible search engine.
        ///
        /// @param  engine
        /// The engine to move.
        /// @param  newIndex
        /// The engine's new index in the set of visible engines.
        ///
        /// @throws NS_ERROR_FAILURE if newIndex is out of bounds, or if engine is
        /// hidden.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MoveEngine([MarshalAs(UnmanagedType.Interface)] nsISearchEngine engine, int newIndex);
		
		/// <summary>
        /// Removes the search engine. If the search engine is installed in a global
        /// location, this will just hide the engine. If the engine is in the user's
        /// profile directory, it will be removed from disk.
        ///
        /// @param  engine
        /// The engine to remove.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveEngine([MarshalAs(UnmanagedType.Interface)] nsISearchEngine engine);
		
		/// <summary>
        /// The default search engine. Returns the first visible engine if the default
        /// engine is hidden. May be null if there are no visible search engines.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISearchEngine GetDefaultEngineAttribute();
		
		/// <summary>
        /// The currently active search engine. May be null if there are no visible
        /// search engines.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISearchEngine GetCurrentEngineAttribute();
		
		/// <summary>
        /// The currently active search engine. May be null if there are no visible
        /// search engines.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCurrentEngineAttribute([MarshalAs(UnmanagedType.Interface)] nsISearchEngine aCurrentEngine);
		
		/// <summary>
        /// The original default engine. This differs from the "defaultEngine"
        /// attribute in that it always returns a given build's default engine,
        /// regardless of whether it is hidden.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISearchEngine GetOriginalDefaultEngineAttribute();
	}
}
