using System.Collections.Generic;
using Assets.Scripts.UI.StageBackground.DaveMainShow.FsvFishType;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow;

[Token(Token = "0x200083C")]
public class PnlDaveFishView : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002AF1")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_MainShow;

	[SerializeField]
	[Token(Token = "0x4002AF2")]
	[FieldOffset(Offset = "0x20")]
	private Button m_BtnShow;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002AF3")]
	[SerializeField]
	private Button m_BtnSell;

	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4002AF4")]
	private Button m_BtnClose;

	[Token(Token = "0x4002AF5")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button m_BtnAllCollect;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002AF6")]
	[SerializeField]
	private Canvas m_Canvas;

	[SerializeField]
	[Token(Token = "0x4002AF7")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_PhoneIconObj;

	[SerializeField]
	[Token(Token = "0x4002AF8")]
	[FieldOffset(Offset = "0x50")]
	private Text m_TxtExpDes;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002AF9")]
	[SerializeField]
	private Slider m_SldFishUnlocked;

	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002AFA")]
	private Text m_TxtFishUnlocked;

	[SerializeField]
	[Token(Token = "0x4002AFB")]
	[FieldOffset(Offset = "0x68")]
	private Text m_TxtAllCollect;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002AFC")]
	[SerializeField]
	private PnlEditorFishDebug m_PnlDebug;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002AFD")]
	[SerializeField]
	private Assets.Scripts.UI.StageBackground.DaveMainShow.FsvFishType.FsvFishType m_FsvFishType;

	[Token(Token = "0x4002AFE")]
	[SerializeField]
	[FieldOffset(Offset = "0x80")]
	private ScrollViewDaveFish m_ScrDaveFish;

	[SerializeField]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002AFF")]
	private PnlDaveFishDetailShow m_DaveFishDetailShow;

	[SerializeField]
	[Token(Token = "0x4002B00")]
	[FieldOffset(Offset = "0x90")]
	private Selectable m_FsvFishTypeSelectable;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4002B01")]
	[SerializeField]
	private DaveFishViewSelectManage m_FishViewSelectManage;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4002B02")]
	[SerializeField]
	private Color m_ColorNotUnlock;

	[Token(Token = "0x4002B03")]
	[SerializeField]
	[FieldOffset(Offset = "0xB0")]
	private Color m_ColorGet;

	[Token(Token = "0x4002B04")]
	[FieldOffset(Offset = "0xC0")]
	private DaveFishDataModel m_DataModel;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4002B05")]
	private int m_TotalExp;

	[Token(Token = "0x4002B06")]
	[FieldOffset(Offset = "0xCC")]
	private DaveFishQuality m_CurSelectQuality;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4002B07")]
	private int m_CurFsvIndex;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4002B08")]
	private List<ScrDaveFishData> m_DaveFishDataList;

	[Token(Token = "0x4002B09")]
	[FieldOffset(Offset = "0xE0")]
	private Vector3 m_OriPhonePos;

	[Token(Token = "0x4002B0A")]
	[FieldOffset(Offset = "0xF0")]
	private Dictionary<string, Sprite> m_FishImgCacheDic;

	[Token(Token = "0x1700084C")]
	public PnlDaveFishDetailShow DaveFishDetailShow
	{
		[Address(RVA = "0x5C1450", Offset = "0x5BFC50", Length = "0x8")]
		[Token(Token = "0x6004BC1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004BC2")]
	[Address(RVA = "0x611890", Offset = "0x610090", Length = "0x5BD")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004BC3")]
	[Address(RVA = "0x612E10", Offset = "0x611610", Length = "0xD3")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004BC4")]
	[Address(RVA = "0x613C60", Offset = "0x612460", Length = "0xCE")]
	public void UpdateFishViewWithFishType(DaveFishQuality fishType)
	{
	}

	[Token(Token = "0x6004BC5")]
	[Address(RVA = "0x6127B0", Offset = "0x610FB0", Length = "0x287")]
	private void OnClickToSell()
	{
	}

	[Address(RVA = "0x6126B0", Offset = "0x610EB0", Length = "0xFC")]
	[Token(Token = "0x6004BC6")]
	private void OnClickToClose()
	{
	}

	[Address(RVA = "0x612A40", Offset = "0x611240", Length = "0x3C8")]
	[Token(Token = "0x6004BC7")]
	private void OnClickToShow()
	{
	}

	[Address(RVA = "0x611FF0", Offset = "0x6107F0", Length = "0x51")]
	[Token(Token = "0x6004BC8")]
	private void ChangePhoneIcon(bool isShow)
	{
	}

	[Token(Token = "0x6004BC9")]
	[Address(RVA = "0x612EF0", Offset = "0x6116F0", Length = "0x134")]
	private void PhoneIn()
	{
	}

	[Token(Token = "0x6004BCA")]
	[Address(RVA = "0x613030", Offset = "0x611830", Length = "0xC8")]
	private void PhoneOut()
	{
	}

	[Address(RVA = "0x613B40", Offset = "0x612340", Length = "0x21")]
	[Token(Token = "0x6004BCB")]
	private void SetShowEnable(bool value)
	{
	}

	[Address(RVA = "0x612510", Offset = "0x610D10", Length = "0x194")]
	[Token(Token = "0x6004BCC")]
	private void OnClickAllCollect()
	{
	}

	[Token(Token = "0x6004BCD")]
	[Address(RVA = "0x613100", Offset = "0x611900", Length = "0x150")]
	private void RefreshBtnAllCollect()
	{
	}

	[Token(Token = "0x6004BCE")]
	[Address(RVA = "0x613260", Offset = "0x611A60", Length = "0x2C7")]
	private void RefreshFishScrollView()
	{
	}

	[Token(Token = "0x6004BCF")]
	[Address(RVA = "0x613530", Offset = "0x611D30", Length = "0x609")]
	private void ResetFishViewNavigations()
	{
	}

	[Address(RVA = "0x611E50", Offset = "0x610650", Length = "0x199")]
	[Token(Token = "0x6004BD0")]
	private void CalculateFishExp()
	{
	}

	[Address(RVA = "0x612290", Offset = "0x610A90", Length = "0x202")]
	[Token(Token = "0x6004BD1")]
	private void GetFishUnlockProgress()
	{
	}

	[Token(Token = "0x6004BD2")]
	[Address(RVA = "0x6124A0", Offset = "0x610CA0", Length = "0x62")]
	private void InitImgCacheDic()
	{
	}

	[Token(Token = "0x6004BD3")]
	[Address(RVA = "0x6121B0", Offset = "0x6109B0", Length = "0xD0")]
	private Sprite GetFishImg(string imgName)
	{
		return null;
	}

	[Token(Token = "0x6004BD4")]
	[Address(RVA = "0x612050", Offset = "0x610850", Length = "0x158")]
	private void ClearSpriteCache()
	{
	}

	[Token(Token = "0x6004BD5")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlDaveFishView()
	{
	}
}
