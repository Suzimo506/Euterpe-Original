namespace PaperPlaneTools;

public class AlertIOSOptions
{
	public static Type DefaultPositiveButton; //Field offset: 0x0
	public static Type DefaultNegativeButton; //Field offset: 0x4
	public static Type DefaultNeutralButton; //Field offset: 0x8
	public static ButtonType DefaultPreferableButton; //Field offset: 0xC
	public static ButtonType[] DefaultButtonsAddOrder; //Field offset: 0x10
	[CompilerGenerated]
	private Type <PositiveButton>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Type <NegativeButton>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Type <NeutralButton>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ButtonType <PreferableButton>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private ButtonType[] <ButtonsAddOrder>k__BackingField; //Field offset: 0x20

	public ButtonType[] ButtonsAddOrder
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Type NegativeButton
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Type NeutralButton
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Type PositiveButton
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ButtonType PreferableButton
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static AlertIOSOptions() { }

	public AlertIOSOptions() { }

	[CompilerGenerated]
	public ButtonType[] get_ButtonsAddOrder() { }

	[CompilerGenerated]
	public Type get_NegativeButton() { }

	[CompilerGenerated]
	public Type get_NeutralButton() { }

	[CompilerGenerated]
	public Type get_PositiveButton() { }

	[CompilerGenerated]
	public ButtonType get_PreferableButton() { }

	[CompilerGenerated]
	public void set_ButtonsAddOrder(ButtonType[] value) { }

	[CompilerGenerated]
	public void set_NegativeButton(Type value) { }

	[CompilerGenerated]
	public void set_NeutralButton(Type value) { }

	[CompilerGenerated]
	public void set_PositiveButton(Type value) { }

	[CompilerGenerated]
	public void set_PreferableButton(ButtonType value) { }

}

