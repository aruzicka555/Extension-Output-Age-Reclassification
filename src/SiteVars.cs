//  Authors:  Robert M. Scheller, Jimm Domingo

using Landis.Core;
using Landis.SpatialModeling;
using Landis.Library.UniversalCohorts;

namespace Landis.Extension.Output.AgeReclass
{
    public static class SiteVars
    {
        private static ISiteVar<ISiteCohorts> cohorts;

        //---------------------------------------------------------------------

        public static void Initialize()
        {
            cohorts = PlugIn.ModelCore.GetSiteVar<ISiteCohorts>("Succession.UniversalCohorts");

        }

        //---------------------------------------------------------------------
        public static ISiteVar<ISiteCohorts> Cohorts
        {
            get
            {
                return cohorts;
            }
        }
    }
}
