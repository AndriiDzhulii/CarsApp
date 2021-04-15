<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CarsApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<h2>Cars</h2>
	<div class="cars-grid-container">
		<asp:GridView ID="gvCars"
			runat="server"
			AutoGenerateColumns="false"
			DataKeyNames="id"
			AllowPaging="true"
			DataSourceID="odsCars"
			PageSize="500"
			OnRowUpdating="gvCars_RowUpdating">
			<Columns>
				<asp:TemplateField>
					<HeaderTemplate>
						<asp:Label runat="server" Text="Id"></asp:Label>
					</HeaderTemplate>
					<ItemTemplate>
						<asp:Label runat="server" Text='<%#Eval("Id")%>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:Label ID="lblCarId" runat="server" Text='<%#Eval("Id")%>'></asp:Label>
					</EditItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField>
					<HeaderTemplate>
						<asp:Label runat="server" Text="Name"></asp:Label>
					</HeaderTemplate>
					<ItemTemplate>
						<asp:Label runat="server" Text='<%#Eval("Name")%>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:TextBox ID="tbName" runat="server" ValidationGroup="UpdateCar" Text='<%#Eval("Name")%>'></asp:TextBox>
						<asp:RequiredFieldValidator ID="rfvName" ValidationGroup="UpdateCar"
							ControlToValidate="tbName" runat="server"
							ErrorMessage="Field is required">
						</asp:RequiredFieldValidator>
					</EditItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField>
					<HeaderTemplate>
						<asp:Label runat="server" Text="Engine"></asp:Label>
					</HeaderTemplate>
					<ItemTemplate>
						<asp:Label runat="server" Text='<%#Eval("Engine.Name")%>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:DropDownList ID="ddlEngines" runat="server"
							SelectedValue='<%#Eval("Engine.Id")%>'
							DataSourceID="odsEngines"
							DataValueField="Id"
							DataTextField="Name">
						</asp:DropDownList>
					</EditItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField>
					<HeaderTemplate>
						<asp:Label runat="server" Text="Battery"></asp:Label>
					</HeaderTemplate>
					<ItemTemplate>
						<asp:Label runat="server" Text='<%#Eval("Battery.Name")%>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:DropDownList ID="ddlBatteries" runat="server"
							SelectedValue='<%#Eval("Battery.Id")%>'
							DataSourceID="odsBatteries"
							DataValueField="Id"
							DataTextField="Name">
						</asp:DropDownList>
					</EditItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField>
					<HeaderTemplate>
						<asp:Label runat="server" Text="Manufacturer"></asp:Label>
					</HeaderTemplate>
					<ItemTemplate>
						<asp:Label runat="server" Text='<%#Eval("Manufacturer.Name")%>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:DropDownList ID="ddlManufactures" runat="server"
							SelectedValue='<%#Eval("Manufacturer.Id")%>'
							DataSourceID="odsManufactures"
							DataValueField="Id"
							DataTextField="Name">
						</asp:DropDownList>
					</EditItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField>
					<HeaderTemplate>
						<asp:Label runat="server" Text="MaxSpeed"></asp:Label>
					</HeaderTemplate>
					<ItemTemplate>
						<asp:Label runat="server" Text='<%#Eval("MaxSpeed")%>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:TextBox ID="tbMaxSpeed" runat="server" ValidationGroup="UpdateCar" Text='<%#Eval("MaxSpeed")%>'></asp:TextBox>
						<asp:RegularExpressionValidator ID="revMaxSpeed" ValidationGroup="UpdateCar"
							ControlToValidate="tbMaxSpeed" runat="server"
							ErrorMessage="Expected value 1 - 1000"
							ValidationExpression="^([1-9][0-9]{0,2}|1000)$">
						</asp:RegularExpressionValidator>
						<asp:RequiredFieldValidator ID="rfvMaxSpeed" ValidationGroup="UpdateCar"
							ControlToValidate="tbMaxSpeed" runat="server"
							ErrorMessage="Expected value 1 - 1000">
						</asp:RequiredFieldValidator>
					</EditItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField>
					<HeaderTemplate>
						<asp:Label runat="server" Text="MaxSeats"></asp:Label>
					</HeaderTemplate>
					<ItemTemplate>
						<asp:Label runat="server" Text='<%#Eval("MaxSeats")%>'></asp:Label>
					</ItemTemplate>
					<EditItemTemplate>
						<asp:TextBox ID="tbMaxSeats" runat="server" ValidationGroup="UpdateCar" Text='<%#Eval("MaxSeats")%>'></asp:TextBox>
						<asp:RegularExpressionValidator ID="revMaxSeats" ValidationGroup="UpdateCar"
							ControlToValidate="tbMaxSeats" runat="server"
							ErrorMessage="Expected value 1 - 1000"
							ValidationExpression="^([1-9][0-9]{0,2}|1000)$">
						</asp:RegularExpressionValidator>
						<asp:RequiredFieldValidator ID="rfvMaxSeats" ValidationGroup="UpdateCar"
							ControlToValidate="tbMaxSeats" runat="server"
							ErrorMessage="Expected value 1 - 1000">
						</asp:RequiredFieldValidator>
					</EditItemTemplate>
				</asp:TemplateField>
				<asp:CommandField ShowEditButton="true" ValidationGroup="UpdateCar"/>
				<asp:CommandField ShowDeleteButton="true" />
			</Columns>
			<PagerSettings Mode="NumericFirstLast" />
		</asp:GridView>
	</div>
	<div class="add-car-container">
		<div>
			<asp:TextBox ID="tbName" runat="server" placeholder="Name" ValidationGroup="GroupAddCar"></asp:TextBox>
			<asp:RequiredFieldValidator ID="rfvName" ValidationGroup="GroupAddCar"
				ControlToValidate="tbName" runat="server"
				ErrorMessage="Field is required">
			</asp:RequiredFieldValidator>
		</div>
		<div class="labeled-in-line">
			<span>Engine:</span>
			<asp:DropDownList ID="ddlEngines" runat="server"
				DataSourceID="odsEngines"
				DataValueField="Id"
				DataTextField="Name">
			</asp:DropDownList>
		</div>
		<div class="labeled-in-line">
			<span>Battery:</span>
			<asp:DropDownList ID="ddlBatteries" runat="server"
				DataSourceID="odsBatteries"
				DataValueField="Id"
				DataTextField="Name">
			</asp:DropDownList>
		</div>
		<div class="labeled-in-line">
			<span>Manufacture:</span>
			<asp:DropDownList ID="ddlManufactures" runat="server"
				DataSourceID="odsManufactures"
				DataValueField="Id"
				DataTextField="Name">
			</asp:DropDownList>
		</div>
		<div>
			<asp:TextBox ID="tbMaxSpeed" runat="server" placeholder="Max speed" Text='0' ValidationGroup="GroupAddCar"></asp:TextBox>
			<asp:RegularExpressionValidator ID="revMaxSpeed" ValidationGroup="GroupAddCar"
				ControlToValidate="tbMaxSpeed" runat="server"
				ErrorMessage="Expected value 1 - 1000"
				ValidationExpression="^([1-9][0-9]{0,2}|1000)$">
			</asp:RegularExpressionValidator>
			<asp:RequiredFieldValidator ID="rfvMaxSpeed" ValidationGroup="GroupAddCar"
				ControlToValidate="tbMaxSpeed" runat="server"
				ErrorMessage="Expected value 1 - 1000">
			</asp:RequiredFieldValidator>
		</div>
		<div>
			<asp:TextBox ID="tbMaxSeats" runat="server" placeholder="Max seats" Text='0' ValidationGroup="GroupAddCar"></asp:TextBox>
			<asp:RegularExpressionValidator ID="revMaxSeats" ValidationGroup="GroupAddCar"
				ControlToValidate="tbMaxSeats" runat="server"
				ErrorMessage="Expected value 1 - 1000"
				ValidationExpression="^([1-9][0-9]{0,2}|1000)$">
			</asp:RegularExpressionValidator>
			<asp:RequiredFieldValidator ID="rfvMaxSeats" ValidationGroup="GroupAddCar"
				ControlToValidate="tbMaxSeats" runat="server"
				ErrorMessage="Expected value 1 - 1000">
			</asp:RequiredFieldValidator>
		</div>
		<asp:Button ID="btnAddCar" runat="server" Text="Add Car" OnClick="btnAddCar_Click"/>
	</div>

	<asp:ObjectDataSource ID="odsCars"
		runat="server"
		EnableCaching="false"
		EnablePaging="true"
		SelectMethod="Get"
		DeleteMethod="Delete"
		SelectCountMethod="GetTotalCount"
		UpdateMethod="Update"
		StartRowIndexParameterName="startRow"
		MaximumRowsParameterName="pageSize"
		TypeName="CarsApp.Infrastructure.DataSources.CarsDataSource"></asp:ObjectDataSource>
	<asp:ObjectDataSource ID="odsEngines" runat="server"
		SelectMethod="GetEngines"
		TypeName="CarsApp.Infrastructure.DataSources.CarAttributesDataSource"></asp:ObjectDataSource>

	<asp:ObjectDataSource ID="odsBatteries" runat="server"
		SelectMethod="GetBatteries"
		TypeName="CarsApp.Infrastructure.DataSources.CarAttributesDataSource"></asp:ObjectDataSource>

	<asp:ObjectDataSource ID="odsManufactures" runat="server"
		SelectMethod="GetManufactures"
		TypeName="CarsApp.Infrastructure.DataSources.CarAttributesDataSource"></asp:ObjectDataSource>
</asp:Content>
