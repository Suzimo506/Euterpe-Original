using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000627")]
public class Popup : Action
{
	[Token(Token = "0x2000BCD")]
	public struct PopUpAniParameter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003B5E")]
		public float inTime;

		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4003B5F")]
		public float inDistance;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003B60")]
		public Ease moveInEase;

		[Token(Token = "0x4003B61")]
		[FieldOffset(Offset = "0xC")]
		public bool isFadeIn;

		[Token(Token = "0x4003B62")]
		[FieldOffset(Offset = "0x10")]
		public Ease fadeInEase;

		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4003B63")]
		public float outTime;

		[Token(Token = "0x4003B64")]
		[FieldOffset(Offset = "0x18")]
		public float outDistance;

		[Token(Token = "0x4003B65")]
		[FieldOffset(Offset = "0x1C")]
		public Ease moveOutEase;

		[Token(Token = "0x4003B66")]
		[FieldOffset(Offset = "0x20")]
		public bool isFadeOut;

		[Token(Token = "0x4003B67")]
		[FieldOffset(Offset = "0x24")]
		public Ease fadeOutEase;

		[Token(Token = "0x4003B68")]
		[FieldOffset(Offset = "0x28")]
		public Color maskColor;

		[Token(Token = "0x4003B69")]
		[FieldOffset(Offset = "0x38")]
		public bool shut;

		[Token(Token = "0x4003B6A")]
		[FieldOffset(Offset = "0x39")]
		public bool shutAll;
	}

	[SerializeField]
	[Token(Token = "0x4002294")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_Panel;

	[SerializeField]
	[Token(Token = "0x4002295")]
	[FieldOffset(Offset = "0x20")]
	private float m_InTime;

	[SerializeField]
	[Token(Token = "0x4002296")]
	[FieldOffset(Offset = "0x24")]
	private float m_InDistance;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4002297")]
	private Ease m_MoveInEase;

	[SerializeField]
	[Token(Token = "0x4002298")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsFadeIn;

	[Token(Token = "0x4002299")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Ease m_FadeInEase;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400229A")]
	[SerializeField]
	private float m_OutTime;

	[SerializeField]
	[Token(Token = "0x400229B")]
	[FieldOffset(Offset = "0x38")]
	private float m_OutDistance;

	[Token(Token = "0x400229C")]
	[SerializeField]
	[FieldOffset(Offset = "0x3C")]
	private Ease m_MoveOutEase;

	[SerializeField]
	[Token(Token = "0x400229D")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsFadeOut;

	[SerializeField]
	[Token(Token = "0x400229E")]
	[FieldOffset(Offset = "0x44")]
	private Ease m_FadeOutEase;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400229F")]
	[SerializeField]
	private Color m_MaskColor;

	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40022A0")]
	private bool m_Shut;

	[SerializeField]
	[Token(Token = "0x40022A1")]
	[FieldOffset(Offset = "0x59")]
	private bool m_ShutAll;

	[SerializeField]
	[Token(Token = "0x40022A2")]
	[FieldOffset(Offset = "0x5C")]
	private PopupType m_Type;

	[SerializeField]
	[Token(Token = "0x40022A3")]
	[FieldOffset(Offset = "0x60")]
	private List<Button> m_ShutButtons;

	[SerializeField]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40022A4")]
	private List<Button> m_ShutAllShutButtons;

	[Token(Token = "0x40022A5")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AudioClip m_ShutClip;

	[Token(Token = "0x40022A6")]
	[SerializeField]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0x19120", Offset = "0x18520")]
	[FieldOffset(Offset = "0x78")]
	private IVariable m_Volume;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40022A7")]
	private Vector3 m_OriginPos;

	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40022A8")]
	private bool m_Flag;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40022A9")]
	private GameObject m_BtnCancell;

	[Token(Token = "0x40022AA")]
	[FieldOffset(Offset = "0x98")]
	private List<Tweener> m_Twners;

	[Token(Token = "0x40022AB")]
	[FieldOffset(Offset = "0xA0")]
	private CanvasGroup m_CanvasGroup;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40022AC")]
	private Tweener m_CurrentObjTweener;

	[Token(Token = "0x40022AD")]
	[FieldOffset(Offset = "0xB0")]
	private Tweener m_CurrentObjMoveTweener;

	[Token(Token = "0x40022AE")]
	[FieldOffset(Offset = "0xB8")]
	private Tweener m_CurrentImgTweener;

	[Token(Token = "0x40022B1")]
	[FieldOffset(Offset = "0xD0")]
	private Vector2 m_ScreenSize;

	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x40022B3")]
	private PopupType m_OriginPopupType;

	[Token(Token = "0x1700058C")]
	public bool isShut
	{
		[Address(RVA = "0x4E5E90", Offset = "0x4E4690", Length = "0x5")]
		[Token(Token = "0x6003B8F")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003B90")]
		[Address(RVA = "0x50B910", Offset = "0x50A110", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700058D")]
	public bool isClickShut
	{
		[Token(Token = "0x6003B92")]
		[CompilerGenerated]
		[Address(RVA = "0x749390", Offset = "0x747B90", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Address(RVA = "0x7496C0", Offset = "0x747EC0", Length = "0x7")]
		[Token(Token = "0x6003B91")]
		private set
		{
		}
	}

	[Token(Token = "0x14000054")]
	public event System.Action onShutClicked
	{
		[Address(RVA = "0x7492F0", Offset = "0x747AF0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6003B89")]
		add
		{
		}
		[Address(RVA = "0x749620", Offset = "0x747E20", Length = "0x9E")]
		[Token(Token = "0x6003B8A")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000055")]
	public event System.Action onInAniLast
	{
		[CompilerGenerated]
		[Token(Token = "0x6003B8B")]
		[Address(RVA = "0x7491B0", Offset = "0x7479B0", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Address(RVA = "0x7494E0", Offset = "0x747CE0", Length = "0x9E")]
		[Token(Token = "0x6003B8C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000056")]
	public event System.Action onOutAniStart
	{
		[Address(RVA = "0x749250", Offset = "0x747A50", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6003B8D")]
		add
		{
		}
		[Token(Token = "0x6003B8E")]
		[Address(RVA = "0x749580", Offset = "0x747D80", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000057")]
	public event System.Action onExcute
	{
		[Token(Token = "0x6003B93")]
		[Address(RVA = "0x749070", Offset = "0x747870", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003B94")]
		[Address(RVA = "0x7493A0", Offset = "0x747BA0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000058")]
	public event System.Action onExit
	{
		[CompilerGenerated]
		[Token(Token = "0x6003B95")]
		[Address(RVA = "0x749110", Offset = "0x747910", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x6003B96")]
		[CompilerGenerated]
		[Address(RVA = "0x749440", Offset = "0x747C40", Length = "0x9E")]
		remove
		{
		}
	}

	[Address(RVA = "0x748C70", Offset = "0x747470", Length = "0x1C7")]
	[Token(Token = "0x6003B97")]
	public void SetOnceType(PopupType tempType)
	{
	}

	[Token(Token = "0x6003B98")]
	[Address(RVA = "0x748B50", Offset = "0x747350", Length = "0x11D")]
	public void SetAniParameter(PopUpAniParameter popUpAniParameter)
	{
	}

	[Token(Token = "0x6003B99")]
	[Address(RVA = "0x746E50", Offset = "0x745650", Length = "0x70")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6003B9A")]
	[Address(RVA = "0x746EC0", Offset = "0x7456C0", Length = "0x281")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x747150", Offset = "0x745950", Length = "0x133")]
	[Token(Token = "0x6003B9B")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6003B9C")]
	[Address(RVA = "0x747E00", Offset = "0x746600", Length = "0xB04")]
	public void Play()
	{
	}

	[Token(Token = "0x6003B9D")]
	[Address(RVA = "0x748E40", Offset = "0x747640", Length = "0xA3")]
	private void SetShutButtonEnable(bool enable)
	{
	}

	[Address(RVA = "0x7479C0", Offset = "0x7461C0", Length = "0x65")]
	[Token(Token = "0x6003B9E")]
	public void OnShutAllShutButtonsClick()
	{
	}

	[Address(RVA = "0x747D90", Offset = "0x746590", Length = "0x65")]
	[Token(Token = "0x6003B9F")]
	public void OnShutButtonsClick()
	{
	}

	[Address(RVA = "0x747940", Offset = "0x746140", Length = "0x77")]
	[Token(Token = "0x6003BA0")]
	public void OnBgShutButtonClick()
	{
	}

	[Token(Token = "0x6003BA1")]
	[Address(RVA = "0x747A30", Offset = "0x746230", Length = "0x358")]
	public void OnShutButtonClick(bool isShutAll = false, bool disablePopupNext = false)
	{
	}

	[Token(Token = "0x6003BA2")]
	[Address(RVA = "0x747430", Offset = "0x745C30", Length = "0x46E")]
	public void Leave(System.Action callback)
	{
	}

	[Token(Token = "0x6003BA3")]
	[Address(RVA = "0x748910", Offset = "0x747110", Length = "0x14B")]
	private void Push()
	{
	}

	[Token(Token = "0x6003BA4")]
	[Address(RVA = "0x748B40", Offset = "0x747340", Length = "0x8")]
	private void ResetFlag()
	{
	}

	[Token(Token = "0x6003BA5")]
	[Address(RVA = "0x748A60", Offset = "0x747260", Length = "0xDE")]
	public void ResetBtnCancelColor()
	{
	}

	[Token(Token = "0x6003BA6")]
	[Address(RVA = "0x747300", Offset = "0x745B00", Length = "0x127")]
	private void KillAllTwns()
	{
	}

	[Token(Token = "0x6003BA7")]
	[Address(RVA = "0x746DB0", Offset = "0x7455B0", Length = "0x9D")]
	private void CheckObjTweenPause()
	{
	}

	[Address(RVA = "0x746D10", Offset = "0x745510", Length = "0x9D")]
	[Token(Token = "0x6003BA8")]
	private void CheckImgTweenPause()
	{
	}

	[Address(RVA = "0x7478A0", Offset = "0x7460A0", Length = "0x9D")]
	[Token(Token = "0x6003BA9")]
	private void ObjLoop(float time)
	{
	}

	[Token(Token = "0x6003BAA")]
	[Address(RVA = "0x747290", Offset = "0x745A90", Length = "0x6B")]
	private void ImgLoop(float time)
	{
	}

	[Address(RVA = "0x746D00", Offset = "0x745500", Length = "0x6")]
	[Token(Token = "0x6003BAB")]
	public void ChangeOutTime(float outTime)
	{
	}

	[Address(RVA = "0x45AB50", Offset = "0x459350", Length = "0x4")]
	[Token(Token = "0x6003BAC")]
	public void ChangeMoveOutEaseType(Ease targetEase)
	{
	}

	[Token(Token = "0x6003BAD")]
	[Address(RVA = "0x748F10", Offset = "0x747710", Length = "0x155")]
	public Popup()
	{
	}
}
