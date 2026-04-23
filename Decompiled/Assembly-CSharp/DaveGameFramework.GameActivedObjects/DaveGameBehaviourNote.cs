using Cpp2ILInjected;

namespace DaveGameFramework.GameActivedObjects;

[Token(Token = "0x20004D7")]
public class DaveGameBehaviourNote : DaveGameNote
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A63")]
	private float m_ActiveDelayTime;

	[Token(Token = "0x170004FA")]
	public float ActiveDelayTime
	{
		[Token(Token = "0x60035FF")]
		[Address(RVA = "0x46DDA0", Offset = "0x46C5A0", Length = "0x6")]
		get
		{
			return default(float);
		}
		[Address(RVA = "0x46DDB0", Offset = "0x46C5B0", Length = "0x6")]
		[Token(Token = "0x6003600")]
		set
		{
		}
	}

	[Address(RVA = "0x46DBC0", Offset = "0x46C3C0", Length = "0x13")]
	[Token(Token = "0x6003601")]
	public override void ExcuteNoteAction()
	{
	}

	[Token(Token = "0x6003602")]
	[Address(RVA = "0x46DBE0", Offset = "0x46C3E0", Length = "0x1A4")]
	public override void OnFixedUpdate()
	{
	}

	[Token(Token = "0x6003603")]
	[Address(RVA = "0x46DD90", Offset = "0x46C590", Length = "0xE")]
	public DaveGameBehaviourNote()
	{
	}
}
