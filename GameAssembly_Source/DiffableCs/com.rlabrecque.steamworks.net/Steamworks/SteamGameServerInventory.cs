namespace Steamworks;

public static class SteamGameServerInventory
{

	public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef) { }

	public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength) { }

	public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected) { }

	public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity) { }

	public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, Byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false) { }

	public static void DestroyResult(SteamInventoryResult_t resultHandle) { }

	public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, UInt32[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, UInt32[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

	public static bool GetAllItems(out SteamInventoryResult_t pResultHandle) { }

	public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice) { }

	public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs) { }

	public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, UInt64[] pCurrentPrices, UInt64[] pBasePrices, uint unArrayLength) { }

	public static uint GetNumItemsWithPrices() { }

	public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	public static EResult GetResultStatus(SteamInventoryResult_t resultHandle) { }

	public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle) { }

	public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle) { }

	public static bool InspectItem(out SteamInventoryResult_t pResultHandle, string pchItemToken) { }

	public static bool LoadItemDefinitions() { }

	public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName) { }

	public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID) { }

	public static SteamAPICall_t RequestPrices() { }

	public static void SendItemDropHeartbeat() { }

	public static bool SerializeResult(SteamInventoryResult_t resultHandle, Byte[] pOutBuffer, out uint punOutBufferSize) { }

	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue) { }

	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue) { }

	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue) { }

	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue) { }

	public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

	public static SteamInventoryUpdateHandle_t StartUpdateProperties() { }

	public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle) { }

	public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, UInt32[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, UInt32[] pArrayGetQuantity, uint nArrayGetLength) { }

	public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest) { }

	public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition) { }

}

