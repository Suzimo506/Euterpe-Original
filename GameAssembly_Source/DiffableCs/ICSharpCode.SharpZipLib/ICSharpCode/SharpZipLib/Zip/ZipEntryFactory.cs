namespace ICSharpCode.SharpZipLib.Zip;

public class ZipEntryFactory : IEntryFactory
{
	private INameTransform nameTransform_; //Field offset: 0x10
	private DateTime fixedDateTime_; //Field offset: 0x18
	private int getAttributes_; //Field offset: 0x20

	public ZipEntryFactory() { }

}

