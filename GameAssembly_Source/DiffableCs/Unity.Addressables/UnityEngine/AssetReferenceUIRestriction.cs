namespace UnityEngine;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class AssetReferenceUIRestriction : Attribute
{

	public AssetReferenceUIRestriction() { }

	public override bool ValidateAsset(string path) { }

	public override bool ValidateAsset(object obj) { }

}

