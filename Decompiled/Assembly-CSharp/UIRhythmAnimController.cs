using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200019C")]
public class UIRhythmAnimController : SingletonMonoBehaviour<UIRhythmAnimController>, IPause
{
	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x18")]
	public GameObject rdStopAim;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A35")]
	public GameObject rdPhoneTipsAim;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A36")]
	public GameObject rdMistakeAim;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A37")]
	public GameObject rdPhoneTipsOlaAim;

	[Token(Token = "0x4000A38")]
	[FieldOffset(Offset = "0x38")]
	private bool isOnStopAim;

	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x39")]
	private bool isOnPhoneTipsAim;

	[Token(Token = "0x4000A3A")]
	[FieldOffset(Offset = "0x3A")]
	private bool isOnOlaPhoneTipsAim;

	[Token(Token = "0x170000E3")]
	public bool IsGlobal
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x6000BC3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0x4E6230", Offset = "0x4E4A30", Length = "0xB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x4E6030", Offset = "0x4E4830", Length = "0x2F")]
	public void PlayStopAnim()
	{
	}

	[Address(RVA = "0x4E5FD0", Offset = "0x4E47D0", Length = "0x2F")]
	[Token(Token = "0x6000BBF")]
	public void PlayPhoneTipsAnim()
	{
	}

	[Address(RVA = "0x4E5F90", Offset = "0x4E4790", Length = "0x39")]
	[Token(Token = "0x6000BC0")]
	public void PlayMistakeAnim()
	{
	}

	[Address(RVA = "0x4E6000", Offset = "0x4E4800", Length = "0x2F")]
	[Token(Token = "0x6000BC1")]
	public void PlayPhoneTipsOlaAnim()
	{
	}

	[Address(RVA = "0x4E60E0", Offset = "0x4E48E0", Length = "0x147")]
	[Token(Token = "0x6000BC2")]
	public void SetPause(bool isRun = true)
	{
	}

	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0x4E5F10", Offset = "0x4E4710", Length = "0x75")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6000BC5")]
	[Address(RVA = "0x4E6060", Offset = "0x4E4860", Length = "0x75")]
	public void Resume()
	{
	}

	[Address(RVA = "0x4E5EA0", Offset = "0x4E46A0", Length = "0x62")]
	[Token(Token = "0x6000BC6")]
	private bool NeedPause()
	{
		return default(bool);
	}

	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0x4E62F0", Offset = "0x4E4AF0", Length = "0x38")]
	public UIRhythmAnimController()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
