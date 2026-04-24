namespace FlexFramework.Excel;

public sealed class ColorConverter : CustomConverter<Color>
{

	public ColorConverter() { }

	public static string ColorToHex(Color color) { }

	public virtual Color Convert(string input) { }

	public static Color HexToColor(string hex) { }

}

