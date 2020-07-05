using System.Collections.Generic;
using FiCalc.Server.Models;

namespace FiCalc.Server.Helper
{

    // These are for 2020
    public static class TaxBandHelper
    {
        public static List<TaxBand> SingleBands()
        {
            return new List<TaxBand>
            {
                new TaxBand {Lower = 0m, Upper = 9875m, Rate = 0.1m},
                new TaxBand {Lower = 9875m, Upper = 40125m, Rate = 0.12m},
                new TaxBand {Lower = 40126m, Upper = 85525m, Rate = 0.22m},
                new TaxBand {Lower = 85526m, Upper = 163300m, Rate = 0.24m},
                new TaxBand {Lower = 163301m, Upper = 207350m, Rate = 0.32m},
                new TaxBand {Lower = 207351m, Upper = 518400m, Rate = 0.35m},
                new TaxBand {Lower = 518401m, Upper = 1000000000m, Rate = 0.37m}
            };
        }

        public static List<TaxBand> MarriedJointBands()
        {
            return new List<TaxBand>
            {
                new TaxBand {Lower = 0m, Upper = 19750m, Rate = 0.1m},
                new TaxBand {Lower = 19751m, Upper = 80250m, Rate = 0.12m},
                new TaxBand {Lower = 80251m, Upper = 171050m, Rate = 0.22m},
                new TaxBand {Lower = 171051m, Upper = 326600m, Rate = 0.24m},
                new TaxBand {Lower = 326601m, Upper = 414700m, Rate = 0.32m},
                new TaxBand {Lower = 414701m, Upper = 622050m, Rate = 0.35m},
                new TaxBand {Lower = 622051m, Upper = 1000000000m, Rate = 0.37m}
            };
        }
    }
}