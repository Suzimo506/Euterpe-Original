namespace ICSharpCode.SharpZipLib.Encryption;

internal class PkzipClassicDecryptCryptoTransform : PkzipClassicCryptoBase, ICryptoTransform, IDisposable
{

	public override bool CanReuseTransform
	{
		 get { } //Length: 3
	}

	public override bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public override int InputBlockSize
	{
		 get { } //Length: 6
	}

	public override int OutputBlockSize
	{
		 get { } //Length: 6
	}

	internal PkzipClassicDecryptCryptoTransform(Byte[] keyBlock) { }

	public override void Dispose() { }

	public override bool get_CanReuseTransform() { }

	public override bool get_CanTransformMultipleBlocks() { }

	public override int get_InputBlockSize() { }

	public override int get_OutputBlockSize() { }

	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

