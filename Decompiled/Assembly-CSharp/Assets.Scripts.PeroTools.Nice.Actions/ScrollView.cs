using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200062B")]
public class ScrollView : Action
{
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0x1C430", Offset = "0x1B830")]
	[SerializeField]
	[Token(Token = "0x40022BD")]
	[FieldOffset(Offset = "0x10")]
	private IVariable m_ScrollSpace;

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40022BE")]
	private ContentType m_ContentType;

	[SerializeField]
	[Token(Token = "0x40022BF")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_Prefab;

	[Token(Token = "0x40022C0")]
	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	private List<GameObject> m_SceneObjects;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40022C1")]
	[SerializeField]
	private ScrollDirection m_Direction;

	[SerializeField]
	[Token(Token = "0x40022C2")]
	[FieldOffset(Offset = "0x38")]
	private Scrollbar m_Scrollbar;

	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40022C3")]
	private float m_ScrollSensitivity;

	[Token(Token = "0x40022C4")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private Vector4 m_Padding;

	[SerializeField]
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40022C5")]
	private float m_Spacing;

	[SerializeField]
	[Token(Token = "0x40022C6")]
	[FieldOffset(Offset = "0x58")]
	private TextAnchor m_ChildAlignment;

	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40022C7")]
	[SerializeField]
	private bool m_ChildControlWidth;

	[SerializeField]
	[Token(Token = "0x40022C8")]
	[FieldOffset(Offset = "0x5D")]
	private bool m_ChildControlHeight;

	[SerializeField]
	[FieldOffset(Offset = "0x5E")]
	[Token(Token = "0x40022C9")]
	private bool m_ChildForceExpandWidth;

	[FieldOffset(Offset = "0x5F")]
	[Token(Token = "0x40022CA")]
	[SerializeField]
	private bool m_ChildForceExpandHeight;

	[SerializeField]
	[Token(Token = "0x40022CB")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsAlign;

	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40022CC")]
	[SerializeField]
	private float m_MidPosition;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40022CD")]
	[SerializeField]
	private Vector2 m_ScaleRate;

	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40022CE")]
	private float m_ScaleRange;

	[SerializeField]
	[Token(Token = "0x40022CF")]
	[FieldOffset(Offset = "0x78")]
	private Button m_BtnSwitchLeftUp;

	[SerializeField]
	[Token(Token = "0x40022D0")]
	[FieldOffset(Offset = "0x80")]
	private Button m_BtnSwitchRightDown;

	[Token(Token = "0x40022D1")]
	[SerializeField]
	[FieldOffset(Offset = "0x88")]
	private AudioClip m_AudioClip;

	[Token(Token = "0x40022D2")]
	[AttributeAttribute(Name = "VariableAttribute", RVA = "0x1D010", Offset = "0x1C410")]
	[SerializeField]
	[FieldOffset(Offset = "0x90")]
	private IVariable m_Count;

	[Token(Token = "0x40022D3")]
	private const float speedThreshold = 200f;

	[Token(Token = "0x40022D4")]
	private const float moveBackTime = 0.4f;

	[Token(Token = "0x40022D5")]
	private const Ease stopCurve = Ease.InExpo;

	[Token(Token = "0x40022D6")]
	private const float moveSpeed = 1200f;

	[Token(Token = "0x40022D7")]
	private const Ease moveCurve = Ease.Linear;

	[Token(Token = "0x40022D8")]
	private const float elasticity = 0.1f;

	[Token(Token = "0x40022D9")]
	private const float decelerationRate = 0.135f;

	[HideInInspector]
	[Token(Token = "0x40022DE")]
	[FieldOffset(Offset = "0xB8")]
	public int index;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40022DF")]
	private List<Transform> m_Children;

	[Token(Token = "0x40022E0")]
	[FieldOffset(Offset = "0xC8")]
	private bool m_IsDragging;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40022E1")]
	private Tweener m_ScrollTwner;

	[Token(Token = "0x40022E2")]
	[FieldOffset(Offset = "0xD8")]
	private Tweener m_PageTwner;

	[Token(Token = "0x40022E3")]
	[FieldOffset(Offset = "0xE0")]
	private Tweener m_ToTwner;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40022E4")]
	private GameObject m_Layout;

	[Token(Token = "0x17000590")]
	public ScrollRect scrollRect
	{
		[Address(RVA = "0x49A8E0", Offset = "0x4990E0", Length = "0x8")]
		[Token(Token = "0x6003BBD")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0x49A9D0", Offset = "0x4991D0", Length = "0xF")]
		[Token(Token = "0x6003BBC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000059")]
	public event Action<int> onIndexChanged
	{
		[Address(RVA = "0x74AF30", Offset = "0x749730", Length = "0x9E")]
		[Token(Token = "0x6003BB6")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003BB7")]
		[CompilerGenerated]
		[Address(RVA = "0x74B110", Offset = "0x749910", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x1400005A")]
	public event Action<Vector2> onValueChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x6003BB8")]
		[Address(RVA = "0x74B070", Offset = "0x749870", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x6003BB9")]
		[Address(RVA = "0x74B250", Offset = "0x749A50", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400005B")]
	public event Action<int, float> onScrollTo
	{
		[CompilerGenerated]
		[Token(Token = "0x6003BBA")]
		[Address(RVA = "0x74AFD0", Offset = "0x7497D0", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x6003BBB")]
		[CompilerGenerated]
		[Address(RVA = "0x74B1B0", Offset = "0x7499B0", Length = "0x9E")]
		remove
		{
		}
	}

	[Address(RVA = "0x749810", Offset = "0x748010", Length = "0x331")]
	[Token(Token = "0x6003BBE")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x749B50", Offset = "0x748350", Length = "0x66")]
	[Token(Token = "0x6003BBF")]
	public Tweener ScrollToIdx(int i, float time = 0f)
	{
		return null;
	}

	[Address(RVA = "0x74AEB0", Offset = "0x7496B0", Length = "0x73")]
	[Token(Token = "0x6003BC0")]
	public ScrollView()
	{
	}
}
