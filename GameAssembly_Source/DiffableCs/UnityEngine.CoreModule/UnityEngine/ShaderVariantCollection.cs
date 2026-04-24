namespace UnityEngine;

public sealed class ShaderVariantCollection : object
{
	internal struct ShaderVariant
	{
		public Shader shader; //Field offset: 0x0
		public PassType passType; //Field offset: 0x8
		public String[] keywords; //Field offset: 0x10

	}


	public bool isWarmedUp
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public int shaderCount
	{
		 get { } //Length: 51
	}

	public int variantCount
	{
		 get { } //Length: 51
	}

	public ShaderVariantCollection() { }

	public bool Add(ShaderVariant variant) { }

	private bool AddVariant(Shader shader, PassType passType, String[] keywords) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void Clear() { }

	public bool Contains(ShaderVariant variant) { }

	private bool ContainsVariant(Shader shader, PassType passType, String[] keywords) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_isWarmedUp() { }

	public int get_shaderCount() { }

	public int get_variantCount() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void Internal_Create(ShaderVariantCollection svc) { }

	public bool Remove(ShaderVariant variant) { }

	private bool RemoveVariant(Shader shader, PassType passType, String[] keywords) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void WarmUp() { }

}

