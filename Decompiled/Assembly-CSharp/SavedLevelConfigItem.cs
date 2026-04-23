using Assets.Scripts.Database;
using Cpp2ILInjected;
using UI.Components.UguiScrollViewExtend;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200014E")]
public class SavedLevelConfigItem : BaseScrollItem<SavedLevelConfigData, SvSavedLevelConfigContext>
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000812")]
	[SerializeField]
	private GameObject m_AreaInfoShow;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000813")]
	[SerializeField]
	private GameObject m_AreaBtnAddShow;

	[SerializeField]
	[Token(Token = "0x4000814")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_TxtRoleName;

	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000815")]
	private CanvasGroup m_CpMainShow;

	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000816")]
	private GameObject m_ObjSelected;

	[Token(Token = "0x4000817")]
	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	private Image m_ImgRole;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000818")]
	[SerializeField]
	private GameObject m_ObjRoleLocked;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000819")]
	[SerializeField]
	private Image m_ImgElfin;

	[SerializeField]
	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_ObjElfinLocked;

	[SerializeField]
	[Token(Token = "0x400081B")]
	[FieldOffset(Offset = "0x70")]
	private Button m_BtnSelect;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400081C")]
	[SerializeField]
	private Button m_BtnDelete;

	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0x80")]
	private SavedRoleElfinConfigModel m_DataModel;

	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x88")]
	private Assets.Scripts.Database.CharacterInfo m_CharacterInfo;

	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0x90")]
	private ElfinInfo m_ElfinInfo;

	[Token(Token = "0x170000BF")]
	public Button BtnSelect
	{
		[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
		[Token(Token = "0x6000960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C0")]
	public Button BtnDelete
	{
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x5C1440", Offset = "0x5BFC40", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x624600", Offset = "0x622E00", Length = "0x108")]
	[Token(Token = "0x6000962")]
	public override void Init(SvSavedLevelConfigContext context)
	{
	}

	[Token(Token = "0x6000963")]
	[Address(RVA = "0x624ED0", Offset = "0x6236D0", Length = "0x139")]
	public override void UpdateData(SavedLevelConfigData data)
	{
	}

	[Token(Token = "0x6000964")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void Release()
	{
	}

	[Token(Token = "0x6000965")]
	[Address(RVA = "0x624B00", Offset = "0x623300", Length = "0x69")]
	public override void Select()
	{
	}

	[Token(Token = "0x6000966")]
	[Address(RVA = "0x624E60", Offset = "0x623660", Length = "0x69")]
	public override void UnSelect()
	{
	}

	[Token(Token = "0x6000967")]
	[Address(RVA = "0x624A10", Offset = "0x623210", Length = "0xEB")]
	private void OnClickedItem()
	{
	}

	[Token(Token = "0x6000968")]
	[Address(RVA = "0x624710", Offset = "0x622F10", Length = "0xED")]
	private void OnBtnRemoveItem()
	{
	}

	[Address(RVA = "0x624800", Offset = "0x623000", Length = "0x206")]
	[Token(Token = "0x6000969")]
	private void OnClickedItemAndSelectFinished(params int[] selections)
	{
	}

	[Address(RVA = "0x625010", Offset = "0x623810", Length = "0x3C0")]
	[Token(Token = "0x600096A")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600096B")]
	[Address(RVA = "0x6253E0", Offset = "0x623BE0", Length = "0x38")]
	public SavedLevelConfigItem()
	{
		((BaseScrollItem<, >)(object)this)._002Ector();
	}
}
