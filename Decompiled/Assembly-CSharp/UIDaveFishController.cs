using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200019B")]
public class UIDaveFishController : SingletonMonoBehaviour<UIDaveFishController>, IPause
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A2B")]
	public Animator daveFishPanelAnimator;

	[Token(Token = "0x4000A2C")]
	[FieldOffset(Offset = "0x20")]
	public Text txtFishName;

	[Token(Token = "0x4000A2D")]
	[FieldOffset(Offset = "0x28")]
	public Text txtFishExp;

	[Token(Token = "0x4000A2E")]
	[FieldOffset(Offset = "0x30")]
	public Image imgFishQualityIcon;

	[Token(Token = "0x4000A2F")]
	[FieldOffset(Offset = "0x38")]
	public Image imgFishIcon;

	[Token(Token = "0x4000A30")]
	[FieldOffset(Offset = "0x40")]
	public GameObject imgNewIcon;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A31")]
	public RectTransform imgMaskBgRectTransform;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A32")]
	private DaveFishDataModel m_FishDataModel;

	[Token(Token = "0x170000E2")]
	public bool IsGlobal
	{
		[Address(RVA = "0x4E5E90", Offset = "0x4E4690", Length = "0x5")]
		[Token(Token = "0x6000BBB")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x4E56A0", Offset = "0x4E3EA0", Length = "0x78")]
	[Token(Token = "0x6000BB6")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x4E5820", Offset = "0x4E4020", Length = "0x626")]
	public void ShowDaveFishPanel(DaveFishData daveFishData)
	{
	}

	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x4E5720", Offset = "0x4E3F20", Length = "0x93")]
	private Vector2 GetFishIconPos(Vector2 fishIconSize)
	{
		return default(Vector2);
	}

	[Address(RVA = "0x4E57C0", Offset = "0x4E3FC0", Length = "0x21")]
	[Token(Token = "0x6000BB9")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x4E57F0", Offset = "0x4E3FF0", Length = "0x26")]
	[Token(Token = "0x6000BBA")]
	public void Resume()
	{
	}

	[Address(RVA = "0x4E5E50", Offset = "0x4E4650", Length = "0x38")]
	[Token(Token = "0x6000BBC")]
	public UIDaveFishController()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
