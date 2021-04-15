using Cars.Services.Interfaces;
using Ninject;
using System;
using System.Web.UI.WebControls;
using CarsApp.Infrastructure.Extensions;
using Cars.Models.Models;

namespace CarsApp
{
	public partial class _Default : Ninject.Web.PageBase
	{
		[Inject]
		public ICarsService CarsService { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void gvCars_RowUpdating(object sender, GridViewUpdateEventArgs e)
		{
			Page.Validate("UpdateCar");

			if (!Page.IsValid)
			{
				return;
			}

			var row = gvCars.Rows[e.RowIndex];

			var id = row.FindControl<Label>("lblCarId").Text.ToInt();
			var endineId = row.FindControl<DropDownList>("ddlEngines").SelectedValue.ToInt();
			var batteryId = row.FindControl<DropDownList>("ddlBatteries").SelectedValue.ToInt();
			var manufactureId = row.FindControl<DropDownList>("ddlManufactures").SelectedValue.ToInt();
			var carName = row.FindControl<TextBox>("tbName").Text;
			var maxSpeed = row.FindControl<TextBox>("tbMaxSpeed").Text.ToInt();
			var maxSeats = row.FindControl<TextBox>("tbMaxSeats").Text.ToInt();

			var carModel = new CarModel(endineId, batteryId, manufactureId)
			{
				Id = id,
				Name = carName,
				MaxSpeed = maxSpeed,
				MaxSeats = maxSeats
			};

			CarsService.Save(carModel);
		}

		protected void btnAddCar_Click(object sender, EventArgs e)
		{
			Page.Validate("GroupAddCar");

			if (!Page.IsValid)
			{
				return;
			}

			var endineId = ddlEngines.SelectedValue.ToInt();
			var batteryId = ddlBatteries.SelectedValue.ToInt();
			var manufactureId = ddlManufactures.SelectedValue.ToInt();

			var carModel = new CarModel(endineId, batteryId, manufactureId)
			{
				Name = tbName.Text,
				MaxSpeed = tbMaxSpeed.Text.ToInt(),
				MaxSeats = tbMaxSeats.Text.ToInt()
			};

			CarsService.Save(carModel);
			gvCars.DataBind();
		}
	}
}