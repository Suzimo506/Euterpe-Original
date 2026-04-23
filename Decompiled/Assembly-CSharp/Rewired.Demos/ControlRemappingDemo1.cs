using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x2000212")]
public class ControlRemappingDemo1 : MonoBehaviour
{
	[Token(Token = "0x2000AAC")]
	private class ControllerSelection
	{
		[Token(Token = "0x4003812")]
		[FieldOffset(Offset = "0x10")]
		private int _id;

		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4003813")]
		private int _idPrev;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003814")]
		private ControllerType _type;

		[Token(Token = "0x4003815")]
		[FieldOffset(Offset = "0x1C")]
		private ControllerType _typePrev;

		[Token(Token = "0x17000A38")]
		public int id
		{
			[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
			[Token(Token = "0x6005B9A")]
			get
			{
				return default(int);
			}
			[Address(RVA = "0xF8E970", Offset = "0xF8D170", Length = "0xA")]
			[Token(Token = "0x6005B9B")]
			set
			{
			}
		}

		[Token(Token = "0x17000A39")]
		public ControllerType type
		{
			[Token(Token = "0x6005B9C")]
			[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
			get
			{
				return default(ControllerType);
			}
			[Token(Token = "0x6005B9D")]
			[Address(RVA = "0xF8E980", Offset = "0xF8D180", Length = "0xA")]
			set
			{
			}
		}

		[Token(Token = "0x17000A3A")]
		public int idPrev
		{
			[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
			[Token(Token = "0x6005B9E")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000A3B")]
		public ControllerType typePrev
		{
			[Address(RVA = "0x597040", Offset = "0x595840", Length = "0x4")]
			[Token(Token = "0x6005B9F")]
			get
			{
				return default(ControllerType);
			}
		}

		[Token(Token = "0x17000A3C")]
		public bool hasSelection
		{
			[Token(Token = "0x6005BA0")]
			[Address(RVA = "0xF8E960", Offset = "0xF8D160", Length = "0x9")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0xF8E930", Offset = "0xF8D130", Length = "0x2C")]
		[Token(Token = "0x6005B99")]
		public ControllerSelection()
		{
		}

		[Token(Token = "0x6005BA1")]
		[Address(RVA = "0xF8E910", Offset = "0xF8D110", Length = "0x14")]
		public void Set(int id, ControllerType type)
		{
		}

		[Token(Token = "0x6005BA2")]
		[Address(RVA = "0xF8E8F0", Offset = "0xF8D0F0", Length = "0x17")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x2000AAD")]
	private class DialogHelper
	{
		[Token(Token = "0x2000E06")]
		public enum DialogType
		{
			[Token(Token = "0x400415D")]
			None = 0,
			[Token(Token = "0x400415E")]
			JoystickConflict = 1,
			[Token(Token = "0x400415F")]
			ElementConflict = 2,
			[Token(Token = "0x4004160")]
			KeyConflict = 3,
			[Token(Token = "0x4004161")]
			DeleteAssignmentConfirmation = 10,
			[Token(Token = "0x4004162")]
			AssignElement = 11
		}

		[Token(Token = "0x4003816")]
		private const float openBusyDelay = 0.25f;

		[Token(Token = "0x4003817")]
		private const float closeBusyDelay = 0.1f;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003818")]
		private DialogType _type;

		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4003819")]
		private bool _enabled;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400381A")]
		private float _busyTime;

		[Token(Token = "0x400381B")]
		[FieldOffset(Offset = "0x1C")]
		private bool _busyTimerRunning;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400381C")]
		private Action<int> drawWindowDelegate;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400381D")]
		private GUI.WindowFunction drawWindowFunction;

		[Token(Token = "0x400381E")]
		[FieldOffset(Offset = "0x30")]
		private WindowProperties windowProperties;

		[Token(Token = "0x400381F")]
		[FieldOffset(Offset = "0x60")]
		private int currentActionId;

		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003820")]
		private Action<int, UserResponse> resultCallback;

		[Token(Token = "0x17000A3D")]
		private float busyTimer
		{
			[Address(RVA = "0xF91A60", Offset = "0xF90260", Length = "0x34")]
			[Token(Token = "0x6005BA3")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000A3E")]
		public bool enabled
		{
			[Address(RVA = "0x44C9C0", Offset = "0x44B1C0", Length = "0x5")]
			[Token(Token = "0x6005BA4")]
			get
			{
				return default(bool);
			}
			[Address(RVA = "0xF91AB0", Offset = "0xF902B0", Length = "0x59")]
			[Token(Token = "0x6005BA5")]
			set
			{
			}
		}

		[Token(Token = "0x17000A3F")]
		public DialogType type
		{
			[Address(RVA = "0xF91AA0", Offset = "0xF902A0", Length = "0xD")]
			[Token(Token = "0x6005BA6")]
			get
			{
				return default(DialogType);
			}
			[Address(RVA = "0xF91B10", Offset = "0xF90310", Length = "0x52")]
			[Token(Token = "0x6005BA7")]
			set
			{
			}
		}

		[Token(Token = "0x17000A40")]
		public bool busy
		{
			[Token(Token = "0x6005BA8")]
			[Address(RVA = "0x44A0A0", Offset = "0x4488A0", Length = "0x5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6005BA9")]
		[Address(RVA = "0xF919A0", Offset = "0xF901A0", Length = "0xB5")]
		public DialogHelper()
		{
		}

		[Token(Token = "0x6005BAA")]
		[Address(RVA = "0xF916B0", Offset = "0xF8FEB0", Length = "0x8A")]
		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback)
		{
		}

		[Token(Token = "0x6005BAB")]
		[Address(RVA = "0xF91740", Offset = "0xF8FF40", Length = "0xB6")]
		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback, float openBusyDelay)
		{
		}

		[Token(Token = "0x6005BAC")]
		[Address(RVA = "0xF91840", Offset = "0xF90040", Length = "0x159")]
		public void Update()
		{
		}

		[Address(RVA = "0xF914D0", Offset = "0xF8FCD0", Length = "0x137")]
		[Token(Token = "0x6005BAD")]
		public void Draw()
		{
		}

		[Address(RVA = "0xF910F0", Offset = "0xF8F8F0", Length = "0x130")]
		[Token(Token = "0x6005BAE")]
		public void DrawConfirmButton()
		{
		}

		[Address(RVA = "0xF91360", Offset = "0xF8FB60", Length = "0x111")]
		[Token(Token = "0x6005BAF")]
		public void DrawConfirmButton(string title)
		{
		}

		[Address(RVA = "0xF91220", Offset = "0xF8FA20", Length = "0x13C")]
		[Token(Token = "0x6005BB0")]
		public void DrawConfirmButton(UserResponse response)
		{
		}

		[Address(RVA = "0xF90FD0", Offset = "0xF8F7D0", Length = "0x11D")]
		[Token(Token = "0x6005BB1")]
		public void DrawConfirmButton(UserResponse response, string title)
		{
		}

		[Address(RVA = "0xF90E30", Offset = "0xF8F630", Length = "0x19E")]
		[Token(Token = "0x6005BB2")]
		public void DrawCancelButton()
		{
		}

		[Token(Token = "0x6005BB3")]
		[Address(RVA = "0xF90CB0", Offset = "0xF8F4B0", Length = "0x17F")]
		public void DrawCancelButton(string title)
		{
		}

		[Token(Token = "0x6005BB4")]
		[Address(RVA = "0xF90C00", Offset = "0xF8F400", Length = "0xA")]
		public void Confirm()
		{
		}

		[Token(Token = "0x6005BB5")]
		[Address(RVA = "0xF90C10", Offset = "0xF8F410", Length = "0x96")]
		public void Confirm(UserResponse response)
		{
		}

		[Token(Token = "0x6005BB6")]
		[Address(RVA = "0xF90B20", Offset = "0xF8F320", Length = "0x8D")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6005BB7")]
		[Address(RVA = "0xF91480", Offset = "0xF8FC80", Length = "0x4B")]
		private void DrawWindow(int windowId)
		{
		}

		[Address(RVA = "0xF91800", Offset = "0xF90000", Length = "0x3B")]
		[Token(Token = "0x6005BB8")]
		private void UpdateTimers()
		{
		}

		[Address(RVA = "0xF91680", Offset = "0xF8FE80", Length = "0x30")]
		[Token(Token = "0x6005BB9")]
		private void StartBusyTimer(float time)
		{
		}

		[Address(RVA = "0xF90BB0", Offset = "0xF8F3B0", Length = "0x45")]
		[Token(Token = "0x6005BBA")]
		private void Close()
		{
		}

		[Address(RVA = "0xF91680", Offset = "0xF8FE80", Length = "0x30")]
		[Token(Token = "0x6005BBB")]
		private void StateChanged(float delay)
		{
		}

		[Token(Token = "0x6005BBC")]
		[Address(RVA = "0xF91660", Offset = "0xF8FE60", Length = "0x1E")]
		private void Reset()
		{
		}

		[Address(RVA = "0xF91650", Offset = "0xF8FE50", Length = "0x5")]
		[Token(Token = "0x6005BBD")]
		private void ResetTimers()
		{
		}

		[Address(RVA = "0xF91610", Offset = "0xF8FE10", Length = "0x31")]
		[Token(Token = "0x6005BBE")]
		public void FullReset()
		{
		}
	}

	[Token(Token = "0x2000AAE")]
	private abstract class QueueEntry
	{
		[Token(Token = "0x2000E07")]
		public enum State
		{
			[Token(Token = "0x4004164")]
			Waiting,
			[Token(Token = "0x4004165")]
			Confirmed,
			[Token(Token = "0x4004166")]
			Canceled
		}

		[Token(Token = "0x4003825")]
		private static int uidCounter;

		[Token(Token = "0x17000A41")]
		public int id
		{
			[CompilerGenerated]
			[Token(Token = "0x6005BBF")]
			[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
			get
			{
				return default(int);
			}
			[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6005BC0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000A42")]
		public QueueActionType queueActionType
		{
			[CompilerGenerated]
			[Token(Token = "0x6005BC1")]
			[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
			get
			{
				return default(QueueActionType);
			}
			[CompilerGenerated]
			[Address(RVA = "0x494A20", Offset = "0x493220", Length = "0x4")]
			[Token(Token = "0x6005BC2")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000A43")]
		public State state
		{
			[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
			[Token(Token = "0x6005BC3")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6005BC4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000A44")]
		public UserResponse response
		{
			[Token(Token = "0x6005BC5")]
			[CompilerGenerated]
			[Address(RVA = "0x597040", Offset = "0x595840", Length = "0x4")]
			get
			{
				return default(UserResponse);
			}
			[CompilerGenerated]
			[Token(Token = "0x6005BC6")]
			[Address(RVA = "0x597080", Offset = "0x595880", Length = "0x4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000A45")]
		protected static int nextId
		{
			[Token(Token = "0x6005BC7")]
			[Address(RVA = "0xF9EC50", Offset = "0xF9D450", Length = "0x39")]
			get
			{
				return default(int);
			}
		}

		[Address(RVA = "0xF9EBF0", Offset = "0xF9D3F0", Length = "0x57")]
		[Token(Token = "0x6005BC8")]
		public QueueEntry(QueueActionType queueActionType)
		{
		}

		[Address(RVA = "0xF9EBE0", Offset = "0xF9D3E0", Length = "0xB")]
		[Token(Token = "0x6005BC9")]
		public void Confirm(UserResponse response)
		{
		}

		[Address(RVA = "0xF9EBD0", Offset = "0xF9D3D0", Length = "0x8")]
		[Token(Token = "0x6005BCA")]
		public void Cancel()
		{
		}
	}

	[Token(Token = "0x2000AAF")]
	private class JoystickAssignmentChange : QueueEntry
	{
		[Token(Token = "0x17000A46")]
		public int playerId
		{
			[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6005BCB")]
			get
			{
				return default(int);
			}
			[Address(RVA = "0x42D200", Offset = "0x42BA00", Length = "0x4")]
			[Token(Token = "0x6005BCC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000A47")]
		public int joystickId
		{
			[CompilerGenerated]
			[Token(Token = "0x6005BCD")]
			[Address(RVA = "0x42D1F0", Offset = "0x42B9F0", Length = "0x4")]
			get
			{
				return default(int);
			}
			[Address(RVA = "0x42D210", Offset = "0x42BA10", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6005BCE")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A48")]
		public bool assign
		{
			[CompilerGenerated]
			[Token(Token = "0x6005BCF")]
			[Address(RVA = "0x45A8E0", Offset = "0x4590E0", Length = "0x5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005BD0")]
			[CompilerGenerated]
			[Address(RVA = "0x45AB40", Offset = "0x459340", Length = "0x4")]
			private set
			{
			}
		}

		[Address(RVA = "0xF99770", Offset = "0xF97F70", Length = "0x80")]
		[Token(Token = "0x6005BD1")]
		public JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign)
			: base(default(QueueActionType))
		{
		}
	}

	[Token(Token = "0x2000AB0")]
	private class ElementAssignmentChange : QueueEntry
	{
		[Token(Token = "0x17000A49")]
		public ElementAssignmentChangeType changeType
		{
			[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
			[Token(Token = "0x6005BD2")]
			[CompilerGenerated]
			get
			{
				return default(ElementAssignmentChangeType);
			}
			[Token(Token = "0x6005BD3")]
			[CompilerGenerated]
			[Address(RVA = "0x42D200", Offset = "0x42BA00", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x17000A4A")]
		public InputMapper.Context context
		{
			[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6005BD4")]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[Token(Token = "0x6005BD5")]
			[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
			private set
			{
			}
		}

		[Token(Token = "0x6005BD6")]
		[Address(RVA = "0xF93E00", Offset = "0xF92600", Length = "0x79")]
		public ElementAssignmentChange(ElementAssignmentChangeType changeType, InputMapper.Context context)
			: base(default(QueueActionType))
		{
		}

		[Token(Token = "0x6005BD7")]
		[Address(RVA = "0xF93E80", Offset = "0xF92680", Length = "0x9B")]
		public ElementAssignmentChange(ElementAssignmentChange other)
			: base(default(QueueActionType))
		{
		}
	}

	[Token(Token = "0x2000AB1")]
	private class FallbackJoystickIdentification : QueueEntry
	{
		[Token(Token = "0x17000A4B")]
		public int joystickId
		{
			[CompilerGenerated]
			[Token(Token = "0x6005BD8")]
			[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
			get
			{
				return default(int);
			}
			[Address(RVA = "0x42D200", Offset = "0x42BA00", Length = "0x4")]
			[Token(Token = "0x6005BD9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000A4C")]
		public string joystickName
		{
			[Token(Token = "0x6005BDA")]
			[CompilerGenerated]
			[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
			[Token(Token = "0x6005BDB")]
			private set
			{
			}
		}

		[Token(Token = "0x6005BDC")]
		[Address(RVA = "0xF945E0", Offset = "0xF92DE0", Length = "0x79")]
		public FallbackJoystickIdentification(int joystickId, string joystickName)
			: base(default(QueueActionType))
		{
		}
	}

	[Token(Token = "0x2000AB2")]
	private class Calibration : QueueEntry
	{
		[Token(Token = "0x4003831")]
		[FieldOffset(Offset = "0x40")]
		public int selectedElementIdentifierId;

		[Token(Token = "0x4003832")]
		[FieldOffset(Offset = "0x44")]
		public bool recording;

		[Token(Token = "0x17000A4D")]
		public Player player
		{
			[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
			[Token(Token = "0x6005BDD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BDE")]
			[CompilerGenerated]
			[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A4E")]
		public ControllerType controllerType
		{
			[CompilerGenerated]
			[Address(RVA = "0x49EAA0", Offset = "0x49D2A0", Length = "0x4")]
			[Token(Token = "0x6005BDF")]
			get
			{
				return default(ControllerType);
			}
			[CompilerGenerated]
			[Token(Token = "0x6005BE0")]
			[Address(RVA = "0x4879F0", Offset = "0x4861F0", Length = "0x4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A4F")]
		public Joystick joystick
		{
			[CompilerGenerated]
			[Token(Token = "0x6005BE1")]
			[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
			get
			{
				return null;
			}
			[Address(RVA = "0x45EF10", Offset = "0x45D710", Length = "0xC")]
			[CompilerGenerated]
			[Token(Token = "0x6005BE2")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A50")]
		public CalibrationMap calibrationMap
		{
			[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6005BE3")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BE4")]
			[CompilerGenerated]
			[Address(RVA = "0x45EEF0", Offset = "0x45D6F0", Length = "0xC")]
			private set
			{
			}
		}

		[Address(RVA = "0xF8E840", Offset = "0xF8D040", Length = "0xAA")]
		[Token(Token = "0x6005BE5")]
		public Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap)
			: base(default(QueueActionType))
		{
		}
	}

	[Token(Token = "0x2000AB3")]
	private struct WindowProperties
	{
		[Token(Token = "0x4003833")]
		[FieldOffset(Offset = "0x0")]
		public int windowId;

		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4003834")]
		public Rect rect;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003835")]
		public Action<string, string> windowDrawDelegate;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003836")]
		public string title;

		[Token(Token = "0x4003837")]
		[FieldOffset(Offset = "0x28")]
		public string message;
	}

	[Token(Token = "0x2000AB4")]
	private enum QueueActionType
	{
		[Token(Token = "0x4003839")]
		None,
		[Token(Token = "0x400383A")]
		JoystickAssignment,
		[Token(Token = "0x400383B")]
		ElementAssignment,
		[Token(Token = "0x400383C")]
		FallbackJoystickIdentification,
		[Token(Token = "0x400383D")]
		Calibrate
	}

	[Token(Token = "0x2000AB5")]
	private enum ElementAssignmentChangeType
	{
		[Token(Token = "0x400383F")]
		Add,
		[Token(Token = "0x4003840")]
		Replace,
		[Token(Token = "0x4003841")]
		Remove,
		[Token(Token = "0x4003842")]
		ReassignOrRemove,
		[Token(Token = "0x4003843")]
		ConflictCheck
	}

	[Token(Token = "0x2000AB6")]
	public enum UserResponse
	{
		[Token(Token = "0x4003845")]
		Confirm,
		[Token(Token = "0x4003846")]
		Cancel,
		[Token(Token = "0x4003847")]
		Custom1,
		[Token(Token = "0x4003848")]
		Custom2
	}

	[Token(Token = "0x4000EFE")]
	private const float defaultModalWidth = 250f;

	[Token(Token = "0x4000EFF")]
	private const float defaultModalHeight = 200f;

	[Token(Token = "0x4000F00")]
	private const float assignmentTimeout = 5f;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F01")]
	private DialogHelper dialog;

	[Token(Token = "0x4000F02")]
	[FieldOffset(Offset = "0x20")]
	private InputMapper inputMapper;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F03")]
	private InputMapper.ConflictFoundEventData conflictFoundEventData;

	[Token(Token = "0x4000F04")]
	[FieldOffset(Offset = "0x30")]
	private bool guiState;

	[Token(Token = "0x4000F05")]
	[FieldOffset(Offset = "0x31")]
	private bool busy;

	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4000F06")]
	private bool pageGUIState;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F07")]
	private Player selectedPlayer;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F08")]
	private int selectedMapCategoryId;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F09")]
	private ControllerSelection selectedController;

	[Token(Token = "0x4000F0A")]
	[FieldOffset(Offset = "0x50")]
	private ControllerMap selectedMap;

	[Token(Token = "0x4000F0B")]
	[FieldOffset(Offset = "0x58")]
	private bool showMenu;

	[Token(Token = "0x4000F0C")]
	[FieldOffset(Offset = "0x59")]
	private bool startListening;

	[Token(Token = "0x4000F0D")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 actionScrollPos;

	[Token(Token = "0x4000F0E")]
	[FieldOffset(Offset = "0x64")]
	private Vector2 calibrateScrollPos;

	[Token(Token = "0x4000F0F")]
	[FieldOffset(Offset = "0x70")]
	private Queue<QueueEntry> actionQueue;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000F10")]
	private bool setupFinished;

	[NonSerialized]
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4000F11")]
	private bool initialized;

	[FieldOffset(Offset = "0x7A")]
	[Token(Token = "0x4000F12")]
	private bool isCompiling;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000F13")]
	private GUIStyle style_wordWrap;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000F14")]
	private GUIStyle style_centeredBox;

	[Address(RVA = "0x557AA0", Offset = "0x5562A0", Length = "0x77")]
	[Token(Token = "0x60013A0")]
	private void Awake()
	{
	}

	[Address(RVA = "0x55D940", Offset = "0x55C140", Length = "0xD4")]
	[Token(Token = "0x60013A1")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60013A2")]
	[Address(RVA = "0x55D920", Offset = "0x55C120", Length = "0x1D")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x55D0B0", Offset = "0x55B8B0", Length = "0x1B0")]
	[Token(Token = "0x60013A3")]
	private void Initialize()
	{
	}

	[Address(RVA = "0x55F840", Offset = "0x55E040", Length = "0x13D")]
	[Token(Token = "0x60013A4")]
	private void Setup()
	{
	}

	[Address(RVA = "0x55D940", Offset = "0x55C140", Length = "0xD4")]
	[Token(Token = "0x60013A5")]
	private void Subscribe()
	{
	}

	[Address(RVA = "0x55D920", Offset = "0x55C120", Length = "0x1D")]
	[Token(Token = "0x60013A6")]
	private void Unsubscribe()
	{
	}

	[Address(RVA = "0x55DA20", Offset = "0x55C220", Length = "0x3C5")]
	[Token(Token = "0x60013A7")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x60013A8")]
	[Address(RVA = "0x55CD60", Offset = "0x55B560", Length = "0x10D")]
	private void HandleMenuControl()
	{
	}

	[Address(RVA = "0x557C40", Offset = "0x556440", Length = "0x1A")]
	[Token(Token = "0x60013A9")]
	private void Close()
	{
	}

	[Address(RVA = "0x55DE10", Offset = "0x55C610", Length = "0x5")]
	[Token(Token = "0x60013AA")]
	private void Open()
	{
	}

	[Address(RVA = "0x55B170", Offset = "0x559970", Length = "0x299")]
	[Token(Token = "0x60013AB")]
	private void DrawInitialScreen()
	{
	}

	[Token(Token = "0x60013AC")]
	[Address(RVA = "0x55C580", Offset = "0x55AD80", Length = "0x227")]
	private void DrawPage()
	{
	}

	[Address(RVA = "0x55C7B0", Offset = "0x55AFB0", Length = "0x373")]
	[Token(Token = "0x60013AD")]
	private void DrawPlayerSelector()
	{
	}

	[Token(Token = "0x60013AE")]
	[Address(RVA = "0x55C150", Offset = "0x55A950", Length = "0x420")]
	private void DrawMouseAssignment()
	{
	}

	[Address(RVA = "0x55B510", Offset = "0x559D10", Length = "0x4FA")]
	[Token(Token = "0x60013AF")]
	private void DrawJoystickSelector()
	{
	}

	[Token(Token = "0x60013B0")]
	[Address(RVA = "0x55A3C0", Offset = "0x558BC0", Length = "0x662")]
	private void DrawControllerSelector()
	{
	}

	[Token(Token = "0x60013B1")]
	[Address(RVA = "0x558200", Offset = "0x556A00", Length = "0x3A1")]
	private void DrawCalibrateButton()
	{
	}

	[Token(Token = "0x60013B2")]
	[Address(RVA = "0x55BA10", Offset = "0x55A210", Length = "0x57C")]
	private void DrawMapCategories()
	{
	}

	[Token(Token = "0x60013B3")]
	[Address(RVA = "0x5594C0", Offset = "0x557CC0", Length = "0xEF2")]
	private void DrawCategoryActions()
	{
	}

	[Token(Token = "0x60013B4")]
	[Address(RVA = "0x557D90", Offset = "0x556590", Length = "0x271")]
	private void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
	}

	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x55B410", Offset = "0x559C10", Length = "0xFB")]
	private void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
	}

	[Token(Token = "0x60013B6")]
	[Address(RVA = "0x558010", Offset = "0x556810", Length = "0x1E2")]
	private void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap)
	{
	}

	[Address(RVA = "0x55F980", Offset = "0x55E180", Length = "0x1D")]
	[Token(Token = "0x60013B7")]
	private void ShowDialog()
	{
	}

	[Address(RVA = "0x55C060", Offset = "0x55A860", Length = "0xE2")]
	[Token(Token = "0x60013B8")]
	private void DrawModalWindow(string title, string message)
	{
	}

	[Address(RVA = "0x55BF90", Offset = "0x55A790", Length = "0xC7")]
	[Token(Token = "0x60013B9")]
	private void DrawModalWindow_OkayOnly(string title, string message)
	{
	}

	[Token(Token = "0x60013BA")]
	[Address(RVA = "0x55AD20", Offset = "0x559520", Length = "0x241")]
	private void DrawElementAssignmentWindow(string title, string message)
	{
	}

	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x55ABC0", Offset = "0x5593C0", Length = "0x15F")]
	private void DrawElementAssignmentProtectedConflictWindow(string title, string message)
	{
	}

	[Address(RVA = "0x55AA30", Offset = "0x559230", Length = "0x180")]
	[Token(Token = "0x60013BC")]
	private void DrawElementAssignmentNormalConflictWindow(string title, string message)
	{
	}

	[Address(RVA = "0x55CB30", Offset = "0x55B330", Length = "0xEA")]
	[Token(Token = "0x60013BD")]
	private void DrawReassignOrRemoveElementAssignmentWindow(string title, string message)
	{
	}

	[Address(RVA = "0x55AF70", Offset = "0x559770", Length = "0x1F2")]
	[Token(Token = "0x60013BE")]
	private void DrawFallbackJoystickIdentificationWindow(string title, string message)
	{
	}

	[Token(Token = "0x60013BF")]
	[Address(RVA = "0x5585B0", Offset = "0x556DB0", Length = "0xF02")]
	private void DrawCalibrationWindow(string title, string message)
	{
	}

	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x557C60", Offset = "0x556460", Length = "0x126")]
	private void DialogResultCallback(int queueActionId, UserResponse response)
	{
	}

	[Address(RVA = "0x55CCB0", Offset = "0x55B4B0", Length = "0xA6")]
	[Token(Token = "0x60013C1")]
	private Rect GetScreenCenteredRect(float width, float height)
	{
		return default(Rect);
	}

	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x55CC20", Offset = "0x55B420", Length = "0x83")]
	private void EnqueueAction(QueueEntry entry)
	{
	}

	[Token(Token = "0x60013C3")]
	[Address(RVA = "0x55EFC0", Offset = "0x55D7C0", Length = "0x244")]
	private void ProcessQueue()
	{
	}

	[Token(Token = "0x60013C4")]
	[Address(RVA = "0x55EC90", Offset = "0x55D490", Length = "0x32C")]
	private bool ProcessJoystickAssignmentChange(JoystickAssignmentChange entry)
	{
		return default(bool);
	}

	[Token(Token = "0x60013C5")]
	[Address(RVA = "0x55E3F0", Offset = "0x55CBF0", Length = "0x2F1")]
	private bool ProcessElementAssignmentChange(ElementAssignmentChange entry)
	{
		return default(bool);
	}

	[Token(Token = "0x60013C6")]
	[Address(RVA = "0x55F440", Offset = "0x55DC40", Length = "0x27F")]
	private bool ProcessRemoveOrReassignElementAssignment(ElementAssignmentChange entry)
	{
		return default(bool);
	}

	[Token(Token = "0x60013C7")]
	[Address(RVA = "0x55F210", Offset = "0x55DA10", Length = "0x226")]
	private bool ProcessRemoveElementAssignment(ElementAssignmentChange entry)
	{
		return default(bool);
	}

	[Token(Token = "0x60013C8")]
	[Address(RVA = "0x55DE20", Offset = "0x55C620", Length = "0x362")]
	private bool ProcessAddOrReplaceElementAssignment(ElementAssignmentChange entry)
	{
		return default(bool);
	}

	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x55E6F0", Offset = "0x55CEF0", Length = "0x34E")]
	private bool ProcessElementAssignmentConflictCheck(ElementAssignmentChange entry)
	{
		return default(bool);
	}

	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x55EA40", Offset = "0x55D240", Length = "0x24D")]
	private bool ProcessFallbackJoystickIdentification(FallbackJoystickIdentification entry)
	{
		return default(bool);
	}

	[Address(RVA = "0x55E190", Offset = "0x55C990", Length = "0x25E")]
	[Token(Token = "0x60013CB")]
	private bool ProcessCalibration(Calibration entry)
	{
		return default(bool);
	}

	[Address(RVA = "0x557B20", Offset = "0x556320", Length = "0x3C")]
	[Token(Token = "0x60013CC")]
	private void PlayerSelectionChanged()
	{
	}

	[Address(RVA = "0x557B60", Offset = "0x556360", Length = "0x19")]
	[Token(Token = "0x60013CD")]
	private void ControllerSelectionChanged()
	{
	}

	[Address(RVA = "0x557B20", Offset = "0x556320", Length = "0x3C")]
	[Token(Token = "0x60013CE")]
	private void ClearControllerSelection()
	{
	}

	[Token(Token = "0x60013CF")]
	[Address(RVA = "0x557B60", Offset = "0x556360", Length = "0x19")]
	private void ClearMapSelection()
	{
	}

	[Address(RVA = "0x55F6C0", Offset = "0x55DEC0", Length = "0x1E")]
	[Token(Token = "0x60013D0")]
	private void ResetAll()
	{
	}

	[Address(RVA = "0x557B80", Offset = "0x556380", Length = "0xBE")]
	[Token(Token = "0x60013D1")]
	private void ClearWorkingVars()
	{
	}

	[Address(RVA = "0x55F770", Offset = "0x55DF70", Length = "0xC3")]
	[Token(Token = "0x60013D2")]
	private void SetGUIStateStart()
	{
	}

	[Address(RVA = "0x55F6E0", Offset = "0x55DEE0", Length = "0x88")]
	[Token(Token = "0x60013D3")]
	private void SetGUIStateEnd()
	{
	}

	[Address(RVA = "0x55D270", Offset = "0x55BA70", Length = "0x2FA")]
	[Token(Token = "0x60013D4")]
	private void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x55D5F0", Offset = "0x55BDF0", Length = "0x321")]
	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Address(RVA = "0x55D570", Offset = "0x55BD70", Length = "0x72")]
	[Token(Token = "0x60013D6")]
	private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
	[Token(Token = "0x60013D7")]
	private void OnConflictFound(InputMapper.ConflictFoundEventData data)
	{
	}

	[Address(RVA = "0x55DDF0", Offset = "0x55C5F0", Length = "0x12")]
	[Token(Token = "0x60013D8")]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[Address(RVA = "0x55CE70", Offset = "0x55B670", Length = "0x23C")]
	[Token(Token = "0x60013D9")]
	public void IdentifyAllJoysticks()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60013DA")]
	protected void CheckRecompile()
	{
	}

	[Token(Token = "0x60013DB")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void RecompileWindow(int windowId)
	{
	}

	[Address(RVA = "0x55F9A0", Offset = "0x55E1A0", Length = "0x64")]
	[Token(Token = "0x60013DC")]
	public ControlRemappingDemo1()
	{
	}
}
