﻿//-----------------------------------------------------------------------------
//
//	This code was generated by a ResourceWrapper.Generator Version 4.0.0.0.
//
//	Changes to this file may cause incorrect behavior and will be lost if
//	the code is regenerated.
//
//-----------------------------------------------------------------------------

namespace ItemWrapper.Generator {
	using System;
	using System.Diagnostics;
	using System.Globalization;
	using System.Runtime.CompilerServices;
	using System.ComponentModel;
	using System.Resources;
	using System.Windows;

	/// <summary>
	/// A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	// This class was auto-generated.
	// To add or remove a member, edit your .ResX file then rerun MsBuild,
	// or rebuild your VS project.
	[DebuggerNonUserCodeAttribute()]
	[CompilerGeneratedAttribute()]
	internal static class TextMessage {

		/// <summary>
		/// Overrides the current thread's CurrentUICulture property for all
		/// resource lookups using this strongly typed resource class.
		/// </summary>
		[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture { get; set; }

		/// <summary>
		/// Used for formating of the resource strings. Usually same as CultureInfo.CurrentCulture.
		/// </summary>
		[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
		public static CultureInfo FormatCulture { get; set; }

		/// <summary>
		/// Gets FlowDirection for current culture.
		/// </summary>
		public static FlowDirection FlowDirection {
			get {
				bool isRightToLeft;
				if(TextMessage.Culture != null && TextMessage.Culture.TextInfo != null) {
					isRightToLeft = TextMessage.Culture.TextInfo.IsRightToLeft;
				} else if(CultureInfo.CurrentUICulture != null && CultureInfo.CurrentUICulture.TextInfo != null) {
					isRightToLeft = CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft;
				} else if(CultureInfo.CurrentCulture != null && CultureInfo.CurrentCulture.TextInfo != null) {
					isRightToLeft = CultureInfo.CurrentCulture.TextInfo.IsRightToLeft;
				} else {
					isRightToLeft = false;
				}
				return isRightToLeft ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
			}
		}

		private static ResourceManager resourceManager;

		/// <summary>
		/// Returns the cached ResourceManager instance used by this class.
		/// </summary>
		[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
		public static ResourceManager ResourceManager {
			get {
				if(resourceManager == null) {
					resourceManager = new ResourceManager("ItemWrapper.Generator.TextMessage", typeof(TextMessage).Assembly);
				}
				return resourceManager;
			}
		}

		/// <summary>
		/// Looks up a localized string similar to {0} is missing..
		/// </summary>
 		public static string ArgumentMissing(string argument) {
			return string.Format(FormatCulture, ResourceManager.GetString("ArgumentMissing", Culture), argument);
		}

		/// <summary>
		/// Looks up a localized string similar to {0} already defined..
		/// </summary>
 		public static string ArgumentRedefinition(string argument) {
			return string.Format(FormatCulture, ResourceManager.GetString("ArgumentRedefinition", Culture), argument);
		}

		/// <summary>
		/// Looks up a localized string similar to Realm item generation complete witout errors..
		/// </summary>
 		public static string ReportSuccess {
			get { return ResourceManager.GetString("ReportSuccess", Culture); }
		}

		/// <summary>
		/// Looks up a localized string similar to Schema file "{0}" does not exist..
		/// </summary>
 		public static string SchemaFileMissing(string file) {
			return string.Format(FormatCulture, ResourceManager.GetString("SchemaFileMissing", Culture), file);
		}

		/// <summary>
		/// Looks up a localized string similar to Target folder "{0}" does not exist..
		/// </summary>
 		public static string TargetFolderMissing(string folder) {
			return string.Format(FormatCulture, ResourceManager.GetString("TargetFolderMissing", Culture), folder);
		}

		/// <summary>
		/// Looks up a localized string similar to {0} unknown argument..
		/// </summary>
 		public static string UnknownArgument(string argument) {
			return string.Format(FormatCulture, ResourceManager.GetString("UnknownArgument", Culture), argument);
		}

		/// <summary>
		/// Looks up a localized string similar to ItemWrapper.Generator OPTIONS
		/// OPTIONS are:.
		/// </summary>
 		public static string Usage {
			get { return ResourceManager.GetString("Usage", Culture); }
		}
	}
}
