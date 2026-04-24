using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x2000969")]
public class PnlRoleSelectedItem : SerializedMonoBehaviour
{
	[Token(Token = "0x2000DDD")]
	protected class AxisSetting
	{
		[Token(Token = "0x4004105")]
		[FieldOffset(Offset = "0x10")]
		public Action<float> axisEnableAction;

		[Token(Token = "0x4004106")]
		[FieldOffset(Offset = "0x18")]
		public Action axisDisableAction;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4004107")]
		public float axisCoolDownTime;

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x60065FB")]
		public AxisSetting()
		{
		}
	}

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400339A")]
	protected Dictionary<string, Action> m_ButtonActionMapping;

	[Token(Token = "0x400339B")]
	[FieldOffset(Offset = "0x60")]
	protected Dictionary<string, AxisSetting> m_AxisActionMapping;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400339C")]
	protected bool m_IsAxisInUse;

	[Token(Token = "0x400339D")]
	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	protected PnlRoleSelectedItem m_Parent;

	[Token(Token = "0x400339E")]
	[FieldOffset(Offset = "0x78")]
	protected float m_Timer;

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60055D8")]
	public virtual void OnSelected()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60055D9")]
	public virtual void OnDeselected()
	{
	}

	[Address(RVA = "0x526C70", Offset = "0x525470", Length = "0x3")]
	[Token(Token = "0x60055DA")]
	public virtual bool IsSelectedValid()
	{
		return default(bool);
	}

	[Address(RVA = "0x640750", Offset = "0x63EF50", Length = "0x1E")]
	[Token(Token = "0x60055DB")]
	public virtual void SetCurrentChildToParent(PnlRoleSelectedItem item)
	{
	}

	[Token(Token = "0x60055DC")]
	[Address(RVA = "0x6402F0", Offset = "0x63EAF0", Length = "0x45E")]
	public virtual void ButtonActionInvoke()
	{
	}

	[Address(RVA = "0x640770", Offset = "0x63EF70", Length = "0x96")]
	[Token(Token = "0x60055DD")]
	public PnlRoleSelectedItem()
	{
	}
}
