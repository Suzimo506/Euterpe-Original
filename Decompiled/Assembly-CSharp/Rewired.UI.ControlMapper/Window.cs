using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[AttributeAttribute(Name = "RequireComponent", RVA = "0x82B0", Offset = "0x76B0")]
[Token(Token = "0x2000211")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x82B0", Offset = "0x76B0")]
public class Window : MonoBehaviour
{
	[Token(Token = "0x2000AAA")]
	public class Timer
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400380D")]
		private bool _started;

		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400380E")]
		private float end;

		[Token(Token = "0x17000A33")]
		public bool started
		{
			[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
			[Token(Token = "0x6005B8D")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000A34")]
		public bool finished
		{
			[Address(RVA = "0x634910", Offset = "0x633110", Length = "0x34")]
			[Token(Token = "0x6005B8E")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000A35")]
		public float remaining
		{
			[Token(Token = "0x6005B8F")]
			[Address(RVA = "0x634950", Offset = "0x633150", Length = "0x34")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6005B90")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public Timer()
		{
		}

		[Token(Token = "0x6005B91")]
		[Address(RVA = "0x6348D0", Offset = "0x6330D0", Length = "0x30")]
		public void Start(float length)
		{
		}

		[Token(Token = "0x6005B92")]
		[Address(RVA = "0x634900", Offset = "0x633100", Length = "0x5")]
		public void Stop()
		{
		}
	}

	[Token(Token = "0x4000EF0")]
	[FieldOffset(Offset = "0x18")]
	public Image backgroundImage;

	[Token(Token = "0x4000EF1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject content;

	[Token(Token = "0x4000EF2")]
	[FieldOffset(Offset = "0x28")]
	private bool _initialized;

	[Token(Token = "0x4000EF3")]
	[FieldOffset(Offset = "0x2C")]
	private int _id;

	[Token(Token = "0x4000EF4")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform _rectTransform;

	[Token(Token = "0x4000EF5")]
	[FieldOffset(Offset = "0x38")]
	private Text _titleText;

	[Token(Token = "0x4000EF6")]
	[FieldOffset(Offset = "0x40")]
	private List<Text> _contentText;

	[Token(Token = "0x4000EF7")]
	[FieldOffset(Offset = "0x48")]
	private GameObject _defaultUIElement;

	[Token(Token = "0x4000EF8")]
	[FieldOffset(Offset = "0x50")]
	private Action<int> _updateCallback;

	[Token(Token = "0x4000EF9")]
	[FieldOffset(Offset = "0x58")]
	private Func<int, bool> _isFocusedCallback;

	[Token(Token = "0x4000EFA")]
	[FieldOffset(Offset = "0x60")]
	private Timer _timer;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000EFB")]
	private CanvasGroup _canvasGroup;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000EFC")]
	public UnityAction cancelCallback;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000EFD")]
	private GameObject lastUISelection;

	[Token(Token = "0x170003FF")]
	public bool hasFocus
	{
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x637BE0", Offset = "0x6363E0", Length = "0x49")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000400")]
	public int id
	{
		[Address(RVA = "0x597010", Offset = "0x595810", Length = "0x4")]
		[Token(Token = "0x6001375")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000401")]
	public RectTransform rectTransform
	{
		[Address(RVA = "0x637C60", Offset = "0x636460", Length = "0xA7")]
		[Token(Token = "0x6001376")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000402")]
	public Text titleText
	{
		[Token(Token = "0x6001377")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000403")]
	public List<Text> contentText
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x6001378")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000404")]
	public GameObject defaultUIElement
	{
		[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
		[Token(Token = "0x6001379")]
		get
		{
			return null;
		}
		[Address(RVA = "0x637D40", Offset = "0x636540", Length = "0xC")]
		[Token(Token = "0x600137A")]
		set
		{
		}
	}

	[Token(Token = "0x17000405")]
	public Action<int> updateCallback
	{
		[Address(RVA = "0x46EF80", Offset = "0x46D780", Length = "0x5")]
		[Token(Token = "0x600137B")]
		get
		{
			return null;
		}
		[Address(RVA = "0x51B9F0", Offset = "0x51A1F0", Length = "0xC")]
		[Token(Token = "0x600137C")]
		set
		{
		}
	}

	[Token(Token = "0x17000406")]
	public Timer timer
	{
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		[Token(Token = "0x600137D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000407")]
	public int width
	{
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x637D10", Offset = "0x636510", Length = "0x2F")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x637DD0", Offset = "0x6365D0", Length = "0x72")]
		[Token(Token = "0x600137F")]
		set
		{
		}
	}

	[Token(Token = "0x17000408")]
	public int height
	{
		[Token(Token = "0x6001380")]
		[Address(RVA = "0x637C30", Offset = "0x636430", Length = "0x2F")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x637D50", Offset = "0x636550", Length = "0x72")]
		[Token(Token = "0x6001381")]
		set
		{
		}
	}

	[Token(Token = "0x17000409")]
	protected bool initialized
	{
		[Address(RVA = "0x45A8E0", Offset = "0x4590E0", Length = "0x5")]
		[Token(Token = "0x6001382")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x637660", Offset = "0x635E60", Length = "0x3B")]
	[Token(Token = "0x6001383")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x637B40", Offset = "0x636340", Length = "0x8E")]
	[Token(Token = "0x6001384")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6001385")]
	[Address(RVA = "0x6374E0", Offset = "0x635CE0", Length = "0x110")]
	public virtual void Initialize(int id, Func<int, bool> isFocusedCallback)
	{
	}

	[Address(RVA = "0x637880", Offset = "0x636080", Length = "0x6A")]
	[Token(Token = "0x6001386")]
	public void SetSize(int width, int height)
	{
	}

	[Token(Token = "0x6001387")]
	[Address(RVA = "0x637010", Offset = "0x635810", Length = "0xA7")]
	public void CreateTitleText(GameObject prefab, Vector2 offset)
	{
	}

	[Address(RVA = "0x6370C0", Offset = "0x6358C0", Length = "0x12C")]
	[Token(Token = "0x6001388")]
	public void CreateTitleText(GameObject prefab, Vector2 offset, string text)
	{
	}

	[Token(Token = "0x6001389")]
	[Address(RVA = "0x6362D0", Offset = "0x634AD0", Length = "0xBE")]
	public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset)
	{
	}

	[Token(Token = "0x600138A")]
	[Address(RVA = "0x636390", Offset = "0x634B90", Length = "0x1C1")]
	public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text)
	{
	}

	[Token(Token = "0x600138B")]
	[Address(RVA = "0x636150", Offset = "0x634950", Length = "0x17D")]
	public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset)
	{
	}

	[Token(Token = "0x600138C")]
	[Address(RVA = "0x636150", Offset = "0x634950", Length = "0x17D")]
	public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text)
	{
	}

	[Address(RVA = "0x6367B0", Offset = "0x634FB0", Length = "0x26C")]
	[Token(Token = "0x600138D")]
	public void CreateButton(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string buttonText, UnityAction confirmCallback, UnityAction cancelCallback, bool setDefault)
	{
	}

	[Address(RVA = "0x637430", Offset = "0x635C30", Length = "0xA0")]
	[Token(Token = "0x600138E")]
	public string GetTitleText(string text)
	{
		return null;
	}

	[Address(RVA = "0x6378F0", Offset = "0x6360F0", Length = "0x94")]
	[Token(Token = "0x600138F")]
	public void SetTitleText(string text)
	{
	}

	[Token(Token = "0x6001390")]
	[Address(RVA = "0x637340", Offset = "0x635B40", Length = "0xEE")]
	public string GetContentText(int index)
	{
		return null;
	}

	[Address(RVA = "0x637250", Offset = "0x635A50", Length = "0xEF")]
	[Token(Token = "0x6001391")]
	public float GetContentTextHeight(int index)
	{
		return default(float);
	}

	[Token(Token = "0x6001392")]
	[Address(RVA = "0x637790", Offset = "0x635F90", Length = "0xEF")]
	public void SetContentText(string text, int index)
	{
	}

	[Token(Token = "0x6001393")]
	[Address(RVA = "0x51B9F0", Offset = "0x51A1F0", Length = "0xC")]
	public void SetUpdateCallback(Action<int> callback)
	{
	}

	[Token(Token = "0x6001394")]
	[Address(RVA = "0x637A60", Offset = "0x636260", Length = "0xDB")]
	public virtual void TakeInputFocus()
	{
	}

	[Token(Token = "0x6001395")]
	[Address(RVA = "0x637220", Offset = "0x635A20", Length = "0x20")]
	public virtual void Enable()
	{
	}

	[Token(Token = "0x6001396")]
	[Address(RVA = "0x6371F0", Offset = "0x6359F0", Length = "0x20")]
	public virtual void Disable()
	{
	}

	[Address(RVA = "0x636560", Offset = "0x634D60", Length = "0x17")]
	[Token(Token = "0x6001397")]
	public virtual void Cancel()
	{
	}

	[Address(RVA = "0x636DE0", Offset = "0x6355E0", Length = "0x223")]
	[Token(Token = "0x6001398")]
	private void CreateText(GameObject prefab, ref Text textComponent, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset)
	{
	}

	[Address(RVA = "0x636C80", Offset = "0x635480", Length = "0x156")]
	[Token(Token = "0x6001399")]
	private void CreateImage(GameObject prefab, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset)
	{
	}

	[Token(Token = "0x600139A")]
	[Address(RVA = "0x636A20", Offset = "0x635220", Length = "0x25D")]
	private GameObject CreateButton(GameObject prefab, string name, UIAnchor anchor, UIPivot pivot, Vector2 offset, out ButtonInfo buttonInfo)
	{
		buttonInfo = null;
		return null;
	}

	[Token(Token = "0x600139B")]
	[Address(RVA = "0x6375F0", Offset = "0x635DF0", Length = "0x65")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8520", Offset = "0x7920")]
	private IEnumerator OnEnableAsync()
	{
		return null;
	}

	[Address(RVA = "0x636580", Offset = "0x634D80", Length = "0x220")]
	[Token(Token = "0x600139C")]
	private void CheckUISelection()
	{
	}

	[Address(RVA = "0x6376A0", Offset = "0x635EA0", Length = "0xE3")]
	[Token(Token = "0x600139D")]
	private void RestoreDefaultOrLastUISelection()
	{
	}

	[Token(Token = "0x600139E")]
	[Address(RVA = "0x637990", Offset = "0x636190", Length = "0xC7")]
	private void SetUISelection(GameObject selection)
	{
	}

	[Address(RVA = "0x637BD0", Offset = "0x6363D0", Length = "0xE")]
	[Token(Token = "0x600139F")]
	public Window()
	{
	}
}
