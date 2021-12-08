using System;

namespace SampleLibrary
{
    public class ParcelTracking
    {
        public bool CheckParcelNumber
            (string parcelNumber)
        {
            return parcelNumber
                .StartsWith("BLR"
                ,StringComparison.OrdinalIgnoreCase);
        }
    }
}
