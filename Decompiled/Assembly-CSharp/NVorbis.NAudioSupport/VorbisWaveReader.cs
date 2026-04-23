using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NAudio.Wave;

namespace NVorbis.NAudioSupport;

[Token(Token = "0x20001DC")]
internal class VorbisWaveReader : WaveStream, IDisposable, ISampleProvider, IWaveProvider
{
	[Token(Token = "0x4000BBE")]
	[FieldOffset(Offset = "0x28")]
	private VorbisReader _reader;

	[Token(Token = "0x4000BBF")]
	[FieldOffset(Offset = "0x30")]
	private WaveFormat _waveFormat;

	[ThreadStatic]
	[Token(Token = "0x4000BC0")]
	private static float[] _conversionBuffer;

	[Token(Token = "0x170000FD")]
	public override WaveFormat WaveFormat
	{
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		[Token(Token = "0x6000D84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000FE")]
	public override long Length
	{
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x881F80", Offset = "0x880780", Length = "0x68")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x170000FF")]
	public override long Position
	{
		[Address(RVA = "0x882030", Offset = "0x880830", Length = "0x92")]
		[Token(Token = "0x6000D86")]
		get
		{
			return default(long);
		}
		[Address(RVA = "0x882220", Offset = "0x880A20", Length = "0x12E")]
		[Token(Token = "0x6000D87")]
		set
		{
		}
	}

	[Token(Token = "0x17000100")]
	public bool IsParameterChange
	{
		[Address(RVA = "0x881F60", Offset = "0x880760", Length = "0x1D")]
		[Token(Token = "0x6000D8A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000101")]
	public int StreamCount
	{
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x8820F0", Offset = "0x8808F0", Length = "0x1D")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000102")]
	public int? NextStreamIndex
	{
		[Token(Token = "0x6000D8D")]
		[CompilerGenerated]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x882210", Offset = "0x880A10", Length = "0x5")]
		set
		{
		}
	}

	[Token(Token = "0x17000103")]
	public int CurrentStream
	{
		[Address(RVA = "0x881F40", Offset = "0x880740", Length = "0x1A")]
		[Token(Token = "0x6000D90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x882150", Offset = "0x880950", Length = "0xB3")]
		set
		{
		}
	}

	[Token(Token = "0x17000104")]
	public int UpperBitrate
	{
		[Address(RVA = "0x882110", Offset = "0x880910", Length = "0x1D")]
		[Token(Token = "0x6000D92")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000105")]
	public int NominalBitrate
	{
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x882010", Offset = "0x880810", Length = "0x1D")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000106")]
	public int LowerBitrate
	{
		[Address(RVA = "0x881FF0", Offset = "0x8807F0", Length = "0x1D")]
		[Token(Token = "0x6000D94")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000107")]
	public string Vendor
	{
		[Address(RVA = "0x882130", Offset = "0x880930", Length = "0x1D")]
		[Token(Token = "0x6000D95")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000108")]
	public string[] Comments
	{
		[Address(RVA = "0x881F00", Offset = "0x880700", Length = "0x1D")]
		[Token(Token = "0x6000D96")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000109")]
	public long ContainerOverheadBits
	{
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x881F20", Offset = "0x880720", Length = "0x1D")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700010A")]
	public IVorbisStreamStatus[] Stats
	{
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x8820D0", Offset = "0x8808D0", Length = "0x1D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000D81")]
	[Address(RVA = "0x881E40", Offset = "0x880640", Length = "0xB8")]
	public VorbisWaveReader(string fileName)
	{
	}

	[Address(RVA = "0x881D80", Offset = "0x880580", Length = "0xBB")]
	[Token(Token = "0x6000D82")]
	public VorbisWaveReader(Stream sourceStream)
	{
	}

	[Token(Token = "0x6000D83")]
	[Address(RVA = "0x881AB0", Offset = "0x8802B0", Length = "0x59")]
	protected override void Dispose(bool disposing)
	{
	}

	[Address(RVA = "0x881BB0", Offset = "0x8803B0", Length = "0x19A")]
	[Token(Token = "0x6000D88")]
	public override int Read(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x881D50", Offset = "0x880550", Length = "0x24")]
	public int Read(float[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x881A90", Offset = "0x880290", Length = "0x1D")]
	public void ClearParameterChange()
	{
	}

	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x881B10", Offset = "0x880310", Length = "0x9F")]
	public bool GetNextStreamIndex()
	{
		return default(bool);
	}
}
