using FrotaApp.Domain.Entities;
using FrotaApp.Infrastructure.Shared.Shared;

namespace FrotaApp.Infrastructure.Input.Queries
{
    public class VehicleQuery : BaseQuery
    {
        public QueryModel InsertVehicleQuery(VehicleEntity vehicle)
        {
            this.Table = Map.GetVehicleTable();
            this.Query = $@"
                INSERT INTO {this.Table}
                VALUES
                (
                    @Name,
                    @Color,
                    @ModelYear,
                    @CategoryId,
                    @Price,
                    @Type,
                    @CreatedOn
                )
            ";

            this.Parameters = new
            {
                Name = vehicle.Name,
                Color = vehicle.Color,
                ModelYear = vehicle.ModelYear,
                CategoryId = vehicle.CategoryId,
                Price = vehicle.Price,
                Type = vehicle.Type,  // Enum (int)
                CreatedOn = vehicle.CreatedOn
            };

            return new QueryModel(this.Query, this.Parameters);
        }
    }
}