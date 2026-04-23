using System;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using Spine.Unity;
using UnityEngine;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008A6")]
public class CharacterApply : SerializedMonoBehaviour
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002D0A")]
	public string characterAnimation;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002D0B")]
	public string characterSound;

	[Token(Token = "0x4002D0C")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsMainShow;

	[SerializeField]
	[Token(Token = "0x4002D0D")]
	[FieldOffset(Offset = "0x70")]
	protected Animator m_Animator;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002D0E")]
	private int m_Index;

	[Token(Token = "0x4002D0F")]
	[FieldOffset(Offset = "0x80")]
	private AudioSource m_AudioSource;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002D10")]
	private Action m_EndCallback;

	[Token(Token = "0x4002D11")]
	[FieldOffset(Offset = "0x90")]
	private AnimationClip m_EndClip;

	[Token(Token = "0x4002D12")]
	[FieldOffset(Offset = "0x98")]
	private string m_EndAnimName;

	[Token(Token = "0x4002D13")]
	[FieldOffset(Offset = "0xA0")]
	private Coroutine m_EndCoroutine;

	[Token(Token = "0x4002D14")]
	[FieldOffset(Offset = "0xA8")]
	private Coroutine m_AudioCoroutine;

	[Token(Token = "0x4002D15")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_Init;

	[Token(Token = "0x4002D16")]
	[FieldOffset(Offset = "0xB8")]
	private SkeletonMecanim m_SkeletonMecanim;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4002D17")]
	private bool m_IsExpressing;

	[Token(Token = "0x17000880")]
	public bool IsExpressShowing
	{
		[Token(Token = "0x6004E46")]
		[Address(RVA = "0x5A8E90", Offset = "0x5A7690", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000881")]
	public bool isMainShow
	{
		[Address(RVA = "0x5A8EA0", Offset = "0x5A76A0", Length = "0x5")]
		[Token(Token = "0x6004E48")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x5A86A0", Offset = "0x5A6EA0", Length = "0x41")]
	[Token(Token = "0x6004E47")]
	public void Init(int index, bool isMainShow = false)
	{
	}

	[Address(RVA = "0x5A8730", Offset = "0x5A6F30", Length = "0x3C")]
	[Token(Token = "0x6004E49")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x5A86F0", Offset = "0x5A6EF0", Length = "0x32")]
	[Token(Token = "0x6004E4A")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x5A82F0", Offset = "0x5A6AF0", Length = "0x98")]
	[Token(Token = "0x6004E4B")]
	private void CheckSkMecanim()
	{
	}

	[Address(RVA = "0x5A8C30", Offset = "0x5A7430", Length = "0x163")]
	[Token(Token = "0x6004E4C")]
	public void SetSkSkin(string skinName)
	{
	}

	[Address(RVA = "0x5A87A0", Offset = "0x5A6FA0", Length = "0x86")]
	[Token(Token = "0x6004E4D")]
	public void PlayCharacterApply()
	{
	}

	[Address(RVA = "0x5A8390", Offset = "0x5A6B90", Length = "0xEB")]
	[Token(Token = "0x6004E4E")]
	public void Clean()
	{
	}

	[Token(Token = "0x6004E4F")]
	[Address(RVA = "0x5A8830", Offset = "0x5A7030", Length = "0x348")]
	public void PlayCharacterApply(string animName, string voiceName, Action endCallback = null, bool autoAddSuffix = true, float endTime = 3f)
	{
	}

	[Token(Token = "0x6004E50")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected virtual void PreCharacterApply(string animName)
	{
	}

	[Address(RVA = "0x5A8770", Offset = "0x5A6F70", Length = "0x2B")]
	[Token(Token = "0x6004E51")]
	public void PlayAnim(string animName)
	{
	}

	[Address(RVA = "0x5A8480", Offset = "0x5A6C80", Length = "0x219")]
	[Token(Token = "0x6004E52")]
	private void EndCharacterApply()
	{
	}

	[Token(Token = "0x6004E53")]
	[Address(RVA = "0x5A8B80", Offset = "0x5A7380", Length = "0xA9")]
	protected virtual void ResetCharaterApply()
	{
	}

	[Address(RVA = "0x5A8DA0", Offset = "0x5A75A0", Length = "0xCF")]
	[Token(Token = "0x6004E54")]
	public void StopCharacterApply()
	{
	}

	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	[Token(Token = "0x6004E55")]
	public CharacterApply()
	{
	}
}
