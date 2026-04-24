namespace System;

internal static class SR
{
	private static ResourceManager s_resourceManager; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly Type <ResourceType>k__BackingField; //Field offset: 0x8

	internal static string Argument_DestinationTooShort
	{
		internal get { } //Length: 82
	}

	internal static string Argument_InvalidTypeWithPointersNotSupported
	{
		internal get { } //Length: 82
	}

	internal static string EndPositionNotReached
	{
		internal get { } //Length: 82
	}

	internal static string NotSupported_CannotCallEqualsOnSpan
	{
		internal get { } //Length: 82
	}

	internal static string NotSupported_CannotCallGetHashCodeOnSpan
	{
		internal get { } //Length: 82
	}

	private static ResourceManager ResourceManager
	{
		private get { } //Length: 273
	}

	internal static Type ResourceType
	{
		[CompilerGenerated]
		internal get { } //Length: 87
	}

	private static SR() { }

	internal static string Format(string resourceFormat, object p1) { }

	internal static string get_Argument_DestinationTooShort() { }

	internal static string get_Argument_InvalidTypeWithPointersNotSupported() { }

	internal static string get_EndPositionNotReached() { }

	internal static string get_NotSupported_CannotCallEqualsOnSpan() { }

	internal static string get_NotSupported_CannotCallGetHashCodeOnSpan() { }

	private static ResourceManager get_ResourceManager() { }

	[CompilerGenerated]
	internal static Type get_ResourceType() { }

	internal static string GetResourceString(string resourceKey, string defaultString) { }

	private static bool UsingResourceKeys() { }

}

