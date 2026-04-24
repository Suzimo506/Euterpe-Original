using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.PeroTools.PreWarm;
using Assets.Scripts.UI.Controls;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200016C")]
public class PnlLevelUpAward : MonoBehaviour, IPreWarm
{
	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip levelUpClip;

	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip levelUpVoice;

	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip clickSfx;

	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0x30")]
	public Button btnCancel;

	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x38")]
	public Animator levelUpAnimator;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008EB")]
	[SerializeField]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_AwardFsv;

	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008EC")]
	private AwardControl m_AwardControl;

	[Token(Token = "0x40008ED")]
	[SerializeField]
	[FieldOffset(Offset = "0x58")]
	private Button m_BtnJumpSeriesLevelUp;

	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Button m_BtnGoNextPage;

	[Token(Token = "0x40008EF")]
	[SerializeField]
	[FieldOffset(Offset = "0x68")]
	private Button m_BtnGoPrev;

	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40008F0")]
	private AwardItem m_AwardItemPrefab;

	[SerializeField]
	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0x78")]
	public particleHoming m_ParticleHomingPrefab;

	[SerializeField]
	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x80")]
	public Transform m_TransSetting;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40008F3")]
	[SerializeField]
	private List<GridLayoutAdjuster> m_PageGrids;

	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x90")]
	private GridLayoutGroup m_GridLayoutGroup;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40008F5")]
	private FastPool m_PoolAwardItem;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40008F6")]
	private FastPool m_PoolParticleHoming;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40008F7")]
	private Transform[] m_Cells;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40008F8")]
	private Dictionary<int, List<AwardInfo>> m_DicAwardInfos;

	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0xB8")]
	private List<AwardInfo> m_AllRewardsInThisSeries;

	[Token(Token = "0x40008FA")]
	[FieldOffset(Offset = "0xC0")]
	private int m_Index;

	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40008FB")]
	private int m_MaxItemNum;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40008FC")]
	private int m_RemainExp;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40008FD")]
	private Coroutine m_RecoverClick;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40008FE")]
	private bool m_JumpEnd;

	[Token(Token = "0x40008FF")]
	private static readonly Dictionary<string, int> ItemPriorities;

	[Token(Token = "0x14000005")]
	public event Action onDisable
	{
		[Address(RVA = "0x7A7DD0", Offset = "0x7A65D0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000A4B")]
		add
		{
		}
		[Address(RVA = "0x7A7E70", Offset = "0x7A6670", Length = "0x9E")]
		[Token(Token = "0x6000A4C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Address(RVA = "0x7A6840", Offset = "0x7A5040", Length = "0x1AF")]
	[Token(Token = "0x6000A4D")]
	public void PreWarm(int slice)
	{
	}

	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x7A4EA0", Offset = "0x7A36A0", Length = "0x2E7")]
	private void Awake()
	{
	}

	[Address(RVA = "0x7A5F70", Offset = "0x7A4770", Length = "0x120")]
	[Token(Token = "0x6000A4F")]
	private void OnCancelClicked()
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x31960", Offset = "0x30D60")]
	[Token(Token = "0x6000A50")]
	[Address(RVA = "0x7A6780", Offset = "0x7A4F80", Length = "0x65")]
	private IEnumerator PlayAnimator()
	{
		return null;
	}

	[Token(Token = "0x6000A51")]
	[Address(RVA = "0x7A62C0", Offset = "0x7A4AC0", Length = "0x2D2")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000A52")]
	[Address(RVA = "0x7A65A0", Offset = "0x7A4DA0", Length = "0x1D7")]
	public void OnLevelUp(int remainExp = 0, bool playLevelUpAudio = true)
	{
	}

	[Address(RVA = "0x7A5BE0", Offset = "0x7A43E0", Length = "0x179")]
	[Token(Token = "0x6000A53")]
	private void InitFsv()
	{
	}

	[Token(Token = "0x6000A54")]
	[Address(RVA = "0x7A5D60", Offset = "0x7A4560", Length = "0x194")]
	private void InitGridNum()
	{
	}

	[Token(Token = "0x6000A55")]
	[Address(RVA = "0x7A4E20", Offset = "0x7A3620", Length = "0x7E")]
	private bool AreApproximatelyEqual(float a, float b, float epsilon)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A56")]
	[Address(RVA = "0x7A5930", Offset = "0x7A4130", Length = "0x2A6")]
	private void GoPrevPage()
	{
	}

	[Token(Token = "0x6000A57")]
	[Address(RVA = "0x7A5690", Offset = "0x7A3E90", Length = "0x293")]
	private void GoNextPage()
	{
	}

	[Address(RVA = "0x7A6E10", Offset = "0x7A5610", Length = "0x7E")]
	[Token(Token = "0x6000A58")]
	private void RefreshNextBtn()
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x31AA0", Offset = "0x30EA0")]
	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x7A5F00", Offset = "0x7A4700", Length = "0x65")]
	private IEnumerator LockMask()
	{
		return null;
	}

	[Address(RVA = "0x7A60A0", Offset = "0x7A48A0", Length = "0x65")]
	[Token(Token = "0x6000A5A")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x31D70", Offset = "0x31170")]
	private IEnumerator OnClickJumpSeriesLevelup()
	{
		return null;
	}

	[Address(RVA = "0x7A7130", Offset = "0x7A5930", Length = "0x474")]
	[Token(Token = "0x6000A5B")]
	private void SendJumpLevelMsg()
	{
	}

	[Address(RVA = "0x7A75B0", Offset = "0x7A5DB0", Length = "0x3B0")]
	[Token(Token = "0x6000A5C")]
	private void ShowSeriesAwardItem()
	{
	}

	[Address(RVA = "0x7A52F0", Offset = "0x7A3AF0", Length = "0x330")]
	[Token(Token = "0x6000A5D")]
	private int GetExpMessageNum()
	{
		return default(int);
	}

	[Address(RVA = "0x7A5190", Offset = "0x7A3990", Length = "0x61")]
	[Token(Token = "0x6000A5E")]
	private (int, int) CalculateLevelUp(int expGained)
	{
		return default((int, int));
	}

	[Address(RVA = "0x7A6E90", Offset = "0x7A5690", Length = "0x29F")]
	[Token(Token = "0x6000A5F")]
	private void SaveCurLevelAwardInfos()
	{
	}

	[Address(RVA = "0x7A7970", Offset = "0x7A6170", Length = "0x89")]
	[Token(Token = "0x6000A60")]
	private void SortCurrentSeriesAwards()
	{
	}

	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x7A5200", Offset = "0x7A3A00", Length = "0x8F")]
	private int CompareRewardPriority(AwardInfo a, AwardInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6000A62")]
	[Address(RVA = "0x7A6C70", Offset = "0x7A5470", Length = "0x19D")]
	private void RefreshLevelAwradItem(List<AwardInfo> awwardInofo)
	{
	}

	[Token(Token = "0x6000A63")]
	[Address(RVA = "0x7A4AE0", Offset = "0x7A32E0", Length = "0x335")]
	private void AddNewMusicToRewardInfo()
	{
	}

	[Address(RVA = "0x7A69F0", Offset = "0x7A51F0", Length = "0x1B4")]
	[Token(Token = "0x6000A64")]
	private void ReAssignmentAwardInfo()
	{
	}

	[Address(RVA = "0x7A61A0", Offset = "0x7A49A0", Length = "0x113")]
	[Token(Token = "0x6000A65")]
	private void OnDisable()
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x31F80", Offset = "0x31380")]
	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x7A67F0", Offset = "0x7A4FF0", Length = "0x4A")]
	private IEnumerator PnlEnable()
	{
		return null;
	}

	[Token(Token = "0x6000A67")]
	[Address(RVA = "0x7A5290", Offset = "0x7A3A90", Length = "0x58")]
	public AwardItem GetAwardItemFormPool(Transform parent)
	{
		return null;
	}

	[Address(RVA = "0x7A6BB0", Offset = "0x7A53B0", Length = "0x55")]
	[Token(Token = "0x6000A68")]
	public void RecycleAwardItem(AwardItem awardItem)
	{
	}

	[Address(RVA = "0x7A5630", Offset = "0x7A3E30", Length = "0x58")]
	[Token(Token = "0x6000A69")]
	public particleHoming GetParticleFormPool(Transform parent)
	{
		return null;
	}

	[Address(RVA = "0x7A6C10", Offset = "0x7A5410", Length = "0x55")]
	[Token(Token = "0x6000A6A")]
	public void RecycleParticleHoming(particleHoming particleHoming)
	{
	}

	[Address(RVA = "0x7A6110", Offset = "0x7A4910", Length = "0x8E")]
	[Token(Token = "0x6000A6B")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000A6C")]
	[Address(RVA = "0x7A7CF0", Offset = "0x7A64F0", Length = "0xD6")]
	public PnlLevelUpAward()
	{
	}
}
