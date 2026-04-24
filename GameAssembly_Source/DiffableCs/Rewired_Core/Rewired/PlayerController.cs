namespace Rewired;

public class PlayerController : IPlayerController
{
	internal class Axis : ElementWithSource
	{
		internal class Definition : Definition
		{
			public AxisCoordinateMode coordinateMode; //Field offset: 0x28
			public float absoluteToRelativeSensitivity; //Field offset: 0x2C

			public Definition() { }

			internal virtual Element GmCJirHUdvAngrAUKhmUOSnWQDiv(PlayerController unnamed_param_0) { }

		}

		internal const float qqlonxFLPzzNZllCiGWUqHnHoHxg = 1; //Field offset: 0x0
		[CustomObfuscation]
		internal const AxisCoordinateMode defaultAxisCoordinateMode = 0; //Field offset: 0x0
		private float vGMWexagHkfpnWbLiudWmSSzGtkm; //Field offset: 0x30
		private AxisCoordinateMode PZNOTYcdWaSkiBoFexAIjMQyakEgA; //Field offset: 0x34

		public float absoluteToRelativeSensitivity
		{
			 get { } //Length: 6
			 set { } //Length: 15
		}

		public AxisCoordinateMode coordinateMode
		{
			 get { } //Length: 4
		}

		public override float value
		{
			 get { } //Length: 298
		}

		public override float valueRaw
		{
			 get { } //Length: 90
		}

		internal Axis(PlayerController unnamed_param_0, Definition unnamed_param_1) { }

		public float get_absoluteToRelativeSensitivity() { }

		public AxisCoordinateMode get_coordinateMode() { }

		public override float get_value() { }

		public override float get_valueRaw() { }

		public void set_absoluteToRelativeSensitivity(float value) { }

	}

	internal class Axis2D : CompoundElement
	{
		internal class Definition : Definition
		{
			private Definition jMNByzjvKKDVnKwVcXSPsDzIEcJi; //Field offset: 0x20
			private Definition pLMulMiLERgmYeYGrapBBKxlKZGJ; //Field offset: 0x28

			public Definition xAxis
			{
				 get { } //Length: 5
				 set { } //Length: 12
			}

			public Definition yAxis
			{
				 get { } //Length: 5
				 set { } //Length: 12
			}

			public Definition() { }

			public Definition get_xAxis() { }

			public Definition get_yAxis() { }

			internal virtual Element GmCJirHUdvAngrAUKhmUOSnWQDiv(PlayerController unnamed_param_0) { }

			public void set_xAxis(Definition value) { }

			public void set_yAxis(Definition value) { }

		}

		internal const int XXchGmAeMCYBulcBiHIuJLqeImJP = 0; //Field offset: 0x0
		internal const int XshjWnvmNtfkHbJHEGpOFZhCZMTY = 1; //Field offset: 0x0
		internal const int ZaAeFUfcuIKLXxvRVuvlurhlEHxW = 2; //Field offset: 0x0

		public override Vector2 value
		{
			 get { } //Length: 180
		}

		public override Vector2 valueRaw
		{
			 get { } //Length: 180
		}

		public Axis xAxis
		{
			 get { } //Length: 58
		}

		public Axis yAxis
		{
			 get { } //Length: 61
		}

		internal Axis2D(PlayerController unnamed_param_0, Definition unnamed_param_1, Definition[] unnamed_param_2) { }

		internal Axis2D(PlayerController unnamed_param_0, Definition unnamed_param_1) { }

		public override Vector2 get_value() { }

		public override Vector2 get_valueRaw() { }

		public Axis get_xAxis() { }

		public Axis get_yAxis() { }

	}

	internal sealed class Button : ElementWithSource
	{
		internal class Definition : Definition
		{

			public Definition() { }

			internal virtual Element GmCJirHUdvAngrAUKhmUOSnWQDiv(PlayerController unnamed_param_0) { }

		}


		public bool justPressed
		{
			 get { } //Length: 89
		}

		public bool justReleased
		{
			 get { } //Length: 89
		}

		public bool value
		{
			 get { } //Length: 89
		}

		public bool valuePrev
		{
			 get { } //Length: 89
		}

		internal Button(PlayerController unnamed_param_0, Definition unnamed_param_1) { }

		public bool get_justPressed() { }

		public bool get_justReleased() { }

		public bool get_value() { }

		public bool get_valuePrev() { }

	}

	internal abstract class CompoundElement : Element
	{
		internal abstract class Definition : Definition
		{

			public Definition() { }

		}

		private readonly List<Element> ijdvGPZepyLFQCCGhtHUxmOSTMiv; //Field offset: 0x28

		internal int CbOzuqJcNKRaqGLVNOGDRSibmzYN
		{
			internal get { } //Length: 59
		}

		internal CompoundElement(PlayerController unnamed_param_0, Definition unnamed_param_1, Definition[] unnamed_param_2) { }

		internal void KSuzaOOtmCNzwFvKBxSdiyfJdwOt(Element unnamed_param_0) { }

		internal int SYETquUCBHCetjlAorENDSSQKPnQA() { }

		internal  ugMrIfFGeTmEfWpTdnrRxpzwHbAu(int unnamed_param_0) { }

		internal void xKtLlOVkzdizsYjKWqYSAllgHjwm(List<Element> unnamed_param_0) { }

	}

	internal class Definition
	{
		public bool enabled; //Field offset: 0x10
		public int playerId; //Field offset: 0x14
		public ICollection<Definition> elements; //Field offset: 0x18

		public Definition() { }

	}

	internal abstract class Element
	{
		[CustomObfuscation]
		public enum CompoundTypes
		{
			Axis2D = 100,
			MouseAxis2D = 101,
			MouseWheel = 102,
		}

		internal abstract class Definition
		{
			public bool enabled; //Field offset: 0x10
			public string name; //Field offset: 0x18

			public Definition() { }

			internal abstract Element GmCJirHUdvAngrAUKhmUOSnWQDiv(PlayerController unnamed_param_0) { }

		}

		[CustomObfuscation]
		public enum Type
		{
			Button = 0,
			Axis = 1,
			MouseAxis = 2,
			MouseWheelAxis = 3,
			Axis2D = 100,
			MouseAxis2D = 101,
			MouseWheel = 102,
		}

		[CustomObfuscation]
		public enum TypeWithSource
		{
			Button = 0,
			Axis = 1,
			MouseAxis = 2,
			MouseWheelAxis = 3,
		}

		public struct wSdQjSYIwokMSvbVeSUESPkOZBIk
		{
			public ControllerElementType TIvrHqoiWzSMnQmlhLoWYtklcSSt; //Field offset: 0x0
			public int GjPpSBHArrBPppWJJfrRkGPhkxEGA; //Field offset: 0x4
			public float zRUQZDXXBkLNTaHWFlnOtpiXDsdt; //Field offset: 0x8

			public wSdQjSYIwokMSvbVeSUESPkOZBIk(ControllerElementType unnamed_param_0, int unnamed_param_1, float unnamed_param_2) { }

		}

		[CustomObfuscation]
		internal const bool defaultEnabled = True; //Field offset: 0x0
		private static Int32[] prqNzzCUMkNGLrWTzxKSJuhLVBWA; //Field offset: 0x0
		private static Int32[] nDpgUkjmFXkxKlUauxMcbxXQCkab; //Field offset: 0x8
		private readonly PlayerController dNEcffbNlUlzVziFYJPZpdDkPLfwA; //Field offset: 0x10
		private bool CKBAxUgCckkjFNNkmRGQhprFhmHo; //Field offset: 0x18
		private bool dDPTnfkiUGCQQHgOhJldFBaHbwjJc; //Field offset: 0x19
		private string izBjhSznEaRawMUCFuEAZRGeBHDi; //Field offset: 0x20

		protected Player EintHaHwEPjTUIgAwfTaImrfmLMUA
		{
			 get { } //Length: 226
		}

		public bool enabled
		{
			 get { } //Length: 5
			 set { } //Length: 26
		}

		internal bool MFGCFhIZelKcjmAhMlFMktOoRSwRA
		{
			internal get { } //Length: 5
			internal set { } //Length: 5
		}

		public string name
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		protected bool zWzGDkMOPCjmwBMQaWYqfDzJwLBRA
		{
			 get { } //Length: 40
		}

		internal Element(PlayerController unnamed_param_0, Definition unnamed_param_1) { }

		[CustomObfuscation]
		internal static Definition CreateDefinition(Type type) { }

		protected override void EnabledStateChanged(bool state) { }

		public bool get_enabled() { }

		public string get_name() { }

		protected Player get_player() { }

		protected bool get_selfAndParentEnabled() { }

		[CustomObfuscation]
		internal static string GetElementTitle(Type type, int index) { }

		[CustomObfuscation]
		internal static int GetMaxElementCount(Type type) { }

		internal override void gxgPRcKwociRNokZjvlZCFLqmmSU() { }

		[CustomObfuscation]
		internal static bool IsCompoundType(Type type) { }

		[CustomObfuscation]
		internal static bool IsTypeWithSource(Type type) { }

		internal bool JwqFqnaYPJIDpuHLbNZVJPbmWkTD() { }

		public void set_enabled(bool value) { }

		public void set_name(string value) { }

		internal void TIwaYMwSlDuNrmbJTHgfAmUPIDEN(bool unnamed_param_0) { }

	}

	internal abstract class ElementWithSource : Element
	{
		internal abstract class Definition : Definition
		{
			private int IpQWoUeAxsbuYJNVxGyhmmhvlnYC; //Field offset: 0x20

			public int actionId
			{
				 get { } //Length: 4
				 set { } //Length: 4
			}

			public string actionName
			{
				 get { } //Length: 233
				 set { } //Length: 275
			}

			public Definition() { }

			public int get_actionId() { }

			public string get_actionName() { }

			public void set_actionId(int value) { }

			public void set_actionName(string value) { }

		}

		[CustomObfuscation]
		internal const int defaultActionId = -1; //Field offset: 0x0
		private int IpQWoUeAxsbuYJNVxGyhmmhvlnYC; //Field offset: 0x28

		public int actionId
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public string actionName
		{
			 get { } //Length: 233
			 set { } //Length: 251
		}

		internal ElementWithSource(PlayerController unnamed_param_0, Definition unnamed_param_1) { }

		public int get_actionId() { }

		public string get_actionName() { }

		public void set_actionId(int value) { }

		public void set_actionName(string value) { }

	}

	internal static class Factory
	{

		public static PlayerController Create(Definition definition) { }

	}

	internal class MouseAxis : Axis
	{
		internal class Definition : Definition
		{

			public Definition() { }

			internal virtual Element GmCJirHUdvAngrAUKhmUOSnWQDiv(PlayerController unnamed_param_0) { }

		}

		[CustomObfuscation]
		internal const AxisCoordinateMode defaultAxisCoordinateMode = 1; //Field offset: 0x0
		[CustomObfuscation]
		internal const float defaultAbsoluteToRelativeSensitivity = 600; //Field offset: 0x0

		public virtual float value
		{
			 get { } //Length: 418
		}

		internal MouseAxis(PlayerController unnamed_param_0, Definition unnamed_param_1) { }

		public virtual float get_value() { }

	}

	internal sealed class MouseAxis2D : Axis2D
	{
		internal class Definition : Definition
		{

			public Definition xAxis
			{
				 get { } //Length: 125
				 set { } //Length: 12
			}

			public Definition yAxis
			{
				 get { } //Length: 125
				 set { } //Length: 12
			}

			public Definition() { }

			public Definition get_xAxis() { }

			public Definition get_yAxis() { }

			internal virtual Element GmCJirHUdvAngrAUKhmUOSnWQDiv(PlayerController unnamed_param_0) { }

			public void set_xAxis(Definition value) { }

			public void set_yAxis(Definition value) { }

		}


		public MouseAxis xAxis
		{
			 get { } //Length: 58
		}

		public MouseAxis yAxis
		{
			 get { } //Length: 61
		}

		internal MouseAxis2D(PlayerController unnamed_param_0, Definition unnamed_param_1) { }

		public MouseAxis get_xAxis() { }

		public MouseAxis get_yAxis() { }

	}

	internal sealed class MouseWheel : Axis2D
	{
		internal class Definition : Definition
		{

			public Definition xAxis
			{
				 get { } //Length: 125
				 set { } //Length: 12
			}

			public Definition yAxis
			{
				 get { } //Length: 125
				 set { } //Length: 12
			}

			public Definition() { }

			public Definition get_xAxis() { }

			public Definition get_yAxis() { }

			internal virtual Element GmCJirHUdvAngrAUKhmUOSnWQDiv(PlayerController unnamed_param_0) { }

			public void set_xAxis(Definition value) { }

			public void set_yAxis(Definition value) { }

		}


		public MouseWheelAxis xAxis
		{
			 get { } //Length: 58
		}

		public MouseWheelAxis yAxis
		{
			 get { } //Length: 61
		}

		internal MouseWheel(PlayerController unnamed_param_0, Definition unnamed_param_1) { }

		public MouseWheelAxis get_xAxis() { }

		public MouseWheelAxis get_yAxis() { }

	}

	internal sealed class MouseWheelAxis : Axis
	{
		internal class Definition : Definition
		{
			public float repeatRate; //Field offset: 0x30

			public Definition() { }

			internal virtual Element GmCJirHUdvAngrAUKhmUOSnWQDiv(PlayerController unnamed_param_0) { }

		}

		[CustomObfuscation]
		internal const float defaultRepeatRate = 4; //Field offset: 0x0
		[CustomObfuscation]
		internal const AxisCoordinateMode defaultAxisCoordinateMode = 1; //Field offset: 0x0
		private const float fJhcqCxsESIkDEtnNBAhLREskBAib = 0.01; //Field offset: 0x0
		private float XksfHkeuEJJXEfiPDrgaosPmDuoC; //Field offset: 0x38
		private double zcVDNfwrWdKgKnIeAsuuYqjytLxm; //Field offset: 0x40
		private float lrEGaNDUNYurjPaNJJqytrOckxvj; //Field offset: 0x48

		public float repeatRate
		{
			 get { } //Length: 28
			 set { } //Length: 35
		}

		public virtual float value
		{
			 get { } //Length: 48
		}

		internal MouseWheelAxis(PlayerController unnamed_param_0, Definition unnamed_param_1) { }

		protected virtual void EnabledStateChanged(bool state) { }

		public float get_repeatRate() { }

		public virtual float get_value() { }

		internal virtual void gxgPRcKwociRNokZjvlZCFLqmmSU() { }

		public void set_repeatRate(float value) { }

		private void TIWlPgfaGufdFBhysiChIRXnJxnP() { }

		private float zHDuplywXJbrOUmJTBiIHcSKAgfb() { }

	}

	internal readonly int VetpcoloufDUIHFBDUgRuDriUEsF; //Field offset: 0x10
	private bool dDPTnfkiUGCQQHgOhJldFBaHbwjJc; //Field offset: 0x14
	private int YyQEjQKhQzMcbEBPJGxHPqKwOqKQB; //Field offset: 0x18
	private readonly AList<Element> ijdvGPZepyLFQCCGhtHUxmOSTMiv; //Field offset: 0x20
	private readonly AList<Button> PpoIcwcfCemRCmKZmtstWxZCnkFM; //Field offset: 0x28
	private readonly AList<Axis> zEpEITeaPBUpoVlrlWXwKvrwrmIC; //Field offset: 0x30
	private readonly ReadOnlyCollection<Element> KuDVQyyjLHjeWgWainxcpWEMpDXA; //Field offset: 0x38
	private readonly ReadOnlyCollection<Button> iEoieboUCWUNVNIsfwSmUskrCjfp; //Field offset: 0x40
	private readonly ReadOnlyCollection<Axis> hFCjqlcoEzaovnUKoVwkHuinNvPV; //Field offset: 0x48
	private readonly List<wSdQjSYIwokMSvbVeSUESPkOZBIk> WpsqQcxfdoPqDqPvuGDXCYEWTmemA; //Field offset: 0x50
	private Action<Int32, Boolean> oskPRpEcFjeDsiyOAitKBgwKaGTq; //Field offset: 0x58
	private Action<Int32, Single> NRxDQEfgedSPfoczVacNBreVEAocb; //Field offset: 0x60
	private Action<Boolean> nusjfdsMovJeDueTjKdmtAfBBcCDA; //Field offset: 0x68

	public override event Action<Int32, Single> AxisValueChangedEvent
	{
		 add { } //Length: 230
		 remove { } //Length: 118
	}

	public override event Action<Int32, Boolean> ButtonStateChangedEvent
	{
		 add { } //Length: 230
		 remove { } //Length: 118
	}

	public override event Action<Boolean> EnabledStateChangedEvent
	{
		 add { } //Length: 230
		 remove { } //Length: 118
	}

	public override IList<Axis> axes
	{
		 get { } //Length: 155
	}

	public override int axisCount
	{
		 get { } //Length: 163
	}

	public override int buttonCount
	{
		 get { } //Length: 163
	}

	public override IList<Button> buttons
	{
		 get { } //Length: 155
	}

	internal Player EintHaHwEPjTUIgAwfTaImrfmLMUA
	{
		internal get { } //Length: 365
	}

	public override int elementCount
	{
		 get { } //Length: 163
	}

	public override IList<Element> elements
	{
		 get { } //Length: 155
	}

	public override bool enabled
	{
		 get { } //Length: 155
		 set { } //Length: 462
	}

	public override int playerId
	{
		 get { } //Length: 157
		 set { } //Length: 193
	}

	internal PlayerController(Definition unnamed_param_0) { }

	public override void add_AxisValueChangedEvent(Action<Int32, Single> value) { }

	public override void add_ButtonStateChangedEvent(Action<Int32, Boolean> value) { }

	public override void add_EnabledStateChangedEvent(Action<Boolean> value) { }

	protected override void ClearVars() { }

	protected virtual void Finalize() { }

	public override IList<Axis> get_axes() { }

	public override int get_axisCount() { }

	public override int get_buttonCount() { }

	public override IList<Button> get_buttons() { }

	public override int get_elementCount() { }

	public override IList<Element> get_elements() { }

	public override bool get_enabled() { }

	public override int get_playerId() { }

	public override float GetAxis(int index) { }

	public override float GetAxisRaw(int index) { }

	public override bool GetButton(int index) { }

	public override bool GetButtonDown(int index) { }

	public override bool GetButtonUp(int index) { }

	public override Element GetElement(int index) { }

	public override T GetElement(int index) { }

	internal void KSuzaOOtmCNzwFvKBxSdiyfJdwOt(Element unnamed_param_0) { }

	private void KSuzaOOtmCNzwFvKBxSdiyfJdwOt(Element unnamed_param_0, List<Element> unnamed_param_1, List<Element> unnamed_param_2, List<Button> unnamed_param_3, List<Axis> unnamed_param_4) { }

	internal Player OsHJsVylPBTgOFnRrUENcHqEgIoU() { }

	public override void remove_AxisValueChangedEvent(Action<Int32, Single> value) { }

	public override void remove_ButtonStateChangedEvent(Action<Int32, Boolean> value) { }

	public override void remove_EnabledStateChangedEvent(Action<Boolean> value) { }

	public override void set_enabled(bool value) { }

	public override void set_playerId(int value) { }

	protected override bool Update(UpdateLoopType updateLoop) { }

	protected override void UpdateFinished() { }

	internal static int UUQaBxawCLpAqQXlbQstnSZureukA(IList<> unnamed_param_0, Predicate<> unnamed_param_1, int unnamed_param_2) { }

	private void WuAJrOPQGZmohVlmObzfeXGkBzEP(UpdateLoopType unnamed_param_0) { }

}

