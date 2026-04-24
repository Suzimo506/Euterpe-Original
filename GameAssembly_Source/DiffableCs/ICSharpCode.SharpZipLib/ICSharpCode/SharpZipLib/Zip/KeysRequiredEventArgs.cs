namespace ICSharpCode.SharpZipLib.Zip;

public class KeysRequiredEventArgs : EventArgs
{
	private string fileName; //Field offset: 0x10
	private Byte[] key; //Field offset: 0x18

	public Byte[] Key
	{
		 get { } //Length: 5
	}

	public KeysRequiredEventArgs(string name, Byte[] keyValue) { }

	public Byte[] get_Key() { }

}

