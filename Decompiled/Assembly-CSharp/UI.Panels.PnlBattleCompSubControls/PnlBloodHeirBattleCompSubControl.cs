using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Panels.PnlBattleCompSubControls;

[Token(Token = "0x20001CF")]
public class PnlBloodHeirBattleCompSubControl : MonoBehaviour, IPause
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B87")]
	[SerializeField]
	private Transform m_SpiFireCreatePos;

	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image m_ImgHeartIcon;

	[SerializeField]
	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_ImgCarrotRobotSkill;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B8A")]
	[SerializeField]
	private GameObject m_ImgCarrotRobotSkill_Img5;

	[Token(Token = "0x4000B8B")]
	[FieldOffset(Offset = "0x38")]
	private Transform m_SkeletonSkillOnFireTrans;

	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x40")]
	private SkeletonGraphic m_SkeletonSkillOnFire;

	[Token(Token = "0x4000B8D")]
	[FieldOffset(Offset = "0x48")]
	private Sequence m_SeqFireOn;

	[Token(Token = "0x170000F0")]
	public bool IsGlobal
	{
		[Address(RVA = "0x50B3E0", Offset = "0x509BE0", Length = "0x5")]
		[Token(Token = "0x6000D0F")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x50A8C0", Offset = "0x5090C0", Length = "0x12C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x50B090", Offset = "0x509890", Length = "0x346")]
	private void Start()
	{
	}

	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x50A9F0", Offset = "0x5091F0", Length = "0xCC")]
	public void ForceActiveRobotSkillIcon()
	{
	}

	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x50AC60", Offset = "0x509460", Length = "0xFC")]
	private void OnRoleSkillOff()
	{
	}

	[Address(RVA = "0x50AD60", Offset = "0x509560", Length = "0xFC")]
	[Token(Token = "0x6000D0A")]
	private void OnRoleSkillOn()
	{
	}

	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x50AF20", Offset = "0x509720", Length = "0x166")]
	private void SetSkFireVisible(bool isVisible)
	{
	}

	[Address(RVA = "0x50AAC0", Offset = "0x5092C0", Length = "0x19C")]
	[Token(Token = "0x6000D0C")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x50AE60", Offset = "0x509660", Length = "0x52")]
	[Token(Token = "0x6000D0D")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x50AEC0", Offset = "0x5096C0", Length = "0x52")]
	public void Resume()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000D10")]
	public PnlBloodHeirBattleCompSubControl()
	{
	}
}
