using Cpp2ILInjected;
using DaveGameFramework.GameComponents;

namespace DaveGameFramework.GameActivedObjects.DaveGameNoteInstances;

[Token(Token = "0x20004DC")]
public class DaveGameNote_CutFishHeavy : DaveGameJudgedNote
{
	[Token(Token = "0x4001A67")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsReady;

	[Token(Token = "0x600361B")]
	[Address(RVA = "0x46FB30", Offset = "0x46E330", Length = "0x6F3")]
	public override void OnFixedUpdate()
	{
	}

	[Token(Token = "0x600361C")]
	[Address(RVA = "0x46F3E0", Offset = "0x46DBE0", Length = "0x605")]
	public override void JudgeNote()
	{
	}

	[Address(RVA = "0x46F9F0", Offset = "0x46E1F0", Length = "0x13A")]
	[Token(Token = "0x600361D")]
	private void OnCharacterHit(DaveGameCharacter character)
	{
	}

	[Address(RVA = "0x470280", Offset = "0x46EA80", Length = "0x264")]
	[Token(Token = "0x600361E")]
	private void SetHeavyHitNoteResult()
	{
	}

	[Address(RVA = "0x470230", Offset = "0x46EA30", Length = "0x41")]
	[Token(Token = "0x600361F")]
	public override void ResetNoteState()
	{
	}

	[Token(Token = "0x6003620")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public DaveGameNote_CutFishHeavy()
	{
	}
}
