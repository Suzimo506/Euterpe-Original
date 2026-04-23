using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200002F")]
public class GameAudioVisualization : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E6")]
	public float power;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x1C")]
	public float upSpeed;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E8")]
	public float downSpeed;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000E9")]
	public float baseN;

	[Token(Token = "0x40000EA")]
	public const int LENGTH = 32;

	[Token(Token = "0x40000EB")]
	public static float[] _samples;

	[Token(Token = "0x40000EC")]
	public static float[] _freqBand;

	[Token(Token = "0x40000ED")]
	public static float[] _bandBuffer;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x28")]
	private float[] _bufferDecrease;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000EF")]
	private float[] _freqBandHighrst;

	[Token(Token = "0x40000F0")]
	public static float[] _audioBand;

	[Token(Token = "0x40000F1")]
	public static float[] _audioBandBuffer;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000F2")]
	private DBOther m_DbOther;

	[Address(RVA = "0x840F60", Offset = "0x83F760", Length = "0xAB")]
	[Token(Token = "0x6000111")]
	private void Awake()
	{
	}

	[Address(RVA = "0x841570", Offset = "0x83FD70", Length = "0x259")]
	[Token(Token = "0x6000112")]
	private void FixedUpdate()
	{
	}

	[Address(RVA = "0x8412E0", Offset = "0x83FAE0", Length = "0x287")]
	[Token(Token = "0x6000113")]
	private void CreateAudioBands()
	{
	}

	[Address(RVA = "0x8417D0", Offset = "0x83FFD0", Length = "0x99")]
	[Token(Token = "0x6000114")]
	private void GetSpectrumAudiosource()
	{
	}

	[Address(RVA = "0x841010", Offset = "0x83F810", Length = "0x2C7")]
	[Token(Token = "0x6000115")]
	private void BandBuffer()
	{
	}

	[Address(RVA = "0x841870", Offset = "0x840070", Length = "0x1A5")]
	[Token(Token = "0x6000116")]
	private void MakeFrequencyBands()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x841B30", Offset = "0x840330", Length = "0x8F")]
	public GameAudioVisualization()
	{
	}
}
