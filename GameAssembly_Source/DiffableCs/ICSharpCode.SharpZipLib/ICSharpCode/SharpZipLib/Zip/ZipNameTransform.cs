namespace ICSharpCode.SharpZipLib.Zip;

public class ZipNameTransform : INameTransform
{
	private static readonly Char[] InvalidEntryChars; //Field offset: 0x0
	private static readonly Char[] InvalidEntryCharsRelaxed; //Field offset: 0x8

	private static ZipNameTransform() { }

	public ZipNameTransform() { }

	public static bool IsValidName(string name, bool relaxed) { }

}

