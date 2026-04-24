namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRRenderModels
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetComponentStatePacked : MulticastDelegate
	{

		public _GetComponentStatePacked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchRenderModelName, string pchComponentName, ref VRControllerState_t_Packed pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref VRControllerState_t_Packed pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState, IAsyncResult result) { }

		public override bool Invoke(string pchRenderModelName, string pchComponentName, ref VRControllerState_t_Packed pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState) { }

	}

	private struct GetComponentStateUnion
	{
		public _GetComponentState pGetComponentState; //Field offset: 0x0
		public _GetComponentStatePacked pGetComponentStatePacked; //Field offset: 0x0

	}

	private IVRRenderModels FnTable; //Field offset: 0x10

	internal CVRRenderModels(IntPtr pInterface) { }

	public void FreeRenderModel(IntPtr pRenderModel) { }

	public void FreeTexture(IntPtr pTexture) { }

	public void FreeTextureD3D11(IntPtr pD3D11Texture2D) { }

	public ulong GetComponentButtonMask(string pchRenderModelName, string pchComponentName) { }

	public uint GetComponentCount(string pchRenderModelName) { }

	public uint GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen) { }

	public uint GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen) { }

	public bool GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState) { }

	public bool GetComponentStateForDevicePath(string pchRenderModelName, string pchComponentName, ulong devicePath, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState) { }

	public uint GetRenderModelCount() { }

	public string GetRenderModelErrorNameFromEnum(EVRRenderModelError error) { }

	public uint GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen) { }

	public uint GetRenderModelOriginalPath(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError) { }

	public uint GetRenderModelThumbnailURL(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError) { }

	public EVRRenderModelError LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture) { }

	public EVRRenderModelError LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel) { }

	public EVRRenderModelError LoadTexture_Async(int textureId, ref IntPtr ppTexture) { }

	public EVRRenderModelError LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D) { }

	public bool RenderModelHasComponent(string pchRenderModelName, string pchComponentName) { }

}

