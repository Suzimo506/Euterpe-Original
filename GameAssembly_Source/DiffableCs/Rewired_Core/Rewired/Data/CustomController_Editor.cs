namespace Rewired.Data;

[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[CustomClassObfuscation]
[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class CustomController_Editor
{
	[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Axis : Element
	{
		public AxisRange range; //Field offset: 0x20
		public bool invert; //Field offset: 0x24
		public float deadZone; //Field offset: 0x28
		public float zero; //Field offset: 0x2C
		public float min; //Field offset: 0x30
		public float max; //Field offset: 0x34
		public bool doNotCalibrateRange; //Field offset: 0x38
		public AxisSensitivityType sensitivityType; //Field offset: 0x3C
		public float sensitivity; //Field offset: 0x40
		public AnimationCurve sensitivityCurve; //Field offset: 0x48
		public HardwareAxisInfo axisInfo; //Field offset: 0x50

		public Axis() { }

		public Axis(string unnamed_param_0) { }

		[Obsolete]
		public Axis(string unnamed_param_0, string unnamed_param_1, string unnamed_param_2, int unnamed_param_3, AxisRange unnamed_param_4, bool unnamed_param_5, float unnamed_param_6, float unnamed_param_7, float unnamed_param_8, float unnamed_param_9, bool unnamed_param_10, HardwareAxisInfo unnamed_param_11) { }

		public Axis(Axis unnamed_param_0) { }

		public virtual Element Clone() { }

	}

	[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Button : Element
	{

		public Button() { }

		public Button(string unnamed_param_0) { }

		public Button(string unnamed_param_0, int unnamed_param_1) { }

		public Button(Button unnamed_param_0) { }

		public virtual Element Clone() { }

	}

	[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal abstract class Element
	{
		public int elementIdentifierId; //Field offset: 0x10
		public string name; //Field offset: 0x18

		public Element() { }

		public Element(string unnamed_param_0, int unnamed_param_1) { }

		public abstract Element Clone() { }

	}

	[CompilerGenerated]
	private sealed class jfBkFQcOfPboYWrmdWDzXIkpEoOc : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerElementIdentifier>, IEnumerator<ControllerElementIdentifier>
	{
		private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
		private ControllerElementIdentifier QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
		private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
		public CustomController_Editor SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
		private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

		private override ControllerElementIdentifier System.Collections.Generic.IEnumerator<Rewired.ControllerElementIdentifier>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public jfBkFQcOfPboYWrmdWDzXIkpEoOc(int unnamed_param_0) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<ControllerElementIdentifier> System.Collections.Generic.IEnumerable<Rewired.ControllerElementIdentifier>.GetEnumerator() { }

		[DebuggerHidden]
		private override ControllerElementIdentifier System.Collections.Generic.IEnumerator<Rewired.ControllerElementIdentifier>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CustomObfuscation]
	[SerializeField]
	private string _name; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	private string _descriptiveName; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	private int _id; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	private string _typeGuidString; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	private List<ControllerElementIdentifier> _elementIdentifiers; //Field offset: 0x30
	[CustomObfuscation]
	[SerializeField]
	private List<Axis> _axes; //Field offset: 0x38
	[CustomObfuscation]
	[SerializeField]
	private List<Button> _buttons; //Field offset: 0x40
	[CustomObfuscation]
	[SerializeField]
	private int _elementIdentifierIdCounter; //Field offset: 0x48

	public List<Axis> axes
	{
		 get { } //Length: 5
	}

	public int axisCount
	{
		 get { } //Length: 60
	}

	public int buttonCount
	{
		 get { } //Length: 60
	}

	public List<Button> buttons
	{
		 get { } //Length: 5
	}

	public internal string descriptiveName
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public internal List<ControllerElementIdentifier> elementIdentifiers
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public IEnumerable<ControllerElementIdentifier> ElementIdentifiers
	{
		 get { } //Length: 131
	}

	public internal int id
	{
		 get { } //Length: 4
		internal set { } //Length: 4
	}

	public internal string name
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public internal Guid typeGuid
	{
		 get { } //Length: 113
		internal set { } //Length: 43
	}

	internal string typeGuidString
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	public CustomController_Editor(CustomController_Editor unnamed_param_0) { }

	public CustomController_Editor() { }

	public void AddAxis() { }

	public void AddButton() { }

	public void AddElement(ControllerElementType type) { }

	public CustomController_Editor Clone() { }

	public bool ContainsElementIdentifier(int id) { }

	internal HardwareControllerMap_Game CreateGameHardwareMap() { }

	public void DeleteElement(int index) { }

	public void DeleteElement(ControllerElementType type, int index) { }

	public void DuplicateElement(ControllerElementType type, int index) { }

	private void ecBCKUIBFTNSxkPLGyCuCOKPCfxmA(int unnamed_param_0, List<> unnamed_param_1) { }

	private Element fUOeEgwsvBgcnFuvhPmRQiGgGXrpA(ControllerElementType unnamed_param_0) { }

	public List<Axis> get_axes() { }

	public int get_axisCount() { }

	public int get_buttonCount() { }

	public List<Button> get_buttons() { }

	public string get_descriptiveName() { }

	public List<ControllerElementIdentifier> get_elementIdentifiers() { }

	public IEnumerable<ControllerElementIdentifier> get_ElementIdentifiers() { }

	public int get_id() { }

	public string get_name() { }

	public Guid get_typeGuid() { }

	internal string get_typeGuidString() { }

	public Int32[] GetAxisElementIdentifierIds() { }

	public String[] GetAxisNames() { }

	public Int32[] GetButtonElementIdentifierIds() { }

	public String[] GetButtonNames() { }

	internal bool GetEffectiveAxisRange(int elementIdentifierId, out AxisRange axisRange) { }

	internal ControllerElementType GetEffectiveElementIdentifierType(int elementIdentifierId) { }

	public T GetElement(int index) { }

	public Int32[] GetElementElementIdentifierIds(ControllerElementType type) { }

	public ControllerElementIdentifier GetElementIdentifier(int id) { }

	public Int32[] GetElementIdentifierIds() { }

	public Int32[] GetElementIdentifierIdsTypeSorted() { }

	public String[] GetElementIdentifierNames() { }

	public String[] GetElementIdentifierNamesTypeSorted() { }

	public ControllerElementIdentifier[] GetElementIdentifiersTypeSorted() { }

	public String[] GetElementNames() { }

	public String[] GetElementNames(ControllerElementType type) { }

	private ControllerElementIdentifier gwKmFWIqOxHiNJnpItWxAPCfMfOb(ControllerElementType unnamed_param_0, string unnamed_param_1, string unnamed_param_2, string unnamed_param_3) { }

	public int IndexOfElementIdentifier(int id) { }

	public void InsertAxis(int index) { }

	public void InsertButton(int index) { }

	public void InsertElement(ControllerElementType type, int index) { }

	private ControllerElementIdentifier jGvZhJyOhqchRJRgzJaZnhmYiVUeA(int unnamed_param_0, string unnamed_param_1) { }

	public bool ReorderElement(ControllerElementType type, int index, bool offsetDown, bool offsetNow) { }

	internal void set_descriptiveName(string value) { }

	internal void set_elementIdentifiers(List<ControllerElementIdentifier> value) { }

	internal void set_id(int value) { }

	internal void set_name(string value) { }

	internal void set_typeGuid(Guid value) { }

	internal void set_typeGuidString(string value) { }

}

