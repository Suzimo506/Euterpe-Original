//Type is in global namespace

public class XdLoginSelect : UISelectManage
{
	internal enum XdWindowType
	{
		Main = 0,
		Web = 1,
	}

	public XdWindowType type; //Field offset: 0x110
	private InputKeyBinding account; //Field offset: 0x118
	public Button WebCloseButton; //Field offset: 0x120
	private bool m_IsWebClose; //Field offset: 0x128

	public XdLoginSelect() { }

	[CompilerGenerated]
	private void <OnInit>b__6_0() { }

	private bool m_IsWeb() { }

	private void OnDestroy() { }

	public virtual void OnInit() { }

}

