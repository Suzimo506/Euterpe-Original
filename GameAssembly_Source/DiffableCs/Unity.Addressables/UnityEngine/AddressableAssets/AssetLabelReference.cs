namespace UnityEngine.AddressableAssets;

public class AssetLabelReference : IKeyEvaluator
{
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private string m_LabelString; //Field offset: 0x10

	public string labelString
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public override object RuntimeKey
	{
		 get { } //Length: 85
	}

	public AssetLabelReference() { }

	public string get_labelString() { }

	public override object get_RuntimeKey() { }

	public virtual int GetHashCode() { }

	public override bool RuntimeKeyIsValid() { }

	public void set_labelString(string value) { }

}

