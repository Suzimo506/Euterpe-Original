namespace UnityEngine.Rendering;

public class DebugUI
{
	internal class BitField : Field<Enum>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<String, GUIContent> <>9__10_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal GUIContent <set_enumType>b__10_0(string x) { }

		}

		[CompilerGenerated]
		private GUIContent[] <enumNames>k__BackingField; //Field offset: 0x50
		[CompilerGenerated]
		private Int32[] <enumValues>k__BackingField; //Field offset: 0x58
		internal Type m_EnumType; //Field offset: 0x60

		public private GUIContent[] enumNames
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public Type enumType
		{
			 get { } //Length: 5
			 set { } //Length: 574
		}

		public private Int32[] enumValues
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public BitField() { }

		[CompilerGenerated]
		public GUIContent[] get_enumNames() { }

		public Type get_enumType() { }

		[CompilerGenerated]
		public Int32[] get_enumValues() { }

		[CompilerGenerated]
		private void set_enumNames(GUIContent[] value) { }

		public void set_enumType(Type value) { }

		[CompilerGenerated]
		private void set_enumValues(Int32[] value) { }

	}

	internal class BoolField : Field<Boolean>
	{

		public BoolField() { }

	}

	internal class Button : Widget
	{
		[CompilerGenerated]
		private Action <action>k__BackingField; //Field offset: 0x38

		public Action action
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public Button() { }

		[CompilerGenerated]
		public Action get_action() { }

		[CompilerGenerated]
		public void set_action(Action value) { }

	}

	internal class ColorField : Field<Color>
	{
		public bool hdr; //Field offset: 0x50
		public bool showAlpha; //Field offset: 0x51
		public bool showPicker; //Field offset: 0x52
		public float incStep; //Field offset: 0x54
		public float incStepMult; //Field offset: 0x58
		public int decimals; //Field offset: 0x5C

		public ColorField() { }

		public virtual Color ValidateValue(Color value) { }

	}

	internal class Container : Widget, IContainer
	{
		[CompilerGenerated]
		private ObservableList<Widget> <children>k__BackingField; //Field offset: 0x38

		public private override ObservableList<Widget> children
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public internal virtual Panel panel
		{
			 get { } //Length: 5
			internal set { } //Length: 380
		}

		public Container() { }

		public Container(string displayName, ObservableList<Widget> children) { }

		internal virtual void GenerateQueryPath() { }

		[CompilerGenerated]
		public override ObservableList<Widget> get_children() { }

		public virtual Panel get_panel() { }

		public virtual int GetHashCode() { }

		protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[CompilerGenerated]
		private void set_children(ObservableList<Widget> value) { }

		internal virtual void set_panel(Panel value) { }

	}

	internal class EnumField : Field<Int32>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<String, GUIContent> <>9__16_0; //Field offset: 0x8
			public static Func<GUIContent, String> <>9__17_0; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal string <InitQuickSeparators>b__17_0(GUIContent x) { }

			internal GUIContent <set_autoEnum>b__16_0(string x) { }

		}

		public GUIContent[] enumNames; //Field offset: 0x50
		public Int32[] enumValues; //Field offset: 0x58
		internal Int32[] quickSeparators; //Field offset: 0x60
		internal Int32[] indexes; //Field offset: 0x68
		[CompilerGenerated]
		private Func<Int32> <getIndex>k__BackingField; //Field offset: 0x70
		[CompilerGenerated]
		private Action<Int32> <setIndex>k__BackingField; //Field offset: 0x78

		public Type autoEnum
		{
			 set { } //Length: 749
		}

		public int currentIndex
		{
			 get { } //Length: 67
			 set { } //Length: 80
		}

		public Func<Int32> getIndex
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public Action<Int32> setIndex
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public EnumField() { }

		public int get_currentIndex() { }

		[CompilerGenerated]
		public Func<Int32> get_getIndex() { }

		[CompilerGenerated]
		public Action<Int32> get_setIndex() { }

		internal void InitIndexes() { }

		internal void InitQuickSeparators() { }

		public void set_autoEnum(Type value) { }

		public void set_currentIndex(int value) { }

		[CompilerGenerated]
		public void set_getIndex(Func<Int32> value) { }

		[CompilerGenerated]
		public void set_setIndex(Action<Int32> value) { }

	}

	internal abstract class Field : Widget, IValueField
	{
		[CompilerGenerated]
		private Func<T> <getter>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Action<T> <setter>k__BackingField; //Field offset: 0x0
		public Action<Field`1<T>, T> onValueChanged; //Field offset: 0x0

		public Func<T> getter
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public Action<T> setter
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		protected Field`1() { }

		[CompilerGenerated]
		public Func<T> get_getter() { }

		[CompilerGenerated]
		public Action<T> get_setter() { }

		public T GetValue() { }

		[CompilerGenerated]
		public void set_getter(Func<T> value) { }

		[CompilerGenerated]
		public void set_setter(Action<T> value) { }

		public override void SetValue(object value) { }

		public void SetValue(T value) { }

		private override object UnityEngine.Rendering.DebugUI.IValueField.GetValue() { }

		private override object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value) { }

		public override T ValidateValue(T value) { }

	}

	[Flags]
	internal enum Flags
	{
		None = 0,
		EditorOnly = 2,
		RuntimeOnly = 4,
		EditorForceUpdate = 8,
	}

	internal class FloatField : Field<Single>
	{
		public Func<Single> min; //Field offset: 0x50
		public Func<Single> max; //Field offset: 0x58
		public float incStep; //Field offset: 0x60
		public float incStepMult; //Field offset: 0x64
		public int decimals; //Field offset: 0x68

		public FloatField() { }

		public virtual float ValidateValue(float value) { }

	}

	internal class Foldout : Container, IValueField
	{
		public bool opened; //Field offset: 0x40
		[CompilerGenerated]
		private String[] <columnLabels>k__BackingField; //Field offset: 0x48

		public String[] columnLabels
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public bool isReadOnly
		{
			 get { } //Length: 3
		}

		public Foldout() { }

		public Foldout(string displayName, ObservableList<Widget> children, String[] columnLabels = null) { }

		[CompilerGenerated]
		public String[] get_columnLabels() { }

		public bool get_isReadOnly() { }

		public bool GetValue() { }

		[CompilerGenerated]
		public void set_columnLabels(String[] value) { }

		public override void SetValue(object value) { }

		public void SetValue(bool value) { }

		private override object UnityEngine.Rendering.DebugUI.IValueField.GetValue() { }

		public override object ValidateValue(object value) { }

	}

	internal class HBox : Container
	{

		public HBox() { }

	}

	internal class HistoryBoolField : BoolField
	{
		[CompilerGenerated]
		private Func<Boolean>[] <historyGetter>k__BackingField; //Field offset: 0x50

		public int historyDepth
		{
			 get { } //Length: 14
		}

		public Func<Boolean>[] historyGetter
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public HistoryBoolField() { }

		public int get_historyDepth() { }

		[CompilerGenerated]
		public Func<Boolean>[] get_historyGetter() { }

		public bool GetHistoryValue(int historyIndex) { }

		[CompilerGenerated]
		public void set_historyGetter(Func<Boolean>[] value) { }

	}

	internal class HistoryEnumField : EnumField
	{
		[CompilerGenerated]
		private Func<Int32>[] <historyIndexGetter>k__BackingField; //Field offset: 0x80

		public int historyDepth
		{
			 get { } //Length: 17
		}

		public Func<Int32>[] historyIndexGetter
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public HistoryEnumField() { }

		public int get_historyDepth() { }

		[CompilerGenerated]
		public Func<Int32>[] get_historyIndexGetter() { }

		public int GetHistoryValue(int historyIndex) { }

		[CompilerGenerated]
		public void set_historyIndexGetter(Func<Int32>[] value) { }

	}

	internal interface IContainer
	{

		public ObservableList<Widget> children
		{
			 get { } //Length: 0
		}

		public string displayName
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		public string queryPath
		{
			 get { } //Length: 0
		}

		public ObservableList<Widget> get_children() { }

		public string get_displayName() { }

		public string get_queryPath() { }

		public void set_displayName(string value) { }

	}

	internal class IntField : Field<Int32>
	{
		public Func<Int32> min; //Field offset: 0x50
		public Func<Int32> max; //Field offset: 0x58
		public int incStep; //Field offset: 0x60
		public int intStepMult; //Field offset: 0x64

		public IntField() { }

		public virtual int ValidateValue(int value) { }

	}

	internal interface IValueField
	{

		public object GetValue() { }

		public void SetValue(object value) { }

		public object ValidateValue(object value) { }

	}

	internal class Panel : IContainer, IComparable<Panel>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action<Panel> <>9__29_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal void <.ctor>b__29_0(Panel <p0>) { }

		}

		[CompilerGenerated]
		private Flags <flags>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <displayName>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private int <groupIndex>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private ObservableList<Widget> <children>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private Action<Panel> onSetDirty; //Field offset: 0x30

		public event Action<Panel> onSetDirty
		{
			[CompilerGenerated]
			 add { } //Length: 158
			[CompilerGenerated]
			 remove { } //Length: 158
		}

		public private override ObservableList<Widget> children
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public override string displayName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public bool editorForceUpdate
		{
			 get { } //Length: 8
		}

		public Flags flags
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public int groupIndex
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public bool isEditorOnly
		{
			 get { } //Length: 8
		}

		public bool isInactiveInEditor
		{
			 get { } //Length: 34
		}

		public bool isRuntimeOnly
		{
			 get { } //Length: 8
		}

		public override string queryPath
		{
			 get { } //Length: 5
		}

		public Panel() { }

		[CompilerGenerated]
		public void add_onSetDirty(Action<Panel> value) { }

		[CompilerGenerated]
		public override ObservableList<Widget> get_children() { }

		[CompilerGenerated]
		public override string get_displayName() { }

		public bool get_editorForceUpdate() { }

		[CompilerGenerated]
		public Flags get_flags() { }

		[CompilerGenerated]
		public int get_groupIndex() { }

		public bool get_isEditorOnly() { }

		public bool get_isInactiveInEditor() { }

		public bool get_isRuntimeOnly() { }

		public override string get_queryPath() { }

		public virtual int GetHashCode() { }

		protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[CompilerGenerated]
		public void remove_onSetDirty(Action<Panel> value) { }

		[CompilerGenerated]
		private void set_children(ObservableList<Widget> value) { }

		[CompilerGenerated]
		public override void set_displayName(string value) { }

		[CompilerGenerated]
		public void set_flags(Flags value) { }

		[CompilerGenerated]
		public void set_groupIndex(int value) { }

		public void SetDirty() { }

		private override int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(Panel other) { }

	}

	internal class UIntField : Field<UInt32>
	{
		public Func<UInt32> min; //Field offset: 0x50
		public Func<UInt32> max; //Field offset: 0x58
		public uint incStep; //Field offset: 0x60
		public uint intStepMult; //Field offset: 0x64

		public UIntField() { }

		public virtual uint ValidateValue(uint value) { }

	}

	internal class Value : Widget
	{
		[CompilerGenerated]
		private Func<Object> <getter>k__BackingField; //Field offset: 0x38
		public float refreshRate; //Field offset: 0x40

		public Func<Object> getter
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public Value() { }

		[CompilerGenerated]
		public Func<Object> get_getter() { }

		public object GetValue() { }

		[CompilerGenerated]
		public void set_getter(Func<Object> value) { }

	}

	internal class VBox : Container
	{

		public VBox() { }

	}

	internal class Vector2Field : Field<Vector2>
	{
		public float incStep; //Field offset: 0x50
		public float incStepMult; //Field offset: 0x54
		public int decimals; //Field offset: 0x58

		public Vector2Field() { }

	}

	internal class Vector3Field : Field<Vector3>
	{
		public float incStep; //Field offset: 0x50
		public float incStepMult; //Field offset: 0x54
		public int decimals; //Field offset: 0x58

		public Vector3Field() { }

	}

	internal class Vector4Field : Field<Vector4>
	{
		public float incStep; //Field offset: 0x50
		public float incStepMult; //Field offset: 0x54
		public int decimals; //Field offset: 0x58

		public Vector4Field() { }

	}

	internal abstract class Widget
	{
		protected Panel m_Panel; //Field offset: 0x10
		protected IContainer m_Parent; //Field offset: 0x18
		[CompilerGenerated]
		private Flags <flags>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private string <displayName>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private string <queryPath>k__BackingField; //Field offset: 0x30

		public override string displayName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public Flags flags
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public bool isEditorOnly
		{
			 get { } //Length: 8
		}

		public bool isInactiveInEditor
		{
			 get { } //Length: 34
		}

		public bool isRuntimeOnly
		{
			 get { } //Length: 8
		}

		public internal override Panel panel
		{
			 get { } //Length: 5
			internal set { } //Length: 12
		}

		public internal override IContainer parent
		{
			 get { } //Length: 5
			internal set { } //Length: 12
		}

		public private override string queryPath
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		protected Widget() { }

		internal override void GenerateQueryPath() { }

		[CompilerGenerated]
		public override string get_displayName() { }

		[CompilerGenerated]
		public Flags get_flags() { }

		public bool get_isEditorOnly() { }

		public bool get_isInactiveInEditor() { }

		public bool get_isRuntimeOnly() { }

		public override Panel get_panel() { }

		public override IContainer get_parent() { }

		[CompilerGenerated]
		public override string get_queryPath() { }

		public virtual int GetHashCode() { }

		[CompilerGenerated]
		public override void set_displayName(string value) { }

		[CompilerGenerated]
		public void set_flags(Flags value) { }

		internal override void set_panel(Panel value) { }

		internal override void set_parent(IContainer value) { }

		[CompilerGenerated]
		private void set_queryPath(string value) { }

	}


	public DebugUI() { }

}

