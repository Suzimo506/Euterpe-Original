using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DG.Tweening;
using PeroPeroGames.GlobalDefines;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Components.NiceReplacement;

[Token(Token = "0x20008C0")]
public class ReplacedPopup : MonoBehaviour, IPlayable
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002DA0")]
	[SerializeField]
	private GameObject m_Panel;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4002DA1")]
	private float m_InTime;

	[SerializeField]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4002DA2")]
	private float m_InDistance;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002DA3")]
	[SerializeField]
	private Ease m_MoveInEase;

	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4002DA4")]
	private bool m_IsFadeIn;

	[SerializeField]
	[Token(Token = "0x4002DA5")]
	[FieldOffset(Offset = "0x38")]
	private Ease m_FadeInEase;

	[SerializeField]
	[Token(Token = "0x4002DA6")]
	[FieldOffset(Offset = "0x3C")]
	private float m_OutTime;

	[SerializeField]
	[Token(Token = "0x4002DA7")]
	[FieldOffset(Offset = "0x40")]
	private float m_OutDistance;

	[SerializeField]
	[Token(Token = "0x4002DA8")]
	[FieldOffset(Offset = "0x44")]
	private Ease m_MoveOutEase;

	[SerializeField]
	[Token(Token = "0x4002DA9")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsFadeOut;

	[SerializeField]
	[Token(Token = "0x4002DAA")]
	[FieldOffset(Offset = "0x4C")]
	private Ease m_FadeOutEase;

	[SerializeField]
	[Token(Token = "0x4002DAB")]
	[FieldOffset(Offset = "0x50")]
	private Color m_MaskColor;

	[SerializeField]
	[Token(Token = "0x4002DAC")]
	[FieldOffset(Offset = "0x60")]
	private bool m_Shut;

	[SerializeField]
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4002DAD")]
	private bool m_ShutAll;

	[SerializeField]
	[Token(Token = "0x4002DAE")]
	[FieldOffset(Offset = "0x64")]
	private PopupType m_Type;

	[SerializeField]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002DAF")]
	private List<Button> m_ShutButtons;

	[SerializeField]
	[Token(Token = "0x4002DB0")]
	[FieldOffset(Offset = "0x70")]
	private List<Button> m_ShutAllShutButtons;

	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4002DB1")]
	private AudioClip m_ShutClip;

	[SerializeField]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002DB2")]
	private bool m_UseSettingVolume;

	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4002DB3")]
	[SerializeField]
	private PeroAudioType m_VolumeType;

	[SerializeField]
	[Token(Token = "0x4002DB4")]
	[FieldOffset(Offset = "0x88")]
	private float m_Volume;

	[Token(Token = "0x4002DB5")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 m_OriginPos;

	[Token(Token = "0x4002DB6")]
	[FieldOffset(Offset = "0x98")]
	private bool m_Flag;

	[Token(Token = "0x4002DB7")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject m_BtnCancell;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4002DB8")]
	private List<Tweener> m_Twners;

	[Token(Token = "0x4002DB9")]
	[FieldOffset(Offset = "0xB0")]
	private CanvasGroup m_CanvasGroup;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4002DBA")]
	private Tweener m_CurrentObjTweener;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4002DBB")]
	private Tweener m_CurrentObjMoveTweener;

	[Token(Token = "0x4002DBC")]
	[FieldOffset(Offset = "0xC8")]
	private Tweener m_CurrentImgTweener;

	[Token(Token = "0x17000886")]
	public bool isShut
	{
		[Address(RVA = "0x5B5230", Offset = "0x5B3A30", Length = "0x5")]
		[Token(Token = "0x6004EE7")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004EE8")]
		[Address(RVA = "0x5B52F0", Offset = "0x5B3AF0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000887")]
	public bool isClickShut
	{
		[Token(Token = "0x6004EEA")]
		[Address(RVA = "0x5B5220", Offset = "0x5B3A20", Length = "0x8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x5B52E0", Offset = "0x5B3AE0", Length = "0x7")]
		[Token(Token = "0x6004EE9")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000093")]
	public event Action onShutClicked
	{
		[Address(RVA = "0x5B5180", Offset = "0x5B3980", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6004EE5")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004EE6")]
		[Address(RVA = "0x5B5240", Offset = "0x5B3A40", Length = "0x9E")]
		remove
		{
		}
	}

	[Address(RVA = "0x5B4EE0", Offset = "0x5B36E0", Length = "0x70")]
	[Token(Token = "0x6004EEB")]
	public void Start()
	{
	}

	[Address(RVA = "0x5B3200", Offset = "0x5B1A00", Length = "0x27F")]
	[Token(Token = "0x6004EEC")]
	public void Execute()
	{
	}

	[Address(RVA = "0x5B3BA0", Offset = "0x5B23A0", Length = "0xFA")]
	[Token(Token = "0x6004EED")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x5B4100", Offset = "0x5B2900", Length = "0xBCA")]
	[Token(Token = "0x6004EEE")]
	public void Play()
	{
	}

	[Address(RVA = "0x5B4E30", Offset = "0x5B3630", Length = "0xA3")]
	[Token(Token = "0x6004EEF")]
	private void SetShutButtonEnable(bool enable)
	{
	}

	[Token(Token = "0x6004EF0")]
	[Address(RVA = "0x5B3CA0", Offset = "0x5B24A0", Length = "0x65")]
	public void OnShutAllShutButtonsClick()
	{
	}

	[Token(Token = "0x6004EF1")]
	[Address(RVA = "0x5B4090", Offset = "0x5B2890", Length = "0x65")]
	public void OnShutButtonsClick()
	{
	}

	[Token(Token = "0x6004EF2")]
	[Address(RVA = "0x5B3B20", Offset = "0x5B2320", Length = "0x77")]
	public void OnBgShutButtonClick()
	{
	}

	[Token(Token = "0x6004EF3")]
	[Address(RVA = "0x5B3D10", Offset = "0x5B2510", Length = "0x37B")]
	public void OnShutButtonClick(bool isShutAll = false, bool disablePopupNext = false)
	{
	}

	[Address(RVA = "0x5B3620", Offset = "0x5B1E20", Length = "0x45B")]
	[Token(Token = "0x6004EF4")]
	public void Leave(Action callback)
	{
	}

	[Token(Token = "0x6004EF5")]
	[Address(RVA = "0x5B4CD0", Offset = "0x5B34D0", Length = "0x142")]
	private void Push()
	{
	}

	[Token(Token = "0x6004EF6")]
	[Address(RVA = "0x5B4E20", Offset = "0x5B3620", Length = "0x8")]
	private void ResetFlag()
	{
	}

	[Address(RVA = "0x5B34F0", Offset = "0x5B1CF0", Length = "0x127")]
	[Token(Token = "0x6004EF7")]
	private void KillAllTwns()
	{
	}

	[Address(RVA = "0x5B3160", Offset = "0x5B1960", Length = "0x9D")]
	[Token(Token = "0x6004EF8")]
	private void CheckObjTweenPause()
	{
	}

	[Token(Token = "0x6004EF9")]
	[Address(RVA = "0x5B30C0", Offset = "0x5B18C0", Length = "0x9D")]
	private void CheckImgTweenPause()
	{
	}

	[Address(RVA = "0x5B3A80", Offset = "0x5B2280", Length = "0x9D")]
	[Token(Token = "0x6004EFA")]
	private void ObjLoop(float time)
	{
	}

	[Address(RVA = "0x5B3480", Offset = "0x5B1C80", Length = "0x66")]
	[Token(Token = "0x6004EFB")]
	private void ImgLoop(float time)
	{
	}

	[Token(Token = "0x6004EFC")]
	[Address(RVA = "0x5B5010", Offset = "0x5B3810", Length = "0x170")]
	public ReplacedPopup()
	{
	}
}
