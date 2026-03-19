using AutoMapper;
using SupplierHub.Models;


using SupplierHub.DTOs.SupplierDTO;
using SupplierHub.DTOs.OrganizationDTO;
using SupplierHub.DTOs.SupplierContactDTO;
using SupplierHub.DTOs.ComplianceDocDTO;
using SupplierHub.DTOs.SupplierRiskDTO;
using SupplierHub.DTOs.CategoryDTO;
using SupplierHub.DTOs.ItemDTO;
using SupplierHub.DTOs.CatalogDTO;
using SupplierHub.DTOs.CatalogItemDTO;
using SupplierHub.DTOs.ContractDTO;

namespace SupplierHub.MapProfile
{
	/// <summary>
	/// AutoMapper profile for mapping Entities ↔ DTOs
	/// </summary>
	public class ApplicationMapperProfile : Profile
	{
		public ApplicationMapperProfile()
		{
			
			// SUPPLIER
			CreateMap<Supplier, SupplierCreateDto>().ReverseMap();
			CreateMap<Supplier, UpdateSupplierDto>().ReverseMap();
			CreateMap<Supplier, GetSupplierByIdDto>().ReverseMap();
			CreateMap<Supplier, GetAllSupplierDto>().ReverseMap();
			CreateMap<Supplier, SupplierDeleteDto>().ReverseMap();

			
			// ORGANIZATION			
			CreateMap<Organization, OrganizationCreateDto>().ReverseMap();
			CreateMap<Organization, OrganizationUpdateDto>().ReverseMap();
			CreateMap<Organization, OrganizationGetByIdDto>().ReverseMap();
			CreateMap<Organization, OrganizationGetAllDto>().ReverseMap();
			CreateMap<Organization, OrganizationDeleteDto>().ReverseMap();

			
			// SUPPLIER CONTACT			
			CreateMap<SupplierContact, SupplierContactCreateDto>().ReverseMap();
			CreateMap<SupplierContact, SupplierContactUpdateDto>().ReverseMap();
			CreateMap<SupplierContact, SupplierContactGetByIdDto>().ReverseMap();
			CreateMap<SupplierContact, SupplierContactGetAllDto>().ReverseMap();
			CreateMap<SupplierContact, SupplierContactDeleteDto>().ReverseMap();

			
			// COMPLIANCE DOCUMENT			
			CreateMap<ComplianceDoc, ComplianceDocCreateDto>().ReverseMap();
			CreateMap<ComplianceDoc, ComplianceDocUpdateDto>().ReverseMap();
			CreateMap<ComplianceDoc, ComplianceDocGetByIdDto>().ReverseMap();
			CreateMap<ComplianceDoc, ComplianceDocGetAllDto>().ReverseMap();
			CreateMap<ComplianceDoc, ComplianceDocDeleteDto>().ReverseMap();

			
			// SUPPLIER RISK			
			CreateMap<SupplierRisk, SupplierRiskCreateDto>().ReverseMap();
			CreateMap<SupplierRisk, SupplierRiskUpdateDto>().ReverseMap();
			CreateMap<SupplierRisk, SupplierRiskGetByIdDto>().ReverseMap();
			CreateMap<SupplierRisk, SupplierRiskGetAllDto>().ReverseMap();
			CreateMap<SupplierRisk, SupplierRiskDeleteDto>().ReverseMap();

			
			// CATEGORY			
			CreateMap<Category, CategoryCreateDto>().ReverseMap();
			CreateMap<Category, CategoryUpdateDto>().ReverseMap();
			CreateMap<Category, CategoryGetByIdDto>().ReverseMap();
			CreateMap<Category, CategoryGetAllDto>().ReverseMap();
			CreateMap<Category, CategoryDeleteDto>().ReverseMap();

			
			// ITEM			
			CreateMap<Item, ItemCreateDto>().ReverseMap();
			CreateMap<Item, ItemUpdateDto>().ReverseMap();
			CreateMap<Item, ItemGetByIdDto>().ReverseMap();
			CreateMap<Item, ItemGetAllDto>().ReverseMap();
			CreateMap<Item, ItemDeleteDto>().ReverseMap();

			// CATALOG
			CreateMap<Catalog, CatalogCreateDto>().ReverseMap();
			CreateMap<Catalog, CatalogUpdateDto>().ReverseMap();
			CreateMap<Catalog, CatalogGetByIdDto>().ReverseMap();
			CreateMap<Catalog, CatalogGetAllDto>().ReverseMap();
			CreateMap<Catalog, CatalogDeleteDto>().ReverseMap();

			
			// CATALOG ITEM			
			CreateMap<CatalogItem, CatalogItemCreateDto>().ReverseMap();
			CreateMap<CatalogItem, CatalogItemUpdateDto>().ReverseMap();
			CreateMap<CatalogItem, CatalogItemGetByIdDto>().ReverseMap();
			CreateMap<CatalogItem, CatalogItemGetAllDto>().ReverseMap();
			CreateMap<CatalogItem, CatalogItemDeleteDto>().ReverseMap();

			
			// CONTRACT			
			CreateMap<Contract, ContractCreateDto>().ReverseMap();
			CreateMap<Contract, ContractUpdateDto>().ReverseMap();
			CreateMap<Contract, ContractGetByIdDto>().ReverseMap();
			CreateMap<Contract, ContractGetAllDto>().ReverseMap();
			CreateMap<Contract, ContractDeleteDto>().ReverseMap();
		}
	}
}