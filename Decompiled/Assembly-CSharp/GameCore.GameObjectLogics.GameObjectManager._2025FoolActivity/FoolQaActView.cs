using Cpp2ILInjected;
using GameCore.GameObjectLogics.GameObjectManager.BattleQuestion;
using Spine;
using UnityEngine;
using UnityEngine.UI;

namespace GameCore.GameObjectLogics.GameObjectManager._2025FoolActivity;

[Token(Token = "0x2000485")]
public class FoolQaActView : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400186F")]
	[SerializeField]
	private Vector2 m_RoleBattlePointOffset;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001870")]
	private Vector2 m_BossBattlePointOffset;

	[SerializeField]
	[Token(Token = "0x4001871")]
	[FieldOffset(Offset = "0x28")]
	private SuperTextMesh m_TxtRoleBattlePoint;

	[Token(Token = "0x4001872")]
	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	private SuperTextMesh m_TxtBossBattlePoint;

	[SerializeField]
	[Token(Token = "0x4001873")]
	[FieldOffset(Offset = "0x38")]
	private CanvasGroup m_RoleBattlePoint;

	[Token(Token = "0x4001874")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private CanvasGroup m_BossBattlePoint;

	[Token(Token = "0x4001875")]
	[SerializeField]
	[FieldOffset(Offset = "0x48")]
	private Image m_ImgRoleBPBar;

	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001876")]
	private Image m_ImgBossBPBar;

	[SerializeField]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001877")]
	private Image m_ImgRoleBPOverState;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001878")]
	private Bone m_BossRootBone;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001879")]
	private BattleQuestionCoreController m_BattleQuestionCoreController;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400187A")]
	private Vector2 m_ReferenceResolution;

	[Address(RVA = "0x8F9560", Offset = "0x8F7D60", Length = "0x2B9")]
	[Token(Token = "0x60033C1")]
	public void ResetBattlePoint()
	{
	}

	[Token(Token = "0x60033C2")]
	[Address(RVA = "0x8F9450", Offset = "0x8F7C50", Length = "0x36")]
	public void OnGameStart()
	{
	}

	[Address(RVA = "0x8F90D0", Offset = "0x8F78D0", Length = "0x3B")]
	[Token(Token = "0x60033C3")]
	public void OnGameFailed()
	{
	}

	[Address(RVA = "0x8F9390", Offset = "0x8F7B90", Length = "0x36")]
	[Token(Token = "0x60033C4")]
	public void OnBossEnter()
	{
	}

	[Address(RVA = "0x8F9490", Offset = "0x8F7C90", Length = "0xC0")]
	[Token(Token = "0x60033C5")]
	public void OnGirlEnter()
	{
	}

	[Address(RVA = "0x8F90D0", Offset = "0x8F78D0", Length = "0x3B")]
	[Token(Token = "0x60033C6")]
	public void HideBattlePointUI()
	{
	}

	[Token(Token = "0x60033C7")]
	[Address(RVA = "0x8F93D0", Offset = "0x8F7BD0", Length = "0x74")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x8F9110", Offset = "0x8F7910", Length = "0x275")]
	[Token(Token = "0x60033C8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60033C9")]
	[Address(RVA = "0x8F98D0", Offset = "0x8F80D0", Length = "0x196")]
	private void ResetCharacterBattlePointUIPosition()
	{
	}

	[Address(RVA = "0x8F9820", Offset = "0x8F8020", Length = "0xA2")]
	[Token(Token = "0x60033CA")]
	private void ResetBossBattlePointUIPosition()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60033CB")]
	public FoolQaActView()
	{
	}
}
