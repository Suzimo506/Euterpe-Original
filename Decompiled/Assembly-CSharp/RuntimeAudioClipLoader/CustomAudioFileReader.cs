using System.IO;
using Cpp2ILInjected;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace RuntimeAudioClipLoader;

[Token(Token = "0x20001DE")]
internal class CustomAudioFileReader : WaveStream, ISampleProvider
{
	[Token(Token = "0x4000BC8")]
	[FieldOffset(Offset = "0x28")]
	private WaveStream readerStream;

	[Token(Token = "0x4000BC9")]
	[FieldOffset(Offset = "0x30")]
	private readonly SampleChannel sampleChannel;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BCA")]
	private readonly int destBytesPerSample;

	[Token(Token = "0x4000BCB")]
	[FieldOffset(Offset = "0x3C")]
	private readonly int sourceBytesPerSample;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BCC")]
	private readonly long length;

	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0x48")]
	private readonly object lockObject;

	[Token(Token = "0x1700010B")]
	public override WaveFormat WaveFormat
	{
		[Address(RVA = "0x61F4F0", Offset = "0x61DCF0", Length = "0x1B")]
		[Token(Token = "0x6000D9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700010C")]
	public override long Length
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x6000D9D")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700010D")]
	public override long Position
	{
		[Address(RVA = "0x61F490", Offset = "0x61DC90", Length = "0x3E")]
		[Token(Token = "0x6000D9E")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x61F510", Offset = "0x61DD10", Length = "0xBB")]
		set
		{
		}
	}

	[Token(Token = "0x1700010E")]
	public float Volume
	{
		[Address(RVA = "0x61F4D0", Offset = "0x61DCD0", Length = "0x1D")]
		[Token(Token = "0x6000DA2")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x61F5D0", Offset = "0x61DDD0", Length = "0x1E")]
		set
		{
		}
	}

	[Address(RVA = "0x61F310", Offset = "0x61DB10", Length = "0x17B")]
	[Token(Token = "0x6000D9A")]
	public CustomAudioFileReader(Stream stream, AudioFormat format)
	{
	}

	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0x61EED0", Offset = "0x61D6D0", Length = "0x203")]
	private void CreateReaderStream(Stream stream, AudioFormat format)
	{
	}

	[Address(RVA = "0x61F160", Offset = "0x61D960", Length = "0xB7")]
	[Token(Token = "0x6000DA0")]
	public override int Read(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6000DA1")]
	[Address(RVA = "0x61F220", Offset = "0x61DA20", Length = "0xCF")]
	public int Read(float[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Address(RVA = "0x61F2F0", Offset = "0x61DAF0", Length = "0x15")]
	[Token(Token = "0x6000DA4")]
	private long SourceToDest(long sourceBytes)
	{
		return default(long);
	}

	[Address(RVA = "0x61F0E0", Offset = "0x61D8E0", Length = "0x15")]
	[Token(Token = "0x6000DA5")]
	private long DestToSource(long destBytes)
	{
		return default(long);
	}

	[Address(RVA = "0x61F100", Offset = "0x61D900", Length = "0x59")]
	[Token(Token = "0x6000DA6")]
	protected override void Dispose(bool disposing)
	{
	}
}
