using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Events;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Components;

[Token(Token = "0x2000607")]
public class FancyScrollView : SerializedSimplySelectable, IEventSystemHandler, IEndDragHandler, IBeginDragHandler, IPreWarm, IDragHandler
{
	[Token(Token = "0x2000BB7")]
	public enum ScrollDirection
	{
		[Token(Token = "0x4003B12")]
		Vertical,
		[Token(Token = "0x4003B13")]
		Horizontal
	}

	[Token(Token = "0x2000BB8")]
	public enum MovementType
	{
		[Token(Token = "0x4003B15")]
		Loop,
		[Token(Token = "0x4003B16")]
		Elastic,
		[Token(Token = "0x4003B17")]
		Clamped
	}

	[Token(Token = "0x2000BB9")]
	public enum SortType
	{
		[Token(Token = "0x4003B19")]
		None = -1,
		[Token(Token = "0x4003B1A")]
		LeftToRight = 0,
		[Token(Token = "0x4003B1B")]
		MiddleToSide = 1,
		[Token(Token = "0x4003B1C")]
		RightToLeft = 2,
		[Token(Token = "0x4003B1D")]
		Custom = 999
	}

	[Token(Token = "0x2000BBA")]
	public enum DeadAreaDir
	{
		[Token(Token = "0x4003B1F")]
		None,
		[Token(Token = "0x4003B20")]
		Vertical,
		[Token(Token = "0x4003B21")]
		Horizontal
	}

	[Token(Token = "0x2000BBB")]
	public enum SourceType
	{
		[Token(Token = "0x4003B23")]
		Prefabs,
		[Token(Token = "0x4003B24")]
		Children
	}

	[Token(Token = "0x2000BBC")]
	public enum State
	{
		[Token(Token = "0x4003B26")]
		Static,
		[Token(Token = "0x4003B27")]
		Dynamic
	}

	[Token(Token = "0x2000BBD")]
	public delegate void OnProcessBarBeginDrag();

	[Token(Token = "0x2000BBE")]
	public delegate void OnProcessBarEndDrag();

	[Token(Token = "0x40021E0")]
	[FieldOffset(Offset = "0x68")]
	public bool showAdvanceOptions;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4550", Offset = "0x3950")]
	[Token(Token = "0x40021E1")]
	[FieldOffset(Offset = "0x70")]
	public RectTransform content;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40021E2")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4630", Offset = "0x3A30")]
	public SourceType sourceType;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40021E3")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4860", Offset = "0x3C60")]
	public GameObject cellPrefabs;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4950", Offset = "0x3D50")]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0x4950", Offset = "0x3D50")]
	[Token(Token = "0x40021E4")]
	[FieldOffset(Offset = "0x88")]
	public IVariable cellCount;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4D20", Offset = "0x4120")]
	[Token(Token = "0x40021E5")]
	[FieldOffset(Offset = "0x90")]
	public Vector3 childrenDefaultScale;

	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40021E6")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4E50", Offset = "0x4250")]
	public float cellInterval;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50B0", Offset = "0x44B0")]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0x50B0", Offset = "0x44B0")]
	[Token(Token = "0x40021E7")]
	[FieldOffset(Offset = "0xA0")]
	public IVariable cellPlaceholderPrefabs;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40021E8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x53F0", Offset = "0x47F0")]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0x53F0", Offset = "0x47F0")]
	public IVariable minCellCount;

	[Token(Token = "0x40021E9")]
	[FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5840", Offset = "0x4C40")]
	public float cellOffset;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B0", Offset = "0x4DB0")]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0x59B0", Offset = "0x4DB0")]
	[Token(Token = "0x40021EA")]
	[FieldOffset(Offset = "0xB8")]
	public IVariable startIndex;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40021EB")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5CE0", Offset = "0x50E0")]
	public bool dontInit;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5E70", Offset = "0x5270")]
	[Token(Token = "0x40021EC")]
	[FieldOffset(Offset = "0xC1")]
	public bool initOnPrewarm;

	[FieldOffset(Offset = "0xC2")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6030", Offset = "0x5430")]
	[Token(Token = "0x40021ED")]
	public bool disableAutoCache;

	[Token(Token = "0x40021EE")]
	[FieldOffset(Offset = "0xC3")]
	public bool enableDeadArea;

	[Token(Token = "0x40021EF")]
	[FieldOffset(Offset = "0xC4")]
	public DeadAreaDir deadAreaDir;

	[Token(Token = "0x40021F0")]
	[FieldOffset(Offset = "0xC8")]
	public float m_DeadDistance;

	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40021F1")]
	private Vector2 m_MousePosition;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x61A0", Offset = "0x55A0")]
	[Token(Token = "0x40021F2")]
	[FieldOffset(Offset = "0xD8")]
	public RectTransform viewPort;

	[FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6370", Offset = "0x5770")]
	[Token(Token = "0x40021F3")]
	public string animName;

	[FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6490", Offset = "0x5890")]
	[Token(Token = "0x40021F4")]
	public SortType sortType;

	[Token(Token = "0x40021F5")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x65A0", Offset = "0x59A0")]
	[FieldOffset(Offset = "0xEC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65A0", Offset = "0x59A0")]
	public float highestPos;

	[FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6810", Offset = "0x5C10")]
	[Token(Token = "0x40021F6")]
	public Scrollbar processBar;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6930", Offset = "0x5D30")]
	[Token(Token = "0x40021F7")]
	[FieldOffset(Offset = "0xF8")]
	public AudioClip audioClip;

	[SerializeField]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0x6E50", Offset = "0x6250")]
	[Token(Token = "0x40021F8")]
	[FieldOffset(Offset = "0x100")]
	private IVariable m_Volume;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x70E0", Offset = "0x64E0")]
	[Token(Token = "0x40021F9")]
	[FieldOffset(Offset = "0x108")]
	public AudioClip errorAudioClip;

	[FieldOffset(Offset = "0x110")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7450", Offset = "0x6850")]
	[Token(Token = "0x40021FA")]
	public ScrollDirection dragDirection;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75C0", Offset = "0x69C0")]
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x40021FB")]
	public MovementType movementType;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40021FC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7640", Offset = "0x6A40")]
	public float scrollSensitivity;

	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x40021FD")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7690", Offset = "0x6A90")]
	public bool inertia;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7740", Offset = "0x6B40")]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40021FE")]
	public Button btnPrevious;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x78A0", Offset = "0x6CA0")]
	[Token(Token = "0x40021FF")]
	[FieldOffset(Offset = "0x128")]
	public Button btnNext;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x79B0", Offset = "0x6DB0")]
	[Token(Token = "0x4002200")]
	[FieldOffset(Offset = "0x130")]
	public float switchDuration;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7B10", Offset = "0x6F10")]
	[Token(Token = "0x4002201")]
	[FieldOffset(Offset = "0x134")]
	public float longPressTriggerTime;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7C00", Offset = "0x7000")]
	[Token(Token = "0x4002202")]
	[FieldOffset(Offset = "0x138")]
	public float borderMaxOffset;

	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x4002203")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D40", Offset = "0x7140")]
	public bool disableButtonWhenReachBorder;

	[FieldOffset(Offset = "0x13D")]
	[Token(Token = "0x4002204")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF0", Offset = "0x72F0")]
	public bool disableDrag;

	[Token(Token = "0x4002208")]
	[FieldOffset(Offset = "0x14C")]
	private float m_PrevScrollPosition;

	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4002210")]
	public OnProcessBarBeginDrag onProcessBarBeginDrag;

	[Token(Token = "0x4002211")]
	[FieldOffset(Offset = "0x188")]
	public OnProcessBarEndDrag onProcessBarEndDrag;

	[Token(Token = "0x4002212")]
	[FieldOffset(Offset = "0x190")]
	private Vector2 m_PointerStartLocalPosition;

	[Token(Token = "0x4002213")]
	[FieldOffset(Offset = "0x198")]
	private float m_DragStartScrollPosition;

	[FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x4002214")]
	private int m_FinalSelectItemIndex;

	[Token(Token = "0x4002215")]
	[FieldOffset(Offset = "0x1A0")]
	private bool m_LongPressing;

	[Token(Token = "0x4002216")]
	[FieldOffset(Offset = "0x1A1")]
	private bool m_AutoScrolling;

	[Token(Token = "0x4002217")]
	[FieldOffset(Offset = "0x1A2")]
	private bool m_KeepAutoScrolling;

	[Token(Token = "0x4002218")]
	[FieldOffset(Offset = "0x1A3")]
	private bool m_ShouldBorderAutoScroll;

	[FieldOffset(Offset = "0x1A4")]
	[Token(Token = "0x4002219")]
	private float m_AutoScrollDuration;

	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x400221A")]
	private float m_AutoScrollStartTime;

	[FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x400221B")]
	private float m_AutoScrollPosition;

	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400221C")]
	private bool m_HasInit;

	[FieldOffset(Offset = "0x1B1")]
	[Token(Token = "0x400221D")]
	private bool m_FirstInit;

	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x400221E")]
	[HideInInspector]
	[SerializeField]
	private int m_AnimNameHash;

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x400221F")]
	[FieldOffset(Offset = "0x1B8")]
	private float m_DragMulFactor;

	[Token(Token = "0x4002220")]
	[FieldOffset(Offset = "0x1BC")]
	private int m_CellCount;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4002221")]
	private readonly Dictionary<int, OnFancyScrollViewCellUpdate> m_Cells;

	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4002222")]
	private FastPool m_PoolPrefabs;

	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4002223")]
	private FastPool m_PoolPlaceHoldPrefabs;

	[Token(Token = "0x4002224")]
	[FieldOffset(Offset = "0x1D8")]
	private bool isScrollBarDrag;

	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4002225")]
	private float m_ScrollBarPointDownTimer;

	[Token(Token = "0x4002226")]
	[FieldOffset(Offset = "0x1E0")]
	private bool m_ScrollBarIsPointDown;

	[FieldOffset(Offset = "0x1E1")]
	[Token(Token = "0x4002227")]
	private bool m_ScrollBarPlayPointDownAnim;

	[Token(Token = "0x4002228")]
	[FieldOffset(Offset = "0x1E2")]
	private bool m_PointerDownToScroll;

	[Token(Token = "0x17000577")]
	public bool loop
	{
		[Address(RVA = "0x744930", Offset = "0x743130", Length = "0xB")]
		[Token(Token = "0x6003ABB")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000578")]
	public float velocity
	{
		[CompilerGenerated]
		[Address(RVA = "0x744960", Offset = "0x743160", Length = "0x9")]
		[Token(Token = "0x6003ABC")]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		[Token(Token = "0x6003ABD")]
		[Address(RVA = "0x744CD0", Offset = "0x7434D0", Length = "0x9")]
		private set
		{
		}
	}

	[Token(Token = "0x17000579")]
	public bool dragging
	{
		[CompilerGenerated]
		[Address(RVA = "0x7448E0", Offset = "0x7430E0", Length = "0x8")]
		[Token(Token = "0x6003ABE")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x6003ABF")]
		[Address(RVA = "0x744CA0", Offset = "0x7434A0", Length = "0x7")]
		private set
		{
		}
	}

	[Token(Token = "0x1700057A")]
	public float currentScrollPosition
	{
		[Address(RVA = "0x7448D0", Offset = "0x7430D0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6003AC0")]
		get
		{
			return default(float);
		}
		[Address(RVA = "0x744C90", Offset = "0x743490", Length = "0x9")]
		[Token(Token = "0x6003AC1")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700057B")]
	public float expectCurrentScollPosition
	{
		[Token(Token = "0x6003AC2")]
		[Address(RVA = "0x7448F0", Offset = "0x7430F0", Length = "0x1B")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700057C")]
	public int selectItemIndex
	{
		[CompilerGenerated]
		[Token(Token = "0x6003AC3")]
		[Address(RVA = "0x744940", Offset = "0x743140", Length = "0x7")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003AC4")]
		[Address(RVA = "0x744CB0", Offset = "0x7434B0", Length = "0x7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700057D")]
	public State state
	{
		[Token(Token = "0x6003AC5")]
		[Address(RVA = "0x744950", Offset = "0x743150", Length = "0x7")]
		[CompilerGenerated]
		get
		{
			return default(State);
		}
		[CompilerGenerated]
		[Address(RVA = "0x744CC0", Offset = "0x7434C0", Length = "0x7")]
		[Token(Token = "0x6003AC6")]
		set
		{
		}
	}

	[Token(Token = "0x1700057E")]
	public bool hasInited
	{
		[Token(Token = "0x6003AD1")]
		[Address(RVA = "0x744910", Offset = "0x743110", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700057F")]
	public int itemCount
	{
		[Address(RVA = "0x744920", Offset = "0x743120", Length = "0x7")]
		[Token(Token = "0x6003AD2")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1400004F")]
	public event UnityAction<int> onFinalItemIndexChange
	{
		[Token(Token = "0x6003AC7")]
		[Address(RVA = "0x7446F0", Offset = "0x742EF0", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003AC8")]
		[Address(RVA = "0x744AB0", Offset = "0x7432B0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000050")]
	public event UnityAction<int> onItemIndexChange
	{
		[Token(Token = "0x6003AC9")]
		[Address(RVA = "0x744790", Offset = "0x742F90", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003ACA")]
		[CompilerGenerated]
		[Address(RVA = "0x744B50", Offset = "0x743350", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000051")]
	public event UnityAction<float> onUpdatePosition
	{
		[Address(RVA = "0x744830", Offset = "0x743030", Length = "0x9E")]
		[Token(Token = "0x6003ACB")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003ACC")]
		[Address(RVA = "0x744BF0", Offset = "0x7433F0", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000052")]
	public event Action<GameObject> onCreatedItem
	{
		[Address(RVA = "0x744650", Offset = "0x742E50", Length = "0x9E")]
		[Token(Token = "0x6003ACD")]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003ACE")]
		[Address(RVA = "0x744A10", Offset = "0x743210", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000053")]
	public event Action<State> OnStateChange
	{
		[CompilerGenerated]
		[Address(RVA = "0x7445B0", Offset = "0x742DB0", Length = "0x9E")]
		[Token(Token = "0x6003ACF")]
		add
		{
		}
		[Address(RVA = "0x744970", Offset = "0x743170", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6003AD0")]
		remove
		{
		}
	}

	[Token(Token = "0x6003ABA")]
	[Address(RVA = "0x742A10", Offset = "0x741210", Length = "0x46")]
	private void UpdateHighestPos()
	{
	}

	[Address(RVA = "0x741AE0", Offset = "0x7402E0", Length = "0x76")]
	[Token(Token = "0x6003AD3")]
	public void Rebuild()
	{
	}

	[Address(RVA = "0x741B60", Offset = "0x740360", Length = "0xC1")]
	[Token(Token = "0x6003AD4")]
	public void Rebuild(GameObject prefabs)
	{
	}

	[Token(Token = "0x6003AD5")]
	[Address(RVA = "0x741A00", Offset = "0x740200", Length = "0xDC")]
	public void Rebuild(GameObject[] childrens)
	{
	}

	[Address(RVA = "0x7414F0", Offset = "0x73FCF0", Length = "0x185")]
	[Token(Token = "0x6003AD6")]
	private void RebuildChildren()
	{
	}

	[Token(Token = "0x6003AD7")]
	[Address(RVA = "0x741680", Offset = "0x73FE80", Length = "0x37E")]
	private void RebuildPrefabs()
	{
	}

	[Token(Token = "0x6003AD8")]
	[Address(RVA = "0x742530", Offset = "0x740D30", Length = "0xFF")]
	public void SetPrefabModeCellCount(int count)
	{
	}

	[Token(Token = "0x6003AD9")]
	[Address(RVA = "0x741EE0", Offset = "0x7406E0", Length = "0x245")]
	public void ScrollToDataIndex(int dataIndex, float duration, bool timeRelToDis = true, int dirTendFlag = 0)
	{
	}

	[Address(RVA = "0x742130", Offset = "0x740930", Length = "0xA7")]
	[Token(Token = "0x6003ADA")]
	public void ScrollToDataUid(string uid, float duration, bool timeRelToDis = true, int dirTendFlag = 0)
	{
	}

	[Token(Token = "0x6003ADB")]
	[Address(RVA = "0x742410", Offset = "0x740C10", Length = "0x112")]
	public void ScrollTo(float position, float duration, bool timeRelToDis = true, int dirTendFlag = 0)
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBC50", Offset = "0xB050")]
	[Token(Token = "0x6003ADC")]
	[Address(RVA = "0x740F00", Offset = "0x73F700", Length = "0x9E")]
	public IEnumerator PlayScrollTo(int dataIndex, float duration, bool timeRelToDis = true)
	{
		return null;
	}

	[Address(RVA = "0x7421E0", Offset = "0x7409E0", Length = "0xCA")]
	[Token(Token = "0x6003ADD")]
	public void ScrollToNext(float time)
	{
	}

	[Address(RVA = "0x7422B0", Offset = "0x740AB0", Length = "0x15D")]
	[Token(Token = "0x6003ADE")]
	public void ScrollToPrevious(float time)
	{
	}

	[Token(Token = "0x6003ADF")]
	[Address(RVA = "0x73F1F0", Offset = "0x73D9F0", Length = "0x6F")]
	public int GetLoop(float pos)
	{
		return default(int);
	}

	[Address(RVA = "0x73F530", Offset = "0x73DD30", Length = "0xF0")]
	[Token(Token = "0x6003AE0")]
	public float GetUnloopPosition(float loopPos)
	{
		return default(float);
	}

	[Token(Token = "0x6003AE1")]
	[Address(RVA = "0x73F2D0", Offset = "0x73DAD0", Length = "0x259")]
	public int GetUnloopIndex(int dataIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6003AE2")]
	[Address(RVA = "0x73F130", Offset = "0x73D930", Length = "0x36")]
	public int GetLoopIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6003AE3")]
	[Address(RVA = "0x73F170", Offset = "0x73D970", Length = "0x7D")]
	public float GetLoopPosition(float position)
	{
		return default(float);
	}

	[Token(Token = "0x6003AE4")]
	[Address(RVA = "0x73F010", Offset = "0x73D810", Length = "0x80")]
	public OnFancyScrollViewCellUpdate GetCellByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6003AE5")]
	[Address(RVA = "0x73F0A0", Offset = "0x73D8A0", Length = "0x8D")]
	public OnFancyScrollViewCellUpdate GetCell(int dataIndex)
	{
		return null;
	}

	[Token(Token = "0x6003AE6")]
	[Address(RVA = "0x741DD0", Offset = "0x7405D0", Length = "0x53")]
	public void RemoveCell(int cellIndex)
	{
	}

	[Address(RVA = "0x7400C0", Offset = "0x73E8C0", Length = "0x13F")]
	[Token(Token = "0x6003AE7")]
	private void LongPressToNext(bool isLongPress = true)
	{
	}

	[Token(Token = "0x6003AE8")]
	[Address(RVA = "0x740200", Offset = "0x73EA00", Length = "0x1A9")]
	private void LongPressToPrevious(bool isLongPress = true)
	{
	}

	[Address(RVA = "0x73FFC0", Offset = "0x73E7C0", Length = "0x79")]
	[Token(Token = "0x6003AE9")]
	private void LongPressNextUp()
	{
	}

	[Address(RVA = "0x740040", Offset = "0x73E840", Length = "0x72")]
	[Token(Token = "0x6003AEA")]
	private void LongPressPreviousUp()
	{
	}

	[Address(RVA = "0x7403B0", Offset = "0x73EBB0", Length = "0x19C")]
	[Token(Token = "0x6003AEB")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6003AEC")]
	[Address(RVA = "0x7405E0", Offset = "0x73EDE0", Length = "0x414")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x740A80", Offset = "0x73F280", Length = "0x2C")]
	[Token(Token = "0x6003AED")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x740FA0", Offset = "0x73F7A0", Length = "0x549")]
	[Token(Token = "0x6003AEE")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x742630", Offset = "0x740E30", Length = "0x73")]
	[Token(Token = "0x6003AEF")]
	protected override void Start()
	{
	}

	[Address(RVA = "0x740A00", Offset = "0x73F200", Length = "0x7F")]
	[Token(Token = "0x6003AF0")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6003AF1")]
	[Address(RVA = "0x73FF80", Offset = "0x73E780", Length = "0x3C")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6003AF2")]
	[Address(RVA = "0x740550", Offset = "0x73ED50", Length = "0x8E")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003AF3")]
	[Address(RVA = "0x743F20", Offset = "0x742720", Length = "0x546")]
	private void Update()
	{
	}

	[Token(Token = "0x6003AF4")]
	[Address(RVA = "0x743EA0", Offset = "0x7426A0", Length = "0x79")]
	private void UpdateState()
	{
	}

	[Token(Token = "0x6003AF5")]
	[Address(RVA = "0x73EC60", Offset = "0x73D460", Length = "0x1B4")]
	private OnFancyScrollViewCellUpdate CreateNewCell(int dataIndex)
	{
		return null;
	}

	[Address(RVA = "0x743590", Offset = "0x741D90", Length = "0x90D")]
	[Token(Token = "0x6003AF6")]
	private void UpdatePosition(float position)
	{
	}

	[Token(Token = "0x6003AF7")]
	[Address(RVA = "0x740B70", Offset = "0x73F370", Length = "0xAE")]
	private void OnScrollBarDragBegin()
	{
	}

	[Address(RVA = "0x740C40", Offset = "0x73F440", Length = "0x6A")]
	[Token(Token = "0x6003AF8")]
	private void OnScrollBarValueChange()
	{
	}

	[Address(RVA = "0x740C20", Offset = "0x73F420", Length = "0x18")]
	[Token(Token = "0x6003AF9")]
	private void OnScrollBarDragEnd()
	{
	}

	[Address(RVA = "0x740AB0", Offset = "0x73F2B0", Length = "0x16")]
	[Token(Token = "0x6003AFA")]
	private void OnPointerDownScrollBar()
	{
	}

	[Address(RVA = "0x740AD0", Offset = "0x73F2D0", Length = "0x95")]
	[Token(Token = "0x6003AFB")]
	private void OnPointerUpScrollBar()
	{
	}

	[Token(Token = "0x6003AFC")]
	[Address(RVA = "0x742A60", Offset = "0x741260", Length = "0xB2D")]
	private void UpdatePositionWithScrollBar(float position)
	{
	}

	[Token(Token = "0x6003AFD")]
	[Address(RVA = "0x73F6B0", Offset = "0x73DEB0", Length = "0x8CA")]
	private void InitCommonData()
	{
	}

	[Address(RVA = "0x73FF80", Offset = "0x73E780", Length = "0x3C")]
	[Token(Token = "0x6003AFE")]
	private void InitData()
	{
	}

	[Token(Token = "0x6003AFF")]
	[Address(RVA = "0x741C30", Offset = "0x740430", Length = "0xA9")]
	private void ReleaseAllCell()
	{
	}

	[Address(RVA = "0x73EE20", Offset = "0x73D620", Length = "0x18B")]
	[Token(Token = "0x6003B00")]
	private void DestroyAllChildren()
	{
	}

	[Token(Token = "0x6003B01")]
	[Address(RVA = "0x741CE0", Offset = "0x7404E0", Length = "0xEE")]
	private void ReleaseCell(int cellIndex)
	{
	}

	[Address(RVA = "0x740CB0", Offset = "0x73F4B0", Length = "0x180")]
	[Token(Token = "0x6003B02")]
	private OnFancyScrollViewCellUpdate PackageCellGo(GameObject cellGo)
	{
		return null;
	}

	[Address(RVA = "0x740E40", Offset = "0x73F640", Length = "0x22")]
	[Token(Token = "0x6003B03")]
	private OnFancyScrollViewCellUpdate PackagePlaceHolderCellGo(GameObject cellGo)
	{
		return null;
	}

	[Address(RVA = "0x73F620", Offset = "0x73DE20", Length = "0x8D")]
	[Token(Token = "0x6003B04")]
	private float GetViewportSize()
	{
		return default(float);
	}

	[Address(RVA = "0x73F260", Offset = "0x73DA60", Length = "0x67")]
	[Token(Token = "0x6003B05")]
	private float GetSizeDeltaSize()
	{
		return default(float);
	}

	[Address(RVA = "0x73EAD0", Offset = "0x73D2D0", Length = "0x18F")]
	[Token(Token = "0x6003B06")]
	private int CalculateTarget(float currentPosition, float velocity, float delta)
	{
		return default(int);
	}

	[Address(RVA = "0x73EA90", Offset = "0x73D290", Length = "0x39")]
	[Token(Token = "0x6003B07")]
	private float CalculateOffset(float position)
	{
		return default(float);
	}

	[Token(Token = "0x6003B08")]
	[Address(RVA = "0x742960", Offset = "0x741160", Length = "0x46")]
	private void UpdateCellData(OnFancyScrollViewCellUpdate cell, int dataIndex)
	{
	}

	[Address(RVA = "0x7429B0", Offset = "0x7411B0", Length = "0x53")]
	[Token(Token = "0x6003B09")]
	private void UpdateCellVisibleByIndex(OnFancyScrollViewCellUpdate cell, int cellIndex)
	{
	}

	[Address(RVA = "0x741E30", Offset = "0x740630", Length = "0xA7")]
	[Token(Token = "0x6003B0A")]
	private float RubberDelta(float overStretching, float viewSize)
	{
		return default(float);
	}

	[Address(RVA = "0x73E860", Offset = "0x73D060", Length = "0x22B")]
	[Token(Token = "0x6003B0B")]
	private float CalculateClosestPosition(float scrollPosition, int dictTendFlag)
	{
		return default(float);
	}

	[Address(RVA = "0x73EFB0", Offset = "0x73D7B0", Length = "0x55")]
	[Token(Token = "0x6003B0C")]
	private float EaseInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6003B0D")]
	[Address(RVA = "0x740E70", Offset = "0x73F670", Length = "0x8E")]
	private void PlayOneShot(AudioClip clip)
	{
	}

	[Token(Token = "0x6003B0E")]
	[Address(RVA = "0x744470", Offset = "0x742C70", Length = "0x131")]
	public FancyScrollView()
	{
	}
}
