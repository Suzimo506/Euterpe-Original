namespace System.ComponentModel;

public class UInt32Converter : BaseNumberConverter
{

	internal virtual Type TargetType
	{
		internal get { } //Length: 85
	}

	public UInt32Converter() { }

	internal virtual object FromString(string value, int radix) { }

	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	internal virtual object FromString(string value, CultureInfo culture) { }

	internal virtual Type get_TargetType() { }

	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

