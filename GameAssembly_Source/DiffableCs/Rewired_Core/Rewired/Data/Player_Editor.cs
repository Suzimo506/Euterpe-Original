namespace Rewired.Data;

[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Player_Editor
{
	[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class ControllerMapEnablerSettings : IDeepCloneable
	{
		[CustomObfuscation]
		[SerializeField]
		private bool _enabled; //Field offset: 0x10
		[CustomObfuscation]
		[SerializeField]
		private List<RuleSetMapping> _ruleSets; //Field offset: 0x18

		public bool enabled
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		public List<RuleSetMapping> ruleSets
		{
			 get { } //Length: 5
			 set { } //Length: 128
		}

		public ControllerMapEnablerSettings() { }

		public ControllerMapEnablerSettings(ControllerMapEnablerSettings unnamed_param_0) { }

		public bool get_enabled() { }

		public List<RuleSetMapping> get_ruleSets() { }

		internal plnXTkenmQqgCDhFKjkYCZrPDSLfA huQSpqjeTaocabdKABgHAxTOcEPZA() { }

		private ytJCOVIdYroWTnzXkEaZAxeiQGab[] oIZyYhfPMXbDDLCcBMjIbKDGcInw() { }

		private override object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

		public void set_enabled(bool value) { }

		public void set_ruleSets(List<RuleSetMapping> value) { }

	}

	[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class ControllerMapLayoutManagerSettings : IDeepCloneable
	{
		[CustomObfuscation]
		[SerializeField]
		private bool _enabled; //Field offset: 0x10
		[CustomObfuscation]
		[SerializeField]
		private bool _loadFromUserDataStore; //Field offset: 0x11
		[CustomObfuscation]
		[SerializeField]
		private List<RuleSetMapping> _ruleSets; //Field offset: 0x18

		public bool enabled
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		public bool loadFromUserDataStore
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		public List<RuleSetMapping> ruleSets
		{
			 get { } //Length: 5
			 set { } //Length: 128
		}

		public ControllerMapLayoutManagerSettings() { }

		public ControllerMapLayoutManagerSettings(ControllerMapLayoutManagerSettings unnamed_param_0) { }

		public bool get_enabled() { }

		public bool get_loadFromUserDataStore() { }

		public List<RuleSetMapping> get_ruleSets() { }

		internal fVXGpyCTCiyuJlPQfkuntdxiioPLA huQSpqjeTaocabdKABgHAxTOcEPZA() { }

		private ytJCOVIdYroWTnzXkEaZAxeiQGab[] oIZyYhfPMXbDDLCcBMjIbKDGcInw() { }

		private override object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

		public void set_enabled(bool value) { }

		public void set_loadFromUserDataStore(bool value) { }

		public void set_ruleSets(List<RuleSetMapping> value) { }

	}

	[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class CreateControllerInfo
	{
		[CustomObfuscation]
		[SerializeField]
		private int _sourceId; //Field offset: 0x10
		[CustomObfuscation]
		[SerializeField]
		private string _tag; //Field offset: 0x18

		public internal int sourceId
		{
			 get { } //Length: 4
			internal set { } //Length: 4
		}

		public internal string tag
		{
			 get { } //Length: 5
			internal set { } //Length: 12
		}

		public CreateControllerInfo() { }

		public CreateControllerInfo(int unnamed_param_0, string unnamed_param_1) { }

		public CreateControllerInfo(CreateControllerInfo unnamed_param_0) { }

		public int get_sourceId() { }

		public string get_tag() { }

		internal void YpPKuFkKhBCfyPoVscIAQHaCGCcDA(int unnamed_param_0) { }

		internal void zZIroqyphDaYLIrOeDuNZVevEsiB(string unnamed_param_0) { }

	}

	[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Mapping
	{
		[CustomObfuscation]
		[SerializeField]
		private bool _enabled; //Field offset: 0x10
		[CustomObfuscation]
		[SerializeField]
		private int _categoryId; //Field offset: 0x14
		[CustomObfuscation]
		[SerializeField]
		private int _layoutId; //Field offset: 0x18

		public internal int categoryId
		{
			 get { } //Length: 4
			internal set { } //Length: 4
		}

		public internal bool enabled
		{
			 get { } //Length: 5
			internal set { } //Length: 4
		}

		public internal int layoutId
		{
			 get { } //Length: 4
			internal set { } //Length: 4
		}

		public Mapping() { }

		public Mapping(bool unnamed_param_0, int unnamed_param_1, int unnamed_param_2) { }

		public void Clear() { }

		public Mapping Clone() { }

		public int get_categoryId() { }

		public bool get_enabled() { }

		public int get_layoutId() { }

		internal void IxiOvcRHWvBObAkXQKBMWYsmOhrC(bool unnamed_param_0) { }

		internal vEIBhKIyWFggERutrrQVFjphYHKbA mYSzLYeMJTGtxBZiIDQuqNTTOVBeA() { }

		internal void oBoRacctcqiafXrxEeFZiMMYqZXeA(int unnamed_param_0) { }

		internal void POogAViSkbtuGemgLxofGAVQDpJPA(int unnamed_param_0) { }

	}

	[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class RuleSetMapping : IDeepCloneable
	{
		[CustomObfuscation]
		[SerializeField]
		private bool _enabled; //Field offset: 0x10
		[CustomObfuscation]
		[SerializeField]
		private int _id; //Field offset: 0x14

		public internal bool enabled
		{
			 get { } //Length: 5
			internal set { } //Length: 4
		}

		public internal int id
		{
			 get { } //Length: 4
			internal set { } //Length: 4
		}

		public RuleSetMapping() { }

		public RuleSetMapping(RuleSetMapping unnamed_param_0) { }

		public RuleSetMapping(bool unnamed_param_0, int unnamed_param_1) { }

		public void Clear() { }

		public RuleSetMapping Clone() { }

		public bool get_enabled() { }

		public int get_id() { }

		internal void IxiOvcRHWvBObAkXQKBMWYsmOhrC(bool unnamed_param_0) { }

		internal void KyvbRlfYYXPzrDbOConEVpBYBOPj(int unnamed_param_0) { }

		private override object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

		internal ytJCOVIdYroWTnzXkEaZAxeiQGab RRUBcMSzLZnkaiJkbYpjusCWUTmH() { }

	}

	[CustomObfuscation]
	[SerializeField]
	private int _id; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	private string _name; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	private string _descriptiveName; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	private bool _startPlaying; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	private List<Mapping> _defaultJoystickMaps; //Field offset: 0x30
	[CustomObfuscation]
	[SerializeField]
	private List<Mapping> _defaultMouseMaps; //Field offset: 0x38
	[CustomObfuscation]
	[SerializeField]
	private List<Mapping> _defaultKeyboardMaps; //Field offset: 0x40
	[CustomObfuscation]
	[SerializeField]
	private List<Mapping> _defaultCustomControllerMaps; //Field offset: 0x48
	[CustomObfuscation]
	[SerializeField]
	private List<CreateControllerInfo> _startingCustomControllers; //Field offset: 0x50
	[CustomObfuscation]
	[SerializeField]
	private bool _assignMouseOnStart; //Field offset: 0x58
	[CustomObfuscation]
	[SerializeField]
	private bool _assignKeyboardOnStart; //Field offset: 0x59
	[CustomObfuscation]
	[SerializeField]
	private bool _excludeFromControllerAutoAssignment; //Field offset: 0x5A
	[CustomObfuscation]
	[SerializeField]
	private ControllerMapLayoutManagerSettings _controllerMapLayoutManagerSettings; //Field offset: 0x60
	[CustomObfuscation]
	[SerializeField]
	private ControllerMapEnablerSettings _controllerMapEnablerSettings; //Field offset: 0x68

	public internal bool assignKeyboardOnStart
	{
		 get { } //Length: 5
		internal set { } //Length: 4
	}

	public internal bool assignMouseOnStart
	{
		 get { } //Length: 5
		internal set { } //Length: 4
	}

	public ControllerMapEnablerSettings controllerMapEnablerSettings
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public ControllerMapLayoutManagerSettings controllerMapLayoutManagerSettings
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public internal List<Mapping> defaultCustomControllerMaps
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public internal List<Mapping> defaultJoystickMaps
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public internal List<Mapping> defaultKeyboardMaps
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public internal List<Mapping> defaultMouseMaps
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public internal string descriptiveName
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public internal bool excludeFromControllerAutoAssignment
	{
		 get { } //Length: 5
		internal set { } //Length: 4
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

	public internal List<CreateControllerInfo> startingCustomControllers
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public internal bool startPlaying
	{
		 get { } //Length: 5
		internal set { } //Length: 4
	}

	public Player_Editor(Player_Editor unnamed_param_0) { }

	public Player_Editor() { }

	internal void AVQuQLTfVLsPwRebVeQDEumMVIEK(List<Mapping> unnamed_param_0) { }

	public Player_Editor Clone() { }

	internal void eokSIRItelSbPmWzrSCDrQvSKNOG(List<CreateControllerInfo> unnamed_param_0) { }

	internal void FMGZevJqvRRmnTSSJuVBRJiDdbHGA(string unnamed_param_0) { }

	public bool get_assignKeyboardOnStart() { }

	public bool get_assignMouseOnStart() { }

	public ControllerMapEnablerSettings get_controllerMapEnablerSettings() { }

	public ControllerMapLayoutManagerSettings get_controllerMapLayoutManagerSettings() { }

	public List<Mapping> get_defaultCustomControllerMaps() { }

	public List<Mapping> get_defaultJoystickMaps() { }

	public List<Mapping> get_defaultKeyboardMaps() { }

	public List<Mapping> get_defaultMouseMaps() { }

	public string get_descriptiveName() { }

	public bool get_excludeFromControllerAutoAssignment() { }

	public int get_id() { }

	public string get_name() { }

	public List<CreateControllerInfo> get_startingCustomControllers() { }

	public bool get_startPlaying() { }

	internal void glssNWKHlMQkZlBjejefPGrIdved(List<Mapping> unnamed_param_0) { }

	internal void gVrPbYtqqXSHgCoVGJsClChtdgLkA(bool unnamed_param_0) { }

	internal void KyvbRlfYYXPzrDbOConEVpBYBOPj(int unnamed_param_0) { }

	internal void nCxaalFfzRJgmOLctFCJEVTyeKvNA(List<Mapping> unnamed_param_0) { }

	internal void QhaMXYfSsYywkJdHMMBLTodxbYxh(bool unnamed_param_0) { }

	internal void rKELzcKdPKjgXiRmMKLIZvlrcQUeA(string unnamed_param_0) { }

	public void set_controllerMapEnablerSettings(ControllerMapEnablerSettings value) { }

	public void set_controllerMapLayoutManagerSettings(ControllerMapLayoutManagerSettings value) { }

	internal void uEnlLIIDBZXnFypMbfAidOaWehoGA(bool unnamed_param_0) { }

	internal void VYCZheUkhbgbjlnjyQwhzdTNPnPk(List<Mapping> unnamed_param_0) { }

	internal void xlwdAwUnqviuWICetbuGeNwtojuI(bool unnamed_param_0) { }

	internal xUgmPHhtbrIYLhaBQlbjGLmWDldT yUQvckvfLYAOaRIFFbLOUftRdWUF() { }

}

