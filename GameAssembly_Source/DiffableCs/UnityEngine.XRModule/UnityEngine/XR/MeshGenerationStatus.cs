namespace UnityEngine.XR;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public enum MeshGenerationStatus
{
	Success = 0,
	InvalidMeshId = 1,
	GenerationAlreadyInProgress = 2,
	Canceled = 3,
	UnknownError = 4,
}

