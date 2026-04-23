using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200007D")]
public class UISelectManage : SerializedMonoBehaviour
{
	[Token(Token = "0x400032C")]
	protected const string img_selected = "ImgSelected";

	[Token(Token = "0x400032D")]
	[SerializeField]
	[FieldOffset(Offset = "0x58")]
	private PanelSpecialType m_PanelSpecial;

	[SerializeField]
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400032E")]
	private PanelType m_Panel;

	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x60")]
	public bool hasNavigationFunciton;

	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x68")]
	public GameObject defaultSelect;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79380", Offset = "0x78780")]
	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x70")]
	public bool forceOnDefaultSelect;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000332")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79500", Offset = "0x78900")]
	public UISelectManage deactivatePanel;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000333")]
	public AudioClip onSelectAudio;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000334")]
	public bool playSelectAudioOnInit;

	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x89")]
	private bool m_PlayOnInit;

	[FieldOffset(Offset = "0x8A")]
	[Token(Token = "0x4000336")]
	public bool hasButtonBlinding;

	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x90")]
	public string buttonUp;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000338")]
	public string buttonDown;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000339")]
	public string buttonLeft;

	[Token(Token = "0x400033A")]
	[FieldOffset(Offset = "0xA8")]
	public string buttonRight;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400033B")]
	public bool hasEdgeAnim;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400033C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x796F0", Offset = "0x78AF0")]
	public List<Vector2> edgeAnimManager;

	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0xC0")]
	public AudioClip onEdgeAudio;

	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0xC8")]
	protected bool isOnEdgeAnim;

	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x400033F")]
	private ButtonDirection m_NullDir;

	[Token(Token = "0x4000340")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_IsGetAxis;

	[Token(Token = "0x4000341")]
	[FieldOffset(Offset = "0xD8")]
	private Sequence m_Sequence;

	[Token(Token = "0x4000342")]
	[FieldOffset(Offset = "0xE0")]
	private Vector3 m_OrgPos;

	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0xEC")]
	private bool m_IsExcuteAnim;

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000344")]
	private bool[] m_FunctionBools;

	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0xF8")]
	protected GameObject lastSelectedObj;

	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0x100")]
	private List<GameObject> m_SelectableObj;

	[Token(Token = "0x4000348")]
	[FieldOffset(Offset = "0x110")]
	private string[] m_DirStrings;

	[Token(Token = "0x17000069")]
	public bool isPopup
	{
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x4E8C40", Offset = "0x4E7440", Length = "0x7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006A")]
	public PanelType panelType
	{
		[Address(RVA = "0x4E8C70", Offset = "0x4E7470", Length = "0x4")]
		[Token(Token = "0x60003A8")]
		get
		{
			return default(PanelType);
		}
	}

	[Token(Token = "0x1700006B")]
	public PanelSpecialType panelSpecialType
	{
		[Address(RVA = "0x4E8C60", Offset = "0x4E7460", Length = "0x4")]
		[Token(Token = "0x60003A9")]
		get
		{
			return default(PanelSpecialType);
		}
	}

	[Token(Token = "0x1700006C")]
	public List<GameObject> SelectableObjs
	{
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x4E8C20", Offset = "0x4E7420", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006D")]
	public GameObject lastSelectedGameObject
	{
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x4E8C50", Offset = "0x4E7450", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006E")]
	private bool ignoreStack
	{
		[Address(RVA = "0x4E8C30", Offset = "0x4E7430", Length = "0x8")]
		[Token(Token = "0x60003B6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<GameObject> onSelectObjChange
	{
		[Address(RVA = "0x4E8B80", Offset = "0x4E7380", Length = "0x9E")]
		[Token(Token = "0x60003AD")]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[Address(RVA = "0x4E8CE0", Offset = "0x4E74E0", Length = "0x9E")]
		[Token(Token = "0x60003AE")]
		remove
		{
		}
	}

	[Address(RVA = "0x4E8C80", Offset = "0x4E7480", Length = "0x5B")]
	[Token(Token = "0x60003AB")]
	private bool m_IsHasSelectAudio()
	{
		return default(bool);
	}

	[Address(RVA = "0x4E7B40", Offset = "0x4E6340", Length = "0x7A")]
	[Token(Token = "0x60003AF")]
	protected void SendSelectedItemChangeMsg()
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x4E6330", Offset = "0x4E4B30", Length = "0xC5")]
	private void Awake()
	{
	}

	[Address(RVA = "0x4E7B30", Offset = "0x4E6330", Length = "0xF")]
	[Token(Token = "0x60003B1")]
	public void ReflushSelectableObj(List<GameObject> reflushed)
	{
	}

	[Address(RVA = "0x4E81B0", Offset = "0x4E69B0", Length = "0x1BA")]
	[Token(Token = "0x60003B2")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x4E73D0", Offset = "0x4E5BD0", Length = "0x51")]
	public virtual bool IsThisUiManager()
	{
		return default(bool);
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x4E8370", Offset = "0x4E6B70", Length = "0x5DB")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x4E7660", Offset = "0x4E5E60", Length = "0xC1")]
	protected virtual void OnAxisDown(ButtonDirection dir, ButtonDirection nullDir, GameObject current, GameObject lastGameObject)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x4E7880", Offset = "0x4E6080", Length = "0x17E")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x4E7800", Offset = "0x4E6000", Length = "0x75")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x4E7C50", Offset = "0x4E6450", Length = "0x1CA")]
	public void SetEnable(bool enable, bool needToSetDefault = true)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x4E7250", Offset = "0x4E5A50", Length = "0x170")]
	public bool IsOnSelectableObj(GameObject current)
	{
		return default(bool);
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x4E7F90", Offset = "0x4E6790", Length = "0x15F")]
	protected void SetPanelBindings()
	{
	}

	[Address(RVA = "0x4E7E20", Offset = "0x4E6620", Length = "0x169")]
	[Token(Token = "0x60003BC")]
	public virtual void SetKeyBindings(GameObject obj, bool enable, bool isStart = false)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x4E7B30", Offset = "0x4E6330", Length = "0xF")]
	protected void SetSelectableObjList(List<GameObject> objs)
	{
	}

	[Address(RVA = "0x4E6700", Offset = "0x4E4F00", Length = "0x112")]
	[Token(Token = "0x60003BE")]
	protected void CloseAllStackPopup()
	{
	}

	[Address(RVA = "0x4E6FE0", Offset = "0x4E57E0", Length = "0x147")]
	[Token(Token = "0x60003BF")]
	protected void GetButtonDown(ButtonDirection dir)
	{
	}

	[Address(RVA = "0x4E7130", Offset = "0x4E5930", Length = "0x42")]
	[Token(Token = "0x60003C0")]
	private Selectable GetCurrentSelectable(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x4E7430", Offset = "0x4E5C30", Length = "0x223")]
	private void MoveToSelectable(Selectable obj, ButtonDirection dir)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x4E6D10", Offset = "0x4E5510", Length = "0x127")]
	private Selectable FindSelect(Selectable obj, ButtonDirection dir)
	{
		return null;
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x4E6400", Offset = "0x4E4C00", Length = "0x3F")]
	private ButtonDirection AxisToButton(float h, float v)
	{
		return default(ButtonDirection);
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x4E6E40", Offset = "0x4E5640", Length = "0x192")]
	private ButtonDirection GetAxisDown()
	{
		return default(ButtonDirection);
	}

	[Address(RVA = "0x4E6440", Offset = "0x4E4C40", Length = "0x1D9")]
	[Token(Token = "0x60003C5")]
	private ButtonDirection CheckDirIsNull(GameObject obj)
	{
		return default(ButtonDirection);
	}

	[Address(RVA = "0x4E6820", Offset = "0x4E5020", Length = "0x4EA")]
	[Token(Token = "0x60003C6")]
	private void ExcuteEdgeAnim(GameObject current, ButtonDirection dir)
	{
	}

	[Address(RVA = "0x4E7180", Offset = "0x4E5980", Length = "0xC8")]
	[Token(Token = "0x60003C7")]
	protected Vector3 GetEdgeAnimPos(ButtonDirection dir, float vaule)
	{
		return default(Vector3);
	}

	[Address(RVA = "0x4E6620", Offset = "0x4E4E20", Length = "0xD4")]
	[Token(Token = "0x60003C8")]
	protected void CleanEdgeAnim(GameObject current)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x4E7A70", Offset = "0x4E6270", Length = "0xBE")]
	private void PlayAudio(AudioClip clip)
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void OnAwake()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void OnInit()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60003CC")]
	public virtual void OnStart()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	public virtual GameObject DefaultSelectObj()
	{
		return null;
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected virtual void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x4E7A00", Offset = "0x4E6200", Length = "0x67")]
	protected virtual void OnSelectEmpty(GameObject lastSelObj)
	{
	}

	[Address(RVA = "0x4E7BC0", Offset = "0x4E63C0", Length = "0x8B")]
	[Token(Token = "0x60003D0")]
	public virtual Transform SetEdgeObj(GameObject currentObj)
	{
		return null;
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x4E80F0", Offset = "0x4E68F0", Length = "0xB8")]
	public virtual List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void OnEnablePnl()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void AfterSelectDefaultObj()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60003D4")]
	public virtual void OnDisablePnl()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void OnUpdatePnl()
	{
	}

	[Address(RVA = "0x4E7730", Offset = "0x4E5F30", Length = "0xCE")]
	[Token(Token = "0x60003D6")]
	public virtual void OnCheckNullDir()
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x4E8950", Offset = "0x4E7150", Length = "0x223")]
	public UISelectManage()
	{
	}
}
