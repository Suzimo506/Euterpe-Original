using Cpp2ILInjected;
using GameLogic;

namespace DaveGameFramework.GameInstanceData;

[Token(Token = "0x20004BD")]
public class DaveGameNoteData
{
	[Token(Token = "0x40019D7")]
	[FieldOffset(Offset = "0x10")]
	private MusicData m_MusicData;

	[Token(Token = "0x40019D8")]
	[FieldOffset(Offset = "0x170")]
	private DaveNoteGameData m_NoteGameData;

	[Token(Token = "0x170004E7")]
	public MusicData MusicData
	{
		[Token(Token = "0x600356A")]
		[Address(RVA = "0x441AF0", Offset = "0x4402F0", Length = "0xA3")]
		get
		{
			return default(MusicData);
		}
	}

	[Token(Token = "0x170004E8")]
	public DaveNoteGameData NoteGameData
	{
		[Token(Token = "0x600356B")]
		[Address(RVA = "0x998050", Offset = "0x996850", Length = "0x8")]
		get
		{
			return default(DaveNoteGameData);
		}
		[Token(Token = "0x600356C")]
		[Address(RVA = "0x998060", Offset = "0x996860", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x600356D")]
	[Address(RVA = "0x997F70", Offset = "0x996770", Length = "0xBD")]
	public void InitNoteData(MusicData musicData)
	{
	}

	[Address(RVA = "0x998040", Offset = "0x996840", Length = "0x7")]
	[Token(Token = "0x600356E")]
	public void SetNoteResult(int result)
	{
	}

	[Address(RVA = "0x998030", Offset = "0x996830", Length = "0xB")]
	[Token(Token = "0x600356F")]
	public void ResetNoteState()
	{
	}

	[Token(Token = "0x6003570")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DaveGameNoteData()
	{
	}
}
