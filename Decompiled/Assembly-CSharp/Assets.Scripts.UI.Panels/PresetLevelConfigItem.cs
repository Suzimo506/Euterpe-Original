using Assets.Scripts.Database;
using Cpp2ILInjected;
using UI.Components.UguiScrollViewExtend;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008EC")]
public class PresetLevelConfigItem : BaseScrollItem<SavedLevelConfigData, SvSavedLevelConfigContext>
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002F6B")]
	[SerializeField]
	private Button m_BtnSelect;

	[SerializeField]
	[Token(Token = "0x4002F6C")]
	[FieldOffset(Offset = "0x30")]
	private Image m_ImgRole;

	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4002F6D")]
	private GameObject m_ObjRoleLocked;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002F6E")]
	[SerializeField]
	private Image m_ImgElfin;

	[Token(Token = "0x4002F6F")]
	[SerializeField]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_ObjElfinLocked;

	[Token(Token = "0x4002F70")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject m_ObjSelected;

	[Token(Token = "0x4002F71")]
	[FieldOffset(Offset = "0x58")]
	private SavedRoleElfinConfigModel m_DataModel;

	[Token(Token = "0x4002F72")]
	[FieldOffset(Offset = "0x60")]
	private Assets.Scripts.Database.CharacterInfo m_CharacterInfo;

	[Token(Token = "0x4002F73")]
	[FieldOffset(Offset = "0x68")]
	private ElfinInfo m_ElfinInfo;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002F74")]
	private bool m_IsRoleUnlocked;

	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x4002F75")]
	private bool m_IsElfinUnlocked;

	[Address(RVA = "0x4CFE70", Offset = "0x4CE670", Length = "0xB6")]
	[Token(Token = "0x60050EF")]
	public override void Init(SvSavedLevelConfigContext context = null)
	{
	}

	[Address(RVA = "0x4D00A0", Offset = "0x4CE8A0", Length = "0x166")]
	[Token(Token = "0x60050F0")]
	public override void UpdateData(SavedLevelConfigData data)
	{
	}

	[Token(Token = "0x60050F1")]
	[Address(RVA = "0x4CFF30", Offset = "0x4CE730", Length = "0x50")]
	public override void Select()
	{
	}

	[Address(RVA = "0x4D0040", Offset = "0x4CE840", Length = "0x50")]
	[Token(Token = "0x60050F2")]
	public override void UnSelect()
	{
	}

	[Address(RVA = "0x4D0210", Offset = "0x4CEA10", Length = "0x2CA")]
	[Token(Token = "0x60050F3")]
	private void UpdateView()
	{
	}

	[Address(RVA = "0x4D04E0", Offset = "0x4CECE0", Length = "0x38")]
	[Token(Token = "0x60050F4")]
	public PresetLevelConfigItem()
	{
		((BaseScrollItem<, >)(object)this)._002Ector();
	}
}
