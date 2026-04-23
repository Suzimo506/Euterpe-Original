using Cpp2ILInjected;

namespace DaveGameFramework.GameActivedObjects;

[Token(Token = "0x20004D8")]
public class DaveGameJudgedNote : DaveGameNote
{
	[Token(Token = "0x6003604")]
	[Address(RVA = "0x46DF50", Offset = "0x46C750", Length = "0x19A")]
	public virtual void JudgeNote()
	{
	}

	[Token(Token = "0x6003605")]
	[Address(RVA = "0x46DBC0", Offset = "0x46C3C0", Length = "0x13")]
	public override void ExcuteNoteAction()
	{
	}

	[Token(Token = "0x6003606")]
	[Address(RVA = "0x46E0F0", Offset = "0x46C8F0", Length = "0x25F")]
	public override void OnFixedUpdate()
	{
	}

	[Token(Token = "0x6003607")]
	[Address(RVA = "0x46DDC0", Offset = "0x46C5C0", Length = "0x184")]
	private int GetNoteJudgeResult()
	{
		return default(int);
	}

	[Token(Token = "0x6003608")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public DaveGameJudgedNote()
	{
	}
}
