namespace Rewired.Data.Mapping;

public sealed class HardwareJoystickTemplateMap : HardwareControllerTemplateMap, IHardwareControllerMap, IHardwareControllerTemplateMap, IHardwareControllerMap_Internal, IHardwareControllerTemplateMap_Internal
{
	internal sealed class ElementIdentifierMap
	{
		public int templateId; //Field offset: 0x10
		public int joystickId; //Field offset: 0x14
		public int joystickId2; //Field offset: 0x18
		public bool splitAxis; //Field offset: 0x1C

		public ElementIdentifierMap() { }

	}

	internal sealed class Entry
	{
		public int id; //Field offset: 0x10
		public string name; //Field offset: 0x18
		public string joystickGuid; //Field offset: 0x20
		public string fileGuid; //Field offset: 0x28
		public List<ElementIdentifierMap> elementIdentifierMappings; //Field offset: 0x30

		public Guid JoystickGuid
		{
			 get { } //Length: 220
		}

		public Entry() { }

		public Guid get_JoystickGuid() { }

		public ElementIdentifierMap GetElementIdentifierMap(int templateId) { }

		public void GetElementIdentifierMaps(int templateId, List<ElementIdentifierMap> results) { }

		public int GetJoystickElementId(int templateElementId) { }

		public int GetTemplateElementId(int joystickElementId) { }

	}

	[CompilerGenerated]
	private sealed class PAXoJUykqnHcGRqWoMXcYKNdpzAP : IDisposable, IEnumerable, IEnumerator, IEnumerable<IControllerElementIdentifierCommon_Internal>, IEnumerator<IControllerElementIdentifierCommon_Internal>
	{
		private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
		private IControllerElementIdentifierCommon_Internal QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
		private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
		public HardwareJoystickTemplateMap SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
		private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

		private override IControllerElementIdentifierCommon_Internal System.Collections.Generic.IEnumerator<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>.Current
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
		public PAXoJUykqnHcGRqWoMXcYKNdpzAP(int unnamed_param_0) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<IControllerElementIdentifierCommon_Internal> System.Collections.Generic.IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>.GetEnumerator() { }

		[DebuggerHidden]
		private override IControllerElementIdentifierCommon_Internal System.Collections.Generic.IEnumerator<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class SpecialElementEntry : IControllerTemplateMapSpecialElement_Internal
	{
		public int elementIdentifierId; //Field offset: 0x10
		public string data; //Field offset: 0x18

		public SpecialElementEntry() { }

		private override T Rewired.Data.Mapping.IControllerTemplateMapSpecialElement_Internal.GetMapping() { }

	}

	[CompilerGenerated]
	private sealed class YLifSlGETUleAtycLdlRcQegBAFbb : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerTemplateElementIdentifier>, IEnumerator<ControllerTemplateElementIdentifier>
	{
		private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
		private ControllerTemplateElementIdentifier QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
		private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
		public HardwareJoystickTemplateMap SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
		private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

		private override ControllerTemplateElementIdentifier System.Collections.Generic.IEnumerator<Rewired.ControllerTemplateElementIdentifier>.Current
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
		public YLifSlGETUleAtycLdlRcQegBAFbb(int unnamed_param_0) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<ControllerTemplateElementIdentifier> System.Collections.Generic.IEnumerable<Rewired.ControllerTemplateElementIdentifier>.GetEnumerator() { }

		[DebuggerHidden]
		private override ControllerTemplateElementIdentifier System.Collections.Generic.IEnumerator<Rewired.ControllerTemplateElementIdentifier>.get_Current() { }

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
	private string controllerName; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	private string description; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	private string templateGuid; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	private string className; //Field offset: 0x30
	[CustomObfuscation]
	[SerializeField]
	private ControllerTemplateElementIdentifier_Editor[] elementIdentifiers; //Field offset: 0x38
	[CustomObfuscation]
	[SerializeField]
	private List<Entry> joysticks; //Field offset: 0x40
	[CustomObfuscation]
	[SerializeField]
	private SpecialElementEntry[] specialElements; //Field offset: 0x48
	[CustomObfuscation]
	[SerializeField]
	private int elementIdentifierIdCounter; //Field offset: 0x50
	[CustomObfuscation]
	[SerializeField]
	private int joystickIdCounter; //Field offset: 0x54

	public string ClassName
	{
		 get { } //Length: 5
	}

	public string ControllerName
	{
		 get { } //Length: 5
	}

	public IEnumerable<ControllerTemplateElementIdentifier> ElementIdentifiers
	{
		 get { } //Length: 131
	}

	public virtual Guid Guid
	{
		 get { } //Length: 113
	}

	private override IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.ElementIdentifiers
	{
		private get { } //Length: 131
	}

	private override string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.name
	{
		private get { } //Length: 5
	}

	private override Guid Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.typeGuid
	{
		private get { } //Length: 45
	}

	public HardwareJoystickTemplateMap() { }

	private Entry AhkzFQTtbmsfGsNqAbBxZiSMWrg(Guid unnamed_param_0) { }

	[CustomObfuscation]
	public override bool ContainsElementIdentifier(int id) { }

	public string get_ClassName() { }

	public string get_ControllerName() { }

	public IEnumerable<ControllerTemplateElementIdentifier> get_ElementIdentifiers() { }

	public virtual Guid get_Guid() { }

	[CustomObfuscation]
	public ControllerTemplateElementIdentifier GetElementIdentifier(int id) { }

	[CustomObfuscation]
	public override Int32[] GetElementIdentifierIds() { }

	[CustomObfuscation]
	public override String[] GetElementIdentifierNames() { }

	[CustomObfuscation]
	internal String[] GetElementIdentifierScriptingNames(bool useAlternate) { }

	public string GetJoystickFileGuidString(int joystickId) { }

	public Guid GetJoystickGuid(int joystickId) { }

	public int GetJoystickId(Guid guid) { }

	public Int32[] GetJoystickIds() { }

	public String[] GetJoystickNames() { }

	public override int GetMappableElementIdentifierInfo(out String[] names, out Int32[] ids) { }

	public int GetNonMappableElementIdentifierInfo(out String[] names, out Int32[] ids) { }

	[CustomObfuscation]
	internal SpecialElementEntry[] GetSpecialElementsOrig() { }

	internal bool GHixjGrRRjBTkPhztBbpbndGBSrjA(ControllerMap_Editor unnamed_param_0, HardwareJoystickMap unnamed_param_1, Guid unnamed_param_2, out string unnamed_param_3) { }

	internal ControllerTemplateElementIdentifier KJIovDyBiHimkZjuNWNefwoPnioJ(Guid unnamed_param_0, int unnamed_param_1) { }

	private int lpTNsOMgCQqCtNuCVdBZbMiqQDsj(int unnamed_param_0) { }

	private override IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_ElementIdentifiers() { }

	private override IControllerElementIdentifierCommon_Internal Rewired.Data.Mapping.IHardwareControllerMap_Internal.GetElementIdentifier(int id) { }

	private override string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.get_name() { }

	private override Guid Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.get_typeGuid() { }

	private override EOKrBWwFWFlsxOBzKuftPINpDfyg Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetAxisTarget(Controller controller, int elementIdentifierId) { }

	private override EOKrBWwFWFlsxOBzKuftPINpDfyg Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetButtonTarget(Controller controller, int elementIdentifierId) { }

	private override int Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetElementIdentifierCount() { }

	private override IControllerTemplateMapSpecialElement_Internal Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetSpecialTemplateElementByElementIdentifierId(int id) { }

	private override IControllerTemplateElementIdentifier Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifier(int index) { }

	private override IControllerTemplateElementIdentifier Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifierById(int elementIdentifierId) { }

}

