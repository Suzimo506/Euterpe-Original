namespace Rewired.Utils.Classes.Data;

[CustomClassObfuscation]
[CustomObfuscation]
internal sealed class GetSetValue : IGetSetValue<T>, IGetValue<T>, ISetValue<T>
{
	private Func<T> MNzkWOZZjlJliNaPBjYqHKJdZMmu; //Field offset: 0x0
	private Action<T> flEGsYUKEHXAQEmRZdsfztxcEnDU; //Field offset: 0x0

	public Func<T> getValueDelegate
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Action<T> setValueDelegate
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public GetSetValue`1(Func<T> unnamed_param_0, Action<T> unnamed_param_1) { }

	public Func<T> get_getValueDelegate() { }

	public Action<T> get_setValueDelegate() { }

	public override T GetValue() { }

	public void set_getValueDelegate(Func<T> value) { }

	public void set_setValueDelegate(Action<T> value) { }

	public override void SetValue(T value) { }

}

