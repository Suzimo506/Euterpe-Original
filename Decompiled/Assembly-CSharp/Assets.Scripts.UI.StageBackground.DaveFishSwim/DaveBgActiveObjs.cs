using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.StageBackground.DaveFishSwim;

[Token(Token = "0x2000847")]
public abstract class DaveBgActiveObjs : MonoBehaviour
{
	[Token(Token = "0x4002B37")]
	[FieldOffset(Offset = "0x18")]
	protected DaveFishData m_Data;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002B38")]
	protected DaveBgFishGroupManage m_FishManager;

	[Token(Token = "0x17000858")]
	public DaveFishData FishData
	{
		[Token(Token = "0x6004C11")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004C12")]
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x6004C13")]
	[Address(RVA = "0x60C820", Offset = "0x60B020", Length = "0x2F")]
	public void Initialize(DaveBgFishGroupManage manager)
	{
	}

	[Token(Token = "0x6004C14")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void OnInitialize();

	[Token(Token = "0x6004C15")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	protected DaveBgActiveObjs()
	{
	}
}
