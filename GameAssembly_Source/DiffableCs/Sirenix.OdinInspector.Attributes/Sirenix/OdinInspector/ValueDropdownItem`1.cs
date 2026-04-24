namespace Sirenix.OdinInspector;

public struct ValueDropdownItem : IValueDropdownItem
{
	public string Text; //Field offset: 0x0
	public T Value; //Field offset: 0x0

	public ValueDropdownItem`1(string text, T value) { }

	private override string Sirenix.OdinInspector.IValueDropdownItem.GetText() { }

	private override object Sirenix.OdinInspector.IValueDropdownItem.GetValue() { }

	public virtual string ToString() { }

}

