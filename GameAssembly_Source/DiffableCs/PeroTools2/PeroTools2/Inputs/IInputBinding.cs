namespace PeroTools2.Inputs;

public interface IInputBinding : IBinding
{

	public Dictionary<String, Action`1<CallbackContext>> inputs
	{
		 get { } //Length: 0
	}

	public Dictionary<String, Action`1<CallbackContext>> get_inputs() { }

}

