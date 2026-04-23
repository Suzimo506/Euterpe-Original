using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000742")]
public class HeadManager : Singleton<HeadManager>
{
	[Token(Token = "0x4002641")]
	[FieldOffset(Offset = "0x10")]
	private List<HeadInfo> m_AllHeadInfos;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002642")]
	private DBConfigHead heads;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002643")]
	private int lastLevel;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002644")]
	private List<HeadInfo> m_DropHeadPool;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002645")]
	private int[] m_DropHeadWeights;

	[Token(Token = "0x17000659")]
	private List<IData> m_HeadItems
	{
		[Token(Token = "0x600438A")]
		[Address(RVA = "0x7944F0", Offset = "0x792CF0", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600438B")]
	[Address(RVA = "0x793AE0", Offset = "0x7922E0", Length = "0xD3")]
	private void Init()
	{
	}

	[Token(Token = "0x600438C")]
	[Address(RVA = "0x794060", Offset = "0x792860", Length = "0x162")]
	private int RefreshDropHeadPool()
	{
		return default(int);
	}

	[Token(Token = "0x600438D")]
	[Address(RVA = "0x793700", Offset = "0x791F00", Length = "0x1FD")]
	public void CheckAndUnlockHead()
	{
	}

	[Token(Token = "0x600438E")]
	[Address(RVA = "0x7932F0", Offset = "0x791AF0", Length = "0x1C2")]
	public void AddRandomDropHead(bool force = false)
	{
	}

	[Token(Token = "0x600438F")]
	[Address(RVA = "0x792EC0", Offset = "0x7916C0", Length = "0x42F")]
	public void AddHeadItem(int listIndex, bool isUnlock, bool isNew = true)
	{
	}

	[Token(Token = "0x6004390")]
	[Address(RVA = "0x793DE0", Offset = "0x7925E0", Length = "0x270")]
	public bool IsHeadUnlock(int imageIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0x793BC0", Offset = "0x7923C0", Length = "0x215")]
	[Token(Token = "0x6004391")]
	public bool IsHeadNew(int imageIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6004392")]
	[Address(RVA = "0x7941D0", Offset = "0x7929D0", Length = "0x204")]
	public void SetHeadOld(int listIndex)
	{
	}

	[Token(Token = "0x6004393")]
	[Address(RVA = "0x7934C0", Offset = "0x791CC0", Length = "0x23A")]
	public void CancelNewImage()
	{
	}

	[Address(RVA = "0x793900", Offset = "0x792100", Length = "0x1D4")]
	[Token(Token = "0x6004394")]
	public bool CheckHasNewHead()
	{
		return default(bool);
	}

	[Address(RVA = "0x7943E0", Offset = "0x792BE0", Length = "0x106")]
	[Token(Token = "0x6004395")]
	public HeadManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
