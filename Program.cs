// Fill values to guidList
// Result will define if all strings are guids, or list you all invalid strings

List<string> guidList = new List<string>()
{
    "0DCB222C-7042-4DE0-B01C-F8EAC1D103E6",
    "040C5CD9-E4CD-450F-A0D1-6E36D7E55BBB"
};

List<string> invalidGuidList = new List<string>();
foreach (var guid in guidList)
{
    if (!Guid.TryParse(guid, out Guid result))
    {
        invalidGuidList.Add(guid);
    }
}

if (invalidGuidList.Count == 0)
{
    Console.WriteLine("OK!");
}
else
{
    Console.WriteLine("FAIL: List has invalid records:");
    foreach (var invalidGuid in invalidGuidList)
    {
        Console.WriteLine(invalidGuid);
    }
}
