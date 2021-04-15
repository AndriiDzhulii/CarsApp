using AutoMapper;
using Cars.DataAccess.Interfaces;
using Cars.Models.Entities;
using Cars.Models.Models;
using Cars.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Cars.Services
{
	public class CarsService : EntityServiceBase<Car, ICarsRepository>, ICarsService
	{
		private readonly IMapper _mapper;

		public CarsService(ICarsRepository repository, IMapper mapper) : base(repository)
		{
			_mapper = mapper;
		}

		public List<CarModel> Filter(int pageNumber, int pageSize)
		{
			return Repository.Filter(pageNumber, pageSize).Select(e => _mapper.Map<CarModel>(e)).ToList();
		}

		public void Save(CarModel model)
		{
			var entity = new Car();

			if (model.Id > 0)
			{
				entity = Repository.GetById(model.Id);

				_mapper.Map(model, entity);

				Repository.Update(entity);
			}
			else
			{
				_mapper.Map(model, entity);

				entity.Id = Repository.GetNewId();

				Repository.Create(entity);
			}
		}
	}
}
