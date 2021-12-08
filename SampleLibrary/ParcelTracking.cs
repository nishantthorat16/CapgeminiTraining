using System;

namespace SampleLibrary
{
    public class ParcelTracking
    {
        public bool CheckParcelNumber
            (string parcelNumber)
        {
            return parcelNumber.Trim()
                .StartsWith("BLR"
                ,StringComparison.OrdinalIgnoreCase);
        }
    }
}
