using AutoMapper;
using Cars.DataAccess.Interfaces;
using Cars.Models.Entities;
using Cars.Models.Models;
using Cars.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Cars.Services 
{
	public class CarAttributesService : EntityServiceBase<CarAttribute, ICarsAttributesRepository>, ICarAttributesService
	{
		private readonly IMapper _mapper;

		public CarAttributesService(ICarsAttributesRepository repository, IMapper mapper) : base(repository)
		{
			_mapper = mapper;
		}

		public List<CarAttributeModel> GetBatteries()
		{
			return Repository.FilterByType("Battery")
								.Select(e => _mapper.Map<CarAttributeModel>(e)).ToList();
		}

		public List<CarAttributeModel> GetEngines()
		{
			return Repository.FilterByType("Engine")
								.Select(e => _mapper.Map<CarAttributeModel>(e)).ToList();
		}

		public List<CarAttributeModel> GetManufactures()
		{
			return Repository.FilterByType("Manufacturer")
								.Select(e => _mapper.Map<CarAttributeModel>(e)).ToList();
		}
	}
}
