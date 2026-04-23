using Cpp2ILInjected;
using UnityEngine;
using rail;

[Token(Token = "0x2000075")]
[DisallowMultipleComponent]
public class RailManager : MonoBehaviour
{
	[Token(Token = "0x4000325")]
	private static RailManager instance_;

	[Token(Token = "0x4000326")]
	private static bool ever_initialize_;

	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x18")]
	private bool initialized_;

	[Token(Token = "0x17000067")]
	private static RailManager Instance
	{
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x56B870", Offset = "0x56A070", Length = "0xB7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000068")]
	public static bool Initialized
	{
		[Address(RVA = "0x56B7B0", Offset = "0x569FB0", Length = "0xBD")]
		[Token(Token = "0x6000383")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x56B1C0", Offset = "0x5699C0", Length = "0x359")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x56B6B0", Offset = "0x569EB0", Length = "0x9F")]
	public void OnRailEvent(RAILEventID id, EventBase data)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x56B620", Offset = "0x569E20", Length = "0x8C")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x56B520", Offset = "0x569D20", Length = "0xF4")]
	[Token(Token = "0x6000387")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x56B750", Offset = "0x569F50", Length = "0x5A")]
	[Token(Token = "0x6000388")]
	private void Update()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public RailManager()
	{
	}
}
