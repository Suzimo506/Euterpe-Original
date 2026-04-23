using Cpp2ILInjected;
using Sirenix.OdinInspector;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200091A")]
public abstract class DLCInfoBaseControl : SerializedMonoBehaviour
{
	[Token(Token = "0x40030F1")]
	[FieldOffset(Offset = "0x58")]
	protected bool initialized;

	[Token(Token = "0x600528E")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void Init(PnlDlc pnlDlc);

	[Token(Token = "0x600528F")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void OnFinalItemChange(bool isSelected)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6005290")]
	public virtual void OnItemChange(int cellIndex)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6005291")]
	public virtual void SetPlayMask(int index, bool isBillboard = false)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6005292")]
	public virtual void RefreshCountDown()
	{
	}

	[Token(Token = "0x6005293")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	protected DLCInfoBaseControl()
	{
	}
}
