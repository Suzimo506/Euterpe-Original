namespace UnityEngine.PostProcessing;

public abstract class PostProcessingModel
{
	[GetSet(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private bool m_Enabled; //Field offset: 0x10

	public bool enabled
	{
		 get { } //Length: 5
		 set { } //Length: 25
	}

	protected PostProcessingModel() { }

	public bool get_enabled() { }

	public override void OnValidate() { }

	public abstract void Reset() { }

	public void set_enabled(bool value) { }

}

