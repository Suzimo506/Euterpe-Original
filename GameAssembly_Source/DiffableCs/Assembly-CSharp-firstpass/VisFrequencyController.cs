//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisFrequencyController : VisBaseController, IVisDataGroupTarget
{
	internal static class Defaults
	{
		public const VisDataValueType subValueType = 2; //Field offset: 0x0
		public const VisDataValueType finalValueType = 0; //Field offset: 0x0

	}

	[SerializeField]
	private VisDataGroup dataGroup; //Field offset: 0x58
	[HideInInspector]
	[SerializeField]
	private string m_szLastDataGroupName; //Field offset: 0x60
	public VisDataValueType subValueType; //Field offset: 0x68
	public VisDataValueType finalValueType; //Field offset: 0x6C

	public override VisDataGroup DataGroup
	{
		 get { } //Length: 5
		 set { } //Length: 175
	}

	public override string LastDataGroupName
	{
		 get { } //Length: 5
	}

	public VisFrequencyController() { }

	public virtual Rect DisplayDebugGUI(int x, int y, int barWidth, int barHeight, int separation, Texture debugTexture) { }

	public override VisDataGroup get_DataGroup() { }

	public override string get_LastDataGroupName() { }

	public virtual float GetCustomControllerValue() { }

	public virtual void Reset() { }

	public override void set_DataGroup(VisDataGroup value) { }

	public virtual void Start() { }

}

