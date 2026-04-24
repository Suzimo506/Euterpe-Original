using System.Collections;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200016D")]
public class PnlUnlock : MonoBehaviour
{
	[Token(Token = "0x4000900")]
	[FieldOffset(Offset = "0x18")]
	public PnlLevelUpAward pnlLevelUpAward;

	[Token(Token = "0x4000901")]
	[FieldOffset(Offset = "0x20")]
	public PnlItemAward pnlItemAward;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000902")]
	public PnlUnlockStage pnlUnlockStage;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000903")]
	public GameObject pnlAwardFly;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000904")]
	public GameObject parFlyAwardCoin;

	[Token(Token = "0x4000905")]
	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	private Image m_InputMask;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000906")]
	private bool m_IsLockMaskState;

	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x4000907")]
	private bool m_IsJumpLeveling;

	[Token(Token = "0x6000A72")]
	[Address(RVA = "0x566360", Offset = "0x564B60", Length = "0x94")]
	private void OnFinishMessage(object sender, object rev, params object[] pars)
	{
	}

	[Address(RVA = "0x566170", Offset = "0x564970", Length = "0x1E8")]
	[Token(Token = "0x6000A73")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000A74")]
	[Address(RVA = "0x565A80", Offset = "0x564280", Length = "0x323")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000A75")]
	[Address(RVA = "0x566C50", Offset = "0x565450", Length = "0x95")]
	private void PnlItemAwardDisableCallback()
	{
	}

	[Address(RVA = "0x566CF0", Offset = "0x5654F0", Length = "0xB9")]
	[Token(Token = "0x6000A76")]
	private void PnlLevelUpAwardDisableCallback()
	{
	}

	[Token(Token = "0x6000A77")]
	[Address(RVA = "0x566DB0", Offset = "0x5655B0", Length = "0x25F")]
	private void PnlUnlockStageDisableCallback()
	{
	}

	[Token(Token = "0x6000A78")]
	[Address(RVA = "0x566400", Offset = "0x564C00", Length = "0x4C4")]
	private void OnLevelUp(object sender, object rev, params object[] args)
	{
	}

	[Address(RVA = "0x5660E0", Offset = "0x5648E0", Length = "0x74")]
	[Token(Token = "0x6000A79")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x350E0", Offset = "0x344E0")]
	private IEnumerator JumpLevelUp(int totalExp)
	{
		return null;
	}

	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0x5668D0", Offset = "0x5650D0", Length = "0x37A")]
	private void OnStageUnlockOrNot()
	{
	}

	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0x567260", Offset = "0x565A60", Length = "0x2BC")]
	private bool UnlockForBudget()
	{
		return default(bool);
	}

	[Token(Token = "0x6000A7C")]
	[Address(RVA = "0x566070", Offset = "0x564870", Length = "0x6B")]
	private string GetFirstSongUidFormAlbumIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6000A7D")]
	[Address(RVA = "0x565DB0", Offset = "0x5645B0", Length = "0x259")]
	private bool CheckHaveEnoughExpToLevelUp()
	{
		return default(bool);
	}

	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0x567060", Offset = "0x565860", Length = "0x1FC")]
	private void ShowSpecialSongUnlock()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x351B0", Offset = "0x345B0")]
	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x566010", Offset = "0x564810", Length = "0x5C")]
	private IEnumerator FreezeInput(float freezeTime)
	{
		return null;
	}

	[Address(RVA = "0x567010", Offset = "0x565810", Length = "0x42")]
	[Token(Token = "0x6000A80")]
	private void SetMask(bool active)
	{
	}

	[Address(RVA = "0x566160", Offset = "0x564960", Length = "0x4")]
	[Token(Token = "0x6000A81")]
	private void LockMask(bool isLock)
	{
	}

	[Token(Token = "0x6000A82")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlUnlock()
	{
	}
}
