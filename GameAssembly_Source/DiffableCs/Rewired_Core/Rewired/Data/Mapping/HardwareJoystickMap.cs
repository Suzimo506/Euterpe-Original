namespace Rewired.Data.Mapping;

[CustomClassObfuscation]
public sealed class HardwareJoystickMap : ScriptableObject, IHardwareControllerMap, IHardwareControllerMap_Internal
{
	[CustomClassObfuscation]
	internal class AxisCalibrationInfoEntry : IDeepCloneable
	{
		[SerializeField]
		internal AlternateAxisCalibrationType key; //Field offset: 0x10
		[SerializeField]
		internal AxisCalibrationInfo calibration; //Field offset: 0x18

		public AxisCalibrationInfoEntry(AxisCalibrationInfoEntry unnamed_param_0) { }

		public override object DeepClone() { }

		protected override void ImportVars(AxisCalibrationInfoEntry source) { }

		public static Dictionary<Int32, AxisCalibrationInfo> ToDictionary(AxisCalibrationInfoEntry[] calibrations, bool deepClone) { }

	}

	[CustomClassObfuscation]
	internal class CompoundElement : IDeepCloneable
	{
		public CompoundControllerElementType type; //Field offset: 0x10
		public int elementIdentifier; //Field offset: 0x14
		public Int32[] componentElementIdentifiers; //Field offset: 0x18

		public int elementCount
		{
			 get { } //Length: 14
		}

		public CompoundElement() { }

		public CompoundElement(CompoundElement unnamed_param_0) { }

		public override object DeepClone() { }

		public int get_elementCount() { }

		public int GetComponentElementIdentifierId(int index) { }

		protected override void ImportVars(CompoundElement source) { }

		internal static void SortHatElementsClockwise(CompoundElement element) { }

	}

	[CompilerGenerated]
	private sealed class DvQTIDIuOxIuXYFKvgdCxoYgVZgs : IDisposable, IEnumerable, IEnumerator, IEnumerable<Guid>, IEnumerator<Guid>
	{
		private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
		private Guid QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x14
		private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x24
		public HardwareJoystickMap SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
		private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

		private override Guid System.Collections.Generic.IEnumerator<System.Guid>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 68
		}

		[DebuggerHidden]
		public DvQTIDIuOxIuXYFKvgdCxoYgVZgs(int unnamed_param_0) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Guid> System.Collections.Generic.IEnumerable<System.Guid>.GetEnumerator() { }

		[DebuggerHidden]
		private override Guid System.Collections.Generic.IEnumerator<System.Guid>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CustomClassObfuscation]
	internal abstract class Elements_Base : IDeepCloneable
	{

		public abstract int axisCount
		{
			 get { } //Length: 0
		}

		public abstract int buttonCount
		{
			 get { } //Length: 0
		}

		protected Elements_Base() { }

		internal override void CopyVars(Elements_Base destination) { }

		public abstract object DeepClone() { }

		public abstract int get_axisCount() { }

		public abstract int get_buttonCount() { }

		internal abstract bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal abstract ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	}

	[CompilerGenerated]
	private sealed class hIuWRzlwGLrGpCIpFJesYNSZqQTN : IDisposable, IEnumerable, IEnumerator, IEnumerable<JoystickType>, IEnumerator<JoystickType>
	{
		private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
		private JoystickType QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x14
		private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x18
		public HardwareJoystickMap SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x20
		private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x28

		private override JoystickType System.Collections.Generic.IEnumerator<Rewired.JoystickType>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 66
		}

		[DebuggerHidden]
		public hIuWRzlwGLrGpCIpFJesYNSZqQTN(int unnamed_param_0) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<JoystickType> System.Collections.Generic.IEnumerable<Rewired.JoystickType>.GetEnumerator() { }

		[DebuggerHidden]
		private override JoystickType System.Collections.Generic.IEnumerator<Rewired.JoystickType>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CustomClassObfuscation]
	internal abstract class MatchingCriteria_Base : IDeepCloneable
	{
		internal class ElementCount_Base : IDeepCloneable
		{
			public int axisCount; //Field offset: 0x10
			public int buttonCount; //Field offset: 0x14

			public ElementCount_Base() { }

			internal override void BnqhzELOcDQdRgbpbumxMbohILKB(ElementCount_Base unnamed_param_0) { }

			public override object DeepClone() { }

			internal override bool ixJMIqdEUcrQYRKEvciaJVFWyUQu(BridgedControllerHWInfo unnamed_param_0) { }

		}

		public int axisCount; //Field offset: 0x10
		public int buttonCount; //Field offset: 0x14
		public bool disabled; //Field offset: 0x18
		public string tag; //Field offset: 0x20

		internal abstract int alternateElementCount
		{
			internal get { } //Length: 0
		}

		internal abstract bool hasData
		{
			internal get { } //Length: 0
		}

		internal override bool isAllowed
		{
			internal get { } //Length: 8
		}

		protected MatchingCriteria_Base() { }

		internal override void CopyVars(MatchingCriteria_Base destination) { }

		public abstract object DeepClone() { }

		internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

		internal abstract int get_alternateElementCount() { }

		internal abstract bool get_hasData() { }

		internal override bool get_isAllowed() { }

		internal abstract ElementCount_Base GetAlternateElementCount(int index) { }

		internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch) { }

		internal static bool StringMatches(string searchIn, string searchFor, bool useRegex) { }

	}

	[CustomClassObfuscation]
	internal abstract class Platform : IDeepCloneable
	{
		[CompilerGenerated]
		private sealed class VtmobOcNKXDICbZRBcGnFkQrGXgh : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform>, IEnumerator<Platform>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Platform QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private IList<Platform> ZSQiGLxNaUnLDimudoINhgYZEeMP; //Field offset: 0x30
			private int coAlIMszcaiCYCKYNVFNwzmxqUgU; //Field offset: 0x38

			private override Platform System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform>.Current
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
			public VtmobOcNKXDICbZRBcGnFkQrGXgh(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Platform> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform>.GetEnumerator() { }

			[DebuggerHidden]
			private override Platform System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public string description; //Field offset: 0x10

		public abstract int assignedAxisCount
		{
			 get { } //Length: 0
		}

		public abstract int assignedButtonCount
		{
			 get { } //Length: 0
		}

		public override string controllerNameOverride
		{
			 get { } //Length: 3
		}

		internal abstract bool disabled
		{
			internal get { } //Length: 0
		}

		internal abstract Elements_Base elements_base
		{
			internal get { } //Length: 0
		}

		internal abstract bool hasData
		{
			internal get { } //Length: 0
		}

		internal bool hasVariants
		{
			internal get { } //Length: 21
		}

		internal override bool isAllowed
		{
			internal get { } //Length: 98
		}

		internal abstract InputPlatform platform
		{
			internal get { } //Length: 0
		}

		internal bool selfOrVariantHasData
		{
			internal get { } //Length: 420
		}

		internal bool selfOrVariantIsAllowed
		{
			internal get { } //Length: 420
		}

		internal bool selfOrVariantIsValid
		{
			internal get { } //Length: 479
		}

		[CustomObfuscation]
		internal int variantCount
		{
			internal get { } //Length: 117
		}

		internal IEnumerable<Platform> Variants
		{
			internal get { } //Length: 131
		}

		internal abstract IList<Platform> variants_base
		{
			internal get { } //Length: 0
		}

		protected Platform() { }

		internal abstract void CopyVars(Platform destination) { }

		public abstract object DeepClone() { }

		public abstract int get_assignedAxisCount() { }

		public abstract int get_assignedButtonCount() { }

		public override string get_controllerNameOverride() { }

		internal abstract bool get_disabled() { }

		internal abstract Elements_Base get_elements_base() { }

		internal abstract bool get_hasData() { }

		internal bool get_hasVariants() { }

		internal override bool get_isAllowed() { }

		internal abstract InputPlatform get_platform() { }

		internal bool get_selfOrVariantHasData() { }

		internal bool get_selfOrVariantIsAllowed() { }

		internal bool get_selfOrVariantIsValid() { }

		internal int get_variantCount() { }

		internal IEnumerable<Platform> get_Variants() { }

		internal abstract IList<Platform> get_variants_base() { }

		internal abstract AxisCalibrationData[] GetAxisCalibrationData() { }

		internal abstract void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal abstract String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal abstract void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal abstract bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal abstract String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal abstract ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal Platform GetFirstValidPlatformMap(out int variantIndex) { }

		internal abstract void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal Platform GetPlatformMap(int variantIndex) { }

		internal int IndexOfElementIdentifier(ControllerElementIdentifier[] elementIdentifiers, int id) { }

		internal abstract bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal abstract bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

		internal HardwareJoystickMap_InputManager ToHardwareJoystickMap_InputManager(HardwareJoystickMap hardwareJoystickMap, InputSource inputSource, InputPlatform actualInputPlatform, int variantIndex) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_AppleGCController : Platform_AppleGCController_Base
	{
		public Platform_AppleGCController_Base[] variants; //Field offset: 0x48

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_AppleGCController() { }

		internal virtual void CopyVars(Platform destination) { }

		internal static Platform_AppleGCController CreateDefaultMap(BridgedControllerHWInfo bridgedController) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_AppleGCController_Base : Platform_Custom
	{
		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal enum AppleGCControllerElementIdentifier
		{
			None = 0,
			A = 1,
			B = 2,
			X = 3,
			Y = 4,
			LeftShoulder = 5,
			RightShoulder = 6,
			Menu = 7,
			Options = 8,
			Home = 9,
			LeftStickButton = 10,
			RightStickButton = 11,
			DPadUp = 12,
			DPadRight = 13,
			DPadDown = 14,
			DPadLeft = 15,
			LeftStickX = 16,
			LeftStickY = 17,
			RightStickX = 18,
			RightStickY = 19,
			LeftTrigger = 20,
			RightTrigger = 21,
			DPadVertical = 22,
			DPadHorizontal = 23,
			TouchpadButton = 24,
			Paddle1 = 25,
			Paddle2 = 26,
			Paddle3 = 27,
			Paddle4 = 28,
			IndexedButton = 29,
			IndexedAxis = 30,
		}

		[CustomObfuscation]
		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public enum AppleGCControllerElementIdentifierAxes
		{
			None = 0,
			LeftStickX = 16,
			LeftStickY = 17,
			RightStickX = 18,
			RightStickY = 19,
			DPadVertical = 22,
			DPadHorizontal = 23,
			IndexedAxis = 30,
		}

		[CustomObfuscation]
		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public enum AppleGCControllerElementIdentifierButtons
		{
			None = 0,
			A = 1,
			B = 2,
			X = 3,
			Y = 4,
			LeftShoulder = 5,
			RightShoulder = 6,
			Menu = 7,
			Options = 8,
			Home = 9,
			LeftStickButton = 10,
			RightStickButton = 11,
			DPadUp = 12,
			DPadRight = 13,
			DPadDown = 14,
			DPadLeft = 15,
			LeftTrigger = 20,
			RightTrigger = 21,
			TouchpadButton = 24,
			Paddle1 = 25,
			Paddle2 = 26,
			Paddle3 = 27,
			Paddle4 = 28,
			IndexedButton = 29,
		}

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal enum AppleGCControllerElementIdentifierCompoundElements
		{
			None = 0,
			IndexedStick = 31,
			IndexedDPad = 32,
			LeftStick = 33,
			RightStick = 34,
			DPad = 35,
		}

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal enum AppleGCControllerProfileSubType
		{
			None = 0,
			Xbox = 1,
			DualShock = 2,
			DualSense = 3,
			Unknown = -1,
		}

		[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		internal enum AppleGCControllerProfileTypeFlags
		{
			None = 0,
			Generic = 1,
			ExtendedGamepad = 2,
			MicroGamepad = 4,
			Unknown = -2147483648,
		}

		[CustomClassObfuscation]
		internal sealed class Axis : Axis
		{
			public AppleGCControllerElementIdentifier sourceElementId; //Field offset: 0x68

			public Axis() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Button
		{
			public AppleGCControllerElementIdentifier sourceElementId; //Field offset: 0x60

			public Button() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class CompoundElement : IDeepCloneable
		{
			public int elementIdentifier; //Field offset: 0x10
			public int sourceElementIndex; //Field offset: 0x14
			public AppleGCControllerElementIdentifierCompoundElements sourceElementId; //Field offset: 0x18

			public CompoundElement() { }

			internal void CopyVars(CompoundElement destination) { }

			public override object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements
		{
			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18
			public CompoundElement[] compoundElements; //Field offset: 0x20

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			public int compoundElementCount
			{
				 get { } //Length: 14
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			public int get_compoundElementCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CompilerGenerated]
		private sealed class gjFETOEHpaUdnRhwRazEOHfjoSQBA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_AppleGCController_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current
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
			public gjFETOEHpaUdnRhwRazEOHfjoSQBA(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class LWtsQXRMAhSMENnHdOPQafKMMOLv : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_AppleGCController_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current
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
			public LWtsQXRMAhSMENnHdOPQafKMMOLv(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria
		{
			public bool productCategory_useRegex; //Field offset: 0x30
			public String[] productCategory; //Field offset: 0x38
			public AppleGCControllerProfileTypeFlags primaryProfileType; //Field offset: 0x40
			public AppleGCControllerProfileSubType[] profileSubTypes; //Field offset: 0x48

			internal virtual bool hasData
			{
				internal get { } //Length: 56
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 8
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			private bool HasProductCategory() { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

			private bool ProductCategoryMatches(string name) { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20
		public string controllerName; //Field offset: 0x28
		private Axis[] _axesOrigGame; //Field offset: 0x30
		private Button[] _buttonsOrigGame; //Field offset: 0x38
		private CompoundElement[] _compoundElementsOrigGame; //Field offset: 0x40

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal virtual Axis[] Axes
		{
			internal get { } //Length: 296
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal virtual Button[] Buttons
		{
			internal get { } //Length: 296
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal CompoundElement[] CompoundElements
		{
			internal get { } //Length: 296
		}

		internal CompoundElement[] CompoundElements_orig
		{
			internal get { } //Length: 15
		}

		public virtual string controllerNameOverride
		{
			 get { } //Length: 5
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 114
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_AppleGCController_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal virtual Axis[] get_Axes() { }

		internal Axis[] get_Axes_orig() { }

		internal virtual Button[] get_Buttons() { }

		internal Button[] get_Buttons_orig() { }

		internal CompoundElement[] get_CompoundElements() { }

		internal CompoundElement[] get_CompoundElements_orig() { }

		public virtual string get_controllerNameOverride() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal virtual IEnumerable<Axis> IterateAxes() { }

		internal virtual IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal abstract class Platform_Custom : Platform
	{
		[CustomClassObfuscation]
		internal abstract class Axis : Element
		{
			public bool invert; //Field offset: 0x38
			public AxisRange sourceAxisRange; //Field offset: 0x3C
			public Pole buttonAxisContribution; //Field offset: 0x40
			public bool calibrateAxis; //Field offset: 0x44
			public float axisZero; //Field offset: 0x48
			public float axisMin; //Field offset: 0x4C
			public float axisMax; //Field offset: 0x50
			public AxisCalibrationInfoEntry[] alternateCalibrations; //Field offset: 0x58
			public HardwareAxisInfo axisInfo; //Field offset: 0x60

			protected Axis() { }

			internal virtual void CopyVars(Element destination) { }

		}

		[CustomClassObfuscation]
		internal abstract class Button : Element
		{
			public Pole sourceAxisPole; //Field offset: 0x38
			public bool requireMultipleButtons; //Field offset: 0x3C
			public Int32[] requiredButtons; //Field offset: 0x40
			public bool ignoreIfButtonsActive; //Field offset: 0x48
			public Int32[] ignoreIfButtonsActiveButtons; //Field offset: 0x50
			public HardwareButtonInfo buttonInfo; //Field offset: 0x58

			protected Button() { }

			internal virtual void CopyVars(Element destination) { }

		}

		[CustomClassObfuscation]
		internal class CustomCalculationSourceData : IDeepCloneable
		{
			public int sourceType; //Field offset: 0x10
			public int sourceAxis; //Field offset: 0x14
			public int sourceButton; //Field offset: 0x18
			public int sourceOtherAxis; //Field offset: 0x1C
			public AxisRange sourceAxisRange; //Field offset: 0x20
			public float axisDeadZone; //Field offset: 0x24
			public bool invert; //Field offset: 0x28
			public AxisCalibrationType axisCalibrationType; //Field offset: 0x2C
			public float axisZero; //Field offset: 0x30
			public float axisMin; //Field offset: 0x34
			public float axisMax; //Field offset: 0x38

			public CustomCalculationSourceData() { }

			public override object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal abstract class Element : IDeepCloneable
		{
			public int elementIdentifier; //Field offset: 0x10
			public int sourceType; //Field offset: 0x14
			public int sourceAxis; //Field offset: 0x18
			public float axisDeadZone; //Field offset: 0x1C
			public int sourceButton; //Field offset: 0x20
			public CustomCalculation customCalculation; //Field offset: 0x28
			public CustomCalculationSourceData[] customCalculationSourceData; //Field offset: 0x30

			protected Element() { }

			internal override void CopyVars(Element destination) { }

			public abstract object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal abstract class Elements : Elements_Base
		{

			protected Elements() { }

		}

		[CustomClassObfuscation]
		internal abstract class MatchingCriteria : MatchingCriteria_Base
		{
			public bool alwaysMatch; //Field offset: 0x28

			internal virtual int alternateElementCount
			{
				internal get { } //Length: 3
			}

			internal virtual bool hasData
			{
				internal get { } //Length: 17
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 8
			}

			protected MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

			internal virtual int get_alternateElementCount() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual ElementCount_Base GetAlternateElementCount(int index) { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

		}


		internal abstract Axis[] Axes
		{
			internal get { } //Length: 0
		}

		internal abstract Button[] Buttons
		{
			internal get { } //Length: 0
		}

		protected Platform_Custom() { }

		internal virtual void CopyVars(Platform destination) { }

		internal abstract Axis[] get_Axes() { }

		internal abstract Button[] get_Buttons() { }

		internal abstract IEnumerable<Axis> IterateAxes() { }

		internal abstract IEnumerable<Button> IterateButtons() { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_DirectInput : Platform_DirectInput_Base
	{
		public Platform_DirectInput_Base[] variants; //Field offset: 0x28

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_DirectInput() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_DirectInput_Base : Platform_RawOrDirectInput
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Axis_Base
		{

			public Axis() { }

			public virtual object DeepClone() { }

			private void ImportVars(Axis source) { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Button_Base
		{

			public Button() { }

			public virtual object DeepClone() { }

			private void ImportVars(Button source) { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements_Platform_Base
		{
			[CompilerGenerated]
			private sealed class DBqrnshaCAIgGcaJoSaamVuaYOtj : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button_Base>, IEnumerator<Button_Base>
			{
				private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
				private Button_Base QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
				private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
				public Elements SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
				private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

				private override Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.Current
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
				public DBqrnshaCAIgGcaJoSaamVuaYOtj(int unnamed_param_0) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator<Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator() { }

				[DebuggerHidden]
				private override Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			[CompilerGenerated]
			private sealed class IPQdbRnTJwfMvjlRcNTokRkKGmKAb : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis_Base>, IEnumerator<Axis_Base>
			{
				private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
				private Axis_Base QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
				private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
				public Elements SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
				private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

				private override Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.Current
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
				public IPQdbRnTJwfMvjlRcNTokRkKGmKAb(int unnamed_param_0) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator<Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator() { }

				[DebuggerHidden]
				private override Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			internal virtual IEnumerable<Axis_Base> Axes
			{
				internal get { } //Length: 131
			}

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			internal virtual IEnumerable<Button_Base> Buttons
			{
				internal get { } //Length: 131
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual IEnumerable<Axis_Base> get_Axes() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual IEnumerable<Button_Base> get_Buttons() { }

			internal virtual Axis_Base GetAxis(int axisIndex) { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CompilerGenerated]
		private sealed class jEacDTuyNmfaeOLIYNHdoUaZnaGt : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button_Base>, IEnumerator<Button_Base>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button_Base QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_DirectInput_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int usyzylygKIVPdEJCpFHKWFYKKHVj; //Field offset: 0x30
			private int coAlIMszcaiCYCKYNVFNwzmxqUgU; //Field offset: 0x34

			private override Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.Current
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
			public jEacDTuyNmfaeOLIYNHdoUaZnaGt(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class PmyCVWkhpAKqaaoorqkeCvjbeukd : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis_Base>, IEnumerator<Axis_Base>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis_Base QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_DirectInput_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int zZHYliMQNOMeCtFNXSmJusuYbZCh; //Field offset: 0x30
			private int coAlIMszcaiCYCKYNVFNwzmxqUgU; //Field offset: 0x34

			private override Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.Current
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
			public PmyCVWkhpAKqaaoorqkeCvjbeukd(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public Elements elements; //Field offset: 0x20

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_DirectInput_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal Axis[] get_Axes_orig() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal virtual IEnumerable<Axis_Base> IterateAxes() { }

		internal virtual IEnumerable<Button_Base> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_Fallback : Platform_Fallback_Base
	{
		public Platform_Fallback_Base[] variants; //Field offset: 0x28

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_Fallback() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_Fallback_Base : Platform
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Element
		{
			public bool invert; //Field offset: 0x38
			public AxisRange sourceAxisRange; //Field offset: 0x3C
			public Pole buttonAxisContribution; //Field offset: 0x40
			public bool calibrateAxis; //Field offset: 0x44
			public float axisZero; //Field offset: 0x48
			public float axisMin; //Field offset: 0x4C
			public float axisMax; //Field offset: 0x50
			public AxisCalibrationInfoEntry[] alternateCalibrations; //Field offset: 0x58
			public HardwareAxisInfo axisInfo; //Field offset: 0x60

			public Axis() { }

			protected virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Element
		{
			public Pole sourceAxisPole; //Field offset: 0x38
			public UnityAxis unityHat_sourceAxis1; //Field offset: 0x3C
			public UnityAxis unityHat_sourceAxis2; //Field offset: 0x40
			public Vector2 unityHat_isActiveAxisValues1; //Field offset: 0x44
			public Vector2 unityHat_isActiveAxisValues2; //Field offset: 0x4C
			public Vector2 unityHat_isActiveAxisValues3; //Field offset: 0x54
			public Vector2 unityHat_zeroValues; //Field offset: 0x5C
			public bool unityHat_checkNeverPressed; //Field offset: 0x64
			public Vector2 unityHat_neverPressedZeroValues; //Field offset: 0x68
			public bool requireMultipleButtons; //Field offset: 0x70
			public UnityButton[] requiredButtons; //Field offset: 0x78
			public bool ignoreIfButtonsActive; //Field offset: 0x80
			public UnityButton[] ignoreIfButtonsActiveButtons; //Field offset: 0x88
			public HardwareButtonInfo buttonInfo; //Field offset: 0x90

			public Button() { }

			protected virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CompilerGenerated]
		private sealed class cmmfBgbWBugNIvPhUbWBSLBzrPJOA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_Fallback_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Button>.Current
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
			public cmmfBgbWBugNIvPhUbWBSLBzrPJOA(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal class CustomCalculationSourceData : IDeepCloneable
		{
			public int sourceType; //Field offset: 0x10
			public int sourceElement; //Field offset: 0x14
			public AxisRange sourceAxisRange; //Field offset: 0x18
			public float deadzone; //Field offset: 0x1C
			public bool invert; //Field offset: 0x20

			public CustomCalculationSourceData() { }

			public override object DeepClone() { }

		}

		[CompilerGenerated]
		private sealed class drzgaaJXXHleEpHzkxPsTJaeLOos : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_Fallback_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Axis>.Current
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
			public drzgaaJXXHleEpHzkxPsTJaeLOos(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal abstract class Element : IDeepCloneable
		{
			public int elementIdentifier; //Field offset: 0x10
			public HardwareElementSourceTypeWithHat sourceType; //Field offset: 0x14
			public UnityAxis sourceAxis; //Field offset: 0x18
			public float axisDeadZone; //Field offset: 0x1C
			public UnityButton sourceButton; //Field offset: 0x20
			public KeyCode sourceKeyCode; //Field offset: 0x24
			public CustomCalculation customCalculation; //Field offset: 0x28
			public CustomCalculationSourceData[] customCalculationSourceData; //Field offset: 0x30

			protected Element() { }

			protected override void CopyVars(Element destination) { }

			public abstract object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements_Base
		{
			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria_Base
		{
			public bool alwaysMatch; //Field offset: 0x28
			public bool productName_useRegex; //Field offset: 0x29
			public String[] productName; //Field offset: 0x30
			public bool matchUnityVersion; //Field offset: 0x38
			public string matchUnityVersion_min; //Field offset: 0x40
			public string matchUnityVersion_max; //Field offset: 0x48
			public bool matchSysVersion; //Field offset: 0x50
			public string matchSysVersion_min; //Field offset: 0x58
			public string matchSysVersion_max; //Field offset: 0x60

			internal virtual int alternateElementCount
			{
				internal get { } //Length: 3
			}

			internal virtual bool hasData
			{
				internal get { } //Length: 34
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 174
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

			internal virtual int get_alternateElementCount() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual ElementCount_Base GetAlternateElementCount(int index) { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_Fallback_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal Axis[] get_Axes_orig() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal IEnumerable<Axis> IterateAxes() { }

		internal IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_GameCore : Platform_GameCore_Base
	{
		public Platform_GameCore_Base[] variants; //Field offset: 0x40

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_GameCore() { }

		internal virtual void CopyVars(Platform destination) { }

		internal static Platform_GameCore CreateDefaultMap(BridgedControllerHWInfo bridgedController) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_GameCore_Base : Platform_Custom
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Axis
		{
			public int sourceHat; //Field offset: 0x68
			public AxisDirection sourceHatDirection; //Field offset: 0x6C
			public HatType sourceHatType; //Field offset: 0x70
			public AxisRange sourceHatRange; //Field offset: 0x74

			public Axis() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Button
		{
			public int sourceHat; //Field offset: 0x60
			public HatDirection sourceHatDirection; //Field offset: 0x64
			public HatType sourceHatType; //Field offset: 0x68

			public Button() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		internal enum DeviceType
		{
			None = 0,
			Gamepad = 1,
			ArcadeStick = 2,
			FlightStick = 3,
			RacingWheel = 4,
			Raw = 6,
		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements
		{
			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		internal enum GamepadSubType
		{
			None = 0,
			Xbox360 = 1,
			XboxOne = 2,
			DualShock = 3,
			NintendoProController = 4,
			Unknown = 1000,
		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria
		{
			public bool productName_useRegex; //Field offset: 0x30
			public String[] productName; //Field offset: 0x38
			public VidPid[] vidPid; //Field offset: 0x40
			public DeviceType deviceType; //Field offset: 0x48
			public GamepadSubType gamepadSubType; //Field offset: 0x4C
			public int hatCount; //Field offset: 0x50

			internal virtual bool hasData
			{
				internal get { } //Length: 74
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 42
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			private bool HasProductName() { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

			private bool ProductNameMatches(string name) { }

		}

		[CompilerGenerated]
		private sealed class TynrNDmMOHJKbuBQmqTXwWbmJWPk : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_GameCore_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current
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
			public TynrNDmMOHJKbuBQmqTXwWbmJWPk(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class xsNlNroDFlxOcZhiTwVGMIdjMwCp : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_GameCore_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current
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
			public xsNlNroDFlxOcZhiTwVGMIdjMwCp(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20
		public string controllerName; //Field offset: 0x28
		private Axis[] _axesOrigGame; //Field offset: 0x30
		private Button[] _buttonsOrigGame; //Field offset: 0x38

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal virtual Axis[] Axes
		{
			internal get { } //Length: 296
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal virtual Button[] Buttons
		{
			internal get { } //Length: 296
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		public virtual string controllerNameOverride
		{
			 get { } //Length: 5
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_GameCore_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal virtual Axis[] get_Axes() { }

		internal Axis[] get_Axes_orig() { }

		internal virtual Button[] get_Buttons() { }

		internal Button[] get_Buttons_orig() { }

		public virtual string get_controllerNameOverride() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal virtual IEnumerable<Axis> IterateAxes() { }

		internal virtual IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_InternalDriver : Platform_InternalDriver_Base
	{
		public Platform_InternalDriver_Base[] variants; //Field offset: 0x38

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_InternalDriver() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_InternalDriver_Base : Platform_Custom
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Axis
		{
			public int sourceHat; //Field offset: 0x68
			public AxisDirection sourceHatDirection; //Field offset: 0x6C
			public HatType sourceHatType; //Field offset: 0x70
			public AxisRange sourceHatRange; //Field offset: 0x74

			public Axis() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Button
		{
			public int sourceHat; //Field offset: 0x60
			public HatDirection sourceHatDirection; //Field offset: 0x64
			public HatType sourceHatType; //Field offset: 0x68

			public Button() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements
		{
			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CompilerGenerated]
		private sealed class FobJXmJGfyDfNYCfYMSMhzgLKYEF : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_InternalDriver_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current
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
			public FobJXmJGfyDfNYCfYMSMhzgLKYEF(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class iDKGqaXVngGBAoPINcedcCsliQjYA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_InternalDriver_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current
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
			public iDKGqaXVngGBAoPINcedcCsliQjYA(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria
		{
			public bool productName_useRegex; //Field offset: 0x30
			public String[] productName; //Field offset: 0x38
			public VidPid[] vidPid; //Field offset: 0x40
			public int hatCount; //Field offset: 0x48

			internal virtual bool hasData
			{
				internal get { } //Length: 68
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 42
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

			private bool ProductNameMatches(string name) { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20
		private Axis[] _axesOrigGame; //Field offset: 0x28
		private Button[] _buttonsOrigGame; //Field offset: 0x30

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal virtual Axis[] Axes
		{
			internal get { } //Length: 296
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal virtual Button[] Buttons
		{
			internal get { } //Length: 296
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_InternalDriver_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal virtual Axis[] get_Axes() { }

		internal Axis[] get_Axes_orig() { }

		internal virtual Button[] get_Buttons() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal virtual IEnumerable<Axis> IterateAxes() { }

		internal virtual IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_Linux : Platform_Linux_Base
	{
		public Platform_Linux_Base[] variants; //Field offset: 0x28

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_Linux() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_Linux_Base : Platform
	{
		[CustomClassObfuscation]
		internal class Axis : Element
		{
			public int elementIdentifier; //Field offset: 0x10
			public HardwareElementSourceTypeWithHat sourceType; //Field offset: 0x14
			public int sourceAxis; //Field offset: 0x18
			public AxisRange sourceAxisRange; //Field offset: 0x1C
			public bool invert; //Field offset: 0x20
			public float axisDeadZone; //Field offset: 0x24
			public bool calibrateAxis; //Field offset: 0x28
			public float axisZero; //Field offset: 0x2C
			public float axisMin; //Field offset: 0x30
			public float axisMax; //Field offset: 0x34
			public AxisCalibrationInfoEntry[] alternateCalibrations; //Field offset: 0x38
			public HardwareAxisInfo axisInfo; //Field offset: 0x40
			public int sourceButton; //Field offset: 0x48
			public Pole buttonAxisContribution; //Field offset: 0x4C
			public int sourceHat; //Field offset: 0x50
			public AxisDirection sourceHatDirection; //Field offset: 0x54
			public AxisRange sourceHatRange; //Field offset: 0x58

			public Axis() { }

			public virtual object DeepClone() { }

			protected virtual void ImportVars(Element source) { }

		}

		[CustomClassObfuscation]
		internal class Button : Element
		{
			public int elementIdentifier; //Field offset: 0x10
			public HardwareElementSourceTypeWithHat sourceType; //Field offset: 0x14
			public int sourceButton; //Field offset: 0x18
			public int sourceAxis; //Field offset: 0x1C
			public Pole sourceAxisPole; //Field offset: 0x20
			public float axisDeadZone; //Field offset: 0x24
			public int sourceHat; //Field offset: 0x28
			public HatType sourceHatType; //Field offset: 0x2C
			public HatDirection sourceHatDirection; //Field offset: 0x30
			public bool requireMultipleButtons; //Field offset: 0x34
			public Int32[] requiredButtons; //Field offset: 0x38
			public bool ignoreIfButtonsActive; //Field offset: 0x40
			public Int32[] ignoreIfButtonsActiveButtons; //Field offset: 0x48
			public HardwareButtonInfo buttonInfo; //Field offset: 0x50

			public Button() { }

			public virtual object DeepClone() { }

			protected virtual void ImportVars(Element source) { }

		}

		[CustomClassObfuscation]
		internal abstract class Element : IDeepCloneable
		{

			protected Element() { }

			public abstract object DeepClone() { }

			protected override void ImportVars(Element source) { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements_Base
		{
			[CompilerGenerated]
			private sealed class KHiuymedzyrOPVMhyKIiRSievuSF : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
			{
				private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
				private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
				private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
				public Elements SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
				private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

				private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.Current
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
				public KHiuymedzyrOPVMhyKIiRSievuSF(int unnamed_param_0) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.GetEnumerator() { }

				[DebuggerHidden]
				private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			[CompilerGenerated]
			private sealed class tEJGpaqsRxmzMBnOZHYEeWZfllfd : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
			{
				private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
				private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
				private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
				public Elements SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
				private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

				private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.Current
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
				public tEJGpaqsRxmzMBnOZHYEeWZfllfd(int unnamed_param_0) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.GetEnumerator() { }

				[DebuggerHidden]
				private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			internal IEnumerable<Axis> Axes
			{
				internal get { } //Length: 131
			}

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			internal IEnumerable<Button> Buttons
			{
				internal get { } //Length: 131
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			internal IEnumerable<Axis> get_Axes() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal IEnumerable<Button> get_Buttons() { }

			internal Axis GetAxis(int axisIndex) { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria_Base
		{
			internal sealed class ElementCount : ElementCount_Base
			{
				public int hatCount; //Field offset: 0x18

				public ElementCount() { }

				internal virtual void BnqhzELOcDQdRgbpbumxMbohILKB(ElementCount_Base unnamed_param_0) { }

				public virtual object DeepClone() { }

				internal virtual bool ixJMIqdEUcrQYRKEvciaJVFWyUQu(BridgedControllerHWInfo unnamed_param_0) { }

			}

			public int hatCount; //Field offset: 0x28
			public ElementCount[] alternateElementCounts; //Field offset: 0x30
			public bool manufacturer_useRegex; //Field offset: 0x38
			public bool productName_useRegex; //Field offset: 0x39
			public bool systemName_useRegex; //Field offset: 0x3A
			public String[] manufacturer; //Field offset: 0x40
			public String[] productName; //Field offset: 0x48
			public String[] systemName; //Field offset: 0x50
			public String[] productGUID; //Field offset: 0x58

			internal virtual int alternateElementCount
			{
				internal get { } //Length: 14
			}

			internal virtual bool hasData
			{
				internal get { } //Length: 44
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 21
			}

			public MatchingCriteria() { }

			private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo) { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

			internal virtual int get_alternateElementCount() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual ElementCount_Base GetAlternateElementCount(int index) { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

			private bool NameMatches(string name, String[] names, bool useRegex) { }

		}

		[CompilerGenerated]
		private sealed class NoXtnqxLGZgFeIhpNxABzkMufqfO : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_Linux_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int zZHYliMQNOMeCtFNXSmJusuYbZCh; //Field offset: 0x30
			private int coAlIMszcaiCYCKYNVFNwzmxqUgU; //Field offset: 0x34

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.Current
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
			public NoXtnqxLGZgFeIhpNxABzkMufqfO(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class xLXvhxqmPtfgXAPVppnPjPnqmbOb : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_Linux_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int usyzylygKIVPdEJCpFHKWFYKKHVj; //Field offset: 0x30
			private int coAlIMszcaiCYCKYNVFNwzmxqUgU; //Field offset: 0x34

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.Current
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
			public xLXvhxqmPtfgXAPVppnPjPnqmbOb(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_Linux_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal Axis[] get_Axes_orig() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal IEnumerable<Axis> IterateAxes() { }

		internal IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_NintendoSwitch : Platform_NintendoSwitch_Base
	{
		public Platform_NintendoSwitch_Base[] variants; //Field offset: 0x38

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_NintendoSwitch() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_NintendoSwitch_Base : Platform_Custom
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Axis
		{

			public Axis() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Button
		{

			public Button() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements
		{
			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CompilerGenerated]
		private sealed class fQDaaCqgSpSVIIYWMIspwBsZZTQu : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_NintendoSwitch_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current
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
			public fQDaaCqgSpSVIIYWMIspwBsZZTQu(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class hLiTONWfLCXiwmTwukmeSBKiZfHf : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_NintendoSwitch_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current
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
			public hLiTONWfLCXiwmTwukmeSBKiZfHf(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria
		{
			public bool productName_useRegex; //Field offset: 0x30
			public String[] productName; //Field offset: 0x38

			internal virtual bool hasData
			{
				internal get { } //Length: 52
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 42
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20
		private Axis[] _axesOrigGame; //Field offset: 0x28
		private Button[] _buttonsOrigGame; //Field offset: 0x30

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal virtual Axis[] Axes
		{
			internal get { } //Length: 296
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal virtual Button[] Buttons
		{
			internal get { } //Length: 296
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_NintendoSwitch_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal virtual Axis[] get_Axes() { }

		internal Axis[] get_Axes_orig() { }

		internal virtual Button[] get_Buttons() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal virtual IEnumerable<Axis> IterateAxes() { }

		internal virtual IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_OSX : Platform_OSX_Base
	{
		public Platform_OSX_Base[] variants; //Field offset: 0x28

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_OSX() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_OSX_Base : Platform
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Element
		{
			public int elementIdentifier; //Field offset: 0x10
			public HardwareElementSourceTypeWithHat sourceType; //Field offset: 0x14
			public int sourceStick; //Field offset: 0x18
			public OSXAxis sourceAxis; //Field offset: 0x1C
			public int sourceOtherAxis; //Field offset: 0x20
			public AxisRange sourceAxisRange; //Field offset: 0x24
			public bool invert; //Field offset: 0x28
			public float axisDeadZone; //Field offset: 0x2C
			public bool calibrateAxis; //Field offset: 0x30
			public float axisZero; //Field offset: 0x34
			public float axisMin; //Field offset: 0x38
			public float axisMax; //Field offset: 0x3C
			public AxisCalibrationInfoEntry[] alternateCalibrations; //Field offset: 0x40
			public HardwareAxisInfo axisInfo; //Field offset: 0x48
			public int sourceButton; //Field offset: 0x50
			public Pole buttonAxisContribution; //Field offset: 0x54
			public int sourceHat; //Field offset: 0x58
			public AxisDirection sourceHatDirection; //Field offset: 0x5C
			public AxisRange sourceHatRange; //Field offset: 0x60

			public Axis() { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Element
		{
			public int elementIdentifier; //Field offset: 0x10
			public HardwareElementSourceTypeWithHat sourceType; //Field offset: 0x14
			public int sourceButton; //Field offset: 0x18
			public int sourceStick; //Field offset: 0x1C
			public OSXAxis sourceAxis; //Field offset: 0x20
			public int sourceOtherAxis; //Field offset: 0x24
			public Pole sourceAxisPole; //Field offset: 0x28
			public float axisDeadZone; //Field offset: 0x2C
			public int sourceHat; //Field offset: 0x30
			public HatType sourceHatType; //Field offset: 0x34
			public HatDirection sourceHatDirection; //Field offset: 0x38
			public bool requireMultipleButtons; //Field offset: 0x3C
			public Int32[] requiredButtons; //Field offset: 0x40
			public bool ignoreIfButtonsActive; //Field offset: 0x48
			public Int32[] ignoreIfButtonsActiveButtons; //Field offset: 0x50
			public HardwareButtonInfo buttonInfo; //Field offset: 0x58

			public Button() { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal abstract class Element : IDeepCloneable
		{

			protected Element() { }

			public abstract object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements_Base
		{
			[CompilerGenerated]
			private sealed class jErDvPoOhWAvDbAIUeUarJpWyLKWA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
			{
				private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
				private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
				private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
				public Elements SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
				private Axis[] inuxbZbMYBTTtRdheIzZHkqdxpdaA; //Field offset: 0x30
				private int kBbpVzVPgoezUKVCwInEjUqBfbMfb; //Field offset: 0x38

				private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.Current
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
				public jErDvPoOhWAvDbAIUeUarJpWyLKWA(int unnamed_param_0) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.GetEnumerator() { }

				[DebuggerHidden]
				private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			[CompilerGenerated]
			private sealed class QZxmpdhVXbmWqBhPZEkxLtCnADQC : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
			{
				private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
				private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
				private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
				public Elements SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
				private Button[] inuxbZbMYBTTtRdheIzZHkqdxpdaA; //Field offset: 0x30
				private int kBbpVzVPgoezUKVCwInEjUqBfbMfb; //Field offset: 0x38

				private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.Current
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
				public QZxmpdhVXbmWqBhPZEkxLtCnADQC(int unnamed_param_0) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.GetEnumerator() { }

				[DebuggerHidden]
				private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

			public IEnumerable<Axis> IterateAxes() { }

			public IEnumerable<Button> IterateButtons() { }

		}

		[CompilerGenerated]
		private sealed class LrOYlJDcfvJphDPFEbirBtQhWeN : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_OSX_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.Current
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
			public LrOYlJDcfvJphDPFEbirBtQhWeN(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria_Base
		{
			internal sealed class ElementCount : ElementCount_Base
			{
				public int hatCount; //Field offset: 0x18

				public ElementCount() { }

				internal virtual void BnqhzELOcDQdRgbpbumxMbohILKB(ElementCount_Base unnamed_param_0) { }

				public virtual object DeepClone() { }

				internal virtual bool ixJMIqdEUcrQYRKEvciaJVFWyUQu(BridgedControllerHWInfo unnamed_param_0) { }

			}

			public int hatCount; //Field offset: 0x28
			public ElementCount[] alternateElementCounts; //Field offset: 0x30
			public bool productName_useRegex; //Field offset: 0x38
			public String[] productName; //Field offset: 0x40
			public String[] manufacturer; //Field offset: 0x48
			public Int32[] productId; //Field offset: 0x50
			public Int32[] vendorId; //Field offset: 0x58

			internal virtual int alternateElementCount
			{
				internal get { } //Length: 14
			}

			internal virtual bool hasData
			{
				internal get { } //Length: 60
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 21
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

			internal virtual int get_alternateElementCount() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual ElementCount_Base GetAlternateElementCount(int index) { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

			private bool ProductNameMatches(string name) { }

		}

		[CompilerGenerated]
		private sealed class wooQEGhWbRdfeeURSBmiIufvIVXg : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_OSX_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.Current
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
			public wooQEGhWbRdfeeURSBmiIufvIVXg(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_OSX_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal Axis[] get_Axes_orig() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal IEnumerable<Axis> IterateAxes() { }

		internal IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_PS4 : Platform_PS4_Base
	{
		public Platform_PS4_Base[] variants; //Field offset: 0x38

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_PS4() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_PS4_Base : Platform_Custom
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Axis
		{

			public Axis() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Button
		{

			public Button() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements
		{
			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CompilerGenerated]
		private sealed class ENknhuYAjvIDRQpmXSFdfEchTGCi : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_PS4_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current
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
			public ENknhuYAjvIDRQpmXSFdfEchTGCi(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria
		{
			public bool productName_useRegex; //Field offset: 0x30
			public String[] productName; //Field offset: 0x38

			internal virtual bool hasData
			{
				internal get { } //Length: 52
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 42
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

		}

		[CompilerGenerated]
		private sealed class TLaokozTbiGwmYZRkvNouVkNlYmS : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_PS4_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current
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
			public TLaokozTbiGwmYZRkvNouVkNlYmS(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20
		private Axis[] _axesOrigGame; //Field offset: 0x28
		private Button[] _buttonsOrigGame; //Field offset: 0x30

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal virtual Axis[] Axes
		{
			internal get { } //Length: 296
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal virtual Button[] Buttons
		{
			internal get { } //Length: 296
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_PS4_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal virtual Axis[] get_Axes() { }

		internal Axis[] get_Axes_orig() { }

		internal virtual Button[] get_Buttons() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal virtual IEnumerable<Axis> IterateAxes() { }

		internal virtual IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_PS5 : Platform_PS5_Base
	{
		public Platform_PS5_Base[] variants; //Field offset: 0x40

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_PS5() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_PS5_Base : Platform_Custom
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Axis
		{

			public Axis() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Button
		{

			public Button() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements
		{
			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CompilerGenerated]
		private sealed class hnUUiroaNmEeNsgKsHOLfmxMKOuN : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_PS5_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current
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
			public hnUUiroaNmEeNsgKsHOLfmxMKOuN(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria
		{
			public bool productName_useRegex; //Field offset: 0x30
			public String[] productName; //Field offset: 0x38

			internal virtual bool hasData
			{
				internal get { } //Length: 52
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 42
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

		}

		[CompilerGenerated]
		private sealed class wMxQDevigxAscKgglXnIuEwJyRskA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_PS5_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current
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
			public wMxQDevigxAscKgglXnIuEwJyRskA(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20
		public string controllerName; //Field offset: 0x28
		private Axis[] _axesOrigGame; //Field offset: 0x30
		private Button[] _buttonsOrigGame; //Field offset: 0x38

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal virtual Axis[] Axes
		{
			internal get { } //Length: 296
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal virtual Button[] Buttons
		{
			internal get { } //Length: 296
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		public virtual string controllerNameOverride
		{
			 get { } //Length: 5
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_PS5_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal virtual Axis[] get_Axes() { }

		internal Axis[] get_Axes_orig() { }

		internal virtual Button[] get_Buttons() { }

		internal Button[] get_Buttons_orig() { }

		public virtual string get_controllerNameOverride() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal virtual IEnumerable<Axis> IterateAxes() { }

		internal virtual IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_RawInput : Platform_RawInput_Base
	{
		public Platform_RawInput_Base[] variants; //Field offset: 0x28

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_RawInput() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_RawInput_Base : Platform_RawOrDirectInput
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Axis_Base
		{
			public int sourceOtherAxis; //Field offset: 0x70

			public Axis() { }

			public virtual object DeepClone() { }

			private void ImportVars(Axis source) { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Button_Base
		{
			public int sourceOtherAxis; //Field offset: 0x68

			public Button() { }

			public virtual object DeepClone() { }

			private void ImportVars(Button source) { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements_Platform_Base
		{
			[CompilerGenerated]
			private sealed class MItLHIGBEHRXqDkMDJNpVhokHoyg : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button_Base>, IEnumerator<Button_Base>
			{
				private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
				private Button_Base QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
				private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
				public Elements SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
				private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

				private override Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.Current
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
				public MItLHIGBEHRXqDkMDJNpVhokHoyg(int unnamed_param_0) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator<Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator() { }

				[DebuggerHidden]
				private override Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			[CompilerGenerated]
			private sealed class vkXGrnrfOQWfYmeaFgVdYtNLChft : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis_Base>, IEnumerator<Axis_Base>
			{
				private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
				private Axis_Base QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
				private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
				public Elements SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
				private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

				private override Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.Current
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
				public vkXGrnrfOQWfYmeaFgVdYtNLChft(int unnamed_param_0) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator<Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator() { }

				[DebuggerHidden]
				private override Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			internal virtual IEnumerable<Axis_Base> Axes
			{
				internal get { } //Length: 131
			}

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			internal virtual IEnumerable<Button_Base> Buttons
			{
				internal get { } //Length: 131
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual IEnumerable<Axis_Base> get_Axes() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual IEnumerable<Button_Base> get_Buttons() { }

			internal virtual Axis_Base GetAxis(int axisIndex) { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CompilerGenerated]
		private sealed class gcrhoXjDTJmrBAqDatDgGUgvzrbuB : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis_Base>, IEnumerator<Axis_Base>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis_Base QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_RawInput_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int zZHYliMQNOMeCtFNXSmJusuYbZCh; //Field offset: 0x30
			private int coAlIMszcaiCYCKYNVFNwzmxqUgU; //Field offset: 0x34

			private override Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.Current
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
			public gcrhoXjDTJmrBAqDatDgGUgvzrbuB(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class KKLnZYQApLUfXLpdxKTPCSGdhIHS : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button_Base>, IEnumerator<Button_Base>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button_Base QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_RawInput_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int usyzylygKIVPdEJCpFHKWFYKKHVj; //Field offset: 0x30
			private int coAlIMszcaiCYCKYNVFNwzmxqUgU; //Field offset: 0x34

			private override Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.Current
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
			public KKLnZYQApLUfXLpdxKTPCSGdhIHS(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public Elements elements; //Field offset: 0x20

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_RawInput_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal Axis[] get_Axes_orig() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal virtual IEnumerable<Axis_Base> IterateAxes() { }

		internal virtual IEnumerable<Button_Base> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal abstract class Platform_RawOrDirectInput : Platform
	{
		[CustomClassObfuscation]
		internal abstract class Axis_Base : Element
		{
			public int elementIdentifier; //Field offset: 0x20
			public HardwareElementSourceTypeWithHat sourceType; //Field offset: 0x24
			public int sourceAxis; //Field offset: 0x28
			public AxisRange sourceAxisRange; //Field offset: 0x2C
			public bool invert; //Field offset: 0x30
			public float axisDeadZone; //Field offset: 0x34
			public bool calibrateAxis; //Field offset: 0x38
			public float axisZero; //Field offset: 0x3C
			public float axisMin; //Field offset: 0x40
			public float axisMax; //Field offset: 0x44
			public HardwareAxisInfo axisInfo; //Field offset: 0x48
			public AxisCalibrationInfoEntry[] alternateCalibrations; //Field offset: 0x50
			public int sourceButton; //Field offset: 0x58
			public Pole buttonAxisContribution; //Field offset: 0x5C
			public int sourceHat; //Field offset: 0x60
			public AxisDirection sourceHatDirection; //Field offset: 0x64
			public AxisRange sourceHatRange; //Field offset: 0x68

			public Axis_Base() { }

			protected void ImportVars(Axis_Base source) { }

		}

		[CustomClassObfuscation]
		internal abstract class Button_Base : Element
		{
			public int elementIdentifier; //Field offset: 0x20
			public HardwareElementSourceTypeWithHat sourceType; //Field offset: 0x24
			public int sourceButton; //Field offset: 0x28
			public int sourceAxis; //Field offset: 0x2C
			public Pole sourceAxisPole; //Field offset: 0x30
			public float axisDeadZone; //Field offset: 0x34
			public int sourceHat; //Field offset: 0x38
			public HatType sourceHatType; //Field offset: 0x3C
			public HatDirection sourceHatDirection; //Field offset: 0x40
			public bool requireMultipleButtons; //Field offset: 0x44
			public Int32[] requiredButtons; //Field offset: 0x48
			public bool ignoreIfButtonsActive; //Field offset: 0x50
			public Int32[] ignoreIfButtonsActiveButtons; //Field offset: 0x58
			public HardwareButtonInfo buttonInfo; //Field offset: 0x60

			public Button_Base() { }

			protected void ImportVars(Button_Base source) { }

		}

		[CustomClassObfuscation]
		internal class CustomCalculationSourceData : IDeepCloneable
		{
			public int sourceType; //Field offset: 0x10
			public int sourceAxis; //Field offset: 0x14
			public int sourceButton; //Field offset: 0x18
			public int sourceOtherAxis; //Field offset: 0x1C
			public AxisRange sourceAxisRange; //Field offset: 0x20
			public float axisDeadZone; //Field offset: 0x24
			public bool invert; //Field offset: 0x28
			public AxisCalibrationType axisCalibrationType; //Field offset: 0x2C
			public float axisZero; //Field offset: 0x30
			public float axisMin; //Field offset: 0x34
			public float axisMax; //Field offset: 0x38

			public CustomCalculationSourceData() { }

			public override object DeepClone() { }

		}

		internal enum DeviceType
		{
			Any = 0,
			Device = 17,
			Mouse = 18,
			Keyboard = 19,
			Joystick = 20,
			Gamepad = 21,
			Driving = 22,
			Flight = 23,
			FirstPerson = 24,
			ControlDevice = 25,
			ScreenPointer = 26,
			Remote = 27,
			Supplemental = 28,
		}

		[CustomClassObfuscation]
		internal abstract class Element : IDeepCloneable
		{
			public CustomCalculation customCalculation; //Field offset: 0x10
			public CustomCalculationSourceData[] customCalculationSourceData; //Field offset: 0x18

			protected Element() { }

			public abstract object DeepClone() { }

			protected void ImportVars(Element source) { }

		}

		[CustomClassObfuscation]
		internal abstract class Elements_Platform_Base : Elements_Base
		{

			internal abstract IEnumerable<Axis_Base> Axes
			{
				internal get { } //Length: 0
			}

			internal abstract IEnumerable<Button_Base> Buttons
			{
				internal get { } //Length: 0
			}

			protected Elements_Platform_Base() { }

			internal abstract IEnumerable<Axis_Base> get_Axes() { }

			internal abstract IEnumerable<Button_Base> get_Buttons() { }

			internal abstract Axis_Base GetAxis(int axisIndex) { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria_Base
		{
			internal sealed class ElementCount : ElementCount_Base
			{
				public int hatCount; //Field offset: 0x18

				public ElementCount() { }

				internal virtual void BnqhzELOcDQdRgbpbumxMbohILKB(ElementCount_Base unnamed_param_0) { }

				public virtual object DeepClone() { }

				internal virtual bool ixJMIqdEUcrQYRKEvciaJVFWyUQu(BridgedControllerHWInfo unnamed_param_0) { }

			}

			public int hatCount; //Field offset: 0x28
			public ElementCount[] alternateElementCounts; //Field offset: 0x30
			public bool productName_useRegex; //Field offset: 0x38
			public String[] productName; //Field offset: 0x40
			public String[] productGUID; //Field offset: 0x48
			public Int32[] productId; //Field offset: 0x50
			public DeviceType deviceType; //Field offset: 0x58

			internal virtual int alternateElementCount
			{
				internal get { } //Length: 14
			}

			internal virtual bool hasData
			{
				internal get { } //Length: 44
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 21
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

			internal virtual int get_alternateElementCount() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual ElementCount_Base GetAlternateElementCount(int index) { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

			private bool ProductNameMatches(BridgedControllerHWInfo controller) { }

			private bool ProductNameMatches(string name) { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		protected Platform_RawOrDirectInput() { }

		internal virtual void CopyVars(Platform destination) { }

		internal virtual bool get_disabled() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal abstract IEnumerable<Axis_Base> IterateAxes() { }

		internal abstract IEnumerable<Button_Base> IterateButtons() { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_SDL2 : Platform_SDL2_Base
	{
		public Platform_SDL2_Base[] variants; //Field offset: 0x28

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_SDL2() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_SDL2_Base : Platform
	{
		[CompilerGenerated]
		private sealed class aGEUPwlQuvagWyBPYcoZiNKvAbbfb : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_SDL2_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int zZHYliMQNOMeCtFNXSmJusuYbZCh; //Field offset: 0x30
			private int coAlIMszcaiCYCKYNVFNwzmxqUgU; //Field offset: 0x34

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.Current
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
			public aGEUPwlQuvagWyBPYcoZiNKvAbbfb(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal class Axis : Element
		{
			public int elementIdentifier; //Field offset: 0x10
			public HardwareElementSourceTypeWithHat sourceType; //Field offset: 0x14
			public int sourceAxis; //Field offset: 0x18
			public AxisRange sourceAxisRange; //Field offset: 0x1C
			public bool invert; //Field offset: 0x20
			public float axisDeadZone; //Field offset: 0x24
			public bool calibrateAxis; //Field offset: 0x28
			public float axisZero; //Field offset: 0x2C
			public float axisMin; //Field offset: 0x30
			public float axisMax; //Field offset: 0x34
			public AxisCalibrationInfoEntry[] alternateCalibrations; //Field offset: 0x38
			public HardwareAxisInfo axisInfo; //Field offset: 0x40
			public int sourceButton; //Field offset: 0x48
			public Pole buttonAxisContribution; //Field offset: 0x4C
			public int sourceHat; //Field offset: 0x50
			public AxisDirection sourceHatDirection; //Field offset: 0x54
			public AxisRange sourceHatRange; //Field offset: 0x58

			public Axis() { }

			public virtual object DeepClone() { }

			protected virtual void ImportVars(Element source) { }

		}

		[CustomClassObfuscation]
		internal class Button : Element
		{
			public int elementIdentifier; //Field offset: 0x10
			public HardwareElementSourceTypeWithHat sourceType; //Field offset: 0x14
			public int sourceButton; //Field offset: 0x18
			public int sourceAxis; //Field offset: 0x1C
			public Pole sourceAxisPole; //Field offset: 0x20
			public float axisDeadZone; //Field offset: 0x24
			public int sourceHat; //Field offset: 0x28
			public HatType sourceHatType; //Field offset: 0x2C
			public HatDirection sourceHatDirection; //Field offset: 0x30
			public bool requireMultipleButtons; //Field offset: 0x34
			public Int32[] requiredButtons; //Field offset: 0x38
			public bool ignoreIfButtonsActive; //Field offset: 0x40
			public Int32[] ignoreIfButtonsActiveButtons; //Field offset: 0x48
			public HardwareButtonInfo buttonInfo; //Field offset: 0x50

			public Button() { }

			public virtual object DeepClone() { }

			protected virtual void ImportVars(Element source) { }

		}

		[CustomClassObfuscation]
		internal abstract class Element : IDeepCloneable
		{

			protected Element() { }

			public abstract object DeepClone() { }

			protected override void ImportVars(Element source) { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements_Base
		{
			[CompilerGenerated]
			private sealed class mQUqfXJcVaXhWWbfaWNdsYYkSRlf : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
			{
				private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
				private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
				private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
				public Elements SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
				private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

				private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.Current
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
				public mQUqfXJcVaXhWWbfaWNdsYYkSRlf(int unnamed_param_0) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.GetEnumerator() { }

				[DebuggerHidden]
				private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			[CompilerGenerated]
			private sealed class sEAixlwNbPFqAxbsCgPZnNQvnKmk : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
			{
				private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
				private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
				private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
				public Elements SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
				private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

				private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.Current
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
				public sEAixlwNbPFqAxbsCgPZnNQvnKmk(int unnamed_param_0) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.GetEnumerator() { }

				[DebuggerHidden]
				private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			internal IEnumerable<Axis> Axes
			{
				internal get { } //Length: 131
			}

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			internal IEnumerable<Button> Buttons
			{
				internal get { } //Length: 131
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			internal IEnumerable<Axis> get_Axes() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal IEnumerable<Button> get_Buttons() { }

			internal Axis GetAxis(int axisIndex) { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CompilerGenerated]
		private sealed class gOplkvQsbGrfhfWnRYuURoJiwEbe : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_SDL2_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int usyzylygKIVPdEJCpFHKWFYKKHVj; //Field offset: 0x30
			private int coAlIMszcaiCYCKYNVFNwzmxqUgU; //Field offset: 0x34

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.Current
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
			public gOplkvQsbGrfhfWnRYuURoJiwEbe(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria_Base
		{
			internal sealed class ElementCount : ElementCount_Base
			{
				public int hatCount; //Field offset: 0x18

				public ElementCount() { }

				internal virtual void BnqhzELOcDQdRgbpbumxMbohILKB(ElementCount_Base unnamed_param_0) { }

				public virtual object DeepClone() { }

				internal virtual bool ixJMIqdEUcrQYRKEvciaJVFWyUQu(BridgedControllerHWInfo unnamed_param_0) { }

			}

			public int hatCount; //Field offset: 0x28
			public bool manufacturer_useRegex; //Field offset: 0x2C
			public bool productName_useRegex; //Field offset: 0x2D
			public bool systemName_useRegex; //Field offset: 0x2E
			public String[] manufacturer; //Field offset: 0x30
			public String[] productName; //Field offset: 0x38
			public String[] systemName; //Field offset: 0x40
			public String[] productGUID; //Field offset: 0x48

			internal virtual int alternateElementCount
			{
				internal get { } //Length: 3
			}

			internal virtual bool hasData
			{
				internal get { } //Length: 44
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 21
			}

			public MatchingCriteria() { }

			private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo) { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

			internal virtual int get_alternateElementCount() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual ElementCount_Base GetAlternateElementCount(int index) { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

			private bool NameMatches(string name, String[] names, bool useRegex) { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_SDL2_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal Axis[] get_Axes_orig() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal IEnumerable<Axis> IterateAxes() { }

		internal IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_Stadia : Platform_Stadia_Base
	{
		public Platform_Stadia_Base[] variants; //Field offset: 0x40

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_Stadia() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_Stadia_Base : Platform_Custom
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Axis
		{

			public Axis() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Button
		{

			public Button() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements
		{
			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CompilerGenerated]
		private sealed class eqlSBQJKwljZWOQFHtdlxdIyPRXj : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_Stadia_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current
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
			public eqlSBQJKwljZWOQFHtdlxdIyPRXj(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class KxVXsdJheAPrpycrrxrdPggxWsqM : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_Stadia_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current
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
			public KxVXsdJheAPrpycrrxrdPggxWsqM(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria
		{
			public bool productName_useRegex; //Field offset: 0x30
			public String[] productName; //Field offset: 0x38

			internal virtual bool hasData
			{
				internal get { } //Length: 52
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 42
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20
		public string controllerName; //Field offset: 0x28
		private Axis[] _axesOrigGame; //Field offset: 0x30
		private Button[] _buttonsOrigGame; //Field offset: 0x38

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal virtual Axis[] Axes
		{
			internal get { } //Length: 296
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal virtual Button[] Buttons
		{
			internal get { } //Length: 296
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		public virtual string controllerNameOverride
		{
			 get { } //Length: 5
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_Stadia_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal virtual Axis[] get_Axes() { }

		internal Axis[] get_Axes_orig() { }

		internal virtual Button[] get_Buttons() { }

		internal Button[] get_Buttons_orig() { }

		public virtual string get_controllerNameOverride() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal virtual IEnumerable<Axis> IterateAxes() { }

		internal virtual IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_Steam : Platform_Steam_Base
	{
		public Platform_Steam_Base[] variants; //Field offset: 0x28

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_Steam() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_Steam_Base : Platform
	{
		[CustomClassObfuscation]
		internal sealed class Elements : Elements_Base
		{

			public virtual int axisCount
			{
				 get { } //Length: 3
			}

			public virtual int buttonCount
			{
				 get { } //Length: 3
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria_Base
		{

			internal virtual int alternateElementCount
			{
				internal get { } //Length: 3
			}

			internal virtual bool hasData
			{
				internal get { } //Length: 3
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 21
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

			internal virtual int get_alternateElementCount() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual ElementCount_Base GetAlternateElementCount(int index) { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_Steam_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_WebGL : Platform_WebGL_Base
	{
		public Platform_WebGL_Base[] variants; //Field offset: 0x38

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_WebGL() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_WebGL_Base : Platform_Custom
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Axis
		{

			public Axis() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Button
		{

			public Button() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CompilerGenerated]
		private sealed class DyNCzwWxrIMzEXxxFZqCLswpHfke : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_WebGL_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current
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
			public DyNCzwWxrIMzEXxxFZqCLswpHfke(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements
		{
			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CompilerGenerated]
		private sealed class KZOfXzAqviyTyQAoaTbTfLmsIRRe : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_WebGL_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current
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
			public KZOfXzAqviyTyQAoaTbTfLmsIRRe(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria
		{
			internal sealed class ClientInfo : IDeepCloneable
			{
				public int browser; //Field offset: 0x10
				public string browserVersionMin; //Field offset: 0x18
				public string browserVersionMax; //Field offset: 0x20
				public int os; //Field offset: 0x28
				public string osVersionMin; //Field offset: 0x30
				public string osVersionMax; //Field offset: 0x38

				public ClientInfo() { }

				public override object DeepClone() { }

			}

			public bool productName_useRegex; //Field offset: 0x30
			public String[] productName; //Field offset: 0x38
			public String[] productGUID; //Field offset: 0x40
			public Int32[] mapping; //Field offset: 0x48
			public ElementCount_Base[] elementCount; //Field offset: 0x50
			public ClientInfo[] clientInfo; //Field offset: 0x58

			internal virtual bool hasData
			{
				internal get { } //Length: 116
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 42
			}

			public MatchingCriteria() { }

			private static bool CheckBrowserVersion(int browser, string versionMin, string versionMax, String[] currentVersion) { }

			private static bool CheckOSVersion(string versionMin, string versionMax, String[] currentVersion) { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20
		private Axis[] _axesOrigGame; //Field offset: 0x28
		private Button[] _buttonsOrigGame; //Field offset: 0x30

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal virtual Axis[] Axes
		{
			internal get { } //Length: 296
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal virtual Button[] Buttons
		{
			internal get { } //Length: 296
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_WebGL_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal virtual Axis[] get_Axes() { }

		internal Axis[] get_Axes_orig() { }

		internal virtual Button[] get_Buttons() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal virtual IEnumerable<Axis> IterateAxes() { }

		internal virtual IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_WindowsUWP : Platform_WindowsUWP_Base
	{
		public Platform_WindowsUWP_Base[] variants; //Field offset: 0x28

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_WindowsUWP() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_WindowsUWP_Base : Platform
	{
		[CustomClassObfuscation]
		internal class Axis : Element
		{
			public int elementIdentifier; //Field offset: 0x10
			public HardwareElementSourceTypeWithHat sourceType; //Field offset: 0x14
			public int sourceAxis; //Field offset: 0x18
			public AxisRange sourceAxisRange; //Field offset: 0x1C
			public bool invert; //Field offset: 0x20
			public float axisDeadZone; //Field offset: 0x24
			public bool calibrateAxis; //Field offset: 0x28
			public float axisZero; //Field offset: 0x2C
			public float axisMin; //Field offset: 0x30
			public float axisMax; //Field offset: 0x34
			public AxisCalibrationInfoEntry[] alternateCalibrations; //Field offset: 0x38
			public HardwareAxisInfo axisInfo; //Field offset: 0x40
			public int sourceButton; //Field offset: 0x48
			public Pole buttonAxisContribution; //Field offset: 0x4C
			public int sourceHat; //Field offset: 0x50
			public AxisDirection sourceHatDirection; //Field offset: 0x54
			public AxisRange sourceHatRange; //Field offset: 0x58

			public Axis() { }

			public virtual object DeepClone() { }

			protected virtual void ImportVars(Element source) { }

		}

		[CustomClassObfuscation]
		internal class Button : Element
		{
			public int elementIdentifier; //Field offset: 0x10
			public HardwareElementSourceTypeWithHat sourceType; //Field offset: 0x14
			public int sourceButton; //Field offset: 0x18
			public int sourceAxis; //Field offset: 0x1C
			public Pole sourceAxisPole; //Field offset: 0x20
			public float axisDeadZone; //Field offset: 0x24
			public int sourceHat; //Field offset: 0x28
			public HatType sourceHatType; //Field offset: 0x2C
			public HatDirection sourceHatDirection; //Field offset: 0x30
			public bool requireMultipleButtons; //Field offset: 0x34
			public Int32[] requiredButtons; //Field offset: 0x38
			public bool ignoreIfButtonsActive; //Field offset: 0x40
			public Int32[] ignoreIfButtonsActiveButtons; //Field offset: 0x48
			public HardwareButtonInfo buttonInfo; //Field offset: 0x50

			public Button() { }

			public virtual object DeepClone() { }

			protected virtual void ImportVars(Element source) { }

		}

		[CustomClassObfuscation]
		internal abstract class Element : IDeepCloneable
		{

			protected Element() { }

			public abstract object DeepClone() { }

			protected override void ImportVars(Element source) { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements_Base
		{
			[CompilerGenerated]
			private sealed class aBkEInbkJJskWVWGDzZgCnHOsRwy : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
			{
				private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
				private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
				private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
				public Elements SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
				private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

				private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.Current
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
				public aBkEInbkJJskWVWGDzZgCnHOsRwy(int unnamed_param_0) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.GetEnumerator() { }

				[DebuggerHidden]
				private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			[CompilerGenerated]
			private sealed class HxzgjyOiLjOroihAPOdkrTvyunQQ : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
			{
				private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
				private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
				private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
				public Elements SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
				private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

				private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.Current
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
				public HxzgjyOiLjOroihAPOdkrTvyunQQ(int unnamed_param_0) { }

				private override bool MoveNext() { }

				[DebuggerHidden]
				private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.GetEnumerator() { }

				[DebuggerHidden]
				private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.get_Current() { }

				[DebuggerHidden]
				private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

				[DebuggerHidden]
				private override object System.Collections.IEnumerator.get_Current() { }

				[DebuggerHidden]
				private override void System.Collections.IEnumerator.Reset() { }

				[DebuggerHidden]
				private override void System.IDisposable.Dispose() { }

			}

			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			internal IEnumerable<Axis> Axes
			{
				internal get { } //Length: 131
			}

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			internal IEnumerable<Button> Buttons
			{
				internal get { } //Length: 131
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			internal IEnumerable<Axis> get_Axes() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal IEnumerable<Button> get_Buttons() { }

			internal Axis GetAxis(int axisIndex) { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria_Base
		{
			internal sealed class ElementCount : ElementCount_Base
			{
				public int hatCount; //Field offset: 0x18

				public ElementCount() { }

				internal virtual void BnqhzELOcDQdRgbpbumxMbohILKB(ElementCount_Base unnamed_param_0) { }

				public virtual object DeepClone() { }

				internal virtual bool ixJMIqdEUcrQYRKEvciaJVFWyUQu(BridgedControllerHWInfo unnamed_param_0) { }

			}

			public int hatCount; //Field offset: 0x28
			public ElementCount[] alternateElementCounts; //Field offset: 0x30
			public bool manufacturer_useRegex; //Field offset: 0x38
			public bool productName_useRegex; //Field offset: 0x39
			public String[] manufacturer; //Field offset: 0x40
			public String[] productName; //Field offset: 0x48
			public String[] productGUID; //Field offset: 0x50

			internal virtual int alternateElementCount
			{
				internal get { } //Length: 14
			}

			internal virtual bool hasData
			{
				internal get { } //Length: 44
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 21
			}

			public MatchingCriteria() { }

			private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo) { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

			internal virtual int get_alternateElementCount() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual ElementCount_Base GetAlternateElementCount(int index) { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

			private bool NameMatches(string name, String[] names, bool useRegex) { }

		}

		[CompilerGenerated]
		private sealed class MyklvQKUrRGGypQsMgEdJQxSAYfv : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_WindowsUWP_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int usyzylygKIVPdEJCpFHKWFYKKHVj; //Field offset: 0x30
			private int coAlIMszcaiCYCKYNVFNwzmxqUgU; //Field offset: 0x34

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.Current
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
			public MyklvQKUrRGGypQsMgEdJQxSAYfv(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class oMLKfEUoMelxfMEakLnaQdmphNzI : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_WindowsUWP_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int zZHYliMQNOMeCtFNXSmJusuYbZCh; //Field offset: 0x30
			private int coAlIMszcaiCYCKYNVFNwzmxqUgU; //Field offset: 0x34

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.Current
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
			public oMLKfEUoMelxfMEakLnaQdmphNzI(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_WindowsUWP_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal Axis[] get_Axes_orig() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal IEnumerable<Axis> IterateAxes() { }

		internal IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_XboxOne : Platform_XboxOne_Base
	{
		public Platform_XboxOne_Base[] variants; //Field offset: 0x38

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_XboxOne() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_XboxOne_Base : Platform_Custom
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Axis
		{

			public Axis() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Button
		{

			public Button() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CompilerGenerated]
		private sealed class cJytZvOmFOlkGqLFoMydIziJqhng : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_XboxOne_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current
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
			public cJytZvOmFOlkGqLFoMydIziJqhng(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements
		{
			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria
		{
			public bool productName_useRegex; //Field offset: 0x30
			public String[] productName; //Field offset: 0x38

			internal virtual bool hasData
			{
				internal get { } //Length: 52
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 42
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

		}

		[CompilerGenerated]
		private sealed class vxwxORtQNjkwYqcaAftFZTFVJuzg : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_XboxOne_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current
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
			public vxwxORtQNjkwYqcaAftFZTFVJuzg(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20
		private Axis[] _axesOrigGame; //Field offset: 0x28
		private Button[] _buttonsOrigGame; //Field offset: 0x30

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal virtual Axis[] Axes
		{
			internal get { } //Length: 296
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal virtual Button[] Buttons
		{
			internal get { } //Length: 296
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_XboxOne_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal virtual Axis[] get_Axes() { }

		internal Axis[] get_Axes_orig() { }

		internal virtual Button[] get_Buttons() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal virtual IEnumerable<Axis> IterateAxes() { }

		internal virtual IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal sealed class Platform_XInput : Platform_XInput_Base
	{
		public Platform_XInput_Base[] variants; //Field offset: 0x28

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 5
		}

		public Platform_XInput() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CustomClassObfuscation]
	internal class Platform_XInput_Base : Platform
	{
		[CustomClassObfuscation]
		internal sealed class Axis : Element
		{
			public bool invert; //Field offset: 0x28
			public Pole buttonAxisContribution; //Field offset: 0x2C
			public AxisRange sourceAxisRange; //Field offset: 0x30
			public bool calibrateAxis; //Field offset: 0x34
			public float axisZero; //Field offset: 0x38
			public float axisMin; //Field offset: 0x3C
			public float axisMax; //Field offset: 0x40
			public AxisCalibrationInfoEntry[] alternateCalibrations; //Field offset: 0x48
			public HardwareAxisInfo axisInfo; //Field offset: 0x50

			public Axis() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Button : Element
		{
			public Pole sourceAxisPole; //Field offset: 0x28
			public HardwareButtonInfo buttonInfo; //Field offset: 0x30

			public Button() { }

			internal virtual void CopyVars(Element destination) { }

			public virtual object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal abstract class Element : IDeepCloneable
		{
			public int elementIdentifier; //Field offset: 0x10
			public HardwareElementSourceType sourceType; //Field offset: 0x14
			public XInputButton sourceButton; //Field offset: 0x18
			public XInputAxis sourceAxis; //Field offset: 0x1C
			public float axisDeadZone; //Field offset: 0x20

			protected Element() { }

			internal override void CopyVars(Element destination) { }

			public abstract object DeepClone() { }

		}

		[CustomClassObfuscation]
		internal sealed class Elements : Elements_Base
		{
			public Axis[] axes; //Field offset: 0x10
			public Button[] buttons; //Field offset: 0x18

			public virtual int axisCount
			{
				 get { } //Length: 14
			}

			public virtual int buttonCount
			{
				 get { } //Length: 14
			}

			public Elements() { }

			internal virtual void CopyVars(Elements_Base destination) { }

			public virtual object DeepClone() { }

			public virtual int get_axisCount() { }

			public virtual int get_buttonCount() { }

			internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

			internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		}

		[CustomClassObfuscation]
		internal sealed class MatchingCriteria : MatchingCriteria_Base
		{
			public XInputDeviceSubType[] subType; //Field offset: 0x28

			internal virtual int alternateElementCount
			{
				internal get { } //Length: 3
			}

			internal virtual bool hasData
			{
				internal get { } //Length: 45
			}

			internal virtual bool isAllowed
			{
				internal get { } //Length: 21
			}

			public MatchingCriteria() { }

			internal virtual void CopyVars(MatchingCriteria_Base destination) { }

			public virtual object DeepClone() { }

			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

			internal virtual int get_alternateElementCount() { }

			internal virtual bool get_hasData() { }

			internal virtual bool get_isAllowed() { }

			internal virtual ElementCount_Base GetAlternateElementCount(int index) { }

			internal virtual bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

		}

		[CompilerGenerated]
		private sealed class vBcAKZSSWWBBCuFOBTlwiinKBQOAA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Button QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_XInput_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Button>.Current
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
			public vBcAKZSSWWBBCuFOBTlwiinKBQOAA(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Button>.GetEnumerator() { }

			[DebuggerHidden]
			private override Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Button>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class zlfYoxhvQlsKunaoalLfAoMhWqMy : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
		{
			private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
			private Axis QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
			private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
			public Platform_XInput_Base SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
			private int mcThSsRaZLDBUhEMRxETPDbFjJqU; //Field offset: 0x30

			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Axis>.Current
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
			public zlfYoxhvQlsKunaoalLfAoMhWqMy(int unnamed_param_0) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Axis>.GetEnumerator() { }

			[DebuggerHidden]
			private override Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Axis>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public MatchingCriteria matchingCriteria; //Field offset: 0x18
		public Elements elements; //Field offset: 0x20

		public virtual int assignedAxisCount
		{
			 get { } //Length: 29
		}

		public virtual int assignedButtonCount
		{
			 get { } //Length: 29
		}

		internal Axis[] Axes_orig
		{
			internal get { } //Length: 15
		}

		internal Button[] Buttons_orig
		{
			internal get { } //Length: 15
		}

		internal virtual bool disabled
		{
			internal get { } //Length: 15
		}

		internal virtual Elements_Base elements_base
		{
			internal get { } //Length: 5
		}

		internal virtual bool hasData
		{
			internal get { } //Length: 100
		}

		internal virtual bool isAllowed
		{
			internal get { } //Length: 59
		}

		internal virtual InputPlatform platform
		{
			internal get { } //Length: 6
		}

		internal virtual IList<Platform> variants_base
		{
			internal get { } //Length: 3
		}

		public Platform_XInput_Base() { }

		internal virtual void CopyVars(Platform destination) { }

		public virtual object DeepClone() { }

		public virtual int get_assignedAxisCount() { }

		public virtual int get_assignedButtonCount() { }

		internal Axis[] get_Axes_orig() { }

		internal Button[] get_Buttons_orig() { }

		internal virtual bool get_disabled() { }

		internal virtual Elements_Base get_elements_base() { }

		internal virtual bool get_hasData() { }

		internal virtual bool get_isAllowed() { }

		internal virtual InputPlatform get_platform() { }

		internal virtual IList<Platform> get_variants_base() { }

		internal virtual AxisCalibrationData[] GetAxisCalibrationData() { }

		internal virtual void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

		internal virtual String[] GetAxisNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

		internal virtual bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

		internal virtual String[] GetEffectiveButtonNames(ControllerElementIdentifier[] identifiers) { }

		internal virtual ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

		internal virtual void GetGameElementIdentifierIdMappings(out Int32[] buttons, out Int32[] axes) { }

		internal virtual bool IsElementIdentifierMapped(int elementIdentifierId) { }

		internal IEnumerable<Axis> IterateAxes() { }

		internal IEnumerable<Button> IterateButtons() { }

		internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	}

	[CompilerGenerated]
	private sealed class UbQaYjgAzdVnTDVFnHNKgYJFPQOjc : IDisposable, IEnumerable, IEnumerator, IEnumerable<IControllerElementIdentifierCommon_Internal>, IEnumerator<IControllerElementIdentifierCommon_Internal>
	{
		private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
		private IControllerElementIdentifierCommon_Internal QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
		private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
		public HardwareJoystickMap SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
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
		public UbQaYjgAzdVnTDVFnHNKgYJFPQOjc(int unnamed_param_0) { }

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

	[CustomClassObfuscation]
	internal class VidPid
	{
		public int vendorId; //Field offset: 0x10
		public int productId; //Field offset: 0x14

		public VidPid() { }

	}

	[CompilerGenerated]
	private sealed class YzaOGMMLoEUFvNdFBANQKfsxFLKx : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerElementIdentifier>, IEnumerator<ControllerElementIdentifier>
	{
		private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
		private ControllerElementIdentifier QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
		private int tZYJKecudHEQvAOVwSofQPfcIgFb; //Field offset: 0x20
		public HardwareJoystickMap SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
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
		public YzaOGMMLoEUFvNdFBANQKfsxFLKx(int unnamed_param_0) { }

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
	private string controllerName; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	private string editorControllerName; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	private string description; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	private string controllerGuid; //Field offset: 0x30
	[CustomObfuscation]
	[SerializeField]
	private String[] templateGuids; //Field offset: 0x38
	[CustomObfuscation]
	[SerializeField]
	private bool hideInLists; //Field offset: 0x40
	[CustomObfuscation]
	[SerializeField]
	private JoystickType[] joystickTypes; //Field offset: 0x48
	[CustomObfuscation]
	[SerializeField]
	private ControllerElementIdentifier[] elementIdentifiers; //Field offset: 0x50
	[CustomObfuscation]
	[SerializeField]
	private CompoundElement[] compoundElements; //Field offset: 0x58
	[CustomObfuscation]
	[SerializeField]
	private Platform_DirectInput directInput; //Field offset: 0x60
	[CustomObfuscation]
	[SerializeField]
	private Platform_RawInput rawInput; //Field offset: 0x68
	[CustomObfuscation]
	[SerializeField]
	private Platform_XInput xInput; //Field offset: 0x70
	[CustomObfuscation]
	[SerializeField]
	private Platform_OSX osx; //Field offset: 0x78
	[CustomObfuscation]
	[SerializeField]
	private Platform_Linux linux; //Field offset: 0x80
	[CustomObfuscation]
	[SerializeField]
	private Platform_WindowsUWP windowsUWP; //Field offset: 0x88
	[CustomObfuscation]
	[SerializeField]
	private Platform_Fallback fallback_Windows; //Field offset: 0x90
	[CustomObfuscation]
	[SerializeField]
	private Platform_Fallback fallback_WindowsUWP; //Field offset: 0x98
	[CustomObfuscation]
	[SerializeField]
	private Platform_Fallback fallback_OSX; //Field offset: 0xA0
	[CustomObfuscation]
	[SerializeField]
	private Platform_Fallback fallback_Linux; //Field offset: 0xA8
	[CustomObfuscation]
	[SerializeField]
	private Platform_Fallback fallback_Linux_PreConfigured; //Field offset: 0xB0
	[CustomObfuscation]
	[SerializeField]
	private Platform_Fallback fallback_Android; //Field offset: 0xB8
	[CustomObfuscation]
	[SerializeField]
	private Platform_Fallback fallback_iOS; //Field offset: 0xC0
	[CustomObfuscation]
	[SerializeField]
	private Platform_Fallback fallback_XBoxOne; //Field offset: 0xC8
	[CustomObfuscation]
	[SerializeField]
	private Platform_Fallback fallback_PS4; //Field offset: 0xD0
	[CustomObfuscation]
	[SerializeField]
	private Platform_PS5 ps5; //Field offset: 0xD8
	[CustomObfuscation]
	[SerializeField]
	private Platform_Fallback fallback_PSM; //Field offset: 0xE0
	[CustomObfuscation]
	[SerializeField]
	private Platform_Fallback fallback_PSVita; //Field offset: 0xE8
	[CustomObfuscation]
	[SerializeField]
	private Platform_Fallback fallback_AmazonFireTV; //Field offset: 0xF0
	[CustomObfuscation]
	[SerializeField]
	private Platform_WebGL webGL; //Field offset: 0xF8
	[CustomObfuscation]
	[SerializeField]
	private Platform_XboxOne xboxOne; //Field offset: 0x100
	[CustomObfuscation]
	[SerializeField]
	private Platform_GameCore gameCore; //Field offset: 0x108
	[CustomObfuscation]
	[SerializeField]
	private Platform_PS4 ps4; //Field offset: 0x110
	[CustomObfuscation]
	[SerializeField]
	private Platform_NintendoSwitch nintendoSwitch; //Field offset: 0x118
	[CustomObfuscation]
	[SerializeField]
	private Platform_Stadia stadia; //Field offset: 0x120
	[CustomObfuscation]
	[SerializeField]
	private Platform_InternalDriver internalDriver; //Field offset: 0x128
	[CustomObfuscation]
	[SerializeField]
	private Platform_SDL2 sdl2_Linux; //Field offset: 0x130
	[CustomObfuscation]
	[SerializeField]
	private Platform_SDL2 sdl2_Windows; //Field offset: 0x138
	[CustomObfuscation]
	[SerializeField]
	private Platform_SDL2 sdl2_OSX; //Field offset: 0x140
	[CustomObfuscation]
	[SerializeField]
	private Platform_AppleGCController appleGCController; //Field offset: 0x148
	[CustomObfuscation]
	[SerializeField]
	private int elementIdentifierIdCounter; //Field offset: 0x150

	public string ControllerName
	{
		 get { } //Length: 5
	}

	public string EditorControllerName
	{
		 get { } //Length: 5
	}

	public int elementIdentifierCount
	{
		 get { } //Length: 14
	}

	public IEnumerable<ControllerElementIdentifier> ElementIdentifiers
	{
		 get { } //Length: 109
	}

	public Guid Guid
	{
		 get { } //Length: 113
	}

	public bool HideInLists
	{
		 get { } //Length: 5
	}

	internal IEnumerable<JoystickType> JoystickTypes
	{
		internal get { } //Length: 109
	}

	private override IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.ElementIdentifiers
	{
		private get { } //Length: 109
	}

	public IEnumerable<Guid> TemplateGuids
	{
		 get { } //Length: 131
	}

	public HardwareJoystickMap() { }

	public HardwareJoystickMap(HardwareJoystickMap unnamed_param_0) { }

	internal HardwareJoystickMap Clone() { }

	[CustomObfuscation]
	public override bool ContainsElementIdentifier(int id) { }

	private Platform_Fallback_Base FindFallbackMap(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) { }

	private Platform_Fallback_Base FindFallbackMatch(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) { }

	private Platform_SDL2_Base FindSDL2Map(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) { }

	private Platform_SDL2_Base FindSDL2Match(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) { }

	public string get_ControllerName() { }

	public string get_EditorControllerName() { }

	public int get_elementIdentifierCount() { }

	public IEnumerable<ControllerElementIdentifier> get_ElementIdentifiers() { }

	public Guid get_Guid() { }

	public bool get_HideInLists() { }

	internal IEnumerable<JoystickType> get_JoystickTypes() { }

	public IEnumerable<Guid> get_TemplateGuids() { }

	internal HardwareJoystickMap_InputManager GetDefaultHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController) { }

	internal bool GetEffectiveAxisRange(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap, out AxisRange axisRange) { }

	internal ControllerElementType GetEffectiveElementIdentifierType(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap) { }

	[CustomObfuscation]
	public ControllerElementIdentifier GetElementIdentifier(int id) { }

	[CustomObfuscation]
	public override Int32[] GetElementIdentifierIds() { }

	[CustomObfuscation]
	public int GetElementIdentifierInfo(ControllerElementType type, out String[] names, out Int32[] ids) { }

	[CustomObfuscation]
	public override String[] GetElementIdentifierNames() { }

	internal void GetElementIdentifiersForControllerElements(HardwareControllerMapIdentifier hardwareMapIdentifier, bool isDefaultMap, out Int32[] buttons, out Int32[] axes) { }

	[CustomObfuscation]
	public override int GetMappableElementIdentifierInfo(out String[] names, out Int32[] ids) { }

	private Platform GetSpecificPlatformMap(HardwareControllerMapIdentifier hardwareMapIdentifier) { }

	private Platform GetSpecificPlatformRoot(InputPlatform exactInputPlatform) { }

	internal String[] GetTemplateGuidsOrig() { }

	private T GetUniversalDefaultMap(out InputPlatform actualInputPlatform, out int variantIndex) { }

	private T GetUniversalDefaultMapRoot(Type type, out InputPlatform actualInputPlatform) { }

	internal int IndexOfElementIdentifier(int id) { }

	internal bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex, out Platform platformMap) { }

	internal static bool Matches(Platform platform, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) { }

	private override IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_ElementIdentifiers() { }

	private override IControllerElementIdentifierCommon_Internal Rewired.Data.Mapping.IHardwareControllerMap_Internal.GetElementIdentifier(int id) { }

	private T TryGetFirstMatchingMap(T mainMap, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex) { }

	private T TryGetFirstValidMap(T mainMap, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex) { }

}

