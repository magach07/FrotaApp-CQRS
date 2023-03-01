using FrotaApp.Domain.Entities;
using FrotaApp.Domain.Spec;

namespace FrotaApp.Domain.Specs
{
    public class IsTaxExemptOn2023 : ISpec<VehicleEntity>
    {
        public bool IsSatifiedBy(VehicleEntity candidate)
        {
            return (candidate.ModelYear < (System.DateTime.Now.Year - 20) ? true : false);
        }
    }
}