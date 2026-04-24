namespace Sirenix.OdinInspector;

public struct ValueDropdownItem : IValueDropdownItem
{
	public string Text; //Field offset: 0x0
	public object Value; //Field offset: 0x8

	public ValueDropdownItem(string text, object value) { }

	private override string Sirenix.OdinInspector.IValueDropdownItem.GetText() { }

	private override object Sirenix.OdinInspector.IValueDropdownItem.GetValue() { }

	public virtual string ToString() { }

}

