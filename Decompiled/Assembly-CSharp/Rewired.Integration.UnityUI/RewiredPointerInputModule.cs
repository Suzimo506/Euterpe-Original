using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

[Token(Token = "0x20001F3")]
public abstract class RewiredPointerInputModule : BaseInputModule
{
	[Token(Token = "0x2000A74")]
	protected class MouseState
	{
		[Token(Token = "0x400370F")]
		[FieldOffset(Offset = "0x10")]
		private List<ButtonState> m_TrackedButtons;

		[Address(RVA = "0x89B2F0", Offset = "0x899AF0", Length = "0xB3")]
		[Token(Token = "0x60059DA")]
		public bool AnyPressesThisFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60059DB")]
		[Address(RVA = "0x89B3B0", Offset = "0x899BB0", Length = "0xB4")]
		public bool AnyReleasesThisFrame()
		{
			return default(bool);
		}

		[Address(RVA = "0x89B470", Offset = "0x899C70", Length = "0x141")]
		[Token(Token = "0x60059DC")]
		public ButtonState GetButtonState(int button)
		{
			return null;
		}

		[Token(Token = "0x60059DD")]
		[Address(RVA = "0x89B5C0", Offset = "0x899DC0", Length = "0x50")]
		public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
		{
		}

		[Token(Token = "0x60059DE")]
		[Address(RVA = "0x89B620", Offset = "0x899E20", Length = "0x69")]
		public MouseState()
		{
		}
	}

	[Token(Token = "0x2000A75")]
	public class MouseButtonEventData
	{
		[Token(Token = "0x4003710")]
		[FieldOffset(Offset = "0x10")]
		public PointerEventData.FramePressState buttonState;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003711")]
		public PlayerPointerEventData buttonData;

		[Token(Token = "0x60059DF")]
		[Address(RVA = "0x89B2C0", Offset = "0x899AC0", Length = "0x11")]
		public bool PressedThisFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60059E0")]
		[Address(RVA = "0x89B2E0", Offset = "0x899AE0", Length = "0x10")]
		public bool ReleasedThisFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60059E1")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public MouseButtonEventData()
		{
		}
	}

	[Token(Token = "0x2000A76")]
	protected class ButtonState
	{
		[Token(Token = "0x4003712")]
		[FieldOffset(Offset = "0x10")]
		private int m_Button;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003713")]
		private MouseButtonEventData m_EventData;

		[Token(Token = "0x1700098E")]
		public MouseButtonEventData eventData
		{
			[Token(Token = "0x60059E2")]
			[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
			get
			{
				return null;
			}
			[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
			[Token(Token = "0x60059E3")]
			set
			{
			}
		}

		[Token(Token = "0x1700098F")]
		public int button
		{
			[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
			[Token(Token = "0x60059E4")]
			get
			{
				return default(int);
			}
			[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
			[Token(Token = "0x60059E5")]
			set
			{
			}
		}

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x60059E6")]
		public ButtonState()
		{
		}
	}

	[Token(Token = "0x2000A77")]
	private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
	{
		[Token(Token = "0x4003714")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 m_MousePosition;

		[Token(Token = "0x4003715")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 m_MousePositionPrev;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003716")]
		private int m_LastUpdatedFrame;

		[Token(Token = "0x17000990")]
		private int Rewired_002EUI_002EIMouseInputSource_002EplayerId
		{
			[Address(RVA = "0x8A2770", Offset = "0x8A0F70", Length = "0x12")]
			[Token(Token = "0x60059E7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000991")]
		private int Rewired_002EUI_002EITouchInputSource_002EplayerId
		{
			[Token(Token = "0x60059E8")]
			[Address(RVA = "0x8A2770", Offset = "0x8A0F70", Length = "0x12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000992")]
		private bool Rewired_002EUI_002EIMouseInputSource_002Eenabled
		{
			[Address(RVA = "0x8A2730", Offset = "0x8A0F30", Length = "0x12")]
			[Token(Token = "0x60059E9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000993")]
		private bool Rewired_002EUI_002EIMouseInputSource_002Elocked
		{
			[Address(RVA = "0x8A2750", Offset = "0x8A0F50", Length = "0x1D")]
			[Token(Token = "0x60059EA")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000994")]
		private int Rewired_002EUI_002EIMouseInputSource_002EbuttonCount
		{
			[Address(RVA = "0x8A2710", Offset = "0x8A0F10", Length = "0x15")]
			[Token(Token = "0x60059EB")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000995")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPosition
		{
			[Token(Token = "0x60059EF")]
			[Address(RVA = "0x8A2840", Offset = "0x8A1040", Length = "0x85")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000996")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPositionDelta
		{
			[Token(Token = "0x60059F0")]
			[Address(RVA = "0x8A2790", Offset = "0x8A0F90", Length = "0xAC")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000997")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EwheelDelta
		{
			[Token(Token = "0x60059F1")]
			[Address(RVA = "0x8A28D0", Offset = "0x8A10D0", Length = "0x16")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000998")]
		private bool Rewired_002EUI_002EITouchInputSource_002EtouchSupported
		{
			[Address(RVA = "0x8A2980", Offset = "0x8A1180", Length = "0x16")]
			[Token(Token = "0x60059F2")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000999")]
		private int Rewired_002EUI_002EITouchInputSource_002EtouchCount
		{
			[Token(Token = "0x60059F3")]
			[Address(RVA = "0x8A2960", Offset = "0x8A1160", Length = "0x16")]
			get
			{
				return default(int);
			}
		}

		[Address(RVA = "0x8A26B0", Offset = "0x8A0EB0", Length = "0x1D")]
		[Token(Token = "0x60059EC")]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonDown(int button)
		{
			return default(bool);
		}

		[Address(RVA = "0x8A26D0", Offset = "0x8A0ED0", Length = "0x1D")]
		[Token(Token = "0x60059ED")]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonUp(int button)
		{
			return default(bool);
		}

		[Address(RVA = "0x8A26F0", Offset = "0x8A0EF0", Length = "0x1D")]
		[Token(Token = "0x60059EE")]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButton(int button)
		{
			return default(bool);
		}

		[Token(Token = "0x60059F4")]
		[Address(RVA = "0x8A28F0", Offset = "0x8A10F0", Length = "0x61")]
		private Touch Rewired_002EUI_002EITouchInputSource_002EGetTouch(int index)
		{
			return default(Touch);
		}

		[Token(Token = "0x60059F5")]
		[Address(RVA = "0x8A29A0", Offset = "0x8A11A0", Length = "0xCE")]
		private void TryUpdate()
		{
		}

		[Address(RVA = "0x8A2A70", Offset = "0x8A1270", Length = "0xE")]
		[Token(Token = "0x60059F6")]
		public UnityInputSource()
		{
		}
	}

	[Token(Token = "0x4000D93")]
	public const int kMouseLeftId = -1;

	[Token(Token = "0x4000D94")]
	public const int kMouseRightId = -2;

	[Token(Token = "0x4000D95")]
	public const int kMouseMiddleId = -3;

	[Token(Token = "0x4000D96")]
	public const int kFakeTouchesId = -4;

	[Token(Token = "0x4000D97")]
	private const int customButtonsStartingId = -2147483520;

	[Token(Token = "0x4000D98")]
	private const int customButtonsMaxCount = 128;

	[Token(Token = "0x4000D99")]
	private const int customButtonsLastId = -2147483392;

	[Token(Token = "0x4000D9A")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<IMouseInputSource> m_MouseInputSourcesList;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000D9B")]
	private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData;

	[Token(Token = "0x4000D9C")]
	[FieldOffset(Offset = "0x58")]
	private ITouchInputSource m_UserDefaultTouchInputSource;

	[Token(Token = "0x4000D9D")]
	[FieldOffset(Offset = "0x60")]
	private UnityInputSource __m_DefaultInputSource;

	[Token(Token = "0x4000D9E")]
	[FieldOffset(Offset = "0x68")]
	private readonly MouseState m_MouseState;

	[Token(Token = "0x1700031E")]
	private UnityInputSource defaultInputSource
	{
		[Address(RVA = "0xFA1D70", Offset = "0xFA0570", Length = "0x69")]
		[Token(Token = "0x6001054")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700031F")]
	private IMouseInputSource defaultMouseInputSource
	{
		[Token(Token = "0x6001055")]
		[Address(RVA = "0xFA1D70", Offset = "0xFA0570", Length = "0x69")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000320")]
	protected ITouchInputSource defaultTouchInputSource
	{
		[Token(Token = "0x6001056")]
		[Address(RVA = "0xFA1D70", Offset = "0xFA0570", Length = "0x69")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000321")]
	protected virtual bool isMouseSupported
	{
		[Address(RVA = "0xFA1DE0", Offset = "0xFA05E0", Length = "0xF9")]
		[Token(Token = "0x6001061")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001057")]
	[Address(RVA = "0xFA0DD0", Offset = "0xF9F5D0", Length = "0x78")]
	protected bool IsDefaultMouse(IMouseInputSource mouse)
	{
		return default(bool);
	}

	[Address(RVA = "0xF9F990", Offset = "0xF9E190", Length = "0x1AB")]
	[Token(Token = "0x6001058")]
	public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
	{
		return null;
	}

	[Token(Token = "0x6001059")]
	[Address(RVA = "0xFA15B0", Offset = "0xF9FDB0", Length = "0x88")]
	public void RemoveMouseInputSource(IMouseInputSource source)
	{
	}

	[Address(RVA = "0xF9EE90", Offset = "0xF9D690", Length = "0xB4")]
	[Token(Token = "0x600105A")]
	public void AddMouseInputSource(IMouseInputSource source)
	{
	}

	[Address(RVA = "0xF9F840", Offset = "0xF9E040", Length = "0x14D")]
	[Token(Token = "0x600105B")]
	public int GetMouseInputSourceCount(int playerId)
	{
		return default(int);
	}

	[Address(RVA = "0xFA09D0", Offset = "0xF9F1D0", Length = "0xC9")]
	[Token(Token = "0x600105C")]
	public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
	{
		return null;
	}

	[Address(RVA = "0xFA16E0", Offset = "0xF9FEE0", Length = "0x83")]
	[Token(Token = "0x600105D")]
	public void RemoveTouchInputSource(ITouchInputSource source)
	{
	}

	[Token(Token = "0x600105E")]
	[Address(RVA = "0xF9EF50", Offset = "0xF9D750", Length = "0xA5")]
	public void AddTouchInputSource(ITouchInputSource source)
	{
	}

	[Address(RVA = "0xFA09A0", Offset = "0xF9F1A0", Length = "0x22")]
	[Token(Token = "0x600105F")]
	public int GetTouchInputSourceCount(int playerId)
	{
		return default(int);
	}

	[Address(RVA = "0xF9F000", Offset = "0xF9D800", Length = "0x43")]
	[Token(Token = "0x6001060")]
	protected void ClearMouseInputSources()
	{
	}

	[Token(Token = "0x6001062")]
	[Address(RVA = "0x0", Length = "0x0")]
	protected abstract bool IsDefaultPlayer(int playerId);

	[Token(Token = "0x6001063")]
	[Address(RVA = "0xFA0480", Offset = "0xF9EC80", Length = "0x51C")]
	protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
	{
		data = null;
		return default(bool);
	}

	[Token(Token = "0x6001064")]
	[Address(RVA = "0xF9F440", Offset = "0xF9DC40", Length = "0x133")]
	private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
	{
		return null;
	}

	[Token(Token = "0x6001065")]
	[Address(RVA = "0xFA1640", Offset = "0xF9FE40", Length = "0x9F")]
	protected void RemovePointerData(PlayerPointerEventData data)
	{
	}

	[Token(Token = "0x6001066")]
	[Address(RVA = "0xFA0AA0", Offset = "0xF9F2A0", Length = "0x324")]
	protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref pressed) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref released) = null;
		return null;
	}

	[Address(RVA = "0xF9FB40", Offset = "0xF9E340", Length = "0x93D")]
	[Token(Token = "0x6001067")]
	protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex)
	{
		return null;
	}

	[Token(Token = "0x6001068")]
	[Address(RVA = "0xF9F660", Offset = "0xF9DE60", Length = "0x1D6")]
	protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
	{
		return null;
	}

	[Token(Token = "0x6001069")]
	[Address(RVA = "0xFA1770", Offset = "0xF9FF70", Length = "0xAB")]
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		return default(bool);
	}

	[Token(Token = "0x600106A")]
	[Address(RVA = "0xFA14B0", Offset = "0xF9FCB0", Length = "0xFF")]
	protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
	{
	}

	[Token(Token = "0x600106B")]
	[Address(RVA = "0xFA1070", Offset = "0xF9F870", Length = "0x430")]
	protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
	{
	}

	[Token(Token = "0x600106C")]
	[Address(RVA = "0xFA0E50", Offset = "0xF9F650", Length = "0x217")]
	public override bool IsPointerOverGameObject(int pointerTypeId)
	{
		return default(bool);
	}

	[Token(Token = "0x600106D")]
	[Address(RVA = "0xF9F050", Offset = "0xF9D850", Length = "0x30B")]
	protected void ClearSelection()
	{
	}

	[Token(Token = "0x600106E")]
	[Address(RVA = "0xFA18F0", Offset = "0xFA00F0", Length = "0x3B5")]
	public override string ToString()
	{
		return null;
	}

	[Address(RVA = "0xF9F580", Offset = "0xF9DD80", Length = "0xD5")]
	[Token(Token = "0x600106F")]
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
	}

	[Address(RVA = "0xF9F360", Offset = "0xF9DB60", Length = "0xDE")]
	[Token(Token = "0x6001070")]
	protected void CopyFromTo(PointerEventData from, PointerEventData to)
	{
	}

	[Address(RVA = "0xFA1820", Offset = "0xFA0020", Length = "0xC6")]
	[Token(Token = "0x6001071")]
	protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
	{
		return default(PointerEventData.FramePressState);
	}

	[Address(RVA = "0xFA1CB0", Offset = "0xFA04B0", Length = "0xBE")]
	[Token(Token = "0x6001072")]
	protected RewiredPointerInputModule()
	{
	}
}
