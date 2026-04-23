using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow;

[Token(Token = "0x200083A")]
public class PnlDaveFishDetailShow : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000D1C")]
	public class DaveFishTypeDefines
	{
		[Token(Token = "0x4003EC5")]
		[FieldOffset(Offset = "0x10")]
		public Sprite imgFishShallows;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003EC6")]
		public Color colorFishShallows;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003EC7")]
		public Sprite imgFishMediumDepth;

		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003EC8")]
		public Color colorFishMediumDepth;

		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003EC9")]
		public Sprite imgFishDepths;

		[Token(Token = "0x4003ECA")]
		[FieldOffset(Offset = "0x48")]
		public Color colorFishDepths;

		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003ECB")]
		public Sprite imgFishLocked;

		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003ECC")]
		public Color colorFishLocked;

		[Token(Token = "0x600636C")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public DaveFishTypeDefines()
		{
		}
	}

	[Token(Token = "0x4002AE1")]
	[FieldOffset(Offset = "0x18")]
	private ScrDaveFishData m_FishData;

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4002AE2")]
	private Button m_BtnHide;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002AE3")]
	[SerializeField]
	private Text m_TxtFishName;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002AE4")]
	[SerializeField]
	private Text m_TxtFishDesc;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002AE5")]
	[SerializeField]
	private Image m_ImgFishType;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002AE6")]
	[SerializeField]
	private Image m_ImgFish;

	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4002AE7")]
	private DaveFishTypeDefines m_FishTypeDefines;

	[SerializeField]
	[Token(Token = "0x4002AE8")]
	[FieldOffset(Offset = "0x50")]
	private Color m_ColorFishNameTypeLocked;

	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002AE9")]
	private Color m_ColorFishLocked;

	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002AEA")]
	private List<FishAlignmentType> m_FishAlignmentTypeList;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002AEB")]
	private Func<string, Sprite> m_GetFishImg;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002AEC")]
	private DaveFishDataModel m_FishDataModel;

	[Token(Token = "0x1700084B")]
	public ScrDaveFishData FishData
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x6004BB8")]
		get
		{
			return null;
		}
		[Address(RVA = "0x611860", Offset = "0x610060", Length = "0x25")]
		[Token(Token = "0x6004BB9")]
		set
		{
		}
	}

	[Token(Token = "0x6004BBA")]
	[Address(RVA = "0x6112A0", Offset = "0x60FAA0", Length = "0xE0")]
	public void Init(Func<string, Sprite> getFishImg)
	{
	}

	[Address(RVA = "0x6117E0", Offset = "0x60FFE0", Length = "0x74")]
	[Token(Token = "0x6004BBB")]
	public void Show(ScrDaveFishData fishData = null)
	{
	}

	[Token(Token = "0x6004BBC")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void Release()
	{
	}

	[Address(RVA = "0x44DE50", Offset = "0x44C650", Length = "0x26")]
	[Token(Token = "0x6004BBD")]
	private void HideView()
	{
	}

	[Token(Token = "0x6004BBE")]
	[Address(RVA = "0x611390", Offset = "0x60FB90", Length = "0x440")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6004BBF")]
	[Address(RVA = "0x611080", Offset = "0x60F880", Length = "0x21B")]
	private void AdaptFishImg(FishAlignmentType type)
	{
	}

	[Token(Token = "0x6004BC0")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlDaveFishDetailShow()
	{
	}
}
