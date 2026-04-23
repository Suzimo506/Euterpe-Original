using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000BD")]
public class DialogSubControl : MonoBehaviour, IPause, IRelease
{
	[Token(Token = "0x20009EE")]
	public enum DialogDir
	{
		[Token(Token = "0x400357D")]
		Up,
		[Token(Token = "0x400357E")]
		Down
	}

	[SerializeField]
	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0x18")]
	private Animator m_Anim;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004E4")]
	private SuperTextMesh m_Text;

	[SerializeField]
	[Token(Token = "0x40004E5")]
	[FieldOffset(Offset = "0x28")]
	private SpriteRenderer m_Bg;

	[SerializeField]
	[Token(Token = "0x40004E6")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_Rect;

	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004E7")]
	private DialogDir m_Dir;

	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40004E8")]
	private GameObject m_HideControl;

	[SerializeField]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004E9")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x9FFC0", Offset = "0x9F3C0")]
	private bool m_IsCanvas;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004EA")]
	[SerializeField]
	private Image m_BgImg;

	[Token(Token = "0x40004EB")]
	private static readonly Vector2 s_MinSize;

	[Token(Token = "0x40004EC")]
	private static readonly Vector2 s_MaxSize;

	[Token(Token = "0x40004ED")]
	private static readonly Vector2 s_CanvasMinSize;

	[Token(Token = "0x40004EE")]
	private static readonly Vector2 s_CanvasMaxSize;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004EF")]
	private DialogMasterControl m_MasterControl;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004F0")]
	private DialogState m_DialogState;

	[Token(Token = "0x1700007E")]
	public DialogState dialogState
	{
		[Address(RVA = "0x429C30", Offset = "0x428430", Length = "0x4")]
		[Token(Token = "0x6000585")]
		get
		{
			return default(DialogState);
		}
	}

	[Token(Token = "0x1700007F")]
	public bool IsGlobal
	{
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x99F8E0", Offset = "0x99E0E0", Length = "0x115")]
	[Token(Token = "0x6000586")]
	public void SetSorting(string sortingName, int order)
	{
	}

	[Address(RVA = "0x99F5D0", Offset = "0x99DDD0", Length = "0x21")]
	[Token(Token = "0x6000587")]
	public void SetHide(bool hide)
	{
	}

	[Address(RVA = "0x99F0C0", Offset = "0x99D8C0", Length = "0xA0")]
	[Token(Token = "0x6000588")]
	public void Init(DialogMasterControl masterControl)
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x99F1B0", Offset = "0x99D9B0", Length = "0x99")]
	public void PlayDialogAnim(DialogState state, float normalize = 0f)
	{
	}

	[Address(RVA = "0x99F410", Offset = "0x99DC10", Length = "0x1BA")]
	[Token(Token = "0x600058A")]
	public void SetDialog(ref GameDialogArgs args)
	{
	}

	[Address(RVA = "0x99F600", Offset = "0x99DE00", Length = "0x2D8")]
	[Token(Token = "0x600058B")]
	public void SetSize(Vector2 size, int type)
	{
	}

	[Address(RVA = "0x99F170", Offset = "0x99D970", Length = "0x37")]
	[Token(Token = "0x600058C")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x99F2C0", Offset = "0x99DAC0", Length = "0x37")]
	[Token(Token = "0x600058D")]
	public void Resume()
	{
	}

	[Address(RVA = "0x99F250", Offset = "0x99DA50", Length = "0x62")]
	[Token(Token = "0x600058F")]
	public void Release(bool isEditor)
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x99F300", Offset = "0x99DB00", Length = "0x100")]
	public void SetBaseImg(Sprite sprite)
	{
	}

	[Address(RVA = "0x99FB60", Offset = "0x99E360", Length = "0xE")]
	[Token(Token = "0x6000591")]
	public DialogSubControl()
	{
	}
}
