using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200014A")]
public class LevelConfigItem : FancyGridViewCell<LevelConfigItemData, LevelConfigItemGroupContext>
{
	[Token(Token = "0x4000801")]
	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	private Image m_ImgUse;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000802")]
	[SerializeField]
	private Image m_ImgShow;

	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000803")]
	private Image m_ImgLove;

	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000804")]
	private Image m_ImgRandom;

	[Token(Token = "0x4000805")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Button m_Button;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000806")]
	[SerializeField]
	private Color m_BgSelectedColor;

	[Token(Token = "0x4000807")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Color m_BgUnSelectedColor;

	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000808")]
	private GameObject m_LockObj;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000809")]
	[SerializeField]
	private Text m_TextName;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400080A")]
	private LevelConfigItemData m_LevelConfigItemData;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400080B")]
	private PnlLevelConfig m_PnlLevelConfig;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400080C")]
	private string m_SpecialTypeStr;

	[Address(RVA = "0x5D3360", Offset = "0x5D1B60", Length = "0xB4")]
	[Token(Token = "0x6000946")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000947")]
	[Address(RVA = "0x5D3420", Offset = "0x5D1C20", Length = "0x1DA")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000948")]
	[Address(RVA = "0x5D3D40", Offset = "0x5D2540", Length = "0x24")]
	public override void UpdateContent(LevelConfigItemData itemData)
	{
	}

	[Token(Token = "0x6000949")]
	[Address(RVA = "0x5D3600", Offset = "0x5D1E00", Length = "0x734")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600094A")]
	[Address(RVA = "0x5D3D70", Offset = "0x5D2570", Length = "0x4E")]
	public LevelConfigItem()
	{
		((FancyGridViewCell<TItemData, TContext>)(object)this)._002Ector();
	}
}
